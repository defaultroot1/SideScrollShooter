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
            _powerUpBlue = new PowerUpBlue(Globals.ContentManger.Load<Texture2D>("Sprites/PowerUpBlue"), 
                new Vector2(400, 400), 4);
            _powerUpOrange = new PowerUpOrange(Globals.ContentManger.Load<Texture2D>("Sprites/PowerUpOrange"),
                new Vector2(300, 300), 4);

        }

        public void Update()
        {
            InputManager.Update(_playerShip);
            ProjectileManager.Update();
            _playerShip.Update();
            _enemySpinner.Update(); 
            _powerUpBlue.Update();
            _powerUpOrange.Update();
            


        }

        public void Draw()
        {
            
            _enemySpinner.Draw();
            _powerUpBlue.Draw();
            _powerUpOrange.Draw();
            ProjectileManager.Draw();
            _playerShip.Draw();

        }

    }
}
