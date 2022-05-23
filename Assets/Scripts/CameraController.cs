using UnityEngine;

public class CameraController : MonoBehaviour
{
    [Header("Settings Camera")]
    [SerializeField]
    private Transform player;
    [SerializeField]
    private int speedCam = 10;
    [SerializeField]
    private float radiusCam = 3;

    private void Start()
    {
        transform.Translate(player.position.x, player.position.y + 2, -10);
    }

    void Update()
    {

    var diffX = player.position.x - transform.position.x;
    var diffY = player.position.y - transform.position.y;

    if (Mathf.Abs(diffX) > radiusCam)
        {
            transform.Translate(Mathf.Sign(diffX) * speedCam * Time.deltaTime, 0, 0);
        }

    if (Mathf.Abs(diffY) > radiusCam)
        {   
            transform.Translate(0, Mathf.Sign(diffY) * speedCam * Time.deltaTime, 0);
        }
    }

 
}