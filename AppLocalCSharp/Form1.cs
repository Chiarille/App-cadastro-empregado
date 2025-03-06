using System;
using System.Windows.Forms;
namespace AppLocalCSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonPesquisar_Click(object sender, EventArgs e)
        {
            Pesquisar();
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            Salvar();
        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            Excluir();
        }

        private void Pesquisar()
        {
            Empregado empregado = new Empregado
            {
                Matricula = string.IsNullOrEmpty(textMatricula.Text) ? 0 : int.Parse(textMatricula.Text),
                Cpf = textCpf.Text,
                Nome = textNome.Text
            };
            dataGridViewEmpregado.DataSource = empregado.Pesquisar();
        }

        private void Salvar()
        {
            Empregado empregado = new Empregado
            {
                Matricula = string.IsNullOrEmpty(textMatricula.Text) ? 0 : int.Parse(textMatricula.Text),
                Cpf = textCpf.Text,
                Nome = textNome.Text,
                Endereco = textEndereco.Text
            };

            if (empregado.Matricula == 0)
                empregado.Incluir();
            else
                empregado.Alterar();

            Limpar();
            Pesquisar();
        }
        private void Excluir()
        {
            if (!string.IsNullOrEmpty(textMatricula.Text))
            {
                Empregado empregado = new Empregado
                {
                    Matricula = int.Parse(textMatricula.Text)
                };
                empregado.Excluir();
                Limpar();
                Pesquisar();
            }
        }
        private void Limpar()
        {
            textMatricula.Clear();
            textCpf.Clear();
            textNome.Clear();
            textEndereco.Clear();
        }

    }
}

