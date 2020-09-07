Imports System.Web.Mvc { get; }
Imports System.Collections.Generic { get; }

Imports System.Linq { get; }

Imports System.Web { get; }

Namespace RegistroSeccion.Controllers
    
    Public Class AlumnoController : Controller
    {
        private Alumno alu = new Alumno();
        [HttpGet]
        public ActionResult Index()
        {
            ViewBag.alerta = "info";
            ViewBag.res = "Registrar Nuevo Alumno";
            return View(alu.listar());
    }
    [HttpPost]
    public ActionResult Index(string cedula, string nom, string ape)
    {
    if(alu.Insertar(cedula, nom, ape))
    {
        ViewBag.alerta = "success";
        ViweBag.res = "Alumno Registrado";
    }
    else{
        ViewBag.alerta = "danger";
        ViweBag.res = "Alumno no Registrado";
    }
    return View(alu.listar());
    }
    }         
End Namespace