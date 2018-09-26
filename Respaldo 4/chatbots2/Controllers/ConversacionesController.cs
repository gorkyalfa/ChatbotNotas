using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace chatbots2.Controllers
{
    public class ConversacionesController : Controller
    {
        // GET: Conversaciones
        public ActionResult Index()
        {
            return View();
        }
              
  
        // POST: Conversaciones/Index
        [HttpPost]
        public ActionResult Index(FormCollection collection)
        {
            // todo: la pregunta que llegue enviar al luis
            // todo: la respuesta del luis procesar
            // todo: lo procesado enviar a notas(si corresponde)
            // todo: lo devuelto por notas dibujar en la pagina
            return View();
        }   
        public ActionResult Chat()
        {
            return View();
        }
    }
}
