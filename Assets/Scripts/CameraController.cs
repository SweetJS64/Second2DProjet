using UnityEngine;

public class CameraController : MonoBehaviour
{
    [Header("Settings Camera")]
    [SerializeField]
    private Transform player;
    [SerializeField]
    private float radiusCam = 3;
    private Vector3 _playerVector;

    void Update()
    {
        _playerVector = player.position;
        _playerVector.z = -10;

        var position = transform.position;
        var diffX = _playerVector.x - position.x;
        var diffY = _playerVector.y - position.y;

        if (Mathf.Abs(diffX) > radiusCam)
        {
            transform.position = Vector3.Lerp(transform.position, _playerVector, Time.deltaTime);
        }

        if (Mathf.Abs(diffY) > radiusCam)
        {
            transform.position = Vector3.Lerp(transform.position, _playerVector, Time.deltaTime);
        }
    }

 
}