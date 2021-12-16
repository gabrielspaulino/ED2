using System;
using System.Collections.Generic;
using System.Text;

namespace Empresa
{
    class Log
    {
        private DateTime dtAcesso;
        private Usuario usuario;
        private bool tipoAcesso;

        public DateTime DtAcesso
        {
            get { return dtAcesso; }
        }

        public Usuario Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }

        public bool TipoAcesso
        {
            get { return tipoAcesso; }
            set { tipoAcesso = value; }
        }

        public Log(DateTime dtAcesso, Usuario usuario, bool tipoAcesso)
        {
            this.dtAcesso = dtAcesso;
            this.usuario = usuario;
            this.tipoAcesso = tipoAcesso;
        }

        public Log()
            : this(DateTime.Now, new Usuario(), false)
        { }

        public override string ToString()
        {
            return "Data de acesso: " + dtAcesso + ", Usuário: " + usuario.ToString() + ", Acesso: " + (tipoAcesso ? "autorizado" : "negado");
        }
    }
}
