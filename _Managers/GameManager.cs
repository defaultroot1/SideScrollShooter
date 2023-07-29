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
            _enemySpinner = new EnemySpinner(Globals.ContentManger.Load<Texture2D>("Sprites/EnemySpinner"),
                new Vector2(500, 500), 3);

        }

        public void Update()
        {
            InputManager.Update(_playerShip);
            ProjectileManager.Update();
            _playerShip.Update();
            _enemySpinner.Update(); 
            PowerUpManager.Update();
            


        }

        public void Draw()
        {
            
            _enemySpinner.Draw();
            ProjectileManager.Draw();
            _playerShip.Draw();
            PowerUpManager.Draw();

        }

    }
}
