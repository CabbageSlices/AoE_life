using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifeDisplayController : MonoBehaviour
{
    public Animator animator;
    public RectTransform heartValueDisplayRect;

    [SerializeField]
    public GameObject heartValueDisplayObject;

    public Image heartValueDisplayImage;

    // Start is called before the first frame update
    void Start()
    {

    }

    private void Awake()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void setHeartValue(float percentAmount)
    {
        if (percentAmount <= 0)
        {
            percentAmount = 0;
        }
        heartValueDisplayRect.localScale = new Vector3(heartValueDisplayRect.localScale.x, percentAmount, heartValueDisplayRect.localScale.z);
    }


    public void setTimeRemainingAsPercent(float timeRemaningNormalized)
    {
        if (timeRemaningNormalized <= 0)
        {
            timeRemaningNormalized = 0;
        }
        animator.speed = timeRemaningNormalized + 0.05f;
        heartValueDisplayImage.color = Color.red * timeRemaningNormalized;
    }
}
