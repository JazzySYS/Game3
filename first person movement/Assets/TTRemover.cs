using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TTRemover : MonoBehaviour
{
    public GameObject TT;

    void OnTriggerExit()
    {
        TT.SetActive(false);
    }
}
