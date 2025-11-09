using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPZLAB5
{
    public class BrickHouseBuilder : HouseBuilder
    {
        public override void BuildFoundation() => house.Foundation = "Бетонний фундамент";
        public override void BuildWalls() => house.Walls = "Цегляні стіни";
        public override void BuildRoof() => house.Roof = "Черепичний дах";
        public override void BuildWindows() => house.Windows = "Пластикові вікна";
        public override void BuildDoors() => house.Doors = "Металеві двері";
        public override void BuildChimney() => house.Chimney = "Цегляний димохід";
    }
}
