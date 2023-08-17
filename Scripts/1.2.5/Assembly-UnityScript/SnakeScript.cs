using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class SnakeScript : EnemyScript
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Start_00242777 : GenericGenerator<Coroutine>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<Coroutine>, IEnumerator
		{
			internal int[] _0024drops_00242778;

			internal SnakeScript _0024self__00242779;

			public _0024(SnakeScript self_)
			{
				_0024self__00242779 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (base._state)
				{
				default:
					_0024self__00242779.canChange = true;
					_0024self__00242779.@base.animation["i"].layer = 0;
					_0024drops_00242778 = new int[3] { 7, 18, 0 };
					_0024self__00242779.SetStats(354, 1, 1, 3, 6f, _0024drops_00242778, Random.Range(2, 6), 3);
					_0024self__00242779.moving = true;
					_0024self__00242779.dir = Random.Range(1, 3);
					((MonoBehaviour)_0024self__00242779).StartCoroutine_Auto(_0024self__00242779.Check());
					goto case 2;
				case 2:
					result = (((GenericGeneratorEnumerator<Coroutine>)this).Yield(2, ((MonoBehaviour)_0024self__00242779).StartCoroutine_Auto(_0024self__00242779.ChangeDir())) ? 1 : 0);
					break;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal SnakeScript _0024self__00242780;

		public _0024Start_00242777(SnakeScript self_)
		{
			_0024self__00242780 = self_;
		}

		public override IEnumerator<Coroutine> GetEnumerator()
		{
			return (IEnumerator<Coroutine>)(object)new _0024(_0024self__00242780);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Check_00242781 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal SnakeScript _0024self__00242782;

			public _0024(SnakeScript self_)
			{
				_0024self__00242782 = self_;
			}

			public override bool MoveNext()
			{
				//IL_0027: Unknown result type (might be due to invalid IL or missing references)
				//IL_002c: Unknown result type (might be due to invalid IL or missing references)
				//IL_006c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0071: Unknown result type (might be due to invalid IL or missing references)
				//IL_0082: Unknown result type (might be due to invalid IL or missing references)
				//IL_008c: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					if (_0024self__00242782.t.position.x == _0024self__00242782.prev)
					{
						((MonoBehaviour)_0024self__00242782).StartCoroutine_Auto(_0024self__00242782.ChangeDir());
					}
					_0024self__00242782.prev = _0024self__00242782.t.position.x;
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(1f)) ? 1 : 0);
					break;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal SnakeScript _0024self__00242783;

		public _0024Check_00242781(SnakeScript self_)
		{
			_0024self__00242783 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00242783);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024ChangeDir_00242784 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal SnakeScript _0024self__00242785;

			public _0024(SnakeScript self_)
			{
				_0024self__00242785 = self_;
			}

			public override bool MoveNext()
			{
				//IL_0026: Unknown result type (might be due to invalid IL or missing references)
				//IL_0030: Expected O, but got Unknown
				//IL_008e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0098: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds((float)Random.Range(3, 10))) ? 1 : 0);
					break;
				case 2:
					_0024self__00242785.canChange = false;
					if (_0024self__00242785.dir == 1)
					{
						_0024self__00242785.dir = 2;
					}
					else
					{
						_0024self__00242785.dir = 1;
					}
					_0024self__00242785.SPD += 3;
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(3, new WaitForSeconds(0.3f)) ? 1 : 0);
					break;
				case 3:
					_0024self__00242785.SPD -= 3;
					_0024self__00242785.canChange = true;
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal SnakeScript _0024self__00242786;

		public _0024ChangeDir_00242784(SnakeScript self_)
		{
			_0024self__00242786 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00242786);
		}
	}

	private RaycastHit hit;

	private bool canChange;

	private Ray ray;

	private Ray ray2;

	private float prev;

	public SnakeScript()
	{
		prev = 1f;
	}

	public override IEnumerator Start()
	{
		return new _0024Start_00242777(this).GetEnumerator();
	}

	public override IEnumerator Check()
	{
		return new _0024Check_00242781(this).GetEnumerator();
	}

	public override IEnumerator ChangeDir()
	{
		return new _0024ChangeDir_00242784(this).GetEnumerator();
	}
}
