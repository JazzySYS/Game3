using UnityEngine;

public class ButtonDown : MonoBehaviour
{
    public Animator bAnim;
    public static bool buttonDown = false;

    void OnTriggerEnter()
    {
        if (!buttonDown)
        {
            bAnim.Play("ButtonDown", 0, 0.0f);
            buttonDown = true;
        }
    }
}
