using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace PongMonoGame
{
    static class Variables
    {
        public const int SCREEN_WIDTH = 800;                               // Ширина экрана
        public const int SCREEN_HEIGHT = 600;                              // Высота экрана
        public const int SCREEN_HALF_WIDTH = SCREEN_WIDTH / 2;             // Половина ширины экрана
        public const int SCREEN_HALF_HEIGHT = SCREEN_HEIGHT / 2;           // Половина высоты экрана

        // Стандартные позиции объектов
        public static Vector2 DEFAULT_BALL_POSITION = new Vector2(SCREEN_HALF_WIDTH, SCREEN_HALF_HEIGHT);
        public static Vector2 DEFAULT_BAT_L_POSITION = new Vector2(50, SCREEN_HALF_HEIGHT);
        public static Vector2 DEFAULT_BAT_R_POSITION = new Vector2(SCREEN_WIDTH - 50, SCREEN_HALF_HEIGHT);
    }
}
