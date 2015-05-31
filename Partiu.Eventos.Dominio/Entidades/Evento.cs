using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partiu.Eventos.Dominio.Entidades
{
     public class Evento
    {
        public int idEvento { get; set; }
        public String nome { get; set; }
        public String descricao { get; set; }
        public DateTime data { get; set; }
        public int views { get; set; }
        public string local { get; set; }
        public string telefone { get; set; }
    }
}
