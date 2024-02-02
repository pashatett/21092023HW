using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarReacing
{
    internal class Car
    {
        public string name;
        public int maxBoost;
        public int distance;
        public double unitOfCalculation;//выдуманные единицы измерения для сравнения машин

        public Random random = new Random();

        public Car(string name, int maxBoost)
        {
            this.name = name;
            this.maxBoost = maxBoost;
        }
        public virtual void Racing()
        {
            while (distance < 100)
            {
                maxBoost += random.Next(1, maxBoost);
                distance += maxBoost;
            }
            unitOfCalculation = (double)distance / (double)maxBoost;
        }
        public virtual void Finish()
        {
            Console.WriteLine($"Победил {name}");
            return;
        }
    }
    class SportCar : Car
    {
        public SportCar(string name, int maxBoost) : base(name, maxBoost) { }
        public override void Racing()
        {
            base.Racing();
        }
        public override void Finish()
        {
            base.Finish();
        }
    }

    class Bus : Car
    {
        public Bus(string name, int maxBoost) : base(name, maxBoost) { }
        public override void Racing()
        {
            base.Racing();
        }
        public override void Finish()
        {
            base.Finish();
        }
    }

    class Passeger : Car
    {
        public Passeger(string name, int maxBoost) : base(name, maxBoost) { }
        public override void Racing()
        {
            base.Racing();
        }
        public override void Finish()
        {
            base.Finish();
        }
    }

    class Track : Car
    {
        public Track(string name, int maxBoost) : base(name, maxBoost) { }
        public override void Racing()
        {
            base.Racing();
        }
        public override void Finish()
        {
            base.Finish();
        }
    }
}