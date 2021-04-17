using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalEnabler : MonoBehaviour
{
    public GameObject eGoal;
    public GameObject dGoal;

    void OnTriggerEnter()
    {
        eGoal.SetActive(true);
        dGoal.SetActive(false);
    }
}
