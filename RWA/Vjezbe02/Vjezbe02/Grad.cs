namespace Vjezbe02
{
    public class Grad
    {
        public int id { get; set; }
        public string naziv { get; set; }
        public int idDrzava { get; set; }

        public Grad() { }

        public Grad(int id, string naziv, int idDrzava)
        {
            this.id = id;
            this.naziv = naziv;
            this.idDrzava = idDrzava;
        }
    }
}