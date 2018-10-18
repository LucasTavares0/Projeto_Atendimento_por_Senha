using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atendimento_V2
{
    class Senhas
    {
        //atributos
        private int proximoAtendimento;
        private Queue<Senha> filaSenhas;

        //própriedades getter e setter
        public void setProximoAtendimento(int value)
        {
            this.proximoAtendimento += value;
        }
        public void setSenha(Senha senha)
        {
            this.filaSenhas.Enqueue(senha);
        }
        public int getProximoAtendimento()
        {
            return this.proximoAtendimento;
        }
        public Senha getSenha()
        {
            return this.filaSenhas.Dequeue();
        }

        //Construtor
        public Senhas()
        {
            filaSenhas = new Queue<Senha>();
            setProximoAtendimento(1);
        }

        //métodos funcionais
        public void gerarSenha()
        {
            Senha senha = new Senha(getProximoAtendimento());
            setSenha(senha);
            setProximoAtendimento(1);
        }

        public List<String> dadosResumido()
        {
            List<String> senhas = new List<string>();

            foreach (Senha s in filaSenhas)
            {
                senhas.Add(s.dadosParciais());
            }
            return senhas;
        }

        public int contarSenhas()
        {
            return this.filaSenhas.Count;
        }
    }
}













