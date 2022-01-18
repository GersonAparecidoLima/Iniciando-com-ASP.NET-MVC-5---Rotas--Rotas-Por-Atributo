using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;

namespace WebApplication1.Controllers
{
    // configurando um prefixo
    // Não e recomendado colocar RoutePrefix na controller Homme por que ele já e um rota inicial
    // aqui estamos utilizando para o nosso aprendizagem
    // aqui estamos chamando Principal
    //[RoutePrefix("Principal")]
    // aqui estamos chamado vazio 
    // por que tudo que estiver vazio, vem para este controller
    [Route("")]
    public class HomeController : Controller
    {
        // ActionResult e um generico        
        public ActionResult Index()
        {
            return View();
            // return Content("ops");
            //return Redirect("http://www.google.com");
        }

        //retorna um conteudo
        // caso queira usar ActionResult pode
        public ContentResult ContentResult() {
            return Content("ops");
        }


        // caso queira usar ActionResult pode
        // Nomeando o controller About para 
        // sobre nos
        // lembrando que e necessário configurar App_Start\RouteConfig.cs 
        // com o seguinte comando routes.MapMvcAttributeRoutes();
        // https:/ /localhost:44377/sobre-nos
        [Route(template:"sobre-nos" )]
        public ActionResult About()
        {
            ViewBag.Message = "Sua página de descrição do aplicativo.";

            return View();
            
        }

        // caso queira usar ActionResult pode
        //https:/ /localhost:44377/institucional/entre-em-contato
        [Route(template:"institucional/entre-em-contato")]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}