using SideScrollShooter._Models;
using SideScrollShooter._Models._Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SideScrollShooter._Managers
{
    public static class CollisionManager
    {

        public static void Update(PlayerShip playerShip)
        {
            PlayerProjectileHandler();
            PlayerShipPowerUpHandler(playerShip);
        }

        public static void PlayerProjectileHandler()
        {
            foreach (var projectile in ProjectileManager.playerProjectiles)
            {
                foreach (var swarm in EnemyManager.allEnemies)
                {
                    foreach (var enemy in swarm) 
                    {
                        if (projectile.GetBounds().Intersects(enemy.GetBounds()))
                        {
                            enemy.HP -= projectile.Damage;
                            projectile.Destroy();
                        }
                    }

                }
            }
        }

        public static void PlayerShipPowerUpHandler(PlayerShip playerShip)
        {
            foreach (var powerUp in PowerUpManager._powerUps)
            {
                if (powerUp.GetBounds().Intersects(playerShip.GetBounds()))
                {
                    powerUp.HP--;
                    playerShip.OrangePowerUpsCollected++;
                }
            }
        }
    }
}
