using UnityEngine;
using UnityEngine.UI;

public class TextTrigger : MonoBehaviour
{
	public Text dtext1;
	public Text dtext2;
	public Text dtext3;
	public Text etext1;
	public Text etext2;
	public Text etext3;

	public Collider preTrig;

    void OnTriggerEnter(Collider CoInfo)
    {
        dtext1.enabled = false;
        dtext2.enabled = false;
        dtext3.enabled = false;
        etext1.enabled = true;
        etext2.enabled = true;
        etext3.enabled = true;

        preTrig.enabled = false;
    }
}
