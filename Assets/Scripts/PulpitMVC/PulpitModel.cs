using UnityEngine;

public class PulpitModel 
{
    private PulpitController pulpitController;

    public float minDestroyTime { get; set; }
    public float maxDestroyTime { get; set; }
    public float spawnTime { get; set; }

    public void setPulpitController(PulpitController controller)
    {
        pulpitController = controller;
    }

    public PulpitModel(Data data)
    {
        minDestroyTime = data.pulpitData.minDestroyTime;
        maxDestroyTime = data.pulpitData.maxDestroyTime;
        spawnTime = data.pulpitData.spawnTime;
    }

    public void destroyModel()
    {
        pulpitController = null;
    }
}
