using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Projector
    {
        public void On() => Console.WriteLine("Проектор включен");
        public void Off() => Console.WriteLine("Проектор выключен");
        public void SetInput(string input) => Console.WriteLine($"Вход установлен на: {input}");
    }
}
