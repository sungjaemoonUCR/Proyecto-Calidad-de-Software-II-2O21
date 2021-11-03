﻿//------------------------------------------------------------------------------
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
    using System.Configuration;
    using System.Linq;
    using System.Web;
    using System.ComponentModel.DataAnnotations;
    using System.Data;
    using System.Data.SqlClient;

    public partial class Subasta
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Subasta()
        {
            this.Relacion_ClienteOfertaEnSubasta = new HashSet<Relacion_ClienteOfertaEnSubasta>();
            this.Sublistas = new HashSet<Sublista>();
        }
    
        public int ProductoIDSubastado { get; set; }
        public string CorreoSubastador { get; set; }
        public System.DateTime FechaPublicado { get; set; }
        public double PrecioMinimo { get; set; }
        public System.DateTime FechaInicio { get; set; }
        public System.DateTime FechaFin { get; set; }
        public Nullable<short> Calificacion { get; set; }
        public Nullable<bool> Estado { get; set; }
        public short PublicoEspecial { get; set; }
        public string Mensaje { get; set; }
        public Nullable<bool> EstadoEnvio { get; set; }
    
        public virtual Producto Producto { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Relacion_ClienteOfertaEnSubasta> Relacion_ClienteOfertaEnSubasta { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sublista> Sublistas { get; set; }


        static private string GetConnectionString()
        {
            //El primer string indica la direcci�n del server, esto hay que cambiarlo cuando la base deje de ser local, notese que su utiliza \\ en lugar de \ esto es po un problema de utf-16
            //El segundo es el nombre de la base
            //El tercero maneja las credenciales del usuario que hace la inserci�n, la opci�n que est� ahora es permitida por que es local y  no hay usuarios externos, eso hay que cambiarlo m�s adelante 
            return Properties.Settings.Default.ServerConectionString;
        }
        public string spRelacion_Subasta_Visible_A_Insertar(string correoDuenoSublista, int SublistaId, int productoID, string correoDuenoProducto, DateTime date)
        {
            string connStr = GetConnectionString();
            SqlConnection con = new SqlConnection(connStr);
            SqlCommand getTimeSQLServer = new SqlCommand("SELECT GETDATE() current_date_time", con);
            SqlCommand cmd = new SqlCommand("spRelacion_Subasta_Visible_A_Insertar", con);

            cmd.CommandType = CommandType.StoredProcedure;


            cmd.Parameters.Add("@CorreoDuenoLista", SqlDbType.NVarChar, 50).Value = correoDuenoSublista;
            cmd.Parameters.Add("@SublistaID", SqlDbType.Int).Value = SublistaId;
            cmd.Parameters.Add("@ProductoID", SqlDbType.Int).Value = productoID;
            cmd.Parameters.Add("@CorreoDuenoSubasta", SqlDbType.NVarChar, 50).Value = correoDuenoProducto;
            cmd.Parameters.Add("@FechaPublicado", SqlDbType.DateTime).Value = date;

            try
            {
                con.Open(); //abre la conexi�n con la base
                cmd.ExecuteNonQuery(); //Ejecuta la consulta
                con.Close(); //Cierra la conexi�n
                return "Success";
            }
            catch (Exception es)
            {
                throw es;
            }
        }
    }
}