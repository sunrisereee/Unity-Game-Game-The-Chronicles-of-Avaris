using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class MoveCamera : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private float smoothSpeed = 0.125f;
    [SerializeField] private bool followVertical = false;

    private float offsetX;

    void Start()
    {
        offsetX = transform.position.x - player.position.x;
    }

    void LateUpdate()
    {
        float newX = Mathf.Lerp(transform.position.x, player.position.x + offsetX, smoothSpeed);
        float newY = followVertical ? Mathf.Lerp(transform.position.y, player.position.y, smoothSpeed) : transform.position.y;

        transform.position = new Vector3(newX, newY, transform.position.z);
    }
}
