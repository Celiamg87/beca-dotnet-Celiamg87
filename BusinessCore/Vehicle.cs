using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessCore
{
    public abstract class Vehicle
    {
        private int door;
        private int wheel;
        private string chasis;
        private bool extras;
        private string carroceria;

        public Vehicle()
        {
            this.door = 5;
            this.wheel = 4;
            this.chasis = "bastidores";
            this.extras = false;
            this.carroceria = "black";
        }

        public Vehicle(int door, int wheel, string chasis,  bool extras, string carroceria)
        {
            this.door = door;
            this.wheel = wheel;
            this.chasis = chasis;
            this.extras = extras;
            this.carroceria = carroceria;
        }

        public int getDoor()
        {
            return door;
        }

        public int getWheel()
        {
            return wheel;
        }
        
        public string getChasis()
        {
            return chasis;
        }

        public bool getExtras()
        {
            return extras;
        }

        public string getCarroceria()
        {
            return carroceria;
        }

        public void setDoor(int door)
        {
            this.door = door;
        }

        public void setWheel(int wheel)
        {
            this.wheel = wheel;
        }
        
        public void setCahsis(string chasis)
        {
            this.chasis = chasis;
        }

        public void setExtras(bool extras)
        {
            this.extras = extras;
        }

        public void setCarroceria(string carroceria)
        {
            this.carroceria = carroceria;
        }

    }
}
