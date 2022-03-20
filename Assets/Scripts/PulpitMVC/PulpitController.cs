using UnityEngine;

public class PulpitController
{
    private PulpitModel pulpitModel;
    private PulpitView pulpitView;

    public PulpitController(PulpitView view)
    {
        pulpitModel = new PulpitModel(GameManager.Instance.data);
        pulpitView = view;
        pulpitModel.setPulpitController(this);
        pulpitView.setPulpitController(this);
    }

    public void destroyController()
    {
        pulpitModel.destroyModel();
        pulpitView.destroyView();
        pulpitModel = null;
        pulpitView = null;
    }
}
