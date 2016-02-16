using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace SnakeGame
{
    class snakeBlock
    {
        Texture2D blockTexture;
        Vector2 Location;

        public snakeBlock(Texture2D texture, Vector2 location)
        {
            this.blockTexture = texture;
            this.Location = location;
        }
    }
}
