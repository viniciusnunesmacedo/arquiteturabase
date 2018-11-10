using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace ArquiteturaBase.Infraestrutura.Transversal.Identidade.Modelos.GerenciarContaModelosTela
{
    /// <summary>
    /// ExternalLoginsViewModel
    /// </summary>
    public class ContasExternasModeloTela
    {
        public IList<UserLoginInfo> ContasAtuais { get; set; }

        public IList<AuthenticationScheme> OutrasContas { get; set; }

        public bool ExibirBotaoExcluir { get; set; }

        public string MensagemStatus { get; set; }
    }
}
