﻿
namespace Lanchonete_JV
{
    partial class formCliente
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnPedido = new System.Windows.Forms.Button();
            this.bntExcluir = new System.Windows.Forms.Button();
            this.bntEditar = new System.Windows.Forms.Button();
            this.bntCadastrar = new System.Windows.Forms.Button();
            this.labelTel = new System.Windows.Forms.Label();
            this.labelNome = new System.Windows.Forms.Label();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtIdCliente = new System.Windows.Forms.TextBox();
            this.labelIdCliente = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(14, 291);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(556, 150);
            this.dataGridView1.TabIndex = 21;
            // 
            // btnPedido
            // 
            this.btnPedido.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPedido.Location = new System.Drawing.Point(475, 238);
            this.btnPedido.Name = "btnPedido";
            this.btnPedido.Size = new System.Drawing.Size(95, 23);
            this.btnPedido.TabIndex = 20;
            this.btnPedido.Text = "Fazer Pedido";
            this.btnPedido.UseVisualStyleBackColor = true;
            // 
            // bntExcluir
            // 
            this.bntExcluir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bntExcluir.Location = new System.Drawing.Point(309, 238);
            this.bntExcluir.Name = "bntExcluir";
            this.bntExcluir.Size = new System.Drawing.Size(75, 23);
            this.bntExcluir.TabIndex = 19;
            this.bntExcluir.Text = "Excluir";
            this.bntExcluir.UseVisualStyleBackColor = true;
            // 
            // bntEditar
            // 
            this.bntEditar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bntEditar.Location = new System.Drawing.Point(165, 238);
            this.bntEditar.Name = "bntEditar";
            this.bntEditar.Size = new System.Drawing.Size(75, 23);
            this.bntEditar.TabIndex = 18;
            this.bntEditar.Text = "Editar";
            this.bntEditar.UseVisualStyleBackColor = true;
            // 
            // bntCadastrar
            // 
            this.bntCadastrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bntCadastrar.Location = new System.Drawing.Point(13, 238);
            this.bntCadastrar.Name = "bntCadastrar";
            this.bntCadastrar.Size = new System.Drawing.Size(75, 23);
            this.bntCadastrar.TabIndex = 17;
            this.bntCadastrar.Text = "Cadastrar";
            this.bntCadastrar.UseVisualStyleBackColor = true;
            // 
            // labelTel
            // 
            this.labelTel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTel.AutoSize = true;
            this.labelTel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTel.Location = new System.Drawing.Point(31, 176);
            this.labelTel.Name = "labelTel";
            this.labelTel.Size = new System.Drawing.Size(131, 19);
            this.labelTel.TabIndex = 16;
            this.labelTel.Text = "Telefone Cliente";
            // 
            // labelNome
            // 
            this.labelNome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelNome.AutoSize = true;
            this.labelNome.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelNome.Location = new System.Drawing.Point(51, 121);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(111, 19);
            this.labelNome.TabIndex = 15;
            this.labelNome.Text = "Nome Cliente";
            // 
            // txtTel
            // 
            this.txtTel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTel.Location = new System.Drawing.Point(189, 172);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(369, 23);
            this.txtTel.TabIndex = 14;
            // 
            // txtNome
            // 
            this.txtNome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNome.Location = new System.Drawing.Point(189, 117);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(369, 23);
            this.txtNome.TabIndex = 13;
            // 
            // txtIdCliente
            // 
            this.txtIdCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtIdCliente.Location = new System.Drawing.Point(189, 71);
            this.txtIdCliente.Name = "txtIdCliente";
            this.txtIdCliente.Size = new System.Drawing.Size(100, 23);
            this.txtIdCliente.TabIndex = 12;
            // 
            // labelIdCliente
            // 
            this.labelIdCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelIdCliente.AutoSize = true;
            this.labelIdCliente.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelIdCliente.Location = new System.Drawing.Point(40, 71);
            this.labelIdCliente.Name = "labelIdCliente";
            this.labelIdCliente.Size = new System.Drawing.Size(122, 19);
            this.labelIdCliente.TabIndex = 11;
            this.labelIdCliente.Text = "Código Cliente";
            // 
            // formCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(583, 458);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnPedido);
            this.Controls.Add(this.bntExcluir);
            this.Controls.Add(this.bntEditar);
            this.Controls.Add(this.bntCadastrar);
            this.Controls.Add(this.labelTel);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtIdCliente);
            this.Controls.Add(this.labelIdCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "formCliente";
            this.Text = "Cliente";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnPedido;
        private System.Windows.Forms.Button bntExcluir;
        private System.Windows.Forms.Button bntEditar;
        private System.Windows.Forms.Button bntCadastrar;
        private System.Windows.Forms.Label labelTel;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtIdCliente;
        private System.Windows.Forms.Label labelIdCliente;
    }
}