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
    class GameScreen: Screen 
    {
        public static Camera camera;

        public static BasicEffect effect;

        public override void Init()
        {
            camera = new Camera();
            effect = new BasicEffect(Basic.gDevice);
        }
        public override void Update()
        {
            camera.Update();
           
        }
        public override void Render()
        {
            Model.FloorModel.Draw(Matrix.Identity);
            
        }
    }
}
