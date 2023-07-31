using SideScrollShooter._Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SideScrollShooter._Models._Base
{
    public class AnimatedSprite : Sprite
    {
        public Animation Anim;
        protected int _frames;
        protected float _animationSpeed;
        public int Width { get; protected set; }    
        public int Height { get; protected set; }
        public int HP = 1;
        public bool DropsPowerUp { get; set; } = false;
        public float Rotation { get; set; }
        public int Points { get; protected set; }

		public AnimatedSprite(Texture2D texture, Vector2 position, int frames, bool loop, float animationSpeed = 0.1f) : base(texture, position)
        {
            _frames = frames;
            _animationSpeed = animationSpeed;
            Anim = new Animation(texture, _frames, 1, _animationSpeed, loop);
            Width = texture.Width / frames;
            Height = texture.Height;
            Points = 0;
        }

        public override Rectangle GetBounds()
        {
            return new Rectangle((int)Position.X, (int)Position.Y, Width, Height);
        }

        public virtual void Update()
        {
            Anim.Update();
        }

		public override void Draw()
        {
            Anim.Draw(Position, Rotation);
        }
    }
}
