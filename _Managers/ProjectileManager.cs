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
        public static List<Projectile> projectiles { get; set; } = new();

        public static void AddProjectile(Projectile projectile)
        {
            projectiles.Add(projectile);
        }

        public static void Update()
        {
            foreach (Projectile projectile in projectiles)
            {
                projectile.Update();
            }
        }

        public static void Draw()
        {
            foreach (Projectile projectile in projectiles)
            {
                projectile.Draw();
            }
        }
    }
}
