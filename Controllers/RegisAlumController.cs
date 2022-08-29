using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Pro1.Models;

namespace Pro1.Controllers
{
    
    public class RegisAlumController : Controller
    {
        private readonly ILogger<RegisAlumController> _logger;

        public RegisAlumController(ILogger<RegisAlumController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
         public IActionResult Regis(RegisAlum objRegisAlum)
       {   
            String? nom=objRegisAlum.Nombres;
            String? ape=objRegisAlum.Apellidos;
            String? correo=objRegisAlum.Correo;
            String? Sem=objRegisAlum.Semestre;
            bool mate=objRegisAlum.Matematica;
            bool leng=objRegisAlum.Lenguaje;
            bool hist=objRegisAlum.Historia;
            if(mate==false && leng==false && hist==false){
                ViewData["Error"]="Debe elegir al menos un curso";
            }else{
                double precioM=0,precioL=0,precioH=0;
                if(mate==true){
                    precioM=300;
                }
                if(leng==true){
                    precioL=300;
                }
                if(hist==true){
                    precioH=300;
                }
                double subTotal,IGV,total;
                subTotal=precioM+precioL+precioH;
                IGV=(subTotal*18)/100;
                total=subTotal+IGV;

                ViewData["Nombres"]=nom;
                ViewData["Apellidos"]=ape;
                ViewData["Semestre"]="Semestre "+Sem;
                ViewData["Mensaje"]="Se ha registrado Satisfactoriamente";
                ViewData["SubTotal"]="Sub Total: S/."+subTotal;
                ViewData["IGV"]="IGV(18%): S/."+IGV;
                ViewData["Total"]="Total: S/."+total;
            }
            return View("Index");
            
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}