using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Banco_Sul
{
    public partial class NovoCliente : Form
    {

        Cliente novoCliente;
        MySqlConnection conexao;
        

        public NovoCliente()
        {
            InitializeComponent();
            novoCliente = new Cliente();
            conexao = new MySqlConnection("Server = localhost; port = 3306; database = dbabank; user = root; password = ''");
        }

        private void BTN_CadastroCancelar_Click(object sender, EventArgs e)
        {
            //indiquei para o botão cancelar realizar sempre uma confirmação se realmente o usuário quer cancelar
            DialogResult opcao = MessageBox.Show("Deseja Realmente cancelar a ação?", "Confirmação",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //usei a condicional para verificar a resposta do usuário
            if (opcao == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void BTN_CadastroLimpar_Click(object sender, EventArgs e)
        {
            //indiquei para o botão cancelar realizar sempre uma confirmação se realmente o usuário quer cancelar
            DialogResult opcao = MessageBox.Show("Deseja Realmente Limpar os Campos?", "Confirmação",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (opcao==DialogResult.Yes)
            {
                TXTBOX_CadastroNome.Text = "";
                TXTBOX_CadastroDataNasc.Text = "";
                TXTBOX_CadastroCpf.Text = "";
                TXTBOX_CadastroEndereco.Text = "";
                NUMBOX_CadastroSaldo.Value = 0;



            }
        }

        private void BTN_CadastroSalvar_Click(object sender, EventArgs e)
        {
            string sql = "";

            try
            {

                conexao.Open();

                novoCliente.Nome = TXTBOX_CadastroNome.Text;
                novoCliente.DataNasc = TXTBOX_CadastroDataNasc.Text;
                novoCliente.Cpf = TXTBOX_CadastroCpf.Text;
                novoCliente.Endereco = TXTBOX_CadastroEndereco.Text;
                novoCliente.Saldo = Convert.ToDouble(NUMBOX_CadastroSaldo.Value);

                

                sql= "INSERT INTO clientes(nm_cliente,dt_nascimento,cpf_cliente,endereco_cliente,saldo_cliente)" +
                    "VALUES('" + novoCliente.Nome + "','" + novoCliente.DataNasc + "'," +
                    " '" + novoCliente.Cpf + "','" + novoCliente.Endereco + "', '" + novoCliente.Saldo + "')";

                MySqlCommand query = new MySqlCommand(sql, conexao);

                query.ExecuteReader();

                MessageBox.Show("Cliente cadastrado com Sucesso!");

                TXTBOX_CadastroNome.Text = "";
                TXTBOX_CadastroDataNasc.Text = "";
                TXTBOX_CadastroCpf.Text = "";
                TXTBOX_CadastroEndereco.Text = "";
                NUMBOX_CadastroSaldo.Value = 0;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("ERRO!(" + ex.Number + "): " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO!" + ex.Message);
            }

            conexao.Close();
        }
    }
}
