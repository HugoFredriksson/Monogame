using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace spelsak
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        Texture2D marko;

        Texture2D makaroner;

        Rectangle markoRect = new Rectangle(0, 0, 100, 200);

        Rectangle makaronerRect = new Rectangle(300, 300, 50, 50);

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
            
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            

            marko = Content.Load<Texture2D>("marko");

            makaroner = Content.Load<Texture2D>("makaroner");


            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            
            KeyboardState kstate = Keyboard.GetState();
            if (kstate.IsKeyDown(Keys.Right))
            markoRect.X++;
            if (kstate.IsKeyDown(Keys.Left))
            markoRect.X--;
            base.Update(gameTime);
            
            if (kstate.IsKeyDown(Keys.Up))
            markoRect.Y--;
            if (kstate.IsKeyDown(Keys.Down))
            markoRect.Y++;
            base.Update(gameTime);



            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            _spriteBatch.Begin();
            _spriteBatch.Draw(marko, markoRect, Color.White);
            _spriteBatch.Draw(makaroner, makaronerRect, Color.White);
            _spriteBatch.End();
            

            base.Draw(gameTime);
        }
    }
}
