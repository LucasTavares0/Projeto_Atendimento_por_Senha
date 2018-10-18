using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atendimento_V2
{
    class Guiches
    {
        //atributos
        private int proximoGuiche;
        private List<Guiche> listaGuiches;

        //propriedades getter e setter
        public void setProximoGuiche(int value)
        {
            this.proximoGuiche += value;
        }
        public int getProximoGuiche()
        {
            return this.proximoGuiche;
        }
        public void setGuiche(Guiche guiche)
        {
            this.listaGuiches.Add(guiche);
            setProximoGuiche(1);
        }
        public Guiche getGuiche(int id)
        {
            Guiche guiche = new Guiche(id);

            foreach(Guiche g in listaGuiches)
            {
                if(g.getId() == id)
                {
                    guiche = g;
                    break;
                }
                else
                {
                    guiche = null;
                }
            }
            return guiche;
        }

        //Construtores
        public Guiches()
        {
            this.listaGuiches = new List<Guiche>();
            setProximoGuiche(1);
        }

        //métodos funcionais
        public void adicionarGuiche()
        {
            Guiche guiche = new Guiche(getProximoGuiche());
            setGuiche(guiche);
        }

        public int contarGuiches()
        {
            return this.listaGuiches.Count;
        }

        public List<string> dadosResumidosGuiche(int id)
        {
            Guiche guiche = getGuiche(id);
            return guiche.dadosResumido();
        }
    }
}























