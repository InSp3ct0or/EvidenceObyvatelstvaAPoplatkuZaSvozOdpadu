using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace EvidenceObyvatelstvaAPoplatkuZaSvozOdpadu
{
    public class ZaplacenePoplatky
    {
        public int Id { get; set; } // Добавлено свойство Id
        public int RokPoplatku { get; set; }
        public int ObyvatelId { get; set; } // Внешний ключ для связи с Obyvatel
        public DateTime DatumUhrady { get; set; }
    }
}
