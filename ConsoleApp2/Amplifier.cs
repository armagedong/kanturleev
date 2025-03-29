using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Amplifier
    {
        public void On() => Console.WriteLine("Усилитель включен");
        public void Off() => Console.WriteLine("Усилитель выключен");
        public void SetVolume(int level) => Console.WriteLine($"Уровень громкости установлен на {level}");
    }
}
