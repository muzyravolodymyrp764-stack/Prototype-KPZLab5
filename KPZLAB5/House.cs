using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
namespace KPZLAB5
{
    public class House
    {
        [Category("Основні компоненти")]
        public string Foundation { get; set; }
        [Category("Основні компоненти")]
        public string Walls { get; set; }
        [Category("Основні компоненти")]
        public string Roof { get; set; }
        [Category("Основні компоненти")]
        public string Windows { get; set; }
        [Category("Основні компоненти")]
        public string Doors { get; set; }

        [Category("Додатково")]
        public string Garage { get; set; }
        [Category("Додатково")]
        public string SmartHome { get; set; }
        [Category("Додатково")]
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
        public object Clone()
        {
            return MemberwiseClone();
        }


    }

}
