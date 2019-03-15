using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Formulario.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            // responde ao GET porque é o que ele responde por defeito no HTTP...
            // necessario para ter um valor para o razor
            // para inicializar a variavel
            ViewBag.Resposta = "";

            return View();
        }

        // POST: Home
        [HttpPost]
        // papel deste metodo, HTTP e faz POST, o que está dentro do []
        // porcessar os dados do formulario
        // receber os dados quem do servidor
        // criar um break point ---executar e vai para aqui
        public ActionResult Index(string nome, int? idade)
            //os tipos primitivos nao podem ser nulos, entao com o int+? pode conter nulos...
        {
            // var auxiliar
            string resposta = "";

            if (nome != "") { 
            //preparar a resposta a enviar para a view
            resposta = "Você chama-se " + nome + "e tem " + idade + " anos!";
            }

            if(idade != null) {
            resposta = "e tem " + idade + " anos!";

            }

            // enviar a "resposta" para a view
            ViewBag.Resposta = resposta;

            

            return View();
        }
    }
}