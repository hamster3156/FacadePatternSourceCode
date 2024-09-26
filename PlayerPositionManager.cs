using UnityEngine;

public class PlayerPositionManager
{
    public void UpdateMovePos(Vector2 moveDir)
    {
        if (moveDir != Vector2.zero)
        {
            Debug.Log("プレイヤーが移動している");
        }
        else
        {
            Debug.Log("プレイヤーが止まっている");
        }
    }
}
