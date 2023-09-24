using Stride.Engine;

namespace Godot_4_1_VS_Stride_4_1
{
    class Godot_4_1_VS_Stride_4_1App
    {
        static void Main(string[] args)
        {
            using (var game = new Game())
            {
                game.Run();
            }
        }
    }
}
