using UnityEngine;

public class PlayerInputManager
{
    public Vector2 MoveInputDir { get; private set; }

    public void UpdateInput()
    {
        var moveInputDir = new Vector2(Input.GetAxis("Horizontal"),
            Input.GetAxis("Vertical"));
        MoveInputDir = moveInputDir;
    }
}
