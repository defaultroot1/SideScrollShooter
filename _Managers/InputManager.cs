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
        public static bool Moving => Direction != Vector2.Zero; // When direction is not zero, Moving = true;

        public static void Update()
        {
            Direction = Vector2.Zero; // Reset direction to zero each frame
            KeyboardState keyboardState = Keyboard.GetState();

            if (keyboardState.GetPressedKeyCount() > 0)
            {
                if (keyboardState.IsKeyDown(Keys.A)) Direction.X--;
                if (keyboardState.IsKeyDown(Keys.D)) Direction.X++;
                if (keyboardState.IsKeyDown(Keys.W)) Direction.Y--;
                if (keyboardState.IsKeyDown(Keys.S)) Direction.Y++;
            }
        }
    }
}
