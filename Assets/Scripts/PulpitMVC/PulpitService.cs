using System;
using System.Collections.Generic;
using UnityEngine;

public class PulpitService : SingletonGeneric<PulpitService>
{
    [HideInInspector] public PulpitView pulpitView;
    [HideInInspector] public Vector3 prevPulpitPosition;
    [HideInInspector] public PulpitController pulpitController;
    
    public GameObject pulpitPrefab;
    public Transform pulpitParent;

    [SerializeField] private int poolSize;
    private Queue<PulpitView> pulpitPool;

    public override void Awake()
    {
        base.Awake();
    }

    private void Start()
    {
        pulpitPool = new Queue<PulpitView>();
        for (int i = 0; i < poolSize; i++)
        {
            CreatePulpitAndAddToPool();
        }
        createPulpit();
    }

    private void CreatePulpitAndAddToPool()
    {
        PulpitView createdPulpit = CreatePulpit();
        pulpitPool.Enqueue(createdPulpit);
        createdPulpit.gameObject.SetActive(false);
    }

    private PulpitView CreatePulpit()
    {
        PulpitView createdpulpit = Instantiate(pulpitPrefab, pulpitParent).GetComponent<PulpitView>();
        return createdpulpit;
    }

    public void AddPulpitBackToPool(PulpitView pulpit)
    { 
        pulpitPool.Enqueue(pulpit);
        pulpit.gameObject.SetActive(false);
    }

    public PulpitView GetPulpitFromPool()
    {
        if (pulpitPool.Count <= 0)
        {
            CreatePulpitAndAddToPool();
        }
        return pulpitPool.Dequeue();
    }

    public int getDirection()
    {
        int rand = UnityEngine.Random.Range(0, Enum.GetValues(typeof(Direction)).Length);
        return rand;
    }

    private void createPulpit()
    {
        PulpitView view = GetPulpitFromPool();
        pulpitController = new PulpitController(view);
        view.gameObject.SetActive(true);
        view.Collider.SetActive(true);
        prevPulpitPosition = view.transform.position;
        PlayerService.Instance.spawnPlayer(view.transform.position);
        view.initialState.changeState(view.initializePulpit);
    }
}
