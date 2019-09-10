using System;
using System.Collections.Generic;
using System.Text;

namespace Medix.Dominio.Entidades
{
    public abstract class Entidade
    {
        public List<string> _mensagensValidacao { get; set; }

        private List<string> MensagemValidacao
        {
            get { return _mensagensValidacao ?? (_mensagensValidacao = new List<string>()); }
        }

        protected void AdicionaMensagem(string mensagem)
        {
            MensagemValidacao.Add(mensagem);
        }
        public abstract void Validate();


    }
}

