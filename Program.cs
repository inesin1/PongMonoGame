using System;

namespace PongMonoGame
{
    public static class Program
    {
        [STAThread]
        static void Main()
        {
            using (var game = new Pong())
                game.Run();
        }
    }
}
