using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;

public class GameController : MonoBehaviour
{
    public float timeLimitInSeconds = 10;

    public float timeElapsed = 0;
    public int numItemsToSpawn = 1;
    public int numItemsPickedUp = 0;

    public LifeDisplayController lifeDisplay;

    public bool gameStarted = true;

    public Light2D playerLight;

    float targetLightRadius;

    public ParticleSystem playerPickupParticleEmitter;

    public AudioSource playerSfxSource;

    // Start is called before the first frame update
    void Start()
    {
        GameObject[] items = GameObject.FindGameObjectsWithTag("pickup");
        numItemsToSpawn = items.Length;
        targetLightRadius = playerLight.pointLightOuterRadius;
    }

    // Update is called once per frame
    void Update()
    {
        if (gameStarted)
        {

            float timeRemaining = timeLimitInSeconds - timeElapsed;
            lifeDisplay.setTimeRemainingAsPercent(timeRemaining / timeLimitInSeconds);

            timeElapsed += Time.deltaTime;

            playerLight.pointLightOuterRadius = Mathf.Lerp(playerLight.pointLightOuterRadius, targetLightRadius, Time.deltaTime);
        }
    }

    public void startGame()
    {
        gameStarted = true;
        timeElapsed = 0;
        numItemsPickedUp = 0;
        lifeDisplay.setHeartValue(0);
    }

    public void onItemPickup()
    {
        numItemsPickedUp += 1;
        lifeDisplay.setHeartValue((float)numItemsPickedUp / (float)numItemsToSpawn);
        targetLightRadius += 1.5f;


        playerPickupParticleEmitter.Emit(400);

        playerSfxSource.Play();
    }
}
