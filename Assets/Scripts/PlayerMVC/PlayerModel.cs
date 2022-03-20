using UnityEngine;

public class PlayerModel
{
    private PlayerController playerController;

    public float speed { get; set; }

    public void setPlayerController(PlayerController controller)
    {
        playerController = controller;
    }

    public PlayerModel(Data data)
    {
        speed = data.playerData.speed;
    }

    public void destroyModel()
    {
        playerController = null;
    }
}
