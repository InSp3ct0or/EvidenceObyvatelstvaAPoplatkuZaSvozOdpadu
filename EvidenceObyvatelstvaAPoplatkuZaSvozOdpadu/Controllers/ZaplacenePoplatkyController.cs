using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidenceObyvatelstvaAPoplatkuZaSvozOdpadu
{
    public class ZaplacenePoplatkyController
    {
        private List<ZaplacenePoplatky> zaplacenePoplatky;

        public ZaplacenePoplatkyController()
        {
            zaplacenePoplatky = new List<ZaplacenePoplatky>();
        }

        public void Create(ZaplacenePoplatky zaplacenePoplatek)
        {
            zaplacenePoplatky.Add(zaplacenePoplatek);
        }

        public List<ZaplacenePoplatky> GetAll()
        {
            return zaplacenePoplatky;
        }

        public ZaplacenePoplatky GetById(int id)
        {
            return zaplacenePoplatky.FirstOrDefault(z => z.ObyvatelId == id);
        }

        public void Update(int id, ZaplacenePoplatky updatedZaplacenePoplatky)
        {
            var existingZaplacenePoplatky = zaplacenePoplatky.FirstOrDefault(z => z.ObyvatelId == id);
            if (existingZaplacenePoplatky != null)
            {
                existingZaplacenePoplatky.RokPoplatku = updatedZaplacenePoplatky.RokPoplatku;
                existingZaplacenePoplatky.DatumUhrady = updatedZaplacenePoplatky.DatumUhrady;
            }
        }

        public void Delete(int id)
        {
            var existingZaplacenePoplatky = zaplacenePoplatky.FirstOrDefault(z => z.ObyvatelId == id);
            if (existingZaplacenePoplatky != null)
            {
                zaplacenePoplatky.Remove(existingZaplacenePoplatky);
            }
        }
    }
}