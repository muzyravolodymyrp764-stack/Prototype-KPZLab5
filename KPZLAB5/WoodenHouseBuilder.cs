using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPZLAB5
{
    public class WoodenHouseBuilder : HouseBuilder
    {
        public override void BuildFoundation() => house.Foundation = "Дерев’яна основа";
        public override void BuildWalls() => house.Walls = "Стіни з колод";
        public override void BuildRoof() => house.Roof = "Дерев’яний дах";
        public override void BuildWindows() => house.Windows = "Дерев’яні рами";
        public override void BuildDoors() => house.Doors = "Дерев’яні двері";
    }
}
