using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SensitivityValue : MonoBehaviour
{
    public Slider sensitivity;
    public static float sensVal = 300f;

    public void Update()
    {
            sensVal = sensitivity.value;
    }
}
