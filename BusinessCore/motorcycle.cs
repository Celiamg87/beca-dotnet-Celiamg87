using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessCore
{
    public class Motorcycle : Vehicle
    {
        public Motorcycle() : base(0, 2, "bastidor", false, "red")
        {
        }

        public Motorcycle(int wheel, string chasis, bool extras, string carroceria) : base(0, wheel, chasis, extras, carroceria)
        {
        }

        public void montarMoto(int wheel, string chasis, bool extras, string carroceria)
        {
            this.setWheel(wheel);
            this.setCahsis(chasis);
            this.setExtras(extras);
            this.setCarroceria(carroceria);
        }

    }
}
