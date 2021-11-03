//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Proyecto_Inge_Bases_Web.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Apelacion
    {
        public string Correo { get; set; }
        public System.DateTime FechaApelacion { get; set; }
        public System.DateTime FechaDenuncia { get; set; }

        [Required(ErrorMessage = "No puede dejar este espacio en blanco.")]
        [StringLength(199, ErrorMessage = "La apelación no debe de exceder los 200 caracteres.")]
        public string Comentario { get; set; }

        public virtual Denuncia Denuncia { get; set; }
    }
}

