using System;
using System.Collections.Generic;
using System.Linq;

namespace RecuPeixera
{
    public class Peixera
    {
        public List<Animal> Animals = new List<Animal>();
        List<Animal> nous = new List<Animal>();
        public void Afegir(Animal a)
        {
            nous.Add(a);
        }
        public void Ronda()
        {
            foreach (var a in Animals) a.Moure();
            var grups = Animals.GroupBy(a => (a.X, a.Y));
            foreach (var g in grups)
            {
                var ll = g.ToList();
                for (int i = 0; i < ll.Count; i++)
                {
                    for (int j = i + 1; j < ll.Count; j++)
                    {
                        ll[i].Interaccio(ll[j], this);
                        ll[j].Interaccio(ll[i], this);
                    }
                }
            }
            Animals.AddRange(nous);
            nous.Clear();
            Animals = Animals.Where(a => a.Viu).ToList();
        }
        public void Stats()
        {
            Console.WriteLine("Peixos: " + Animals.Count(a => a is Peix));
            Console.WriteLine("Tiburons: " + Animals.Count(a => a is Tauro));
            Console.WriteLine("Pops: " + Animals.Count(a => a is Pop));
            Console.WriteLine("Tortugues: " + Animals.Count(a => a is Tortuga));
        }
    }
}