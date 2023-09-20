using System;
using System.Diagnostics;
using System.Security.Authentication;
using MassTransit;
using Microsoft.Extensions.Hosting;

namespace StartupTime
{
    class Program
    {
        public static void Main(string[] args)
        {
            string netVersion = AppDomain.CurrentDomain.SetupInformation.TargetFrameworkName;
            Console.WriteLine(netVersion);
            Console.WriteLine();

            IHost host = Host.CreateDefaultBuilder(args)
                .ConfigureServices(services =>
                {
                    services.AddMassTransit(x =>
                    {
                        x.AddSagaStateMachinesFromNamespaceContaining<Program>();

                        x.UsingRabbitMq((context, cfg) =>
                        {
                            using (var timer = new InTimer())
                            {
                                cfg.Host(new Uri($"rabbitmq://{Environment.MachineName}:5673/Schleupen-CS-PI-SB-MessageBus"),
                                    "WorkflowHost (Repro)",
                                    h =>
                                    {
                                        h.Username("dev");
                                        h.Password("dev");
                                        h.Heartbeat(TimeSpan.FromSeconds(Debugger.IsAttached ? 300 : 30));
                                        h.UseSsl(s =>
                                        {
                                            s.Protocol = SslProtocols.Tls12;
                                        });
                                    });

                                cfg.UseKillSwitch(options =>
                                {
                                    options.SetTrackingPeriod(m: 15);
                                    options.SetRestartTimeout(m: 1);
                                });

                                cfg.UseMessageRetry(r => r.Interval(5, 1000));
                                cfg.UseMessageScope(context);
                                cfg.UseInMemoryOutbox(context);

                                cfg.ConfigureEndpoints(context);
                            }
                        });
                    });
                })
                .Build();

            host.Run();
        }
    }

    class InTimer :
        IDisposable
    {
        readonly Stopwatch _timer = Stopwatch.StartNew();

        public void Dispose()
        {
            _timer.Stop();
            Console.WriteLine("Configuration elapsed time: {0}", _timer.Elapsed);
        }
    }
}