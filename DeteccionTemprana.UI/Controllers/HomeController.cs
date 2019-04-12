using System;
using madurativas.db;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using Microsoft.Ajax.Utilities;

namespace madurativas.Controllers
{
    public class HomeController : Controller
    {

        madurativasEntities db = new madurativasEntities();
        public ActionResult Index()
        {

            var pacientesLst = db.Pacientes.Where(p => p.inactivo == false).ToList();

            var pacientesSelectList = new SelectList(pacientesLst, "pacienteId", "FullName");
            ViewBag.Pacientes = pacientesSelectList;

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index([Bind(Include = "pacienteId,fechaestudio,digitado")] estudio estudio)
        {
            if (ModelState.IsValid)
            {
                estudio.eval_riesgos = new eval_riesgos();
                //estudio.mchat = new mchat();

                db.estudios.Add(estudio);
                db.SaveChanges();

                return RedirectToAction("Edit", new {id=estudio.estudioId});
            }

            return View(estudio);

        }


        public ActionResult Edit(int id)
        {
            estudio _estudio = db.estudios.FirstOrDefault(e => e.estudioId == id);

            var pacientesLst = db.Pacientes.Where(p => p.inactivo == false).ToList();

            var pacientesSelectList = new SelectList(pacientesLst, "pacienteId", "FullName");
            ViewBag.Pacientes = pacientesSelectList;

            if (_estudio == null) return new HttpStatusCodeResult(HttpStatusCode.BadRequest);


            return View(_estudio);
        }


        public ActionResult evalRiesgos(int id)
        {
            var eval = db.eval_riesgos.FirstOrDefault(e => e.estudioid == id);

            if(eval == null) return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            ViewBag.px = eval.estudio.Paciente.FullName;
            ViewBag.fnacimiento = eval.estudio.Paciente.fechaNacimiento.Date.ToShortDateString();

            return View(eval);

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public void evalRiesgos(eval_riesgos evalRiesgos)
        {
            if (ModelState.IsValid)
            {
                db.Entry(evalRiesgos).State = EntityState.Modified;

                db.SaveChanges();
            }

            //ViewBag.px = evalRiesgos.estudio.Paciente.FullName;
            //ViewBag.fnacimiento = evalRiesgos.estudio.Paciente.fechaNacimiento.Date.ToShortDateString();

            
        }


        public ActionResult EstudioDelDia()
        {

            var fechaBusqueda = DateTime.Now.AddDays(-1);
            var estudios = db.estudios.ToList();

            return View(estudios);
        }
      
    }


}