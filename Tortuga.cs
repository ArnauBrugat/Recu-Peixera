namespace RecuPeixera
{
    public class Tortuga : Animal
    {
        public Tortuga(int x, int y, Sexe s) : base(x, y)
        {
            Sexe = s;
        }
        public override void Interaccio(Animal altre, Peixera p)
        {
            if (!Viu || !altre.Viu) return;
            if (altre is Tortuga t)
            {
                if (t.Sexe == Sexe)
                {
                    Viu = false;
                    t.Viu = false;
                }
                else
                {
                    p.Afegir(new Tortuga(X, Y, (Sexe)r.Next(2)));
                }
            }
        }
    }
}