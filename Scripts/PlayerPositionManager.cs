using UnityEngine;

public class PlayerPositionManager
{
    public void UpdateMovePos(Vector2 moveDir)
    {
        if (moveDir != Vector2.zero)
        {
            Debug.Log("�v���C���[���ړ����Ă���");
        }
        else
        {
            Debug.Log("�v���C���[���~�܂��Ă���");
        }
    }
}