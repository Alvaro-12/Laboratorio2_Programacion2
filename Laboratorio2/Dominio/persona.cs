using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Laboratorio2.Dominio
{
    [Table ("Persona")]

    public class persona
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int IdPersona { get; set; }
        [Display (Name = "NombrePersona")]
        [Required (ErrorMessage = "Campo requerido ")]
        [StringLength (50,MinimumLength =3,ErrorMessage = "El nombre de la persona tiene que estar entre 3 y 50 caracteres")]

        public  string NombrePersona { get; set;}
        [Display (Name = "EdadPersona")]
        [Required(ErrorMessage = "Campo requerido ")]
        [Range (18,122, ErrorMessage = "Eres menor de edad no puedes entrar ")]
        public int EdadPersona { get; set; }
        [Display (Name = "DescripcionPersona")]
        [Required(ErrorMessage = "Campo requerido ")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Maximo  50 caracteres")]
        public string DescripcionPersona { get; set; }

         
   
    }
}
