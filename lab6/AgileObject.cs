using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Lab6;
namespace Lab6
{
    public class AgileObject : GameObject
    {
        protected Vector2 speed; // Скорость

        public AgileObject(Vector2 position, Texture2D texture, Vector2 speed)
            : base(position, texture)
        {
            Speed = speed;
        }

        // Переопределение метода Update из базового класса
        public override void Update(GameTime gameTime)
        {
            // Размеры экрана
            const int ScreenWidth = 1600;
            const int ScreenHeight = 900;

            // Обновление позиции
            Position += Speed * 5;

            // Проверка границ экрана и изменение направления при столкновении
            if (Position.X < 0 || Position.X + Texture.Width > ScreenWidth)
            {
                Speed = new Vector2(-Speed.X, Speed.Y); // Изменение направления по X
            }

            if (Position.Y < 0 || Position.Y + Texture.Height > ScreenHeight)
            {
                Speed = new Vector2(Speed.X, -Speed.Y); // Изменение направления по Y
            }
        }

        // Свойство для скорости
        public Vector2 Speed
        {
            get => speed;
            set => speed = value;
        }
    }
}