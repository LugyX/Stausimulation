using System;
using System.Collections.Generic;
using System.Linq;
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
    class Transmitter
    {
        public GameClass game
        {
            get { throw new System.NotImplementedException(); }
            set { }
        }

        //static Random rnd = new Random();

        protected const int SPEED_MIN = 0;
        protected const int SPEED_MAX = 4;
        protected const int SCREEN_WIDTH = 1280;
        protected const int SCREEN_HEIGHT = 800;

        protected Point position = new Point();
        protected string orientation;
        protected int speed, duration=0;
        protected Vector2 vec_position;

        protected void Car(Point position, string orientation, int speed)
        {
            if(position.X > 0 && position.X <= SCREEN_WIDTH)
                this.position.X = position.X;
            if(position.Y > 0 && position.Y <= SCREEN_HEIGHT)
                this.position.Y = position.Y;
            if(orientation == "N" || orientation == "O" || orientation == "S" || orientation == "W")
                this.orientation = orientation;
            if (speed <= SPEED_MAX && speed >= SPEED_MIN)
                this.speed = speed;
        }
        /* protected Car()
        {
            try  { position = game.p_arr[rnd.Next(0, game.p_arr.Count + 1)]; }
            catch{ }
            switch (rnd.Next(0, 4))
            {
                case 0: orientation = "N"; break;
                case 1: orientation = "O"; break;
                case 2: orientation = "S"; break;
                case 3: orientation = "W"; break;
                default: break;
            }

            speed = rnd.Next(SPEED_MIN + 1, SPEED_MAX + 1);            
        }
        * */

        public virtual void setPosition(int x, int y)
        {
            position.X = x;
            position.Y = y;
        }
        public virtual int giveDuration()
        {
            return duration;
        }

        public virtual int givePositionX()
        {
            return position.X;
        }
        public virtual int givePositionY()
        {
            return position.Y;
        }

        public virtual void setOrientation(string o)
        {
            orientation = o;
        }
        public virtual void setDuration(int d)
        {
            duration = d;
        }
        public virtual void updateVektor()
        {
            vec_position = new Vector2(position.X, position.Y);
        }

        public virtual void move()
        {
            if (duration != 0)
            {
                switch (orientation)
                {
                    case "N": position.Y -= speed; break;
                    case "O": position.X += speed; break;
                    case "S": position.Y += speed; break;
                    case "W": position.X -= speed; break;
                    default: break;
                }
                duration--;
            }
            else
            {
                Console.WriteLine("Ups, an Error occured");
                /*switch(map[position.X, position.Y])
                 * {
                 * 
                 * }
                 */
            }
        }
    }

    /*public class Transmitter : Car
    {

    }

    public class Standard : Car
    {

    }

    public class Client : Car
    {
    
    }*/
}
