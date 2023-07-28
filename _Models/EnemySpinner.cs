using SideScrollShooter._Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SideScrollShooter._Models
{
    internal class EnemySpinner : AnimatedSprite
    {
        private float _speed = 100;
        public EnemySpinner(Texture2D texture, Vector2 position, int frames) : base(texture, position, frames) { }

        public override void Update()
        {
            base.Update();
            Position = new Vector2(Position.X - _speed * Globals.ElapsedGameTimeSeconds, Position.Y);
        }

    }
}
