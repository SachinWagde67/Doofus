using UnityEngine;

public class PulpitService : SingletonGeneric<PulpitService>
{
    [HideInInspector] public PulpitView pulpitView;
    public int rows;
    public int cols;
    
    private PulpitController pulpitController;
    private GameObject[,] platforms;
    [SerializeField] private GameObject platformPrefab;
    [SerializeField] private Transform platformParent;

    public override void Awake()
    {
        base.Awake();
    }

    private void Start()
    {
        generatePulpits();
        pulpitController = new PulpitController(pulpitView);
    }

    private void generatePulpits()
    {
        platforms = new GameObject[rows, cols];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                spawnPulpit(i, j);
            }
        }
    }

    private void spawnPulpit(int i, int j)
    {
        GameObject obj = Instantiate(platformPrefab, platformParent);
        pulpitView = obj.GetComponent<PulpitView>();
        pulpitView.transform.position = new Vector3(i * platformPrefab.transform.localScale.x, 0f, j * platformPrefab.transform.localScale.z);
        pulpitView.gameObject.SetActive(false);
        if (i == rows / 2 && j == cols / 2)
        {
            pulpitView.gameObject.SetActive(true);
            PlayerService.Instance.spawnPlayer(i, j, platformPrefab);
        }
    }
}
