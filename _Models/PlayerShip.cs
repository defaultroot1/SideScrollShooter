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
            var shipTexture = Globals.ContentManger.Load<Texture2D>("Sprites/playerShipSprite3x2");

            _anims.AddAnimation(new Vector2(0, 0), new Animation(shipTexture, 2, 3, 0.1f, 1, true)); // Idle
            _anims.AddAnimation(new Vector2(1, 0), new Animation(shipTexture, 2, 3, 0.1f, 1, true)); // Right
            _anims.AddAnimation(new Vector2(-1, 0), new Animation(shipTexture, 2, 3, 0.1f, 1, true)); // Left
            _anims.AddAnimation(new Vector2(0, -1), new Animation(shipTexture, 2, 3, 0.1f, 2, false)); // Up
            _anims.AddAnimation(new Vector2(0, 1), new Animation(shipTexture, 2, 3, 0.1f, 3, false)); // Down
            _anims.AddAnimation(new Vector2(-1, -1), new Animation(shipTexture, 2, 3, 0.1f, 2, false)); // Up Left
            _anims.AddAnimation(new Vector2(1, -1), new Animation(shipTexture, 2, 3, 0.1f, 2, false)); // Up Right
            _anims.AddAnimation(new Vector2(-1, 1), new Animation(shipTexture, 2, 3, 0.1f, 3, false)); // Down Left
            _anims.AddAnimation(new Vector2(1, 1), new Animation(shipTexture, 2, 3, 0.1f, 3, false)); // Down Right
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
