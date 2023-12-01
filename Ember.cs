namespace WFA231201
{
    public class Ember
    {
        public string Nev { get; set; }
        public DateTime Szul { get; set; }
        public bool VanLova { get; set; }

        public override string ToString()
        {
            return $"{Nev};{Szul:yyyy-MM-dd};{(VanLova ? "igen" : "nem")}";
        }

        public Ember(string nev, DateTime szul, bool vanLova)
        {
            Nev = nev;
            Szul = szul;
            VanLova = vanLova;
        }
    }
}
