using UnityEngine;

public class PulpitState : MonoBehaviour
{
    public PulpitView pulpitView;

    public virtual void OnStateEnter()
    {
        this.enabled = true;
    }

    public virtual void OnStateExit()
    {
        this.enabled = false;
    }

    public void changeState(PulpitState newState)
    {
        if (pulpitView.initialState != null)
        {
            pulpitView.initialState.OnStateExit();
        }
        pulpitView.initialState = newState;
        if (pulpitView.initialState != null)
        {
            pulpitView.initialState.OnStateEnter();
        }
    }
}
