using System;

namespace Course{
    class Program{
        static void Main(string[] args){


            float x = 4.5f; //float tem 4 bytes
            double y = x; //Double tem 8 bytes Aceita por conta dos bytyes e são similares
            Console.WriteLine(y);

            double a;
            float b;
            a = 5.1;
            b = (float)a; //Forçar a conversão implicita, dados podem ser perdidos por conta do numero de bytes

            Console.WriteLine(b);

            double c;
            int d;
            c = 5.1;
            d = (int)c; //Forçar a conversão implicita, dados podem ser perdidos por conta do numero de bytes

            Console.WriteLine(c);
        }
    }
}