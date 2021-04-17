using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SensitivityValueIG : MonoBehaviour
{
    public Slider sensitivity;
    
    void Start()
    {
        sensitivity.value = SensitivityValue.sensVal;
    }

    void Update()
    {
        SensitivityValue.sensVal = sensitivity.value;
    }
}
