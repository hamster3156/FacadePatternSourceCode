using UnityEngine;

public class PlayDataProvider : MonoBehaviour
{
    public Vector2 MoveDir => inputManager.MoveInputDir;
    private PlayerInputManager inputManager;
    private PlayerPositionManager positionManager;

    public void UpdateInput()
    {
        inputManager.UpdateInput();
    }

    public void UpdatePosition()
    {
        positionManager.UpdateMovePos(inputManager.MoveInputDir);
    }

    private void Start()
    {
        inputManager = new();
        positionManager = new();
    }
}
