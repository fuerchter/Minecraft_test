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
    class Basic
    {
        public static SpriteBatch spriteBatch;
        public static GraphicsDevice gDevice;
        public static GraphicsDeviceManager gManager;
        public static ContentManager content;
        public static GameTime gameTime;
        public static Game1 game;
        

        public static GameWindow window;
        public static Rectangle windowSize = new Rectangle(0, 0, 1200, 720); //Rechteck der die Fenstergröße beschreibt


        public static Screen currentScreen; //HauptScreen
        public static SpriteFont debugFont;

        public static void Init(Game1 _game)
        {
            game = _game;
            gManager = _game.graphics;
            gDevice = gManager.GraphicsDevice;
            content = _game.Content;
            spriteBatch = new SpriteBatch(gDevice); //gametime in updatemethode geupt.
            window = _game.Window;

            gManager.PreferredBackBufferWidth = windowSize.Width;   //Größe
            gManager.PreferredBackBufferWidth = windowSize.Height;
            gManager.ApplyChanges();

            setScreen(new GameScreen());

            debugFont = content.Load<SpriteFont>("Font");
        }

        public static void Update(GameTime _gameTime)
        {
            
            gameTime = _gameTime;

            currentScreen.Update();
        }
        public static void Render()
        {
            spriteBatch.Begin();

            currentScreen.Render();

            spriteBatch.End();
        }
        public static void setScreen(Screen newScreen) //damit man die Szene wechseln kann
        {
            currentScreen = newScreen;
            currentScreen.Init();
        }
    }

}
