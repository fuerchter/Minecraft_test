using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Minecraft_test
{


    class Camera
    {
        public Matrix view, projection;

        public Vector3 position;
        public float speed = 0.04f;
        public float rotationSpeed = 0.004f;

        float yaw, pitch;

        int oldX, oldY;


        public Camera()
        {
            position = new Vector3(0, 0, 0);

            view = Matrix.CreateLookAt(position, Vector3.Zero, Vector3.Up);
            projection = Matrix.CreatePerspectiveFieldOfView(MathHelper.ToRadians(45.0f), Basic.gDevice.Viewport.AspectRatio, 0.1f, 1000.0f);
        }

        public void Update()
        {

            KeyboardState kBoard = Keyboard.GetState();

            if (kBoard.IsKeyDown(Keys.W))
            {
                Vector3 v = new Vector3(0, 0, -1) * speed;
                move(v);
            }

            if (kBoard.IsKeyDown(Keys.S))
            {
                Vector3 v = new Vector3(0, 0, 1) * speed;
                move(v);
            }

            if (kBoard.IsKeyDown(Keys.A))
            {
                Vector3 v = new Vector3(-1, 0, 0) * speed;
                move(v);
            }

            if (kBoard.IsKeyDown(Keys.D))
            {
                Vector3 v = new Vector3(1, 0, 0) * speed;
                move(v);
            }

            MouseState mState = Mouse.GetState();

            int dx = mState.X - oldX;
            int dy = mState.Y - oldY;

            yaw += -rotationSpeed * dx;
            pitch += -rotationSpeed * dy;

            pitch = MathHelper.Clamp(pitch, -1.5f, 1.5f);

            UpdateMatrices();
            ResetCursor();

        }

        private void ResetCursor()
        {
            if (Basic.game.IsActive)
            {
                Mouse.SetPosition(Basic.windowSize.Width / 2, Basic.windowSize.Height / 2);
                oldX = Basic.windowSize.Width / 2;
                oldY = Basic.windowSize.Height / 2;
            }
        }

        public void move(Vector3 v)
        {
            Vector3 forward = Vector3.Transform(v, Matrix.CreateRotationY(yaw));
            position += forward;
        }

        public void UpdateMatrices()
        {
            Matrix rotation = Matrix.CreateRotationX(pitch) * Matrix.CreateRotationY(yaw);

            Vector3 transformed = Vector3.Transform(new Vector3(0, 0, -1), rotation);
            Vector3 lookAt = position + transformed;

            view = Matrix.CreateLookAt(position, lookAt, Vector3.Up);
        }

    }
}


