using MassTransit;

namespace StartupTime;

public class Start
{
    public Guid CorrelationId { get; set; }
}

public class StartCompleted
{
    public Guid CorrelationId { get; set; }
}

public class SpeedIncreased
{
    public Guid CorrelationId { get; set; }
}

public class SpeedDecreased
{
    public Guid CorrelationId { get; set; }
}

public class ShotTaken
{
    public Guid CorrelationId { get; set; }
}

public class RequestA
{
    public Guid CorrelationId { get; set; }
}

public class ResponseA
{
    public Guid CorrelationId { get; set; }
}

public class RequestB
{
    public Guid CorrelationId { get; set; }
}

public class ResponseB
{
    public Guid CorrelationId { get; set; }
}

public class SampleStateMachineInstance :
    SagaStateMachineInstance
{
    public int CurrentState { get; set; }
    public Guid CorrelationId { get; set; }
}

public class SampleStateMachine :
    MassTransitStateMachine<SampleStateMachineInstance>
{
    public SampleStateMachine()
    {
        InstanceState(x => x.CurrentState, Starting, Started, Running, Walking, Sipping, Stalking);

        Request(() => ShotRequest, x => x.Timeout = TimeSpan.Zero);

        Initially(
            When(Start)
                .TransitionTo(Starting));

        During(Starting,
            When(StartCompleted)
                .TransitionTo(Started));
        During(Started,
            When(SpeedIncreased)
                .TransitionTo(Running));
        During(Running,
            When(SpeedDecreased)
                .TransitionTo(Walking));
        DuringAny(
            When(ShotTaken)
                .Request(ShotRequest, context => new RequestA()),
            When(ShotRequest.Completed)
                .Then(_ => { }),
            When(ShotRequest.Faulted)
                .Then(_ => { }));
    }

    public Request<SampleStateMachineInstance, RequestA, ResponseA> ShotRequest { get; } = null!;

    public Event<Start> Start { get; } = null!;
    public Event<StartCompleted> StartCompleted { get; } = null!;
    public Event<SpeedIncreased> SpeedIncreased { get; } = null!;
    public Event<SpeedDecreased> SpeedDecreased { get; } = null!;
    public Event<ShotTaken> ShotTaken { get; } = null!;

    public State Starting { get; } = null!;
    public State Started { get; } = null!;
    public State Running { get; } = null!;
    public State Walking { get; } = null!;
    public State Sipping { get; } = null!;
    public State Stalking { get; } = null!;
}