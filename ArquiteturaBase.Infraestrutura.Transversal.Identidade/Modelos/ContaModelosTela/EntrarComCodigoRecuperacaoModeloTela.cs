using System.ComponentModel.DataAnnotations;

namespace ArquiteturaBase.Infraestrutura.Transversal.Identidade.Modelos.ContaModelosTela
{
    /// <summary>
    /// LoginWithRecoveryCodeViewModel
    /// </summary>
    public class EntrarComCodigoRecuperacaoModeloTela
    {
        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Código de recuperação")]
        public string CodigoRecuperacao { get; set; }
    }
}
