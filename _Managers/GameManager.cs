﻿using SideScrollShooter._Models;
using SideScrollShooter._Models.Enemies;
using SideScrollShooter._Models.FX;
using SideScrollShooter._Models.PowerUps;
using System.Diagnostics;

namespace SideScrollShooter._Managers
{
    public class GameManager
    {
        private BackgroundManager _backgroundManager;
        private PlayerShip _playerShip;
        private GUI _gui;


        public void Init() 
        {
            _backgroundManager = new BackgroundManager();
            _playerShip = new PlayerShip();
            _gui = new GUI();
            ScoreManager.LoadHighScore();

            //EnemyManager.SpawnEnemySpinner(200, 5);
            //EnemyManager.SpawnEnemySpinner(800, 8);
            //EnemyManager.SpawnEnemySeeker(500);
            //EnemyManager.SpawnEnemyRoller(300);

		}

        public void Update()
        {
            _backgroundManager.Update();
            InputManager.Update(_playerShip);
            ProjectileManager.Update();
            _playerShip.Update();
            PowerUpManager.Update();
            EnemyManager.Update();
			CollisionManager.Update(_playerShip, this);
			ScoreManager.Update();
            FXManager.Update();
			

		}

        public void Draw()
        {   
            _backgroundManager.Draw();
            ProjectileManager.Draw();
            _playerShip.Draw();
            PowerUpManager.Draw();
            EnemyManager.Draw();
            FXManager.Draw();
            _gui.Draw();

        }

        public void ResetGame()
        {
            ScoreManager.score = 0;
            _playerShip.ResetPosition();
            EnemyManager.ClearAllEnemies();
        }

    }
}
