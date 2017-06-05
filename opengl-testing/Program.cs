using System;
using System.Drawing;
using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.ES20;
using OpenTK.Input;

namespace opengl_testing
{
    internal class Program : GameWindow
    {
        public Program() : base(800, 600, GraphicsMode.Default, "OpenGL Testing", GameWindowFlags.FixedWindow)
        {
            VSync = VSyncMode.Off;
            CursorVisible = true;
        }

        private static void Main(string[] args)
        {
            using (Program pro = new Program())
            {
                pro.Run(30, 60);
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            GL.ClearColor(Color.Firebrick);
        }

        protected override void OnUpdateFrame(FrameEventArgs e)
        {
            base.OnUpdateFrame(e);
            if (Keyboard[Key.Escape])
            {
                Exit();
            }
        }

        protected override void OnRenderFrame(FrameEventArgs e)
        {
            base.OnRenderFrame(e);
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
            SwapBuffers();
        }

        protected override void OnKeyDown(KeyboardKeyEventArgs e)
        {
            base.OnKeyDown(e);
            Console.WriteLine($"{e.Key} was pressed.");
        }
    }
}