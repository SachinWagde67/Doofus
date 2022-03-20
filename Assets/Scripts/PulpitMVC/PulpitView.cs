using TMPro;
using UnityEngine;

public class PulpitView : MonoBehaviour
{
    public GameObject Collider;
    public PulpitController pulpitController;
    public PulpitState initialState;
    public TextMeshProUGUI timeTxt;
    public PulpitInitialise initializePulpit;
    public PulpitSpawned spawnedPulpit;
    public PulpitDestroy destroyPulpit;
    [HideInInspector] public float destroyTime;
    [HideInInspector] public float spawnTime;
    [HideInInspector] public PulpitStateEnum currentState;

    private void Start()
    {
        spawnTime = GameManager.Instance.data.pulpitData.spawnTime;
        destroyTime = Random.Range(GameManager.Instance.data.pulpitData.minDestroyTime, GameManager.Instance.data.pulpitData.maxDestroyTime);
    }

    public void setPulpitController(PulpitController controller)
    {
        pulpitController = controller;
    }

    public PulpitController getPulpitController()
    {
        return pulpitController;
    }

    public Vector3 setPulpitPosition(Direction rand, PulpitView view, Vector3 lastPosition)
    {
        switch (rand)
        {
            case Direction.Left:
                view.transform.position = new Vector3(lastPosition.x + view.transform.localScale.x, lastPosition.y, lastPosition.z);
                break;
            case Direction.Right:
                view.transform.position = new Vector3(lastPosition.x - view.transform.localScale.x, lastPosition.y, lastPosition.z);
                break;
            case Direction.Up:
                view.transform.position = new Vector3(lastPosition.x, lastPosition.y, lastPosition.z + view.transform.localScale.z);
                break;
            case Direction.Down:
                view.transform.position = new Vector3(lastPosition.x, lastPosition.y, lastPosition.z - view.transform.localScale.z);
                break;
        }
        return view.transform.position;
    }

    public void destroyView()
    {
        pulpitController = null;
    }

}
