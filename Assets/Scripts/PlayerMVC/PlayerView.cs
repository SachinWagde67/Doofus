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

    public void setPlayerPosition(int i, int j, GameObject platformPrefab)
    {
        transform.position = new Vector3(i * platformPrefab.transform.localScale.x, 1f, j * platformPrefab.transform.localScale.z);
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
