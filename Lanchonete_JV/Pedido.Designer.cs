
namespace Lanchonete_JV
{
    partial class formPedido
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
            this.lblPNome = new System.Windows.Forms.Label();
            this.txtPdoNome = new System.Windows.Forms.TextBox();
            this.txtPIdCliente = new System.Windows.Forms.TextBox();
            this.lblPId = new System.Windows.Forms.Label();
            this.dataGridPedido = new System.Windows.Forms.DataGridView();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnInserir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPedido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPNome
            // 
            this.lblPNome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPNome.AutoSize = true;
            this.lblPNome.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPNome.Location = new System.Drawing.Point(34, 36);
            this.lblPNome.Name = "lblPNome";
            this.lblPNome.Size = new System.Drawing.Size(111, 19);
            this.lblPNome.TabIndex = 2;
            this.lblPNome.Text = "Nome Cliente";
            // 
            // txtPdoNome
            // 
            this.txtPdoNome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPdoNome.BackColor = System.Drawing.Color.Gold;
            this.txtPdoNome.Location = new System.Drawing.Point(176, 32);
            this.txtPdoNome.Name = "txtPdoNome";
            this.txtPdoNome.Size = new System.Drawing.Size(277, 23);
            this.txtPdoNome.TabIndex = 3;
            // 
            // txtPIdCliente
            // 
            this.txtPIdCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPIdCliente.BackColor = System.Drawing.Color.Gold;
            this.txtPIdCliente.Location = new System.Drawing.Point(176, 82);
            this.txtPIdCliente.Name = "txtPIdCliente";
            this.txtPIdCliente.Size = new System.Drawing.Size(100, 23);
            this.txtPIdCliente.TabIndex = 4;
            // 
            // lblPId
            // 
            this.lblPId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPId.AutoSize = true;
            this.lblPId.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPId.Location = new System.Drawing.Point(23, 86);
            this.lblPId.Name = "lblPId";
            this.lblPId.Size = new System.Drawing.Size(122, 19);
            this.lblPId.TabIndex = 5;
            this.lblPId.Text = "Código Cliente";
            // 
            // dataGridPedido
            // 
            this.dataGridPedido.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPedido.Location = new System.Drawing.Point(12, 130);
            this.dataGridPedido.Name = "dataGridPedido";
            this.dataGridPedido.RowTemplate.Height = 25;
            this.dataGridPedido.Size = new System.Drawing.Size(541, 210);
            this.dataGridPedido.TabIndex = 6;
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnFechar.Location = new System.Drawing.Point(51, 414);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(127, 34);
            this.btnFechar.TabIndex = 7;
            this.btnFechar.Text = "Fechar Produto";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnInserir
            // 
            this.btnInserir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnInserir.Location = new System.Drawing.Point(291, 414);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(127, 34);
            this.btnInserir.TabIndex = 8;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(23, 350);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 19);
            this.label1.TabIndex = 9;
            this.label1.Text = "Total a Pagar : ";
            // 
            // txtTotal
            // 
            this.txtTotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTotal.BackColor = System.Drawing.Color.Gold;
            this.txtTotal.Location = new System.Drawing.Point(176, 346);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(357, 23);
            this.txtTotal.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::Lanchonete_JV.Properties.Resources.unnamed;
            this.pictureBox1.Location = new System.Drawing.Point(559, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(490, 477);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Image = global::Lanchonete_JV.Properties.Resources.pizzeria_restaurant_logo_design_template_220e91d20f43c0d3cec8f3732b11c0ad_screen;
            this.pictureBox2.Location = new System.Drawing.Point(940, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 77);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // Pedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(1052, 479);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.dataGridPedido);
            this.Controls.Add(this.lblPId);
            this.Controls.Add(this.txtPIdCliente);
            this.Controls.Add(this.txtPdoNome);
            this.Controls.Add(this.lblPNome);
            this.Name = "Pedido";
            this.Text = "Pedido";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPedido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblPNome;
        private System.Windows.Forms.TextBox txtPdoNome;
        private System.Windows.Forms.TextBox txtPIdCliente;
        private System.Windows.Forms.Label lblPId;
        private System.Windows.Forms.DataGridView dataGridPedido;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}