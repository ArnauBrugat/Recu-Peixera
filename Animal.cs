using System;

namespace RecuPeixera
{
    public enum Sexe { Mascle, Femella }
    public enum Direccio { Amunt, Avall, Esquerra, Dreta }
    public abstract class Animal
    {
        public int X;
        public int Y;
        public bool Viu = true;
        public Sexe? Sexe;
        public Direccio Direccio;
        protected static Random r = new Random();
        public Animal(int x, int y)
        {
            X = x;
            Y = y;
            Direccio = (Direccio)r.Next(4);
        }
        public virtual void Moure()
        {
            if (Direccio == Direccio.Amunt) Y--;
            else if (Direccio == Direccio.Avall) Y++;
            else if (Direccio == Direccio.Esquerra) X--;
            else X++;
            if (X < 0) X = 19;
            if (X > 19) X = 0;
            if (Y < 0) Y = 19;
            if (Y > 19) Y = 0;
        }
        public abstract void Interaccio(Animal altre, Peixera p);
    }
}