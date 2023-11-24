using System.ComponentModel.DataAnnotations;

namespace OptativoTercerParcial.Models
{
    public class Usuario
    {
        public int ID_USUARIO { get; set; }
        public int ID_PERSONA { get; set; }
        public string NOMBRE_USUARIO { get; set; }
        public string CONTRASEÑA { get; set; }
        public string NIVEL { get; set; }
        public string ESTADO { get; set; }
        // Propiedad de navegación
        public Persona Persona { get; set; }
    }
}
