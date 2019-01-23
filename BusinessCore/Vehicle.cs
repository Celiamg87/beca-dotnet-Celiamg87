using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessCore
{
    class Vehicle
    {
        private int door;
        private int wheel;
        private string chasis;
        private bool extras;
        private string carroceria;
        /*{
            green,
            yellow,
            black,
            white,
            blue,
            red
        };*/

        public Vehicle()
        {
            door = 5;
            wheel = 4;
            chasis = "bastidores";
            extras = false;
            carroceria = "black";
        }

        public Vehicle(int door, int wheel, string chasis,  bool extras, string carroceria)
        {
            this.door = door;
            this.wheel = wheel;
            this.chasis = chasis;
            this.extras = extras;
            this.carroceria = carroceria;
        }

        protected int getDoor()
        {
            return door;
        }

        protected int getWheel()
        {
            return wheel;
        }
        
        protected string getChasis()
        {
            return chasis;
        }

        protected bool getExtras()
        {
            return extras;
        }

        protected string getCarroceria()
        {
            return carroceria;
        }

        protected void setDoor(int door)
        {
            this.door = door;
        }

        protected void setWheel(int wheel)
        {
            this.wheel = wheel;
        }
        
        protected void setCahsis(string chasis)
        {
            this.chasis = chasis;
        }

        protected void setExtras(bool extras)
        {
            this.extras = extras;
        }

        protected void setCarroceria(string carroceria)
        {
            this.carroceria = carroceria;
        }

    }
}
