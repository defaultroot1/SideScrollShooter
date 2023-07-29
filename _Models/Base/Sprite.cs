using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SideScrollShooter._Models._Base
{
    public class Sprite
    {
        protected Texture2D _texture;
        public Vector2 Position { get; set; }

        public Sprite(Texture2D texture, Vector2 position)
        {
            _texture = texture;
            Position = position;
        }

        public virtual void Draw()
        {
            Globals.SpriteBatch.Draw(_texture, Position, Color.White);
        }
    }
}
