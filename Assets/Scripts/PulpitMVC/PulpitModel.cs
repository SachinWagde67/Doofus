using UnityEngine;

public class PulpitModel 
{
    private PulpitController pulpitController;

    public float destroyTime { get; set; }
    public float spawnTime { get; set; }

    public void setPulpitController(PulpitController controller)
    {
        pulpitController = controller;
    }

    public PulpitModel(Data data)
    {
        destroyTime = Random.Range(data.pulpitData.minDestroyTime, data.pulpitData.maxDestroyTime);
        spawnTime = data.pulpitData.spawnTime;
    }

    public void destroyModel()
    {
        pulpitController = null;
    }
}
