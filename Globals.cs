﻿using Microsoft.Xna.Framework.Content;
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
        public static int ScreenWidth;
        public static int ScreenHeight;
        public static int PlayerWidth;
        public static int PlayerHeight;
        public static float globalScrollSpeed = 100.0f;
        public static Vector2 playerPosition;

        public static void UpdateElapsedGameTime(GameTime gameTime)
        {
            ElapsedGameTimeSeconds = (float)gameTime.ElapsedGameTime.TotalSeconds;
        }
    }
}
