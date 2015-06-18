using UnityEngine;
using System.Collections;

public class FireTargetBase : MonoBehaviour
{
	public virtual void Fire() // TODO: Pass trigger (player) information to the fire target
	{
		Debug.Log("FIRE!");
	}
}
