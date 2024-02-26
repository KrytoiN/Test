namespace Geometry
{
    public class Triangle
    {
        double A;
        double B;
        double C;
        public Triangle()
        {
            A = B = C = 0;
        }

        public Triangle(double sideA, double sideB, double sideC)
        {
            if (sideA < 0)
                throw new ArgumentException("Неверна указана сторона A");
            if (sideB < 0)
                throw new ArgumentException("Неверно указана сторона B");
            if (sideC < 0)
                throw new ArgumentException("Неверно указана сторона C");
            A = sideA;
            B = sideB;
            C = sideC;
        }

        public double sideA { get { return A; } set { A = value; } }
        public double sideB { get { return B; } set { B = value; } }
        public double sideC { get { return C; } set { C = value; } }

        public double Square()
        {
            double p = (A + B + C) / 2;
            return Math.Sqrt(p * ( p - A) * (p - B) * (p - C) );
        }

        public bool isRectangular()
        {
            return (Math.Pow(A, 2) + Math.Pow(B, 2) == Math.Pow(C, 2)) || (Math.Pow(A, 2) + Math.Pow(C, 2) == Math.Pow(B, 2)) || (Math.Pow(B, 2) + Math.Pow(C,2) == Math.Pow(A, 2));
        }

    }

    public class Circle
    {
        double R;
        public Circle()
        {
            R = 0;
        }

        public Circle(double radius)
        {
            if (radius < 0)
                throw new ArgumentException("Неверно указан радиус круга");
            R = radius;
        }

        public double Radius { get { return R; } set { R = value; } }

        public double Square()
        {
            return Math.PI * Math.Pow(R, 2);
        }
    }


}
