Building...


using MassTransit;

namespace StartupTime;


public class Start1
{
    public Guid CorrelationId { get; set; }
}

public class StartCompleted1
{
    public Guid CorrelationId { get; set; }
}

public class SpeedIncreased1
{
    public Guid CorrelationId { get; set; }
}

public class SpeedDecreased1
{
    public Guid CorrelationId { get; set; }
}

public class ShotTaken1
{
    public Guid CorrelationId { get; set; }
}

public class RequestA1
{
    public Guid CorrelationId { get; set; }
}

public class ResponseA1
{
    public Guid CorrelationId { get; set; }
}

public class RequestB1
{
    public Guid CorrelationId { get; set; }
}

public class ResponseB1
{
    public Guid CorrelationId { get; set; }
}

public class SampleStateMachineInstance1 :
    SagaStateMachineInstance
{
    public int CurrentState { get; set; }
    public Guid CorrelationId { get; set; }
}

public class SampleStateMachine1 :
    MassTransitStateMachine<SampleStateMachineInstance1>
{
    public SampleStateMachine1()
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
                .Request(ShotRequest, context => new RequestA1()),
            When(ShotRequest.Completed)
                .Then(_ => { }),
            When(ShotRequest.Faulted)
                .Then(_ => { }));
    }

    public Request<SampleStateMachineInstance1, RequestA1, ResponseA1> ShotRequest { get; } = null!;

    public Event<Start1> Start { get; } = null!;
    public Event<StartCompleted1> StartCompleted { get; } = null!;
    public Event<SpeedIncreased1> SpeedIncreased { get; } = null!;
    public Event<SpeedDecreased1> SpeedDecreased { get; } = null!;
    public Event<ShotTaken1> ShotTaken { get; } = null!;

    public State Starting { get; } = null!;
    public State Started { get; } = null!;
    public State Running { get; } = null!;
    public State Walking { get; } = null!;
    public State Sipping { get; } = null!;
    public State Stalking { get; } = null!;
}


public class Start2
{
    public Guid CorrelationId { get; set; }
}

public class StartCompleted2
{
    public Guid CorrelationId { get; set; }
}

public class SpeedIncreased2
{
    public Guid CorrelationId { get; set; }
}

public class SpeedDecreased2
{
    public Guid CorrelationId { get; set; }
}

public class ShotTaken2
{
    public Guid CorrelationId { get; set; }
}

public class RequestA2
{
    public Guid CorrelationId { get; set; }
}

public class ResponseA2
{
    public Guid CorrelationId { get; set; }
}

public class RequestB2
{
    public Guid CorrelationId { get; set; }
}

public class ResponseB2
{
    public Guid CorrelationId { get; set; }
}

public class SampleStateMachineInstance2 :
    SagaStateMachineInstance
{
    public int CurrentState { get; set; }
    public Guid CorrelationId { get; set; }
}

public class SampleStateMachine2 :
    MassTransitStateMachine<SampleStateMachineInstance2>
{
    public SampleStateMachine2()
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
                .Request(ShotRequest, context => new RequestA2()),
            When(ShotRequest.Completed)
                .Then(_ => { }),
            When(ShotRequest.Faulted)
                .Then(_ => { }));
    }

    public Request<SampleStateMachineInstance2, RequestA2, ResponseA2> ShotRequest { get; } = null!;

    public Event<Start2> Start { get; } = null!;
    public Event<StartCompleted2> StartCompleted { get; } = null!;
    public Event<SpeedIncreased2> SpeedIncreased { get; } = null!;
    public Event<SpeedDecreased2> SpeedDecreased { get; } = null!;
    public Event<ShotTaken2> ShotTaken { get; } = null!;

    public State Starting { get; } = null!;
    public State Started { get; } = null!;
    public State Running { get; } = null!;
    public State Walking { get; } = null!;
    public State Sipping { get; } = null!;
    public State Stalking { get; } = null!;
}


public class Start3
{
    public Guid CorrelationId { get; set; }
}

public class StartCompleted3
{
    public Guid CorrelationId { get; set; }
}

public class SpeedIncreased3
{
    public Guid CorrelationId { get; set; }
}

public class SpeedDecreased3
{
    public Guid CorrelationId { get; set; }
}

public class ShotTaken3
{
    public Guid CorrelationId { get; set; }
}

public class RequestA3
{
    public Guid CorrelationId { get; set; }
}

public class ResponseA3
{
    public Guid CorrelationId { get; set; }
}

public class RequestB3
{
    public Guid CorrelationId { get; set; }
}

public class ResponseB3
{
    public Guid CorrelationId { get; set; }
}

public class SampleStateMachineInstance3 :
    SagaStateMachineInstance
{
    public int CurrentState { get; set; }
    public Guid CorrelationId { get; set; }
}

public class SampleStateMachine3 :
    MassTransitStateMachine<SampleStateMachineInstance3>
{
    public SampleStateMachine3()
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
                .Request(ShotRequest, context => new RequestA3()),
            When(ShotRequest.Completed)
                .Then(_ => { }),
            When(ShotRequest.Faulted)
                .Then(_ => { }));
    }

    public Request<SampleStateMachineInstance3, RequestA3, ResponseA3> ShotRequest { get; } = null!;

    public Event<Start3> Start { get; } = null!;
    public Event<StartCompleted3> StartCompleted { get; } = null!;
    public Event<SpeedIncreased3> SpeedIncreased { get; } = null!;
    public Event<SpeedDecreased3> SpeedDecreased { get; } = null!;
    public Event<ShotTaken3> ShotTaken { get; } = null!;

    public State Starting { get; } = null!;
    public State Started { get; } = null!;
    public State Running { get; } = null!;
    public State Walking { get; } = null!;
    public State Sipping { get; } = null!;
    public State Stalking { get; } = null!;
}


public class Start4
{
    public Guid CorrelationId { get; set; }
}

public class StartCompleted4
{
    public Guid CorrelationId { get; set; }
}

public class SpeedIncreased4
{
    public Guid CorrelationId { get; set; }
}

public class SpeedDecreased4
{
    public Guid CorrelationId { get; set; }
}

public class ShotTaken4
{
    public Guid CorrelationId { get; set; }
}

public class RequestA4
{
    public Guid CorrelationId { get; set; }
}

public class ResponseA4
{
    public Guid CorrelationId { get; set; }
}

public class RequestB4
{
    public Guid CorrelationId { get; set; }
}

public class ResponseB4
{
    public Guid CorrelationId { get; set; }
}

public class SampleStateMachineInstance4 :
    SagaStateMachineInstance
{
    public int CurrentState { get; set; }
    public Guid CorrelationId { get; set; }
}

public class SampleStateMachine4 :
    MassTransitStateMachine<SampleStateMachineInstance4>
{
    public SampleStateMachine4()
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
                .Request(ShotRequest, context => new RequestA4()),
            When(ShotRequest.Completed)
                .Then(_ => { }),
            When(ShotRequest.Faulted)
                .Then(_ => { }));
    }

    public Request<SampleStateMachineInstance4, RequestA4, ResponseA4> ShotRequest { get; } = null!;

    public Event<Start4> Start { get; } = null!;
    public Event<StartCompleted4> StartCompleted { get; } = null!;
    public Event<SpeedIncreased4> SpeedIncreased { get; } = null!;
    public Event<SpeedDecreased4> SpeedDecreased { get; } = null!;
    public Event<ShotTaken4> ShotTaken { get; } = null!;

    public State Starting { get; } = null!;
    public State Started { get; } = null!;
    public State Running { get; } = null!;
    public State Walking { get; } = null!;
    public State Sipping { get; } = null!;
    public State Stalking { get; } = null!;
}


public class Start5
{
    public Guid CorrelationId { get; set; }
}

public class StartCompleted5
{
    public Guid CorrelationId { get; set; }
}

public class SpeedIncreased5
{
    public Guid CorrelationId { get; set; }
}

public class SpeedDecreased5
{
    public Guid CorrelationId { get; set; }
}

public class ShotTaken5
{
    public Guid CorrelationId { get; set; }
}

public class RequestA5
{
    public Guid CorrelationId { get; set; }
}

public class ResponseA5
{
    public Guid CorrelationId { get; set; }
}

public class RequestB5
{
    public Guid CorrelationId { get; set; }
}

public class ResponseB5
{
    public Guid CorrelationId { get; set; }
}

public class SampleStateMachineInstance5 :
    SagaStateMachineInstance
{
    public int CurrentState { get; set; }
    public Guid CorrelationId { get; set; }
}

public class SampleStateMachine5 :
    MassTransitStateMachine<SampleStateMachineInstance5>
{
    public SampleStateMachine5()
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
                .Request(ShotRequest, context => new RequestA5()),
            When(ShotRequest.Completed)
                .Then(_ => { }),
            When(ShotRequest.Faulted)
                .Then(_ => { }));
    }

    public Request<SampleStateMachineInstance5, RequestA5, ResponseA5> ShotRequest { get; } = null!;

    public Event<Start5> Start { get; } = null!;
    public Event<StartCompleted5> StartCompleted { get; } = null!;
    public Event<SpeedIncreased5> SpeedIncreased { get; } = null!;
    public Event<SpeedDecreased5> SpeedDecreased { get; } = null!;
    public Event<ShotTaken5> ShotTaken { get; } = null!;

    public State Starting { get; } = null!;
    public State Started { get; } = null!;
    public State Running { get; } = null!;
    public State Walking { get; } = null!;
    public State Sipping { get; } = null!;
    public State Stalking { get; } = null!;
}


public class Start6
{
    public Guid CorrelationId { get; set; }
}

public class StartCompleted6
{
    public Guid CorrelationId { get; set; }
}

public class SpeedIncreased6
{
    public Guid CorrelationId { get; set; }
}

public class SpeedDecreased6
{
    public Guid CorrelationId { get; set; }
}

public class ShotTaken6
{
    public Guid CorrelationId { get; set; }
}

public class RequestA6
{
    public Guid CorrelationId { get; set; }
}

public class ResponseA6
{
    public Guid CorrelationId { get; set; }
}

public class RequestB6
{
    public Guid CorrelationId { get; set; }
}

public class ResponseB6
{
    public Guid CorrelationId { get; set; }
}

public class SampleStateMachineInstance6 :
    SagaStateMachineInstance
{
    public int CurrentState { get; set; }
    public Guid CorrelationId { get; set; }
}

public class SampleStateMachine6 :
    MassTransitStateMachine<SampleStateMachineInstance6>
{
    public SampleStateMachine6()
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
                .Request(ShotRequest, context => new RequestA6()),
            When(ShotRequest.Completed)
                .Then(_ => { }),
            When(ShotRequest.Faulted)
                .Then(_ => { }));
    }

    public Request<SampleStateMachineInstance6, RequestA6, ResponseA6> ShotRequest { get; } = null!;

    public Event<Start6> Start { get; } = null!;
    public Event<StartCompleted6> StartCompleted { get; } = null!;
    public Event<SpeedIncreased6> SpeedIncreased { get; } = null!;
    public Event<SpeedDecreased6> SpeedDecreased { get; } = null!;
    public Event<ShotTaken6> ShotTaken { get; } = null!;

    public State Starting { get; } = null!;
    public State Started { get; } = null!;
    public State Running { get; } = null!;
    public State Walking { get; } = null!;
    public State Sipping { get; } = null!;
    public State Stalking { get; } = null!;
}


public class Start7
{
    public Guid CorrelationId { get; set; }
}

public class StartCompleted7
{
    public Guid CorrelationId { get; set; }
}

public class SpeedIncreased7
{
    public Guid CorrelationId { get; set; }
}

public class SpeedDecreased7
{
    public Guid CorrelationId { get; set; }
}

public class ShotTaken7
{
    public Guid CorrelationId { get; set; }
}

public class RequestA7
{
    public Guid CorrelationId { get; set; }
}

public class ResponseA7
{
    public Guid CorrelationId { get; set; }
}

public class RequestB7
{
    public Guid CorrelationId { get; set; }
}

public class ResponseB7
{
    public Guid CorrelationId { get; set; }
}

public class SampleStateMachineInstance7 :
    SagaStateMachineInstance
{
    public int CurrentState { get; set; }
    public Guid CorrelationId { get; set; }
}

public class SampleStateMachine7 :
    MassTransitStateMachine<SampleStateMachineInstance7>
{
    public SampleStateMachine7()
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
                .Request(ShotRequest, context => new RequestA7()),
            When(ShotRequest.Completed)
                .Then(_ => { }),
            When(ShotRequest.Faulted)
                .Then(_ => { }));
    }

    public Request<SampleStateMachineInstance7, RequestA7, ResponseA7> ShotRequest { get; } = null!;

    public Event<Start7> Start { get; } = null!;
    public Event<StartCompleted7> StartCompleted { get; } = null!;
    public Event<SpeedIncreased7> SpeedIncreased { get; } = null!;
    public Event<SpeedDecreased7> SpeedDecreased { get; } = null!;
    public Event<ShotTaken7> ShotTaken { get; } = null!;

    public State Starting { get; } = null!;
    public State Started { get; } = null!;
    public State Running { get; } = null!;
    public State Walking { get; } = null!;
    public State Sipping { get; } = null!;
    public State Stalking { get; } = null!;
}


public class Start8
{
    public Guid CorrelationId { get; set; }
}

public class StartCompleted8
{
    public Guid CorrelationId { get; set; }
}

public class SpeedIncreased8
{
    public Guid CorrelationId { get; set; }
}

public class SpeedDecreased8
{
    public Guid CorrelationId { get; set; }
}

public class ShotTaken8
{
    public Guid CorrelationId { get; set; }
}

public class RequestA8
{
    public Guid CorrelationId { get; set; }
}

public class ResponseA8
{
    public Guid CorrelationId { get; set; }
}

public class RequestB8
{
    public Guid CorrelationId { get; set; }
}

public class ResponseB8
{
    public Guid CorrelationId { get; set; }
}

public class SampleStateMachineInstance8 :
    SagaStateMachineInstance
{
    public int CurrentState { get; set; }
    public Guid CorrelationId { get; set; }
}

public class SampleStateMachine8 :
    MassTransitStateMachine<SampleStateMachineInstance8>
{
    public SampleStateMachine8()
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
                .Request(ShotRequest, context => new RequestA8()),
            When(ShotRequest.Completed)
                .Then(_ => { }),
            When(ShotRequest.Faulted)
                .Then(_ => { }));
    }

    public Request<SampleStateMachineInstance8, RequestA8, ResponseA8> ShotRequest { get; } = null!;

    public Event<Start8> Start { get; } = null!;
    public Event<StartCompleted8> StartCompleted { get; } = null!;
    public Event<SpeedIncreased8> SpeedIncreased { get; } = null!;
    public Event<SpeedDecreased8> SpeedDecreased { get; } = null!;
    public Event<ShotTaken8> ShotTaken { get; } = null!;

    public State Starting { get; } = null!;
    public State Started { get; } = null!;
    public State Running { get; } = null!;
    public State Walking { get; } = null!;
    public State Sipping { get; } = null!;
    public State Stalking { get; } = null!;
}


public class Start9
{
    public Guid CorrelationId { get; set; }
}

public class StartCompleted9
{
    public Guid CorrelationId { get; set; }
}

public class SpeedIncreased9
{
    public Guid CorrelationId { get; set; }
}

public class SpeedDecreased9
{
    public Guid CorrelationId { get; set; }
}

public class ShotTaken9
{
    public Guid CorrelationId { get; set; }
}

public class RequestA9
{
    public Guid CorrelationId { get; set; }
}

public class ResponseA9
{
    public Guid CorrelationId { get; set; }
}

public class RequestB9
{
    public Guid CorrelationId { get; set; }
}

public class ResponseB9
{
    public Guid CorrelationId { get; set; }
}

public class SampleStateMachineInstance9 :
    SagaStateMachineInstance
{
    public int CurrentState { get; set; }
    public Guid CorrelationId { get; set; }
}

public class SampleStateMachine9 :
    MassTransitStateMachine<SampleStateMachineInstance9>
{
    public SampleStateMachine9()
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
                .Request(ShotRequest, context => new RequestA9()),
            When(ShotRequest.Completed)
                .Then(_ => { }),
            When(ShotRequest.Faulted)
                .Then(_ => { }));
    }

    public Request<SampleStateMachineInstance9, RequestA9, ResponseA9> ShotRequest { get; } = null!;

    public Event<Start9> Start { get; } = null!;
    public Event<StartCompleted9> StartCompleted { get; } = null!;
    public Event<SpeedIncreased9> SpeedIncreased { get; } = null!;
    public Event<SpeedDecreased9> SpeedDecreased { get; } = null!;
    public Event<ShotTaken9> ShotTaken { get; } = null!;

    public State Starting { get; } = null!;
    public State Started { get; } = null!;
    public State Running { get; } = null!;
    public State Walking { get; } = null!;
    public State Sipping { get; } = null!;
    public State Stalking { get; } = null!;
}


public class Start10
{
    public Guid CorrelationId { get; set; }
}

public class StartCompleted10
{
    public Guid CorrelationId { get; set; }
}

public class SpeedIncreased10
{
    public Guid CorrelationId { get; set; }
}

public class SpeedDecreased10
{
    public Guid CorrelationId { get; set; }
}

public class ShotTaken10
{
    public Guid CorrelationId { get; set; }
}

public class RequestA10
{
    public Guid CorrelationId { get; set; }
}

public class ResponseA10
{
    public Guid CorrelationId { get; set; }
}

public class RequestB10
{
    public Guid CorrelationId { get; set; }
}

public class ResponseB10
{
    public Guid CorrelationId { get; set; }
}

public class SampleStateMachineInstance10 :
    SagaStateMachineInstance
{
    public int CurrentState { get; set; }
    public Guid CorrelationId { get; set; }
}

public class SampleStateMachine10 :
    MassTransitStateMachine<SampleStateMachineInstance10>
{
    public SampleStateMachine10()
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
                .Request(ShotRequest, context => new RequestA10()),
            When(ShotRequest.Completed)
                .Then(_ => { }),
            When(ShotRequest.Faulted)
                .Then(_ => { }));
    }

    public Request<SampleStateMachineInstance10, RequestA10, ResponseA10> ShotRequest { get; } = null!;

    public Event<Start10> Start { get; } = null!;
    public Event<StartCompleted10> StartCompleted { get; } = null!;
    public Event<SpeedIncreased10> SpeedIncreased { get; } = null!;
    public Event<SpeedDecreased10> SpeedDecreased { get; } = null!;
    public Event<ShotTaken10> ShotTaken { get; } = null!;

    public State Starting { get; } = null!;
    public State Started { get; } = null!;
    public State Running { get; } = null!;
    public State Walking { get; } = null!;
    public State Sipping { get; } = null!;
    public State Stalking { get; } = null!;
}


public class Start11
{
    public Guid CorrelationId { get; set; }
}

public class StartCompleted11
{
    public Guid CorrelationId { get; set; }
}

public class SpeedIncreased11
{
    public Guid CorrelationId { get; set; }
}

public class SpeedDecreased11
{
    public Guid CorrelationId { get; set; }
}

public class ShotTaken11
{
    public Guid CorrelationId { get; set; }
}

public class RequestA11
{
    public Guid CorrelationId { get; set; }
}

public class ResponseA11
{
    public Guid CorrelationId { get; set; }
}

public class RequestB11
{
    public Guid CorrelationId { get; set; }
}

public class ResponseB11
{
    public Guid CorrelationId { get; set; }
}

public class SampleStateMachineInstance11 :
    SagaStateMachineInstance
{
    public int CurrentState { get; set; }
    public Guid CorrelationId { get; set; }
}

public class SampleStateMachine11 :
    MassTransitStateMachine<SampleStateMachineInstance11>
{
    public SampleStateMachine11()
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
                .Request(ShotRequest, context => new RequestA11()),
            When(ShotRequest.Completed)
                .Then(_ => { }),
            When(ShotRequest.Faulted)
                .Then(_ => { }));
    }

    public Request<SampleStateMachineInstance11, RequestA11, ResponseA11> ShotRequest { get; } = null!;

    public Event<Start11> Start { get; } = null!;
    public Event<StartCompleted11> StartCompleted { get; } = null!;
    public Event<SpeedIncreased11> SpeedIncreased { get; } = null!;
    public Event<SpeedDecreased11> SpeedDecreased { get; } = null!;
    public Event<ShotTaken11> ShotTaken { get; } = null!;

    public State Starting { get; } = null!;
    public State Started { get; } = null!;
    public State Running { get; } = null!;
    public State Walking { get; } = null!;
    public State Sipping { get; } = null!;
    public State Stalking { get; } = null!;
}


public class Start12
{
    public Guid CorrelationId { get; set; }
}

public class StartCompleted12
{
    public Guid CorrelationId { get; set; }
}

public class SpeedIncreased12
{
    public Guid CorrelationId { get; set; }
}

public class SpeedDecreased12
{
    public Guid CorrelationId { get; set; }
}

public class ShotTaken12
{
    public Guid CorrelationId { get; set; }
}

public class RequestA12
{
    public Guid CorrelationId { get; set; }
}

public class ResponseA12
{
    public Guid CorrelationId { get; set; }
}

public class RequestB12
{
    public Guid CorrelationId { get; set; }
}

public class ResponseB12
{
    public Guid CorrelationId { get; set; }
}

public class SampleStateMachineInstance12 :
    SagaStateMachineInstance
{
    public int CurrentState { get; set; }
    public Guid CorrelationId { get; set; }
}

public class SampleStateMachine12 :
    MassTransitStateMachine<SampleStateMachineInstance12>
{
    public SampleStateMachine12()
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
                .Request(ShotRequest, context => new RequestA12()),
            When(ShotRequest.Completed)
                .Then(_ => { }),
            When(ShotRequest.Faulted)
                .Then(_ => { }));
    }

    public Request<SampleStateMachineInstance12, RequestA12, ResponseA12> ShotRequest { get; } = null!;

    public Event<Start12> Start { get; } = null!;
    public Event<StartCompleted12> StartCompleted { get; } = null!;
    public Event<SpeedIncreased12> SpeedIncreased { get; } = null!;
    public Event<SpeedDecreased12> SpeedDecreased { get; } = null!;
    public Event<ShotTaken12> ShotTaken { get; } = null!;

    public State Starting { get; } = null!;
    public State Started { get; } = null!;
    public State Running { get; } = null!;
    public State Walking { get; } = null!;
    public State Sipping { get; } = null!;
    public State Stalking { get; } = null!;
}


public class Start13
{
    public Guid CorrelationId { get; set; }
}

public class StartCompleted13
{
    public Guid CorrelationId { get; set; }
}

public class SpeedIncreased13
{
    public Guid CorrelationId { get; set; }
}

public class SpeedDecreased13
{
    public Guid CorrelationId { get; set; }
}

public class ShotTaken13
{
    public Guid CorrelationId { get; set; }
}

public class RequestA13
{
    public Guid CorrelationId { get; set; }
}

public class ResponseA13
{
    public Guid CorrelationId { get; set; }
}

public class RequestB13
{
    public Guid CorrelationId { get; set; }
}

public class ResponseB13
{
    public Guid CorrelationId { get; set; }
}

public class SampleStateMachineInstance13 :
    SagaStateMachineInstance
{
    public int CurrentState { get; set; }
    public Guid CorrelationId { get; set; }
}

public class SampleStateMachine13 :
    MassTransitStateMachine<SampleStateMachineInstance13>
{
    public SampleStateMachine13()
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
                .Request(ShotRequest, context => new RequestA13()),
            When(ShotRequest.Completed)
                .Then(_ => { }),
            When(ShotRequest.Faulted)
                .Then(_ => { }));
    }

    public Request<SampleStateMachineInstance13, RequestA13, ResponseA13> ShotRequest { get; } = null!;

    public Event<Start13> Start { get; } = null!;
    public Event<StartCompleted13> StartCompleted { get; } = null!;
    public Event<SpeedIncreased13> SpeedIncreased { get; } = null!;
    public Event<SpeedDecreased13> SpeedDecreased { get; } = null!;
    public Event<ShotTaken13> ShotTaken { get; } = null!;

    public State Starting { get; } = null!;
    public State Started { get; } = null!;
    public State Running { get; } = null!;
    public State Walking { get; } = null!;
    public State Sipping { get; } = null!;
    public State Stalking { get; } = null!;
}


public class Start14
{
    public Guid CorrelationId { get; set; }
}

public class StartCompleted14
{
    public Guid CorrelationId { get; set; }
}

public class SpeedIncreased14
{
    public Guid CorrelationId { get; set; }
}

public class SpeedDecreased14
{
    public Guid CorrelationId { get; set; }
}

public class ShotTaken14
{
    public Guid CorrelationId { get; set; }
}

public class RequestA14
{
    public Guid CorrelationId { get; set; }
}

public class ResponseA14
{
    public Guid CorrelationId { get; set; }
}

public class RequestB14
{
    public Guid CorrelationId { get; set; }
}

public class ResponseB14
{
    public Guid CorrelationId { get; set; }
}

public class SampleStateMachineInstance14 :
    SagaStateMachineInstance
{
    public int CurrentState { get; set; }
    public Guid CorrelationId { get; set; }
}

public class SampleStateMachine14 :
    MassTransitStateMachine<SampleStateMachineInstance14>
{
    public SampleStateMachine14()
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
                .Request(ShotRequest, context => new RequestA14()),
            When(ShotRequest.Completed)
                .Then(_ => { }),
            When(ShotRequest.Faulted)
                .Then(_ => { }));
    }

    public Request<SampleStateMachineInstance14, RequestA14, ResponseA14> ShotRequest { get; } = null!;

    public Event<Start14> Start { get; } = null!;
    public Event<StartCompleted14> StartCompleted { get; } = null!;
    public Event<SpeedIncreased14> SpeedIncreased { get; } = null!;
    public Event<SpeedDecreased14> SpeedDecreased { get; } = null!;
    public Event<ShotTaken14> ShotTaken { get; } = null!;

    public State Starting { get; } = null!;
    public State Started { get; } = null!;
    public State Running { get; } = null!;
    public State Walking { get; } = null!;
    public State Sipping { get; } = null!;
    public State Stalking { get; } = null!;
}


public class Start15
{
    public Guid CorrelationId { get; set; }
}

public class StartCompleted15
{
    public Guid CorrelationId { get; set; }
}

public class SpeedIncreased15
{
    public Guid CorrelationId { get; set; }
}

public class SpeedDecreased15
{
    public Guid CorrelationId { get; set; }
}

public class ShotTaken15
{
    public Guid CorrelationId { get; set; }
}

public class RequestA15
{
    public Guid CorrelationId { get; set; }
}

public class ResponseA15
{
    public Guid CorrelationId { get; set; }
}

public class RequestB15
{
    public Guid CorrelationId { get; set; }
}

public class ResponseB15
{
    public Guid CorrelationId { get; set; }
}

public class SampleStateMachineInstance15 :
    SagaStateMachineInstance
{
    public int CurrentState { get; set; }
    public Guid CorrelationId { get; set; }
}

public class SampleStateMachine15 :
    MassTransitStateMachine<SampleStateMachineInstance15>
{
    public SampleStateMachine15()
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
                .Request(ShotRequest, context => new RequestA15()),
            When(ShotRequest.Completed)
                .Then(_ => { }),
            When(ShotRequest.Faulted)
                .Then(_ => { }));
    }

    public Request<SampleStateMachineInstance15, RequestA15, ResponseA15> ShotRequest { get; } = null!;

    public Event<Start15> Start { get; } = null!;
    public Event<StartCompleted15> StartCompleted { get; } = null!;
    public Event<SpeedIncreased15> SpeedIncreased { get; } = null!;
    public Event<SpeedDecreased15> SpeedDecreased { get; } = null!;
    public Event<ShotTaken15> ShotTaken { get; } = null!;

    public State Starting { get; } = null!;
    public State Started { get; } = null!;
    public State Running { get; } = null!;
    public State Walking { get; } = null!;
    public State Sipping { get; } = null!;
    public State Stalking { get; } = null!;
}


public class Start16
{
    public Guid CorrelationId { get; set; }
}

public class StartCompleted16
{
    public Guid CorrelationId { get; set; }
}

public class SpeedIncreased16
{
    public Guid CorrelationId { get; set; }
}

public class SpeedDecreased16
{
    public Guid CorrelationId { get; set; }
}

public class ShotTaken16
{
    public Guid CorrelationId { get; set; }
}

public class RequestA16
{
    public Guid CorrelationId { get; set; }
}

public class ResponseA16
{
    public Guid CorrelationId { get; set; }
}

public class RequestB16
{
    public Guid CorrelationId { get; set; }
}

public class ResponseB16
{
    public Guid CorrelationId { get; set; }
}

public class SampleStateMachineInstance16 :
    SagaStateMachineInstance
{
    public int CurrentState { get; set; }
    public Guid CorrelationId { get; set; }
}

public class SampleStateMachine16 :
    MassTransitStateMachine<SampleStateMachineInstance16>
{
    public SampleStateMachine16()
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
                .Request(ShotRequest, context => new RequestA16()),
            When(ShotRequest.Completed)
                .Then(_ => { }),
            When(ShotRequest.Faulted)
                .Then(_ => { }));
    }

    public Request<SampleStateMachineInstance16, RequestA16, ResponseA16> ShotRequest { get; } = null!;

    public Event<Start16> Start { get; } = null!;
    public Event<StartCompleted16> StartCompleted { get; } = null!;
    public Event<SpeedIncreased16> SpeedIncreased { get; } = null!;
    public Event<SpeedDecreased16> SpeedDecreased { get; } = null!;
    public Event<ShotTaken16> ShotTaken { get; } = null!;

    public State Starting { get; } = null!;
    public State Started { get; } = null!;
    public State Running { get; } = null!;
    public State Walking { get; } = null!;
    public State Sipping { get; } = null!;
    public State Stalking { get; } = null!;
}


public class Start17
{
    public Guid CorrelationId { get; set; }
}

public class StartCompleted17
{
    public Guid CorrelationId { get; set; }
}

public class SpeedIncreased17
{
    public Guid CorrelationId { get; set; }
}

public class SpeedDecreased17
{
    public Guid CorrelationId { get; set; }
}

public class ShotTaken17
{
    public Guid CorrelationId { get; set; }
}

public class RequestA17
{
    public Guid CorrelationId { get; set; }
}

public class ResponseA17
{
    public Guid CorrelationId { get; set; }
}

public class RequestB17
{
    public Guid CorrelationId { get; set; }
}

public class ResponseB17
{
    public Guid CorrelationId { get; set; }
}

public class SampleStateMachineInstance17 :
    SagaStateMachineInstance
{
    public int CurrentState { get; set; }
    public Guid CorrelationId { get; set; }
}

public class SampleStateMachine17 :
    MassTransitStateMachine<SampleStateMachineInstance17>
{
    public SampleStateMachine17()
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
                .Request(ShotRequest, context => new RequestA17()),
            When(ShotRequest.Completed)
                .Then(_ => { }),
            When(ShotRequest.Faulted)
                .Then(_ => { }));
    }

    public Request<SampleStateMachineInstance17, RequestA17, ResponseA17> ShotRequest { get; } = null!;

    public Event<Start17> Start { get; } = null!;
    public Event<StartCompleted17> StartCompleted { get; } = null!;
    public Event<SpeedIncreased17> SpeedIncreased { get; } = null!;
    public Event<SpeedDecreased17> SpeedDecreased { get; } = null!;
    public Event<ShotTaken17> ShotTaken { get; } = null!;

    public State Starting { get; } = null!;
    public State Started { get; } = null!;
    public State Running { get; } = null!;
    public State Walking { get; } = null!;
    public State Sipping { get; } = null!;
    public State Stalking { get; } = null!;
}


public class Start18
{
    public Guid CorrelationId { get; set; }
}

public class StartCompleted18
{
    public Guid CorrelationId { get; set; }
}

public class SpeedIncreased18
{
    public Guid CorrelationId { get; set; }
}

public class SpeedDecreased18
{
    public Guid CorrelationId { get; set; }
}

public class ShotTaken18
{
    public Guid CorrelationId { get; set; }
}

public class RequestA18
{
    public Guid CorrelationId { get; set; }
}

public class ResponseA18
{
    public Guid CorrelationId { get; set; }
}

public class RequestB18
{
    public Guid CorrelationId { get; set; }
}

public class ResponseB18
{
    public Guid CorrelationId { get; set; }
}

public class SampleStateMachineInstance18 :
    SagaStateMachineInstance
{
    public int CurrentState { get; set; }
    public Guid CorrelationId { get; set; }
}

public class SampleStateMachine18 :
    MassTransitStateMachine<SampleStateMachineInstance18>
{
    public SampleStateMachine18()
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
                .Request(ShotRequest, context => new RequestA18()),
            When(ShotRequest.Completed)
                .Then(_ => { }),
            When(ShotRequest.Faulted)
                .Then(_ => { }));
    }

    public Request<SampleStateMachineInstance18, RequestA18, ResponseA18> ShotRequest { get; } = null!;

    public Event<Start18> Start { get; } = null!;
    public Event<StartCompleted18> StartCompleted { get; } = null!;
    public Event<SpeedIncreased18> SpeedIncreased { get; } = null!;
    public Event<SpeedDecreased18> SpeedDecreased { get; } = null!;
    public Event<ShotTaken18> ShotTaken { get; } = null!;

    public State Starting { get; } = null!;
    public State Started { get; } = null!;
    public State Running { get; } = null!;
    public State Walking { get; } = null!;
    public State Sipping { get; } = null!;
    public State Stalking { get; } = null!;
}


public class Start19
{
    public Guid CorrelationId { get; set; }
}

public class StartCompleted19
{
    public Guid CorrelationId { get; set; }
}

public class SpeedIncreased19
{
    public Guid CorrelationId { get; set; }
}

public class SpeedDecreased19
{
    public Guid CorrelationId { get; set; }
}

public class ShotTaken19
{
    public Guid CorrelationId { get; set; }
}

public class RequestA19
{
    public Guid CorrelationId { get; set; }
}

public class ResponseA19
{
    public Guid CorrelationId { get; set; }
}

public class RequestB19
{
    public Guid CorrelationId { get; set; }
}

public class ResponseB19
{
    public Guid CorrelationId { get; set; }
}

public class SampleStateMachineInstance19 :
    SagaStateMachineInstance
{
    public int CurrentState { get; set; }
    public Guid CorrelationId { get; set; }
}

public class SampleStateMachine19 :
    MassTransitStateMachine<SampleStateMachineInstance19>
{
    public SampleStateMachine19()
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
                .Request(ShotRequest, context => new RequestA19()),
            When(ShotRequest.Completed)
                .Then(_ => { }),
            When(ShotRequest.Faulted)
                .Then(_ => { }));
    }

    public Request<SampleStateMachineInstance19, RequestA19, ResponseA19> ShotRequest { get; } = null!;

    public Event<Start19> Start { get; } = null!;
    public Event<StartCompleted19> StartCompleted { get; } = null!;
    public Event<SpeedIncreased19> SpeedIncreased { get; } = null!;
    public Event<SpeedDecreased19> SpeedDecreased { get; } = null!;
    public Event<ShotTaken19> ShotTaken { get; } = null!;

    public State Starting { get; } = null!;
    public State Started { get; } = null!;
    public State Running { get; } = null!;
    public State Walking { get; } = null!;
    public State Sipping { get; } = null!;
    public State Stalking { get; } = null!;
}


public class Start20
{
    public Guid CorrelationId { get; set; }
}

public class StartCompleted20
{
    public Guid CorrelationId { get; set; }
}

public class SpeedIncreased20
{
    public Guid CorrelationId { get; set; }
}

public class SpeedDecreased20
{
    public Guid CorrelationId { get; set; }
}

public class ShotTaken20
{
    public Guid CorrelationId { get; set; }
}

public class RequestA20
{
    public Guid CorrelationId { get; set; }
}

public class ResponseA20
{
    public Guid CorrelationId { get; set; }
}

public class RequestB20
{
    public Guid CorrelationId { get; set; }
}

public class ResponseB20
{
    public Guid CorrelationId { get; set; }
}

public class SampleStateMachineInstance20 :
    SagaStateMachineInstance
{
    public int CurrentState { get; set; }
    public Guid CorrelationId { get; set; }
}

public class SampleStateMachine20 :
    MassTransitStateMachine<SampleStateMachineInstance20>
{
    public SampleStateMachine20()
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
                .Request(ShotRequest, context => new RequestA20()),
            When(ShotRequest.Completed)
                .Then(_ => { }),
            When(ShotRequest.Faulted)
                .Then(_ => { }));
    }

    public Request<SampleStateMachineInstance20, RequestA20, ResponseA20> ShotRequest { get; } = null!;

    public Event<Start20> Start { get; } = null!;
    public Event<StartCompleted20> StartCompleted { get; } = null!;
    public Event<SpeedIncreased20> SpeedIncreased { get; } = null!;
    public Event<SpeedDecreased20> SpeedDecreased { get; } = null!;
    public Event<ShotTaken20> ShotTaken { get; } = null!;

    public State Starting { get; } = null!;
    public State Started { get; } = null!;
    public State Running { get; } = null!;
    public State Walking { get; } = null!;
    public State Sipping { get; } = null!;
    public State Stalking { get; } = null!;
}


public class Start21
{
    public Guid CorrelationId { get; set; }
}

public class StartCompleted21
{
    public Guid CorrelationId { get; set; }
}

public class SpeedIncreased21
{
    public Guid CorrelationId { get; set; }
}

public class SpeedDecreased21
{
    public Guid CorrelationId { get; set; }
}

public class ShotTaken21
{
    public Guid CorrelationId { get; set; }
}

public class RequestA21
{
    public Guid CorrelationId { get; set; }
}

public class ResponseA21
{
    public Guid CorrelationId { get; set; }
}

public class RequestB21
{
    public Guid CorrelationId { get; set; }
}

public class ResponseB21
{
    public Guid CorrelationId { get; set; }
}

public class SampleStateMachineInstance21 :
    SagaStateMachineInstance
{
    public int CurrentState { get; set; }
    public Guid CorrelationId { get; set; }
}

public class SampleStateMachine21 :
    MassTransitStateMachine<SampleStateMachineInstance21>
{
    public SampleStateMachine21()
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
                .Request(ShotRequest, context => new RequestA21()),
            When(ShotRequest.Completed)
                .Then(_ => { }),
            When(ShotRequest.Faulted)
                .Then(_ => { }));
    }

    public Request<SampleStateMachineInstance21, RequestA21, ResponseA21> ShotRequest { get; } = null!;

    public Event<Start21> Start { get; } = null!;
    public Event<StartCompleted21> StartCompleted { get; } = null!;
    public Event<SpeedIncreased21> SpeedIncreased { get; } = null!;
    public Event<SpeedDecreased21> SpeedDecreased { get; } = null!;
    public Event<ShotTaken21> ShotTaken { get; } = null!;

    public State Starting { get; } = null!;
    public State Started { get; } = null!;
    public State Running { get; } = null!;
    public State Walking { get; } = null!;
    public State Sipping { get; } = null!;
    public State Stalking { get; } = null!;
}


public class Start22
{
    public Guid CorrelationId { get; set; }
}

public class StartCompleted22
{
    public Guid CorrelationId { get; set; }
}

public class SpeedIncreased22
{
    public Guid CorrelationId { get; set; }
}

public class SpeedDecreased22
{
    public Guid CorrelationId { get; set; }
}

public class ShotTaken22
{
    public Guid CorrelationId { get; set; }
}

public class RequestA22
{
    public Guid CorrelationId { get; set; }
}

public class ResponseA22
{
    public Guid CorrelationId { get; set; }
}

public class RequestB22
{
    public Guid CorrelationId { get; set; }
}

public class ResponseB22
{
    public Guid CorrelationId { get; set; }
}

public class SampleStateMachineInstance22 :
    SagaStateMachineInstance
{
    public int CurrentState { get; set; }
    public Guid CorrelationId { get; set; }
}

public class SampleStateMachine22 :
    MassTransitStateMachine<SampleStateMachineInstance22>
{
    public SampleStateMachine22()
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
                .Request(ShotRequest, context => new RequestA22()),
            When(ShotRequest.Completed)
                .Then(_ => { }),
            When(ShotRequest.Faulted)
                .Then(_ => { }));
    }

    public Request<SampleStateMachineInstance22, RequestA22, ResponseA22> ShotRequest { get; } = null!;

    public Event<Start22> Start { get; } = null!;
    public Event<StartCompleted22> StartCompleted { get; } = null!;
    public Event<SpeedIncreased22> SpeedIncreased { get; } = null!;
    public Event<SpeedDecreased22> SpeedDecreased { get; } = null!;
    public Event<ShotTaken22> ShotTaken { get; } = null!;

    public State Starting { get; } = null!;
    public State Started { get; } = null!;
    public State Running { get; } = null!;
    public State Walking { get; } = null!;
    public State Sipping { get; } = null!;
    public State Stalking { get; } = null!;
}


public class Start23
{
    public Guid CorrelationId { get; set; }
}

public class StartCompleted23
{
    public Guid CorrelationId { get; set; }
}

public class SpeedIncreased23
{
    public Guid CorrelationId { get; set; }
}

public class SpeedDecreased23
{
    public Guid CorrelationId { get; set; }
}

public class ShotTaken23
{
    public Guid CorrelationId { get; set; }
}

public class RequestA23
{
    public Guid CorrelationId { get; set; }
}

public class ResponseA23
{
    public Guid CorrelationId { get; set; }
}

public class RequestB23
{
    public Guid CorrelationId { get; set; }
}

public class ResponseB23
{
    public Guid CorrelationId { get; set; }
}

public class SampleStateMachineInstance23 :
    SagaStateMachineInstance
{
    public int CurrentState { get; set; }
    public Guid CorrelationId { get; set; }
}

public class SampleStateMachine23 :
    MassTransitStateMachine<SampleStateMachineInstance23>
{
    public SampleStateMachine23()
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
                .Request(ShotRequest, context => new RequestA23()),
            When(ShotRequest.Completed)
                .Then(_ => { }),
            When(ShotRequest.Faulted)
                .Then(_ => { }));
    }

    public Request<SampleStateMachineInstance23, RequestA23, ResponseA23> ShotRequest { get; } = null!;

    public Event<Start23> Start { get; } = null!;
    public Event<StartCompleted23> StartCompleted { get; } = null!;
    public Event<SpeedIncreased23> SpeedIncreased { get; } = null!;
    public Event<SpeedDecreased23> SpeedDecreased { get; } = null!;
    public Event<ShotTaken23> ShotTaken { get; } = null!;

    public State Starting { get; } = null!;
    public State Started { get; } = null!;
    public State Running { get; } = null!;
    public State Walking { get; } = null!;
    public State Sipping { get; } = null!;
    public State Stalking { get; } = null!;
}


public class Start24
{
    public Guid CorrelationId { get; set; }
}

public class StartCompleted24
{
    public Guid CorrelationId { get; set; }
}

public class SpeedIncreased24
{
    public Guid CorrelationId { get; set; }
}

public class SpeedDecreased24
{
    public Guid CorrelationId { get; set; }
}

public class ShotTaken24
{
    public Guid CorrelationId { get; set; }
}

public class RequestA24
{
    public Guid CorrelationId { get; set; }
}

public class ResponseA24
{
    public Guid CorrelationId { get; set; }
}

public class RequestB24
{
    public Guid CorrelationId { get; set; }
}

public class ResponseB24
{
    public Guid CorrelationId { get; set; }
}

public class SampleStateMachineInstance24 :
    SagaStateMachineInstance
{
    public int CurrentState { get; set; }
    public Guid CorrelationId { get; set; }
}

public class SampleStateMachine24 :
    MassTransitStateMachine<SampleStateMachineInstance24>
{
    public SampleStateMachine24()
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
                .Request(ShotRequest, context => new RequestA24()),
            When(ShotRequest.Completed)
                .Then(_ => { }),
            When(ShotRequest.Faulted)
                .Then(_ => { }));
    }

    public Request<SampleStateMachineInstance24, RequestA24, ResponseA24> ShotRequest { get; } = null!;

    public Event<Start24> Start { get; } = null!;
    public Event<StartCompleted24> StartCompleted { get; } = null!;
    public Event<SpeedIncreased24> SpeedIncreased { get; } = null!;
    public Event<SpeedDecreased24> SpeedDecreased { get; } = null!;
    public Event<ShotTaken24> ShotTaken { get; } = null!;

    public State Starting { get; } = null!;
    public State Started { get; } = null!;
    public State Running { get; } = null!;
    public State Walking { get; } = null!;
    public State Sipping { get; } = null!;
    public State Stalking { get; } = null!;
}


public class Start25
{
    public Guid CorrelationId { get; set; }
}

public class StartCompleted25
{
    public Guid CorrelationId { get; set; }
}

public class SpeedIncreased25
{
    public Guid CorrelationId { get; set; }
}

public class SpeedDecreased25
{
    public Guid CorrelationId { get; set; }
}

public class ShotTaken25
{
    public Guid CorrelationId { get; set; }
}

public class RequestA25
{
    public Guid CorrelationId { get; set; }
}

public class ResponseA25
{
    public Guid CorrelationId { get; set; }
}

public class RequestB25
{
    public Guid CorrelationId { get; set; }
}

public class ResponseB25
{
    public Guid CorrelationId { get; set; }
}

public class SampleStateMachineInstance25 :
    SagaStateMachineInstance
{
    public int CurrentState { get; set; }
    public Guid CorrelationId { get; set; }
}

public class SampleStateMachine25 :
    MassTransitStateMachine<SampleStateMachineInstance25>
{
    public SampleStateMachine25()
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
                .Request(ShotRequest, context => new RequestA25()),
            When(ShotRequest.Completed)
                .Then(_ => { }),
            When(ShotRequest.Faulted)
                .Then(_ => { }));
    }

    public Request<SampleStateMachineInstance25, RequestA25, ResponseA25> ShotRequest { get; } = null!;

    public Event<Start25> Start { get; } = null!;
    public Event<StartCompleted25> StartCompleted { get; } = null!;
    public Event<SpeedIncreased25> SpeedIncreased { get; } = null!;
    public Event<SpeedDecreased25> SpeedDecreased { get; } = null!;
    public Event<ShotTaken25> ShotTaken { get; } = null!;

    public State Starting { get; } = null!;
    public State Started { get; } = null!;
    public State Running { get; } = null!;
    public State Walking { get; } = null!;
    public State Sipping { get; } = null!;
    public State Stalking { get; } = null!;
}


public class Start26
{
    public Guid CorrelationId { get; set; }
}

public class StartCompleted26
{
    public Guid CorrelationId { get; set; }
}

public class SpeedIncreased26
{
    public Guid CorrelationId { get; set; }
}

public class SpeedDecreased26
{
    public Guid CorrelationId { get; set; }
}

public class ShotTaken26
{
    public Guid CorrelationId { get; set; }
}

public class RequestA26
{
    public Guid CorrelationId { get; set; }
}

public class ResponseA26
{
    public Guid CorrelationId { get; set; }
}

public class RequestB26
{
    public Guid CorrelationId { get; set; }
}

public class ResponseB26
{
    public Guid CorrelationId { get; set; }
}

public class SampleStateMachineInstance26 :
    SagaStateMachineInstance
{
    public int CurrentState { get; set; }
    public Guid CorrelationId { get; set; }
}

public class SampleStateMachine26 :
    MassTransitStateMachine<SampleStateMachineInstance26>
{
    public SampleStateMachine26()
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
                .Request(ShotRequest, context => new RequestA26()),
            When(ShotRequest.Completed)
                .Then(_ => { }),
            When(ShotRequest.Faulted)
                .Then(_ => { }));
    }

    public Request<SampleStateMachineInstance26, RequestA26, ResponseA26> ShotRequest { get; } = null!;

    public Event<Start26> Start { get; } = null!;
    public Event<StartCompleted26> StartCompleted { get; } = null!;
    public Event<SpeedIncreased26> SpeedIncreased { get; } = null!;
    public Event<SpeedDecreased26> SpeedDecreased { get; } = null!;
    public Event<ShotTaken26> ShotTaken { get; } = null!;

    public State Starting { get; } = null!;
    public State Started { get; } = null!;
    public State Running { get; } = null!;
    public State Walking { get; } = null!;
    public State Sipping { get; } = null!;
    public State Stalking { get; } = null!;
}


public class Start27
{
    public Guid CorrelationId { get; set; }
}

public class StartCompleted27
{
    public Guid CorrelationId { get; set; }
}

public class SpeedIncreased27
{
    public Guid CorrelationId { get; set; }
}

public class SpeedDecreased27
{
    public Guid CorrelationId { get; set; }
}

public class ShotTaken27
{
    public Guid CorrelationId { get; set; }
}

public class RequestA27
{
    public Guid CorrelationId { get; set; }
}

public class ResponseA27
{
    public Guid CorrelationId { get; set; }
}

public class RequestB27
{
    public Guid CorrelationId { get; set; }
}

public class ResponseB27
{
    public Guid CorrelationId { get; set; }
}

public class SampleStateMachineInstance27 :
    SagaStateMachineInstance
{
    public int CurrentState { get; set; }
    public Guid CorrelationId { get; set; }
}

public class SampleStateMachine27 :
    MassTransitStateMachine<SampleStateMachineInstance27>
{
    public SampleStateMachine27()
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
                .Request(ShotRequest, context => new RequestA27()),
            When(ShotRequest.Completed)
                .Then(_ => { }),
            When(ShotRequest.Faulted)
                .Then(_ => { }));
    }

    public Request<SampleStateMachineInstance27, RequestA27, ResponseA27> ShotRequest { get; } = null!;

    public Event<Start27> Start { get; } = null!;
    public Event<StartCompleted27> StartCompleted { get; } = null!;
    public Event<SpeedIncreased27> SpeedIncreased { get; } = null!;
    public Event<SpeedDecreased27> SpeedDecreased { get; } = null!;
    public Event<ShotTaken27> ShotTaken { get; } = null!;

    public State Starting { get; } = null!;
    public State Started { get; } = null!;
    public State Running { get; } = null!;
    public State Walking { get; } = null!;
    public State Sipping { get; } = null!;
    public State Stalking { get; } = null!;
}


public class Start28
{
    public Guid CorrelationId { get; set; }
}

public class StartCompleted28
{
    public Guid CorrelationId { get; set; }
}

public class SpeedIncreased28
{
    public Guid CorrelationId { get; set; }
}

public class SpeedDecreased28
{
    public Guid CorrelationId { get; set; }
}

public class ShotTaken28
{
    public Guid CorrelationId { get; set; }
}

public class RequestA28
{
    public Guid CorrelationId { get; set; }
}

public class ResponseA28
{
    public Guid CorrelationId { get; set; }
}

public class RequestB28
{
    public Guid CorrelationId { get; set; }
}

public class ResponseB28
{
    public Guid CorrelationId { get; set; }
}

public class SampleStateMachineInstance28 :
    SagaStateMachineInstance
{
    public int CurrentState { get; set; }
    public Guid CorrelationId { get; set; }
}

public class SampleStateMachine28 :
    MassTransitStateMachine<SampleStateMachineInstance28>
{
    public SampleStateMachine28()
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
                .Request(ShotRequest, context => new RequestA28()),
            When(ShotRequest.Completed)
                .Then(_ => { }),
            When(ShotRequest.Faulted)
                .Then(_ => { }));
    }

    public Request<SampleStateMachineInstance28, RequestA28, ResponseA28> ShotRequest { get; } = null!;

    public Event<Start28> Start { get; } = null!;
    public Event<StartCompleted28> StartCompleted { get; } = null!;
    public Event<SpeedIncreased28> SpeedIncreased { get; } = null!;
    public Event<SpeedDecreased28> SpeedDecreased { get; } = null!;
    public Event<ShotTaken28> ShotTaken { get; } = null!;

    public State Starting { get; } = null!;
    public State Started { get; } = null!;
    public State Running { get; } = null!;
    public State Walking { get; } = null!;
    public State Sipping { get; } = null!;
    public State Stalking { get; } = null!;
}


public class Start29
{
    public Guid CorrelationId { get; set; }
}

public class StartCompleted29
{
    public Guid CorrelationId { get; set; }
}

public class SpeedIncreased29
{
    public Guid CorrelationId { get; set; }
}

public class SpeedDecreased29
{
    public Guid CorrelationId { get; set; }
}

public class ShotTaken29
{
    public Guid CorrelationId { get; set; }
}

public class RequestA29
{
    public Guid CorrelationId { get; set; }
}

public class ResponseA29
{
    public Guid CorrelationId { get; set; }
}

public class RequestB29
{
    public Guid CorrelationId { get; set; }
}

public class ResponseB29
{
    public Guid CorrelationId { get; set; }
}

public class SampleStateMachineInstance29 :
    SagaStateMachineInstance
{
    public int CurrentState { get; set; }
    public Guid CorrelationId { get; set; }
}

public class SampleStateMachine29 :
    MassTransitStateMachine<SampleStateMachineInstance29>
{
    public SampleStateMachine29()
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
                .Request(ShotRequest, context => new RequestA29()),
            When(ShotRequest.Completed)
                .Then(_ => { }),
            When(ShotRequest.Faulted)
                .Then(_ => { }));
    }

    public Request<SampleStateMachineInstance29, RequestA29, ResponseA29> ShotRequest { get; } = null!;

    public Event<Start29> Start { get; } = null!;
    public Event<StartCompleted29> StartCompleted { get; } = null!;
    public Event<SpeedIncreased29> SpeedIncreased { get; } = null!;
    public Event<SpeedDecreased29> SpeedDecreased { get; } = null!;
    public Event<ShotTaken29> ShotTaken { get; } = null!;

    public State Starting { get; } = null!;
    public State Started { get; } = null!;
    public State Running { get; } = null!;
    public State Walking { get; } = null!;
    public State Sipping { get; } = null!;
    public State Stalking { get; } = null!;
}


public class Start30
{
    public Guid CorrelationId { get; set; }
}

public class StartCompleted30
{
    public Guid CorrelationId { get; set; }
}

public class SpeedIncreased30
{
    public Guid CorrelationId { get; set; }
}

public class SpeedDecreased30
{
    public Guid CorrelationId { get; set; }
}

public class ShotTaken30
{
    public Guid CorrelationId { get; set; }
}

public class RequestA30
{
    public Guid CorrelationId { get; set; }
}

public class ResponseA30
{
    public Guid CorrelationId { get; set; }
}

public class RequestB30
{
    public Guid CorrelationId { get; set; }
}

public class ResponseB30
{
    public Guid CorrelationId { get; set; }
}

public class SampleStateMachineInstance30 :
    SagaStateMachineInstance
{
    public int CurrentState { get; set; }
    public Guid CorrelationId { get; set; }
}

public class SampleStateMachine30 :
    MassTransitStateMachine<SampleStateMachineInstance30>
{
    public SampleStateMachine30()
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
                .Request(ShotRequest, context => new RequestA30()),
            When(ShotRequest.Completed)
                .Then(_ => { }),
            When(ShotRequest.Faulted)
                .Then(_ => { }));
    }

    public Request<SampleStateMachineInstance30, RequestA30, ResponseA30> ShotRequest { get; } = null!;

    public Event<Start30> Start { get; } = null!;
    public Event<StartCompleted30> StartCompleted { get; } = null!;
    public Event<SpeedIncreased30> SpeedIncreased { get; } = null!;
    public Event<SpeedDecreased30> SpeedDecreased { get; } = null!;
    public Event<ShotTaken30> ShotTaken { get; } = null!;

    public State Starting { get; } = null!;
    public State Started { get; } = null!;
    public State Running { get; } = null!;
    public State Walking { get; } = null!;
    public State Sipping { get; } = null!;
    public State Stalking { get; } = null!;
}


public class Start31
{
    public Guid CorrelationId { get; set; }
}

public class StartCompleted31
{
    public Guid CorrelationId { get; set; }
}

public class SpeedIncreased31
{
    public Guid CorrelationId { get; set; }
}

public class SpeedDecreased31
{
    public Guid CorrelationId { get; set; }
}

public class ShotTaken31
{
    public Guid CorrelationId { get; set; }
}

public class RequestA31
{
    public Guid CorrelationId { get; set; }
}

public class ResponseA31
{
    public Guid CorrelationId { get; set; }
}

public class RequestB31
{
    public Guid CorrelationId { get; set; }
}

public class ResponseB31
{
    public Guid CorrelationId { get; set; }
}

public class SampleStateMachineInstance31 :
    SagaStateMachineInstance
{
    public int CurrentState { get; set; }
    public Guid CorrelationId { get; set; }
}

public class SampleStateMachine31 :
    MassTransitStateMachine<SampleStateMachineInstance31>
{
    public SampleStateMachine31()
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
                .Request(ShotRequest, context => new RequestA31()),
            When(ShotRequest.Completed)
                .Then(_ => { }),
            When(ShotRequest.Faulted)
                .Then(_ => { }));
    }

    public Request<SampleStateMachineInstance31, RequestA31, ResponseA31> ShotRequest { get; } = null!;

    public Event<Start31> Start { get; } = null!;
    public Event<StartCompleted31> StartCompleted { get; } = null!;
    public Event<SpeedIncreased31> SpeedIncreased { get; } = null!;
    public Event<SpeedDecreased31> SpeedDecreased { get; } = null!;
    public Event<ShotTaken31> ShotTaken { get; } = null!;

    public State Starting { get; } = null!;
    public State Started { get; } = null!;
    public State Running { get; } = null!;
    public State Walking { get; } = null!;
    public State Sipping { get; } = null!;
    public State Stalking { get; } = null!;
}


public class Start32
{
    public Guid CorrelationId { get; set; }
}

public class StartCompleted32
{
    public Guid CorrelationId { get; set; }
}

public class SpeedIncreased32
{
    public Guid CorrelationId { get; set; }
}

public class SpeedDecreased32
{
    public Guid CorrelationId { get; set; }
}

public class ShotTaken32
{
    public Guid CorrelationId { get; set; }
}

public class RequestA32
{
    public Guid CorrelationId { get; set; }
}

public class ResponseA32
{
    public Guid CorrelationId { get; set; }
}

public class RequestB32
{
    public Guid CorrelationId { get; set; }
}

public class ResponseB32
{
    public Guid CorrelationId { get; set; }
}

public class SampleStateMachineInstance32 :
    SagaStateMachineInstance
{
    public int CurrentState { get; set; }
    public Guid CorrelationId { get; set; }
}

public class SampleStateMachine32 :
    MassTransitStateMachine<SampleStateMachineInstance32>
{
    public SampleStateMachine32()
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
                .Request(ShotRequest, context => new RequestA32()),
            When(ShotRequest.Completed)
                .Then(_ => { }),
            When(ShotRequest.Faulted)
                .Then(_ => { }));
    }

    public Request<SampleStateMachineInstance32, RequestA32, ResponseA32> ShotRequest { get; } = null!;

    public Event<Start32> Start { get; } = null!;
    public Event<StartCompleted32> StartCompleted { get; } = null!;
    public Event<SpeedIncreased32> SpeedIncreased { get; } = null!;
    public Event<SpeedDecreased32> SpeedDecreased { get; } = null!;
    public Event<ShotTaken32> ShotTaken { get; } = null!;

    public State Starting { get; } = null!;
    public State Started { get; } = null!;
    public State Running { get; } = null!;
    public State Walking { get; } = null!;
    public State Sipping { get; } = null!;
    public State Stalking { get; } = null!;
}


public class Start33
{
    public Guid CorrelationId { get; set; }
}

public class StartCompleted33
{
    public Guid CorrelationId { get; set; }
}

public class SpeedIncreased33
{
    public Guid CorrelationId { get; set; }
}

public class SpeedDecreased33
{
    public Guid CorrelationId { get; set; }
}

public class ShotTaken33
{
    public Guid CorrelationId { get; set; }
}

public class RequestA33
{
    public Guid CorrelationId { get; set; }
}

public class ResponseA33
{
    public Guid CorrelationId { get; set; }
}

public class RequestB33
{
    public Guid CorrelationId { get; set; }
}

public class ResponseB33
{
    public Guid CorrelationId { get; set; }
}

public class SampleStateMachineInstance33 :
    SagaStateMachineInstance
{
    public int CurrentState { get; set; }
    public Guid CorrelationId { get; set; }
}

public class SampleStateMachine33 :
    MassTransitStateMachine<SampleStateMachineInstance33>
{
    public SampleStateMachine33()
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
                .Request(ShotRequest, context => new RequestA33()),
            When(ShotRequest.Completed)
                .Then(_ => { }),
            When(ShotRequest.Faulted)
                .Then(_ => { }));
    }

    public Request<SampleStateMachineInstance33, RequestA33, ResponseA33> ShotRequest { get; } = null!;

    public Event<Start33> Start { get; } = null!;
    public Event<StartCompleted33> StartCompleted { get; } = null!;
    public Event<SpeedIncreased33> SpeedIncreased { get; } = null!;
    public Event<SpeedDecreased33> SpeedDecreased { get; } = null!;
    public Event<ShotTaken33> ShotTaken { get; } = null!;

    public State Starting { get; } = null!;
    public State Started { get; } = null!;
    public State Running { get; } = null!;
    public State Walking { get; } = null!;
    public State Sipping { get; } = null!;
    public State Stalking { get; } = null!;
}


public class Start34
{
    public Guid CorrelationId { get; set; }
}

public class StartCompleted34
{
    public Guid CorrelationId { get; set; }
}

public class SpeedIncreased34
{
    public Guid CorrelationId { get; set; }
}

public class SpeedDecreased34
{
    public Guid CorrelationId { get; set; }
}

public class ShotTaken34
{
    public Guid CorrelationId { get; set; }
}

public class RequestA34
{
    public Guid CorrelationId { get; set; }
}

public class ResponseA34
{
    public Guid CorrelationId { get; set; }
}

public class RequestB34
{
    public Guid CorrelationId { get; set; }
}

public class ResponseB34
{
    public Guid CorrelationId { get; set; }
}

public class SampleStateMachineInstance34 :
    SagaStateMachineInstance
{
    public int CurrentState { get; set; }
    public Guid CorrelationId { get; set; }
}

public class SampleStateMachine34 :
    MassTransitStateMachine<SampleStateMachineInstance34>
{
    public SampleStateMachine34()
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
                .Request(ShotRequest, context => new RequestA34()),
            When(ShotRequest.Completed)
                .Then(_ => { }),
            When(ShotRequest.Faulted)
                .Then(_ => { }));
    }

    public Request<SampleStateMachineInstance34, RequestA34, ResponseA34> ShotRequest { get; } = null!;

    public Event<Start34> Start { get; } = null!;
    public Event<StartCompleted34> StartCompleted { get; } = null!;
    public Event<SpeedIncreased34> SpeedIncreased { get; } = null!;
    public Event<SpeedDecreased34> SpeedDecreased { get; } = null!;
    public Event<ShotTaken34> ShotTaken { get; } = null!;

    public State Starting { get; } = null!;
    public State Started { get; } = null!;
    public State Running { get; } = null!;
    public State Walking { get; } = null!;
    public State Sipping { get; } = null!;
    public State Stalking { get; } = null!;
}


public class Start35
{
    public Guid CorrelationId { get; set; }
}

public class StartCompleted35
{
    public Guid CorrelationId { get; set; }
}

public class SpeedIncreased35
{
    public Guid CorrelationId { get; set; }
}

public class SpeedDecreased35
{
    public Guid CorrelationId { get; set; }
}

public class ShotTaken35
{
    public Guid CorrelationId { get; set; }
}

public class RequestA35
{
    public Guid CorrelationId { get; set; }
}

public class ResponseA35
{
    public Guid CorrelationId { get; set; }
}

public class RequestB35
{
    public Guid CorrelationId { get; set; }
}

public class ResponseB35
{
    public Guid CorrelationId { get; set; }
}

public class SampleStateMachineInstance35 :
    SagaStateMachineInstance
{
    public int CurrentState { get; set; }
    public Guid CorrelationId { get; set; }
}

public class SampleStateMachine35 :
    MassTransitStateMachine<SampleStateMachineInstance35>
{
    public SampleStateMachine35()
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
                .Request(ShotRequest, context => new RequestA35()),
            When(ShotRequest.Completed)
                .Then(_ => { }),
            When(ShotRequest.Faulted)
                .Then(_ => { }));
    }

    public Request<SampleStateMachineInstance35, RequestA35, ResponseA35> ShotRequest { get; } = null!;

    public Event<Start35> Start { get; } = null!;
    public Event<StartCompleted35> StartCompleted { get; } = null!;
    public Event<SpeedIncreased35> SpeedIncreased { get; } = null!;
    public Event<SpeedDecreased35> SpeedDecreased { get; } = null!;
    public Event<ShotTaken35> ShotTaken { get; } = null!;

    public State Starting { get; } = null!;
    public State Started { get; } = null!;
    public State Running { get; } = null!;
    public State Walking { get; } = null!;
    public State Sipping { get; } = null!;
    public State Stalking { get; } = null!;
}


public class Start36
{
    public Guid CorrelationId { get; set; }
}

public class StartCompleted36
{
    public Guid CorrelationId { get; set; }
}

public class SpeedIncreased36
{
    public Guid CorrelationId { get; set; }
}

public class SpeedDecreased36
{
    public Guid CorrelationId { get; set; }
}

public class ShotTaken36
{
    public Guid CorrelationId { get; set; }
}

public class RequestA36
{
    public Guid CorrelationId { get; set; }
}

public class ResponseA36
{
    public Guid CorrelationId { get; set; }
}

public class RequestB36
{
    public Guid CorrelationId { get; set; }
}

public class ResponseB36
{
    public Guid CorrelationId { get; set; }
}

public class SampleStateMachineInstance36 :
    SagaStateMachineInstance
{
    public int CurrentState { get; set; }
    public Guid CorrelationId { get; set; }
}

public class SampleStateMachine36 :
    MassTransitStateMachine<SampleStateMachineInstance36>
{
    public SampleStateMachine36()
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
                .Request(ShotRequest, context => new RequestA36()),
            When(ShotRequest.Completed)
                .Then(_ => { }),
            When(ShotRequest.Faulted)
                .Then(_ => { }));
    }

    public Request<SampleStateMachineInstance36, RequestA36, ResponseA36> ShotRequest { get; } = null!;

    public Event<Start36> Start { get; } = null!;
    public Event<StartCompleted36> StartCompleted { get; } = null!;
    public Event<SpeedIncreased36> SpeedIncreased { get; } = null!;
    public Event<SpeedDecreased36> SpeedDecreased { get; } = null!;
    public Event<ShotTaken36> ShotTaken { get; } = null!;

    public State Starting { get; } = null!;
    public State Started { get; } = null!;
    public State Running { get; } = null!;
    public State Walking { get; } = null!;
    public State Sipping { get; } = null!;
    public State Stalking { get; } = null!;
}


public class Start37
{
    public Guid CorrelationId { get; set; }
}

public class StartCompleted37
{
    public Guid CorrelationId { get; set; }
}

public class SpeedIncreased37
{
    public Guid CorrelationId { get; set; }
}

public class SpeedDecreased37
{
    public Guid CorrelationId { get; set; }
}

public class ShotTaken37
{
    public Guid CorrelationId { get; set; }
}

public class RequestA37
{
    public Guid CorrelationId { get; set; }
}

public class ResponseA37
{
    public Guid CorrelationId { get; set; }
}

public class RequestB37
{
    public Guid CorrelationId { get; set; }
}

public class ResponseB37
{
    public Guid CorrelationId { get; set; }
}

public class SampleStateMachineInstance37 :
    SagaStateMachineInstance
{
    public int CurrentState { get; set; }
    public Guid CorrelationId { get; set; }
}

public class SampleStateMachine37 :
    MassTransitStateMachine<SampleStateMachineInstance37>
{
    public SampleStateMachine37()
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
                .Request(ShotRequest, context => new RequestA37()),
            When(ShotRequest.Completed)
                .Then(_ => { }),
            When(ShotRequest.Faulted)
                .Then(_ => { }));
    }

    public Request<SampleStateMachineInstance37, RequestA37, ResponseA37> ShotRequest { get; } = null!;

    public Event<Start37> Start { get; } = null!;
    public Event<StartCompleted37> StartCompleted { get; } = null!;
    public Event<SpeedIncreased37> SpeedIncreased { get; } = null!;
    public Event<SpeedDecreased37> SpeedDecreased { get; } = null!;
    public Event<ShotTaken37> ShotTaken { get; } = null!;

    public State Starting { get; } = null!;
    public State Started { get; } = null!;
    public State Running { get; } = null!;
    public State Walking { get; } = null!;
    public State Sipping { get; } = null!;
    public State Stalking { get; } = null!;
}


public class Start38
{
    public Guid CorrelationId { get; set; }
}

public class StartCompleted38
{
    public Guid CorrelationId { get; set; }
}

public class SpeedIncreased38
{
    public Guid CorrelationId { get; set; }
}

public class SpeedDecreased38
{
    public Guid CorrelationId { get; set; }
}

public class ShotTaken38
{
    public Guid CorrelationId { get; set; }
}

public class RequestA38
{
    public Guid CorrelationId { get; set; }
}

public class ResponseA38
{
    public Guid CorrelationId { get; set; }
}

public class RequestB38
{
    public Guid CorrelationId { get; set; }
}

public class ResponseB38
{
    public Guid CorrelationId { get; set; }
}

public class SampleStateMachineInstance38 :
    SagaStateMachineInstance
{
    public int CurrentState { get; set; }
    public Guid CorrelationId { get; set; }
}

public class SampleStateMachine38 :
    MassTransitStateMachine<SampleStateMachineInstance38>
{
    public SampleStateMachine38()
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
                .Request(ShotRequest, context => new RequestA38()),
            When(ShotRequest.Completed)
                .Then(_ => { }),
            When(ShotRequest.Faulted)
                .Then(_ => { }));
    }

    public Request<SampleStateMachineInstance38, RequestA38, ResponseA38> ShotRequest { get; } = null!;

    public Event<Start38> Start { get; } = null!;
    public Event<StartCompleted38> StartCompleted { get; } = null!;
    public Event<SpeedIncreased38> SpeedIncreased { get; } = null!;
    public Event<SpeedDecreased38> SpeedDecreased { get; } = null!;
    public Event<ShotTaken38> ShotTaken { get; } = null!;

    public State Starting { get; } = null!;
    public State Started { get; } = null!;
    public State Running { get; } = null!;
    public State Walking { get; } = null!;
    public State Sipping { get; } = null!;
    public State Stalking { get; } = null!;
}


public class Start39
{
    public Guid CorrelationId { get; set; }
}

public class StartCompleted39
{
    public Guid CorrelationId { get; set; }
}

public class SpeedIncreased39
{
    public Guid CorrelationId { get; set; }
}

public class SpeedDecreased39
{
    public Guid CorrelationId { get; set; }
}

public class ShotTaken39
{
    public Guid CorrelationId { get; set; }
}

public class RequestA39
{
    public Guid CorrelationId { get; set; }
}

public class ResponseA39
{
    public Guid CorrelationId { get; set; }
}

public class RequestB39
{
    public Guid CorrelationId { get; set; }
}

public class ResponseB39
{
    public Guid CorrelationId { get; set; }
}

public class SampleStateMachineInstance39 :
    SagaStateMachineInstance
{
    public int CurrentState { get; set; }
    public Guid CorrelationId { get; set; }
}

public class SampleStateMachine39 :
    MassTransitStateMachine<SampleStateMachineInstance39>
{
    public SampleStateMachine39()
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
                .Request(ShotRequest, context => new RequestA39()),
            When(ShotRequest.Completed)
                .Then(_ => { }),
            When(ShotRequest.Faulted)
                .Then(_ => { }));
    }

    public Request<SampleStateMachineInstance39, RequestA39, ResponseA39> ShotRequest { get; } = null!;

    public Event<Start39> Start { get; } = null!;
    public Event<StartCompleted39> StartCompleted { get; } = null!;
    public Event<SpeedIncreased39> SpeedIncreased { get; } = null!;
    public Event<SpeedDecreased39> SpeedDecreased { get; } = null!;
    public Event<ShotTaken39> ShotTaken { get; } = null!;

    public State Starting { get; } = null!;
    public State Started { get; } = null!;
    public State Running { get; } = null!;
    public State Walking { get; } = null!;
    public State Sipping { get; } = null!;
    public State Stalking { get; } = null!;
}


public class Start40
{
    public Guid CorrelationId { get; set; }
}

public class StartCompleted40
{
    public Guid CorrelationId { get; set; }
}

public class SpeedIncreased40
{
    public Guid CorrelationId { get; set; }
}

public class SpeedDecreased40
{
    public Guid CorrelationId { get; set; }
}

public class ShotTaken40
{
    public Guid CorrelationId { get; set; }
}

public class RequestA40
{
    public Guid CorrelationId { get; set; }
}

public class ResponseA40
{
    public Guid CorrelationId { get; set; }
}

public class RequestB40
{
    public Guid CorrelationId { get; set; }
}

public class ResponseB40
{
    public Guid CorrelationId { get; set; }
}

public class SampleStateMachineInstance40 :
    SagaStateMachineInstance
{
    public int CurrentState { get; set; }
    public Guid CorrelationId { get; set; }
}

public class SampleStateMachine40 :
    MassTransitStateMachine<SampleStateMachineInstance40>
{
    public SampleStateMachine40()
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
                .Request(ShotRequest, context => new RequestA40()),
            When(ShotRequest.Completed)
                .Then(_ => { }),
            When(ShotRequest.Faulted)
                .Then(_ => { }));
    }

    public Request<SampleStateMachineInstance40, RequestA40, ResponseA40> ShotRequest { get; } = null!;

    public Event<Start40> Start { get; } = null!;
    public Event<StartCompleted40> StartCompleted { get; } = null!;
    public Event<SpeedIncreased40> SpeedIncreased { get; } = null!;
    public Event<SpeedDecreased40> SpeedDecreased { get; } = null!;
    public Event<ShotTaken40> ShotTaken { get; } = null!;

    public State Starting { get; } = null!;
    public State Started { get; } = null!;
    public State Running { get; } = null!;
    public State Walking { get; } = null!;
    public State Sipping { get; } = null!;
    public State Stalking { get; } = null!;
}


public class Start41
{
    public Guid CorrelationId { get; set; }
}

public class StartCompleted41
{
    public Guid CorrelationId { get; set; }
}

public class SpeedIncreased41
{
    public Guid CorrelationId { get; set; }
}

public class SpeedDecreased41
{
    public Guid CorrelationId { get; set; }
}

public class ShotTaken41
{
    public Guid CorrelationId { get; set; }
}

public class RequestA41
{
    public Guid CorrelationId { get; set; }
}

public class ResponseA41
{
    public Guid CorrelationId { get; set; }
}

public class RequestB41
{
    public Guid CorrelationId { get; set; }
}

public class ResponseB41
{
    public Guid CorrelationId { get; set; }
}

public class SampleStateMachineInstance41 :
    SagaStateMachineInstance
{
    public int CurrentState { get; set; }
    public Guid CorrelationId { get; set; }
}

public class SampleStateMachine41 :
    MassTransitStateMachine<SampleStateMachineInstance41>
{
    public SampleStateMachine41()
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
                .Request(ShotRequest, context => new RequestA41()),
            When(ShotRequest.Completed)
                .Then(_ => { }),
            When(ShotRequest.Faulted)
                .Then(_ => { }));
    }

    public Request<SampleStateMachineInstance41, RequestA41, ResponseA41> ShotRequest { get; } = null!;

    public Event<Start41> Start { get; } = null!;
    public Event<StartCompleted41> StartCompleted { get; } = null!;
    public Event<SpeedIncreased41> SpeedIncreased { get; } = null!;
    public Event<SpeedDecreased41> SpeedDecreased { get; } = null!;
    public Event<ShotTaken41> ShotTaken { get; } = null!;

    public State Starting { get; } = null!;
    public State Started { get; } = null!;
    public State Running { get; } = null!;
    public State Walking { get; } = null!;
    public State Sipping { get; } = null!;
    public State Stalking { get; } = null!;
}


public class Start42
{
    public Guid CorrelationId { get; set; }
}

public class StartCompleted42
{
    public Guid CorrelationId { get; set; }
}

public class SpeedIncreased42
{
    public Guid CorrelationId { get; set; }
}

public class SpeedDecreased42
{
    public Guid CorrelationId { get; set; }
}

public class ShotTaken42
{
    public Guid CorrelationId { get; set; }
}

public class RequestA42
{
    public Guid CorrelationId { get; set; }
}

public class ResponseA42
{
    public Guid CorrelationId { get; set; }
}

public class RequestB42
{
    public Guid CorrelationId { get; set; }
}

public class ResponseB42
{
    public Guid CorrelationId { get; set; }
}

public class SampleStateMachineInstance42 :
    SagaStateMachineInstance
{
    public int CurrentState { get; set; }
    public Guid CorrelationId { get; set; }
}

public class SampleStateMachine42 :
    MassTransitStateMachine<SampleStateMachineInstance42>
{
    public SampleStateMachine42()
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
                .Request(ShotRequest, context => new RequestA42()),
            When(ShotRequest.Completed)
                .Then(_ => { }),
            When(ShotRequest.Faulted)
                .Then(_ => { }));
    }

    public Request<SampleStateMachineInstance42, RequestA42, ResponseA42> ShotRequest { get; } = null!;

    public Event<Start42> Start { get; } = null!;
    public Event<StartCompleted42> StartCompleted { get; } = null!;
    public Event<SpeedIncreased42> SpeedIncreased { get; } = null!;
    public Event<SpeedDecreased42> SpeedDecreased { get; } = null!;
    public Event<ShotTaken42> ShotTaken { get; } = null!;

    public State Starting { get; } = null!;
    public State Started { get; } = null!;
    public State Running { get; } = null!;
    public State Walking { get; } = null!;
    public State Sipping { get; } = null!;
    public State Stalking { get; } = null!;
}


public class Start43
{
    public Guid CorrelationId { get; set; }
}

public class StartCompleted43
{
    public Guid CorrelationId { get; set; }
}

public class SpeedIncreased43
{
    public Guid CorrelationId { get; set; }
}

public class SpeedDecreased43
{
    public Guid CorrelationId { get; set; }
}

public class ShotTaken43
{
    public Guid CorrelationId { get; set; }
}

public class RequestA43
{
    public Guid CorrelationId { get; set; }
}

public class ResponseA43
{
    public Guid CorrelationId { get; set; }
}

public class RequestB43
{
    public Guid CorrelationId { get; set; }
}

public class ResponseB43
{
    public Guid CorrelationId { get; set; }
}

public class SampleStateMachineInstance43 :
    SagaStateMachineInstance
{
    public int CurrentState { get; set; }
    public Guid CorrelationId { get; set; }
}

public class SampleStateMachine43 :
    MassTransitStateMachine<SampleStateMachineInstance43>
{
    public SampleStateMachine43()
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
                .Request(ShotRequest, context => new RequestA43()),
            When(ShotRequest.Completed)
                .Then(_ => { }),
            When(ShotRequest.Faulted)
                .Then(_ => { }));
    }

    public Request<SampleStateMachineInstance43, RequestA43, ResponseA43> ShotRequest { get; } = null!;

    public Event<Start43> Start { get; } = null!;
    public Event<StartCompleted43> StartCompleted { get; } = null!;
    public Event<SpeedIncreased43> SpeedIncreased { get; } = null!;
    public Event<SpeedDecreased43> SpeedDecreased { get; } = null!;
    public Event<ShotTaken43> ShotTaken { get; } = null!;

    public State Starting { get; } = null!;
    public State Started { get; } = null!;
    public State Running { get; } = null!;
    public State Walking { get; } = null!;
    public State Sipping { get; } = null!;
    public State Stalking { get; } = null!;
}


public class Start44
{
    public Guid CorrelationId { get; set; }
}

public class StartCompleted44
{
    public Guid CorrelationId { get; set; }
}

public class SpeedIncreased44
{
    public Guid CorrelationId { get; set; }
}

public class SpeedDecreased44
{
    public Guid CorrelationId { get; set; }
}

public class ShotTaken44
{
    public Guid CorrelationId { get; set; }
}

public class RequestA44
{
    public Guid CorrelationId { get; set; }
}

public class ResponseA44
{
    public Guid CorrelationId { get; set; }
}

public class RequestB44
{
    public Guid CorrelationId { get; set; }
}

public class ResponseB44
{
    public Guid CorrelationId { get; set; }
}

public class SampleStateMachineInstance44 :
    SagaStateMachineInstance
{
    public int CurrentState { get; set; }
    public Guid CorrelationId { get; set; }
}

public class SampleStateMachine44 :
    MassTransitStateMachine<SampleStateMachineInstance44>
{
    public SampleStateMachine44()
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
                .Request(ShotRequest, context => new RequestA44()),
            When(ShotRequest.Completed)
                .Then(_ => { }),
            When(ShotRequest.Faulted)
                .Then(_ => { }));
    }

    public Request<SampleStateMachineInstance44, RequestA44, ResponseA44> ShotRequest { get; } = null!;

    public Event<Start44> Start { get; } = null!;
    public Event<StartCompleted44> StartCompleted { get; } = null!;
    public Event<SpeedIncreased44> SpeedIncreased { get; } = null!;
    public Event<SpeedDecreased44> SpeedDecreased { get; } = null!;
    public Event<ShotTaken44> ShotTaken { get; } = null!;

    public State Starting { get; } = null!;
    public State Started { get; } = null!;
    public State Running { get; } = null!;
    public State Walking { get; } = null!;
    public State Sipping { get; } = null!;
    public State Stalking { get; } = null!;
}


public class Start45
{
    public Guid CorrelationId { get; set; }
}

public class StartCompleted45
{
    public Guid CorrelationId { get; set; }
}

public class SpeedIncreased45
{
    public Guid CorrelationId { get; set; }
}

public class SpeedDecreased45
{
    public Guid CorrelationId { get; set; }
}

public class ShotTaken45
{
    public Guid CorrelationId { get; set; }
}

public class RequestA45
{
    public Guid CorrelationId { get; set; }
}

public class ResponseA45
{
    public Guid CorrelationId { get; set; }
}

public class RequestB45
{
    public Guid CorrelationId { get; set; }
}

public class ResponseB45
{
    public Guid CorrelationId { get; set; }
}

public class SampleStateMachineInstance45 :
    SagaStateMachineInstance
{
    public int CurrentState { get; set; }
    public Guid CorrelationId { get; set; }
}

public class SampleStateMachine45 :
    MassTransitStateMachine<SampleStateMachineInstance45>
{
    public SampleStateMachine45()
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
                .Request(ShotRequest, context => new RequestA45()),
            When(ShotRequest.Completed)
                .Then(_ => { }),
            When(ShotRequest.Faulted)
                .Then(_ => { }));
    }

    public Request<SampleStateMachineInstance45, RequestA45, ResponseA45> ShotRequest { get; } = null!;

    public Event<Start45> Start { get; } = null!;
    public Event<StartCompleted45> StartCompleted { get; } = null!;
    public Event<SpeedIncreased45> SpeedIncreased { get; } = null!;
    public Event<SpeedDecreased45> SpeedDecreased { get; } = null!;
    public Event<ShotTaken45> ShotTaken { get; } = null!;

    public State Starting { get; } = null!;
    public State Started { get; } = null!;
    public State Running { get; } = null!;
    public State Walking { get; } = null!;
    public State Sipping { get; } = null!;
    public State Stalking { get; } = null!;
}


public class Start46
{
    public Guid CorrelationId { get; set; }
}

public class StartCompleted46
{
    public Guid CorrelationId { get; set; }
}

public class SpeedIncreased46
{
    public Guid CorrelationId { get; set; }
}

public class SpeedDecreased46
{
    public Guid CorrelationId { get; set; }
}

public class ShotTaken46
{
    public Guid CorrelationId { get; set; }
}

public class RequestA46
{
    public Guid CorrelationId { get; set; }
}

public class ResponseA46
{
    public Guid CorrelationId { get; set; }
}

public class RequestB46
{
    public Guid CorrelationId { get; set; }
}

public class ResponseB46
{
    public Guid CorrelationId { get; set; }
}

public class SampleStateMachineInstance46 :
    SagaStateMachineInstance
{
    public int CurrentState { get; set; }
    public Guid CorrelationId { get; set; }
}

public class SampleStateMachine46 :
    MassTransitStateMachine<SampleStateMachineInstance46>
{
    public SampleStateMachine46()
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
                .Request(ShotRequest, context => new RequestA46()),
            When(ShotRequest.Completed)
                .Then(_ => { }),
            When(ShotRequest.Faulted)
                .Then(_ => { }));
    }

    public Request<SampleStateMachineInstance46, RequestA46, ResponseA46> ShotRequest { get; } = null!;

    public Event<Start46> Start { get; } = null!;
    public Event<StartCompleted46> StartCompleted { get; } = null!;
    public Event<SpeedIncreased46> SpeedIncreased { get; } = null!;
    public Event<SpeedDecreased46> SpeedDecreased { get; } = null!;
    public Event<ShotTaken46> ShotTaken { get; } = null!;

    public State Starting { get; } = null!;
    public State Started { get; } = null!;
    public State Running { get; } = null!;
    public State Walking { get; } = null!;
    public State Sipping { get; } = null!;
    public State Stalking { get; } = null!;
}


public class Start47
{
    public Guid CorrelationId { get; set; }
}

public class StartCompleted47
{
    public Guid CorrelationId { get; set; }
}

public class SpeedIncreased47
{
    public Guid CorrelationId { get; set; }
}

public class SpeedDecreased47
{
    public Guid CorrelationId { get; set; }
}

public class ShotTaken47
{
    public Guid CorrelationId { get; set; }
}

public class RequestA47
{
    public Guid CorrelationId { get; set; }
}

public class ResponseA47
{
    public Guid CorrelationId { get; set; }
}

public class RequestB47
{
    public Guid CorrelationId { get; set; }
}

public class ResponseB47
{
    public Guid CorrelationId { get; set; }
}

public class SampleStateMachineInstance47 :
    SagaStateMachineInstance
{
    public int CurrentState { get; set; }
    public Guid CorrelationId { get; set; }
}

public class SampleStateMachine47 :
    MassTransitStateMachine<SampleStateMachineInstance47>
{
    public SampleStateMachine47()
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
                .Request(ShotRequest, context => new RequestA47()),
            When(ShotRequest.Completed)
                .Then(_ => { }),
            When(ShotRequest.Faulted)
                .Then(_ => { }));
    }

    public Request<SampleStateMachineInstance47, RequestA47, ResponseA47> ShotRequest { get; } = null!;

    public Event<Start47> Start { get; } = null!;
    public Event<StartCompleted47> StartCompleted { get; } = null!;
    public Event<SpeedIncreased47> SpeedIncreased { get; } = null!;
    public Event<SpeedDecreased47> SpeedDecreased { get; } = null!;
    public Event<ShotTaken47> ShotTaken { get; } = null!;

    public State Starting { get; } = null!;
    public State Started { get; } = null!;
    public State Running { get; } = null!;
    public State Walking { get; } = null!;
    public State Sipping { get; } = null!;
    public State Stalking { get; } = null!;
}


public class Start48
{
    public Guid CorrelationId { get; set; }
}

public class StartCompleted48
{
    public Guid CorrelationId { get; set; }
}

public class SpeedIncreased48
{
    public Guid CorrelationId { get; set; }
}

public class SpeedDecreased48
{
    public Guid CorrelationId { get; set; }
}

public class ShotTaken48
{
    public Guid CorrelationId { get; set; }
}

public class RequestA48
{
    public Guid CorrelationId { get; set; }
}

public class ResponseA48
{
    public Guid CorrelationId { get; set; }
}

public class RequestB48
{
    public Guid CorrelationId { get; set; }
}

public class ResponseB48
{
    public Guid CorrelationId { get; set; }
}

public class SampleStateMachineInstance48 :
    SagaStateMachineInstance
{
    public int CurrentState { get; set; }
    public Guid CorrelationId { get; set; }
}

public class SampleStateMachine48 :
    MassTransitStateMachine<SampleStateMachineInstance48>
{
    public SampleStateMachine48()
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
                .Request(ShotRequest, context => new RequestA48()),
            When(ShotRequest.Completed)
                .Then(_ => { }),
            When(ShotRequest.Faulted)
                .Then(_ => { }));
    }

    public Request<SampleStateMachineInstance48, RequestA48, ResponseA48> ShotRequest { get; } = null!;

    public Event<Start48> Start { get; } = null!;
    public Event<StartCompleted48> StartCompleted { get; } = null!;
    public Event<SpeedIncreased48> SpeedIncreased { get; } = null!;
    public Event<SpeedDecreased48> SpeedDecreased { get; } = null!;
    public Event<ShotTaken48> ShotTaken { get; } = null!;

    public State Starting { get; } = null!;
    public State Started { get; } = null!;
    public State Running { get; } = null!;
    public State Walking { get; } = null!;
    public State Sipping { get; } = null!;
    public State Stalking { get; } = null!;
}


public class Start49
{
    public Guid CorrelationId { get; set; }
}

public class StartCompleted49
{
    public Guid CorrelationId { get; set; }
}

public class SpeedIncreased49
{
    public Guid CorrelationId { get; set; }
}

public class SpeedDecreased49
{
    public Guid CorrelationId { get; set; }
}

public class ShotTaken49
{
    public Guid CorrelationId { get; set; }
}

public class RequestA49
{
    public Guid CorrelationId { get; set; }
}

public class ResponseA49
{
    public Guid CorrelationId { get; set; }
}

public class RequestB49
{
    public Guid CorrelationId { get; set; }
}

public class ResponseB49
{
    public Guid CorrelationId { get; set; }
}

public class SampleStateMachineInstance49 :
    SagaStateMachineInstance
{
    public int CurrentState { get; set; }
    public Guid CorrelationId { get; set; }
}

public class SampleStateMachine49 :
    MassTransitStateMachine<SampleStateMachineInstance49>
{
    public SampleStateMachine49()
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
                .Request(ShotRequest, context => new RequestA49()),
            When(ShotRequest.Completed)
                .Then(_ => { }),
            When(ShotRequest.Faulted)
                .Then(_ => { }));
    }

    public Request<SampleStateMachineInstance49, RequestA49, ResponseA49> ShotRequest { get; } = null!;

    public Event<Start49> Start { get; } = null!;
    public Event<StartCompleted49> StartCompleted { get; } = null!;
    public Event<SpeedIncreased49> SpeedIncreased { get; } = null!;
    public Event<SpeedDecreased49> SpeedDecreased { get; } = null!;
    public Event<ShotTaken49> ShotTaken { get; } = null!;

    public State Starting { get; } = null!;
    public State Started { get; } = null!;
    public State Running { get; } = null!;
    public State Walking { get; } = null!;
    public State Sipping { get; } = null!;
    public State Stalking { get; } = null!;
}


public class Start50
{
    public Guid CorrelationId { get; set; }
}

public class StartCompleted50
{
    public Guid CorrelationId { get; set; }
}

public class SpeedIncreased50
{
    public Guid CorrelationId { get; set; }
}

public class SpeedDecreased50
{
    public Guid CorrelationId { get; set; }
}

public class ShotTaken50
{
    public Guid CorrelationId { get; set; }
}

public class RequestA50
{
    public Guid CorrelationId { get; set; }
}

public class ResponseA50
{
    public Guid CorrelationId { get; set; }
}

public class RequestB50
{
    public Guid CorrelationId { get; set; }
}

public class ResponseB50
{
    public Guid CorrelationId { get; set; }
}

public class SampleStateMachineInstance50 :
    SagaStateMachineInstance
{
    public int CurrentState { get; set; }
    public Guid CorrelationId { get; set; }
}

public class SampleStateMachine50 :
    MassTransitStateMachine<SampleStateMachineInstance50>
{
    public SampleStateMachine50()
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
                .Request(ShotRequest, context => new RequestA50()),
            When(ShotRequest.Completed)
                .Then(_ => { }),
            When(ShotRequest.Faulted)
                .Then(_ => { }));
    }

    public Request<SampleStateMachineInstance50, RequestA50, ResponseA50> ShotRequest { get; } = null!;

    public Event<Start50> Start { get; } = null!;
    public Event<StartCompleted50> StartCompleted { get; } = null!;
    public Event<SpeedIncreased50> SpeedIncreased { get; } = null!;
    public Event<SpeedDecreased50> SpeedDecreased { get; } = null!;
    public Event<ShotTaken50> ShotTaken { get; } = null!;

    public State Starting { get; } = null!;
    public State Started { get; } = null!;
    public State Running { get; } = null!;
    public State Walking { get; } = null!;
    public State Sipping { get; } = null!;
    public State Stalking { get; } = null!;
}


public class Start51
{
    public Guid CorrelationId { get; set; }
}

public class StartCompleted51
{
    public Guid CorrelationId { get; set; }
}

public class SpeedIncreased51
{
    public Guid CorrelationId { get; set; }
}

public class SpeedDecreased51
{
    public Guid CorrelationId { get; set; }
}

public class ShotTaken51
{
    public Guid CorrelationId { get; set; }
}

public class RequestA51
{
    public Guid CorrelationId { get; set; }
}

public class ResponseA51
{
    public Guid CorrelationId { get; set; }
}

public class RequestB51
{
    public Guid CorrelationId { get; set; }
}

public class ResponseB51
{
    public Guid CorrelationId { get; set; }
}

public class SampleStateMachineInstance51 :
    SagaStateMachineInstance
{
    public int CurrentState { get; set; }
    public Guid CorrelationId { get; set; }
}

public class SampleStateMachine51 :
    MassTransitStateMachine<SampleStateMachineInstance51>
{
    public SampleStateMachine51()
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
                .Request(ShotRequest, context => new RequestA51()),
            When(ShotRequest.Completed)
                .Then(_ => { }),
            When(ShotRequest.Faulted)
                .Then(_ => { }));
    }

    public Request<SampleStateMachineInstance51, RequestA51, ResponseA51> ShotRequest { get; } = null!;

    public Event<Start51> Start { get; } = null!;
    public Event<StartCompleted51> StartCompleted { get; } = null!;
    public Event<SpeedIncreased51> SpeedIncreased { get; } = null!;
    public Event<SpeedDecreased51> SpeedDecreased { get; } = null!;
    public Event<ShotTaken51> ShotTaken { get; } = null!;

    public State Starting { get; } = null!;
    public State Started { get; } = null!;
    public State Running { get; } = null!;
    public State Walking { get; } = null!;
    public State Sipping { get; } = null!;
    public State Stalking { get; } = null!;
}


public class Start52
{
    public Guid CorrelationId { get; set; }
}

public class StartCompleted52
{
    public Guid CorrelationId { get; set; }
}

public class SpeedIncreased52
{
    public Guid CorrelationId { get; set; }
}

public class SpeedDecreased52
{
    public Guid CorrelationId { get; set; }
}

public class ShotTaken52
{
    public Guid CorrelationId { get; set; }
}

public class RequestA52
{
    public Guid CorrelationId { get; set; }
}

public class ResponseA52
{
    public Guid CorrelationId { get; set; }
}

public class RequestB52
{
    public Guid CorrelationId { get; set; }
}

public class ResponseB52
{
    public Guid CorrelationId { get; set; }
}

public class SampleStateMachineInstance52 :
    SagaStateMachineInstance
{
    public int CurrentState { get; set; }
    public Guid CorrelationId { get; set; }
}

public class SampleStateMachine52 :
    MassTransitStateMachine<SampleStateMachineInstance52>
{
    public SampleStateMachine52()
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
                .Request(ShotRequest, context => new RequestA52()),
            When(ShotRequest.Completed)
                .Then(_ => { }),
            When(ShotRequest.Faulted)
                .Then(_ => { }));
    }

    public Request<SampleStateMachineInstance52, RequestA52, ResponseA52> ShotRequest { get; } = null!;

    public Event<Start52> Start { get; } = null!;
    public Event<StartCompleted52> StartCompleted { get; } = null!;
    public Event<SpeedIncreased52> SpeedIncreased { get; } = null!;
    public Event<SpeedDecreased52> SpeedDecreased { get; } = null!;
    public Event<ShotTaken52> ShotTaken { get; } = null!;

    public State Starting { get; } = null!;
    public State Started { get; } = null!;
    public State Running { get; } = null!;
    public State Walking { get; } = null!;
    public State Sipping { get; } = null!;
    public State Stalking { get; } = null!;
}


public class Start53
{
    public Guid CorrelationId { get; set; }
}

public class StartCompleted53
{
    public Guid CorrelationId { get; set; }
}

public class SpeedIncreased53
{
    public Guid CorrelationId { get; set; }
}

public class SpeedDecreased53
{
    public Guid CorrelationId { get; set; }
}

public class ShotTaken53
{
    public Guid CorrelationId { get; set; }
}

public class RequestA53
{
    public Guid CorrelationId { get; set; }
}

public class ResponseA53
{
    public Guid CorrelationId { get; set; }
}

public class RequestB53
{
    public Guid CorrelationId { get; set; }
}

public class ResponseB53
{
    public Guid CorrelationId { get; set; }
}

public class SampleStateMachineInstance53 :
    SagaStateMachineInstance
{
    public int CurrentState { get; set; }
    public Guid CorrelationId { get; set; }
}

public class SampleStateMachine53 :
    MassTransitStateMachine<SampleStateMachineInstance53>
{
    public SampleStateMachine53()
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
                .Request(ShotRequest, context => new RequestA53()),
            When(ShotRequest.Completed)
                .Then(_ => { }),
            When(ShotRequest.Faulted)
                .Then(_ => { }));
    }

    public Request<SampleStateMachineInstance53, RequestA53, ResponseA53> ShotRequest { get; } = null!;

    public Event<Start53> Start { get; } = null!;
    public Event<StartCompleted53> StartCompleted { get; } = null!;
    public Event<SpeedIncreased53> SpeedIncreased { get; } = null!;
    public Event<SpeedDecreased53> SpeedDecreased { get; } = null!;
    public Event<ShotTaken53> ShotTaken { get; } = null!;

    public State Starting { get; } = null!;
    public State Started { get; } = null!;
    public State Running { get; } = null!;
    public State Walking { get; } = null!;
    public State Sipping { get; } = null!;
    public State Stalking { get; } = null!;
}


public class Start54
{
    public Guid CorrelationId { get; set; }
}

public class StartCompleted54
{
    public Guid CorrelationId { get; set; }
}

public class SpeedIncreased54
{
    public Guid CorrelationId { get; set; }
}

public class SpeedDecreased54
{
    public Guid CorrelationId { get; set; }
}

public class ShotTaken54
{
    public Guid CorrelationId { get; set; }
}

public class RequestA54
{
    public Guid CorrelationId { get; set; }
}

public class ResponseA54
{
    public Guid CorrelationId { get; set; }
}

public class RequestB54
{
    public Guid CorrelationId { get; set; }
}

public class ResponseB54
{
    public Guid CorrelationId { get; set; }
}

public class SampleStateMachineInstance54 :
    SagaStateMachineInstance
{
    public int CurrentState { get; set; }
    public Guid CorrelationId { get; set; }
}

public class SampleStateMachine54 :
    MassTransitStateMachine<SampleStateMachineInstance54>
{
    public SampleStateMachine54()
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
                .Request(ShotRequest, context => new RequestA54()),
            When(ShotRequest.Completed)
                .Then(_ => { }),
            When(ShotRequest.Faulted)
                .Then(_ => { }));
    }

    public Request<SampleStateMachineInstance54, RequestA54, ResponseA54> ShotRequest { get; } = null!;

    public Event<Start54> Start { get; } = null!;
    public Event<StartCompleted54> StartCompleted { get; } = null!;
    public Event<SpeedIncreased54> SpeedIncreased { get; } = null!;
    public Event<SpeedDecreased54> SpeedDecreased { get; } = null!;
    public Event<ShotTaken54> ShotTaken { get; } = null!;

    public State Starting { get; } = null!;
    public State Started { get; } = null!;
    public State Running { get; } = null!;
    public State Walking { get; } = null!;
    public State Sipping { get; } = null!;
    public State Stalking { get; } = null!;
}


public class Start55
{
    public Guid CorrelationId { get; set; }
}

public class StartCompleted55
{
    public Guid CorrelationId { get; set; }
}

public class SpeedIncreased55
{
    public Guid CorrelationId { get; set; }
}

public class SpeedDecreased55
{
    public Guid CorrelationId { get; set; }
}

public class ShotTaken55
{
    public Guid CorrelationId { get; set; }
}

public class RequestA55
{
    public Guid CorrelationId { get; set; }
}

public class ResponseA55
{
    public Guid CorrelationId { get; set; }
}

public class RequestB55
{
    public Guid CorrelationId { get; set; }
}

public class ResponseB55
{
    public Guid CorrelationId { get; set; }
}

public class SampleStateMachineInstance55 :
    SagaStateMachineInstance
{
    public int CurrentState { get; set; }
    public Guid CorrelationId { get; set; }
}

public class SampleStateMachine55 :
    MassTransitStateMachine<SampleStateMachineInstance55>
{
    public SampleStateMachine55()
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
                .Request(ShotRequest, context => new RequestA55()),
            When(ShotRequest.Completed)
                .Then(_ => { }),
            When(ShotRequest.Faulted)
                .Then(_ => { }));
    }

    public Request<SampleStateMachineInstance55, RequestA55, ResponseA55> ShotRequest { get; } = null!;

    public Event<Start55> Start { get; } = null!;
    public Event<StartCompleted55> StartCompleted { get; } = null!;
    public Event<SpeedIncreased55> SpeedIncreased { get; } = null!;
    public Event<SpeedDecreased55> SpeedDecreased { get; } = null!;
    public Event<ShotTaken55> ShotTaken { get; } = null!;

    public State Starting { get; } = null!;
    public State Started { get; } = null!;
    public State Running { get; } = null!;
    public State Walking { get; } = null!;
    public State Sipping { get; } = null!;
    public State Stalking { get; } = null!;
}


public class Start56
{
    public Guid CorrelationId { get; set; }
}

public class StartCompleted56
{
    public Guid CorrelationId { get; set; }
}

public class SpeedIncreased56
{
    public Guid CorrelationId { get; set; }
}

public class SpeedDecreased56
{
    public Guid CorrelationId { get; set; }
}

public class ShotTaken56
{
    public Guid CorrelationId { get; set; }
}

public class RequestA56
{
    public Guid CorrelationId { get; set; }
}

public class ResponseA56
{
    public Guid CorrelationId { get; set; }
}

public class RequestB56
{
    public Guid CorrelationId { get; set; }
}

public class ResponseB56
{
    public Guid CorrelationId { get; set; }
}

public class SampleStateMachineInstance56 :
    SagaStateMachineInstance
{
    public int CurrentState { get; set; }
    public Guid CorrelationId { get; set; }
}

public class SampleStateMachine56 :
    MassTransitStateMachine<SampleStateMachineInstance56>
{
    public SampleStateMachine56()
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
                .Request(ShotRequest, context => new RequestA56()),
            When(ShotRequest.Completed)
                .Then(_ => { }),
            When(ShotRequest.Faulted)
                .Then(_ => { }));
    }

    public Request<SampleStateMachineInstance56, RequestA56, ResponseA56> ShotRequest { get; } = null!;

    public Event<Start56> Start { get; } = null!;
    public Event<StartCompleted56> StartCompleted { get; } = null!;
    public Event<SpeedIncreased56> SpeedIncreased { get; } = null!;
    public Event<SpeedDecreased56> SpeedDecreased { get; } = null!;
    public Event<ShotTaken56> ShotTaken { get; } = null!;

    public State Starting { get; } = null!;
    public State Started { get; } = null!;
    public State Running { get; } = null!;
    public State Walking { get; } = null!;
    public State Sipping { get; } = null!;
    public State Stalking { get; } = null!;
}


public class Start57
{
    public Guid CorrelationId { get; set; }
}

public class StartCompleted57
{
    public Guid CorrelationId { get; set; }
}

public class SpeedIncreased57
{
    public Guid CorrelationId { get; set; }
}

public class SpeedDecreased57
{
    public Guid CorrelationId { get; set; }
}

public class ShotTaken57
{
    public Guid CorrelationId { get; set; }
}

public class RequestA57
{
    public Guid CorrelationId { get; set; }
}

public class ResponseA57
{
    public Guid CorrelationId { get; set; }
}

public class RequestB57
{
    public Guid CorrelationId { get; set; }
}

public class ResponseB57
{
    public Guid CorrelationId { get; set; }
}

public class SampleStateMachineInstance57 :
    SagaStateMachineInstance
{
    public int CurrentState { get; set; }
    public Guid CorrelationId { get; set; }
}

public class SampleStateMachine57 :
    MassTransitStateMachine<SampleStateMachineInstance57>
{
    public SampleStateMachine57()
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
                .Request(ShotRequest, context => new RequestA57()),
            When(ShotRequest.Completed)
                .Then(_ => { }),
            When(ShotRequest.Faulted)
                .Then(_ => { }));
    }

    public Request<SampleStateMachineInstance57, RequestA57, ResponseA57> ShotRequest { get; } = null!;

    public Event<Start57> Start { get; } = null!;
    public Event<StartCompleted57> StartCompleted { get; } = null!;
    public Event<SpeedIncreased57> SpeedIncreased { get; } = null!;
    public Event<SpeedDecreased57> SpeedDecreased { get; } = null!;
    public Event<ShotTaken57> ShotTaken { get; } = null!;

    public State Starting { get; } = null!;
    public State Started { get; } = null!;
    public State Running { get; } = null!;
    public State Walking { get; } = null!;
    public State Sipping { get; } = null!;
    public State Stalking { get; } = null!;
}


public class Start58
{
    public Guid CorrelationId { get; set; }
}

public class StartCompleted58
{
    public Guid CorrelationId { get; set; }
}

public class SpeedIncreased58
{
    public Guid CorrelationId { get; set; }
}

public class SpeedDecreased58
{
    public Guid CorrelationId { get; set; }
}

public class ShotTaken58
{
    public Guid CorrelationId { get; set; }
}

public class RequestA58
{
    public Guid CorrelationId { get; set; }
}

public class ResponseA58
{
    public Guid CorrelationId { get; set; }
}

public class RequestB58
{
    public Guid CorrelationId { get; set; }
}

public class ResponseB58
{
    public Guid CorrelationId { get; set; }
}

public class SampleStateMachineInstance58 :
    SagaStateMachineInstance
{
    public int CurrentState { get; set; }
    public Guid CorrelationId { get; set; }
}

public class SampleStateMachine58 :
    MassTransitStateMachine<SampleStateMachineInstance58>
{
    public SampleStateMachine58()
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
                .Request(ShotRequest, context => new RequestA58()),
            When(ShotRequest.Completed)
                .Then(_ => { }),
            When(ShotRequest.Faulted)
                .Then(_ => { }));
    }

    public Request<SampleStateMachineInstance58, RequestA58, ResponseA58> ShotRequest { get; } = null!;

    public Event<Start58> Start { get; } = null!;
    public Event<StartCompleted58> StartCompleted { get; } = null!;
    public Event<SpeedIncreased58> SpeedIncreased { get; } = null!;
    public Event<SpeedDecreased58> SpeedDecreased { get; } = null!;
    public Event<ShotTaken58> ShotTaken { get; } = null!;

    public State Starting { get; } = null!;
    public State Started { get; } = null!;
    public State Running { get; } = null!;
    public State Walking { get; } = null!;
    public State Sipping { get; } = null!;
    public State Stalking { get; } = null!;
}


public class Start59
{
    public Guid CorrelationId { get; set; }
}

public class StartCompleted59
{
    public Guid CorrelationId { get; set; }
}

public class SpeedIncreased59
{
    public Guid CorrelationId { get; set; }
}

public class SpeedDecreased59
{
    public Guid CorrelationId { get; set; }
}

public class ShotTaken59
{
    public Guid CorrelationId { get; set; }
}

public class RequestA59
{
    public Guid CorrelationId { get; set; }
}

public class ResponseA59
{
    public Guid CorrelationId { get; set; }
}

public class RequestB59
{
    public Guid CorrelationId { get; set; }
}

public class ResponseB59
{
    public Guid CorrelationId { get; set; }
}

public class SampleStateMachineInstance59 :
    SagaStateMachineInstance
{
    public int CurrentState { get; set; }
    public Guid CorrelationId { get; set; }
}

public class SampleStateMachine59 :
    MassTransitStateMachine<SampleStateMachineInstance59>
{
    public SampleStateMachine59()
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
                .Request(ShotRequest, context => new RequestA59()),
            When(ShotRequest.Completed)
                .Then(_ => { }),
            When(ShotRequest.Faulted)
                .Then(_ => { }));
    }

    public Request<SampleStateMachineInstance59, RequestA59, ResponseA59> ShotRequest { get; } = null!;

    public Event<Start59> Start { get; } = null!;
    public Event<StartCompleted59> StartCompleted { get; } = null!;
    public Event<SpeedIncreased59> SpeedIncreased { get; } = null!;
    public Event<SpeedDecreased59> SpeedDecreased { get; } = null!;
    public Event<ShotTaken59> ShotTaken { get; } = null!;

    public State Starting { get; } = null!;
    public State Started { get; } = null!;
    public State Running { get; } = null!;
    public State Walking { get; } = null!;
    public State Sipping { get; } = null!;
    public State Stalking { get; } = null!;
}


public class Start60
{
    public Guid CorrelationId { get; set; }
}

public class StartCompleted60
{
    public Guid CorrelationId { get; set; }
}

public class SpeedIncreased60
{
    public Guid CorrelationId { get; set; }
}

public class SpeedDecreased60
{
    public Guid CorrelationId { get; set; }
}

public class ShotTaken60
{
    public Guid CorrelationId { get; set; }
}

public class RequestA60
{
    public Guid CorrelationId { get; set; }
}

public class ResponseA60
{
    public Guid CorrelationId { get; set; }
}

public class RequestB60
{
    public Guid CorrelationId { get; set; }
}

public class ResponseB60
{
    public Guid CorrelationId { get; set; }
}

public class SampleStateMachineInstance60 :
    SagaStateMachineInstance
{
    public int CurrentState { get; set; }
    public Guid CorrelationId { get; set; }
}

public class SampleStateMachine60 :
    MassTransitStateMachine<SampleStateMachineInstance60>
{
    public SampleStateMachine60()
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
                .Request(ShotRequest, context => new RequestA60()),
            When(ShotRequest.Completed)
                .Then(_ => { }),
            When(ShotRequest.Faulted)
                .Then(_ => { }));
    }

    public Request<SampleStateMachineInstance60, RequestA60, ResponseA60> ShotRequest { get; } = null!;

    public Event<Start60> Start { get; } = null!;
    public Event<StartCompleted60> StartCompleted { get; } = null!;
    public Event<SpeedIncreased60> SpeedIncreased { get; } = null!;
    public Event<SpeedDecreased60> SpeedDecreased { get; } = null!;
    public Event<ShotTaken60> ShotTaken { get; } = null!;

    public State Starting { get; } = null!;
    public State Started { get; } = null!;
    public State Running { get; } = null!;
    public State Walking { get; } = null!;
    public State Sipping { get; } = null!;
    public State Stalking { get; } = null!;
}


public class Start61
{
    public Guid CorrelationId { get; set; }
}

public class StartCompleted61
{
    public Guid CorrelationId { get; set; }
}

public class SpeedIncreased61
{
    public Guid CorrelationId { get; set; }
}

public class SpeedDecreased61
{
    public Guid CorrelationId { get; set; }
}

public class ShotTaken61
{
    public Guid CorrelationId { get; set; }
}

public class RequestA61
{
    public Guid CorrelationId { get; set; }
}

public class ResponseA61
{
    public Guid CorrelationId { get; set; }
}

public class RequestB61
{
    public Guid CorrelationId { get; set; }
}

public class ResponseB61
{
    public Guid CorrelationId { get; set; }
}

public class SampleStateMachineInstance61 :
    SagaStateMachineInstance
{
    public int CurrentState { get; set; }
    public Guid CorrelationId { get; set; }
}

public class SampleStateMachine61 :
    MassTransitStateMachine<SampleStateMachineInstance61>
{
    public SampleStateMachine61()
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
                .Request(ShotRequest, context => new RequestA61()),
            When(ShotRequest.Completed)
                .Then(_ => { }),
            When(ShotRequest.Faulted)
                .Then(_ => { }));
    }

    public Request<SampleStateMachineInstance61, RequestA61, ResponseA61> ShotRequest { get; } = null!;

    public Event<Start61> Start { get; } = null!;
    public Event<StartCompleted61> StartCompleted { get; } = null!;
    public Event<SpeedIncreased61> SpeedIncreased { get; } = null!;
    public Event<SpeedDecreased61> SpeedDecreased { get; } = null!;
    public Event<ShotTaken61> ShotTaken { get; } = null!;

    public State Starting { get; } = null!;
    public State Started { get; } = null!;
    public State Running { get; } = null!;
    public State Walking { get; } = null!;
    public State Sipping { get; } = null!;
    public State Stalking { get; } = null!;
}


public class Start62
{
    public Guid CorrelationId { get; set; }
}

public class StartCompleted62
{
    public Guid CorrelationId { get; set; }
}

public class SpeedIncreased62
{
    public Guid CorrelationId { get; set; }
}

public class SpeedDecreased62
{
    public Guid CorrelationId { get; set; }
}

public class ShotTaken62
{
    public Guid CorrelationId { get; set; }
}

public class RequestA62
{
    public Guid CorrelationId { get; set; }
}

public class ResponseA62
{
    public Guid CorrelationId { get; set; }
}

public class RequestB62
{
    public Guid CorrelationId { get; set; }
}

public class ResponseB62
{
    public Guid CorrelationId { get; set; }
}

public class SampleStateMachineInstance62 :
    SagaStateMachineInstance
{
    public int CurrentState { get; set; }
    public Guid CorrelationId { get; set; }
}

public class SampleStateMachine62 :
    MassTransitStateMachine<SampleStateMachineInstance62>
{
    public SampleStateMachine62()
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
                .Request(ShotRequest, context => new RequestA62()),
            When(ShotRequest.Completed)
                .Then(_ => { }),
            When(ShotRequest.Faulted)
                .Then(_ => { }));
    }

    public Request<SampleStateMachineInstance62, RequestA62, ResponseA62> ShotRequest { get; } = null!;

    public Event<Start62> Start { get; } = null!;
    public Event<StartCompleted62> StartCompleted { get; } = null!;
    public Event<SpeedIncreased62> SpeedIncreased { get; } = null!;
    public Event<SpeedDecreased62> SpeedDecreased { get; } = null!;
    public Event<ShotTaken62> ShotTaken { get; } = null!;

    public State Starting { get; } = null!;
    public State Started { get; } = null!;
    public State Running { get; } = null!;
    public State Walking { get; } = null!;
    public State Sipping { get; } = null!;
    public State Stalking { get; } = null!;
}


public class Start63
{
    public Guid CorrelationId { get; set; }
}

public class StartCompleted63
{
    public Guid CorrelationId { get; set; }
}

public class SpeedIncreased63
{
    public Guid CorrelationId { get; set; }
}

public class SpeedDecreased63
{
    public Guid CorrelationId { get; set; }
}

public class ShotTaken63
{
    public Guid CorrelationId { get; set; }
}

public class RequestA63
{
    public Guid CorrelationId { get; set; }
}

public class ResponseA63
{
    public Guid CorrelationId { get; set; }
}

public class RequestB63
{
    public Guid CorrelationId { get; set; }
}

public class ResponseB63
{
    public Guid CorrelationId { get; set; }
}

public class SampleStateMachineInstance63 :
    SagaStateMachineInstance
{
    public int CurrentState { get; set; }
    public Guid CorrelationId { get; set; }
}

public class SampleStateMachine63 :
    MassTransitStateMachine<SampleStateMachineInstance63>
{
    public SampleStateMachine63()
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
                .Request(ShotRequest, context => new RequestA63()),
            When(ShotRequest.Completed)
                .Then(_ => { }),
            When(ShotRequest.Faulted)
                .Then(_ => { }));
    }

    public Request<SampleStateMachineInstance63, RequestA63, ResponseA63> ShotRequest { get; } = null!;

    public Event<Start63> Start { get; } = null!;
    public Event<StartCompleted63> StartCompleted { get; } = null!;
    public Event<SpeedIncreased63> SpeedIncreased { get; } = null!;
    public Event<SpeedDecreased63> SpeedDecreased { get; } = null!;
    public Event<ShotTaken63> ShotTaken { get; } = null!;

    public State Starting { get; } = null!;
    public State Started { get; } = null!;
    public State Running { get; } = null!;
    public State Walking { get; } = null!;
    public State Sipping { get; } = null!;
    public State Stalking { get; } = null!;
}


public class Start64
{
    public Guid CorrelationId { get; set; }
}

public class StartCompleted64
{
    public Guid CorrelationId { get; set; }
}

public class SpeedIncreased64
{
    public Guid CorrelationId { get; set; }
}

public class SpeedDecreased64
{
    public Guid CorrelationId { get; set; }
}

public class ShotTaken64
{
    public Guid CorrelationId { get; set; }
}

public class RequestA64
{
    public Guid CorrelationId { get; set; }
}

public class ResponseA64
{
    public Guid CorrelationId { get; set; }
}

public class RequestB64
{
    public Guid CorrelationId { get; set; }
}

public class ResponseB64
{
    public Guid CorrelationId { get; set; }
}

public class SampleStateMachineInstance64 :
    SagaStateMachineInstance
{
    public int CurrentState { get; set; }
    public Guid CorrelationId { get; set; }
}

public class SampleStateMachine64 :
    MassTransitStateMachine<SampleStateMachineInstance64>
{
    public SampleStateMachine64()
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
                .Request(ShotRequest, context => new RequestA64()),
            When(ShotRequest.Completed)
                .Then(_ => { }),
            When(ShotRequest.Faulted)
                .Then(_ => { }));
    }

    public Request<SampleStateMachineInstance64, RequestA64, ResponseA64> ShotRequest { get; } = null!;

    public Event<Start64> Start { get; } = null!;
    public Event<StartCompleted64> StartCompleted { get; } = null!;
    public Event<SpeedIncreased64> SpeedIncreased { get; } = null!;
    public Event<SpeedDecreased64> SpeedDecreased { get; } = null!;
    public Event<ShotTaken64> ShotTaken { get; } = null!;

    public State Starting { get; } = null!;
    public State Started { get; } = null!;
    public State Running { get; } = null!;
    public State Walking { get; } = null!;
    public State Sipping { get; } = null!;
    public State Stalking { get; } = null!;
}


public class Start65
{
    public Guid CorrelationId { get; set; }
}

public class StartCompleted65
{
    public Guid CorrelationId { get; set; }
}

public class SpeedIncreased65
{
    public Guid CorrelationId { get; set; }
}

public class SpeedDecreased65
{
    public Guid CorrelationId { get; set; }
}

public class ShotTaken65
{
    public Guid CorrelationId { get; set; }
}

public class RequestA65
{
    public Guid CorrelationId { get; set; }
}

public class ResponseA65
{
    public Guid CorrelationId { get; set; }
}

public class RequestB65
{
    public Guid CorrelationId { get; set; }
}

public class ResponseB65
{
    public Guid CorrelationId { get; set; }
}

public class SampleStateMachineInstance65 :
    SagaStateMachineInstance
{
    public int CurrentState { get; set; }
    public Guid CorrelationId { get; set; }
}

public class SampleStateMachine65 :
    MassTransitStateMachine<SampleStateMachineInstance65>
{
    public SampleStateMachine65()
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
                .Request(ShotRequest, context => new RequestA65()),
            When(ShotRequest.Completed)
                .Then(_ => { }),
            When(ShotRequest.Faulted)
                .Then(_ => { }));
    }

    public Request<SampleStateMachineInstance65, RequestA65, ResponseA65> ShotRequest { get; } = null!;

    public Event<Start65> Start { get; } = null!;
    public Event<StartCompleted65> StartCompleted { get; } = null!;
    public Event<SpeedIncreased65> SpeedIncreased { get; } = null!;
    public Event<SpeedDecreased65> SpeedDecreased { get; } = null!;
    public Event<ShotTaken65> ShotTaken { get; } = null!;

    public State Starting { get; } = null!;
    public State Started { get; } = null!;
    public State Running { get; } = null!;
    public State Walking { get; } = null!;
    public State Sipping { get; } = null!;
    public State Stalking { get; } = null!;
}


public class Start66
{
    public Guid CorrelationId { get; set; }
}

public class StartCompleted66
{
    public Guid CorrelationId { get; set; }
}

public class SpeedIncreased66
{
    public Guid CorrelationId { get; set; }
}

public class SpeedDecreased66
{
    public Guid CorrelationId { get; set; }
}

public class ShotTaken66
{
    public Guid CorrelationId { get; set; }
}

public class RequestA66
{
    public Guid CorrelationId { get; set; }
}

public class ResponseA66
{
    public Guid CorrelationId { get; set; }
}

public class RequestB66
{
    public Guid CorrelationId { get; set; }
}

public class ResponseB66
{
    public Guid CorrelationId { get; set; }
}

public class SampleStateMachineInstance66 :
    SagaStateMachineInstance
{
    public int CurrentState { get; set; }
    public Guid CorrelationId { get; set; }
}

public class SampleStateMachine66 :
    MassTransitStateMachine<SampleStateMachineInstance66>
{
    public SampleStateMachine66()
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
                .Request(ShotRequest, context => new RequestA66()),
            When(ShotRequest.Completed)
                .Then(_ => { }),
            When(ShotRequest.Faulted)
                .Then(_ => { }));
    }

    public Request<SampleStateMachineInstance66, RequestA66, ResponseA66> ShotRequest { get; } = null!;

    public Event<Start66> Start { get; } = null!;
    public Event<StartCompleted66> StartCompleted { get; } = null!;
    public Event<SpeedIncreased66> SpeedIncreased { get; } = null!;
    public Event<SpeedDecreased66> SpeedDecreased { get; } = null!;
    public Event<ShotTaken66> ShotTaken { get; } = null!;

    public State Starting { get; } = null!;
    public State Started { get; } = null!;
    public State Running { get; } = null!;
    public State Walking { get; } = null!;
    public State Sipping { get; } = null!;
    public State Stalking { get; } = null!;
}


public class Start67
{
    public Guid CorrelationId { get; set; }
}

public class StartCompleted67
{
    public Guid CorrelationId { get; set; }
}

public class SpeedIncreased67
{
    public Guid CorrelationId { get; set; }
}

public class SpeedDecreased67
{
    public Guid CorrelationId { get; set; }
}

public class ShotTaken67
{
    public Guid CorrelationId { get; set; }
}

public class RequestA67
{
    public Guid CorrelationId { get; set; }
}

public class ResponseA67
{
    public Guid CorrelationId { get; set; }
}

public class RequestB67
{
    public Guid CorrelationId { get; set; }
}

public class ResponseB67
{
    public Guid CorrelationId { get; set; }
}

public class SampleStateMachineInstance67 :
    SagaStateMachineInstance
{
    public int CurrentState { get; set; }
    public Guid CorrelationId { get; set; }
}

public class SampleStateMachine67 :
    MassTransitStateMachine<SampleStateMachineInstance67>
{
    public SampleStateMachine67()
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
                .Request(ShotRequest, context => new RequestA67()),
            When(ShotRequest.Completed)
                .Then(_ => { }),
            When(ShotRequest.Faulted)
                .Then(_ => { }));
    }

    public Request<SampleStateMachineInstance67, RequestA67, ResponseA67> ShotRequest { get; } = null!;

    public Event<Start67> Start { get; } = null!;
    public Event<StartCompleted67> StartCompleted { get; } = null!;
    public Event<SpeedIncreased67> SpeedIncreased { get; } = null!;
    public Event<SpeedDecreased67> SpeedDecreased { get; } = null!;
    public Event<ShotTaken67> ShotTaken { get; } = null!;

    public State Starting { get; } = null!;
    public State Started { get; } = null!;
    public State Running { get; } = null!;
    public State Walking { get; } = null!;
    public State Sipping { get; } = null!;
    public State Stalking { get; } = null!;
}


public class Start68
{
    public Guid CorrelationId { get; set; }
}

public class StartCompleted68
{
    public Guid CorrelationId { get; set; }
}

public class SpeedIncreased68
{
    public Guid CorrelationId { get; set; }
}

public class SpeedDecreased68
{
    public Guid CorrelationId { get; set; }
}

public class ShotTaken68
{
    public Guid CorrelationId { get; set; }
}

public class RequestA68
{
    public Guid CorrelationId { get; set; }
}

public class ResponseA68
{
    public Guid CorrelationId { get; set; }
}

public class RequestB68
{
    public Guid CorrelationId { get; set; }
}

public class ResponseB68
{
    public Guid CorrelationId { get; set; }
}

public class SampleStateMachineInstance68 :
    SagaStateMachineInstance
{
    public int CurrentState { get; set; }
    public Guid CorrelationId { get; set; }
}

public class SampleStateMachine68 :
    MassTransitStateMachine<SampleStateMachineInstance68>
{
    public SampleStateMachine68()
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
                .Request(ShotRequest, context => new RequestA68()),
            When(ShotRequest.Completed)
                .Then(_ => { }),
            When(ShotRequest.Faulted)
                .Then(_ => { }));
    }

    public Request<SampleStateMachineInstance68, RequestA68, ResponseA68> ShotRequest { get; } = null!;

    public Event<Start68> Start { get; } = null!;
    public Event<StartCompleted68> StartCompleted { get; } = null!;
    public Event<SpeedIncreased68> SpeedIncreased { get; } = null!;
    public Event<SpeedDecreased68> SpeedDecreased { get; } = null!;
    public Event<ShotTaken68> ShotTaken { get; } = null!;

    public State Starting { get; } = null!;
    public State Started { get; } = null!;
    public State Running { get; } = null!;
    public State Walking { get; } = null!;
    public State Sipping { get; } = null!;
    public State Stalking { get; } = null!;
}


public class Start69
{
    public Guid CorrelationId { get; set; }
}

public class StartCompleted69
{
    public Guid CorrelationId { get; set; }
}

public class SpeedIncreased69
{
    public Guid CorrelationId { get; set; }
}

public class SpeedDecreased69
{
    public Guid CorrelationId { get; set; }
}

public class ShotTaken69
{
    public Guid CorrelationId { get; set; }
}

public class RequestA69
{
    public Guid CorrelationId { get; set; }
}

public class ResponseA69
{
    public Guid CorrelationId { get; set; }
}

public class RequestB69
{
    public Guid CorrelationId { get; set; }
}

public class ResponseB69
{
    public Guid CorrelationId { get; set; }
}

public class SampleStateMachineInstance69 :
    SagaStateMachineInstance
{
    public int CurrentState { get; set; }
    public Guid CorrelationId { get; set; }
}

public class SampleStateMachine69 :
    MassTransitStateMachine<SampleStateMachineInstance69>
{
    public SampleStateMachine69()
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
                .Request(ShotRequest, context => new RequestA69()),
            When(ShotRequest.Completed)
                .Then(_ => { }),
            When(ShotRequest.Faulted)
                .Then(_ => { }));
    }

    public Request<SampleStateMachineInstance69, RequestA69, ResponseA69> ShotRequest { get; } = null!;

    public Event<Start69> Start { get; } = null!;
    public Event<StartCompleted69> StartCompleted { get; } = null!;
    public Event<SpeedIncreased69> SpeedIncreased { get; } = null!;
    public Event<SpeedDecreased69> SpeedDecreased { get; } = null!;
    public Event<ShotTaken69> ShotTaken { get; } = null!;

    public State Starting { get; } = null!;
    public State Started { get; } = null!;
    public State Running { get; } = null!;
    public State Walking { get; } = null!;
    public State Sipping { get; } = null!;
    public State Stalking { get; } = null!;
}


public class Start70
{
    public Guid CorrelationId { get; set; }
}

public class StartCompleted70
{
    public Guid CorrelationId { get; set; }
}

public class SpeedIncreased70
{
    public Guid CorrelationId { get; set; }
}

public class SpeedDecreased70
{
    public Guid CorrelationId { get; set; }
}

public class ShotTaken70
{
    public Guid CorrelationId { get; set; }
}

public class RequestA70
{
    public Guid CorrelationId { get; set; }
}

public class ResponseA70
{
    public Guid CorrelationId { get; set; }
}

public class RequestB70
{
    public Guid CorrelationId { get; set; }
}

public class ResponseB70
{
    public Guid CorrelationId { get; set; }
}

public class SampleStateMachineInstance70 :
    SagaStateMachineInstance
{
    public int CurrentState { get; set; }
    public Guid CorrelationId { get; set; }
}

public class SampleStateMachine70 :
    MassTransitStateMachine<SampleStateMachineInstance70>
{
    public SampleStateMachine70()
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
                .Request(ShotRequest, context => new RequestA70()),
            When(ShotRequest.Completed)
                .Then(_ => { }),
            When(ShotRequest.Faulted)
                .Then(_ => { }));
    }

    public Request<SampleStateMachineInstance70, RequestA70, ResponseA70> ShotRequest { get; } = null!;

    public Event<Start70> Start { get; } = null!;
    public Event<StartCompleted70> StartCompleted { get; } = null!;
    public Event<SpeedIncreased70> SpeedIncreased { get; } = null!;
    public Event<SpeedDecreased70> SpeedDecreased { get; } = null!;
    public Event<ShotTaken70> ShotTaken { get; } = null!;

    public State Starting { get; } = null!;
    public State Started { get; } = null!;
    public State Running { get; } = null!;
    public State Walking { get; } = null!;
    public State Sipping { get; } = null!;
    public State Stalking { get; } = null!;
}


public class Start71
{
    public Guid CorrelationId { get; set; }
}

public class StartCompleted71
{
    public Guid CorrelationId { get; set; }
}

public class SpeedIncreased71
{
    public Guid CorrelationId { get; set; }
}

public class SpeedDecreased71
{
    public Guid CorrelationId { get; set; }
}

public class ShotTaken71
{
    public Guid CorrelationId { get; set; }
}

public class RequestA71
{
    public Guid CorrelationId { get; set; }
}

public class ResponseA71
{
    public Guid CorrelationId { get; set; }
}

public class RequestB71
{
    public Guid CorrelationId { get; set; }
}

public class ResponseB71
{
    public Guid CorrelationId { get; set; }
}

public class SampleStateMachineInstance71 :
    SagaStateMachineInstance
{
    public int CurrentState { get; set; }
    public Guid CorrelationId { get; set; }
}

public class SampleStateMachine71 :
    MassTransitStateMachine<SampleStateMachineInstance71>
{
    public SampleStateMachine71()
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
                .Request(ShotRequest, context => new RequestA71()),
            When(ShotRequest.Completed)
                .Then(_ => { }),
            When(ShotRequest.Faulted)
                .Then(_ => { }));
    }

    public Request<SampleStateMachineInstance71, RequestA71, ResponseA71> ShotRequest { get; } = null!;

    public Event<Start71> Start { get; } = null!;
    public Event<StartCompleted71> StartCompleted { get; } = null!;
    public Event<SpeedIncreased71> SpeedIncreased { get; } = null!;
    public Event<SpeedDecreased71> SpeedDecreased { get; } = null!;
    public Event<ShotTaken71> ShotTaken { get; } = null!;

    public State Starting { get; } = null!;
    public State Started { get; } = null!;
    public State Running { get; } = null!;
    public State Walking { get; } = null!;
    public State Sipping { get; } = null!;
    public State Stalking { get; } = null!;
}


public class Start72
{
    public Guid CorrelationId { get; set; }
}

public class StartCompleted72
{
    public Guid CorrelationId { get; set; }
}

public class SpeedIncreased72
{
    public Guid CorrelationId { get; set; }
}

public class SpeedDecreased72
{
    public Guid CorrelationId { get; set; }
}

public class ShotTaken72
{
    public Guid CorrelationId { get; set; }
}

public class RequestA72
{
    public Guid CorrelationId { get; set; }
}

public class ResponseA72
{
    public Guid CorrelationId { get; set; }
}

public class RequestB72
{
    public Guid CorrelationId { get; set; }
}

public class ResponseB72
{
    public Guid CorrelationId { get; set; }
}

public class SampleStateMachineInstance72 :
    SagaStateMachineInstance
{
    public int CurrentState { get; set; }
    public Guid CorrelationId { get; set; }
}

public class SampleStateMachine72 :
    MassTransitStateMachine<SampleStateMachineInstance72>
{
    public SampleStateMachine72()
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
                .Request(ShotRequest, context => new RequestA72()),
            When(ShotRequest.Completed)
                .Then(_ => { }),
            When(ShotRequest.Faulted)
                .Then(_ => { }));
    }

    public Request<SampleStateMachineInstance72, RequestA72, ResponseA72> ShotRequest { get; } = null!;

    public Event<Start72> Start { get; } = null!;
    public Event<StartCompleted72> StartCompleted { get; } = null!;
    public Event<SpeedIncreased72> SpeedIncreased { get; } = null!;
    public Event<SpeedDecreased72> SpeedDecreased { get; } = null!;
    public Event<ShotTaken72> ShotTaken { get; } = null!;

    public State Starting { get; } = null!;
    public State Started { get; } = null!;
    public State Running { get; } = null!;
    public State Walking { get; } = null!;
    public State Sipping { get; } = null!;
    public State Stalking { get; } = null!;
}


public class Start73
{
    public Guid CorrelationId { get; set; }
}

public class StartCompleted73
{
    public Guid CorrelationId { get; set; }
}

public class SpeedIncreased73
{
    public Guid CorrelationId { get; set; }
}

public class SpeedDecreased73
{
    public Guid CorrelationId { get; set; }
}

public class ShotTaken73
{
    public Guid CorrelationId { get; set; }
}

public class RequestA73
{
    public Guid CorrelationId { get; set; }
}

public class ResponseA73
{
    public Guid CorrelationId { get; set; }
}

public class RequestB73
{
    public Guid CorrelationId { get; set; }
}

public class ResponseB73
{
    public Guid CorrelationId { get; set; }
}

public class SampleStateMachineInstance73 :
    SagaStateMachineInstance
{
    public int CurrentState { get; set; }
    public Guid CorrelationId { get; set; }
}

public class SampleStateMachine73 :
    MassTransitStateMachine<SampleStateMachineInstance73>
{
    public SampleStateMachine73()
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
                .Request(ShotRequest, context => new RequestA73()),
            When(ShotRequest.Completed)
                .Then(_ => { }),
            When(ShotRequest.Faulted)
                .Then(_ => { }));
    }

    public Request<SampleStateMachineInstance73, RequestA73, ResponseA73> ShotRequest { get; } = null!;

    public Event<Start73> Start { get; } = null!;
    public Event<StartCompleted73> StartCompleted { get; } = null!;
    public Event<SpeedIncreased73> SpeedIncreased { get; } = null!;
    public Event<SpeedDecreased73> SpeedDecreased { get; } = null!;
    public Event<ShotTaken73> ShotTaken { get; } = null!;

    public State Starting { get; } = null!;
    public State Started { get; } = null!;
    public State Running { get; } = null!;
    public State Walking { get; } = null!;
    public State Sipping { get; } = null!;
    public State Stalking { get; } = null!;
}


public class Start74
{
    public Guid CorrelationId { get; set; }
}

public class StartCompleted74
{
    public Guid CorrelationId { get; set; }
}

public class SpeedIncreased74
{
    public Guid CorrelationId { get; set; }
}

public class SpeedDecreased74
{
    public Guid CorrelationId { get; set; }
}

public class ShotTaken74
{
    public Guid CorrelationId { get; set; }
}

public class RequestA74
{
    public Guid CorrelationId { get; set; }
}

public class ResponseA74
{
    public Guid CorrelationId { get; set; }
}

public class RequestB74
{
    public Guid CorrelationId { get; set; }
}

public class ResponseB74
{
    public Guid CorrelationId { get; set; }
}

public class SampleStateMachineInstance74 :
    SagaStateMachineInstance
{
    public int CurrentState { get; set; }
    public Guid CorrelationId { get; set; }
}

public class SampleStateMachine74 :
    MassTransitStateMachine<SampleStateMachineInstance74>
{
    public SampleStateMachine74()
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
                .Request(ShotRequest, context => new RequestA74()),
            When(ShotRequest.Completed)
                .Then(_ => { }),
            When(ShotRequest.Faulted)
                .Then(_ => { }));
    }

    public Request<SampleStateMachineInstance74, RequestA74, ResponseA74> ShotRequest { get; } = null!;

    public Event<Start74> Start { get; } = null!;
    public Event<StartCompleted74> StartCompleted { get; } = null!;
    public Event<SpeedIncreased74> SpeedIncreased { get; } = null!;
    public Event<SpeedDecreased74> SpeedDecreased { get; } = null!;
    public Event<ShotTaken74> ShotTaken { get; } = null!;

    public State Starting { get; } = null!;
    public State Started { get; } = null!;
    public State Running { get; } = null!;
    public State Walking { get; } = null!;
    public State Sipping { get; } = null!;
    public State Stalking { get; } = null!;
}


public class Start75
{
    public Guid CorrelationId { get; set; }
}

public class StartCompleted75
{
    public Guid CorrelationId { get; set; }
}

public class SpeedIncreased75
{
    public Guid CorrelationId { get; set; }
}

public class SpeedDecreased75
{
    public Guid CorrelationId { get; set; }
}

public class ShotTaken75
{
    public Guid CorrelationId { get; set; }
}

public class RequestA75
{
    public Guid CorrelationId { get; set; }
}

public class ResponseA75
{
    public Guid CorrelationId { get; set; }
}

public class RequestB75
{
    public Guid CorrelationId { get; set; }
}

public class ResponseB75
{
    public Guid CorrelationId { get; set; }
}

public class SampleStateMachineInstance75 :
    SagaStateMachineInstance
{
    public int CurrentState { get; set; }
    public Guid CorrelationId { get; set; }
}

public class SampleStateMachine75 :
    MassTransitStateMachine<SampleStateMachineInstance75>
{
    public SampleStateMachine75()
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
                .Request(ShotRequest, context => new RequestA75()),
            When(ShotRequest.Completed)
                .Then(_ => { }),
            When(ShotRequest.Faulted)
                .Then(_ => { }));
    }

    public Request<SampleStateMachineInstance75, RequestA75, ResponseA75> ShotRequest { get; } = null!;

    public Event<Start75> Start { get; } = null!;
    public Event<StartCompleted75> StartCompleted { get; } = null!;
    public Event<SpeedIncreased75> SpeedIncreased { get; } = null!;
    public Event<SpeedDecreased75> SpeedDecreased { get; } = null!;
    public Event<ShotTaken75> ShotTaken { get; } = null!;

    public State Starting { get; } = null!;
    public State Started { get; } = null!;
    public State Running { get; } = null!;
    public State Walking { get; } = null!;
    public State Sipping { get; } = null!;
    public State Stalking { get; } = null!;
}


public class Start76
{
    public Guid CorrelationId { get; set; }
}

public class StartCompleted76
{
    public Guid CorrelationId { get; set; }
}

public class SpeedIncreased76
{
    public Guid CorrelationId { get; set; }
}

public class SpeedDecreased76
{
    public Guid CorrelationId { get; set; }
}

public class ShotTaken76
{
    public Guid CorrelationId { get; set; }
}

public class RequestA76
{
    public Guid CorrelationId { get; set; }
}

public class ResponseA76
{
    public Guid CorrelationId { get; set; }
}

public class RequestB76
{
    public Guid CorrelationId { get; set; }
}

public class ResponseB76
{
    public Guid CorrelationId { get; set; }
}

public class SampleStateMachineInstance76 :
    SagaStateMachineInstance
{
    public int CurrentState { get; set; }
    public Guid CorrelationId { get; set; }
}

public class SampleStateMachine76 :
    MassTransitStateMachine<SampleStateMachineInstance76>
{
    public SampleStateMachine76()
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
                .Request(ShotRequest, context => new RequestA76()),
            When(ShotRequest.Completed)
                .Then(_ => { }),
            When(ShotRequest.Faulted)
                .Then(_ => { }));
    }

    public Request<SampleStateMachineInstance76, RequestA76, ResponseA76> ShotRequest { get; } = null!;

    public Event<Start76> Start { get; } = null!;
    public Event<StartCompleted76> StartCompleted { get; } = null!;
    public Event<SpeedIncreased76> SpeedIncreased { get; } = null!;
    public Event<SpeedDecreased76> SpeedDecreased { get; } = null!;
    public Event<ShotTaken76> ShotTaken { get; } = null!;

    public State Starting { get; } = null!;
    public State Started { get; } = null!;
    public State Running { get; } = null!;
    public State Walking { get; } = null!;
    public State Sipping { get; } = null!;
    public State Stalking { get; } = null!;
}


public class Start77
{
    public Guid CorrelationId { get; set; }
}

public class StartCompleted77
{
    public Guid CorrelationId { get; set; }
}

public class SpeedIncreased77
{
    public Guid CorrelationId { get; set; }
}

public class SpeedDecreased77
{
    public Guid CorrelationId { get; set; }
}

public class ShotTaken77
{
    public Guid CorrelationId { get; set; }
}

public class RequestA77
{
    public Guid CorrelationId { get; set; }
}

public class ResponseA77
{
    public Guid CorrelationId { get; set; }
}

public class RequestB77
{
    public Guid CorrelationId { get; set; }
}

public class ResponseB77
{
    public Guid CorrelationId { get; set; }
}

public class SampleStateMachineInstance77 :
    SagaStateMachineInstance
{
    public int CurrentState { get; set; }
    public Guid CorrelationId { get; set; }
}

public class SampleStateMachine77 :
    MassTransitStateMachine<SampleStateMachineInstance77>
{
    public SampleStateMachine77()
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
                .Request(ShotRequest, context => new RequestA77()),
            When(ShotRequest.Completed)
                .Then(_ => { }),
            When(ShotRequest.Faulted)
                .Then(_ => { }));
    }

    public Request<SampleStateMachineInstance77, RequestA77, ResponseA77> ShotRequest { get; } = null!;

    public Event<Start77> Start { get; } = null!;
    public Event<StartCompleted77> StartCompleted { get; } = null!;
    public Event<SpeedIncreased77> SpeedIncreased { get; } = null!;
    public Event<SpeedDecreased77> SpeedDecreased { get; } = null!;
    public Event<ShotTaken77> ShotTaken { get; } = null!;

    public State Starting { get; } = null!;
    public State Started { get; } = null!;
    public State Running { get; } = null!;
    public State Walking { get; } = null!;
    public State Sipping { get; } = null!;
    public State Stalking { get; } = null!;
}


public class Start78
{
    public Guid CorrelationId { get; set; }
}

public class StartCompleted78
{
    public Guid CorrelationId { get; set; }
}

public class SpeedIncreased78
{
    public Guid CorrelationId { get; set; }
}

public class SpeedDecreased78
{
    public Guid CorrelationId { get; set; }
}

public class ShotTaken78
{
    public Guid CorrelationId { get; set; }
}

public class RequestA78
{
    public Guid CorrelationId { get; set; }
}

public class ResponseA78
{
    public Guid CorrelationId { get; set; }
}

public class RequestB78
{
    public Guid CorrelationId { get; set; }
}

public class ResponseB78
{
    public Guid CorrelationId { get; set; }
}

public class SampleStateMachineInstance78 :
    SagaStateMachineInstance
{
    public int CurrentState { get; set; }
    public Guid CorrelationId { get; set; }
}

public class SampleStateMachine78 :
    MassTransitStateMachine<SampleStateMachineInstance78>
{
    public SampleStateMachine78()
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
                .Request(ShotRequest, context => new RequestA78()),
            When(ShotRequest.Completed)
                .Then(_ => { }),
            When(ShotRequest.Faulted)
                .Then(_ => { }));
    }

    public Request<SampleStateMachineInstance78, RequestA78, ResponseA78> ShotRequest { get; } = null!;

    public Event<Start78> Start { get; } = null!;
    public Event<StartCompleted78> StartCompleted { get; } = null!;
    public Event<SpeedIncreased78> SpeedIncreased { get; } = null!;
    public Event<SpeedDecreased78> SpeedDecreased { get; } = null!;
    public Event<ShotTaken78> ShotTaken { get; } = null!;

    public State Starting { get; } = null!;
    public State Started { get; } = null!;
    public State Running { get; } = null!;
    public State Walking { get; } = null!;
    public State Sipping { get; } = null!;
    public State Stalking { get; } = null!;
}


public class Start79
{
    public Guid CorrelationId { get; set; }
}

public class StartCompleted79
{
    public Guid CorrelationId { get; set; }
}

public class SpeedIncreased79
{
    public Guid CorrelationId { get; set; }
}

public class SpeedDecreased79
{
    public Guid CorrelationId { get; set; }
}

public class ShotTaken79
{
    public Guid CorrelationId { get; set; }
}

public class RequestA79
{
    public Guid CorrelationId { get; set; }
}

public class ResponseA79
{
    public Guid CorrelationId { get; set; }
}

public class RequestB79
{
    public Guid CorrelationId { get; set; }
}

public class ResponseB79
{
    public Guid CorrelationId { get; set; }
}

public class SampleStateMachineInstance79 :
    SagaStateMachineInstance
{
    public int CurrentState { get; set; }
    public Guid CorrelationId { get; set; }
}

public class SampleStateMachine79 :
    MassTransitStateMachine<SampleStateMachineInstance79>
{
    public SampleStateMachine79()
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
                .Request(ShotRequest, context => new RequestA79()),
            When(ShotRequest.Completed)
                .Then(_ => { }),
            When(ShotRequest.Faulted)
                .Then(_ => { }));
    }

    public Request<SampleStateMachineInstance79, RequestA79, ResponseA79> ShotRequest { get; } = null!;

    public Event<Start79> Start { get; } = null!;
    public Event<StartCompleted79> StartCompleted { get; } = null!;
    public Event<SpeedIncreased79> SpeedIncreased { get; } = null!;
    public Event<SpeedDecreased79> SpeedDecreased { get; } = null!;
    public Event<ShotTaken79> ShotTaken { get; } = null!;

    public State Starting { get; } = null!;
    public State Started { get; } = null!;
    public State Running { get; } = null!;
    public State Walking { get; } = null!;
    public State Sipping { get; } = null!;
    public State Stalking { get; } = null!;
}


public class Start80
{
    public Guid CorrelationId { get; set; }
}

public class StartCompleted80
{
    public Guid CorrelationId { get; set; }
}

public class SpeedIncreased80
{
    public Guid CorrelationId { get; set; }
}

public class SpeedDecreased80
{
    public Guid CorrelationId { get; set; }
}

public class ShotTaken80
{
    public Guid CorrelationId { get; set; }
}

public class RequestA80
{
    public Guid CorrelationId { get; set; }
}

public class ResponseA80
{
    public Guid CorrelationId { get; set; }
}

public class RequestB80
{
    public Guid CorrelationId { get; set; }
}

public class ResponseB80
{
    public Guid CorrelationId { get; set; }
}

public class SampleStateMachineInstance80 :
    SagaStateMachineInstance
{
    public int CurrentState { get; set; }
    public Guid CorrelationId { get; set; }
}

public class SampleStateMachine80 :
    MassTransitStateMachine<SampleStateMachineInstance80>
{
    public SampleStateMachine80()
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
                .Request(ShotRequest, context => new RequestA80()),
            When(ShotRequest.Completed)
                .Then(_ => { }),
            When(ShotRequest.Faulted)
                .Then(_ => { }));
    }

    public Request<SampleStateMachineInstance80, RequestA80, ResponseA80> ShotRequest { get; } = null!;

    public Event<Start80> Start { get; } = null!;
    public Event<StartCompleted80> StartCompleted { get; } = null!;
    public Event<SpeedIncreased80> SpeedIncreased { get; } = null!;
    public Event<SpeedDecreased80> SpeedDecreased { get; } = null!;
    public Event<ShotTaken80> ShotTaken { get; } = null!;

    public State Starting { get; } = null!;
    public State Started { get; } = null!;
    public State Running { get; } = null!;
    public State Walking { get; } = null!;
    public State Sipping { get; } = null!;
    public State Stalking { get; } = null!;
}


public class Start81
{
    public Guid CorrelationId { get; set; }
}

public class StartCompleted81
{
    public Guid CorrelationId { get; set; }
}

public class SpeedIncreased81
{
    public Guid CorrelationId { get; set; }
}

public class SpeedDecreased81
{
    public Guid CorrelationId { get; set; }
}

public class ShotTaken81
{
    public Guid CorrelationId { get; set; }
}

public class RequestA81
{
    public Guid CorrelationId { get; set; }
}

public class ResponseA81
{
    public Guid CorrelationId { get; set; }
}

public class RequestB81
{
    public Guid CorrelationId { get; set; }
}

public class ResponseB81
{
    public Guid CorrelationId { get; set; }
}

public class SampleStateMachineInstance81 :
    SagaStateMachineInstance
{
    public int CurrentState { get; set; }
    public Guid CorrelationId { get; set; }
}

public class SampleStateMachine81 :
    MassTransitStateMachine<SampleStateMachineInstance81>
{
    public SampleStateMachine81()
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
                .Request(ShotRequest, context => new RequestA81()),
            When(ShotRequest.Completed)
                .Then(_ => { }),
            When(ShotRequest.Faulted)
                .Then(_ => { }));
    }

    public Request<SampleStateMachineInstance81, RequestA81, ResponseA81> ShotRequest { get; } = null!;

    public Event<Start81> Start { get; } = null!;
    public Event<StartCompleted81> StartCompleted { get; } = null!;
    public Event<SpeedIncreased81> SpeedIncreased { get; } = null!;
    public Event<SpeedDecreased81> SpeedDecreased { get; } = null!;
    public Event<ShotTaken81> ShotTaken { get; } = null!;

    public State Starting { get; } = null!;
    public State Started { get; } = null!;
    public State Running { get; } = null!;
    public State Walking { get; } = null!;
    public State Sipping { get; } = null!;
    public State Stalking { get; } = null!;
}


public class Start82
{
    public Guid CorrelationId { get; set; }
}

public class StartCompleted82
{
    public Guid CorrelationId { get; set; }
}

public class SpeedIncreased82
{
    public Guid CorrelationId { get; set; }
}

public class SpeedDecreased82
{
    public Guid CorrelationId { get; set; }
}

public class ShotTaken82
{
    public Guid CorrelationId { get; set; }
}

public class RequestA82
{
    public Guid CorrelationId { get; set; }
}

public class ResponseA82
{
    public Guid CorrelationId { get; set; }
}

public class RequestB82
{
    public Guid CorrelationId { get; set; }
}

public class ResponseB82
{
    public Guid CorrelationId { get; set; }
}

public class SampleStateMachineInstance82 :
    SagaStateMachineInstance
{
    public int CurrentState { get; set; }
    public Guid CorrelationId { get; set; }
}

public class SampleStateMachine82 :
    MassTransitStateMachine<SampleStateMachineInstance82>
{
    public SampleStateMachine82()
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
                .Request(ShotRequest, context => new RequestA82()),
            When(ShotRequest.Completed)
                .Then(_ => { }),
            When(ShotRequest.Faulted)
                .Then(_ => { }));
    }

    public Request<SampleStateMachineInstance82, RequestA82, ResponseA82> ShotRequest { get; } = null!;

    public Event<Start82> Start { get; } = null!;
    public Event<StartCompleted82> StartCompleted { get; } = null!;
    public Event<SpeedIncreased82> SpeedIncreased { get; } = null!;
    public Event<SpeedDecreased82> SpeedDecreased { get; } = null!;
    public Event<ShotTaken82> ShotTaken { get; } = null!;

    public State Starting { get; } = null!;
    public State Started { get; } = null!;
    public State Running { get; } = null!;
    public State Walking { get; } = null!;
    public State Sipping { get; } = null!;
    public State Stalking { get; } = null!;
}


public class Start83
{
    public Guid CorrelationId { get; set; }
}

public class StartCompleted83
{
    public Guid CorrelationId { get; set; }
}

public class SpeedIncreased83
{
    public Guid CorrelationId { get; set; }
}

public class SpeedDecreased83
{
    public Guid CorrelationId { get; set; }
}

public class ShotTaken83
{
    public Guid CorrelationId { get; set; }
}

public class RequestA83
{
    public Guid CorrelationId { get; set; }
}

public class ResponseA83
{
    public Guid CorrelationId { get; set; }
}

public class RequestB83
{
    public Guid CorrelationId { get; set; }
}

public class ResponseB83
{
    public Guid CorrelationId { get; set; }
}

public class SampleStateMachineInstance83 :
    SagaStateMachineInstance
{
    public int CurrentState { get; set; }
    public Guid CorrelationId { get; set; }
}

public class SampleStateMachine83 :
    MassTransitStateMachine<SampleStateMachineInstance83>
{
    public SampleStateMachine83()
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
                .Request(ShotRequest, context => new RequestA83()),
            When(ShotRequest.Completed)
                .Then(_ => { }),
            When(ShotRequest.Faulted)
                .Then(_ => { }));
    }

    public Request<SampleStateMachineInstance83, RequestA83, ResponseA83> ShotRequest { get; } = null!;

    public Event<Start83> Start { get; } = null!;
    public Event<StartCompleted83> StartCompleted { get; } = null!;
    public Event<SpeedIncreased83> SpeedIncreased { get; } = null!;
    public Event<SpeedDecreased83> SpeedDecreased { get; } = null!;
    public Event<ShotTaken83> ShotTaken { get; } = null!;

    public State Starting { get; } = null!;
    public State Started { get; } = null!;
    public State Running { get; } = null!;
    public State Walking { get; } = null!;
    public State Sipping { get; } = null!;
    public State Stalking { get; } = null!;
}


public class Start84
{
    public Guid CorrelationId { get; set; }
}

public class StartCompleted84
{
    public Guid CorrelationId { get; set; }
}

public class SpeedIncreased84
{
    public Guid CorrelationId { get; set; }
}

public class SpeedDecreased84
{
    public Guid CorrelationId { get; set; }
}

public class ShotTaken84
{
    public Guid CorrelationId { get; set; }
}

public class RequestA84
{
    public Guid CorrelationId { get; set; }
}

public class ResponseA84
{
    public Guid CorrelationId { get; set; }
}

public class RequestB84
{
    public Guid CorrelationId { get; set; }
}

public class ResponseB84
{
    public Guid CorrelationId { get; set; }
}

public class SampleStateMachineInstance84 :
    SagaStateMachineInstance
{
    public int CurrentState { get; set; }
    public Guid CorrelationId { get; set; }
}

public class SampleStateMachine84 :
    MassTransitStateMachine<SampleStateMachineInstance84>
{
    public SampleStateMachine84()
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
                .Request(ShotRequest, context => new RequestA84()),
            When(ShotRequest.Completed)
                .Then(_ => { }),
            When(ShotRequest.Faulted)
                .Then(_ => { }));
    }

    public Request<SampleStateMachineInstance84, RequestA84, ResponseA84> ShotRequest { get; } = null!;

    public Event<Start84> Start { get; } = null!;
    public Event<StartCompleted84> StartCompleted { get; } = null!;
    public Event<SpeedIncreased84> SpeedIncreased { get; } = null!;
    public Event<SpeedDecreased84> SpeedDecreased { get; } = null!;
    public Event<ShotTaken84> ShotTaken { get; } = null!;

    public State Starting { get; } = null!;
    public State Started { get; } = null!;
    public State Running { get; } = null!;
    public State Walking { get; } = null!;
    public State Sipping { get; } = null!;
    public State Stalking { get; } = null!;
}


public class Start85
{
    public Guid CorrelationId { get; set; }
}

public class StartCompleted85
{
    public Guid CorrelationId { get; set; }
}

public class SpeedIncreased85
{
    public Guid CorrelationId { get; set; }
}

public class SpeedDecreased85
{
    public Guid CorrelationId { get; set; }
}

public class ShotTaken85
{
    public Guid CorrelationId { get; set; }
}

public class RequestA85
{
    public Guid CorrelationId { get; set; }
}

public class ResponseA85
{
    public Guid CorrelationId { get; set; }
}

public class RequestB85
{
    public Guid CorrelationId { get; set; }
}

public class ResponseB85
{
    public Guid CorrelationId { get; set; }
}

public class SampleStateMachineInstance85 :
    SagaStateMachineInstance
{
    public int CurrentState { get; set; }
    public Guid CorrelationId { get; set; }
}

public class SampleStateMachine85 :
    MassTransitStateMachine<SampleStateMachineInstance85>
{
    public SampleStateMachine85()
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
                .Request(ShotRequest, context => new RequestA85()),
            When(ShotRequest.Completed)
                .Then(_ => { }),
            When(ShotRequest.Faulted)
                .Then(_ => { }));
    }

    public Request<SampleStateMachineInstance85, RequestA85, ResponseA85> ShotRequest { get; } = null!;

    public Event<Start85> Start { get; } = null!;
    public Event<StartCompleted85> StartCompleted { get; } = null!;
    public Event<SpeedIncreased85> SpeedIncreased { get; } = null!;
    public Event<SpeedDecreased85> SpeedDecreased { get; } = null!;
    public Event<ShotTaken85> ShotTaken { get; } = null!;

    public State Starting { get; } = null!;
    public State Started { get; } = null!;
    public State Running { get; } = null!;
    public State Walking { get; } = null!;
    public State Sipping { get; } = null!;
    public State Stalking { get; } = null!;
}


public class Start86
{
    public Guid CorrelationId { get; set; }
}

public class StartCompleted86
{
    public Guid CorrelationId { get; set; }
}

public class SpeedIncreased86
{
    public Guid CorrelationId { get; set; }
}

public class SpeedDecreased86
{
    public Guid CorrelationId { get; set; }
}

public class ShotTaken86
{
    public Guid CorrelationId { get; set; }
}

public class RequestA86
{
    public Guid CorrelationId { get; set; }
}

public class ResponseA86
{
    public Guid CorrelationId { get; set; }
}

public class RequestB86
{
    public Guid CorrelationId { get; set; }
}

public class ResponseB86
{
    public Guid CorrelationId { get; set; }
}

public class SampleStateMachineInstance86 :
    SagaStateMachineInstance
{
    public int CurrentState { get; set; }
    public Guid CorrelationId { get; set; }
}

public class SampleStateMachine86 :
    MassTransitStateMachine<SampleStateMachineInstance86>
{
    public SampleStateMachine86()
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
                .Request(ShotRequest, context => new RequestA86()),
            When(ShotRequest.Completed)
                .Then(_ => { }),
            When(ShotRequest.Faulted)
                .Then(_ => { }));
    }

    public Request<SampleStateMachineInstance86, RequestA86, ResponseA86> ShotRequest { get; } = null!;

    public Event<Start86> Start { get; } = null!;
    public Event<StartCompleted86> StartCompleted { get; } = null!;
    public Event<SpeedIncreased86> SpeedIncreased { get; } = null!;
    public Event<SpeedDecreased86> SpeedDecreased { get; } = null!;
    public Event<ShotTaken86> ShotTaken { get; } = null!;

    public State Starting { get; } = null!;
    public State Started { get; } = null!;
    public State Running { get; } = null!;
    public State Walking { get; } = null!;
    public State Sipping { get; } = null!;
    public State Stalking { get; } = null!;
}


public class Start87
{
    public Guid CorrelationId { get; set; }
}

public class StartCompleted87
{
    public Guid CorrelationId { get; set; }
}

public class SpeedIncreased87
{
    public Guid CorrelationId { get; set; }
}

public class SpeedDecreased87
{
    public Guid CorrelationId { get; set; }
}

public class ShotTaken87
{
    public Guid CorrelationId { get; set; }
}

public class RequestA87
{
    public Guid CorrelationId { get; set; }
}

public class ResponseA87
{
    public Guid CorrelationId { get; set; }
}

public class RequestB87
{
    public Guid CorrelationId { get; set; }
}

public class ResponseB87
{
    public Guid CorrelationId { get; set; }
}

public class SampleStateMachineInstance87 :
    SagaStateMachineInstance
{
    public int CurrentState { get; set; }
    public Guid CorrelationId { get; set; }
}

public class SampleStateMachine87 :
    MassTransitStateMachine<SampleStateMachineInstance87>
{
    public SampleStateMachine87()
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
                .Request(ShotRequest, context => new RequestA87()),
            When(ShotRequest.Completed)
                .Then(_ => { }),
            When(ShotRequest.Faulted)
                .Then(_ => { }));
    }

    public Request<SampleStateMachineInstance87, RequestA87, ResponseA87> ShotRequest { get; } = null!;

    public Event<Start87> Start { get; } = null!;
    public Event<StartCompleted87> StartCompleted { get; } = null!;
    public Event<SpeedIncreased87> SpeedIncreased { get; } = null!;
    public Event<SpeedDecreased87> SpeedDecreased { get; } = null!;
    public Event<ShotTaken87> ShotTaken { get; } = null!;

    public State Starting { get; } = null!;
    public State Started { get; } = null!;
    public State Running { get; } = null!;
    public State Walking { get; } = null!;
    public State Sipping { get; } = null!;
    public State Stalking { get; } = null!;
}


public class Start88
{
    public Guid CorrelationId { get; set; }
}

public class StartCompleted88
{
    public Guid CorrelationId { get; set; }
}

public class SpeedIncreased88
{
    public Guid CorrelationId { get; set; }
}

public class SpeedDecreased88
{
    public Guid CorrelationId { get; set; }
}

public class ShotTaken88
{
    public Guid CorrelationId { get; set; }
}

public class RequestA88
{
    public Guid CorrelationId { get; set; }
}

public class ResponseA88
{
    public Guid CorrelationId { get; set; }
}

public class RequestB88
{
    public Guid CorrelationId { get; set; }
}

public class ResponseB88
{
    public Guid CorrelationId { get; set; }
}

public class SampleStateMachineInstance88 :
    SagaStateMachineInstance
{
    public int CurrentState { get; set; }
    public Guid CorrelationId { get; set; }
}

public class SampleStateMachine88 :
    MassTransitStateMachine<SampleStateMachineInstance88>
{
    public SampleStateMachine88()
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
                .Request(ShotRequest, context => new RequestA88()),
            When(ShotRequest.Completed)
                .Then(_ => { }),
            When(ShotRequest.Faulted)
                .Then(_ => { }));
    }

    public Request<SampleStateMachineInstance88, RequestA88, ResponseA88> ShotRequest { get; } = null!;

    public Event<Start88> Start { get; } = null!;
    public Event<StartCompleted88> StartCompleted { get; } = null!;
    public Event<SpeedIncreased88> SpeedIncreased { get; } = null!;
    public Event<SpeedDecreased88> SpeedDecreased { get; } = null!;
    public Event<ShotTaken88> ShotTaken { get; } = null!;

    public State Starting { get; } = null!;
    public State Started { get; } = null!;
    public State Running { get; } = null!;
    public State Walking { get; } = null!;
    public State Sipping { get; } = null!;
    public State Stalking { get; } = null!;
}


public class Start89
{
    public Guid CorrelationId { get; set; }
}

public class StartCompleted89
{
    public Guid CorrelationId { get; set; }
}

public class SpeedIncreased89
{
    public Guid CorrelationId { get; set; }
}

public class SpeedDecreased89
{
    public Guid CorrelationId { get; set; }
}

public class ShotTaken89
{
    public Guid CorrelationId { get; set; }
}

public class RequestA89
{
    public Guid CorrelationId { get; set; }
}

public class ResponseA89
{
    public Guid CorrelationId { get; set; }
}

public class RequestB89
{
    public Guid CorrelationId { get; set; }
}

public class ResponseB89
{
    public Guid CorrelationId { get; set; }
}

public class SampleStateMachineInstance89 :
    SagaStateMachineInstance
{
    public int CurrentState { get; set; }
    public Guid CorrelationId { get; set; }
}

public class SampleStateMachine89 :
    MassTransitStateMachine<SampleStateMachineInstance89>
{
    public SampleStateMachine89()
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
                .Request(ShotRequest, context => new RequestA89()),
            When(ShotRequest.Completed)
                .Then(_ => { }),
            When(ShotRequest.Faulted)
                .Then(_ => { }));
    }

    public Request<SampleStateMachineInstance89, RequestA89, ResponseA89> ShotRequest { get; } = null!;

    public Event<Start89> Start { get; } = null!;
    public Event<StartCompleted89> StartCompleted { get; } = null!;
    public Event<SpeedIncreased89> SpeedIncreased { get; } = null!;
    public Event<SpeedDecreased89> SpeedDecreased { get; } = null!;
    public Event<ShotTaken89> ShotTaken { get; } = null!;

    public State Starting { get; } = null!;
    public State Started { get; } = null!;
    public State Running { get; } = null!;
    public State Walking { get; } = null!;
    public State Sipping { get; } = null!;
    public State Stalking { get; } = null!;
}


public class Start90
{
    public Guid CorrelationId { get; set; }
}

public class StartCompleted90
{
    public Guid CorrelationId { get; set; }
}

public class SpeedIncreased90
{
    public Guid CorrelationId { get; set; }
}

public class SpeedDecreased90
{
    public Guid CorrelationId { get; set; }
}

public class ShotTaken90
{
    public Guid CorrelationId { get; set; }
}

public class RequestA90
{
    public Guid CorrelationId { get; set; }
}

public class ResponseA90
{
    public Guid CorrelationId { get; set; }
}

public class RequestB90
{
    public Guid CorrelationId { get; set; }
}

public class ResponseB90
{
    public Guid CorrelationId { get; set; }
}

public class SampleStateMachineInstance90 :
    SagaStateMachineInstance
{
    public int CurrentState { get; set; }
    public Guid CorrelationId { get; set; }
}

public class SampleStateMachine90 :
    MassTransitStateMachine<SampleStateMachineInstance90>
{
    public SampleStateMachine90()
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
                .Request(ShotRequest, context => new RequestA90()),
            When(ShotRequest.Completed)
                .Then(_ => { }),
            When(ShotRequest.Faulted)
                .Then(_ => { }));
    }

    public Request<SampleStateMachineInstance90, RequestA90, ResponseA90> ShotRequest { get; } = null!;

    public Event<Start90> Start { get; } = null!;
    public Event<StartCompleted90> StartCompleted { get; } = null!;
    public Event<SpeedIncreased90> SpeedIncreased { get; } = null!;
    public Event<SpeedDecreased90> SpeedDecreased { get; } = null!;
    public Event<ShotTaken90> ShotTaken { get; } = null!;

    public State Starting { get; } = null!;
    public State Started { get; } = null!;
    public State Running { get; } = null!;
    public State Walking { get; } = null!;
    public State Sipping { get; } = null!;
    public State Stalking { get; } = null!;
}


public class Start91
{
    public Guid CorrelationId { get; set; }
}

public class StartCompleted91
{
    public Guid CorrelationId { get; set; }
}

public class SpeedIncreased91
{
    public Guid CorrelationId { get; set; }
}

public class SpeedDecreased91
{
    public Guid CorrelationId { get; set; }
}

public class ShotTaken91
{
    public Guid CorrelationId { get; set; }
}

public class RequestA91
{
    public Guid CorrelationId { get; set; }
}

public class ResponseA91
{
    public Guid CorrelationId { get; set; }
}

public class RequestB91
{
    public Guid CorrelationId { get; set; }
}

public class ResponseB91
{
    public Guid CorrelationId { get; set; }
}

public class SampleStateMachineInstance91 :
    SagaStateMachineInstance
{
    public int CurrentState { get; set; }
    public Guid CorrelationId { get; set; }
}

public class SampleStateMachine91 :
    MassTransitStateMachine<SampleStateMachineInstance91>
{
    public SampleStateMachine91()
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
                .Request(ShotRequest, context => new RequestA91()),
            When(ShotRequest.Completed)
                .Then(_ => { }),
            When(ShotRequest.Faulted)
                .Then(_ => { }));
    }

    public Request<SampleStateMachineInstance91, RequestA91, ResponseA91> ShotRequest { get; } = null!;

    public Event<Start91> Start { get; } = null!;
    public Event<StartCompleted91> StartCompleted { get; } = null!;
    public Event<SpeedIncreased91> SpeedIncreased { get; } = null!;
    public Event<SpeedDecreased91> SpeedDecreased { get; } = null!;
    public Event<ShotTaken91> ShotTaken { get; } = null!;

    public State Starting { get; } = null!;
    public State Started { get; } = null!;
    public State Running { get; } = null!;
    public State Walking { get; } = null!;
    public State Sipping { get; } = null!;
    public State Stalking { get; } = null!;
}


public class Start92
{
    public Guid CorrelationId { get; set; }
}

public class StartCompleted92
{
    public Guid CorrelationId { get; set; }
}

public class SpeedIncreased92
{
    public Guid CorrelationId { get; set; }
}

public class SpeedDecreased92
{
    public Guid CorrelationId { get; set; }
}

public class ShotTaken92
{
    public Guid CorrelationId { get; set; }
}

public class RequestA92
{
    public Guid CorrelationId { get; set; }
}

public class ResponseA92
{
    public Guid CorrelationId { get; set; }
}

public class RequestB92
{
    public Guid CorrelationId { get; set; }
}

public class ResponseB92
{
    public Guid CorrelationId { get; set; }
}

public class SampleStateMachineInstance92 :
    SagaStateMachineInstance
{
    public int CurrentState { get; set; }
    public Guid CorrelationId { get; set; }
}

public class SampleStateMachine92 :
    MassTransitStateMachine<SampleStateMachineInstance92>
{
    public SampleStateMachine92()
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
                .Request(ShotRequest, context => new RequestA92()),
            When(ShotRequest.Completed)
                .Then(_ => { }),
            When(ShotRequest.Faulted)
                .Then(_ => { }));
    }

    public Request<SampleStateMachineInstance92, RequestA92, ResponseA92> ShotRequest { get; } = null!;

    public Event<Start92> Start { get; } = null!;
    public Event<StartCompleted92> StartCompleted { get; } = null!;
    public Event<SpeedIncreased92> SpeedIncreased { get; } = null!;
    public Event<SpeedDecreased92> SpeedDecreased { get; } = null!;
    public Event<ShotTaken92> ShotTaken { get; } = null!;

    public State Starting { get; } = null!;
    public State Started { get; } = null!;
    public State Running { get; } = null!;
    public State Walking { get; } = null!;
    public State Sipping { get; } = null!;
    public State Stalking { get; } = null!;
}


public class Start93
{
    public Guid CorrelationId { get; set; }
}

public class StartCompleted93
{
    public Guid CorrelationId { get; set; }
}

public class SpeedIncreased93
{
    public Guid CorrelationId { get; set; }
}

public class SpeedDecreased93
{
    public Guid CorrelationId { get; set; }
}

public class ShotTaken93
{
    public Guid CorrelationId { get; set; }
}

public class RequestA93
{
    public Guid CorrelationId { get; set; }
}

public class ResponseA93
{
    public Guid CorrelationId { get; set; }
}

public class RequestB93
{
    public Guid CorrelationId { get; set; }
}

public class ResponseB93
{
    public Guid CorrelationId { get; set; }
}

public class SampleStateMachineInstance93 :
    SagaStateMachineInstance
{
    public int CurrentState { get; set; }
    public Guid CorrelationId { get; set; }
}

public class SampleStateMachine93 :
    MassTransitStateMachine<SampleStateMachineInstance93>
{
    public SampleStateMachine93()
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
                .Request(ShotRequest, context => new RequestA93()),
            When(ShotRequest.Completed)
                .Then(_ => { }),
            When(ShotRequest.Faulted)
                .Then(_ => { }));
    }

    public Request<SampleStateMachineInstance93, RequestA93, ResponseA93> ShotRequest { get; } = null!;

    public Event<Start93> Start { get; } = null!;
    public Event<StartCompleted93> StartCompleted { get; } = null!;
    public Event<SpeedIncreased93> SpeedIncreased { get; } = null!;
    public Event<SpeedDecreased93> SpeedDecreased { get; } = null!;
    public Event<ShotTaken93> ShotTaken { get; } = null!;

    public State Starting { get; } = null!;
    public State Started { get; } = null!;
    public State Running { get; } = null!;
    public State Walking { get; } = null!;
    public State Sipping { get; } = null!;
    public State Stalking { get; } = null!;
}


public class Start94
{
    public Guid CorrelationId { get; set; }
}

public class StartCompleted94
{
    public Guid CorrelationId { get; set; }
}

public class SpeedIncreased94
{
    public Guid CorrelationId { get; set; }
}

public class SpeedDecreased94
{
    public Guid CorrelationId { get; set; }
}

public class ShotTaken94
{
    public Guid CorrelationId { get; set; }
}

public class RequestA94
{
    public Guid CorrelationId { get; set; }
}

public class ResponseA94
{
    public Guid CorrelationId { get; set; }
}

public class RequestB94
{
    public Guid CorrelationId { get; set; }
}

public class ResponseB94
{
    public Guid CorrelationId { get; set; }
}

public class SampleStateMachineInstance94 :
    SagaStateMachineInstance
{
    public int CurrentState { get; set; }
    public Guid CorrelationId { get; set; }
}

public class SampleStateMachine94 :
    MassTransitStateMachine<SampleStateMachineInstance94>
{
    public SampleStateMachine94()
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
                .Request(ShotRequest, context => new RequestA94()),
            When(ShotRequest.Completed)
                .Then(_ => { }),
            When(ShotRequest.Faulted)
                .Then(_ => { }));
    }

    public Request<SampleStateMachineInstance94, RequestA94, ResponseA94> ShotRequest { get; } = null!;

    public Event<Start94> Start { get; } = null!;
    public Event<StartCompleted94> StartCompleted { get; } = null!;
    public Event<SpeedIncreased94> SpeedIncreased { get; } = null!;
    public Event<SpeedDecreased94> SpeedDecreased { get; } = null!;
    public Event<ShotTaken94> ShotTaken { get; } = null!;

    public State Starting { get; } = null!;
    public State Started { get; } = null!;
    public State Running { get; } = null!;
    public State Walking { get; } = null!;
    public State Sipping { get; } = null!;
    public State Stalking { get; } = null!;
}


public class Start95
{
    public Guid CorrelationId { get; set; }
}

public class StartCompleted95
{
    public Guid CorrelationId { get; set; }
}

public class SpeedIncreased95
{
    public Guid CorrelationId { get; set; }
}

public class SpeedDecreased95
{
    public Guid CorrelationId { get; set; }
}

public class ShotTaken95
{
    public Guid CorrelationId { get; set; }
}

public class RequestA95
{
    public Guid CorrelationId { get; set; }
}

public class ResponseA95
{
    public Guid CorrelationId { get; set; }
}

public class RequestB95
{
    public Guid CorrelationId { get; set; }
}

public class ResponseB95
{
    public Guid CorrelationId { get; set; }
}

public class SampleStateMachineInstance95 :
    SagaStateMachineInstance
{
    public int CurrentState { get; set; }
    public Guid CorrelationId { get; set; }
}

public class SampleStateMachine95 :
    MassTransitStateMachine<SampleStateMachineInstance95>
{
    public SampleStateMachine95()
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
                .Request(ShotRequest, context => new RequestA95()),
            When(ShotRequest.Completed)
                .Then(_ => { }),
            When(ShotRequest.Faulted)
                .Then(_ => { }));
    }

    public Request<SampleStateMachineInstance95, RequestA95, ResponseA95> ShotRequest { get; } = null!;

    public Event<Start95> Start { get; } = null!;
    public Event<StartCompleted95> StartCompleted { get; } = null!;
    public Event<SpeedIncreased95> SpeedIncreased { get; } = null!;
    public Event<SpeedDecreased95> SpeedDecreased { get; } = null!;
    public Event<ShotTaken95> ShotTaken { get; } = null!;

    public State Starting { get; } = null!;
    public State Started { get; } = null!;
    public State Running { get; } = null!;
    public State Walking { get; } = null!;
    public State Sipping { get; } = null!;
    public State Stalking { get; } = null!;
}


public class Start96
{
    public Guid CorrelationId { get; set; }
}

public class StartCompleted96
{
    public Guid CorrelationId { get; set; }
}

public class SpeedIncreased96
{
    public Guid CorrelationId { get; set; }
}

public class SpeedDecreased96
{
    public Guid CorrelationId { get; set; }
}

public class ShotTaken96
{
    public Guid CorrelationId { get; set; }
}

public class RequestA96
{
    public Guid CorrelationId { get; set; }
}

public class ResponseA96
{
    public Guid CorrelationId { get; set; }
}

public class RequestB96
{
    public Guid CorrelationId { get; set; }
}

public class ResponseB96
{
    public Guid CorrelationId { get; set; }
}

public class SampleStateMachineInstance96 :
    SagaStateMachineInstance
{
    public int CurrentState { get; set; }
    public Guid CorrelationId { get; set; }
}

public class SampleStateMachine96 :
    MassTransitStateMachine<SampleStateMachineInstance96>
{
    public SampleStateMachine96()
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
                .Request(ShotRequest, context => new RequestA96()),
            When(ShotRequest.Completed)
                .Then(_ => { }),
            When(ShotRequest.Faulted)
                .Then(_ => { }));
    }

    public Request<SampleStateMachineInstance96, RequestA96, ResponseA96> ShotRequest { get; } = null!;

    public Event<Start96> Start { get; } = null!;
    public Event<StartCompleted96> StartCompleted { get; } = null!;
    public Event<SpeedIncreased96> SpeedIncreased { get; } = null!;
    public Event<SpeedDecreased96> SpeedDecreased { get; } = null!;
    public Event<ShotTaken96> ShotTaken { get; } = null!;

    public State Starting { get; } = null!;
    public State Started { get; } = null!;
    public State Running { get; } = null!;
    public State Walking { get; } = null!;
    public State Sipping { get; } = null!;
    public State Stalking { get; } = null!;
}


public class Start97
{
    public Guid CorrelationId { get; set; }
}

public class StartCompleted97
{
    public Guid CorrelationId { get; set; }
}

public class SpeedIncreased97
{
    public Guid CorrelationId { get; set; }
}

public class SpeedDecreased97
{
    public Guid CorrelationId { get; set; }
}

public class ShotTaken97
{
    public Guid CorrelationId { get; set; }
}

public class RequestA97
{
    public Guid CorrelationId { get; set; }
}

public class ResponseA97
{
    public Guid CorrelationId { get; set; }
}

public class RequestB97
{
    public Guid CorrelationId { get; set; }
}

public class ResponseB97
{
    public Guid CorrelationId { get; set; }
}

public class SampleStateMachineInstance97 :
    SagaStateMachineInstance
{
    public int CurrentState { get; set; }
    public Guid CorrelationId { get; set; }
}

public class SampleStateMachine97 :
    MassTransitStateMachine<SampleStateMachineInstance97>
{
    public SampleStateMachine97()
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
                .Request(ShotRequest, context => new RequestA97()),
            When(ShotRequest.Completed)
                .Then(_ => { }),
            When(ShotRequest.Faulted)
                .Then(_ => { }));
    }

    public Request<SampleStateMachineInstance97, RequestA97, ResponseA97> ShotRequest { get; } = null!;

    public Event<Start97> Start { get; } = null!;
    public Event<StartCompleted97> StartCompleted { get; } = null!;
    public Event<SpeedIncreased97> SpeedIncreased { get; } = null!;
    public Event<SpeedDecreased97> SpeedDecreased { get; } = null!;
    public Event<ShotTaken97> ShotTaken { get; } = null!;

    public State Starting { get; } = null!;
    public State Started { get; } = null!;
    public State Running { get; } = null!;
    public State Walking { get; } = null!;
    public State Sipping { get; } = null!;
    public State Stalking { get; } = null!;
}


public class Start98
{
    public Guid CorrelationId { get; set; }
}

public class StartCompleted98
{
    public Guid CorrelationId { get; set; }
}

public class SpeedIncreased98
{
    public Guid CorrelationId { get; set; }
}

public class SpeedDecreased98
{
    public Guid CorrelationId { get; set; }
}

public class ShotTaken98
{
    public Guid CorrelationId { get; set; }
}

public class RequestA98
{
    public Guid CorrelationId { get; set; }
}

public class ResponseA98
{
    public Guid CorrelationId { get; set; }
}

public class RequestB98
{
    public Guid CorrelationId { get; set; }
}

public class ResponseB98
{
    public Guid CorrelationId { get; set; }
}

public class SampleStateMachineInstance98 :
    SagaStateMachineInstance
{
    public int CurrentState { get; set; }
    public Guid CorrelationId { get; set; }
}

public class SampleStateMachine98 :
    MassTransitStateMachine<SampleStateMachineInstance98>
{
    public SampleStateMachine98()
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
                .Request(ShotRequest, context => new RequestA98()),
            When(ShotRequest.Completed)
                .Then(_ => { }),
            When(ShotRequest.Faulted)
                .Then(_ => { }));
    }

    public Request<SampleStateMachineInstance98, RequestA98, ResponseA98> ShotRequest { get; } = null!;

    public Event<Start98> Start { get; } = null!;
    public Event<StartCompleted98> StartCompleted { get; } = null!;
    public Event<SpeedIncreased98> SpeedIncreased { get; } = null!;
    public Event<SpeedDecreased98> SpeedDecreased { get; } = null!;
    public Event<ShotTaken98> ShotTaken { get; } = null!;

    public State Starting { get; } = null!;
    public State Started { get; } = null!;
    public State Running { get; } = null!;
    public State Walking { get; } = null!;
    public State Sipping { get; } = null!;
    public State Stalking { get; } = null!;
}


public class Start99
{
    public Guid CorrelationId { get; set; }
}

public class StartCompleted99
{
    public Guid CorrelationId { get; set; }
}

public class SpeedIncreased99
{
    public Guid CorrelationId { get; set; }
}

public class SpeedDecreased99
{
    public Guid CorrelationId { get; set; }
}

public class ShotTaken99
{
    public Guid CorrelationId { get; set; }
}

public class RequestA99
{
    public Guid CorrelationId { get; set; }
}

public class ResponseA99
{
    public Guid CorrelationId { get; set; }
}

public class RequestB99
{
    public Guid CorrelationId { get; set; }
}

public class ResponseB99
{
    public Guid CorrelationId { get; set; }
}

public class SampleStateMachineInstance99 :
    SagaStateMachineInstance
{
    public int CurrentState { get; set; }
    public Guid CorrelationId { get; set; }
}

public class SampleStateMachine99 :
    MassTransitStateMachine<SampleStateMachineInstance99>
{
    public SampleStateMachine99()
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
                .Request(ShotRequest, context => new RequestA99()),
            When(ShotRequest.Completed)
                .Then(_ => { }),
            When(ShotRequest.Faulted)
                .Then(_ => { }));
    }

    public Request<SampleStateMachineInstance99, RequestA99, ResponseA99> ShotRequest { get; } = null!;

    public Event<Start99> Start { get; } = null!;
    public Event<StartCompleted99> StartCompleted { get; } = null!;
    public Event<SpeedIncreased99> SpeedIncreased { get; } = null!;
    public Event<SpeedDecreased99> SpeedDecreased { get; } = null!;
    public Event<ShotTaken99> ShotTaken { get; } = null!;

    public State Starting { get; } = null!;
    public State Started { get; } = null!;
    public State Running { get; } = null!;
    public State Walking { get; } = null!;
    public State Sipping { get; } = null!;
    public State Stalking { get; } = null!;
}


