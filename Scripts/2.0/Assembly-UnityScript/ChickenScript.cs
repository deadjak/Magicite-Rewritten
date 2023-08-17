using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class ChickenScript : EnemyScript
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Moove_00241320 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024num_00241321;

			internal ChickenScript _0024self__00241322;

			public _0024(ChickenScript self_)
			{
				_0024self__00241322 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					_0024self__00241322.mooving = true;
					_0024num_00241321 = UnityEngine.Random.Range(0, 5);
					if (_0024num_00241321 != 0)
					{
						if (_0024num_00241321 == 1)
						{
							_0024self__00241322.MOV = true;
							_0024self__00241322.GetComponent<NetworkView>().RPC("Turn", RPCMode.All, 1);
							_0024self__00241322.spdd = 8;
						}
						else
						{
							_0024self__00241322.GetComponent<NetworkView>().RPC("Turn", RPCMode.All, 0);
							_0024self__00241322.MOV = true;
							_0024self__00241322.spdd = -8;
						}
					}
					result = (Yield(2, new WaitForSeconds(1f)) ? 1 : 0);
					break;
				case 2:
					_0024self__00241322.mooving = false;
					_0024self__00241322.MOV = false;
					YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal ChickenScript _0024self__00241323;

		public _0024Moove_00241320(ChickenScript self_)
		{
			_0024self__00241323 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00241323);
		}
	}

	private int spdd;

	private bool mooving;

	private bool MOV;

	public override void Awake()
	{
		int[] array = new int[3] { 21, 21, 0 };
		SetStats(7, 1, 1, 3, 3f, array, UnityEngine.Random.Range(2, 6), 2);
		r = GetComponent<Rigidbody>();
		t = transform;
	}

	public override void Update()
	{
		if (!mooving && Network.isServer)
		{
			StartCoroutine_Auto(Moove());
		}
		if (MOV && Network.isServer)
		{
			int num = spdd;
			Vector3 velocity = r.velocity;
			float num2 = (velocity.x = num);
			Vector3 vector2 = (r.velocity = velocity);
		}
	}

	public virtual IEnumerator Moove()
	{
		return new _0024Moove_00241320(this).GetEnumerator();
	}

	[RPC]
	public virtual void Turn(int a)
	{
		if (a == 0)
		{
			int num = 0;
			Quaternion rotation = e.transform.rotation;
			float num2 = (rotation.y = num);
			Quaternion quaternion2 = (e.transform.rotation = rotation);
		}
		else
		{
			int num3 = 180;
			Quaternion rotation2 = e.transform.rotation;
			float num4 = (rotation2.y = num3);
			Quaternion quaternion4 = (e.transform.rotation = rotation2);
		}
	}
}
