using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPZLAB5
{
    public class ModernHouseBuilder : HouseBuilder
    {
        public override void BuildFoundation() => house.Foundation = "Залізобетонна плита";
        public override void BuildWalls() => house.Walls = "Сучасні панелі";
        public override void BuildRoof() => house.Roof = "Плоский дах";
        public override void BuildWindows() => house.Windows = "Панорамні вікна";
        public override void BuildDoors() => house.Doors = "Скляні двері";
        public override void BuildGarage() => house.Garage = "Вбудований гараж";
        public override void InstallSmartHomeSystem() => house.SmartHome = "Система «Розумний дім»";
    }
}
