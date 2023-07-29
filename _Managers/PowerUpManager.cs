using SideScrollShooter._Models._Base;
using SideScrollShooter._Models.PowerUps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SideScrollShooter._Managers
{

    public static class PowerUpManager
    {
        public static List<AnimatedSprite> _powerUps = new List<AnimatedSprite>();

        public static void AddOrangePowerUp(Vector2 position)
        {
            _powerUps.Add(new PowerUpOrange(Globals.ContentManger.Load<Texture2D>("Sprites/PowerUpOrange"),
                position, 4));
        }

        public static void AddBluePowerUp(Vector2 position)
        {
            _powerUps.Add(new PowerUpOrange(Globals.ContentManger.Load<Texture2D>("Sprites/PowerUpBlue"),
                position, 4));
        }

        public static void Update()
        {
            foreach (AnimatedSprite powerUp in _powerUps) 
            {
                powerUp.Update();
            }
        }

        public static void Draw()
        {
            foreach (AnimatedSprite powerUp in _powerUps)
            {
                powerUp.Draw();
            }
        }
    }
}
