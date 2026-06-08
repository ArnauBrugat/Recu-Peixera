namespace RecuPeixera
{
    public class Tauro : Animal
    {
public int Edat = 0;
        public Tauro(int x, int y, Sexe s) : base(x, y)
        {
            Sexe = s;
        }
        public override void Moure()
        {
            base.Moure();
            Edat++;
            if (Edat > 75) Viu = false;
        }
        public override void Interaccio(Animal altre, Peixera p)
        {
            if (!Viu || !altre.Viu) return;
            if (altre is Tauro t)
            {
                if (t.Sexe == Sexe)
                {
                    Viu = false;
                    t.Viu = false;
                }
                else
                {
                    p.Afegir(new Tauro(X, Y, (Sexe)r.Next(2)));
                }
            }
            else if (altre is Tortuga)
            {
                Direccio = (Direccio)r.Next(4);
            }
            else
            {
                altre.Viu = false;
            }
        }
    }
}