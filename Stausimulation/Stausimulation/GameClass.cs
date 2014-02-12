using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace Stausimulation
{


    public static class variables
    {
        //Globale Variablen
        public static int carCount = 5;

        public static bool carDespawned = false;
        public static string map = null;
        public static int width = 1000;
        public static int height = 1000;
        public static int spawns_count = 0;
        public static string[, ,] array_map = new string [variables.width,variables.height,5];
        public static int[,] spawns = new int [100, 2];
        public static Random rnd = new Random();



        
     
    }
    public class GameClass : Microsoft.Xna.Framework.Game
    {
        private GraphicsDeviceManager graphics;
        private SpriteBatch spriteBatch;
        List<Transmitter> transmitter;

        public List<Point> p_arr = new List<Point>();
            

        public GameClass()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base. Initialize will enumerate through any components
        /// and initialize them as well.
        protected override void Initialize()
        {
            // TODO: Datei laden und nach spawns durchsuchen
            //p_arr.Add(new Point(x, y)); 
          
            
            IsMouseVisible = true;

            base.Initialize();

            //initialisierung der map
            spriteBatch = new SpriteBatch(GraphicsDevice);
  
           // trans = Content.Load<Texture2D>("trans.png");


            Int64 zaehler1=0;

            reader.ReadFile();
             string [] type = (variables.map).Split(';');
            
            for (int zaehler2 = 1; zaehler2<=variables.height; zaehler2++)
            {
               for (int zaehler3 = 1; zaehler3<=variables.width; zaehler3++)
            {
                reader.ReadFile();
                 string [] type2 = (type[zaehler1]).Split(',');

                variables.array_map[zaehler3,zaehler2,0]=type2[0];
                zaehler1++;
                   if (type2[1] != null)
                   {
                       variables.array_map[zaehler3,zaehler2,1]=type2[1];
                   }
                   if (type2[2] != null)
                   {
                       variables.array_map[zaehler3,zaehler2,2]=type2[2];
                   }

            } 
            }
             for (int zaehler2 = 1; zaehler2<=variables.height; zaehler2++)
            {
               for (int zaehler3 = 1; zaehler3<=variables.width; zaehler3++)
                 {
                   if (variables.array_map[zaehler3, zaehler2,0]=="S" )
                   {
                       variables.spawns[variables.spawns_count, 0] = zaehler3;
                       variables.spawns[variables.spawns_count, 1] = zaehler2;
                     
                       variables.spawns_count++;
                   }
                 }
             }

            
           /* Transmitter[] transmitter = new Transmitter[variables.carCount];
            transmitter[0] = new Transmitter ();
            transmitter[1] = new Transmitter ();
            transmitter[2] = new Transmitter ();
            transmitter[3] = new Transmitter ();
            transmitter[4] = new Transmitter ();

            List<transmitter> liste = new List<transmitter>();
            */
            
            /*List<Transmitter>*/ transmitter = new List<Transmitter>();
            for(int i = 0; i < variables.carCount;i++)
            {
             transmitter.Add(new Transmitter()); 
            }   
        }

        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);

            graphics.PreferredBackBufferWidth = 1000;
            graphics.PreferredBackBufferHeight = 1000;
            graphics.IsFullScreen = false;
            graphics.ApplyChanges();
            Window.Title = "Seminarkurs 9 - Stausimulation";


            // TODO: use this.Content to load your game content here
        }

        /// UnloadContent will be called once per game and is the place to unload
        /// all content.
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed)
                this.Exit();

            //Transmitter[] transmitter;
         
            //Fallunterscheidung bei abgelaufener Zeit:

            for (int z=0 ; z == (variables.carCount -1); z++)
            {

                int temp = transmitter[z].giveDuration();
                if (temp == 0)
                {
                    int tempX = transmitter[z].givePositionX();
                    int tempY = transmitter[z].givePositionY();

                    if (variables.array_map[tempX, tempY, 0] == "U")
                    {
                        //Unterscheidungsfeld
                        string temp1 = variables.array_map[tempX, tempY, 1];
                        string temp2 = variables.array_map[tempX, tempY, 2];

                        string[] t1 = (temp1).Split('>');
                        string[] t2 = (temp2).Split('>');

                        if (temp1 != null && temp2 != null)
                        {
                            //Es sind nur maximal 2 Richtungen logisch möglich im normalen Straßenbetrieb                          
                            variables.rnd.Next(0, 2);
                            int tempZ = 0;
                            tempZ = Convert.ToInt16(variables.rnd);
                            if (tempZ == 0)
                            {
                                transmitter[z].setOrientation(t1[0]);
                                transmitter[z].setDuration(Convert.ToInt16(t1[1]));
                            }
                            else if (tempZ == 1)
                            {
                                transmitter[z].setOrientation(t2[0]);
                                transmitter[z].setDuration(Convert.ToInt16(t2[1]));

                            }
                            else
                            {
                                Console.WriteLine("Ein Auto steht auf einem Pixel ohne Information");
                            }
                        }
                        else if (temp1 != null)
                        {
                            //nur Richtungsänderung
                            transmitter[z].setOrientation(t1[0]);
                            transmitter[z].setDuration(Convert.ToInt16(t1[1]));
                        }
                        else
                        {
                            Console.WriteLine("Ein Auto steht auf einem Pixel ohne Information");
                        }

                    }
                    else if ((variables.array_map[tempX, tempY, 0] == "S"))
                    {
                        string temp1 = variables.array_map[tempX, tempY, 1];
                        string temp2 = variables.array_map[tempX, tempY, 2];

                        string[] t1 = (temp1).Split('>');
                        string[] t2 = (temp2).Split('>');

                        transmitter[z].setOrientation(t1[0]);
                        transmitter[z].setDuration(Convert.ToInt16(t1[1]));
                    }
                    else if ((variables.array_map[tempX, tempY, 0] == "D"))
                    {
                        //Despawnfeld
                        variables.rnd.Next(0, (variables.spawns_count + 1));
                        transmitter[z].setPosition((variables.spawns[Convert.ToInt16(variables.rnd), 0]),(variables.spawns[Convert.ToInt16(variables.rnd),1]));

                    }
                    else
                    {
                        Console.WriteLine("Ein Auto steht auf einem Pixel ohne Information");
                    }

                }
                else
                {
                    //normales movement
                    transmitter[z].move();
                }
            }
            


            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        /// This is called when the game should draw itself.
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here
           /* damage = new Texture2D(device, 1, 1, 1, TextureUsage.None, SurfaceFormat.Color); 
            damage.SetData(new [] { new Color(new Vector4(1f, 1f, 1f, 0.6f)), });
            spriteBatch.Draw(damage, new Rectangle(10,10,1,1), Color.Red);
                 
            enemy.pos += enemy.speed*(float)gameTime.ElapsedGameTime.TotalSeconds;

            base.Draw(gameTime);

            spriteBatch.Draw(textureDeform,  , Color.White);
            */
            //Transmitter[] transmitter;

            for (int z = 0; z == (variables.carCount - 1); z++)
            {
                transmitter[z].updateVektor();
            }


            base.Draw(gameTime);
        }
    }
}