using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[RequireComponent(typeof (Collider))]
public class Interactable : MonoBehaviour
{
	public bool InteractionCue;

	public Transform InteractionCueAnchor;

	public List<FireTargetBase> Targets;

	public void Trigger()
	{
		foreach(FireTargetBase target in Targets) {
			target.Fire();
		}
	}
}
