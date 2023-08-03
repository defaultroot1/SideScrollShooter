using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SideScrollShooter._Models._Base
{
	public class AnimatedProjectile : AnimatedSprite
	{
		public Vector2 Direction { get; set; }
		public float Speed { get; set; }
		public int Damage { get; set; }
		public float lifespan = 5f;

		public AnimatedProjectile(Texture2D texture, Vector2 position, Vector2 direction, int frames, bool loop) : base(texture, position, frames, loop)
		{
			_texture = texture;
			Position = position;
			Direction = direction;
			Speed = 100f;
			Damage = 1;
		}

		public void Update()
		{
			Position += Direction * Speed * Globals.ElapsedGameTimeSeconds;
			lifespan -= Globals.ElapsedGameTimeSeconds;
		}

		public void Destroy()
		{
			lifespan = 0;
		}

	}
}
