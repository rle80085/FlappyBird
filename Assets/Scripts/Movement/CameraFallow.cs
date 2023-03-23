
using UnityEngine;

public class CameraFallow : MonoBehaviour
{
    public Transform character;

    [Header("Camera Settings")]
    public float Smoothing;
    public float offset;

    private Vector2 StartPosition;
    private Vector2 LastPostion;

    void Start()
    {
        StartPosition = transform.position;
    }
    void LateUpdate()
    {
        Vector2 CurrentPosition = new Vector2(character.position.x, character.position.y);

        LastPostion = Vector2.Lerp(LastPostion, CurrentPosition, 1);

        transform.position = new Vector3(LastPostion.x, StartPosition.y, offset);
    }

}

