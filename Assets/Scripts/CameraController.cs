using UnityEngine;

public class CameraController : MonoBehaviour
{
    [Header("Settings Camera")]
    [SerializeField]
    private Transform player;
    [SerializeField]
    private float radiusCam = 3;
    private Vector3 playerVector;

    void Update()
    {
        playerVector = player.position;
        playerVector.z = -10;
        
        var diffX = playerVector.x - transform.position.x;
        var diffY = playerVector.y - transform.position.y;

        if (Mathf.Abs(diffX) > radiusCam)
        {
            transform.position = Vector3.Lerp(transform.position, playerVector, Time.deltaTime);
        }

        if (Mathf.Abs(diffY) > radiusCam)
        {
            transform.position = Vector3.Lerp(transform.position, playerVector, Time.deltaTime);
        }
    }

 
}