using SideScrollShooter._Models;
using SideScrollShooter._Models.Enemies;
using SideScrollShooter._Models.PowerUps;
using System.Diagnostics;

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
            EnemyManager.SpawnEnemySpinner(200, 5);
            EnemyManager.SpawnEnemySpinner(800, 8);

        }

        public void Update()
        {
            InputManager.Update(_playerShip);
            ProjectileManager.Update();
            _playerShip.Update();
            PowerUpManager.Update();
            EnemyManager.Update();
            CollisionManager.Update(_playerShip);

            Debug.WriteLine(_playerShip.OrangePowerUpsCollected);

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
