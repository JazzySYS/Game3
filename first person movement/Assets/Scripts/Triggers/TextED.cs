using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextED : MonoBehaviour
{
    public GameObject TextE;
    public GameObject TextD;

    void OnTriggerEnter()
    {
        TextE.SetActive(true);
        TextD.SetActive(false);
    }
}
