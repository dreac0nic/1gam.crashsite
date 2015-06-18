using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Interactable : MonoBehaviour
{
	public List<FireTargetBase> Targets;

	public void Trigger()
	{
		foreach(FireTargetBase target in Targets) {
			target.Fire();
		}
	}
}
