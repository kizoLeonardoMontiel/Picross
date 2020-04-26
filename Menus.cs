using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MonoGame;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;


namespace Picross
{
    class Menus
    {
        SpriteBatch spriteBatch;
        float width, height;
        SpriteFont font;
        Vector2[] menuElements;

        public Menus(SpriteBatch spriteBatch, SpriteFont font, int width, int height)
        {
            this.spriteBatch = spriteBatch;
            this.width = width; this.height = height;
            this.font = font;
        }

        public void DrawMain()
        {
            //Add menu elements into an array to get their values later on in the game logic section
            menuElements = new Vector2[4];
            for(int i = 0; i <= 3; i++)
            {
                menuElements[i] = new Vector2((width / 2.2f), ((height / 4f) + (i * 70)));
            }
            spriteBatch.DrawString(font, "New Game", menuElements[0], Color.White);
            spriteBatch.DrawString(font, "Continue", menuElements[1], Color.White);
            spriteBatch.DrawString(font, "Options", menuElements[2], Color.White);
            spriteBatch.DrawString(font, "Exit", menuElements[3], Color.White);
            
            

        }


        private void MenuLogic()
        {

        }
    }
}
