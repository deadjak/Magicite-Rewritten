using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class fQueen : EnemyScript
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Summon_00243141 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal fQueen _0024self__00243142;

			public _0024(fQueen self_)
			{
				_0024self__00243142 = self_;
			}

			public override bool MoveNext()
			{
				//IL_002c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0036: Expected O, but got Unknown
				//IL_009c: Unknown result type (might be due to invalid IL or missing references)
				//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
				//IL_004f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0059: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					_0024self__00243142.summoned = 0;
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(20f)) ? 1 : 0);
					break;
				case 2:
					if (MenuScript.multiplayer == 1)
					{
						goto IL_004b;
					}
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				case 3:
					if (_0024self__00243142.summoned < 8)
					{
						_0024self__00243142.summoned++;
						Network.Instantiate(Resources.Load("e/fairy"), _0024self__00243142.t.position, Quaternion.identity, 0);
					}
					goto IL_004b;
				case 1:
					{
						result = 0;
						break;
					}
					IL_004b:
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(3, new WaitForSeconds(5f)) ? 1 : 0);
					break;
				}
				return (byte)result != 0;
			}
		}

		internal fQueen _0024self__00243143;

		public _0024Summon_00243141(fQueen self_)
		{
			_0024self__00243143 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00243143);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024UpdateZrotation_00243144 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal fQueen _0024self__00243145;

			public _0024(fQueen self_)
			{
				_0024self__00243145 = self_;
			}

			public override bool MoveNext()
			{
				//IL_0046: Unknown result type (might be due to invalid IL or missing references)
				//IL_0050: Expected O, but got Unknown
				//IL_0024: Unknown result type (might be due to invalid IL or missing references)
				//IL_002e: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(2f)) ? 1 : 0);
					break;
				case 2:
					_0024self__00243145.atking = true;
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(3, new WaitForSeconds(1.5f)) ? 1 : 0);
					break;
				case 3:
					_0024self__00243145.atking = false;
					goto default;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal fQueen _0024self__00243146;

		public _0024UpdateZrotation_00243144(fQueen self_)
		{
			_0024self__00243146 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00243146);
		}
	}

	private GameObject player;

	private bool atking;

	private Vector3 curVector;

	private float speed;

	public AudioClip scourge1;

	private int spdd;

	private bool charging;

	private float zRotation;

	private bool rotating;

	private Vector3 mouse_pos;

	private Vector3 object_pos;

	private float angle;

	private int summoned;

	public fQueen()
	{
		speed = 10f;
	}

	public override void Awake()
	{
		t = ((Component)this).transform;
		r = ((Component)this).rigidbody;
		((Component)this).collider.material.dynamicFriction = 0f;
		int[] array = new int[3] { 71, 71, 71 };
		SetStats(850, 4, 13, 350, 5f, array, 20, 350);
		((MonoBehaviour)this).StartCoroutine_Auto(UpdateZrotation());
		((MonoBehaviour)this).StartCoroutine_Auto(Summon());
	}

	public override IEnumerator Summon()
	{
		return new _0024Summon_00243141(this).GetEnumerator();
	}

	public override void SetPlayer(GameObject g)
	{
		player = g;
	}

	public override void FixedUpdate()
	{
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_0157: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0126: Unknown result type (might be due to invalid IL or missing references)
		//IL_0170: Unknown result type (might be due to invalid IL or missing references)
		//IL_0178: Unknown result type (might be due to invalid IL or missing references)
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)player) && atking && MenuScript.multiplayer == 1)
		{
			if (!(player.transform.position.x + 0.5f <= t.position.x))
			{
				t.Translate(Vector3.left * -5f * Time.deltaTime);
			}
			else if (!(player.transform.position.x - 0.5f >= t.position.x))
			{
				t.Translate(Vector3.left * 5f * Time.deltaTime);
			}
			if (!(player.transform.position.y + 1f <= t.position.y))
			{
				t.Translate(Vector3.up * 4f * Time.deltaTime);
			}
			else if (!(player.transform.position.y - 1f >= t.position.y))
			{
				t.Translate(Vector3.up * -4f * Time.deltaTime);
			}
		}
	}

	public override IEnumerator UpdateZrotation()
	{
		return new _0024UpdateZrotation_00243144(this).GetEnumerator();
	}

	[RPC]
	public override void Turn(int a)
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
		if (a == 0)
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

	[RPC]
	public override void ATK()
	{
	}

	[RPC]
	public override void IDLE()
	{
	}

	public override void K()
	{
	}

	public override void KN()
	{
	}
}
