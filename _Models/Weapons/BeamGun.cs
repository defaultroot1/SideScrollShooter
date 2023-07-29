using SideScrollShooter._Managers;
using SideScrollShooter._Models._Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SideScrollShooter._Models.Weapons
{
    public class BeamGun : Weapon
    {

        public BeamGun()
        {
            cooldown = 0.1f;

        }

        protected override void CreateProjectile(PlayerShip playerShip)
        {
            ProjectileManager.AddProjectile(new Projectile(Globals.ContentManger.Load<Texture2D>("Sprites/beam"),
                new Vector2(playerShip.Position.X + playerShip.Width / 2, playerShip.Position.Y + playerShip.Height / 2), 
                playerShip.DirectionFacing, 1000f, 1));
        }

        public void Fire(PlayerShip playerShip)
        {
            CreateProjectile(playerShip);
        }
    }
}
