using System;

namespace RecuPeixera
{
    internal class Program
    {
        static Random r = new Random();
        static void Main()
        {
            Peixera p = new Peixera();
            for (int i = 0; i < 50; i++)
            {
                p.Animals.Add(new Peix(r.Next(20), r.Next(20), Sexe.Mascle));
                p.Animals.Add(new Peix(r.Next(20), r.Next(20), Sexe.Femella));
            }
            for (int i = 0; i < 10; i++)
            {
                p.Animals.Add(new Tauro(r.Next(20), r.Next(20), Sexe.Mascle));
                p.Animals.Add(new Tauro(r.Next(20), r.Next(20), Sexe.Femella));
            }
            for (int i = 0; i < 15; i++)
                p.Animals.Add(new Pop(r.Next(20), r.Next(20)));
            for (int i = 0; i < 3; i++)
            {
                p.Animals.Add(new Tortuga(r.Next(20), r.Next(20), Sexe.Mascle));
                p.Animals.Add(new Tortuga(r.Next(20), r.Next(20), Sexe.Femella));
            }
            for (int i = 0; i < 100; i++)
                p.Ronda();
            p.Stats();
        }
    }
}