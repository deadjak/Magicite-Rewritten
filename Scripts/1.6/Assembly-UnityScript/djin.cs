using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class djin : EnemyScript
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Attack_00243133 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal GameObject _0024g_00243134;

			internal Vector3 _0024pp2_00243135;

			internal int _0024num_00243136;

			internal Vector3 _0024pp_00243137;

			internal djin _0024self__00243138;

			public _0024(Vector3 pp, djin self_)
			{
				//IL_0007: Unknown result type (might be due to invalid IL or missing references)
				//IL_0008: Unknown result type (might be due to invalid IL or missing references)
				_0024pp_00243137 = pp;
				_0024self__00243138 = self_;
			}

			public override bool MoveNext()
			{
				//IL_0051: Unknown result type (might be due to invalid IL or missing references)
				//IL_0056: Unknown result type (might be due to invalid IL or missing references)
				//IL_0230: Unknown result type (might be due to invalid IL or missing references)
				//IL_0235: Unknown result type (might be due to invalid IL or missing references)
				//IL_0255: Unknown result type (might be due to invalid IL or missing references)
				//IL_025a: Unknown result type (might be due to invalid IL or missing references)
				//IL_0265: Unknown result type (might be due to invalid IL or missing references)
				//IL_026f: Expected O, but got Unknown
				//IL_0289: Unknown result type (might be due to invalid IL or missing references)
				//IL_02a0: Unknown result type (might be due to invalid IL or missing references)
				//IL_02aa: Expected O, but got Unknown
				//IL_02c0: Unknown result type (might be due to invalid IL or missing references)
				//IL_02c5: Unknown result type (might be due to invalid IL or missing references)
				//IL_02e5: Unknown result type (might be due to invalid IL or missing references)
				//IL_02ea: Unknown result type (might be due to invalid IL or missing references)
				//IL_02f5: Unknown result type (might be due to invalid IL or missing references)
				//IL_02ff: Expected O, but got Unknown
				//IL_0319: Unknown result type (might be due to invalid IL or missing references)
				//IL_0576: Unknown result type (might be due to invalid IL or missing references)
				//IL_0580: Expected O, but got Unknown
				//IL_018a: Unknown result type (might be due to invalid IL or missing references)
				//IL_018f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0155: Unknown result type (might be due to invalid IL or missing references)
				//IL_015f: Expected O, but got Unknown
				//IL_0409: Unknown result type (might be due to invalid IL or missing references)
				//IL_0413: Expected O, but got Unknown
				//IL_034f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0364: Unknown result type (might be due to invalid IL or missing references)
				//IL_0369: Unknown result type (might be due to invalid IL or missing references)
				//IL_036e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0383: Unknown result type (might be due to invalid IL or missing references)
				//IL_0388: Unknown result type (might be due to invalid IL or missing references)
				//IL_039b: Unknown result type (might be due to invalid IL or missing references)
				//IL_03a0: Unknown result type (might be due to invalid IL or missing references)
				//IL_04a1: Unknown result type (might be due to invalid IL or missing references)
				//IL_04b1: Unknown result type (might be due to invalid IL or missing references)
				//IL_04b6: Unknown result type (might be due to invalid IL or missing references)
				//IL_04bb: Unknown result type (might be due to invalid IL or missing references)
				//IL_0462: Unknown result type (might be due to invalid IL or missing references)
				//IL_0477: Unknown result type (might be due to invalid IL or missing references)
				//IL_047c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0481: Unknown result type (might be due to invalid IL or missing references)
				//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
				//IL_0102: Expected O, but got Unknown
				//IL_03ec: Unknown result type (might be due to invalid IL or missing references)
				//IL_03c7: Unknown result type (might be due to invalid IL or missing references)
				//IL_01c5: Unknown result type (might be due to invalid IL or missing references)
				//IL_01ca: Unknown result type (might be due to invalid IL or missing references)
				//IL_01d5: Unknown result type (might be due to invalid IL or missing references)
				//IL_01df: Expected O, but got Unknown
				//IL_01f9: Unknown result type (might be due to invalid IL or missing references)
				//IL_0210: Unknown result type (might be due to invalid IL or missing references)
				//IL_021a: Expected O, but got Unknown
				//IL_04d0: Unknown result type (might be due to invalid IL or missing references)
				//IL_04d5: Unknown result type (might be due to invalid IL or missing references)
				//IL_04e8: Unknown result type (might be due to invalid IL or missing references)
				//IL_04ed: Unknown result type (might be due to invalid IL or missing references)
				//IL_053a: Unknown result type (might be due to invalid IL or missing references)
				//IL_0515: Unknown result type (might be due to invalid IL or missing references)
				//IL_0554: Unknown result type (might be due to invalid IL or missing references)
				//IL_055e: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					_0024self__00243138.ATKING = true;
					if (!(_0024pp_00243137.x <= ((Component)_0024self__00243138).transform.position.x))
					{
						if (MenuScript.multiplayer > 0)
						{
							((Component)_0024self__00243138).networkView.RPC("Turn", (RPCMode)2, new object[1] { 1 });
						}
						else
						{
							_0024self__00243138.Turn(1);
						}
					}
					else if (MenuScript.multiplayer > 0)
					{
						((Component)_0024self__00243138).networkView.RPC("Turn", (RPCMode)2, new object[1] { 0 });
					}
					else
					{
						_0024self__00243138.Turn(0);
					}
					_0024g_00243134 = null;
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.3f)) ? 1 : 0);
					break;
				case 2:
					if (MenuScript.multiplayer > 0)
					{
						((Component)_0024self__00243138).networkView.RPC("A1", (RPCMode)2, new object[0]);
					}
					else
					{
						_0024self__00243138.@base.animation.Play("a");
					}
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(3, new WaitForSeconds(0.5f)) ? 1 : 0);
					break;
				case 3:
					if (Object.op_Implicit((Object)(object)_0024self__00243138.player))
					{
						_0024pp2_00243135 = _0024self__00243138.player.transform.position;
						if (MenuScript.multiplayer > 0 && MenuScript.multiplayer == 1)
						{
							_0024g_00243134 = (GameObject)Network.Instantiate(Resources.Load("haz/whelpFire"), _0024self__00243138.djinPoint.transform.position, Quaternion.identity, 0);
							_0024g_00243134.networkView.RPC("Set", (RPCMode)2, new object[1] { _0024pp2_00243135 });
							result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(4, new WaitForSeconds(0.3f)) ? 1 : 0);
							break;
						}
					}
					goto IL_0329;
				case 4:
					_0024pp2_00243135 = _0024self__00243138.player.transform.position;
					_0024g_00243134 = (GameObject)Network.Instantiate(Resources.Load("haz/whelpFire"), _0024self__00243138.djinPoint.transform.position, Quaternion.identity, 0);
					_0024g_00243134.networkView.RPC("Set", (RPCMode)2, new object[1] { _0024pp2_00243135 });
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(5, new WaitForSeconds(0.3f)) ? 1 : 0);
					break;
				case 5:
					_0024pp2_00243135 = _0024self__00243138.player.transform.position;
					_0024g_00243134 = (GameObject)Network.Instantiate(Resources.Load("haz/whelpFire"), _0024self__00243138.djinPoint.transform.position, Quaternion.identity, 0);
					_0024g_00243134.networkView.RPC("Set", (RPCMode)2, new object[1] { _0024pp2_00243135 });
					goto IL_0329;
				case 6:
					_0024self__00243138.atking = false;
					if (Object.op_Implicit((Object)(object)_0024self__00243138.player))
					{
						_0024num_00243136 = Random.Range(0, 3);
						if (_0024num_00243136 == 0)
						{
							_0024self__00243138.curVector = _0024self__00243138.t.position - _0024self__00243138.player.transform.position;
						}
						else
						{
							_0024self__00243138.curVector = _0024self__00243138.player.transform.position - _0024self__00243138.t.position;
						}
						if (!(_0024self__00243138.player.transform.position.x <= _0024self__00243138.t.position.x))
						{
							_0024self__00243138.e.transform.rotation = Quaternion.Euler(0f, 180f, 0f);
						}
						else
						{
							_0024self__00243138.e.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
						}
						_0024self__00243138.atking = true;
						result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(7, new WaitForSeconds(2f)) ? 1 : 0);
						break;
					}
					goto case 7;
				case 7:
					_0024self__00243138.atking = false;
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(8, new WaitForSeconds(1.5f)) ? 1 : 0);
					break;
				case 8:
					_0024self__00243138.ATKING = false;
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				case 1:
					{
						result = 0;
						break;
					}
					IL_0329:
					if (Object.op_Implicit((Object)(object)_0024self__00243138.player))
					{
						_0024self__00243138.curVector = _0024self__00243138.t.position - _0024self__00243138.player.transform.position;
						if (!(_0024self__00243138.player.transform.position.x <= _0024self__00243138.t.position.x))
						{
							_0024self__00243138.e.transform.rotation = Quaternion.Euler(0f, 180f, 0f);
						}
						else
						{
							_0024self__00243138.e.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
						}
					}
					_0024self__00243138.atking = true;
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(6, new WaitForSeconds(0.5f)) ? 1 : 0);
					break;
				}
				return (byte)result != 0;
			}
		}

		internal Vector3 _0024pp_00243139;

		internal djin _0024self__00243140;

		public _0024Attack_00243133(Vector3 pp, djin self_)
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			_0024pp_00243139 = pp;
			_0024self__00243140 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024pp_00243139, _0024self__00243140);
		}
	}

	public GameObject djinPoint;

	private Vector3 curVector;

	private float speed;

	public AudioClip scourge1;

	private RaycastHit hit;

	private Ray r1U;

	private Ray r2U;

	private Ray r1D;

	private Ray r2D;

	private int mask;

	private int spd;

	private bool turning;

	private int mask2;

	private bool ATKING;

	private GameObject player;

	private bool atking;

	public djin()
	{
		speed = 10f;
		mask = 256;
		mask2 = 2048;
	}

	public override void Awake()
	{
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		t = ((Component)this).transform;
		r = ((Component)this).rigidbody;
		((Component)this).collider.material.dynamicFriction = 0f;
		@base.animation["i"].layer = 0;
		@base.animation["a"].layer = 1;
		int[] array = new int[3] { 7, 18, 0 };
		SetStats(85, 6, 2, 10, 2f, array, Random.Range(10, 25), 10);
		float y = ((Component)this).transform.position.y + (float)Random.Range(3, 10);
		Vector3 position = ((Component)this).transform.position;
		float num = (position.y = y);
		Vector3 val2 = (((Component)this).transform.position = position);
	}

	public override void SetPlayer(GameObject g)
	{
		player = g;
	}

	public override void Update()
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)player))
		{
			if (!(Mathf.Abs(player.transform.position.x - t.position.x) >= 18f) && !ATKING)
			{
				((MonoBehaviour)this).StartCoroutine_Auto(Attack(player.transform.position));
			}
			else if (atking && !(Mathf.Abs(player.transform.position.x - t.position.x) >= 10f) && !knocking && r.isKinematic)
			{
				t.Translate(((Vector3)(ref curVector)).normalized * 6f * Time.deltaTime);
			}
		}
	}

	public override IEnumerator Attack(Vector3 pp)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		return new _0024Attack_00243133(pp, this).GetEnumerator();
	}

	[RPC]
	public override void A1()
	{
		@base.animation.Play("a");
	}

	[RPC]
	public override void Turn(int dir)
	{
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		if (dir == 0)
		{
			int num = 0;
			Quaternion rotation = e.transform.rotation;
			float num2 = (rotation.y = num);
			Quaternion val2 = (e.transform.rotation = rotation);
		}
		else
		{
			int num3 = 180;
			Quaternion rotation2 = e.transform.rotation;
			float num4 = (rotation2.y = num3);
			Quaternion val4 = (e.transform.rotation = rotation2);
		}
	}
}
