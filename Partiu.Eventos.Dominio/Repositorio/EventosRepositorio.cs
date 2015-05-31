using Partiu.Eventos.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partiu.Eventos.Dominio.Repositorio
{
   public  class EventosRepositorio
    {
       private readonly EfDbContext _context = new EfDbContext();

       public IEnumerable<Evento> Evento
       {
           get { return _context.Evento;  }
       }

  

    }
}
