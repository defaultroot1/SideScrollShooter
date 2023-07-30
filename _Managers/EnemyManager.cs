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
        public static List<List<AnimatedSprite>> allEnemies = new List<List<AnimatedSprite>>();

        public static void SpawnEnemySpinner(int yAxisEntry, int numberEnemies)
        {
            List<AnimatedSprite> enemySwarm = new List<AnimatedSprite>();
            Vector2 swarmStartinPosition = new Vector2(Globals.ScreenWidth, yAxisEntry);

            for (int i = 0; i < numberEnemies; i++)
            {
                enemySwarm.Add(new EnemySpinner(Globals.ContentManger.Load<Texture2D>("Sprites/EnemySpinner"),
                    new Vector2(Globals.ScreenWidth + (60 * i), yAxisEntry),
                    new Vector2(Globals.ScreenWidth, yAxisEntry),
                    3));
            }

            allEnemies.Add(enemySwarm);

        }

        public static void Update()
        {
            Vector2 lastPosition = new Vector2();

            foreach (var swarm in allEnemies)
            {
                foreach (var enemy in swarm)
                {
                    enemy.Update();
                    lastPosition = enemy.Position;
                }

                swarm.RemoveAll((enemy) => enemy.HP <= 0);
                if (swarm.Count <= 0)
                {
                    PowerUpManager.AddOrangePowerUp(lastPosition);
                }


            }
            allEnemies.RemoveAll((swarm) => swarm.Count <= 0);
            System.Diagnostics.Debug.WriteLine($"Swarms: {allEnemies.Count}");

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
