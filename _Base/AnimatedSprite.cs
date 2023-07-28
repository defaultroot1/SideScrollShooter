using SideScrollShooter._Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SideScrollShooter._Base
{
    internal class AnimatedSprite : Sprite
    {
        protected Animation _anim;
        protected int _frames;
        protected float _animationSpeed;

        public AnimatedSprite(Texture2D texture, Vector2 position, int frames, float animationSpeed=0.1f) : base(texture, position) 
        {
            _frames = frames;
            _animationSpeed = animationSpeed;
            _anim = new Animation(texture, _frames, 1, _animationSpeed);
        }

        public virtual void Update()
        {
            _anim.Update();
        }

        public override void Draw()
        {
            _anim.Draw(Position);
        }
    }
}
