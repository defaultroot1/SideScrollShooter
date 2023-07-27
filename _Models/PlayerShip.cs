using SideScrollShooter._Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SideScrollShooter._Models
{
    internal class PlayerShip
    {
        private Vector2 _position = new Vector2(100, 100);
        private float _speed = 600f;
        private AnimationManager _anims = new AnimationManager();

        public PlayerShip()
        {
            var shipTexture = Globals.ContentManger.Load<Texture2D>("Sprites/playerShipSprite");

            _anims.AddAnimation(new Vector2(1, 0), new Animation(shipTexture, 5, 1, 0.1f, 1));
        }

        public void Update()
        {
            if(InputManager.Moving)
            {
                _position += Vector2.Normalize(InputManager.Direction) * _speed * Globals.ElapsedGameTimeSeconds;
            }

            _anims.Update(InputManager.Direction);
        }

        public void Draw()
        {
            _anims.Draw(_position);
        }
    }
}
