using UnityEngine;

public class PlayerView : MonoBehaviour
{
    private PlayerController playerController;
    private float xDir, zDir;

    private void Update()
    {
        moveInput();
        playerController.movePlayer(xDir, zDir);
    }

    private void moveInput()
    {
        xDir = Input.GetAxis("Horizontal");
        zDir = Input.GetAxis("Vertical");
    }

    public void setPlayerPosition(Vector3 pos)
    {
        transform.position = pos;
    }

    public void setPlayerController(PlayerController controller)
    {
        playerController = controller;
    }

    public void destroyView()
    {
        playerController = null;
    }
}
