using UnityEngine;
using UnityEngine.UI;

public class Buton : MonoBehaviour
{

	[SerializeField] private int rayLength = 5;
	[SerializeField] private LayerMask layerMaskInteract;
	[SerializeField] private string excludeLayerName = null;

	private buttonCont raycastedObj;

	[SerializeField] private KeyCode pressButton = KeyCode.Mouse0;

	[SerializeField] private Image crosshair = null;

	private bool isCrossHairActive;
	private bool doOnce;

	private const string interactableTag = "Button";

	private void Update()
	{

		RaycastHit hit;

		Vector3 fwd = transform.TransformDirection(Vector3.forward);

		int mask = 1 << LayerMask.NameToLayer(excludeLayerName) | layerMaskInteract.value;

		if(Physics.Raycast(transform.position, fwd, out hit, rayLength, mask))
		{

			if(hit.collider.CompareTag(interactableTag))
			{

				if(!doOnce)
				{
					raycastedObj = hit.collider.gameObject.GetComponent<buttonCont>();

					CrosshairChange(true);
				}

				isCrossHairActive = true;
				doOnce = true;

				if(Input.GetKeyDown(pressButton)){
					raycastedObj.PlayAnimation();
				}

				else
				{
					if(isCrossHairActive)
					{
						CrosshairChange(false);
						doOnce = false;
					}

				}

			}

		}

	}

	void CrosshairChange (bool on)
	{
		if(on = true && !doOnce)
		{
			crosshair.color = Color.red;
		}
		else
		{
			crosshair.color = Color.white;
			isCrossHairActive = false;
		}
	}


}


