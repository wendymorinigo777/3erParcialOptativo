using System.ComponentModel.DataAnnotations;

namespace OptativoTercerParcial.Models
{
    public class Usuario
    {
        public int IDUSUARIO { get; set; }
        public int IDPERSONA { get; set; }
        public string NOMBREUSUARIO { get; set; }
        public string CONTRASEÑA { get; set; }
        public string NIVEL { get; set; }
        public string ESTADO { get; set; }
        // Propiedad de navegación
        public Persona Persona { get; set; }
    }
}
