using UnityEngine;

public class PulpitView : MonoBehaviour
{
    private PulpitController pulpitController;

    public void setPulpitController(PulpitController controller)
    {
        pulpitController = controller;
    }

    public void destroyView()
    {
        pulpitController = null;
    }
}
