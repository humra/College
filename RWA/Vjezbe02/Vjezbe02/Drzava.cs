namespace Vjezbe02
{
    public class Drzava
    {
        public int id { get; set; }
        public string naziv { get; set; }

        public Drzava() { }

        public Drzava(int id, string naziv)
        {
            this.id = id;
            this.naziv = naziv;
        }
    }
}