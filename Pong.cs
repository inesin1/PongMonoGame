using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace PongMonoGame
{
    public class Pong : Game
    {
        private GraphicsDeviceManager _graphics;    // Менеджер для работы с графикой
        private SpriteBatch _spriteBatch;           // Объект для работы со спрайтами 

        // Игровые объекты
        private Ball _ball = new Ball();            // Мяч
        private Bat _batL = new Bat("left");        // Левая ракетка
        private Bat _batR = new Bat("right");       // Правая ракетка

        public Pong()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        /// <summary>
        /// Инициализация
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
        }

        /// <summary>
        /// Загрузка контента
        /// </summary>
        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);


        }

        /// <summary>
        /// Обновление игровых объектов
        /// </summary>
        /// <param name="gameTime">Игровое время</param>
        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        /// <summary>
        /// Отрисовка игровых объектов
        /// </summary>
        /// <param name="gameTime">Игровое время</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Black);

            _spriteBatch.Begin();



            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
