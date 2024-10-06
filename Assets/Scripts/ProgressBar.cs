using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProgressBar : MonoBehaviour
{
    private Slider slider;

    //private float targetProgress = 1f;

    public float FillSpeed = 0.25f;
    public float barRemoveSpeed = 1f;

    public bool incrementProgress = true;

    private void Awake()
    {
        slider = gameObject.GetComponent<Slider>();
    }
    // Update is called once per frame
    void Update()
    {
        if (incrementProgress == true)
        {
            slider.value += FillSpeed * Time.deltaTime;
        }
        else
        {
            slider.value -= barRemoveSpeed * Time.deltaTime;
        }
        
    }

    public void usingPower(bool isUsingPower) {
        incrementProgress = !isUsingPower;
    }

    public float getProgress()
    {
        return slider.value;
    }

    ////Add progress to bar
    //public void changeProgress(float newProgress)
    //{
    //    targetProgress = newProgress;
    //}

}
