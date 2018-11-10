using System.ComponentModel.DataAnnotations;

namespace ArquiteturaBase.Infraestrutura.Transversal.Identidade.Modelos.GerenciarContaModelosTela
{
    /// <summary>
    /// IndexViewModel
    /// </summary>
    public class PrincipalModeloTela
    {
        public string Usuario { get; set; }

        public bool EmailEstaConfirmado { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Phone]
        [Display(Name = "Número de telefone")]
        public string NumeroTelefone { get; set; }

        public string MensagemStatus { get; set; }
    }
}
