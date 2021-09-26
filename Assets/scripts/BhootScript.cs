using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BhootScript : MonoBehaviour
{
    public Transform TargetObject;
    public Rigidbody2D bhoot;

    [SerializeField]
    public float speed = 10.0F;
    [SerializeField]
    public float followDistance = 5.0F;
    Vector3 velocity;

    // Start is called before the first frame update
    private void Start()
    {
        bhoot = GetComponent<Rigidbody2D>();
    }

    private void Awake()
    {
        if (!TargetObject)
            TargetObject = GameObject.FindWithTag("player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        var distance = TargetObject.position - transform.position;
        if (distance.magnitude < followDistance)
        {
            var bhootToPlayerVector = distance.normalized;
            bhoot.velocity = new Vector3(bhootToPlayerVector.x * speed, bhootToPlayerVector.y * speed, 0f);
        }
        else
        {
            bhoot.velocity = Random.insideUnitCircle * speed;
        }
    }
}
