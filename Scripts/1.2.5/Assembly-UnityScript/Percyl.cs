using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class Percyl : EnemyScript
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024ChargeRight_00242254 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024num_00242255;

			internal int _0024_0024774_00242256;

			internal Vector3 _0024_0024775_00242257;

			internal int _0024_0024776_00242258;

			internal Vector3 _0024_0024777_00242259;

			internal int _0024_0024778_00242260;

			internal Vector3 _0024_0024779_00242261;

			internal int _0024_0024780_00242262;

			internal Vector3 _0024_0024781_00242263;

			internal int _0024_0024782_00242264;

			internal Vector3 _0024_0024783_00242265;

			internal int _0024_0024784_00242266;

			internal Vector3 _0024_0024785_00242267;

			internal Percyl _0024self__00242268;

			public _0024(Percyl self_)
			{
				_0024self__00242268 = self_;
			}

			public override bool MoveNext()
			{
				//IL_0159: Unknown result type (might be due to invalid IL or missing references)
				//IL_015e: Unknown result type (might be due to invalid IL or missing references)
				//IL_015f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0161: Unknown result type (might be due to invalid IL or missing references)
				//IL_0166: Unknown result type (might be due to invalid IL or missing references)
				//IL_018d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0192: Unknown result type (might be due to invalid IL or missing references)
				//IL_0193: Unknown result type (might be due to invalid IL or missing references)
				//IL_019a: Unknown result type (might be due to invalid IL or missing references)
				//IL_01a4: Unknown result type (might be due to invalid IL or missing references)
				//IL_01ae: Expected O, but got Unknown
				//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
				//IL_01d2: Unknown result type (might be due to invalid IL or missing references)
				//IL_01d3: Unknown result type (might be due to invalid IL or missing references)
				//IL_01d5: Unknown result type (might be due to invalid IL or missing references)
				//IL_01da: Unknown result type (might be due to invalid IL or missing references)
				//IL_0201: Unknown result type (might be due to invalid IL or missing references)
				//IL_0206: Unknown result type (might be due to invalid IL or missing references)
				//IL_0207: Unknown result type (might be due to invalid IL or missing references)
				//IL_020e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0218: Unknown result type (might be due to invalid IL or missing references)
				//IL_0222: Expected O, but got Unknown
				//IL_0241: Unknown result type (might be due to invalid IL or missing references)
				//IL_0246: Unknown result type (might be due to invalid IL or missing references)
				//IL_0247: Unknown result type (might be due to invalid IL or missing references)
				//IL_0249: Unknown result type (might be due to invalid IL or missing references)
				//IL_024e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0275: Unknown result type (might be due to invalid IL or missing references)
				//IL_027a: Unknown result type (might be due to invalid IL or missing references)
				//IL_027b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0282: Unknown result type (might be due to invalid IL or missing references)
				//IL_028c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0296: Expected O, but got Unknown
				//IL_0345: Unknown result type (might be due to invalid IL or missing references)
				//IL_034a: Unknown result type (might be due to invalid IL or missing references)
				//IL_034b: Unknown result type (might be due to invalid IL or missing references)
				//IL_034d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0352: Unknown result type (might be due to invalid IL or missing references)
				//IL_0379: Unknown result type (might be due to invalid IL or missing references)
				//IL_037e: Unknown result type (might be due to invalid IL or missing references)
				//IL_037f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0386: Unknown result type (might be due to invalid IL or missing references)
				//IL_03a3: Unknown result type (might be due to invalid IL or missing references)
				//IL_03a8: Unknown result type (might be due to invalid IL or missing references)
				//IL_03a9: Unknown result type (might be due to invalid IL or missing references)
				//IL_03ab: Unknown result type (might be due to invalid IL or missing references)
				//IL_03b0: Unknown result type (might be due to invalid IL or missing references)
				//IL_03d7: Unknown result type (might be due to invalid IL or missing references)
				//IL_03dc: Unknown result type (might be due to invalid IL or missing references)
				//IL_03dd: Unknown result type (might be due to invalid IL or missing references)
				//IL_03e4: Unknown result type (might be due to invalid IL or missing references)
				//IL_03eb: Unknown result type (might be due to invalid IL or missing references)
				//IL_03f5: Expected O, but got Unknown
				//IL_040a: Unknown result type (might be due to invalid IL or missing references)
				//IL_0414: Expected O, but got Unknown
				//IL_031c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0326: Expected O, but got Unknown
				//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
				//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
				//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
				//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
				//IL_00de: Unknown result type (might be due to invalid IL or missing references)
				//IL_0102: Unknown result type (might be due to invalid IL or missing references)
				//IL_0107: Unknown result type (might be due to invalid IL or missing references)
				//IL_0108: Unknown result type (might be due to invalid IL or missing references)
				//IL_010e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0130: Unknown result type (might be due to invalid IL or missing references)
				//IL_013a: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					if (!_0024self__00242268.charging && MenuScript.multiplayer == 1)
					{
						_0024self__00242268.charging = true;
						_0024num_00242255 = Random.Range(0, 3);
						if (_0024num_00242255 == 0)
						{
							_0024self__00242268.spdd = 0;
							((Component)_0024self__00242268).networkView.RPC("Turn", (RPCMode)2, new object[1] { 1 });
							((Component)_0024self__00242268).networkView.RPC("RUN", (RPCMode)2, new object[0]);
							int num11 = (_0024_0024774_00242256 = 5);
							Vector3 val16 = (_0024_0024775_00242257 = _0024self__00242268.r.velocity);
							float num12 = (_0024_0024775_00242257.y = _0024_0024774_00242256);
							Vector3 val18 = (_0024self__00242268.r.velocity = _0024_0024775_00242257);
							((Component)_0024self__00242268).networkView.RPC("RUN2", (RPCMode)2, new object[0]);
							result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(1f)) ? 1 : 0);
						}
						else
						{
							_0024self__00242268.spdd = 0;
							((Component)_0024self__00242268).networkView.RPC("Turn", (RPCMode)2, new object[1] { 1 });
							((Component)_0024self__00242268).networkView.RPC("ATK", (RPCMode)2, new object[0]);
							result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(6, new WaitForSeconds(0.5f)) ? 1 : 0);
						}
						break;
					}
					goto IL_0425;
				case 2:
				{
					int num9 = (_0024_0024776_00242258 = 25);
					Vector3 val13 = (_0024_0024777_00242259 = _0024self__00242268.r.velocity);
					float num10 = (_0024_0024777_00242259.x = _0024_0024776_00242258);
					Vector3 val15 = (_0024self__00242268.r.velocity = _0024_0024777_00242259);
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(3, new WaitForSeconds(0.3f)) ? 1 : 0);
					break;
				}
				case 3:
				{
					int num7 = (_0024_0024778_00242260 = 25);
					Vector3 val10 = (_0024_0024779_00242261 = _0024self__00242268.r.velocity);
					float num8 = (_0024_0024779_00242261.x = _0024_0024778_00242260);
					Vector3 val12 = (_0024self__00242268.r.velocity = _0024_0024779_00242261);
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(4, new WaitForSeconds(0.3f)) ? 1 : 0);
					break;
				}
				case 4:
				{
					int num5 = (_0024_0024780_00242262 = 25);
					Vector3 val7 = (_0024_0024781_00242263 = _0024self__00242268.r.velocity);
					float num6 = (_0024_0024781_00242263.x = _0024_0024780_00242262);
					Vector3 val9 = (_0024self__00242268.r.velocity = _0024_0024781_00242263);
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(5, new WaitForSeconds(0.5f)) ? 1 : 0);
					break;
				}
				case 5:
					((Component)_0024self__00242268).networkView.RPC("IDLE", (RPCMode)2, new object[0]);
					_0024self__00242268.spdd = 0;
					goto IL_0406;
				case 6:
				{
					int num = (_0024_0024782_00242264 = 30);
					Vector3 val = (_0024_0024783_00242265 = _0024self__00242268.r.velocity);
					float num2 = (_0024_0024783_00242265.y = _0024_0024782_00242264);
					Vector3 val3 = (_0024self__00242268.r.velocity = _0024_0024783_00242265);
					int num3 = (_0024_0024784_00242266 = 20);
					Vector3 val4 = (_0024_0024785_00242267 = _0024self__00242268.r.velocity);
					float num4 = (_0024_0024785_00242267.x = _0024_0024784_00242266);
					Vector3 val6 = (_0024self__00242268.r.velocity = _0024_0024785_00242267);
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(7, new WaitForSeconds(2f)) ? 1 : 0);
					break;
				}
				case 7:
					_0024self__00242268.spdd = 0;
					goto IL_0406;
				case 8:
					_0024self__00242268.charging = false;
					goto IL_0425;
				case 1:
					{
						result = 0;
						break;
					}
					IL_0406:
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(8, new WaitForSeconds(1f)) ? 1 : 0);
					break;
					IL_0425:
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal Percyl _0024self__00242269;

		public _0024ChargeRight_00242254(Percyl self_)
		{
			_0024self__00242269 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00242269);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024ChargeLeft_00242270 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024num_00242271;

			internal int _0024_0024786_00242272;

			internal Vector3 _0024_0024787_00242273;

			internal int _0024_0024788_00242274;

			internal Vector3 _0024_0024789_00242275;

			internal int _0024_0024790_00242276;

			internal Vector3 _0024_0024791_00242277;

			internal int _0024_0024792_00242278;

			internal Vector3 _0024_0024793_00242279;

			internal int _0024_0024794_00242280;

			internal Vector3 _0024_0024795_00242281;

			internal int _0024_0024796_00242282;

			internal Vector3 _0024_0024797_00242283;

			internal Percyl _0024self__00242284;

			public _0024(Percyl self_)
			{
				_0024self__00242284 = self_;
			}

			public override bool MoveNext()
			{
				//IL_0159: Unknown result type (might be due to invalid IL or missing references)
				//IL_015e: Unknown result type (might be due to invalid IL or missing references)
				//IL_015f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0161: Unknown result type (might be due to invalid IL or missing references)
				//IL_0166: Unknown result type (might be due to invalid IL or missing references)
				//IL_018d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0192: Unknown result type (might be due to invalid IL or missing references)
				//IL_0193: Unknown result type (might be due to invalid IL or missing references)
				//IL_019a: Unknown result type (might be due to invalid IL or missing references)
				//IL_01a4: Unknown result type (might be due to invalid IL or missing references)
				//IL_01ae: Expected O, but got Unknown
				//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
				//IL_01d2: Unknown result type (might be due to invalid IL or missing references)
				//IL_01d3: Unknown result type (might be due to invalid IL or missing references)
				//IL_01d5: Unknown result type (might be due to invalid IL or missing references)
				//IL_01da: Unknown result type (might be due to invalid IL or missing references)
				//IL_0201: Unknown result type (might be due to invalid IL or missing references)
				//IL_0206: Unknown result type (might be due to invalid IL or missing references)
				//IL_0207: Unknown result type (might be due to invalid IL or missing references)
				//IL_020e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0218: Unknown result type (might be due to invalid IL or missing references)
				//IL_0222: Expected O, but got Unknown
				//IL_0241: Unknown result type (might be due to invalid IL or missing references)
				//IL_0246: Unknown result type (might be due to invalid IL or missing references)
				//IL_0247: Unknown result type (might be due to invalid IL or missing references)
				//IL_0249: Unknown result type (might be due to invalid IL or missing references)
				//IL_024e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0275: Unknown result type (might be due to invalid IL or missing references)
				//IL_027a: Unknown result type (might be due to invalid IL or missing references)
				//IL_027b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0282: Unknown result type (might be due to invalid IL or missing references)
				//IL_028c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0296: Expected O, but got Unknown
				//IL_0345: Unknown result type (might be due to invalid IL or missing references)
				//IL_034a: Unknown result type (might be due to invalid IL or missing references)
				//IL_034b: Unknown result type (might be due to invalid IL or missing references)
				//IL_034d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0352: Unknown result type (might be due to invalid IL or missing references)
				//IL_0379: Unknown result type (might be due to invalid IL or missing references)
				//IL_037e: Unknown result type (might be due to invalid IL or missing references)
				//IL_037f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0386: Unknown result type (might be due to invalid IL or missing references)
				//IL_03a3: Unknown result type (might be due to invalid IL or missing references)
				//IL_03a8: Unknown result type (might be due to invalid IL or missing references)
				//IL_03a9: Unknown result type (might be due to invalid IL or missing references)
				//IL_03ab: Unknown result type (might be due to invalid IL or missing references)
				//IL_03b0: Unknown result type (might be due to invalid IL or missing references)
				//IL_03d7: Unknown result type (might be due to invalid IL or missing references)
				//IL_03dc: Unknown result type (might be due to invalid IL or missing references)
				//IL_03dd: Unknown result type (might be due to invalid IL or missing references)
				//IL_03e4: Unknown result type (might be due to invalid IL or missing references)
				//IL_03eb: Unknown result type (might be due to invalid IL or missing references)
				//IL_03f5: Expected O, but got Unknown
				//IL_040a: Unknown result type (might be due to invalid IL or missing references)
				//IL_0414: Expected O, but got Unknown
				//IL_031c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0326: Expected O, but got Unknown
				//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
				//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
				//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
				//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
				//IL_00de: Unknown result type (might be due to invalid IL or missing references)
				//IL_0102: Unknown result type (might be due to invalid IL or missing references)
				//IL_0107: Unknown result type (might be due to invalid IL or missing references)
				//IL_0108: Unknown result type (might be due to invalid IL or missing references)
				//IL_010e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0130: Unknown result type (might be due to invalid IL or missing references)
				//IL_013a: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					if (!_0024self__00242284.charging && MenuScript.multiplayer == 1)
					{
						_0024self__00242284.charging = true;
						_0024num_00242271 = Random.Range(0, 3);
						if (_0024num_00242271 == 0)
						{
							_0024self__00242284.spdd = 0;
							((Component)_0024self__00242284).networkView.RPC("Turn", (RPCMode)2, new object[1] { 0 });
							((Component)_0024self__00242284).networkView.RPC("RUN", (RPCMode)2, new object[0]);
							int num11 = (_0024_0024786_00242272 = 5);
							Vector3 val16 = (_0024_0024787_00242273 = _0024self__00242284.r.velocity);
							float num12 = (_0024_0024787_00242273.y = _0024_0024786_00242272);
							Vector3 val18 = (_0024self__00242284.r.velocity = _0024_0024787_00242273);
							((Component)_0024self__00242284).networkView.RPC("RUN2", (RPCMode)2, new object[0]);
							result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(1f)) ? 1 : 0);
						}
						else
						{
							_0024self__00242284.spdd = 0;
							((Component)_0024self__00242284).networkView.RPC("Turn", (RPCMode)2, new object[1] { 0 });
							((Component)_0024self__00242284).networkView.RPC("ATK", (RPCMode)2, new object[0]);
							result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(6, new WaitForSeconds(0.5f)) ? 1 : 0);
						}
						break;
					}
					goto IL_0425;
				case 2:
				{
					int num9 = (_0024_0024788_00242274 = -25);
					Vector3 val13 = (_0024_0024789_00242275 = _0024self__00242284.r.velocity);
					float num10 = (_0024_0024789_00242275.x = _0024_0024788_00242274);
					Vector3 val15 = (_0024self__00242284.r.velocity = _0024_0024789_00242275);
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(3, new WaitForSeconds(0.3f)) ? 1 : 0);
					break;
				}
				case 3:
				{
					int num7 = (_0024_0024790_00242276 = -25);
					Vector3 val10 = (_0024_0024791_00242277 = _0024self__00242284.r.velocity);
					float num8 = (_0024_0024791_00242277.x = _0024_0024790_00242276);
					Vector3 val12 = (_0024self__00242284.r.velocity = _0024_0024791_00242277);
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(4, new WaitForSeconds(0.3f)) ? 1 : 0);
					break;
				}
				case 4:
				{
					int num5 = (_0024_0024792_00242278 = -25);
					Vector3 val7 = (_0024_0024793_00242279 = _0024self__00242284.r.velocity);
					float num6 = (_0024_0024793_00242279.x = _0024_0024792_00242278);
					Vector3 val9 = (_0024self__00242284.r.velocity = _0024_0024793_00242279);
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(5, new WaitForSeconds(0.5f)) ? 1 : 0);
					break;
				}
				case 5:
					((Component)_0024self__00242284).networkView.RPC("IDLE", (RPCMode)2, new object[0]);
					_0024self__00242284.spdd = 0;
					goto IL_0406;
				case 6:
				{
					int num = (_0024_0024794_00242280 = 30);
					Vector3 val = (_0024_0024795_00242281 = _0024self__00242284.r.velocity);
					float num2 = (_0024_0024795_00242281.y = _0024_0024794_00242280);
					Vector3 val3 = (_0024self__00242284.r.velocity = _0024_0024795_00242281);
					int num3 = (_0024_0024796_00242282 = -20);
					Vector3 val4 = (_0024_0024797_00242283 = _0024self__00242284.r.velocity);
					float num4 = (_0024_0024797_00242283.x = _0024_0024796_00242282);
					Vector3 val6 = (_0024self__00242284.r.velocity = _0024_0024797_00242283);
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(7, new WaitForSeconds(2f)) ? 1 : 0);
					break;
				}
				case 7:
					_0024self__00242284.spdd = 0;
					goto IL_0406;
				case 8:
					_0024self__00242284.charging = false;
					goto IL_0425;
				case 1:
					{
						result = 0;
						break;
					}
					IL_0406:
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(8, new WaitForSeconds(1f)) ? 1 : 0);
					break;
					IL_0425:
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal Percyl _0024self__00242285;

		public _0024ChargeLeft_00242270(Percyl self_)
		{
			_0024self__00242285 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00242285);
		}
	}

	private GameObject player;

	private bool atking;

	private Vector3 curVector;

	private float speed;

	public AudioClip scourge1;

	private int spdd;

	private bool charging;

	private int mask2;

	private Ray r1U;

	private Ray r2U;

	public Percyl()
	{
		speed = 10f;
		mask2 = 2048;
	}

	public override void Awake()
	{
		t = ((Component)this).transform;
		r = ((Component)this).rigidbody;
		((Component)this).collider.material.dynamicFriction = 0f;
		int[] array = new int[3] { 19, 20, 17 };
		SetStats(600, 4, 0, 4, 200f, array, Random.Range(6, 20), 200);
		@base.animation["r1"].layer = 2;
		@base.animation["r2"].layer = 1;
		@base.animation["i"].layer = 1;
		@base.animation["a"].layer = 2;
	}

	public override void SetPlayer(GameObject g)
	{
		player = g;
	}

	public override void Update()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_0168: Unknown result type (might be due to invalid IL or missing references)
		//IL_0176: Unknown result type (might be due to invalid IL or missing references)
		//IL_017b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c0: Unknown result type (might be due to invalid IL or missing references)
		((Ray)(ref r1U)).origin = ((Component)this).transform.position;
		((Ray)(ref r1U)).direction = Vector3.left;
		((Ray)(ref r2U)).origin = ((Component)this).transform.position;
		((Ray)(ref r2U)).direction = Vector3.right;
		if (Physics.Raycast(r1U, 1.5f, mask2) && e.transform.rotation.y == 0f && MenuScript.multiplayer > 0 && MenuScript.multiplayer == 1)
		{
			((Component)this).networkView.RPC("Turn", (RPCMode)2, new object[1] { 1 });
			spdd *= -1;
		}
		if (Physics.Raycast(r2U, 1.5f, mask2) && e.transform.rotation.y != 0f && MenuScript.multiplayer > 0 && MenuScript.multiplayer == 1)
		{
			((Component)this).networkView.RPC("Turn", (RPCMode)2, new object[1] { 0 });
			spdd *= -1;
		}
		if (Object.op_Implicit((Object)(object)player) && !(Mathf.Abs(player.transform.position.x - t.position.x) >= 25f) && !knocking)
		{
			if (!(player.transform.position.x <= t.position.x))
			{
				((MonoBehaviour)this).StartCoroutine_Auto(ChargeRight());
			}
			else
			{
				((MonoBehaviour)this).StartCoroutine_Auto(ChargeLeft());
			}
		}
		if (charging && knocking)
		{
		}
	}

	public override IEnumerator ChargeRight()
	{
		return new _0024ChargeRight_00242254(this).GetEnumerator();
	}

	public override IEnumerator ChargeLeft()
	{
		return new _0024ChargeLeft_00242270(this).GetEnumerator();
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
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		if (a == 0)
		{
			int num = 180;
			Quaternion rotation = e.transform.rotation;
			float num2 = (rotation.y = num);
			Quaternion val2 = (e.transform.rotation = rotation);
		}
		else
		{
			int num3 = 0;
			Quaternion rotation2 = e.transform.rotation;
			float num4 = (rotation2.y = num3);
			Quaternion val4 = (e.transform.rotation = rotation2);
		}
	}

	[RPC]
	public override void ATK()
	{
		@base.animation.Play("a");
	}

	[RPC]
	public override void RUN()
	{
		@base.animation.Play("r1");
	}

	[RPC]
	public override void RUN2()
	{
		@base.animation.Play("r2");
	}

	[RPC]
	public override void IDLE()
	{
		@base.animation.Play("i");
	}
}
