using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sensitivity : MonoBehaviour
{
    public Slider sensitivity;
    public static float sensVal;

    public void Update()
    {
        sensVal = sensitivity.value;
    }
}
