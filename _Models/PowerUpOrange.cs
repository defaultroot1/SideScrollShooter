using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SideScrollShooter._Models
{
    internal class PowerUpOrange
    {
        private Vector2 _position = new Vector2(200, 200);
        private static Texture2D _texture;
        private Animation _anim;

        public PowerUpOrange(Vector2 position)
        {
            _position = position;
            _texture ??= Globals.ContentManger.Load<Texture2D>($"Sprites/powerUpOrange");
            _anim = new Animation(_texture, 4, 1, 0.1f, 1);
        }

        public void Update()
        {
            _anim.Update();
        }

        public void Draw()
        {
            _anim.Draw(_position);
        }
    }


}
