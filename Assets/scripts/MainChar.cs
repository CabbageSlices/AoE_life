using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainChar : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody2D player;
    public float moveSpeed = 10f;
    public GameController controller;
    // Update is called once per frame
    void Start()
    {
        player = GetComponent<Rigidbody2D>();
    }

    private void Awake()
    {
        if (controller == null)
        {
            controller = GameObject.FindWithTag("gameController").GetComponent<GameController>();
        }
    }
    void Update()
    {
        player.velocity = new Vector3(moveSpeed * Input.GetAxis("Horizontal"), moveSpeed * Input.GetAxis("Vertical"), 0f);

    }

    private void LateUpdate()
    {
        if (controller.gameStarted)
        {

            Camera.main.transform.position = transform.position - new Vector3(0, 0, 10);
        }
    }
}
