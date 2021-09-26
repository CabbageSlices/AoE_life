using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainChar : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody2D player;
    public float moveSpeed = 10f;
    // Update is called once per frame
    void Start ()
    {
        player = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        player.velocity = new Vector3(moveSpeed * Input.GetAxis("Horizontal"), moveSpeed * Input.GetAxis("Vertical"), 0f);

    }
}
