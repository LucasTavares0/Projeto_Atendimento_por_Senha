using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atendimento_V2
{
    public partial class FormAtendimentoPorSenha : Form
    {
        ControllerSenhasGuiches controller;

        public FormAtendimentoPorSenha()
        {
            InitializeComponent();
            this.controller = new ControllerSenhasGuiches();
        }

        private void botaoGerar_Click_1(object sender, EventArgs e)
        {
            if (controller.gerarSenha())
            {
                //MessageBox.Show("");
            }
            else
            {
                MessageBox.Show("Ocorreu um erro. Não foi possível gerar uma nova senha.");
            }
        }

        private void botaoListarSenhas_Click_1(object sender, EventArgs e)
        {
            List<String> lista = controller.listarSenhas(0);

            listBoxSenhas.Items.Clear();
            foreach(String senha in lista)
            {
                listBoxSenhas.Items.Add(senha);
            }
        }

        private void botaoAdicionarGuiche_Click(object sender, EventArgs e)
        {
            if (controller.adicionarGuiche())
            {
                labelQntdGuiches.Text = controller.contarGuiches().ToString();
                MessageBox.Show("Guichê " + labelQntdGuiches.Text + " adicionado com sucesso! ");
            }
            else
            {
                MessageBox.Show("Ocorreu um erro. Não foi possível adicionar um novo guichê! ");
            }
        }

        private void botaoChamar_Click(object sender, EventArgs e)
        {
            if(textBoxNumeroGuiche.Text == "" || textBoxNumeroGuiche.Text == null)
            {
                MessageBox.Show("Por favor. Digite o número do guichê! ");
            }
            else
            {
                if(controller.contarGuiches() <= 0)
                {
                    MessageBox.Show("Não existe nenhum guichê para realizar o atendimento! ");
                }
                else
                {
                    try
                    {
                        if (controller.guicheExiste(int.Parse(textBoxNumeroGuiche.Text)))
                        {
                            if (controller.chamarSenhaNoGuiche(int.Parse(textBoxNumeroGuiche.Text)))
                            {
                                MessageBox.Show("Atendimento realizado com sucesso! ");
                            }
                            else
                            {
                                MessageBox.Show("Não existem senhas a serem atendidas! ");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Esse guichê não está cadastrado! ");
                        }
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Ocorreu um erro! \nO valor inserido deve ser um número.");
                    }
                    catch (Exception em)
                    {
                        MessageBox.Show("Ocorreu um erro! \n" + em.Message);
                    }
                }
            }
        }

        private void botaoListarAtendimentos_Click(object sender, EventArgs e)
        {
            if (controller.contarGuiches() <= 0)
            {
                MessageBox.Show("Não existe nenhum guichê para realizar a listagem! ");
            }
            else
            {
                try
                {
                    if (controller.guicheExiste(int.Parse(textBoxNumeroGuiche.Text)))
                    {
                        List<String> lista = controller.listarSenhas(int.Parse(textBoxNumeroGuiche.Text));

                        listBoxAgendamentos.Items.Clear();
                        foreach (String senha in lista)
                        {
                            listBoxAgendamentos.Items.Add(senha);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Esse guichê não está cadastrado! ");
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("Ocorreu um erro! \nO valor inserido deve ser um número.");
                }
                catch (Exception em)
                {
                    MessageBox.Show("Ocorreu um erro! \n" + em.Message);
                }
            }
        }
    }
}

                