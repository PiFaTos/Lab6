using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Lab6;
namespace Lab6
{
    public class GameObject
    {
        // Поля
        protected Vector2 position; // Координаты
        protected Texture2D texture; // Текстура

        // Конструктор
        public GameObject(Vector2 position, Texture2D texture)
        {
            Position = position;
            Texture = texture;
        }

        // Метод для отрисовки объекта
        public virtual void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(Texture, Position, Color.White);
        }

        // Метод для обновления состояния объекта
        public virtual void Update(GameTime gameTime)
        {
            // Пустой метод для переопределения в потомках
        }

        // Свойства
        public Vector2 Position
        {
            get => position;
            set => position = value;
        }

        public Texture2D Texture
        {
            get => texture;
            set => texture = value;
        }
    }
}