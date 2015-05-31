
using Partiu.Eventos.Dominio.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Partiu.Eventos.Web.Controllers
{
    public class EventoController : Controller
    {

        public EventosRepositorio _repositorio;
        // GET: Evento
        public ActionResult Index()
        {
            _repositorio = new EventosRepositorio();

            var eventos = _repositorio.Evento.Take(5); 


            return View();

        }
    }
}