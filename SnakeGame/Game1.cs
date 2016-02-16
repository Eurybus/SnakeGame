using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Diagnostics;
namespace SnakeGame
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        Texture2D texture;
        Vector2 texturePos;
        snake Snake;

        public Vector2 gameArea;
        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            texturePos = new Vector2(0, 0);

            
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            gameArea.X = Window.ClientBounds.Width;
            gameArea.Y = Window.ClientBounds.Height;
            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);
            try
            {
                Snake = new snake(this.Content.Load<Texture2D>("res/snake_block.png"));
            }
            catch (Microsoft.Xna.Framework.Content.ContentLoadException e)
            {
                Debug.WriteLine(e.Message);
                //throw;
            }
            // TODO: use this.Content to load your game content here
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// game-specific content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            if (Keyboard.GetState().IsKeyDown(Keys.A))
            {
                Snake.Move(new Vector2(-16,0));
                //if (Snake.HeadLocation.X < gameArea.X) Snake.HeadLocation = new Vector2(0, Snake.HeadLocation.Y);
            }
            if (Keyboard.GetState().IsKeyDown(Keys.D))
            {
                Snake.Move(new Vector2(16, 0));
                //if (Snake.HeadLocation.X > gameArea.X) Snake.HeadLocation = new Vector2(gameArea.X, Snake.HeadLocation.Y);
            }
            if (Keyboard.GetState().IsKeyDown(Keys.W))
            {
                Snake.Move(new Vector2(0, -16));
                //if (Snake.HeadLocation.Y < gameArea.Y) Snake.HeadLocation = new Vector2(Snake.HeadLocation.X, gameArea.Y);
            }
            if (Keyboard.GetState().IsKeyDown(Keys.S))
            {
                Snake.Move(new Vector2(0, 16));
                //if (Snake.HeadLocation.Y > gameArea.Y) Snake.HeadLocation = new Vector2(Snake.HeadLocation.X, 0);
            }
            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            
            GraphicsDevice.Clear(Color.CornflowerBlue);

            spriteBatch.Begin();
            spriteBatch.Draw(Snake.BlockTexture, Snake.HeadLocation);
            spriteBatch.End();
            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }
    }
}
