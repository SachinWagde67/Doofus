using UnityEngine;

public class PulpitController
{
    public PulpitModel pulpitModel;
    public PulpitView pulpitView;

    public PulpitController(PulpitView view)
    {
        pulpitModel = new PulpitModel(GameManager.Instance.data);
        pulpitView = view;
        pulpitView.setPulpitController(this);
        pulpitModel.setPulpitController(this);
    }

    public void generateNextPulpit()
    {
        PulpitView view = PulpitService.Instance.GetPulpitFromPool();
        view.gameObject.SetActive(true);
        view.Collider.SetActive(true);
        Direction dir = (Direction)PulpitService.Instance.getDirection();
        view.transform.position = view.setPulpitPosition(dir, view, PulpitService.Instance.prevPulpitPosition);
        PulpitService.Instance.prevPulpitPosition = view.transform.position;
        view.initialState.changeState(view.initializePulpit);
    }

    public void destroyController()
    {
        pulpitModel.destroyModel();
        pulpitView.destroyView();
        pulpitModel = null;
        pulpitView = null;
    }
}
