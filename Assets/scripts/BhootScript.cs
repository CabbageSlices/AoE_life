using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BhootScript : MonoBehaviour
{
    public Transform TargetObject;

    float speed = 10.0F;
    float followDistance = 5.0F;
    Vector3 velocity;

    // Start is called before the first frame update
    private void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {   
        var distance = transform.position - TargetObject.position;
        if (Mathf.Abs(distance.x) + Mathf.Abs(distance.y) < followDistance){
            transform.position = Vector2.Lerp(transform.position, TargetObject.position, Time.deltaTime);
        }
        else {
            velocity = Random.insideUnitCircle * speed;
            transform.Translate(velocity * Time.deltaTime);        
        }
    }
}
