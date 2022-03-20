using UnityEngine;

public class PulpitSpawned : PulpitState
{
    private float timer;
    private bool isPulpitSpawned;

    public override void OnStateEnter()
    {
        base.OnStateEnter();
        timer = 0f;
        isPulpitSpawned = false;
        pulpitView.currentState = PulpitStateEnum.SpawnedPulpit;
    }

    private void Update()
    {
        destroyPulpitAfterTime();
        if (!isPulpitSpawned)
        {
            spawnPulpitAfterTime();
        }
    }

    public override void OnStateExit()
    {
        base.OnStateExit();
    }

    private void destroyPulpitAfterTime()
    {
        pulpitView.destroyTime -= Time.deltaTime;
        pulpitView.timeTxt.text = pulpitView.destroyTime.ToString("f2");
        if (pulpitView.destroyTime <= 0f)
        {
            pulpitView.initialState.changeState(pulpitView.destroyPulpit);
        }
    }

    private void spawnPulpitAfterTime()
    {
        timer += Time.deltaTime;
        if (pulpitView.spawnTime <= timer)
        {
            isPulpitSpawned = true;
            PulpitService.Instance.pulpitController.generateNextPulpit();
        }
    }
}
