namespace Banco_Sul
{
    partial class Excluir
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LBL_excluirCodCliente = new System.Windows.Forms.Label();
            this.NUMBOX_ExcluirCodCliente = new System.Windows.Forms.NumericUpDown();
            this.LBL_ExcluirBuscar = new System.Windows.Forms.Label();
            this.TXTBOX_excluirDisplay = new System.Windows.Forms.TextBox();
            this.BTN_ExcluirExcluir = new System.Windows.Forms.Button();
            this.BTN_ExcluirBuscar = new System.Windows.Forms.Button();
            this.LBL_ExcluirExcluir = new System.Windows.Forms.Label();
            this.BTN_ExcluirCancelar = new System.Windows.Forms.Button();
            this.LBL_ExcluirCancelar = new System.Windows.Forms.Label();
            this.BTN_ExcluirLimpar = new System.Windows.Forms.Button();
            this.LBL_ExcluirLimpar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NUMBOX_ExcluirCodCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // LBL_excluirCodCliente
            // 
            this.LBL_excluirCodCliente.AutoSize = true;
            this.LBL_excluirCodCliente.Location = new System.Drawing.Point(32, 38);
            this.LBL_excluirCodCliente.Name = "LBL_excluirCodCliente";
            this.LBL_excluirCodCliente.Size = new System.Drawing.Size(90, 13);
            this.LBL_excluirCodCliente.TabIndex = 0;
            this.LBL_excluirCodCliente.Text = "Código do Cliente";
            // 
            // NUMBOX_ExcluirCodCliente
            // 
            this.NUMBOX_ExcluirCodCliente.Location = new System.Drawing.Point(122, 36);
            this.NUMBOX_ExcluirCodCliente.Name = "NUMBOX_ExcluirCodCliente";
            this.NUMBOX_ExcluirCodCliente.Size = new System.Drawing.Size(120, 20);
            this.NUMBOX_ExcluirCodCliente.TabIndex = 1;
            // 
            // LBL_ExcluirBuscar
            // 
            this.LBL_ExcluirBuscar.AutoSize = true;
            this.LBL_ExcluirBuscar.Location = new System.Drawing.Point(258, 59);
            this.LBL_ExcluirBuscar.Name = "LBL_ExcluirBuscar";
            this.LBL_ExcluirBuscar.Size = new System.Drawing.Size(40, 13);
            this.LBL_ExcluirBuscar.TabIndex = 3;
            this.LBL_ExcluirBuscar.Text = "Buscar";
            // 
            // TXTBOX_excluirDisplay
            // 
            this.TXTBOX_excluirDisplay.Location = new System.Drawing.Point(35, 84);
            this.TXTBOX_excluirDisplay.Name = "TXTBOX_excluirDisplay";
            this.TXTBOX_excluirDisplay.ReadOnly = true;
            this.TXTBOX_excluirDisplay.Size = new System.Drawing.Size(257, 20);
            this.TXTBOX_excluirDisplay.TabIndex = 4;
            // 
            // BTN_ExcluirExcluir
            // 
            this.BTN_ExcluirExcluir.Image = global::Banco_Sul.Properties.Resources.excluir__1_;
            this.BTN_ExcluirExcluir.Location = new System.Drawing.Point(58, 135);
            this.BTN_ExcluirExcluir.Name = "BTN_ExcluirExcluir";
            this.BTN_ExcluirExcluir.Size = new System.Drawing.Size(44, 34);
            this.BTN_ExcluirExcluir.TabIndex = 5;
            this.BTN_ExcluirExcluir.UseVisualStyleBackColor = true;
            this.BTN_ExcluirExcluir.Click += new System.EventHandler(this.BTN_ExcluirExcluir_Click);
            // 
            // BTN_ExcluirBuscar
            // 
            this.BTN_ExcluirBuscar.Image = global::Banco_Sul.Properties.Resources.buscar__1_;
            this.BTN_ExcluirBuscar.Location = new System.Drawing.Point(256, 27);
            this.BTN_ExcluirBuscar.Name = "BTN_ExcluirBuscar";
            this.BTN_ExcluirBuscar.Size = new System.Drawing.Size(40, 32);
            this.BTN_ExcluirBuscar.TabIndex = 2;
            this.BTN_ExcluirBuscar.UseVisualStyleBackColor = true;
            this.BTN_ExcluirBuscar.Click += new System.EventHandler(this.BTN_ExcluirBuscar_Click);
            // 
            // LBL_ExcluirExcluir
            // 
            this.LBL_ExcluirExcluir.AutoSize = true;
            this.LBL_ExcluirExcluir.Location = new System.Drawing.Point(39, 170);
            this.LBL_ExcluirExcluir.Name = "LBL_ExcluirExcluir";
            this.LBL_ExcluirExcluir.Size = new System.Drawing.Size(83, 13);
            this.LBL_ExcluirExcluir.TabIndex = 6;
            this.LBL_ExcluirExcluir.Text = "Excluir Cadastro";
            // 
            // BTN_ExcluirCancelar
            // 
            this.BTN_ExcluirCancelar.Image = global::Banco_Sul.Properties.Resources.cancelar__2_;
            this.BTN_ExcluirCancelar.Location = new System.Drawing.Point(157, 135);
            this.BTN_ExcluirCancelar.Name = "BTN_ExcluirCancelar";
            this.BTN_ExcluirCancelar.Size = new System.Drawing.Size(42, 34);
            this.BTN_ExcluirCancelar.TabIndex = 7;
            this.BTN_ExcluirCancelar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BTN_ExcluirCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BTN_ExcluirCancelar.UseVisualStyleBackColor = true;
            this.BTN_ExcluirCancelar.Click += new System.EventHandler(this.BTN_ExcluirCancelar_Click);
            // 
            // LBL_ExcluirCancelar
            // 
            this.LBL_ExcluirCancelar.AutoSize = true;
            this.LBL_ExcluirCancelar.Location = new System.Drawing.Point(154, 170);
            this.LBL_ExcluirCancelar.Name = "LBL_ExcluirCancelar";
            this.LBL_ExcluirCancelar.Size = new System.Drawing.Size(49, 13);
            this.LBL_ExcluirCancelar.TabIndex = 8;
            this.LBL_ExcluirCancelar.Text = "Cancelar";
            // 
            // BTN_ExcluirLimpar
            // 
            this.BTN_ExcluirLimpar.Image = global::Banco_Sul.Properties.Resources.borracha__1_;
            this.BTN_ExcluirLimpar.Location = new System.Drawing.Point(251, 135);
            this.BTN_ExcluirLimpar.Name = "BTN_ExcluirLimpar";
            this.BTN_ExcluirLimpar.Size = new System.Drawing.Size(41, 34);
            this.BTN_ExcluirLimpar.TabIndex = 9;
            this.BTN_ExcluirLimpar.UseVisualStyleBackColor = true;
            this.BTN_ExcluirLimpar.Click += new System.EventHandler(this.BTN_ExcluirLimpar_Click);
            // 
            // LBL_ExcluirLimpar
            // 
            this.LBL_ExcluirLimpar.AutoSize = true;
            this.LBL_ExcluirLimpar.Location = new System.Drawing.Point(253, 170);
            this.LBL_ExcluirLimpar.Name = "LBL_ExcluirLimpar";
            this.LBL_ExcluirLimpar.Size = new System.Drawing.Size(38, 13);
            this.LBL_ExcluirLimpar.TabIndex = 10;
            this.LBL_ExcluirLimpar.Text = "Limpar";
            // 
            // Excluir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 251);
            this.Controls.Add(this.LBL_ExcluirLimpar);
            this.Controls.Add(this.BTN_ExcluirLimpar);
            this.Controls.Add(this.LBL_ExcluirCancelar);
            this.Controls.Add(this.BTN_ExcluirCancelar);
            this.Controls.Add(this.LBL_ExcluirExcluir);
            this.Controls.Add(this.BTN_ExcluirExcluir);
            this.Controls.Add(this.TXTBOX_excluirDisplay);
            this.Controls.Add(this.LBL_ExcluirBuscar);
            this.Controls.Add(this.BTN_ExcluirBuscar);
            this.Controls.Add(this.NUMBOX_ExcluirCodCliente);
            this.Controls.Add(this.LBL_excluirCodCliente);
            this.Name = "Excluir";
            this.Text = "Excluir";
            ((System.ComponentModel.ISupportInitialize)(this.NUMBOX_ExcluirCodCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBL_excluirCodCliente;
        private System.Windows.Forms.NumericUpDown NUMBOX_ExcluirCodCliente;
        private System.Windows.Forms.Button BTN_ExcluirBuscar;
        private System.Windows.Forms.Label LBL_ExcluirBuscar;
        private System.Windows.Forms.TextBox TXTBOX_excluirDisplay;
        private System.Windows.Forms.Button BTN_ExcluirExcluir;
        private System.Windows.Forms.Label LBL_ExcluirExcluir;
        private System.Windows.Forms.Button BTN_ExcluirCancelar;
        private System.Windows.Forms.Label LBL_ExcluirCancelar;
        private System.Windows.Forms.Button BTN_ExcluirLimpar;
        private System.Windows.Forms.Label LBL_ExcluirLimpar;
    }
}