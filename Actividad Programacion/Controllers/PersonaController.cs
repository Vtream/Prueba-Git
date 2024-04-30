using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Actividad_Programacion.Models;

namespace Actividad_Programacion.Controllers
{
    public class PersonaController : Controller
    {
        // GET: Persona
        public ActionResult Index()
        {
            List<Persona> lista = new List<Persona>();
           
            Persona Per1 = new Persona();
            Per1.Id= 1;
            Per1.Nombre = "Ricardo";
            Per1.PrimerApellido = "Castelblanco";
            Per1.SegundoApelldio = "Sepulveda";
            lista.Add(Per1);

            Persona Per2 = new Persona();
            Per2.Id = 2;
            Per2.Nombre = "Juan";
            Per2.PrimerApellido = "Castro";
            Per2.SegundoApelldio = "Segura";
            lista.Add(Per2);

            Persona Per3 = new Persona();
            Per3.Id = 3;
            Per3.Nombre = "Pepito";
            Per3.PrimerApellido = "Perez";
            Per3.SegundoApelldio = "Suarez";
            lista.Add(Per3);

            return View(lista);
        }
    }
}