using SideScrollShooter._Models._Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SideScrollShooter._Models.Background
{
    internal class BackgroundPlanet : Sprite
    {
        private float _scrollSpeed;
        private Vector2 _direction = new Vector2(-1, 0);

        public BackgroundPlanet(Texture2D texture, Vector2 position) : base(texture, position)
        {
            _scrollSpeed = 20f;
        }

        public void Update()
        {
            Position += _direction * _scrollSpeed * Globals.ElapsedGameTimeSeconds;
        }


    }
}
