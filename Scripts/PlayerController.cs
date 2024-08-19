using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private PlayDataProvider dateProvider;

    private void Update()
    {
        dateProvider.UpdateInput();
        dateProvider.UpdatePosition();
    }
}