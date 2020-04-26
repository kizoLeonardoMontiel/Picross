using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Picross
{

    public class Picross : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        //Handles menu drawing and logic
        Menus menu;
        SpriteFont f;
        

        public Picross()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            graphics.PreferredBackBufferWidth = 1920;
            graphics.PreferredBackBufferHeight = 1080;
            this.IsMouseVisible = true;

        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
        }

        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);
            f = Content.Load<SpriteFont>("MainMenuFont");
        }

        protected override void UnloadContent()
        {

        }

        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            //Get height and width to draw the menu stuff
            
            int w = graphics.PreferredBackBufferWidth;  int h = graphics.PreferredBackBufferHeight;
            GraphicsDevice.Clear(Color.CornflowerBlue);
            menu = new Menus(spriteBatch, f, w, h);


            spriteBatch.Begin();
            //Draw main menu on startup
            menu.DrawMain();
            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
