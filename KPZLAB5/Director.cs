using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPZLAB5
{
    public class Director
    {
        public void Construct(HouseBuilder builder)
        {
            builder.BuildFoundation();
            builder.BuildWalls();
            builder.BuildRoof();
            builder.BuildWindows();
            builder.BuildDoors();
            builder.BuildGarage();
            builder.InstallSmartHomeSystem();
            builder.BuildChimney();
        }
    }
}
