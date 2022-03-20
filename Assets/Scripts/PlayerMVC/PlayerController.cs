using UnityEngine;
using Cinemachine;

public class PlayerController
{
    private PlayerModel playerModel;
    private PlayerView playerView;
    private Rigidbody rb;
    private CinemachineVirtualCamera camera;

    public PlayerController()
    {
        playerView = PlayerService.Instance.playerView;
        playerModel = new PlayerModel(GameManager.Instance.data);
        playerView.setPlayerController(this);
        playerModel.setPlayerController(this);
    }

    public void setCamera(CinemachineVirtualCamera cam)
    {
        camera = cam;
        camera.Follow = playerView.transform;
        camera.LookAt = playerView.transform;
    }

    public void movePlayer(float xDir, float zDir)
    {
        Vector3 moveDir = new Vector3(xDir, 0f, zDir);
        playerView.transform.position += moveDir * playerModel.speed * Time.deltaTime;
    }

    public void destroyController()
    {
        playerModel.destroyModel();
        playerView.destroyView();
        playerModel = null;
        playerView = null;
    }
}
