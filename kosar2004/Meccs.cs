namespace kosar2004
{
    internal class Meccs
    {
        public string Hazai { get; private set; }
        public string Idegen { get; private set; }
        public int Hpont { get; private set; }
        public int Ipont { get; private set; }
        public string Hely { get; private set; }
        public string Ido { get; private set; }

        public Meccs(string hazai, string idegen, int hpont, int ipont, string hely, string ido)
        {
            this.Hazai = hazai;
            this.Idegen = idegen;
            this.Hpont = hpont;
            this.Ipont = ipont;
            this.Hely = hely;
            this.Ido = ido;

        }
    }
}