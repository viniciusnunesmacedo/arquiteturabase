using System.ComponentModel.DataAnnotations;

namespace ArquiteturaBase.Infraestrutura.Transversal.Identidade.Modelos.GerenciarContaModelosTela
{
    /// <summary>
    /// ChangePasswordViewModel
    /// </summary>
    public class AlterarSenhaModeloTela
    {
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Senha atual")]
        public string SenhaAtual { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "O {0} deve ter pelo menos {2} e no máximo {1} caracteres.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Nova senha")]
        public string NovaSenha { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirme a nova senha")]
        [Compare("NewPassword", ErrorMessage = "A nova senha e a senha de confirmação não correspondem.")]
        public string ConfirmeNovaSenha { get; set; }

        public string MensagemStatus { get; set; }
    }
}
