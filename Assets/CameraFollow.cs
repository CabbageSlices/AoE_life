
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform player;
    public float cameraSpeed = 0.125f;
    public Vector3 offset;
    
    void LateUpdate ()
    {
  
        transform.position = new Vector3(player.position.x, player.position.y, Time.deltaTime);
    }
}
