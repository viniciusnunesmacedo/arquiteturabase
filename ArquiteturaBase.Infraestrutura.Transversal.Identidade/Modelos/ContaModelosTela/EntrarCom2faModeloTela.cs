using System.ComponentModel.DataAnnotations;

namespace ArquiteturaBase.Infraestrutura.Transversal.Identidade.Modelos.ContaModelosTela
{
    /// <summary>
    /// LoginWith2faViewModel
    /// </summary>
    public class EntrarCom2faModeloTela
    {
        [Required]
        [StringLength(7, ErrorMessage = "O {0} deve ter pelo menos {2} e no máximo {1} caracteres.", MinimumLength = 6)]
        [DataType(DataType.Text)]
        [Display(Name = "Código autenticador")]
        public string TwoFactorCode { get; set; }

        [Display(Name = "Lembre-se desta máquina")]
        public bool RegistrarEscolhaMaquina { get; set; }

        public bool RegistrarEscolha { get; set; }
    }
}
