using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Fnaf_Fan_Game
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        private Random random;

        private int time;
        private int energy;
        private int endTime;

        private int ritchieProgress;
        private int roarieProgress;
        private int balloonRitchieProgress;
        private int concreteManProgress;

        enum gameState
        {
            menu = 1,
            inRoom = 2,
            cams = 3,
            dead = 4,
            win = 5
        }
        enum Rooms
        {
            swoom = 1,
            userCenter = 2,
            vader = 3,
            outsideLougne = 4,
            northside = 5,
            cryingCorner = 6,
            projectRoom = 7,
            loserCenter = 8
        }
        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            time = 0;
            endTime = 21600;
            energy = 100;
            ritchieProgress = 0;
            roarieProgress = 0;
            balloonRitchieProgress = 0;
            concreteManProgress = 0;
            random = new Random();
            base.Initialize();

        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();
            
            // TODO: Add your update logic here

            // === LOGIC FOR LOSING ===
            if(energy == 0)
            {
                //screen goes dark
                //tiger roar jumpscare
                //transition to loss gamestate
            }
            if(ritchieProgress == 100)
            {
                //ritchie jumpscare
                //transition to loss gamestate
            }
            if (roarieProgress == 100)
            {
                //roarie jumpscare
                //transition to loss gamestate
            }
            if (balloonRitchieProgress == 100)
            {
                //balloon ritchie jumpscare
                //transition to loss gamestate
            }
            if (concreteManProgress == 100)
            {
                //Concrete man jumpscare
                //transition to loss gamestate
            }
            // +++ LOGIC FOR WINNING +++
            if (time == endTime)
                {
                //display for having won the game
                //transition to win gamestate
            }
            else
                {
                //game loop with all logic updates and controls.
                }





                    base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here
            

            base.Draw(gameTime);
        }
    }
}
