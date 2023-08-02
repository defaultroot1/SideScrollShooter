using SideScrollShooter._Models._Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SideScrollShooter._Models.Enemies;

namespace SideScrollShooter._Managers
{
    public static class EnemyManager
    {
        // A List holding Lists of enemySwarms
        public static List<List<AnimatedSprite>> allEnemies = new List<List<AnimatedSprite>>();
        public static float EnemySeekerSpawnRate = 5f; // Spawns every x seconds
        public static float EnemySeekerSpawnTimer = 0f;
        public static int EnemySeekerSpawnNumber = 3; // How many spawn each time
		public static float EnemySpinnerSpawnRate = 5f; // Spawns every x seconds
		public static float EnemySpinnerSpawnTimer = 0f;
		public static int EnemySpinnerSpawnNumber = 1; // How many spawn each time
		public static float EnemyRollerSpawnRate = 10f; // Spawns every x seconds
		public static float EnemyRollerSpawnTimer = 0f;
		public static int EnemyRollerSpawnNumber = 5; // How many spawn each time

		public static void SpawnEnemySpinner(int yAxisEntry, int numberEnemies)
        {
            // Each group of enemies is added to a swarm List, which in turn is added to the allEnemies List
            // This lets us track if the player has destroyed all enemies in a single swarm, which results in a PowerUp
            List<AnimatedSprite> enemySwarm = new List<AnimatedSprite>();

            // Hold the swarm's starting position so that waypoints can be reached by individual enemies
            Vector2 swarmStartinPosition = new Vector2(Globals.ScreenWidth, yAxisEntry);

            // Generate the swarm
            for (int i = 0; i < numberEnemies; i++)
            {
                enemySwarm.Add(new EnemySpinner(Globals.ContentManger.Load<Texture2D>("Sprites/EnemySpinner"),
                    new Vector2(Globals.ScreenWidth + (60 * i), yAxisEntry),
                    new Vector2(Globals.ScreenWidth, yAxisEntry),
                    3, true));
            }

            allEnemies.Add(enemySwarm);

        }

        public static void SpawnEnemySeeker(int yAxisEntry)
        {

			List<AnimatedSprite> enemySwarm = new List<AnimatedSprite>();

			enemySwarm.Add(new EnemySeeker(Globals.ContentManger.Load<Texture2D>("Sprites/EnemySeeker"),
					new Vector2(Globals.ScreenWidth + 50, yAxisEntry),
					1, true));

            allEnemies.Add(enemySwarm);
		}

		public static void SpawnEnemyRoller(int yAxisEntry)
		{

			List<AnimatedSprite> enemySwarm = new List<AnimatedSprite>();

			enemySwarm.Add(new EnemyRoller(Globals.ContentManger.Load<Texture2D>("Sprites/EnemyRoller"),
					new Vector2(Globals.ScreenWidth - 100, yAxisEntry),
					6, true));

			allEnemies.Add(enemySwarm);
		}

		public static void Update()
        {
            // Hold the position of each enemy so that when last enemy is destroyed the PowerUp can be generated in correct position
            Vector2 lastPosition = new Vector2();
            bool dropsPowerUp = false;

            foreach (var swarm in allEnemies)
            {
                foreach (var enemy in swarm)
                {
                    enemy.Update();
                    lastPosition = enemy.Position;
                    dropsPowerUp = enemy.DropsPowerUp;
                    if (enemy.HP <= 0)
                    {
						ScoreManager.score += enemy.Points;

                        switch (enemy.GetType().Name)
                        {
                            case "EnemySpinner":
                                FXManager.SpawnSpinnerExplosion(enemy.Position);
                                break;
							case "EnemySeeker":
								FXManager.SpawnSmokeyExplosion(enemy.Position);
								break;
							case "EnemyRoller":
								FXManager.SpawnSmokeyExplosion(enemy.Position);
								break;
						}
                        
					}
                
                }

                // For any enemies that were damaged this frame, remove them
                swarm.RemoveAll((enemy) => enemy.HP <= 0);

                // If the swarm has no objects left, all enemise in swarm were destroyed, so generated a PowerUp
                if (swarm.Count <= 0 && dropsPowerUp)
                {
                    PowerUpManager.AddOrangePowerUp(lastPosition);
                }



            }

            // Remove any empty swarms from allEnemies
            allEnemies.RemoveAll((swarm) => swarm.Count <= 0);


            EnemySeekerSpawnTimer += Globals.ElapsedGameTimeSeconds;
			EnemySpinnerSpawnTimer += Globals.ElapsedGameTimeSeconds;
			EnemyRollerSpawnTimer += Globals.ElapsedGameTimeSeconds;

			// Spawn enemies based on time elapsed
			if (EnemySeekerSpawnTimer >= EnemySeekerSpawnRate)
            {
                Random rand = new Random();
                for (int i = 0; i < EnemySeekerSpawnNumber; i++)
                {
					SpawnEnemySeeker(rand.Next(200, Globals.ScreenHeight - 200));
					
				}
				EnemySeekerSpawnTimer = 0;
			}

			if (EnemySpinnerSpawnTimer >= EnemySpinnerSpawnRate)
			{
				Random rand = new Random();
				for (int i = 0; i < EnemySpinnerSpawnNumber; i++)
				{
					SpawnEnemySpinner(rand.Next(200, Globals.ScreenHeight - 200), 6);

				}
				EnemySpinnerSpawnTimer = 0;
			}

			if (EnemyRollerSpawnTimer >= EnemyRollerSpawnRate)
			{
				Random rand = new Random();
				for (int i = 0; i < EnemyRollerSpawnNumber; i++)
				{
					SpawnEnemyRoller(rand.Next(200, Globals.ScreenHeight - 200));

				}
				EnemyRollerSpawnTimer = 0;
			}

		}

        public static void Draw()
        {
            foreach (var swarm in allEnemies)
            {
                foreach (var enemy in swarm)
                    enemy.Draw();

            }
        }
    }
}
