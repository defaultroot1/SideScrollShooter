using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SideScrollShooter._Models._Base
{
    public class Projectile : Sprite
    {
        public Vector2 Direction { get; set; }
        public float Speed { get; set; }
        public int Damage { get; set; }

        public Projectile(Texture2D texture, Vector2 position, Vector2 direction, float speed, int damage) : base(texture, position)
        {
            _texture = texture;
            Position = position;
            Direction = direction;
            Speed = speed;
            Damage = damage;
        }

        public void Update()
        {
            Position += Direction * Speed * Globals.ElapsedGameTimeSeconds;
        }

    }
}
