using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banco_Sul
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void SairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NovoClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NovoCliente janelaNovoCliente = new NovoCliente();
            janelaNovoCliente.MdiParent = this;
            janelaNovoCliente.Show();
            janelaNovoCliente.Location = new Point(250,0);

        }

        private void AtualizarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Atualizar janelaAtualizar = new Atualizar();
            janelaAtualizar.MdiParent = this;
            janelaAtualizar.Show();
            janelaAtualizar.Location = new Point(0,0);
        }

        private void ExcluirClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Excluir janelaExcluir = new Excluir();
            janelaExcluir.MdiParent = this;
            janelaExcluir.Show();
            janelaExcluir.Location = new Point(0,0);
        }
    }
}
