using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Pro1.Models
{
    public class RegisAlum
    {
     
        [Required]
        [Display(Name ="Nombres",Prompt ="Nombres Completos")]  
        public string? Nombres {get; set;}
        [Required]
        [Display(Name ="Apellidos",Prompt ="Apellidos Completos")]  
        public string? Apellidos {get; set;}
        [Required]
        [Display(Name ="Correo",Prompt ="Correo Electonico")] 
        public string? Correo {get; set;}
        [Required]
        [Display(Name ="Semestre",Prompt ="Semestre")] 
        public string? Semestre {get; set;}
        public bool Matematica{get;set;}
        public bool Lenguaje{get;set;}
        public bool Historia{get;set;}
      
        

    }
}