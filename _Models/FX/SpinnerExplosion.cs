using SideScrollShooter._Models._Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SideScrollShooter._Models.FX
{
	internal class SpinnerExplosion : AnimatedSprite
	{
		public SpinnerExplosion(Texture2D texture, Vector2 position, int frames, bool loop) : base(texture, position, frames, loop)
		{
			
		}
	}
}
