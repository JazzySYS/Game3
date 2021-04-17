using UnityEngine;

public class Goals : MonoBehaviour
{
	//Getting objects Collider and renderer
	public Collider gCo;
	public Renderer gMesh;

	//Getting next objects collider and renderer
	public Collider hCo;
	public Renderer hMesh;

    void OnTriggerEnter()
    {
        gCo.enabled = false;
        gMesh.enabled = false;

        hCo.enabled = true;
        hMesh.enabled = true;
    }
}
