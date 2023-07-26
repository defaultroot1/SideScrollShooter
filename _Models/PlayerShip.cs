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
        private Texture2D _texture;

        public PlayerShip()
        {
            _texture = Globals.ContentManger.Load<Texture2D>("Sprites/playerShipSprite");
        }

        public void Update()
        {
            if(InputManager.Moving)
            {
                _position += Vector2.Normalize(InputManager.Direction) * _speed * Globals.ElapsedGameTimeSeconds;
            }
        }

        public void Draw()
        {
            Globals.SpriteBatch.Draw(_texture, _position, Color.White);
        }
    }
}
