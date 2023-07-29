using SideScrollShooter._Models._Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SideScrollShooter._Models.Enemies
{
    public class EnemySpinner : AnimatedSprite
    {
        private float _speed = 200;
        public float LifeTime { get; set; } = 0;
        public Vector2 Direction = new Vector2(-1, 0);
        private int moveStage = 0;
        public EnemySpinner(Texture2D texture, Vector2 position, int frames) : base(texture, position, frames) 
        {
        }

        public override void Update()
        {
            base.Update();

            if (moveStage == 0)
            {
                // Stage 0: Move from right to left

                if (Position.X <= Globals.ScreenWidth - 500)
                {
                    // Switch to Stage 1 when close to the left edge
                    Direction = new Vector2(1, 1);
                    moveStage = 1;
                }
            }
            else if (moveStage == 1)
            {
                // Stage 1: Move diagonally right

                if (Position.Y >= Globals.ScreenHeight - 600)
                {
                    // Switch to Stage 2 when close to the bottom edge
                    Direction = new Vector2(1, 0);
                    moveStage = 2;
                }
            }
            else if (moveStage == 2)
            {
                // Stage 2: Move from left to right

                if (Position.X >= Globals.ScreenWidth)
                {
                    // Switch to Stage 3 when off the right edge
                    Direction = new Vector2(-1, 0);
                    moveStage = 3;
                }
            }
            else if (moveStage == 3)
            {
                // Stage 3: Move from right to left

                if (Position.X <= Globals.ScreenWidth - 300)
                {
                    // Switch back to Stage 0 when close to the left edge
                    Direction = new Vector2(1, 0);
                    moveStage = 0;
                }
            }

            Position += Direction * Globals.ElapsedGameTimeSeconds * _speed;
            LifeTime += Globals.ElapsedGameTimeSeconds;

        }

    }
}
