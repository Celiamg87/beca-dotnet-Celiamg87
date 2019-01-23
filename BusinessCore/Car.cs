using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessCore
{
    public class Car : Vehicle
    {
        public Car() : base()
        {
        }

        public Car(int door, int wheel, string chasis, bool extras, string carroceria) : base(door, wheel, chasis, extras, carroceria)
        {
        }

        public void montarCoche(int door, int wheel, string chasis, bool extras, string carroceria)
        {
            this.setDoor(door);
            this.setWheel(wheel);
            this.setCahsis(chasis);
            this.setExtras(extras);
            this.setCarroceria(carroceria);
        }
    }
}
