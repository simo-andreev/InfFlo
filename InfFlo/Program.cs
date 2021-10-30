using System;
using System.Diagnostics;
using System.Numerics;
using Emotion.Common;
using Emotion.Graphics.Camera;
using Emotion.Platform;
using Emotion.Platform.Implementation.GlfwImplementation;
using Emotion.Platform.Implementation.Win32;
using Emotion.Platform.Input;
using Emotion.Plugins.ImGuiNet;
using Emotion.Standard.Logging;
using InfFlo.Scenes;

namespace InfFlo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! " + Debugger.IsAttached);

            var configurator = new Configurator().AddPlugin(new ImGuiNetPlugin());
            // configurator.HostTitle = "🗯 🔨 🚉 🏐 🍩 ☦ 💂 😎 😸 🚕 🚊 👟";
            configurator.InitialDisplayMode = DisplayMode.Windowed;
            configurator.UseEmotionFontSize = false;
            configurator.PlatformOverride = new Win32Platform();
#if(DEBUG)
            configurator.Logger = new ConsoleLogger();
            configurator.DebugMode = true;
            configurator.PlatformOverride = new GlfwPlatform();
#else
            configurator.DebugMode = false;
#endif

            foreach (var info in configurator.GetType().GetProperties())
            {
                Console.WriteLine($"Engine Configuration: {info.Name} | {info.GetValue(configurator)}");
            }

            Engine.Setup(configurator);
            
            Engine.SceneManager.SetScene(new SceneScene());
            Engine.Renderer.Camera = new SolCam(Vector3.Zero);
            
            Engine.Run();
        }
    }

    public class ConsoleLogger : LoggingProvider
    {
        public override void Log(MessageType type, string source, string message)
        {
            Console.WriteLine($"[{source}]: {type} - {message}");
        }

        public override void Dispose()
        {
            /* do noting */
        }
    }
}
internal class SolCam : TrueScaleCamera
{
    public float Speed { get; set; } = 0.35f;

    public SolCam(Vector3 position, float zoom = 1) : base(position, zoom)
    {
    }

    public override void Update()
    {
        Vector3 cameraMoveDirection = Vector3.Zero;

        // note any-and-all 'WASD' move input
        if (Engine.Host.IsKeyHeld(Key.W)) cameraMoveDirection.Y -= 1;
        if (Engine.Host.IsKeyHeld(Key.A)) cameraMoveDirection.X -= 1;
        if (Engine.Host.IsKeyHeld(Key.S)) cameraMoveDirection.Y += 1;
        if (Engine.Host.IsKeyHeld(Key.D)) cameraMoveDirection.X += 1;

        // If mouse scroll-ed, note Zoom amount and direction
        // if (Engine.Host.IsKeyHeld(Key.LeftControl) && Engine.Host.IsKeyDown(Key.KpAdd)) Zoom += 0.035f * Engine.DeltaTime;
        // if (Engine.Host.IsKeyHeld(Key.LeftControl) && Engine.Host.IsKeyDown(Key.KpSubtract)) Zoom -= 0.035f * Engine.DeltaTime;
        

        // If mouse scroll-ed, note Zoom amount and direction
        if (Engine.Host.IsKeyHeld(Key.LeftControl) && Engine.Host.IsKeyDown(Key.KpAdd)) Zoom += 0.0035f * Engine.DeltaTime;
        if (Engine.Host.IsKeyHeld(Key.LeftControl) && Engine.Host.IsKeyDown(Key.KpSubtract)) Zoom -= 0.0035f * Engine.DeltaTime;
        
        // Clamp Camera Zoom
        if (Zoom > 10) Zoom = 10;
        if (Zoom < 0.1f) Zoom = 0.1f;

        // If fast-move key down -> quadruple speed coefficient 
        float speed = Speed;
        if (Engine.Host.IsKeyHeld(Key.LeftControl)) speed *= 4;
        speed *= Engine.DeltaTime;

        // Since the camera is isometric its X and Y axes are rotated - however we want the movement to be relative to the screen 
        // based on the perspective. To do this we need to find the "proper" up and right directions and move along them.
        cameraMoveDirection *= new Vector3(speed, speed, speed);

        // Finally apply the movement Vector to the camera.
        Engine.Renderer.Camera.Position += cameraMoveDirection;

        if (Engine.Host.IsKeyHeld(Key.Home)) Engine.Renderer.Camera.Position = Vector3.Zero;
    }
}