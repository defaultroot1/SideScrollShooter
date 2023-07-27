using SideScrollShooter._Models;

namespace SideScrollShooter._Managers
{
    internal class GameManager
    {
        private PlayerShip _playerShip;
        private PowerUp _powerUp;
        public void Init() 
        { 
            _playerShip = new PlayerShip();
            _powerUp = new PowerUp(new Vector2(200, 200), PowerUpColour.Orange);
        }

        public void Update()
        {
            InputManager.Update();
            _playerShip.Update();
            _powerUp.Update();
        }

        public void Draw()
        {
            _playerShip.Draw();
            _powerUp.Draw();
        }

    }
}
