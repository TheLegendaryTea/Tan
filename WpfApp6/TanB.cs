using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp4
{
    internal class TanB : Tangens
    {
        public double Kat1 { get; set; }
        public double Kat2 { get; set; }
        public TanB(double kat1, double kat2)
        {
            Kat1 = kat1;
            Kat2 = kat2;
        }
        public override double Katet1()
        {
            return Kat1;
        }

        public override double Katet2()
        {
            return Kat2;
        }
        public override double TangA()
        {
            return Kat1 / Kat2;
        }
        public override double TangB()
        {
            return Kat2 / Kat1;
        }
        public override double Rad()
        {
            return TangB() * Math.PI / 180;
        }
        public override double Raz()
        {
            return TangB() - TangA();
        }
        public override string Print()
        {
            return $"Катет угла b: {TangB()} \n Угол b в радианах {Rad()} \n Разница тангенса b от a: {Raz()}";
        }

        

    }
}
