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
        Color[] color;
        public Menus(SpriteBatch spriteBatch, SpriteFont font, int width, int height)
        {
            this.spriteBatch = spriteBatch;
            this.width = width; this.height = height;
            this.font = font;

            //Initialize menus and colors
            menuElements = new Vector2[4];
            color = new Color[4];
            for (int i = 0; i <= 3; i++)
            {
                //Position for each element on the screen. Will stay in the same position regardless of screen resolution.
                menuElements[i] = new Vector2((width / 2.2f), ((height / 4f) + (i * 70)));
                //TODO: Add && statement to check if there is any saved data
                if (i == 1)
                {
                    color[i] = Color.Gray;
                }
                else
                {
                    color[i] = Color.White;
                }

            }

        }

        public void DrawMain()
        {

            //Add menu elements into an array to get their values later on in the game logic section
            menuElements = new Vector2[4];
            for(int i = 0; i <= 3; i++)
            {
                menuElements[i] = new Vector2((width / 2.2f), ((height / 4f) + (i * 70)));
            }
            spriteBatch.DrawString(font, "New Game", menuElements[0], color[0]);
            spriteBatch.DrawString(font, "Continue", menuElements[1], color[1]);
            spriteBatch.DrawString(font, "Options", menuElements[2], color[2]);
            spriteBatch.DrawString(font, "Exit", menuElements[3], color[3]);
        }


        public Vector2[] GetMenuElements()
        {
            return this.menuElements;
        }

        public Color[] GetColor()
        {
            return this.color;
        }

        public void SetColor(Color color, int i)
        {
            this.color[i] = color;
        }

        public void UpdateMenu(GameTime gameTime)
        {
            MouseState mouseState = Mouse.GetState();
            int currentElement = 0;
            Menus menu = new Menus(spriteBatch, font, 1920, 1080);
            foreach (Vector2 i in menu.GetMenuElements())
            {
                if (i.X == mouseState.X || i.Y == mouseState.Y)
                {
                    //Adds menu highlighting
                    this.SetColor(Color.Red, currentElement);
                }
                else
                {
                    //If not hovering the element, change color back to white
                    this.SetColor(Color.White, currentElement);
                }
                currentElement++;
            }

        }
    }
}
