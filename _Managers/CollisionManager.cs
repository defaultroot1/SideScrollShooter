﻿using SideScrollShooter._Models;
using SideScrollShooter._Models._Base;
using SideScrollShooter._Models.PowerUps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SideScrollShooter._Managers
{
    public static class CollisionManager
    {

        public static void Update(PlayerShip playerShip, GameManager gameManager)
        {
            PlayerProjectileHandler();
            PlayerShipPowerUpHandler(playerShip);
            PlayerShipEnemyShipHandler(playerShip, gameManager);
            EnemyProjectileHandler(playerShip, gameManager);
        }
        
        // Loop through all projectiles generated by PlayerShip and handle collision with objects
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

		public static void EnemyProjectileHandler(PlayerShip playerShip, GameManager gameManager)
		{
			foreach (var projectile in ProjectileManager.enemyProjectiles)
			{
				if (projectile.GetBounds().Intersects(playerShip.GetBounds()))
				{
					projectile.Destroy();
                    playerShip.DestroyShip();
                    gameManager.ResetGame();
                    //gameManager.ResetGame();
				}
			}
		}

		// Lopp through each PowerUp and handle collision (pickup) against PlayerShip
		public static void PlayerShipPowerUpHandler(PlayerShip playerShip)
        {
            foreach (var powerUp in PowerUpManager._powerUps)
            {
                if (powerUp.GetBounds().Intersects(playerShip.GetBounds()) && powerUp is PowerUpOrange)
                {
                    powerUp.HP--;
                    playerShip.OrangePowerUpsCollected++;
                    playerShip.IncreaseSpeed(50);
                }
            }
        }

        public static void PlayerShipEnemyShipHandler(PlayerShip playerShip, GameManager gameManager)
        {
            foreach (var swarm in EnemyManager.allEnemies)
            {
                foreach (var enemy in swarm)
                {
                    if (playerShip.GetBounds().Intersects(enemy.GetBounds()))
                    {
                        System.Diagnostics.Debug.WriteLine("HIT!");
						playerShip.DestroyShip();
						gameManager.ResetGame();
					}
                }
            }
        }
    }
}
