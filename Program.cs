using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Создать:
//1)3 разных класса: Пила, Молоток, Инструмент, где Пила и Молоток - это наследники класса Инструмент
//2) фабрику, создающий молоток
//3) фабрику, созд. пилу
namespace BuildingTools
{
    abstract class BuildingTools //Абстрактный класс Строительные инструменты
    {
        protected string handle = ""; //Рукоятка

        public abstract void Use(); // Абстрактный метод Использовать инструмент
    }

    class Hammer : BuildingTools
    {
        new string handle = "дуб"; //Рукоятка

        public override void Use() //Реализуем метод из абстрактного класса
        {
            Console.WriteLine("Держась за рукоятку из {0}а, молотком забил гвоздь", handle);
        }
    }

    class Saw : BuildingTools
    {
       new string handle = "пластик";

        public override void Use()
        {
            Console.WriteLine("Держась за рукоятку из {0}а, пилой отпилил доску", handle);
        }
    }

    class ToolFactory //Одна фабрика с двумя конвейерами по производству молотков и пил
    {
        public BuildingTools CreateHammer()
        {
            return new Hammer();
        }

        public BuildingTools CreateSaw()
        {
            return new Saw();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ToolFactory toolFactory = new ToolFactory();

            BuildingTools hammer1 = toolFactory.CreateHammer();
            BuildingTools saw1 = toolFactory.CreateSaw();

            hammer1.Use();
            saw1.Use();
        }
    }
}
