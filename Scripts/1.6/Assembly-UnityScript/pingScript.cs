using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class pingScript : MonoBehaviour
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Animate_00243216 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal float _0024_00241208_00243217;

			internal Vector2 _0024_00241209_00243218;

			internal pingScript _0024self__00243219;

			public _0024(pingScript self_)
			{
				_0024self__00243219 = self_;
			}

			public override bool MoveNext()
			{
				//IL_0048: Unknown result type (might be due to invalid IL or missing references)
				//IL_004d: Unknown result type (might be due to invalid IL or missing references)
				//IL_007a: Unknown result type (might be due to invalid IL or missing references)
				//IL_007f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0080: Unknown result type (might be due to invalid IL or missing references)
				//IL_0081: Unknown result type (might be due to invalid IL or missing references)
				//IL_0086: Unknown result type (might be due to invalid IL or missing references)
				//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
				//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
				//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
				//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
				//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
				//IL_00d4: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					_0024self__00243219.r = ((Component)_0024self__00243219).renderer;
					goto case 2;
				case 2:
				{
					float num = (_0024_00241208_00243217 = _0024self__00243219.@base.renderer.material.mainTextureOffset.x + 0.5f);
					Vector2 val = (_0024_00241209_00243218 = _0024self__00243219.@base.renderer.material.mainTextureOffset);
					float num2 = (_0024_00241209_00243218.x = _0024_00241208_00243217);
					Vector2 val3 = (_0024self__00243219.@base.renderer.material.mainTextureOffset = _0024_00241209_00243218);
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.2f)) ? 1 : 0);
					break;
				}
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal pingScript _0024self__00243220;

		public _0024Animate_00243216(pingScript self_)
		{
			_0024self__00243220 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00243220);
		}
	}

	public int num;

	public GameObject @base;

	private Renderer r;

	public Material pingGood;

	public Material pingBad;

	public Material pingTrying;

	public override void OnEnable()
	{
		((Component)this).collider.enabled = true;
		Shit();
	}

	public override void Shit()
	{
	}

	public override IEnumerator Animate()
	{
		return new _0024Animate_00243216(this).GetEnumerator();
	}

	public override void Main()
	{
	}
}
