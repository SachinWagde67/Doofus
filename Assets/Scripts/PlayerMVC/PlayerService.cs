using UnityEngine;
using Cinemachine;

public class PlayerService : SingletonGeneric<PlayerService>
{
    [HideInInspector] public PlayerView playerView;
    public CinemachineVirtualCamera virtualCamera;

    [SerializeField] private GameObject playerPrefab;
    private PlayerController playerController;

    public override void Awake()
    {
        base.Awake();
    }

    private void Start()
    {
        playerController = new PlayerController();
        playerController.setCamera(virtualCamera);
    }

    public void spawnPlayer(Vector3 pos)
    {
        GameObject player = Instantiate(playerPrefab);
        playerView = player.GetComponent<PlayerView>();
        playerView.setPlayerPosition(pos);
    }
}
