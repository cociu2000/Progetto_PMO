using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneBiblioteca.Classi
{
    public class Restituzione
    {
        public int idLibro { get; set; }
        public int idUtente { get; set; }
        public int idPrenotazione { get; set; }
        public int GiorniRitardo { get; set; }
    }
}
