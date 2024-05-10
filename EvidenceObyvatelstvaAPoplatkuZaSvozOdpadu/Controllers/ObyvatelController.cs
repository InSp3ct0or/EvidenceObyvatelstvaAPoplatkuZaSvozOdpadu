using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace EvidenceObyvatelstvaAPoplatkuZaSvozOdpadu
{
    public class ObyvatelController
    {
        private List<Obyvatel> obyvatele;

        public ObyvatelController()
        {
            obyvatele = new List<Obyvatel>();
        }

        public void Create(Obyvatel obyvatel)
        {
            obyvatele.Add(obyvatel);
        }

        public List<Obyvatel> GetAll()
        {
            return obyvatele;
        }

        public Obyvatel GetById(int id)
        {
            return obyvatele.FirstOrDefault(o => o.ObyvatelId == id);
        }

        public void Update(int id, Obyvatel updatedObyvatel)
        {
            var existingObyvatel = obyvatele.FirstOrDefault(o => o.ObyvatelId == id);
            if (existingObyvatel != null)
            {
                existingObyvatel.Jmeno = updatedObyvatel.Jmeno;
                existingObyvatel.Prijmeni = updatedObyvatel.Prijmeni;
                existingObyvatel.BytovaJednotkaId = updatedObyvatel.BytovaJednotkaId;
            }
        }

        public void Delete(int id)
        {
            var existingObyvatel = obyvatele.FirstOrDefault(o => o.ObyvatelId == id);
            if (existingObyvatel != null)
            {
                obyvatele.Remove(existingObyvatel);
            }
        }
    }
}
