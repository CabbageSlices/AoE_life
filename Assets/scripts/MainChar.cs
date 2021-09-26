using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainChar : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody2D player;
    public float moveSpeed = 10f;
    public GameController controller;
    public bool isDead = false;

    public Animator animator;

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

        if (animator == null)
        {
            animator = GetComponent<Animator>();
        }
    }
    void Update()
    {
        if (controller.gameStarted && !isDead)
        {

            player.velocity = new Vector3(moveSpeed * Input.GetAxis("Horizontal"), moveSpeed * Input.GetAxis("Vertical"), 0f);
        }
        else
        {
            player.velocity = Vector3.zero;
        }

    }

    private void LateUpdate()
    {
        if (controller.gameStarted)
        {

            Camera.main.transform.position = transform.position - new Vector3(0, 0, 10);
        }
    }

    public void finishDying()
    {
        controller.onPlayerDeath();
    }

    public void startDying()
    {
        isDead = true;
        animator.Play("dying");
        player.velocity = Vector3.zero;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!isDead && controller.gameStarted && other.tag == "deathThing")
        {
            startDying();
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (!isDead && controller.gameStarted && other.gameObject.tag == "deathThing")
        {
            startDying();
        }
    }
}
