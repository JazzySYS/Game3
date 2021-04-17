using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SensitivityValue : MonoBehaviour
{
    public Slider SensitivityBar;
    public static float sensVal;

    public void Update()
    {
        sensVal = SensitivityBar.value;
    }
}
