using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPZLAB5
{
    public class House
    {
        public string Foundation { get; set; }
        public string Walls { get; set; }
        public string Roof { get; set; }
        public string Windows { get; set; }
        public string Doors { get; set; }
        public string Garage { get; set; }
        public string SmartHome { get; set; }
        public string Chimney { get; set; }

        public string ShowInfo()
        {
            return $"Фундамент: {Foundation}{Environment.NewLine}" +
           $"Стіни: {Walls}{Environment.NewLine}" +
           $"Дах: {Roof}{Environment.NewLine}" +
           $"Вікна: {Windows}{Environment.NewLine}" +
           $"Двері: {Doors}{Environment.NewLine}" +
           (Garage != null ? $"Гараж: {Garage}{Environment.NewLine}" : "") +
           (SmartHome != null ? $"Розумний дім: {SmartHome}{Environment.NewLine}" : "") +
           (Chimney != null ? $"Димохід: {Chimney}{Environment.NewLine}" : "");
        }
    }
}
