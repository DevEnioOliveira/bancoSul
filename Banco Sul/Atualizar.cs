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
    public partial class Atualizar : Form
    {

        MySqlConnection conexao;
        Cliente cliente;
        Conta conta;
        
        public Atualizar()
        {
            InitializeComponent();
            conta = new Conta();
            conexao = new MySqlConnection("Server = localhost; port = 3306; database = dbabank; user = root; password = ''");
            cliente = new Cliente();
            TXTBOX_AtualizarNome.Enabled = false;
            TXTBOX_AtualizaDataNasc.Enabled = false;
            TXTBOX_AtualizarCpf.Enabled = false;
            TXTBOX_AtualizarEndereco.Enabled = false;
            NUMBOX_AtualizarSaldo.Enabled = false;
        }

        private void BTN_AtualizarBuscar_Click(object sender, EventArgs e)
        {
            string sql = "";
            MySqlDataReader reader = null;

            try
            {
                conexao.Open();
                conta.IdCliente = Convert.ToInt32(NUMBOX_AtualizarCodCliente.Value);
                sql = "SELECT * FROM clientes WHERE id_cliente = " + conta.IdCliente + ";";
                MySqlCommand query = new MySqlCommand(sql,conexao);

                reader = query.ExecuteReader();

                if (reader.Read())
                {
                    TXTBOX_AtualizarNome.Enabled = true;
                    TXTBOX_AtualizaDataNasc.Enabled = true;
                    TXTBOX_AtualizarCpf.Enabled = true;
                    TXTBOX_AtualizarEndereco.Enabled = true;
                    NUMBOX_AtualizarSaldo.Enabled = true;

                }
                else
                {
                    MessageBox.Show("Cliente não encontrado!!!");
                }

                conexao.Close();

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("ERRO!(" + ex.Number + "): " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO!" + ex.Message);
            }
            
        }

        private void BTN_AtualizarCancelar_Click(object sender, EventArgs e)
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

        private void BTN_AtualizarLimpar_Click(object sender, EventArgs e)
        {
            //indiquei para o botão cancelar realizar sempre uma confirmação se realmente o usuário quer cancelar
            DialogResult opcao = MessageBox.Show("Deseja Realmente Limpar os Campos?", "Confirmação",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (opcao == DialogResult.Yes)
            {
                NUMBOX_AtualizarCodCliente.Value = 0;
                TXTBOX_AtualizarNome.Text = "";
                TXTBOX_AtualizaDataNasc.Text = "";
                TXTBOX_AtualizarCpf.Text = "";
                TXTBOX_AtualizarEndereco.Text = "";
                TXTBOX_AtualizarDisplay.Text = "";
                NUMBOX_AtualizarSaldo.Value = 0;

                TXTBOX_AtualizarNome.Enabled = false;
                TXTBOX_AtualizaDataNasc.Enabled = false;
                TXTBOX_AtualizarCpf.Enabled = false;
                TXTBOX_AtualizarEndereco.Enabled = false;
                NUMBOX_AtualizarSaldo.Enabled = false;

            }
        }

        private void BTN_AtualizarAtualizar_Click(object sender, EventArgs e)
        {
            string sql = "";
            MySqlDataReader reader = null;

            try
            {
                //indiquei para o botão cancelar realizar sempre uma confirmação se realmente o usuário quer cancelar
                DialogResult opcao = MessageBox.Show("Deseja Realmente Atualizar o Cadastro?", "Confirmação",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                //usei a condicional para verificar a resposta do usuário
                if (opcao == DialogResult.Yes)
                {
                    conexao.Open();

                    cliente.Nome = TXTBOX_AtualizarNome.Text;
                    cliente.DataNasc = TXTBOX_AtualizaDataNasc.Text;
                    cliente.Cpf = TXTBOX_AtualizarCpf.Text;
                    cliente.Endereco = TXTBOX_AtualizarEndereco.Text;
                    cliente.Saldo = Convert.ToDouble(NUMBOX_AtualizarSaldo.Value);
                    
                    conta.IdCliente = Convert.ToInt32(NUMBOX_AtualizarCodCliente.Value);
                    sql = "UPDATE clientes SET nm_cliente = '" + cliente.Nome + "',dt_nascimento='" + cliente.DataNasc + "'," +
                        "saldo_cliente='" + cliente.Saldo +"',endereco_cliente='"+cliente.Endereco+"',cpf_cliente='"+ cliente.Cpf +"' " +
                        "WHERE id_cliente ='"+conta.IdCliente+"'";

                    MySqlCommand query = new MySqlCommand(sql, conexao);

                    reader = query.ExecuteReader();
                    if (reader.Read())
                    {
                        MessageBox.Show("ERRO! CLIENTE ENCONTRADO , MAS NÃO ATUALIZADO");
                    }
                    else
                    {
                        MessageBox.Show("CLIENTE ATUALIZADO COM SUCESSO");
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
