using SideScrollShooter._Models;
using SideScrollShooter._Models.Enemies;
using SideScrollShooter._Models.PowerUps;
using System.Diagnostics;

namespace SideScrollShooter._Managers
{
    internal class GameManager
    {
        private BackgroundManager _backgroundManager;
        private PlayerShip _playerShip;


        public void Init() 
        {
            _backgroundManager = new BackgroundManager();
            _playerShip = new PlayerShip();
            EnemyManager.SpawnEnemySpinner(200, 5);
            EnemyManager.SpawnEnemySpinner(800, 8);

        }

        public void Update()
        {
            _backgroundManager.Update();
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
            _backgroundManager.Draw();
            ProjectileManager.Draw();
            _playerShip.Draw();
            PowerUpManager.Draw();
            EnemyManager.Draw();

        }

    }
}
