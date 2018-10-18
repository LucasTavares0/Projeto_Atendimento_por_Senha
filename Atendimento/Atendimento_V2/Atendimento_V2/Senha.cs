using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atendimento_V2
{
    class Senha
    {
        //atributos
        private int id;
        private DateTime dtGerac;
        private DateTime hrGerac;
        private DateTime dtAtend;
        private DateTime hrAtend;

        //Propriedades Setter
        public void setId(int value)
        {
            this.id = value;
        }
        public void setDtGerac()
        {
            this.dtGerac = DateTime.Now;
        }
        public void setHrGerac()
        {
            this.hrGerac = DateTime.Now;
        }
        public void setDtAtend()
        {
            this.dtAtend = DateTime.Now;
        }
        public void setHrAtend()
        {
            this.hrAtend = DateTime.Now;
        }

        //Propriedades Getter
        public int getId()
        {
            return this.id;
        }
        public String getDtGerac()
        {
            string aux = this.dtGerac.ToString();
            return aux.Substring(0, 11);
        }
        public String getHrGerac()
        {
            string aux = this.hrGerac.ToString();
            return aux.Substring(10, 6);
        }
        public String getDtAtend()
        {
            string aux = this.dtAtend.ToString();
            return aux.Substring(0, 11);
        }
        public String getHrAtend()
        {
            string aux = this.hrAtend.ToString();
            return aux.Substring(10, 6);
        }

        //Construtor
        public Senha()
        {
            setId(0);
            setDtGerac();
            setHrGerac();
        }
        public Senha(int id)
        {
            setId(id);
            setDtGerac();
            setHrGerac();
        }

        //Métodos funcionais
        public String dadosParciais()
        {
            StringBuilder dados = new StringBuilder();
            dados.Append("ID: " + getId()); dados.Append(" - ");
            dados.Append("Dt: " + getDtGerac()); dados.Append(" - ");
            dados.Append("Hr: " + getHrGerac());
            return dados.ToString();
        }
        public String dadosCompletos()
        {
            StringBuilder dados = new StringBuilder();
            dados.Append(dadosParciais()); dados.Append(" - ");
            dados.Append("Dt.Atend: " + getDtAtend()); dados.Append(" - ");
            dados.Append("Hr.Atend: " + getHrAtend());
            return dados.ToString();
        }
    }

}
