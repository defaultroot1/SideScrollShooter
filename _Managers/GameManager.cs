using SideScrollShooter._Models;
using SideScrollShooter._Models.Enemies;
using SideScrollShooter._Models.PowerUps;

namespace SideScrollShooter._Managers
{
    internal class GameManager
    {
        private PlayerShip _playerShip;
        private EnemySpinner _enemySpinner;
        private PowerUpBlue _powerUpBlue;
        private PowerUpOrange _powerUpOrange;

        public void Init() 
        { 
            _playerShip = new PlayerShip();
            EnemyManager.SpawnEnemySpinner(200);

        }

        public void Update()
        {
            InputManager.Update(_playerShip);
            ProjectileManager.Update();
            _playerShip.Update();
            PowerUpManager.Update();
            EnemyManager.Update();
            CollisionManager.Update();


        }

        public void Draw()
        {
            
            ProjectileManager.Draw();
            _playerShip.Draw();
            PowerUpManager.Draw();
            EnemyManager.Draw();

        }

    }
}
