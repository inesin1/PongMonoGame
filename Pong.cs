using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace PongMonoGame
{
    public class Pong : Game
    {
        private GraphicsDeviceManager _graphics;    // Менеджер для работы с графикой
        public SpriteBatch SpriteBatch;             // Объект для работы со спрайтами 

        // Игровые объекты
        public Ball Ball;   // Мяч
        public Bat BatL;    // Левая ракетка
        public Bat BatR;    // Правая ракетка

        public Pong()
        {
            _graphics = new GraphicsDeviceManager(this);
            _graphics.PreferredBackBufferWidth = Variables.SCREEN_WIDTH;
            _graphics.PreferredBackBufferHeight = Variables.SCREEN_HEIGHT;
            _graphics.ApplyChanges();

            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        /// <summary>
        /// Инициализация
        /// </summary>
        protected override void Initialize()
        {
            Ball = new Ball(this);
            BatL = new Bat(this, "left");
            BatR = new Bat(this, "right");

            BatL.Init();
            BatR.Init();

            base.Initialize();
        }

        /// <summary>
        /// Загрузка контента
        /// </summary>
        protected override void LoadContent()
        {
            SpriteBatch = new SpriteBatch(GraphicsDevice);


        }

        /// <summary>
        /// Обновление игровых объектов
        /// </summary>
        /// <param name="gameTime">Игровое время</param>
        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            BatR.Update((float)gameTime.ElapsedGameTime.TotalSeconds);

            base.Update(gameTime);
        }

        /// <summary>
        /// Отрисовка игровых объектов
        /// </summary>
        /// <param name="gameTime">Игровое время</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Black);

            SpriteBatch.Begin();

            BatL.Draw();
            BatR.Draw();
            //Ball.Draw();

            SpriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
