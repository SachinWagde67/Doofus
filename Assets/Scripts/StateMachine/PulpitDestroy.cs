

public class PulpitDestroy : PulpitState
{
    public override void OnStateEnter()
    {
        base.OnStateEnter();
        pulpitView.currentState = PulpitStateEnum.DestroyPulpit;
        PulpitService.Instance.AddPulpitBackToPool(pulpitView);
    }

    public override void OnStateExit()
    {
        base.OnStateExit();
    }
}
