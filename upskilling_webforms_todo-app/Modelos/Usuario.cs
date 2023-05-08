using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Web;

namespace upskilling_webforms_todo_app.Modelos
{
    public class Usuario
    {
        public int Id { get; set; }
        public string NomeUsuario { get; set; }
        public Url Avatar { get; set; }
        private static List<Usuario> Usuarios = new List<Usuario> {
            new Usuario { Id = 1, NomeUsuario = "Joao", Avatar = new Url("https://i.pravatar.cc/25?img=1") },
            new Usuario { Id = 2, NomeUsuario = "Maria", Avatar = new Url("https://i.pravatar.cc/25?img=2") },
            new Usuario{ Id = 3, NomeUsuario = "Pedro", Avatar = new Url("https://i.pravatar.cc/25?img=3")}
           };


        public Usuario()
        {




        }

        public static void AdicionarUsuario(Usuario usuario)
        {
            Usuarios.Add(usuario);
        }

        public static Usuario BuscarUsuarioPorNome(string nome)
        {
            return Usuarios.FirstOrDefault(u => u.NomeUsuario == nome);
        }
    }
}