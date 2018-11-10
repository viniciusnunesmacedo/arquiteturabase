namespace ArquiteturaBase.Infraestrutura.Transversal.Identidade.Modelos.GerenciarContaModelosTela
{
    /// <summary>
    /// TwoFactorAuthenticationViewModel
    /// </summary>
    public class DoisFatoresAutenticacaoModeloTela
    {
        public bool TemAutenticador { get; set; }

        public int CodigosRecuperacaoDeixados { get; set; }

        public bool DoisFatoresEstaAtivado { get; set; }
    }
}
