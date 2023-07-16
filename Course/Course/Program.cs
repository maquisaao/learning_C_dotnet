using System;
using System.Globalization;
using System.Xml.Schema;

namespace Course {
    internal class Program {
        static void Main(string[] args) {

            double A, B, C, tri, pi = 3.14159, cir, trap, ret, quad;


            string[] valores = Console.ReadLine().Split(' ');
            A = double.Parse(valores[0], CultureInfo.InvariantCulture);
            B = double.Parse(valores[1], CultureInfo.InvariantCulture);
            C = double.Parse(valores[2], CultureInfo.InvariantCulture);

            tri = (A * C)/2;
            cir = pi * C * C;
            trap = ((A+B)*C)/ 2;
            quad = B * B;
            ret = A * B;

            Console.WriteLine("TRIANGULO: "+tri.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("CIRCULO: " + cir.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPEZIO: " + trap.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO: " + quad.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("RETANGULO: " + ret.ToString("F3", CultureInfo.InvariantCulture));




        }
    }
}
