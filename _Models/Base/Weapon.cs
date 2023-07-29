using SideScrollShooter._Managers;
using SideScrollShooter._Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SideScrollShooter._Models._Base
{
    public abstract class Weapon
    {
        protected float cooldown;
        protected float cooldownLeft;

        protected Weapon()
        {
            cooldownLeft = 0f;
        }

        protected abstract void CreateProjectile(PlayerShip playerShip);

        public virtual void Fire(PlayerShip playerShip)
        {
            CreateProjectile(playerShip);
        }
    }


}
