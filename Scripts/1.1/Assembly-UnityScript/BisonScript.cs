using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class BisonScript : EnemyScript
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Moove_00241366 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024num_00241367;

			internal BisonScript _0024self__00241368;

			public _0024(BisonScript self_)
			{
				_0024self__00241368 = self_;
			}

			public override bool MoveNext()
			{
				//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
				//IL_00da: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					_0024self__00241368.mooving = true;
					_0024num_00241367 = Random.Range(0, 5);
					if (_0024num_00241367 != 0)
					{
						if (_0024num_00241367 == 1)
						{
							_0024self__00241368.MOV = true;
							((Component)_0024self__00241368).networkView.RPC("Turn", (RPCMode)2, new object[1] { 1 });
							_0024self__00241368.spdd = 2;
						}
						else
						{
							((Component)_0024self__00241368).networkView.RPC("Turn", (RPCMode)2, new object[1] { 0 });
							_0024self__00241368.MOV = true;
							_0024self__00241368.spdd = -2;
						}
					}
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(1f)) ? 1 : 0);
					break;
				case 2:
					_0024self__00241368.mooving = false;
					_0024self__00241368.MOV = false;
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal BisonScript _0024self__00241369;

		public _0024Moove_00241366(BisonScript self_)
		{
			_0024self__00241369 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00241369);
		}
	}

	private int spdd;

	private bool mooving;

	private bool MOV;

	public override void Awake()
	{
		int[] array = new int[3] { 7, 19, 20 };
		SetStats(7, 1, 1, 3, 3f, array, Random.Range(2, 6), 2);
		r = ((Component)this).rigidbody;
		t = ((Component)this).transform;
	}

	public override void Update()
	{
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		if (!mooving && MenuScript.multiplayer == 1)
		{
			((MonoBehaviour)this).StartCoroutine_Auto(Moove());
		}
		if (MOV)
		{
			int num = spdd;
			Vector3 velocity = r.velocity;
			float num2 = (velocity.x = num);
			Vector3 val2 = (r.velocity = velocity);
		}
	}

	public override IEnumerator Moove()
	{
		return new _0024Moove_00241366(this).GetEnumerator();
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
}