using System.ComponentModel.DataAnnotations;

namespace ArquiteturaBase.Infraestrutura.Transversal.Identidade.Modelos.ContaModelosTela
{
    /// <summary>
    /// ForgotPasswordViewModel
    /// </summary>
    public class EsqueceuSenhaModeloTela
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
