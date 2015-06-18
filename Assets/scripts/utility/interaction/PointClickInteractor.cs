using UnityEngine;
using UnityEngine.UI;
using System.Collections;

[RequireComponent(typeof (Camera))]
public class PointClickInteractor : MonoBehaviour
{
	public Canvas HUDCanvas;

	public float InteractionDistance = 2.0f;

	// TODO: Add reference to prefab to use as a cue for interacting with the object.

	private Camera m_Camera;

	void Start()
	{
		m_Camera = GetComponent<Camera>();
	}

	void Update()
	{
		RaycastHit hitInfo;

		if(Physics.Raycast(m_Camera.ScreenPointToRay(Input.mousePosition), out hitInfo, InteractionDistance)) {
			Interactable interactee = hitInfo.collider.GetComponent<Interactable>();

			if(interactee) {
				// Pop interaction cue above interactable.
				// TODO: DO THAT THING

				// Interact with object if interact button is pushed.
				if(Input.GetButtonDown("Interact"))
					interactee.Trigger();
			}
		}
	}
}
