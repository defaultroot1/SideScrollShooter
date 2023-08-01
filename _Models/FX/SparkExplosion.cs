using SideScrollShooter._Models._Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SideScrollShooter._Models.FX
{
	internal class SparkExplosion : AnimatedSprite
	{
		public bool isAnimationComplete { get; set; } = false;
		public SparkExplosion(Texture2D texture, Vector2 position, int frames, bool loop) : base(texture, position, frames, loop)
		{
			
		}

		public override void Update()
		{
			base.Update();
			

			if (Anim.Frame == Anim.Frames - 1)
			{
				isAnimationComplete = true;
			}
			System.Diagnostics.Debug.WriteLine(isAnimationComplete);
		}
	}
}
