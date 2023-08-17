using System;
using UnityEngine;

[Serializable]
public class WaspTrig : MonoBehaviour
{
	public GameObject parent;

	private WaspScript wasp;

	public override void Awake()
	{
		wasp = (WaspScript)(object)parent.GetComponent("WaspScript");
	}

	public override void OnTriggerEnter(Collider c)
	{
		if (((Component)c).gameObject.layer == 8)
		{
			((Component)wasp).SendMessage("SetPlayer", (object)((Component)c).gameObject);
		}
	}

	public override void Main()
	{
	}
}
