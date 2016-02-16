using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace SnakeGame
{
    class snake
    {
        private Texture2D blockTexture;

        public Texture2D BlockTexture
        {
            get { return blockTexture; }
            //set { blockTexture = value; }
        }

        private Vector2 headLocation;

        public Vector2 HeadLocation
        {
            get { return headLocation; }
            set { headLocation = value; }
        }

        int length = 5;
        
        
        int snakeBlockSize = 16;

        public snake(Texture2D texture)
        {
            headLocation = new Vector2(50, 50);
            blockTexture = texture;
        }
        public void Move(Vector2 pos)
        {
            headLocation += pos;
            
        }
    }
}
