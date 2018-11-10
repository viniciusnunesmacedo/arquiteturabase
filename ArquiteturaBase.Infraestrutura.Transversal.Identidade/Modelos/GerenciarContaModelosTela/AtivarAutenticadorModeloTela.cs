using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ArquiteturaBase.Infraestrutura.Transversal.Identidade.Modelos.GerenciarContaModelosTela
{
    /// <summary>
    /// EnableAuthenticatorViewModel
    /// </summary>
    public class AtivarAutenticadorModeloTela
    {
        [Required]
        [StringLength(7, ErrorMessage = "O {0} deve ter pelo menos {2} e no máximo {1} caracteres.", MinimumLength = 6)]
        [DataType(DataType.Text)]
        [Display(Name = "Código de verificação")]
        public string Codigo { get; set; }

        [ReadOnly(true)]
        public string ChaveCompartilhada { get; set; }

        public string EnderecoAutenticador { get; set; }
    }
}
