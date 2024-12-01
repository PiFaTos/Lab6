using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;
using SpriteBatch = Microsoft.Xna.Framework.Graphics.SpriteBatch;
using Lab6;

namespace lab6
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch spriteBatch;
        private List<GameObject> gameObjects;
        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";

            this._graphics.PreferredBackBufferWidth = 1600;  // Ширина окна
            this._graphics.PreferredBackBufferHeight = 900; // Высота окна
            gameObjects = new List<GameObject>();

            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
        }

        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
            Texture2D stationaryTexture = Content.Load<Texture2D>("AK");
            Texture2D movingTexture = Content.Load<Texture2D>("airplane");
            Texture2D playerTexture = Content.Load<Texture2D>("cloud");

            // Создаём объекты
            GameObject stationary = new GameObject(new Vector2(100, 100), stationaryTexture);
            AgileObject moving = new AgileObject(new Vector2(200, 200), movingTexture, new Vector2(1, 0));
            ControlObject player = new ControlObject(new Vector2(300, 300), playerTexture, new Vector2(2, 2));

            // Добавляем их в список
            gameObjects.Add(stationary);
            gameObjects.Add(moving);
            gameObjects.Add(player);

        }

        protected override void Update(GameTime gameTime)
        {
            foreach (var obj in gameObjects)
            {
                obj.Update(gameTime);
            }

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Microsoft.Xna.Framework.Color.CornflowerBlue);

            // TODO: Add your drawing code here
            spriteBatch.Begin();
            foreach (var obj in gameObjects)
            {
                obj.Draw(spriteBatch);
            }
            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}