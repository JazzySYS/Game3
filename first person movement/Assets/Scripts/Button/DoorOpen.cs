using UnityEngine;

public class DoorOpen : MonoBehaviour
{
    public Animator doorAnim;
    public DoorOpen dOp;

    public bool doorOpened = false;

    void OnTriggerEnter()
    {
        if (!doorOpened)
        {
            doorAnim.Play("DoorOpen", 0, 0.0f);
            dOp.enabled = false;
            doorOpened = true;
        }
    }
}
