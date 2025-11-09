using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPZLAB5
{
    public abstract class HouseBuilder
    {
        protected House house = new House();

        public abstract void BuildFoundation();
        public abstract void BuildWalls();
        public abstract void BuildRoof();
        public abstract void BuildWindows();
        public abstract void BuildDoors();

        public virtual void BuildGarage() { }
        public virtual void InstallSmartHomeSystem() { }
        public virtual void BuildChimney() { }

        public House GetHouse() => house;
    }
}
