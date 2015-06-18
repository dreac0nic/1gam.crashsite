using UnityEngine;
using System.Collections;

[RequireComponent(typeof (Light))]
public class LightToggleTarget : FireTargetBase
{
	protected Light m_TargetLight;

	public void Start() {
		m_TargetLight = GetComponent<Light>();
	}

	public override void Fire() // TODO: Pass trigger (player) information to the fire target
	{
		m_TargetLight.enabled = !m_TargetLight.enabled;
	}
}
