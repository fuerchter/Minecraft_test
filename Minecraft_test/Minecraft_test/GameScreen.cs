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
       // public static world currentworld;

        public override void Init()
        {
            camera = new Camera();
            effect = new BasicEffect(Basic.gDevice);
            //currentworld = new world();
            new Model();

           // camera.setMovementValues(0.05f, 0.05f);
            base.Init();

        }
        public override void Update()
        {
            camera.Update();
            base.Update();
           
        }
        public override void Render()
        {
         
            GameScreen.effect.View = GameScreen.camera.view;
            GameScreen.effect.Projection = GameScreen.camera.projection;

            Model.floor.Render(Matrix.CreateTranslation(0, 0, 0));
            Model.floor.Render(Matrix.CreateTranslation(1, 0, 0));
            Model.floor.Render(Matrix.CreateTranslation(2, 0, 0));
            Model.floor.Render(Matrix.CreateTranslation(3, 0, 0));
            Model.floor.Render(Matrix.CreateTranslation(4, 0, 0));
           
            base.Render();
            //Model.FloorModel.Draw(Matrix.Identity);
            
        }
    }
}
