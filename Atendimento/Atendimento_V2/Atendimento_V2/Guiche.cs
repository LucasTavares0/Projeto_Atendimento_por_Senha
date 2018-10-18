using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atendimento_V2
{
    class Guiche
    {
        //atributos
        private int id;
        private Queue<Senha> atendimentos;

        //Propriedades getter e setters
        public void setId(int value)
        {
            this.id = value;
        }
        public void setSenha(Senha senha)
        {
            this.atendimentos.Enqueue(senha);
        }
        public int getId()
        {
            return this.id;
        }
        public Senha getSenha()
        {
            return this.atendimentos.Dequeue();
        }

        //Construtores
        public Guiche(int id)
        {
            this.atendimentos = new Queue<Senha>();
            setId(id);
        }
        public Guiche()
        {
            this.atendimentos = new Queue<Senha>();
            setId(0);
        }

        //métodos funcionais
        public void chamarSenha(Senha senha) //-- Adiciona uma nova senha aos atendimentos desse guiche
        {
            senha.setDtAtend();
            senha.setHrAtend();
            this.atendimentos.Enqueue(senha);
        }

        public List<String> dadosResumido()
        {
            List<String> senhas = new List<string>();

            foreach (Senha s in this.atendimentos)
            {
                senhas.Add(s.dadosCompletos());
            }
            return senhas;
        }
    }
}
















