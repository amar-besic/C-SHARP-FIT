using FIT.Data.IspitIB210178;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;

namespace FIT.Data
{
    public class Student
    {
        
        public int Id { get; set; }
        public string Indeks { get; set; }
        public string Lozinka { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Email { get; set; }
        public byte[] Slika { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public bool Aktivan { get; set; }        
        public int SemestarId { get; set; }
        public int GradId { get; set; } // 
        public GradoviIB210178 Grad { get; set; } 

        public string NazivGrada => Grad.Naziv ?? "Nema grada"; 
        public string NazivDrzave => Grad.Drzava.Naziv ?? "Nema ";

        [NotMapped] public double  prosjek { get; set; }

        public override string ToString()
        {
            return $"{Indeks} {Ime} {Prezime}";
        }
    }
}
