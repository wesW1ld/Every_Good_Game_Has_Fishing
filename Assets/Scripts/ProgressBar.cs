using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProgressBar : MonoBehaviour
{
    Image pb;

    public float speed;

    private void Start() 
    {
        pb = GetComponent<Image>();

        pb.fillAmount = 0f;
    }

    private void Update() 
    {
        if(GameManager.Instance.fill == true)
        {
            pb.fillAmount += speed;
        }
    }
}
