using System;

namespace экз._2_Сухоцький_Іван_ФІТ_2_13
{
    class Konus
    {
        public double Radius { get; set; }
        public double Height { get; set; }


        public Konus(double R, double h)
        {
            Radius = R;
            Height = h;
            R = Convert.ToDouble(Console.ReadLine());
            h = Convert.ToDouble(Console.ReadLine());
        }

        public virtual double Volume()
        {
            return (Math.PI * Radius * Radius * Height) / 3;
        }

        public double Area()
        {
            return Math.PI * Radius * Radius;
        }

        public override string ToString()
        {
            return "Радиус основания R = " + Radius + "\n" + "Высота H = " + Height + "\n" + "Объем V = " + Volume() + "\n" + "Площадь основания S = " + Area() + "\n";
        }
    }

    class Frustum : Konus
    {
        public double radius { get; set; }

        public Frustum(double R, double h, double r) : base(R, h)
        {
            radius = r;
        }
        public override double Volume()
        {
            return (Math.PI * Height * (Radius * Radius + Radius * radius + radius * radius)) / 3;
        }
        public override string ToString()
        {
            return base.ToString() + "Радиус вершины r = " + radius + "\n";
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Konus[] cones = new Konus[4];
            cones[0] = new Konus(1, 2);
            cones[1] = new Konus(2.1, 4.8);
            cones[2] = new Frustum(3.2, 3.5, 1.2);
            cones[3] = new Frustum(4.8, 2.1, 2.1);

            foreach (Konus c in cones)
            {
                Console.WriteLine(c.ToString());
            }
            Console.Read();
        }
    }
}