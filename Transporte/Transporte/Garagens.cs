using System;
using System.Collections.Generic;
using System.Text;

namespace Transporte
{
    class Garagens
    {
        private List<Garagem> listaGaragens;
        private bool jornadaAtiva;
        List<Transporte> transportes;

        public Garagens()
        {
            listaGaragens = new List<Garagem>();
            jornadaAtiva = false;
            transportes = new List<Transporte>();
        }

        public List<Garagem> ListaGaragens
        {
            get { return listaGaragens; }
        }

        public bool JornadaAtiva
        {
            get { return jornadaAtiva; }
        }

        public List<Transporte> Transportes
        {
            get { return transportes; }
        }

        public bool incluir(Garagem garagem)
        {
            if (pesquisarGaragem(garagem) == null)
            {
                listaGaragens.Add(garagem);
                return true;
            }
            return false;
        }

        public void iniciarJornada()
        {
            transportes.Clear();
            jornadaAtiva = true;
        }

        public List<Transporte> encerrarJornada()
        {
            jornadaAtiva = false;
            return transportes;
        }

        public Garagem pesquisarGaragem(Garagem garagem)
        {
            foreach (Garagem g in listaGaragens)
            {
                if (g.Equals(garagem))
                {
                    return g;
                }
            }
            return null;
        }
    }
}
