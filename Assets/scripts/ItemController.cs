using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemController : MonoBehaviour
{
    public GameController controller;
    bool triggered = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    private void Awake()
    {
        controller = GameObject.FindWithTag("gameController").GetComponent<GameController>();
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (triggered)
        {
            return;
        }

        triggered = true;
        if (other.gameObject.tag == "player")
        {
            controller.onItemPickup();
        }

        Destroy(gameObject);
    }
}
