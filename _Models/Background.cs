using SideScrollShooter._Models._Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SideScrollShooter._Models
{
    internal class Background : AnimatedSprite
    {
        private float _scrollSpeed;
        private Vector2 _direction = new Vector2(-1, 0);

        public Background(Texture2D texture, Vector2 position, int frames, float scrollSpeed, float animationSpeed) : base(texture, position, frames, animationSpeed)
        {
            _scrollSpeed = scrollSpeed;
        }

        public override void Update()
        {
            Position += _direction * _scrollSpeed * Globals.ElapsedGameTimeSeconds;
            base.Update();
        }
    }
}
