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
            _backgrounds.Add(new Background(
                Globals.ContentManger.Load<Texture2D>("Background/starfield1"),
                Vector2.Zero,
                1, 100.0f, 1.0f));
            _backgrounds.Add(new Background(
                Globals.ContentManger.Load<Texture2D>("Background/starfield1"),
                new Vector2(Globals.ScreenWidth, 0),
                1, 100.0f, 1.0f));
            _backgrounds.Add(new Background(
                Globals.ContentManger.Load<Texture2D>("Background/starfield2"),
                Vector2.Zero,
                6, 50.0f, 1.0f));
            _backgrounds.Add(new Background(
                Globals.ContentManger.Load<Texture2D>("Background/starfield2"),
                new Vector2(Globals.ScreenWidth, 0),
                6, 50.0f, 1.0f));
            _backgrounds.Add(new Background(
                Globals.ContentManger.Load<Texture2D>("Background/starfield3"),
                Vector2.Zero,
                6, 10.0f, 0.5f));
            _backgrounds.Add(new Background(
                Globals.ContentManger.Load<Texture2D>("Background/starfield3"),
                new Vector2(Globals.ScreenWidth, 0),
                6, 10.0f, 0.5f));
        }

        public void Update()
        {
            foreach (var background in _backgrounds)
            {
                if (background.Position.X <= -Globals.ScreenWidth)
                {
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
