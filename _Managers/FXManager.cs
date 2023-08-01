using SideScrollShooter._Models._Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SideScrollShooter._Models.FX;
using SideScrollShooter._Models.Enemies;

namespace SideScrollShooter._Managers
{
	public static class FXManager
	{
		private static List<AnimatedSprite> _fxSprites = new List<AnimatedSprite>();

		public static void SpawnSpinnerExplosion(Vector2 position) 
		{
			_fxSprites.Add(new SparkExplosion(Globals.ContentManger.Load<Texture2D>("Sprites/spinnerExplosion"),
				position, 3, false));
		}
		public static void SpawnSmokeyExplosion(Vector2 position)
		{
			_fxSprites.Add(new SmokeyExplosion(Globals.ContentManger.Load<Texture2D>("Sprites/seekerExplosion"),
				position, 4, false));
		}

		public static void Update()
		{
			foreach (var sprite in _fxSprites)
			{
				sprite.Update();
			}
			DestroyFX();
		}

		public static void Draw()
		{
			foreach (var sprite in _fxSprites)
			{
				sprite.Draw();
			}
		}

		public static void DestroyFX()
		{
			// Destroy any FX that have completed their loop
			_fxSprites.RemoveAll(sprite => sprite is SparkExplosion explosion && explosion.isAnimationComplete);
			_fxSprites.RemoveAll(sprite => sprite is SmokeyExplosion explosion && explosion.isAnimationComplete);
		}

	}
}
