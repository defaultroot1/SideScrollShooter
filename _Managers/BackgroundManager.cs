using SideScrollShooter._Models;
using SideScrollShooter._Models._Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SideScrollShooter._Managers
{
    internal class BackgroundManager
    {
        private List<Background> _backgrounds = new List<Background>();

        public BackgroundManager()
        {
            // Create 3 layers of background at different speeds. Each layer is duplicated to allow looping
            _backgrounds.Add(new Background(
                Globals.ContentManger.Load<Texture2D>("Background/starfield1"),
                Vector2.Zero,
                1, 80.0f, true, 1.0f));
            _backgrounds.Add(new Background(
                Globals.ContentManger.Load<Texture2D>("Background/starfield1"),
                new Vector2(Globals.ScreenWidth, 0),
                1, 80.0f, true, 1.0f));

            _backgrounds.Add(new Background(
                Globals.ContentManger.Load<Texture2D>("Background/starfield2"),
                Vector2.Zero,
                6, 50.0f, true, 1.0f));
            _backgrounds.Add(new Background(
                Globals.ContentManger.Load<Texture2D>("Background/starfield2"),
                new Vector2(Globals.ScreenWidth, 0),
                6, 50.0f, true, 1.0f));

            _backgrounds.Add(new Background(
                Globals.ContentManger.Load<Texture2D>("Background/starfield3"),
                Vector2.Zero,
                6, 10.0f, true, 0.5f));
            _backgrounds.Add(new Background(
                Globals.ContentManger.Load<Texture2D>("Background/starfield3"),
                new Vector2(Globals.ScreenWidth, 0),
                6, 10.0f, true, 0.5f));
        }

        public void Update()
        {
            foreach (var background in _backgrounds)
            {
                if (background.Position.X <= -Globals.ScreenWidth)
                {
                    // When background reaches end of left screen, reposition it back to right for looping
                    background.Position = new Vector2(Globals.ScreenWidth, 0);
                }
                background.Update();
            }
        }

        public void Draw()
        {
            foreach (var background in _backgrounds)
            {
                background.Draw();
            }
        }


    }
}
