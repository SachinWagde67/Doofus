using UnityEngine;

public class PulpitInitialise : PulpitState
{
    public override void OnStateEnter()
    {
        base.OnStateEnter();
        pulpitView.gameObject.SetActive(true);
        pulpitView.currentState = PulpitStateEnum.InitialisePulpit;
        pulpitView.destroyTime = Random.Range(GameManager.Instance.data.pulpitData.minDestroyTime, GameManager.Instance.data.pulpitData.maxDestroyTime);
        pulpitView.initialState.changeState(pulpitView.spawnedPulpit);
    }

    public override void OnStateExit()
    {
        base.OnStateExit();
    }
}
