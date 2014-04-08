using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace Minecraft_test
{

    public class Game1 : Microsoft.Xna.Framework.Game
    {
       public GraphicsDeviceManager graphics;
       

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        protected override void Initialize()
        {

            Basic.Init(this);//in game1 klasse game übergeben
            base.Initialize();
        }

        
        //protected override void LoadContent()
        //{
 
        //    spriteBatch = new SpriteBatch(GraphicsDevice);

        //}

        
        protected override void UnloadContent()
        {
                    }

               protected override void Update(GameTime gameTime)
        {
                   Basic.Update(gameTime);
                   base.Update(gameTime);
        }

        
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Black);
            Basic.Render();
            
            base.Draw(gameTime);
        }
    }
}
