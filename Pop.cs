namespace RecuPeixera
{
    public class Pop : Animal
    {
        int fase = 0;
        public Pop(int x, int y) : base(x, y)
        {
            Sexe = null;
        }
        public override void Moure()
        {
            if (fase == 0) X++;
            else if (fase == 1) Y++;
            else if (fase == 2) X--;
            else Y--;
            if (X == 19) fase = 1;
            if (Y == 19) fase = 2;
            if (X == 0) fase = 3;
            if (Y == 0) fase = 0;
        }
        public override void Interaccio(Animal altre, Peixera p)
        {
        }
    }
}
