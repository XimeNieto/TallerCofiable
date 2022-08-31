using Microsoft.AspNetCore.Mvc;
using TallerCofiable.datos;
using TallerCofiable.Models;



namespace TallerMecanico.Controllers
{
    public class MantenedorController : Controller
    {
        PersonaDatos PersonaDatos = new PersonaDatos();
        public IActionResult Listar()
        {
            //LA LISTA MOSTRARÁ UNA LISTA DE PERSONAS
            var oLista = PersonaDatos.Listar();

            return View(oLista);
        }
        public IActionResult Guardar()
        {
            //METODO SOLO DEVUELVE LA LISTA
            return View();
        }

        [HttpPost]
        public IActionResult Guardar(personaModelo oPersona)
        {
            //METODO RECIBE EL OBJETO PARA GUARDARLO EN DB
            if (!ModelState.IsValid)
                return View();

            var respuesta = PersonaDatos.Guardar(oPersona);

            if (respuesta)
                return RedirectToAction("Listar");
            else
                return View();
        }
        public IActionResult Editar(int IdPersona)
        {
            var oPersona = PersonaDatos.Obtener(IdPersona);
            return View(oPersona);
        }

        [HttpPost]
        public IActionResult Editar(personaModelo oPersona)
        {
            if (!ModelState.IsValid)
                return View();


            var respuesta = PersonaDatos.Editar(oPersona);

            if (respuesta)
                return RedirectToAction("Listar");
            else
                return View();
        }

        public IActionResult Eliminar(int IdPersona)
        {
            //METODO SOLO DEVUELVE LA VISTA
            var opersona = PersonaDatos.Obtener(IdPersona);
            return View(opersona);
        }

        [HttpPost]
        public IActionResult Eliminar(personaModelo oPersona)
        {

            var respuesta = PersonaDatos.Eliminar(oPersona.IdPersona);

            if (respuesta)
                return RedirectToAction("Listar");
            else
                return View();
        }

    }
}
