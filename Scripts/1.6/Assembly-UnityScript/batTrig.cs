using System;
using UnityEngine;

[Serializable]
public class batTrig : MonoBehaviour
{
	public GameObject parent;

	private bat wasp;

	public override void Awake()
	{
		wasp = (bat)(object)parent.GetComponent("bat");
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
