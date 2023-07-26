using Microsoft.Xna.Framework.Content;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SideScrollShooter
{
    public static class Globals
    {
        public static ContentManager ContentManger { get; set; }
        public static SpriteBatch SpriteBatch { get; set; }
        public static float ElapsedGameTimeSeconds { get; set; }

        public static void UpdateElapsedGameTime(GameTime gameTime)
        {
            ElapsedGameTimeSeconds = (float)gameTime.ElapsedGameTime.TotalSeconds;
        }
    }
}
