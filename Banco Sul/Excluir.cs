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
    public partial class Excluir : Form
    {
        Conta conta;
        MySqlConnection conexao;

        public Excluir()
        {
            InitializeComponent();
            conta = new Conta();
            conexao = new MySqlConnection("Server = localhost; port = 3306; database = dbabank; user = root; password = ''");
        }

        private void BTN_ExcluirLimpar_Click(object sender, EventArgs e)
        {
            //indiquei para o botão cancelar realizar sempre uma confirmação se realmente o usuário quer cancelar
            DialogResult opcao = MessageBox.Show("Deseja Realmente Limpar os Campos?", "Confirmação",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (opcao == DialogResult.Yes)
            {
                TXTBOX_excluirDisplay.Text = "";
                NUMBOX_ExcluirCodCliente.Value = 0;





            }
        }

        private void BTN_ExcluirCancelar_Click(object sender, EventArgs e)
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

        private void BTN_ExcluirBuscar_Click(object sender, EventArgs e)
        {
            string sql = "";
            MySqlDataReader reader = null;

            try
            {  
                    conexao.Open();
                    conta.IdCliente = Convert.ToInt32(NUMBOX_ExcluirCodCliente.Value);
                    sql = "SELECT * FROM clientes WHERE id_cliente = " + conta.IdCliente + ";";
                    MySqlCommand query = new MySqlCommand(sql, conexao);

                    reader = query.ExecuteReader();

                    if (reader.Read())
                    {
                        TXTBOX_excluirDisplay.Text = "Encontrado";
                    }
                    else
                    {
                        MessageBox.Show("Cliente não encontrado!!!");
                    }           

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

        private void BTN_ExcluirExcluir_Click(object sender, EventArgs e)
        {
            string sql = "";
            MySqlDataReader reader= null;

            try
            {
                //indiquei para o botão cancelar realizar sempre uma confirmação se realmente o usuário quer cancelar
                DialogResult opcao = MessageBox.Show("Deseja Realmente Excluir o Cadastro?", "Confirmação",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                //usei a condicional para verificar a resposta do usuário
                if (opcao == DialogResult.Yes)
                {
                    conexao.Open();
                    conta.IdCliente = Convert.ToInt32(NUMBOX_ExcluirCodCliente.Value);
                    sql = "DELETE  FROM clientes WHERE id_cliente = " + conta.IdCliente + ";";
                    MySqlCommand query = new MySqlCommand(sql, conexao);

                    reader = query.ExecuteReader();
                    if (reader.Read())
                    {
                        MessageBox.Show("ERRO! CLIENTE ENCONTRADO , MAS NÃO EXCLUÍDO");
                    }
                    else
                    {
                        MessageBox.Show("CLIENTE EXCLUÍDO COM SUCESSO!");
                    }
                }
                
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
