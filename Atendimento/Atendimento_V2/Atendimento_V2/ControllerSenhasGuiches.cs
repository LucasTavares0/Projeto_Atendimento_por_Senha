using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atendimento_V2
{
    class ControllerSenhasGuiches
    {
        //atributos - Classes performadoras
        private Guiches listaGuiches;
        private Senhas filaSenhas;
        
        public ControllerSenhasGuiches()
        {
            this.filaSenhas = new Senhas();
            this.listaGuiches = new Guiches();
        }

        public bool gerarSenha()
        {
            try
            {
                filaSenhas.gerarSenha();
                return true;
            }
            catch(Exception)
            {
                return false;
            }
        }

        public List<string> listarSenhas(int id)
        {   
            if(id > 0) return listaGuiches.dadosResumidosGuiche(id);
            else return filaSenhas.dadosResumido();
        }

        public bool adicionarGuiche()
        {
            try
            {
                listaGuiches.adicionarGuiche();
                return true;
            }
            catch(Exception)
            {
                return false;
            }
        }

        public int contarGuiches()
        {
            return listaGuiches.contarGuiches();
        }

        public bool guicheExiste(int idGuiche)
        {
            if (listaGuiches.getGuiche(idGuiche) != null) return true;
            else return false;
        }

        public bool chamarSenhaNoGuiche(int idGuiche)
        {
            try
            {
                Guiche guiche = listaGuiches.getGuiche(idGuiche);
                guiche.chamarSenha(filaSenhas.getSenha());
                return true;
            }
            catch(Exception)
            {
                return false;
            }
        }
    }
}
