using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EvidenceObyvatelstvaAPoplatkuZaSvozOdpadu
{
    public class BytovaJednotkaController
    {
        private List<BytovaJednotka> bytoveJednotky;

        public BytovaJednotkaController()
        {
            bytoveJednotky = new List<BytovaJednotka>();
        }

        public void Create(BytovaJednotka bytovaJednotka)
        {
            bytoveJednotky.Add(bytovaJednotka);
        }

        public List<BytovaJednotka> GetAll()
        {
            return bytoveJednotky;
        }

        public BytovaJednotka GetById(int id)
        {
            return bytoveJednotky.FirstOrDefault(b => b.BytovaJednotkaId == id);
        }

        public void Update(int id, BytovaJednotka updatedBytovaJednotka)
        {
            var existingBytovaJednotka = bytoveJednotky.FirstOrDefault(b => b.BytovaJednotkaId == id);
            if (existingBytovaJednotka != null)
            {
                existingBytovaJednotka.Adresa = updatedBytovaJednotka.Adresa;
                existingBytovaJednotka.VyskaPoplatkuZaObyvatele = updatedBytovaJednotka.VyskaPoplatkuZaObyvatele;
            }
        }

        public void Delete(int id)
        {
            var existingBytovaJednotka = bytoveJednotky.FirstOrDefault(b => b.BytovaJednotkaId == id);
            if (existingBytovaJednotka != null)
            {
                bytoveJednotky.Remove(existingBytovaJednotka);
            }
        }
    }
}

