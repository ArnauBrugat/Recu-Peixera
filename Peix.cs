namespace RecuPeixera
{
public class Peix : Animal
    {
        public Peix(int x, int y, Sexe s) : base(x, y)
        {
            Sexe = s;
        }
        public override void Interaccio(Animal altre, Peixera p)
        {
            if (!Viu || !altre.Viu) return;
            if (altre is Peix px)
            {
                if (px.Sexe == Sexe)
                {
                    Viu = false;
                    px.Viu = false;
                }
                else
                {
                    p.Afegir(new Peix(X, Y, (Sexe)r.Next(2)));
                }
            }
            else if (altre is Tauro)
            {
            Viu = false;
            }
        }
    }
}