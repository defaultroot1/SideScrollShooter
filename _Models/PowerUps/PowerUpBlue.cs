using SideScrollShooter._Models._Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SideScrollShooter._Models.PowerUps
{
    internal class PowerUpBlue : AnimatedSprite
    {

        public PowerUpBlue(Texture2D texture, Vector2 position, int frames, bool loop) : base(texture, position, frames, loop) { }
        private Vector2 _direction = new Vector2(-1, 0);

        public override void Update()
        {
            Position += _direction * Globals.globalScrollSpeed * Globals.ElapsedGameTimeSeconds;
            base.Update();

        }
    }

}
