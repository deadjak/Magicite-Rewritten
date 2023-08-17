using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class EnemyScript : MonoBehaviour
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024SetStatsN_00241520 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024hp_00241521;

			internal int _0024atk_00241522;

			internal EnemyScript _0024self__00241523;

			public _0024(int hp, int atk, EnemyScript self_)
			{
				_0024hp_00241521 = hp;
				_0024atk_00241522 = atk;
				_0024self__00241523 = self_;
			}

			public override bool MoveNext()
			{
				//IL_001e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0028: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.5f)) ? 1 : 0);
					break;
				case 2:
					_0024self__00241523.MAXHP = _0024hp_00241521;
					_0024self__00241523.HP = _0024hp_00241521;
					_0024self__00241523.ATK = _0024atk_00241522;
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal int _0024hp_00241524;

		internal int _0024atk_00241525;

		internal EnemyScript _0024self__00241526;

		public _0024SetStatsN_00241520(int hp, int atk, EnemyScript self_)
		{
			_0024hp_00241524 = hp;
			_0024atk_00241525 = atk;
			_0024self__00241526 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024hp_00241524, _0024atk_00241525, _0024self__00241526);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Knock22_00241527 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal bool _0024wasK_00241528;

			internal int _0024_0024550_00241529;

			internal Vector3 _0024_0024551_00241530;

			internal int _0024_0024552_00241531;

			internal Vector3 _0024_0024553_00241532;

			internal int _0024_0024554_00241533;

			internal Vector3 _0024_0024555_00241534;

			internal Vector3 _0024p_00241535;

			internal EnemyScript _0024self__00241536;

			public _0024(Vector3 p, EnemyScript self_)
			{
				//IL_0007: Unknown result type (might be due to invalid IL or missing references)
				//IL_0008: Unknown result type (might be due to invalid IL or missing references)
				_0024p_00241535 = p;
				_0024self__00241536 = self_;
			}

			public override bool MoveNext()
			{
				//IL_0067: Unknown result type (might be due to invalid IL or missing references)
				//IL_006c: Unknown result type (might be due to invalid IL or missing references)
				//IL_006d: Unknown result type (might be due to invalid IL or missing references)
				//IL_006e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0073: Unknown result type (might be due to invalid IL or missing references)
				//IL_0097: Unknown result type (might be due to invalid IL or missing references)
				//IL_009c: Unknown result type (might be due to invalid IL or missing references)
				//IL_009d: Unknown result type (might be due to invalid IL or missing references)
				//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
				//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
				//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
				//IL_014b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0150: Unknown result type (might be due to invalid IL or missing references)
				//IL_0151: Unknown result type (might be due to invalid IL or missing references)
				//IL_0153: Unknown result type (might be due to invalid IL or missing references)
				//IL_0158: Unknown result type (might be due to invalid IL or missing references)
				//IL_017f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0184: Unknown result type (might be due to invalid IL or missing references)
				//IL_0185: Unknown result type (might be due to invalid IL or missing references)
				//IL_018c: Unknown result type (might be due to invalid IL or missing references)
				//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
				//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
				//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
				//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
				//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
				//IL_011c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0121: Unknown result type (might be due to invalid IL or missing references)
				//IL_0122: Unknown result type (might be due to invalid IL or missing references)
				//IL_0129: Unknown result type (might be due to invalid IL or missing references)
				//IL_0196: Unknown result type (might be due to invalid IL or missing references)
				//IL_01a0: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
				{
					_0024wasK_00241528 = default(bool);
					if (_0024self__00241536.r.isKinematic)
					{
						_0024wasK_00241528 = true;
						((Component)_0024self__00241536).rigidbody.isKinematic = false;
					}
					int num = (_0024_0024550_00241529 = 2);
					Vector3 val = (_0024_0024551_00241530 = ((Component)_0024self__00241536).rigidbody.velocity);
					float num2 = (_0024_0024551_00241530.y = _0024_0024550_00241529);
					Vector3 val3 = (((Component)_0024self__00241536).rigidbody.velocity = _0024_0024551_00241530);
					if (_0024p_00241535.x <= _0024self__00241536.t.position.x)
					{
						int num3 = (_0024_0024554_00241533 = 10);
						Vector3 val4 = (_0024_0024555_00241534 = ((Component)_0024self__00241536).rigidbody.velocity);
						float num4 = (_0024_0024555_00241534.x = _0024_0024554_00241533);
						Vector3 val6 = (((Component)_0024self__00241536).rigidbody.velocity = _0024_0024555_00241534);
					}
					else
					{
						int num5 = (_0024_0024552_00241531 = -10);
						Vector3 val7 = (_0024_0024553_00241532 = ((Component)_0024self__00241536).rigidbody.velocity);
						float num6 = (_0024_0024553_00241532.x = _0024_0024552_00241531);
						Vector3 val9 = (((Component)_0024self__00241536).rigidbody.velocity = _0024_0024553_00241532);
					}
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.2f)) ? 1 : 0);
					break;
				}
				case 2:
					if (_0024wasK_00241528)
					{
						((Component)_0024self__00241536).rigidbody.isKinematic = true;
					}
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal Vector3 _0024p_00241537;

		internal EnemyScript _0024self__00241538;

		public _0024Knock22_00241527(Vector3 p, EnemyScript self_)
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			_0024p_00241537 = p;
			_0024self__00241538 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024p_00241537, _0024self__00241538);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Knock_00241539 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024_0024556_00241540;

			internal Vector3 _0024_0024557_00241541;

			internal int _0024_0024558_00241542;

			internal Vector3 _0024_0024559_00241543;

			internal int _0024_0024560_00241544;

			internal Vector3 _0024_0024561_00241545;

			internal Vector3 _0024p_00241546;

			internal EnemyScript _0024self__00241547;

			public _0024(Vector3 p, EnemyScript self_)
			{
				//IL_0007: Unknown result type (might be due to invalid IL or missing references)
				//IL_0008: Unknown result type (might be due to invalid IL or missing references)
				_0024p_00241546 = p;
				_0024self__00241547 = self_;
			}

			public override bool MoveNext()
			{
				//IL_0163: Unknown result type (might be due to invalid IL or missing references)
				//IL_0168: Unknown result type (might be due to invalid IL or missing references)
				//IL_0169: Unknown result type (might be due to invalid IL or missing references)
				//IL_016b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0170: Unknown result type (might be due to invalid IL or missing references)
				//IL_0197: Unknown result type (might be due to invalid IL or missing references)
				//IL_019c: Unknown result type (might be due to invalid IL or missing references)
				//IL_019d: Unknown result type (might be due to invalid IL or missing references)
				//IL_01a4: Unknown result type (might be due to invalid IL or missing references)
				//IL_0067: Unknown result type (might be due to invalid IL or missing references)
				//IL_006c: Unknown result type (might be due to invalid IL or missing references)
				//IL_003c: Unknown result type (might be due to invalid IL or missing references)
				//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
				//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
				//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
				//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
				//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
				//IL_0124: Unknown result type (might be due to invalid IL or missing references)
				//IL_0129: Unknown result type (might be due to invalid IL or missing references)
				//IL_012a: Unknown result type (might be due to invalid IL or missing references)
				//IL_0131: Unknown result type (might be due to invalid IL or missing references)
				//IL_0091: Unknown result type (might be due to invalid IL or missing references)
				//IL_0096: Unknown result type (might be due to invalid IL or missing references)
				//IL_0097: Unknown result type (might be due to invalid IL or missing references)
				//IL_0098: Unknown result type (might be due to invalid IL or missing references)
				//IL_009d: Unknown result type (might be due to invalid IL or missing references)
				//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
				//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
				//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
				//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
				//IL_013b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0145: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					if (MenuScript.multiplayer > 0)
					{
						((Component)_0024self__00241547).networkView.RPC("KnockN", (RPCMode)2, new object[1] { _0024p_00241546 });
						goto IL_01a7;
					}
					if (_0024p_00241546.x <= _0024self__00241547.t.position.x)
					{
						int num3 = (_0024_0024558_00241542 = 10);
						Vector3 val4 = (_0024_0024559_00241543 = ((Component)_0024self__00241547).rigidbody.velocity);
						float num4 = (_0024_0024559_00241543.x = _0024_0024558_00241542);
						Vector3 val6 = (((Component)_0024self__00241547).rigidbody.velocity = _0024_0024559_00241543);
					}
					else
					{
						int num5 = (_0024_0024556_00241540 = -10);
						Vector3 val7 = (_0024_0024557_00241541 = ((Component)_0024self__00241547).rigidbody.velocity);
						float num6 = (_0024_0024557_00241541.x = _0024_0024556_00241540);
						Vector3 val9 = (((Component)_0024self__00241547).rigidbody.velocity = _0024_0024557_00241541);
					}
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.2f)) ? 1 : 0);
					break;
				case 2:
				{
					int num = (_0024_0024560_00241544 = 0);
					Vector3 val = (_0024_0024561_00241545 = ((Component)_0024self__00241547).rigidbody.velocity);
					float num2 = (_0024_0024561_00241545.x = _0024_0024560_00241544);
					Vector3 val3 = (((Component)_0024self__00241547).rigidbody.velocity = _0024_0024561_00241545);
					goto IL_01a7;
				}
				case 1:
					{
						result = 0;
						break;
					}
					IL_01a7:
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal Vector3 _0024p_00241548;

		internal EnemyScript _0024self__00241549;

		public _0024Knock_00241539(Vector3 p, EnemyScript self_)
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			_0024p_00241548 = p;
			_0024self__00241549 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024p_00241548, _0024self__00241549);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024KnockN_00241550 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024_0024562_00241551;

			internal Vector3 _0024_0024563_00241552;

			internal int _0024_0024564_00241553;

			internal Vector3 _0024_0024565_00241554;

			internal int _0024_0024566_00241555;

			internal Vector3 _0024_0024567_00241556;

			internal int _0024_0024568_00241557;

			internal Vector3 _0024_0024569_00241558;

			internal Vector3 _0024p_00241559;

			internal EnemyScript _0024self__00241560;

			public _0024(Vector3 p, EnemyScript self_)
			{
				//IL_0007: Unknown result type (might be due to invalid IL or missing references)
				//IL_0008: Unknown result type (might be due to invalid IL or missing references)
				_0024p_00241559 = p;
				_0024self__00241560 = self_;
			}

			public override bool MoveNext()
			{
				//IL_002e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0033: Unknown result type (might be due to invalid IL or missing references)
				//IL_0034: Unknown result type (might be due to invalid IL or missing references)
				//IL_0035: Unknown result type (might be due to invalid IL or missing references)
				//IL_003a: Unknown result type (might be due to invalid IL or missing references)
				//IL_005e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0063: Unknown result type (might be due to invalid IL or missing references)
				//IL_0064: Unknown result type (might be due to invalid IL or missing references)
				//IL_006a: Unknown result type (might be due to invalid IL or missing references)
				//IL_0082: Unknown result type (might be due to invalid IL or missing references)
				//IL_0087: Unknown result type (might be due to invalid IL or missing references)
				//IL_0185: Unknown result type (might be due to invalid IL or missing references)
				//IL_018a: Unknown result type (might be due to invalid IL or missing references)
				//IL_018b: Unknown result type (might be due to invalid IL or missing references)
				//IL_018d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0192: Unknown result type (might be due to invalid IL or missing references)
				//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
				//IL_01be: Unknown result type (might be due to invalid IL or missing references)
				//IL_01bf: Unknown result type (might be due to invalid IL or missing references)
				//IL_01c6: Unknown result type (might be due to invalid IL or missing references)
				//IL_0112: Unknown result type (might be due to invalid IL or missing references)
				//IL_0117: Unknown result type (might be due to invalid IL or missing references)
				//IL_0118: Unknown result type (might be due to invalid IL or missing references)
				//IL_011a: Unknown result type (might be due to invalid IL or missing references)
				//IL_011f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0146: Unknown result type (might be due to invalid IL or missing references)
				//IL_014b: Unknown result type (might be due to invalid IL or missing references)
				//IL_014c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0153: Unknown result type (might be due to invalid IL or missing references)
				//IL_00af: Unknown result type (might be due to invalid IL or missing references)
				//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
				//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
				//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
				//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
				//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
				//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
				//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
				//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
				//IL_015d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0167: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
				{
					int num3 = (_0024_0024562_00241551 = 2);
					Vector3 val4 = (_0024_0024563_00241552 = ((Component)_0024self__00241560).rigidbody.velocity);
					float num4 = (_0024_0024563_00241552.y = _0024_0024562_00241551);
					Vector3 val6 = (((Component)_0024self__00241560).rigidbody.velocity = _0024_0024563_00241552);
					if (_0024p_00241559.x <= _0024self__00241560.t.position.x)
					{
						int num5 = (_0024_0024566_00241555 = 10);
						Vector3 val7 = (_0024_0024567_00241556 = ((Component)_0024self__00241560).rigidbody.velocity);
						float num6 = (_0024_0024567_00241556.x = _0024_0024566_00241555);
						Vector3 val9 = (((Component)_0024self__00241560).rigidbody.velocity = _0024_0024567_00241556);
					}
					else
					{
						int num7 = (_0024_0024564_00241553 = -10);
						Vector3 val10 = (_0024_0024565_00241554 = ((Component)_0024self__00241560).rigidbody.velocity);
						float num8 = (_0024_0024565_00241554.x = _0024_0024564_00241553);
						Vector3 val12 = (((Component)_0024self__00241560).rigidbody.velocity = _0024_0024565_00241554);
					}
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.2f)) ? 1 : 0);
					break;
				}
				case 2:
				{
					int num = (_0024_0024568_00241557 = 0);
					Vector3 val = (_0024_0024569_00241558 = ((Component)_0024self__00241560).rigidbody.velocity);
					float num2 = (_0024_0024569_00241558.x = _0024_0024568_00241557);
					Vector3 val3 = (((Component)_0024self__00241560).rigidbody.velocity = _0024_0024569_00241558);
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				}
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal Vector3 _0024p_00241561;

		internal EnemyScript _0024self__00241562;

		public _0024KnockN_00241550(Vector3 p, EnemyScript self_)
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			_0024p_00241561 = p;
			_0024self__00241562 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024p_00241561, _0024self__00241562);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024TD_00241563 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024finalDMG_00241564;

			internal GameObject _0024n3_00241565;

			internal GameObject _0024n2_00241566;

			internal int _0024_0024570_00241567;

			internal Vector3 _0024_0024571_00241568;

			internal int _0024_0024572_00241569;

			internal Vector3 _0024_0024573_00241570;

			internal int _0024dmg_00241571;

			internal EnemyScript _0024self__00241572;

			public _0024(int dmg, EnemyScript self_)
			{
				_0024dmg_00241571 = dmg;
				_0024self__00241572 = self_;
			}

			public override bool MoveNext()
			{
				//IL_02c5: Unknown result type (might be due to invalid IL or missing references)
				//IL_02ca: Unknown result type (might be due to invalid IL or missing references)
				//IL_02cb: Unknown result type (might be due to invalid IL or missing references)
				//IL_02cd: Unknown result type (might be due to invalid IL or missing references)
				//IL_02d2: Unknown result type (might be due to invalid IL or missing references)
				//IL_02fe: Unknown result type (might be due to invalid IL or missing references)
				//IL_0303: Unknown result type (might be due to invalid IL or missing references)
				//IL_0304: Unknown result type (might be due to invalid IL or missing references)
				//IL_030b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0081: Unknown result type (might be due to invalid IL or missing references)
				//IL_0091: Unknown result type (might be due to invalid IL or missing references)
				//IL_0096: Unknown result type (might be due to invalid IL or missing references)
				//IL_00a1: Expected O, but got Unknown
				//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
				//IL_00ab: Expected O, but got Unknown
				//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
				//IL_01b1: Unknown result type (might be due to invalid IL or missing references)
				//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
				//IL_01c0: Expected O, but got Unknown
				//IL_01c0: Unknown result type (might be due to invalid IL or missing references)
				//IL_01ca: Expected O, but got Unknown
				//IL_0211: Unknown result type (might be due to invalid IL or missing references)
				//IL_0216: Unknown result type (might be due to invalid IL or missing references)
				//IL_0217: Unknown result type (might be due to invalid IL or missing references)
				//IL_0218: Unknown result type (might be due to invalid IL or missing references)
				//IL_021d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0241: Unknown result type (might be due to invalid IL or missing references)
				//IL_0246: Unknown result type (might be due to invalid IL or missing references)
				//IL_0247: Unknown result type (might be due to invalid IL or missing references)
				//IL_024d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0277: Unknown result type (might be due to invalid IL or missing references)
				//IL_0281: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					if (!_0024self__00241572.takingDamage)
					{
						((Component)_0024self__00241572).audio.PlayOneShot(_0024self__00241572.aHit);
						_0024finalDMG_00241564 = _0024dmg_00241571;
						if (_0024finalDMG_00241564 < 1)
						{
							_0024finalDMG_00241564 = 1;
						}
						if (MenuScript.multiplayer > 0)
						{
							_0024n3_00241565 = (GameObject)Network.Instantiate((Object)(GameObject)Resources.Load("TD", typeof(GameObject)), _0024self__00241572.t.position, Quaternion.identity, 0);
							_0024n3_00241565.networkView.RPC("SDN", (RPCMode)2, new object[1] { _0024finalDMG_00241564 });
							((Component)_0024self__00241572).networkView.RPC("TDN", (RPCMode)6, new object[1] { _0024finalDMG_00241564 });
							((Component)_0024self__00241572).networkView.RPC("TDN2", (RPCMode)2, new object[1] { _0024finalDMG_00241564 });
						}
						else
						{
							_0024self__00241572.takingDamage = true;
							if (_0024finalDMG_00241564 < 1)
							{
								_0024finalDMG_00241564 = 1;
							}
							_0024self__00241572.HP -= _0024finalDMG_00241564;
							_0024self__00241572.e.animation.Play();
							if (_0024dmg_00241571 > 0)
							{
								_0024n2_00241566 = (GameObject)Object.Instantiate((Object)(GameObject)Resources.Load("TD", typeof(GameObject)), _0024self__00241572.t.position, Quaternion.identity);
								_0024n2_00241566.SendMessage("SD", (object)_0024finalDMG_00241564);
							}
							if (!_0024self__00241572.r.isKinematic)
							{
								int num3 = (_0024_0024570_00241567 = 0);
								Vector3 val4 = (_0024_0024571_00241568 = ((Component)_0024self__00241572).rigidbody.velocity);
								float num4 = (_0024_0024571_00241568.x = _0024_0024570_00241567);
								Vector3 val6 = (((Component)_0024self__00241572).rigidbody.velocity = _0024_0024571_00241568);
							}
							if (_0024self__00241572.HP >= 1)
							{
								result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.2f)) ? 1 : 0);
								break;
							}
							_0024self__00241572.Die();
						}
					}
					goto IL_030e;
				case 2:
				{
					_0024self__00241572.e.animation.Stop();
					_0024self__00241572.takingDamage = false;
					int num = (_0024_0024572_00241569 = 0);
					Vector3 val = (_0024_0024573_00241570 = _0024self__00241572.e.transform.localPosition);
					float num2 = (_0024_0024573_00241570.z = _0024_0024572_00241569);
					Vector3 val3 = (_0024self__00241572.e.transform.localPosition = _0024_0024573_00241570);
					goto IL_030e;
				}
				case 1:
					{
						result = 0;
						break;
					}
					IL_030e:
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal int _0024dmg_00241573;

		internal EnemyScript _0024self__00241574;

		public _0024TD_00241563(int dmg, EnemyScript self_)
		{
			_0024dmg_00241573 = dmg;
			_0024self__00241574 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024dmg_00241573, _0024self__00241574);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024TDN2_00241575 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024_0024574_00241576;

			internal Vector3 _0024_0024575_00241577;

			internal int _0024_0024576_00241578;

			internal Vector3 _0024_0024577_00241579;

			internal EnemyScript _0024self__00241580;

			public _0024(EnemyScript self_)
			{
				_0024self__00241580 = self_;
			}

			public override bool MoveNext()
			{
				//IL_0102: Unknown result type (might be due to invalid IL or missing references)
				//IL_0107: Unknown result type (might be due to invalid IL or missing references)
				//IL_0108: Unknown result type (might be due to invalid IL or missing references)
				//IL_010a: Unknown result type (might be due to invalid IL or missing references)
				//IL_010f: Unknown result type (might be due to invalid IL or missing references)
				//IL_013b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0140: Unknown result type (might be due to invalid IL or missing references)
				//IL_0141: Unknown result type (might be due to invalid IL or missing references)
				//IL_0148: Unknown result type (might be due to invalid IL or missing references)
				//IL_0059: Unknown result type (might be due to invalid IL or missing references)
				//IL_005e: Unknown result type (might be due to invalid IL or missing references)
				//IL_005f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0060: Unknown result type (might be due to invalid IL or missing references)
				//IL_0065: Unknown result type (might be due to invalid IL or missing references)
				//IL_0089: Unknown result type (might be due to invalid IL or missing references)
				//IL_008e: Unknown result type (might be due to invalid IL or missing references)
				//IL_008f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0095: Unknown result type (might be due to invalid IL or missing references)
				//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
				//IL_00be: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					_0024self__00241580.e.animation.Play();
					if (!((Component)_0024self__00241580).rigidbody.isKinematic)
					{
						int num3 = (_0024_0024574_00241576 = 0);
						Vector3 val4 = (_0024_0024575_00241577 = ((Component)_0024self__00241580).rigidbody.velocity);
						float num4 = (_0024_0024575_00241577.x = _0024_0024574_00241576);
						Vector3 val6 = (((Component)_0024self__00241580).rigidbody.velocity = _0024_0024575_00241577);
					}
					if (_0024self__00241580.HP < 1)
					{
						goto IL_014b;
					}
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.2f)) ? 1 : 0);
					break;
				case 2:
				{
					_0024self__00241580.e.animation.Stop();
					_0024self__00241580.takingDamage = false;
					int num = (_0024_0024576_00241578 = 0);
					Vector3 val = (_0024_0024577_00241579 = _0024self__00241580.e.transform.localPosition);
					float num2 = (_0024_0024577_00241579.z = _0024_0024576_00241578);
					Vector3 val3 = (_0024self__00241580.e.transform.localPosition = _0024_0024577_00241579);
					goto IL_014b;
				}
				case 1:
					{
						result = 0;
						break;
					}
					IL_014b:
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal EnemyScript _0024self__00241581;

		public _0024TDN2_00241575(EnemyScript self_)
		{
			_0024self__00241581 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00241581);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024KN_00241582 : GenericGenerator<YieldInstruction>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<YieldInstruction>, IEnumerator
		{
			internal bool _0024wasK_00241583;

			internal int _0024_0024578_00241584;

			internal Vector3 _0024_0024579_00241585;

			internal int _0024_0024580_00241586;

			internal Vector3 _0024_0024581_00241587;

			internal int _0024_0024582_00241588;

			internal Vector3 _0024_0024583_00241589;

			internal int _0024_0024584_00241590;

			internal Vector3 _0024_0024585_00241591;

			internal bool _0024l_00241592;

			internal EnemyScript _0024self__00241593;

			public _0024(bool l, EnemyScript self_)
			{
				_0024l_00241592 = l;
				_0024self__00241593 = self_;
			}

			public override bool MoveNext()
			{
				//IL_020d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0217: Expected O, but got Unknown
				//IL_0153: Unknown result type (might be due to invalid IL or missing references)
				//IL_0158: Unknown result type (might be due to invalid IL or missing references)
				//IL_0159: Unknown result type (might be due to invalid IL or missing references)
				//IL_015b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0160: Unknown result type (might be due to invalid IL or missing references)
				//IL_0187: Unknown result type (might be due to invalid IL or missing references)
				//IL_018c: Unknown result type (might be due to invalid IL or missing references)
				//IL_018d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0194: Unknown result type (might be due to invalid IL or missing references)
				//IL_01b1: Unknown result type (might be due to invalid IL or missing references)
				//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
				//IL_01b7: Unknown result type (might be due to invalid IL or missing references)
				//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
				//IL_01be: Unknown result type (might be due to invalid IL or missing references)
				//IL_01e5: Unknown result type (might be due to invalid IL or missing references)
				//IL_01ea: Unknown result type (might be due to invalid IL or missing references)
				//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
				//IL_01f2: Unknown result type (might be due to invalid IL or missing references)
				//IL_01f7: Unknown result type (might be due to invalid IL or missing references)
				//IL_0201: Expected O, but got Unknown
				//IL_0087: Unknown result type (might be due to invalid IL or missing references)
				//IL_008c: Unknown result type (might be due to invalid IL or missing references)
				//IL_008d: Unknown result type (might be due to invalid IL or missing references)
				//IL_008e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0093: Unknown result type (might be due to invalid IL or missing references)
				//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
				//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
				//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
				//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
				//IL_00df: Unknown result type (might be due to invalid IL or missing references)
				//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
				//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
				//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
				//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
				//IL_0113: Unknown result type (might be due to invalid IL or missing references)
				//IL_0118: Unknown result type (might be due to invalid IL or missing references)
				//IL_0119: Unknown result type (might be due to invalid IL or missing references)
				//IL_0120: Unknown result type (might be due to invalid IL or missing references)
				//IL_0125: Unknown result type (might be due to invalid IL or missing references)
				//IL_012f: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					_0024self__00241593.knocking = true;
					_0024wasK_00241583 = default(bool);
					if (_0024self__00241593.r.isKinematic)
					{
						_0024wasK_00241583 = true;
						_0024self__00241593.r.isKinematic = false;
					}
					if (_0024l_00241592)
					{
						int num = (_0024_0024578_00241584 = -15);
						Vector3 val = (_0024_0024579_00241585 = _0024self__00241593.r.velocity);
						float num2 = (_0024_0024579_00241585.x = _0024_0024578_00241584);
						Vector3 val3 = (_0024self__00241593.r.velocity = _0024_0024579_00241585);
						int num3 = (_0024_0024580_00241586 = 10);
						Vector3 val4 = (_0024_0024581_00241587 = _0024self__00241593.r.velocity);
						float num4 = (_0024_0024581_00241587.y = _0024_0024580_00241586);
						Vector3 val6 = (_0024self__00241593.r.velocity = _0024_0024581_00241587);
						result = (((GenericGeneratorEnumerator<YieldInstruction>)this).Yield(2, (YieldInstruction)new WaitForEndOfFrame()) ? 1 : 0);
					}
					else
					{
						int num5 = (_0024_0024582_00241588 = 15);
						Vector3 val7 = (_0024_0024583_00241589 = _0024self__00241593.r.velocity);
						float num6 = (_0024_0024583_00241589.x = _0024_0024582_00241588);
						Vector3 val9 = (_0024self__00241593.r.velocity = _0024_0024583_00241589);
						int num7 = (_0024_0024584_00241590 = 10);
						Vector3 val10 = (_0024_0024585_00241591 = _0024self__00241593.r.velocity);
						float num8 = (_0024_0024585_00241591.y = _0024_0024584_00241590);
						Vector3 val12 = (_0024self__00241593.r.velocity = _0024_0024585_00241591);
						result = (((GenericGeneratorEnumerator<YieldInstruction>)this).Yield(3, (YieldInstruction)new WaitForEndOfFrame()) ? 1 : 0);
					}
					break;
				case 2:
				case 3:
					result = (((GenericGeneratorEnumerator<YieldInstruction>)this).Yield(4, (YieldInstruction)new WaitForSeconds(0.2f)) ? 1 : 0);
					break;
				case 4:
					_0024self__00241593.knocking = false;
					if (_0024wasK_00241583)
					{
						_0024self__00241593.r.isKinematic = true;
					}
					((GenericGeneratorEnumerator<YieldInstruction>)this).YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal bool _0024l_00241594;

		internal EnemyScript _0024self__00241595;

		public _0024KN_00241582(bool l, EnemyScript self_)
		{
			_0024l_00241594 = l;
			_0024self__00241595 = self_;
		}

		public override IEnumerator<YieldInstruction> GetEnumerator()
		{
			return (IEnumerator<YieldInstruction>)(object)new _0024(_0024l_00241594, _0024self__00241595);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024K_00241596 : GenericGenerator<YieldInstruction>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<YieldInstruction>, IEnumerator
		{
			internal bool _0024wasK_00241597;

			internal int _0024_0024586_00241598;

			internal Vector3 _0024_0024587_00241599;

			internal int _0024_0024588_00241600;

			internal Vector3 _0024_0024589_00241601;

			internal int _0024_0024590_00241602;

			internal Vector3 _0024_0024591_00241603;

			internal int _0024_0024592_00241604;

			internal Vector3 _0024_0024593_00241605;

			internal bool _0024l_00241606;

			internal EnemyScript _0024self__00241607;

			public _0024(bool l, EnemyScript self_)
			{
				_0024l_00241606 = l;
				_0024self__00241607 = self_;
			}

			public override bool MoveNext()
			{
				//IL_0247: Unknown result type (might be due to invalid IL or missing references)
				//IL_0251: Expected O, but got Unknown
				//IL_018d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0192: Unknown result type (might be due to invalid IL or missing references)
				//IL_0193: Unknown result type (might be due to invalid IL or missing references)
				//IL_0195: Unknown result type (might be due to invalid IL or missing references)
				//IL_019a: Unknown result type (might be due to invalid IL or missing references)
				//IL_01c1: Unknown result type (might be due to invalid IL or missing references)
				//IL_01c6: Unknown result type (might be due to invalid IL or missing references)
				//IL_01c7: Unknown result type (might be due to invalid IL or missing references)
				//IL_01ce: Unknown result type (might be due to invalid IL or missing references)
				//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
				//IL_01f0: Unknown result type (might be due to invalid IL or missing references)
				//IL_01f1: Unknown result type (might be due to invalid IL or missing references)
				//IL_01f3: Unknown result type (might be due to invalid IL or missing references)
				//IL_01f8: Unknown result type (might be due to invalid IL or missing references)
				//IL_021f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0224: Unknown result type (might be due to invalid IL or missing references)
				//IL_0225: Unknown result type (might be due to invalid IL or missing references)
				//IL_022c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0231: Unknown result type (might be due to invalid IL or missing references)
				//IL_023b: Expected O, but got Unknown
				//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
				//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
				//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
				//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
				//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
				//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
				//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
				//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
				//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
				//IL_0119: Unknown result type (might be due to invalid IL or missing references)
				//IL_011e: Unknown result type (might be due to invalid IL or missing references)
				//IL_011f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0121: Unknown result type (might be due to invalid IL or missing references)
				//IL_0126: Unknown result type (might be due to invalid IL or missing references)
				//IL_014d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0152: Unknown result type (might be due to invalid IL or missing references)
				//IL_0153: Unknown result type (might be due to invalid IL or missing references)
				//IL_015a: Unknown result type (might be due to invalid IL or missing references)
				//IL_015f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0169: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					if (MenuScript.multiplayer > 0)
					{
						((Component)_0024self__00241607).networkView.RPC("KN", (RPCMode)2, new object[1] { _0024l_00241606 });
						goto IL_027e;
					}
					_0024self__00241607.knocking = true;
					_0024wasK_00241597 = default(bool);
					if (_0024self__00241607.r.isKinematic)
					{
						_0024wasK_00241597 = true;
						_0024self__00241607.r.isKinematic = false;
					}
					if (_0024l_00241606)
					{
						int num = (_0024_0024586_00241598 = -12);
						Vector3 val = (_0024_0024587_00241599 = _0024self__00241607.r.velocity);
						float num2 = (_0024_0024587_00241599.x = _0024_0024586_00241598);
						Vector3 val3 = (_0024self__00241607.r.velocity = _0024_0024587_00241599);
						int num3 = (_0024_0024588_00241600 = 10);
						Vector3 val4 = (_0024_0024589_00241601 = _0024self__00241607.r.velocity);
						float num4 = (_0024_0024589_00241601.y = _0024_0024588_00241600);
						Vector3 val6 = (_0024self__00241607.r.velocity = _0024_0024589_00241601);
						result = (((GenericGeneratorEnumerator<YieldInstruction>)this).Yield(2, (YieldInstruction)new WaitForEndOfFrame()) ? 1 : 0);
					}
					else
					{
						int num5 = (_0024_0024590_00241602 = 12);
						Vector3 val7 = (_0024_0024591_00241603 = _0024self__00241607.r.velocity);
						float num6 = (_0024_0024591_00241603.x = _0024_0024590_00241602);
						Vector3 val9 = (_0024self__00241607.r.velocity = _0024_0024591_00241603);
						int num7 = (_0024_0024592_00241604 = 10);
						Vector3 val10 = (_0024_0024593_00241605 = _0024self__00241607.r.velocity);
						float num8 = (_0024_0024593_00241605.y = _0024_0024592_00241604);
						Vector3 val12 = (_0024self__00241607.r.velocity = _0024_0024593_00241605);
						result = (((GenericGeneratorEnumerator<YieldInstruction>)this).Yield(3, (YieldInstruction)new WaitForEndOfFrame()) ? 1 : 0);
					}
					break;
				case 2:
				case 3:
					result = (((GenericGeneratorEnumerator<YieldInstruction>)this).Yield(4, (YieldInstruction)new WaitForSeconds(0.5f)) ? 1 : 0);
					break;
				case 4:
					_0024self__00241607.knocking = false;
					if (_0024wasK_00241597)
					{
						_0024self__00241607.r.isKinematic = true;
					}
					goto IL_027e;
				case 1:
					{
						result = 0;
						break;
					}
					IL_027e:
					((GenericGeneratorEnumerator<YieldInstruction>)this).YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal bool _0024l_00241608;

		internal EnemyScript _0024self__00241609;

		public _0024K_00241596(bool l, EnemyScript self_)
		{
			_0024l_00241608 = l;
			_0024self__00241609 = self_;
		}

		public override IEnumerator<YieldInstruction> GetEnumerator()
		{
			return (IEnumerator<YieldInstruction>)(object)new _0024(_0024l_00241608, _0024self__00241609);
		}
	}

	public bool isChicken;

	public int bossID;

	public AudioClip a;

	public AudioClip aHit;

	public GameObject @base;

	public GameObject e;

	public bool moving;

	public int dir;

	public int HP;

	public int MAXHP;

	public int ATK;

	public int DEF;

	public int EXP;

	public int SPD;

	public int[] drops;

	public Transform t;

	public bool takingDamage;

	public Rigidbody r;

	private int GOLD;

	private int exp;

	public bool attacking;

	public bool knocking;

	private float poisonDMG;

	public EnemyScript()
	{
		drops = new int[3];
	}

	public override void Awake()
	{
		t = ((Component)this).transform;
		r = ((Component)this).rigidbody;
		((Component)this).collider.material.dynamicFriction = 0f;
	}

	[RPC]
	public override IEnumerator SetStatsN(int hp, int atk)
	{
		return new _0024SetStatsN_00241520(hp, atk, this).GetEnumerator();
	}

	public override void SetStats(int HP, int ATK, int DEF, int EXP, float SPD, int[] drops, int coins, int exp)
	{
		MAXHP = HP;
		this.HP = MAXHP;
		this.ATK = ATK;
		this.DEF = DEF;
		this.EXP = EXP;
		this.SPD = (int)SPD;
		this.drops = drops;
		GOLD = coins;
		this.exp = exp;
		poisonDMG = MAXHP;
		poisonDMG *= 0.2f;
		if (MenuScript.multiplayer == 1)
		{
			MAXHP = (int)((float)MAXHP + (float)HP * 0.5f * (float)Network.connections.Length);
			this.ATK = (int)((float)this.ATK + (float)ATK * 0.4f * (float)Network.connections.Length);
			((Component)this).networkView.RPC("SetStatsN", (RPCMode)2, new object[2] { MAXHP, this.ATK });
		}
	}

	public override void Update()
	{
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		if (!attacking && !knocking)
		{
			if (dir == 1 && moving)
			{
				@base.animation.Play("r");
				int num = -SPD;
				Vector3 velocity = ((Component)this).rigidbody.velocity;
				float num2 = (velocity.x = num);
				Vector3 val2 = (((Component)this).rigidbody.velocity = velocity);
				e.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
			}
			else if (dir == 2 && moving)
			{
				@base.animation.Play("r");
				int sPD = SPD;
				Vector3 velocity2 = ((Component)this).rigidbody.velocity;
				float num3 = (velocity2.x = sPD);
				Vector3 val4 = (((Component)this).rigidbody.velocity = velocity2);
				e.transform.rotation = Quaternion.Euler(0f, 180f, 0f);
			}
			else
			{
				@base.animation.Play("i");
			}
		}
	}

	public override void OnCollisionEnter(Collision c)
	{
		if (c.gameObject.layer == 8)
		{
			c.gameObject.SendMessage("TD", (object)ATK);
		}
	}

	public override IEnumerator Knock22(Vector3 p)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		return new _0024Knock22_00241527(p, this).GetEnumerator();
	}

	public override IEnumerator Knock(Vector3 p)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		return new _0024Knock_00241539(p, this).GetEnumerator();
	}

	[RPC]
	public override IEnumerator KnockN(Vector3 p)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		return new _0024KnockN_00241550(p, this).GetEnumerator();
	}

	public override IEnumerator TD(int dmg)
	{
		return new _0024TD_00241563(dmg, this).GetEnumerator();
	}

	[RPC]
	public override void TDN(int dmg)
	{
		takingDamage = true;
		e.animation.Play();
		HP -= dmg;
		if (HP < 1)
		{
			Die();
		}
		else
		{
			takingDamage = false;
		}
	}

	[RPC]
	public override IEnumerator TDN2(int dmg)
	{
		return new _0024TDN2_00241575(this).GetEnumerator();
	}

	public override void Die()
	{
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_064c: Unknown result type (might be due to invalid IL or missing references)
		//IL_065c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_0176: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_021b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0220: Unknown result type (might be due to invalid IL or missing references)
		//IL_0489: Unknown result type (might be due to invalid IL or missing references)
		//IL_048e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0498: Unknown result type (might be due to invalid IL or missing references)
		//IL_049e: Expected O, but got Unknown
		//IL_03d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ea: Expected O, but got Unknown
		//IL_02c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02dd: Expected O, but got Unknown
		//IL_05fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0609: Unknown result type (might be due to invalid IL or missing references)
		//IL_060f: Expected O, but got Unknown
		//IL_0545: Unknown result type (might be due to invalid IL or missing references)
		//IL_054a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0555: Unknown result type (might be due to invalid IL or missing references)
		//IL_055b: Expected O, but got Unknown
		GameObject val = null;
		int num = default(int);
		Item item = null;
		if (isChicken && Network.isServer && Random.Range(0, 8) == 0)
		{
			Network.Instantiate(Resources.Load("e/chickenKing"), new Vector3(0f, 0f, 0f), Quaternion.identity, 0);
		}
		if (bossID > 0)
		{
			GameScript.tempStats[10] = GameScript.tempStats[10] + 1;
		}
		if (bossID == 1)
		{
			MenuScript.canUnlockHat[8] = 1;
		}
		else if (bossID == 2)
		{
			MenuScript.canUnlockHat[14] = 1;
		}
		else if (bossID == 3)
		{
			MenuScript.canUnlockHat[18] = 1;
		}
		else if (bossID == 4)
		{
			MenuScript.canUnlockHat[20] = 1;
		}
		else if (bossID == 5)
		{
			MenuScript.canUnlockHat[21] = 1;
		}
		else if (bossID == 6)
		{
			MenuScript.canUnlockHat[22] = 1;
		}
		if (MenuScript.multiplayer > 0)
		{
			GameScript.tempStats[1] = GameScript.tempStats[1] + 1;
			if (GameScript.tempStats[1] > 14)
			{
				MenuScript.canUnlockRace[1] = 1;
			}
			else if (GameScript.tempStats[1] >= 10)
			{
				MenuScript.canUnlockHat[3] = 1;
			}
			if (Network.isServer)
			{
				for (num = 0; num < GOLD; num++)
				{
					Network.Instantiate(Resources.Load("c"), t.position, Quaternion.identity, 0);
				}
				int num2 = exp;
				while (num2 >= 20)
				{
					num2 -= 20;
					Network.Instantiate(Resources.Load("expHuge"), t.position, Quaternion.identity, 0);
				}
				while (num2 >= 8)
				{
					num2 -= 8;
					Network.Instantiate(Resources.Load("expBig"), t.position, Quaternion.identity, 0);
				}
				for (num = 0; num < num2; num++)
				{
					Network.Instantiate(Resources.Load("exp"), t.position, Quaternion.identity, 0);
				}
				if (drops[0] > 0 && Random.Range(0, 2) == 0)
				{
					int num3 = Random.Range(1, 3);
					for (num = 0; num < num3; num++)
					{
						item = new Item(drops[0], 1, new int[4], 0f, null);
						if (item.id == 566)
						{
							item.e = new int[4] { -3, 100, 0, 0 };
							item.d = 100;
						}
						if (MenuScript.multiplayer > 0)
						{
							val = (GameObject)Network.Instantiate(Resources.Load("item"), t.position, Quaternion.identity, 0);
							val.networkView.RPC("SetID", (RPCMode)6, new object[1] { item.id });
							val.networkView.RPC("SetD", (RPCMode)6, new object[1] { item.d });
							val.networkView.RPC("SetE", (RPCMode)6, new object[1] { item.e });
							val.networkView.RPC("SetQ", (RPCMode)6, new object[1] { 1 });
						}
					}
				}
				if (drops[1] > 0 && Random.Range(0, 4) == 0)
				{
					int num4 = Random.Range(1, 3);
					item = new Item(drops[1], 1, new int[2], 0f, null);
					for (num = 0; num < num4; num++)
					{
						if (MenuScript.multiplayer > 0)
						{
							val = (GameObject)Network.Instantiate(Resources.Load("item"), t.position, Quaternion.identity, 0);
							val.networkView.RPC("SetID", (RPCMode)6, new object[1] { item.id });
							val.networkView.RPC("SetD", (RPCMode)6, new object[1] { item.d });
							val.networkView.RPC("SetE", (RPCMode)6, new object[1] { item.e });
							val.networkView.RPC("SetQ", (RPCMode)6, new object[1] { 1 });
						}
						else
						{
							val = (GameObject)Object.Instantiate(Resources.Load("item"), t.position, Quaternion.identity);
							val.SendMessage("Set", (object)item);
						}
					}
				}
				if (drops[2] > 0 && Random.Range(0, 8) == 0)
				{
					int num5 = Random.Range(1, 3);
					item = new Item(drops[2], 1, new int[4], 0f, null);
					if (item.id == 566)
					{
						item.e = new int[4] { -3, 100, 0, 0 };
						item.d = 100;
					}
					for (num = 0; num < num5; num++)
					{
						if (MenuScript.multiplayer > 0)
						{
							val = (GameObject)Network.Instantiate(Resources.Load("item"), t.position, Quaternion.identity, 0);
							val.networkView.RPC("SetID", (RPCMode)6, new object[1] { item.id });
							val.networkView.RPC("SetD", (RPCMode)6, new object[1] { item.d });
							val.networkView.RPC("SetE", (RPCMode)6, new object[1] { item.e });
							val.networkView.RPC("SetQ", (RPCMode)6, new object[1] { 1 });
						}
						else
						{
							val = (GameObject)Object.Instantiate(Resources.Load("item"), t.position, Quaternion.identity);
							val.SendMessage("Set", (object)item);
						}
					}
				}
			}
		}
		if (MenuScript.multiplayer == 0)
		{
			Object.Destroy((Object)(object)((Component)this).gameObject);
		}
		if (Network.isServer)
		{
			Network.RemoveRPCs(((Component)this).networkView.viewID);
			Network.Destroy(((Component)this).networkView.viewID);
		}
	}

	public override void OnDestroy()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		if (MenuScript.multiplayer > 0)
		{
			Network.RemoveRPCs(((Component)this).networkView.viewID);
		}
	}

	[RPC]
	public override IEnumerator KN(bool l)
	{
		return new _0024KN_00241582(l, this).GetEnumerator();
	}

	public override IEnumerator K(bool l)
	{
		return new _0024K_00241596(l, this).GetEnumerator();
	}

	public override void TDp()
	{
		int dmg = (int)poisonDMG;
		((MonoBehaviour)this).StartCoroutine_Auto(TD(dmg));
	}

	public override void Main()
	{
	}
}
