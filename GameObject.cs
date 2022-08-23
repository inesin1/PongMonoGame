using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace PongMonoGame
{
    /// <summary>
    /// Родительский класс для всех игровых объектов
    /// </summary>
    public class GameObject
    {
        public Pong Context { get; }                // Контекст
        public Vector2 Position { get; set; } = Vector2.Zero; // Позиция
        public Vector2 Size { get; set; }           // Размеры
        public Texture2D Texture { get; set; }     // Текстура
        public Rectangle CollisionBox { get; set; } // Поле столкновения
        public float Rotation { get; set; }         // Угол поворота
        public Vector2 Origin { get; set; }         // Центр координат

        public GameObject(Pong context) { Context = context; }

        /// <summary>
        /// Инициализация объекта. Срабатывает один раз при создании
        /// </summary>
        public virtual void Init() {
            Size = new Vector2(Texture.Width, Texture.Height);
            Rotation = 0;
            Origin = new Vector2(Size.X / 2, Size.Y / 2);
        }

        /// <summary>
        /// Обновление состояния объекта. Срабатывает каждый кадр
        /// </summary>
        /// <param name="deltaTime">Разница во времени между кадрами</param>
        public virtual void Update(float deltaTime) {
            CollisionBox = new Rectangle((int)Position.X, (int)Position.Y, (int)Size.X, (int)Size.Y);
        }

        /// <summary>
        /// Отрисовка объекта. Срабатывает каждый кадр
        /// </summary>
        public virtual void Draw() {
            Context.SpriteBatch.Draw(
                Texture,
                Position,
                null,
                Color.White,
                Rotation,
                Origin,
                Vector2.One,
                SpriteEffects.None,
                0
                );
        }
    }
}
