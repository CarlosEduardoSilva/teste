using EcommerceOsorioManha.DAL;
using EcommerceOsorioManha.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EcommerceOsorioManha.Controllers
{
    public class UsuarioController : Controller
    {
        public ActionResult Logar(Usuario usu)
        {
            var user = UsuarioDAO.Logar(usu);

            if (user != null )
            {
                Session["Usuario"] = user;
                return View();
            }
            else
            {
                return HttpNotFound();
            }


        }
        // GET: Usuario
        public ActionResult Login()
        {


            return View();
        }
    }
}