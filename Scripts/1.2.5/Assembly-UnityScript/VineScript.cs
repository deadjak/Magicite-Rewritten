using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class VineScript : MonoBehaviour
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Start_00242912 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024i_00242913;

			internal int _0024num_00242914;

			internal VineScript _0024self__00242915;

			public _0024(VineScript self_)
			{
				_0024self__00242915 = self_;
			}

			public override bool MoveNext()
			{
				//IL_0093: Unknown result type (might be due to invalid IL or missing references)
				//IL_009d: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					_0024i_00242913 = default(int);
					_0024i_00242913 = 0;
					goto IL_00b0;
				case 2:
					_0024i_00242913++;
					goto IL_00b0;
				case 1:
					{
						result = 0;
						break;
					}
					IL_00b0:
					if (_0024i_00242913 < 3)
					{
						_0024self__00242915.@base[_0024i_00242913].animation["i"].speed = 0.5f;
						_0024self__00242915.@base[_0024i_00242913].animation.Play();
						_0024num_00242914 = Random.Range(1, 5);
						result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds((float)_0024num_00242914 * 0.5f)) ? 1 : 0);
						break;
					}
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal VineScript _0024self__00242916;

		public _0024Start_00242912(VineScript self_)
		{
			_0024self__00242916 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00242916);
		}
	}

	public GameObject[] @base;

	public VineScript()
	{
		@base = (GameObject[])(object)new GameObject[3];
	}

	public override IEnumerator Start()
	{
		return new _0024Start_00242912(this).GetEnumerator();
	}

	public override void Main()
	{
	}
}
