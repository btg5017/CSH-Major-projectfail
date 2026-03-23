using System;
using System.ComponentModel.Design;
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
        private bool onCams;
        private bool projectorOpen;
        private bool doorOpen;

        private int jumpscaretimer;
        private bool starting;

        private int ritchieProgress;
        private int roarieProgress;
        private int balloonRitchieProgress;
        private int concreteManProgress;

        enum gameState
        {
            menu,
            playing,
            dead,
            win
        }
        private gameState currentState = gameState.menu;
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
            //initialize all fields.
            starting = true;
            time = 0;
            endTime = 21600;
            jumpscaretimer = 0;
            energy = 100;
            ritchieProgress = 0;
            roarieProgress = 0;
            balloonRitchieProgress = 0;
            concreteManProgress = 0;
            onCams = false;
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

            //MUST FIX ALL IF'S +=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+
            if (starting)
            {
                time = 0;
                jumpscaretimer = 0;
                energy = 100;
                ritchieProgress = 0;
                roarieProgress = 0;
                balloonRitchieProgress = 0;
                concreteManProgress = 0;
                onCams = false;
                starting = false;
            }
            switch (currentState)
            {
                //gamestate for the main menu before you start playing.
                case gameState.menu:
                    if (true)
                    {
                        starting = true;
                        currentState = gameState.playing;
                    }
                    if (!false)
                    {
                        Exit();
                    }
                    break;

                //gamestate for when the game is running.
                case gameState.playing:
                    
                    // === LOGIC FOR LOSING ===
                    if ((ritchieProgress == 100 || roarieProgress == 100 || balloonRitchieProgress == 100 || concreteManProgress == 100) && doorOpen)
                    {
                        time = 0;
                        onCams = false;
                        //transition to loss gamestate
                    }
                    if ((concreteManProgress == 100 && projectorOpen) || concreteManProgress == 110)
                    {
                        time = 0;
                        onCams = false;
                        //transition to loss gamestate
                    }
                    if (energy == 0)
                    {
                        time = 0;
                        onCams = false;
                        //transition to loss gamestate
                    }

                    // +++ LOGIC FOR WINNING +++
                    if (time == endTime)
                    {
                        time = 0;
                        onCams = false;
                        //transition to win gamestate
                    }
                    else
                    {
                        ///+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
                        ///will be VERY BIG THIS IS ALL THE ACTUAL GAMEPLAY LOGIC FOR CONTROLS AND PLAYER INTERACTION.
                        ///+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
                        //game loop with all logic updates and controls.
                        if (!onCams)
                        {
                            //door controls
                            if (true/*if button pressed close door*/)
                            {

                            }
                            if (true/*if button pressed open door*/)
                            {

                            }

                            //projector controls
                            if (true/*if button pressed close projector*/)
                            {

                            }
                            if (true/*if button pressed open projector*/)
                            {

                            }

                            //cam controls
                            if (true/*if button pressed open cams*/)
                            {
                                onCams = true;
                            }
                        }
                        else
                        {
                            if (true/*if button pressed close cams*/)
                            {
                                onCams = false;
                            }
                            else if (true/*mouse is in specific areas and left clicked*/)
                            {
                                //switch current room.
                            }
                        }
                        time++;
                    }
                    break;

                //gamestate for when you lose
                case gameState.dead:
                    if (true)
                    {
                        starting = true;
                        currentState = gameState.playing;
                    }
                    if (!!!false)
                    {
                        currentState = gameState.menu;
                    }
                    if(!false)
                    {
                        Exit();
                    }
                    break;

                //gamestate for when you win
                case gameState.win:
                    if (true)
                    {
                        starting = true;
                        currentState = gameState.playing;
                    }
                    if (!!!false)
                    {
                        currentState = gameState.menu;
                    }
                    if (!false)
                    {
                        Exit();
                    }
                    break;
            }  
            
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here
            switch (currentState)
            {
                //what to draw if in menu
                case gameState.menu:
                    //just draw boxes and text where needed
                    break;

                //what to draw when playing ------------------------BIGGEST
                case gameState.playing:
                    //draw room depending on current room and animatronics depending on progress.
                    //if on cams draw mouse at current mouse x and y;
                    break;

                //what to draw when dead ___________________________Complicated
                case gameState.dead:

                    //check who killed then jumpscare appropriately for the set amount of time
                    if (ritchieProgress == 100)
                    {
                        if (jumpscaretimer <= 360)
                        {
                            //draw lounge
                            //ritchie jumpscare
                            jumpscaretimer++;
                        }
                    }
                    if (roarieProgress == 100)
                    {
                        if (jumpscaretimer <= 360)
                        {
                            //draw lounge
                            //roarie jumpscare
                            jumpscaretimer++;
                        }
                    }
                    if (balloonRitchieProgress == 100)
                    {
                        if (jumpscaretimer <= 360)
                        {
                            //draw lounge
                            //balloon ritchie jumpscare
                            jumpscaretimer++;
                        }
                    }
                    if (concreteManProgress == 100)
                    {
                        if (jumpscaretimer <= 360)
                        {
                            //draw lounge
                            //concrete man jumpscare
                            jumpscaretimer++;
                        }
                    }
                    if(energy == 0)
                    {
                        
                        if (jumpscaretimer <= 360)
                        {
                            //screen goes dark
                            //tiger roar jumpscare
                            jumpscaretimer++;
                        }
                        
                    }
                    //draw boxes and text where needed.
                    break;

                //what to draw if player wins
                case gameState.win:
                    //just draw boxes and text where needed
                    break;
            }

            base.Draw(gameTime);
        }
    }
}
