using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SideScrollShooter._Models
{
    internal class EnemySpinner
    {
        private Texture2D _texture;
        private Animation _anim;
        private Vector2 _position = new Vector2(800, 300);
        private float _speed = 5f;

        public EnemySpinner()
        {
            _texture = Globals.ContentManger.Load<Texture2D>("Sprites/enemySpinner");
            _anim = new Animation(_texture, 3, 1, 0.1f);
        }

        public void Update()
        {
            _position = new Vector2(_position.X - _speed, _position.Y);
            _anim.Update();
        }

        public void Draw()
        {
            _anim.Draw(_position);
        }
    }
}
