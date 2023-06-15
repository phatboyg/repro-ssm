using System.Diagnostics;
using MassTransit;
using StartupTime;

IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices(services =>
    {
        services.AddMassTransit(x =>
        {
            x.AddSagaStateMachinesFromNamespaceContaining<SampleStateMachine>();

            x.UsingRabbitMq((context, cfg) =>
            {
                using var timer = new InTimer();
                
                cfg.UseKillSwitch(options =>
                {
                    options.SetTrackingPeriod(m: 15);
                    options.SetRestartTimeout(m: 1);
                });

                cfg.UseMessageRetry(r => r.Interval(5, 1000));
                cfg.UseMessageScope(context);
                cfg.UseInMemoryOutbox(context);

                cfg.ConfigureEndpoints(context);
            });
        });
    })
    .Build();

// var template = new StateMachines();
// Console.WriteLine(template.TransformText());

host.Run();


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