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

        public static void Update()
        {
            PlayerProjectileHandler();
        }

        public static void PlayerProjectileHandler()
        {
            foreach (var projectile in ProjectileManager.playerProjectiles)
            {
                foreach (var enemy in EnemyManager.enemies)
                {
                    if(projectile.GetBounds().Intersects(enemy.GetBounds()))
                    {
                        enemy.HP -= projectile.Damage;
                        projectile.Destroy();
                    }
                }
            }
        }
    }
}
