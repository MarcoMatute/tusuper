using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using TuSuper.BL;

namespace TuSuper.WebAdmin.Controllers
{
    public class LoginController : Controller
    {
        SeguridadBL _seguridadBL;

        public LoginController()
        {
            _seguridadBL = new SeguridadBL();
        }



        // GET: Login
        public ActionResult Index()
        {
            FormsAuthentication.SignOut();
            return View();
        }


        [HttpPost]
        public ActionResult Index (FormCollection data)
        {
            var nombreUsuario = data["username"];
            var contrasena = data["password"];
           var UsuarioValido= _seguridadBL.Autorizar(nombreUsuario, contrasena);
            if (UsuarioValido)
            {
                FormsAuthentication.SetAuthCookie(nombreUsuario, true);
                return RedirectToAction("Index", "Home");
            }
            ModelState.AddModelError("", "Usuario y contrase;a invalido");
            return View();
        }
    }
}