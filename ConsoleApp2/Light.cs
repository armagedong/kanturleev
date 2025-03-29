using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Light
    {
        public void On() => Console.WriteLine("Свет включен");
        public void Off() => Console.WriteLine("Свет выключен");
        public void RGBLIghtOn() => Console.WriteLine("RGB-подсветка включена");
        public void RGBLIghtOff() => Console.WriteLine("RGB-подсветка выключена");
        public void SetLight(int lvl) => Console.WriteLine($"Яркость подсветки установлена на {lvl}");

    }
}
