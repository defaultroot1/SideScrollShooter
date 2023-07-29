using SideScrollShooter._Managers;
using SideScrollShooter._Models.Weapons;
using SideScrollShooter._Models._Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SideScrollShooter._Models
{
    public class PlayerShip
    {
        public Vector2 Position = new Vector2(100, 100);
        private float _speed = 600f;
        private AnimationManager _anims = new AnimationManager();
        public Texture2D Texture;
        public Vector2 DirectionFacing = new Vector2(1, 0);
        public Weapon Weapon;
        public LaserGun LaserGun = new LaserGun();
        public BeamGun BeamGun = new BeamGun();
        public int Width;
        public int Height;

        public PlayerShip()
        {
            Texture = Globals.ContentManger.Load<Texture2D>("Sprites/playerShipSprite3x2");

            _anims.AddAnimation(new Vector2(0, 0), new Animation(Texture, 2, 3, 0.1f, 1, true)); // Idle
            _anims.AddAnimation(new Vector2(1, 0), new Animation(Texture, 2, 3, 0.1f, 1, true)); // Right
            _anims.AddAnimation(new Vector2(-1, 0), new Animation(Texture, 2, 3, 0.1f, 1, true)); // Left
            _anims.AddAnimation(new Vector2(0, -1), new Animation(Texture, 2, 3, 0.1f, 2, false)); // Up
            _anims.AddAnimation(new Vector2(0, 1), new Animation(Texture, 2, 3, 0.1f, 3, false)); // Down
            _anims.AddAnimation(new Vector2(-1, -1), new Animation(Texture, 2, 3, 0.1f, 2, false)); // Up Left
            _anims.AddAnimation(new Vector2(1, -1), new Animation(Texture, 2, 3, 0.1f, 2, false)); // Up Right
            _anims.AddAnimation(new Vector2(-1, 1), new Animation(Texture, 2, 3, 0.1f, 3, false)); // Down Left
            _anims.AddAnimation(new Vector2(1, 1), new Animation(Texture, 2, 3, 0.1f, 3, false)); // Down Right

            Width = Texture.Width / 2;
            Height = Texture.Height / 3;

            Weapon = LaserGun;

        }

        public void Update()
        {
            if(InputManager.Moving)
            {
                Position += Vector2.Normalize(InputManager.Direction) * _speed * Globals.ElapsedGameTimeSeconds;
            }

            _anims.Update(InputManager.Direction);

            if(InputManager.SpacePressed)
            {
                Weapon.Fire(this);
            }
        }

        public void Draw()
        {
            _anims.Draw(Position);
        }

        public void ActivateBeamGun()
        {
            Weapon = BeamGun;
        }

        public void ActivateLaserGun()
        {
            Weapon = LaserGun;
        }

    }
}
