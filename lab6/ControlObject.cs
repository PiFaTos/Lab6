using Lab6;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Lab6
{
    public class ControlObject : AgileObject
    {
        public ControlObject(Vector2 position, Texture2D texture, Vector2 speed)
            : base(position, texture, speed) { }

        // Переопределение метода Update для управления объектом
        public override void Update(GameTime gameTime)
        {
            // Получение текущего состояния клавиатуры
            KeyboardState keyboardState = Keyboard.GetState();

            // Проверка нажатий клавиш и изменение координат объекта
            if (keyboardState.IsKeyDown(Keys.Left))
            {
                Position = new Vector2(Position.X - Speed.X, Position.Y);
            }

            if (keyboardState.IsKeyDown(Keys.Right))
            {
                Position = new Vector2(Position.X + Speed.X, Position.Y);
            }

            if (keyboardState.IsKeyDown(Keys.Up))
            {
                Position = new Vector2(Position.X, Position.Y - Speed.Y);
            }

            if (keyboardState.IsKeyDown(Keys.Down))
            {
                Position = new Vector2(Position.X, Position.Y + Speed.Y);
            }
        }
    }
}