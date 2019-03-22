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
            // inicializar valor inicial do ViewBag
            // ViewBag para guardar a resposta
            ViewBag.Resposta = "";

            return View();
        }

        // POST: Home
        // metodo /POST
        [HttpPost]
        // papel deste metodo, HTTP é fazer POST, o que está dentro do []
        // processar os dados do formulario
        // receber os dados que vem do servidor
        // criar um break point ---executar e vai para aqui
        // os tipos primitivos nao podem ser nulos, entao com o int+? pode conter nulos...
        public ActionResult Index(string nome, int? idade)
        {
            // Precisamos de validar os dados introduzidos pelo utilizador
            // 1ª questão: O 'nome' é um nome só em caracteres?
            // 2ª questão: a idade está dentro dos parametros pretendidos [0; 120]?

            // var auxiliar
            string resposta = "";

            //if(nome != "")
            //{
            //    // preparar a resposta a enviar para a View
            //    resposta = "Voce chama-se " + nome;
            //}

            // Validar a idade
            if(idade >= 0 && idade <= 120){
                // criar mensagem da resposta
                resposta = "Voce chama-se " + nome +" e tem " + idade + " anos!";
            }
            else
            {
                // mensagem alternativa
                resposta = "Deve especificar uma idade váilda!\n" +
                            "A idade deve ser maior que zero e menor que 120 anos...";
            }

            // criar o 'contentor' que levará a mensagem para a View
            // enviar a 'resposta' para a view
            ViewBag.Resposta = resposta;

            return View();
        }
    }
}