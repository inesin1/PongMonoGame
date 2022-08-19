using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace PongMonoGame
{
    class GameObject
    {
        public Vector2 Position = Vector2.Zero;     // Позиция
        public Texture2D Texture;                   // Текстура
        public Point Size;                          // Размеры
        public Rectangle CollisionBox;              // Поле столкновения
    }
}
