using UnityEngine;

public class PulpitGenerator : MonoBehaviour
{
    private GameObject[,] platforms;
    [SerializeField] private GameObject platformPrefab;
    [SerializeField] private Transform platformParent;
    [SerializeField] private int rows;
    [SerializeField] private int cols;

    private void Awake()
    {
        platforms = new GameObject[rows,cols];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                spawnPlatform(i, j);
            }
        }
    }

    private void spawnPlatform(int i, int j)
    {
        GameObject obj = Instantiate(platformPrefab, platformParent);
        obj.transform.position = new Vector3(i * platformPrefab.transform.localScale.x, 0f, j * platformPrefab.transform.localScale.z);
        obj.SetActive(false); 
        if (i == rows / 2 && j == cols / 2)
        {
            obj.SetActive(true);
            PlayerService.Instance.spawnPlayer(i, j, platformPrefab);
        }
    }
}
