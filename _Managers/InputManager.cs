using SideScrollShooter._Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SideScrollShooter._Managers
{
    public static class InputManager
    {
        public static Vector2 Direction;
        public static bool SpacePressed;
        public static bool Moving => Direction != Vector2.Zero; // When direction is not zero, Moving = true;
        private static KeyboardState _lastKeyboardState;

        public static void Update(PlayerShip playerShip)
        {
            Direction = Vector2.Zero; // Reset direction to zero each frame
            KeyboardState keyboardState = Keyboard.GetState();

            if (keyboardState.GetPressedKeyCount() > 0)
            {
                if (keyboardState.IsKeyDown(Keys.A)) Direction.X--;
                if (keyboardState.IsKeyDown(Keys.D)) Direction.X++;
                if (keyboardState.IsKeyDown(Keys.W)) Direction.Y--;
                if (keyboardState.IsKeyDown(Keys.S)) Direction.Y++;

                if (keyboardState.IsKeyDown(Keys.D1)) playerShip.ActivateLaserGun();
                if (keyboardState.IsKeyDown(Keys.D2)) playerShip.ActivateBeamGun();

                SpacePressed = keyboardState.IsKeyDown(Keys.Space) && _lastKeyboardState.IsKeyUp(Keys.Space);
            }
            _lastKeyboardState = keyboardState;
        }
    }
}
