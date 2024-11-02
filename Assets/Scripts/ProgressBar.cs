using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProgressBar : MonoBehaviour
{
    Image pb;

    private void Start() 
    {
        pb = GetComponent<Image>();
    }

    private void Update() 
    {
        pb.fillAmount = .5f;
    }
}
