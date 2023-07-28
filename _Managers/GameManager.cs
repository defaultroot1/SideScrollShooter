using SideScrollShooter._Models;

namespace SideScrollShooter._Managers
{
    internal class GameManager
    {
        private PlayerShip _playerShip;
        private PowerUpOrange _powerUp;
        private EnemySpinner _enemySpinner;

        public void Init() 
        { 
            _playerShip = new PlayerShip();
            _powerUp = new PowerUpOrange(new Vector2(200, 200));
            _enemySpinner = new EnemySpinner();

        }

        public void Update()
        {
            InputManager.Update();
            _playerShip.Update();
            _powerUp.Update();
            _enemySpinner.Update(); 

        }

        public void Draw()
        {
            _playerShip.Draw();
            _powerUp.Draw();
            _enemySpinner.Draw();

        }

    }
}
