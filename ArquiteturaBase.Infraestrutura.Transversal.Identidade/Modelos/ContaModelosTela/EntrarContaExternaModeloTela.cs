using System.ComponentModel.DataAnnotations;

namespace ArquiteturaBase.Infraestrutura.Transversal.Identidade.Modelos.ContaModelosTela
{
    /// <summary>
    /// ExternalLoginViewModel
    /// </summary>
    public class EntrarContaExternaModeloTela
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
