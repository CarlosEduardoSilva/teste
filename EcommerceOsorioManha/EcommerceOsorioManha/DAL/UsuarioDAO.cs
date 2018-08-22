using EcommerceOsorioManha.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EcommerceOsorioManha.DAL
{
    public class UsuarioDAO
    {
        private static Context ctx = SingletonContext.GetInstance();

        public static Usuario Logar(Usuario usuario)
        {
            var usuarioLogado = ctx.Usuarios.Where(x => x.Login.Equals(usuario.Login) && x.Login.Equals(usuario.Senha)).FirstOrDefault();

            if (usuarioLogado == null)
                return null;
            else
                return usuarioLogado;
        }


    }
}