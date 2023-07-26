using SideScrollShooter._Models;

namespace SideScrollShooter._Managers
{
    internal class GameManager
    {
        private PlayerShip _playerShip;
        public void Init() 
        { 
            _playerShip = new PlayerShip();
        }

        public void Update()
        {
            InputManager.Update();
            _playerShip.Update();
        }

        public void Draw()
        {
            _playerShip.Draw();
        }

    }
}
