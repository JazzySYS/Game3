using UnityEngine;

public class ButtonUp : MonoBehaviour
{
    public Animator bAnim;

    void OnTriggerExit()
    {
        if(ButtonDown.buttonDown == true)
        {
            bAnim.Play("ButtonUp", 0, 0.0f);
            ButtonDown.buttonDown = false;
        }
    }
}
