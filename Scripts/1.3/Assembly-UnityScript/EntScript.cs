using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class EntScript : EnemyScript
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Start_00241581 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int[] _0024drops_00241582;

			internal EntScript _0024self__00241583;

			public _0024(EntScript self_)
			{
				_0024self__00241583 = self_;
			}

			public override bool MoveNext()
			{
				//IL_008f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0099: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					_0024self__00241583.@base.animation["i"].layer = 0;
					_0024drops_00241582 = new int[3] { 7, 18, 0 };
					_0024self__00241583.SetStats(10, 1, 1, 3, 2f, _0024drops_00241582, Random.Range(2, 6), 3);
					goto case 2;
				case 2:
					((MonoBehaviour)_0024self__00241583).StartCoroutine_Auto(_0024self__00241583.AttackCheck());
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.7f)) ? 1 : 0);
					break;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal EntScript _0024self__00241584;

		public _0024Start_00241581(EntScript self_)
		{
			_0024self__00241584 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00241584);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024AttackCheck_00241585 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal Ray _0024ray_00241586;

			internal Ray _0024ray2_00241587;

			internal int _0024_0024576_00241588;

			internal Vector3 _0024_0024577_00241589;

			internal int _0024_0024578_00241590;

			internal Vector3 _0024_0024579_00241591;

			internal int _0024_0024580_00241592;

			internal Vector3 _0024_0024581_00241593;

			internal int _0024_0024582_00241594;

			internal Vector3 _0024_0024583_00241595;

			internal int _0024_0024584_00241596;

			internal Vector3 _0024_0024585_00241597;

			internal EntScript _0024self__00241598;

			public _0024(EntScript self_)
			{
				_0024self__00241598 = self_;
			}

			public override bool MoveNext()
			{
				//IL_0023: Unknown result type (might be due to invalid IL or missing references)
				//IL_002e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0033: Unknown result type (might be due to invalid IL or missing references)
				//IL_0038: Unknown result type (might be due to invalid IL or missing references)
				//IL_0049: Unknown result type (might be due to invalid IL or missing references)
				//IL_0054: Unknown result type (might be due to invalid IL or missing references)
				//IL_0059: Unknown result type (might be due to invalid IL or missing references)
				//IL_005e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0064: Unknown result type (might be due to invalid IL or missing references)
				//IL_02a9: Unknown result type (might be due to invalid IL or missing references)
				//IL_02ae: Unknown result type (might be due to invalid IL or missing references)
				//IL_02af: Unknown result type (might be due to invalid IL or missing references)
				//IL_02b1: Unknown result type (might be due to invalid IL or missing references)
				//IL_02b6: Unknown result type (might be due to invalid IL or missing references)
				//IL_02dd: Unknown result type (might be due to invalid IL or missing references)
				//IL_02e2: Unknown result type (might be due to invalid IL or missing references)
				//IL_02e3: Unknown result type (might be due to invalid IL or missing references)
				//IL_02ea: Unknown result type (might be due to invalid IL or missing references)
				//IL_016a: Unknown result type (might be due to invalid IL or missing references)
				//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
				//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
				//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
				//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
				//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
				//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
				//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
				//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
				//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
				//IL_0104: Unknown result type (might be due to invalid IL or missing references)
				//IL_0120: Unknown result type (might be due to invalid IL or missing references)
				//IL_0125: Unknown result type (might be due to invalid IL or missing references)
				//IL_0126: Unknown result type (might be due to invalid IL or missing references)
				//IL_0128: Unknown result type (might be due to invalid IL or missing references)
				//IL_012d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0154: Unknown result type (might be due to invalid IL or missing references)
				//IL_0159: Unknown result type (might be due to invalid IL or missing references)
				//IL_015a: Unknown result type (might be due to invalid IL or missing references)
				//IL_0161: Unknown result type (might be due to invalid IL or missing references)
				//IL_0275: Unknown result type (might be due to invalid IL or missing references)
				//IL_027f: Expected O, but got Unknown
				//IL_01a2: Unknown result type (might be due to invalid IL or missing references)
				//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
				//IL_01d1: Unknown result type (might be due to invalid IL or missing references)
				//IL_01d2: Unknown result type (might be due to invalid IL or missing references)
				//IL_01d4: Unknown result type (might be due to invalid IL or missing references)
				//IL_01d9: Unknown result type (might be due to invalid IL or missing references)
				//IL_0200: Unknown result type (might be due to invalid IL or missing references)
				//IL_0205: Unknown result type (might be due to invalid IL or missing references)
				//IL_0206: Unknown result type (might be due to invalid IL or missing references)
				//IL_020d: Unknown result type (might be due to invalid IL or missing references)
				//IL_022a: Unknown result type (might be due to invalid IL or missing references)
				//IL_022f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0230: Unknown result type (might be due to invalid IL or missing references)
				//IL_0232: Unknown result type (might be due to invalid IL or missing references)
				//IL_0237: Unknown result type (might be due to invalid IL or missing references)
				//IL_025e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0263: Unknown result type (might be due to invalid IL or missing references)
				//IL_0264: Unknown result type (might be due to invalid IL or missing references)
				//IL_026b: Unknown result type (might be due to invalid IL or missing references)
				int result;
				switch (base._state)
				{
				default:
					_0024ray_00241586 = new Ray(_0024self__00241598.t.position, new Vector3(1f, 0f, 0f));
					_0024ray2_00241587 = new Ray(_0024self__00241598.t.position, new Vector3(-1f, 0f, 0f));
					if (Physics.Raycast(_0024ray_00241586, ref _0024self__00241598.hit, 10f, 256))
					{
						_0024self__00241598.e.transform.rotation = Quaternion.Euler(0f, 180f, 0f);
						int num3 = (_0024_0024576_00241588 = Random.Range(5, 10));
						Vector3 val4 = (_0024_0024577_00241589 = _0024self__00241598.r.velocity);
						float num4 = (_0024_0024577_00241589.y = _0024_0024576_00241588);
						Vector3 val6 = (_0024self__00241598.r.velocity = _0024_0024577_00241589);
						int num5 = (_0024_0024578_00241590 = 10);
						Vector3 val7 = (_0024_0024579_00241591 = _0024self__00241598.r.velocity);
						float num6 = (_0024_0024579_00241591.x = _0024_0024578_00241590);
						Vector3 val9 = (_0024self__00241598.r.velocity = _0024_0024579_00241591);
					}
					else if (Physics.Raycast(_0024ray2_00241587, ref _0024self__00241598.hit, 10f, 256))
					{
						_0024self__00241598.e.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
						int num7 = (_0024_0024580_00241592 = Random.Range(5, 10));
						Vector3 val10 = (_0024_0024581_00241593 = _0024self__00241598.r.velocity);
						float num8 = (_0024_0024581_00241593.y = _0024_0024580_00241592);
						Vector3 val12 = (_0024self__00241598.r.velocity = _0024_0024581_00241593);
						int num9 = (_0024_0024582_00241594 = -10);
						Vector3 val13 = (_0024_0024583_00241595 = _0024self__00241598.r.velocity);
						float num10 = (_0024_0024583_00241595.x = _0024_0024582_00241594);
						Vector3 val15 = (_0024self__00241598.r.velocity = _0024_0024583_00241595);
					}
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.3f)) ? 1 : 0);
					break;
				case 2:
				{
					_0024self__00241598.attacking = false;
					int num = (_0024_0024584_00241596 = 0);
					Vector3 val = (_0024_0024585_00241597 = _0024self__00241598.r.velocity);
					float num2 = (_0024_0024585_00241597.x = _0024_0024584_00241596);
					Vector3 val3 = (_0024self__00241598.r.velocity = _0024_0024585_00241597);
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

		internal EntScript _0024self__00241599;

		public _0024AttackCheck_00241585(EntScript self_)
		{
			_0024self__00241599 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00241599);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024MoveCheck_00241600 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024num_00241601;

			internal int _0024dir_00241602;

			internal int _0024_0024586_00241603;

			internal Vector3 _0024_0024587_00241604;

			internal EntScript _0024self__00241605;

			public _0024(EntScript self_)
			{
				_0024self__00241605 = self_;
			}

			public override bool MoveNext()
			{
				//IL_0100: Unknown result type (might be due to invalid IL or missing references)
				//IL_010a: Expected O, but got Unknown
				//IL_0069: Unknown result type (might be due to invalid IL or missing references)
				//IL_006e: Unknown result type (might be due to invalid IL or missing references)
				//IL_006f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0070: Unknown result type (might be due to invalid IL or missing references)
				//IL_0075: Unknown result type (might be due to invalid IL or missing references)
				//IL_0099: Unknown result type (might be due to invalid IL or missing references)
				//IL_009e: Unknown result type (might be due to invalid IL or missing references)
				//IL_009f: Unknown result type (might be due to invalid IL or missing references)
				//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
				//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
				//IL_00bb: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					if (!_0024self__00241605.attacking)
					{
						((Component)_0024self__00241605).audio.PlayOneShot(_0024self__00241605.a);
						_0024self__00241605.dir = 0;
						int num = (_0024_0024586_00241603 = 0);
						Vector3 val = (_0024_0024587_00241604 = _0024self__00241605._0024get_rigidbody_00241606().velocity);
						float num2 = (_0024_0024587_00241604.x = _0024_0024586_00241603);
						Vector3 val3 = (_0024self__00241605._0024get_rigidbody_00241607().velocity = _0024_0024587_00241604);
						result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds((float)Random.Range(0, 3))) ? 1 : 0);
						break;
					}
					goto IL_00f7;
				case 2:
					_0024num_00241601 = Random.Range(1, 2);
					_0024dir_00241602 = Random.Range(1, 3);
					_0024self__00241605.moving = false;
					_0024self__00241605.dir = _0024dir_00241602;
					goto IL_00f7;
				case 3:
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				case 1:
					{
						result = 0;
						break;
					}
					IL_00f7:
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(3, new WaitForSeconds((float)_0024num_00241601)) ? 1 : 0);
					break;
				}
				return (byte)result != 0;
			}
		}

		internal EntScript _0024self__00241608;

		public _0024MoveCheck_00241600(EntScript self_)
		{
			_0024self__00241608 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00241608);
		}
	}

	private RaycastHit hit;

	public override IEnumerator Start()
	{
		return new _0024Start_00241581(this).GetEnumerator();
	}

	public override IEnumerator AttackCheck()
	{
		return new _0024AttackCheck_00241585(this).GetEnumerator();
	}

	public override IEnumerator MoveCheck()
	{
		return new _0024MoveCheck_00241600(this).GetEnumerator();
	}

	internal Rigidbody _0024get_rigidbody_00241606()
	{
		return ((Component)this).rigidbody;
	}

	internal Rigidbody _0024get_rigidbody_00241607()
	{
		return ((Component)this).rigidbody;
	}
}
