using SideScrollShooter._Models._Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SideScrollShooter._Models.Enemies
{
	internal class EnemyRoller : AnimatedSprite
	{
		private Vector2 Direction = new Vector2(-1, 1);
		private float timeSinceDirectionChange { get; set; } = 0f;
		private float _speed { get; set; } = 300f;
		public EnemyRoller(Texture2D texture, Vector2 position, int frames, bool loop) : base(texture, position, frames, loop)
		{
			Points = 20;
		}

		public override void Update()
		{
			timeSinceDirectionChange += Globals.ElapsedGameTimeSeconds;

			if (timeSinceDirectionChange >= 0.5)
			{
				Direction = new Vector2(Direction.X, Direction.Y * -1);
				timeSinceDirectionChange = 0f;
			}

			Position += Direction * _speed * Globals.ElapsedGameTimeSeconds;
			


			base.Update();

		}
	}
}
