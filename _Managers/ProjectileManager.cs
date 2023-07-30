using SideScrollShooter._Models._Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SideScrollShooter._Managers
{
    public class ProjectileManager
    {
        public static List<Projectile> playerProjectiles { get; set; } = new();
        public static List<Projectile> enemyProjectiles { get; set; } = new();

        public static void AddPlayerProjectile(Projectile projectile)
        {
            playerProjectiles.Add(projectile);
        }

        public static void AddEnemyProjectile(Projectile projectile)
        {
            enemyProjectiles.Add(projectile);
        }

        public static void Update()
        {
            foreach (Projectile projectile in playerProjectiles)
            {
                projectile.Update();
            }

            foreach (Projectile projectile in enemyProjectiles)
            {
                projectile.Update();
            }

            // For any projectiles that have reached their lifespan, remove them
            playerProjectiles.RemoveAll((p) => p.lifespan <= 0);
            enemyProjectiles.RemoveAll((p) => p.lifespan <= 0);
        }

        public static void Draw()
        {
            foreach (Projectile projectile in playerProjectiles)
            {
                projectile.Draw();
            }
            foreach (Projectile projectile in enemyProjectiles)
            {
                projectile.Draw();
            }

        }
    }
}
