namespace DLWMS.Data
{
    public class Student
    {
        public int Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public string Email { get; set; }
        public string BrojIndeksa { get; set; }
        public string Lozinka { get; set; }
        public int GradId { get; set; }
        public Grad Grad { get; set; }
        public int SpolId { get; set; }
        public Spol Spol { get; set; }
        public byte[] Slika { get; set; }
        public bool Aktivan { get; set; }


        public string IndexImePrezime => $"({BrojIndeksa}) {Ime} {Prezime}";
        public string imeDrzave => $"({Grad?.Drzava?.Naziv}" ?? "Nema";
        public string imeGrada => $"{Grad?.Naziv}" ?? "Nema";
        public string ImeSpola => $"{Spol?.Naziv}" ?? "Nema";
        public override string ToString()
        {
            return $"{Ime } {Prezime }";
        }
    }
}