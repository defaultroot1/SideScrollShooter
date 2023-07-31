using SideScrollShooter._Models._Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SideScrollShooter._Models.Enemies
{
    public class EnemySpinner : AnimatedSprite
    {
        private float _speed = 200;
        public float LifeTime { get; set; } = 0;
        public Vector2 Direction = new Vector2(-1, 0);
        public Vector2 Destination = new Vector2(100, 200);
        private Vector2 _startingPosition = new Vector2(0, 0);
        private List<Vector2> _waypoints = new List<Vector2>();
        private int _currentWaypointIndex = 0;

		public EnemySpinner(Texture2D texture, Vector2 position, Vector2 startingPosition, int frames, bool loop) : base(texture, position, frames, loop) 
        {
            _startingPosition = startingPosition;
            InitWaypoints();
            DropsPowerUp = true; // Swarms of this enemy type will drop a powerup when completely destroyed
            Points = 10;
            
        }

        public override void Update()
        {
            base.Update();

            if (_currentWaypointIndex < _waypoints.Count)
            {
                Vector2 targetWaypoint = _waypoints[_currentWaypointIndex];

                // Calculate the direction vector towards the target waypoint
                Vector2 direction = Vector2.Normalize(targetWaypoint - Position);

                // Move towards the waypoint
                Position += direction * _speed * Globals.ElapsedGameTimeSeconds;

                // Check if the enemy has reached the waypoint
                if (Vector2.Distance(Position, targetWaypoint) < _speed * Globals.ElapsedGameTimeSeconds)
                {
                    // If reached, move to the next waypoint
                    _currentWaypointIndex++;
                }

            }

            LifeTime += Globals.ElapsedGameTimeSeconds;
        }

        public void InitWaypoints()
        {
            List<Vector2> relativeWaypoints = new List<Vector2>();
            Vector2 previousPosition = _startingPosition;

            if (_startingPosition.Y < Globals.ScreenHeight / 2)
            {
                relativeWaypoints.Add(new Vector2(-500, 0));    // Move left
                relativeWaypoints.Add(new Vector2(60, 60));   // Move down-right
                relativeWaypoints.Add(new Vector2(-500, 0));    // Move left
                relativeWaypoints.Add(new Vector2(60, 60));   // Move down-right
                relativeWaypoints.Add(new Vector2(-1000, 0));   // Move left (off screen)
            }
            else
            {
                relativeWaypoints.Add(new Vector2(-500, 0));    // Move left
                relativeWaypoints.Add(new Vector2(60, -60));   // Move up-right
                relativeWaypoints.Add(new Vector2(-500, 0));    // Move left
                relativeWaypoints.Add(new Vector2(60, -60));   // Move down-right
                relativeWaypoints.Add(new Vector2(-1000, 0));   // Move left (off screen)
            }



            foreach (var waypoint in relativeWaypoints)
            {
                Vector2 nextWaypoint = new Vector2(previousPosition.X + waypoint.X, previousPosition.Y + waypoint.Y);
                _waypoints.Add(nextWaypoint);
                previousPosition = nextWaypoint;
                
            }

        }

    }
}
