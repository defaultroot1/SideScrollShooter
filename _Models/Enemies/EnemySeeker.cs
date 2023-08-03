using SideScrollShooter._Managers;
using SideScrollShooter._Models._Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SideScrollShooter._Models.Enemies
{
	internal class EnemySeeker : AnimatedSprite
	{
		private float _speed = 200.0f;
		private Vector2 _direction = new Vector2(-1, 0);
		public EnemySeeker(Texture2D texture, Vector2 position, int frames, bool loop) : base(texture, position, frames, loop)
		{
			DropsPowerUp = false;
			Points = 50;
		}

		public override void Update()
		{
			var toPlayer = new Vector2((Globals.playerPosition.X + Globals.PlayerWidth / 2) - Position.X,
				Globals.playerPosition.Y - Position.Y);
			//Rotation = (float)Math.Atan2(toPlayer.X, toPlayer.Y);

			var direction = Vector2.Normalize(toPlayer);

			Position += direction * _speed * Globals.ElapsedGameTimeSeconds;


			float angle = (float)Math.Atan2(toPlayer.Y, toPlayer.X);

			Rotation = angle + MathF.PI;

		}
	}
}
