using UnityEngine;
using System.Collections;

[RequireComponent(typeof (Camera))]
public class PointClickInteractor : MonoBehaviour
{
	private Camera m_Camera;
	void Start()
	{
		m_Camera = GetComponent<Camera>();
	}

	void Update()
	{
		if(Input.GetButtonDown("Interact")) {
			RaycastHit hitInfo;

			// TODO: ADD DISTANCE WHEN CAMERA MOVEMENT!
			// TODO: Layer mask for interaction???
			if(Physics.Raycast(m_Camera.ScreenPointToRay(Input.mousePosition), out hitInfo)) {
				Interactable interactee = hitInfo.collider.GetComponent<Interactable>();

				if(interactee) {
					interactee.Trigger();
				}
			}
		}
	}
}
