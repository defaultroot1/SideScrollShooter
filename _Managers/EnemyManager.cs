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
        public static List<AnimatedSprite> enemies = new List<AnimatedSprite>();

        public static void SpawnEnemySpinner(int yAxisEntry)
        {
            for(int i = 0; i < 5 ; i++)
            {
                enemies.Add(new EnemySpinner(Globals.ContentManger.Load<Texture2D>("Sprites/EnemySpinner"), 
                    new Vector2(Globals.ScreenWidth + (60 * i), yAxisEntry),
                    3));
            }
            
        }

        public static void Update()
        {
            foreach(var enemy in enemies)
            {
                enemy.Update();
            }

            enemies.RemoveAll((e) => e.HP <= 0);
        }

        public static void Draw()
        {
            foreach (var enemy in enemies)
            {
                enemy.Draw();
            }
        }
    }
}
