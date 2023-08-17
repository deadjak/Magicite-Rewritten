using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class SlimeScript : EnemyScript
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Start_00242741 : GenericGenerator<YieldInstruction>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<YieldInstruction>, IEnumerator
		{
			internal SlimeScript _0024self__00242742;

			public _0024(SlimeScript self_)
			{
				_0024self__00242742 = self_;
			}

			public override bool MoveNext()
			{
				//IL_0025: Unknown result type (might be due to invalid IL or missing references)
				//IL_002f: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					result = (((GenericGeneratorEnumerator<YieldInstruction>)this).Yield(2, (YieldInstruction)new WaitForSeconds((float)Random.Range(0, 6))) ? 1 : 0);
					break;
				case 2:
				case 3:
					result = (((GenericGeneratorEnumerator<YieldInstruction>)this).Yield(3, (YieldInstruction)(object)((MonoBehaviour)_0024self__00242742).StartCoroutine_Auto(_0024self__00242742.MoveCheck())) ? 1 : 0);
					break;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal SlimeScript _0024self__00242743;

		public _0024Start_00242741(SlimeScript self_)
		{
			_0024self__00242743 = self_;
		}

		public override IEnumerator<YieldInstruction> GetEnumerator()
		{
			return (IEnumerator<YieldInstruction>)(object)new _0024(_0024self__00242743);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024MoveCheck_00242744 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024num_00242745;

			internal int _0024_00241004_00242746;

			internal Vector3 _0024_00241005_00242747;

			internal int _0024_00241006_00242748;

			internal Vector3 _0024_00241007_00242749;

			internal int _0024_00241008_00242750;

			internal Vector3 _0024_00241009_00242751;

			internal int _0024_00241010_00242752;

			internal Vector3 _0024_00241011_00242753;

			internal SlimeScript _0024self__00242754;

			public _0024(SlimeScript self_)
			{
				_0024self__00242754 = self_;
			}

			public override bool MoveNext()
			{
				//IL_0109: Unknown result type (might be due to invalid IL or missing references)
				//IL_010e: Unknown result type (might be due to invalid IL or missing references)
				//IL_010f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0111: Unknown result type (might be due to invalid IL or missing references)
				//IL_0116: Unknown result type (might be due to invalid IL or missing references)
				//IL_013d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0142: Unknown result type (might be due to invalid IL or missing references)
				//IL_0143: Unknown result type (might be due to invalid IL or missing references)
				//IL_014a: Unknown result type (might be due to invalid IL or missing references)
				//IL_016e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0173: Unknown result type (might be due to invalid IL or missing references)
				//IL_0174: Unknown result type (might be due to invalid IL or missing references)
				//IL_0176: Unknown result type (might be due to invalid IL or missing references)
				//IL_017b: Unknown result type (might be due to invalid IL or missing references)
				//IL_01a2: Unknown result type (might be due to invalid IL or missing references)
				//IL_01a7: Unknown result type (might be due to invalid IL or missing references)
				//IL_01a8: Unknown result type (might be due to invalid IL or missing references)
				//IL_01af: Unknown result type (might be due to invalid IL or missing references)
				//IL_0047: Unknown result type (might be due to invalid IL or missing references)
				//IL_004c: Unknown result type (might be due to invalid IL or missing references)
				//IL_004d: Unknown result type (might be due to invalid IL or missing references)
				//IL_004e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0053: Unknown result type (might be due to invalid IL or missing references)
				//IL_0077: Unknown result type (might be due to invalid IL or missing references)
				//IL_007c: Unknown result type (might be due to invalid IL or missing references)
				//IL_007d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0083: Unknown result type (might be due to invalid IL or missing references)
				//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
				//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
				//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
				//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
				//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
				//IL_00da: Unknown result type (might be due to invalid IL or missing references)
				//IL_00df: Unknown result type (might be due to invalid IL or missing references)
				//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
				//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
				//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
				//IL_01c0: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					_0024num_00242745 = Random.Range(0, 2);
					if (_0024num_00242745 != 0)
					{
						int num = (_0024_00241008_00242750 = -10);
						Vector3 val = (_0024_00241009_00242751 = ((Component)_0024self__00242754).rigidbody.velocity);
						float num2 = (_0024_00241009_00242751.x = _0024_00241008_00242750);
						Vector3 val3 = (((Component)_0024self__00242754).rigidbody.velocity = _0024_00241009_00242751);
						int num3 = (_0024_00241010_00242752 = Random.Range(10, 16));
						Vector3 val4 = (_0024_00241011_00242753 = ((Component)_0024self__00242754).rigidbody.velocity);
						float num4 = (_0024_00241011_00242753.y = _0024_00241010_00242752);
						Vector3 val6 = (((Component)_0024self__00242754).rigidbody.velocity = _0024_00241011_00242753);
					}
					else
					{
						int num5 = (_0024_00241004_00242746 = 10);
						Vector3 val7 = (_0024_00241005_00242747 = ((Component)_0024self__00242754).rigidbody.velocity);
						float num6 = (_0024_00241005_00242747.x = _0024_00241004_00242746);
						Vector3 val9 = (((Component)_0024self__00242754).rigidbody.velocity = _0024_00241005_00242747);
						int num7 = (_0024_00241006_00242748 = Random.Range(10, 16));
						Vector3 val10 = (_0024_00241007_00242749 = ((Component)_0024self__00242754).rigidbody.velocity);
						float num8 = (_0024_00241007_00242749.y = _0024_00241006_00242748);
						Vector3 val12 = (((Component)_0024self__00242754).rigidbody.velocity = _0024_00241007_00242749);
					}
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(3f)) ? 1 : 0);
					break;
				case 2:
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal SlimeScript _0024self__00242755;

		public _0024MoveCheck_00242744(SlimeScript self_)
		{
			_0024self__00242755 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00242755);
		}
	}

	public override void Awake()
	{
		int[] array = new int[3] { 9, 18, 15 };
		SetStats(10, 1, 0, 3, 4f, array, Random.Range(5, 15), 3);
		@base.animation["i"].speed = 0.5f;
		t = ((Component)this).transform;
		r = ((Component)this).rigidbody;
		((Component)this).collider.material.dynamicFriction = 0f;
	}

	public override IEnumerator Start()
	{
		return new _0024Start_00242741(this).GetEnumerator();
	}

	public override IEnumerator MoveCheck()
	{
		return new _0024MoveCheck_00242744(this).GetEnumerator();
	}
}
