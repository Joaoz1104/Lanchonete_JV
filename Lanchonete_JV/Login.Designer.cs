
namespace Lanchonete_JV
{
    partial class formLogin
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
            this.labelIdFunc = new System.Windows.Forms.Label();
            this.labelNomeFunc = new System.Windows.Forms.Label();
            this.txtIdFunc = new System.Windows.Forms.TextBox();
            this.txtNomeFunc = new System.Windows.Forms.TextBox();
            this.labelEmailFunc = new System.Windows.Forms.Label();
            this.txtEmailFunc = new System.Windows.Forms.TextBox();
            this.labelSenha = new System.Windows.Forms.Label();
            this.mskdTxtSenhaFunc = new System.Windows.Forms.MaskedTextBox();
            this.btnLogar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelIdFunc
            // 
            this.labelIdFunc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelIdFunc.AutoSize = true;
            this.labelIdFunc.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelIdFunc.Location = new System.Drawing.Point(24, 42);
            this.labelIdFunc.Name = "labelIdFunc";
            this.labelIdFunc.Size = new System.Drawing.Size(161, 19);
            this.labelIdFunc.TabIndex = 0;
            this.labelIdFunc.Text = "Código Funcionário";
            // 
            // labelNomeFunc
            // 
            this.labelNomeFunc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelNomeFunc.AutoSize = true;
            this.labelNomeFunc.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelNomeFunc.Location = new System.Drawing.Point(24, 112);
            this.labelNomeFunc.Name = "labelNomeFunc";
            this.labelNomeFunc.Size = new System.Drawing.Size(150, 19);
            this.labelNomeFunc.TabIndex = 1;
            this.labelNomeFunc.Text = "Nome Funcionário";
            // 
            // txtIdFunc
            // 
            this.txtIdFunc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtIdFunc.Location = new System.Drawing.Point(216, 38);
            this.txtIdFunc.Name = "txtIdFunc";
            this.txtIdFunc.Size = new System.Drawing.Size(100, 23);
            this.txtIdFunc.TabIndex = 3;
            // 
            // txtNomeFunc
            // 
            this.txtNomeFunc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNomeFunc.Location = new System.Drawing.Point(216, 108);
            this.txtNomeFunc.Name = "txtNomeFunc";
            this.txtNomeFunc.Size = new System.Drawing.Size(307, 23);
            this.txtNomeFunc.TabIndex = 4;
            // 
            // labelEmailFunc
            // 
            this.labelEmailFunc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelEmailFunc.AutoSize = true;
            this.labelEmailFunc.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelEmailFunc.Location = new System.Drawing.Point(24, 203);
            this.labelEmailFunc.Name = "labelEmailFunc";
            this.labelEmailFunc.Size = new System.Drawing.Size(56, 19);
            this.labelEmailFunc.TabIndex = 5;
            this.labelEmailFunc.Text = "E-mail";
            // 
            // txtEmailFunc
            // 
            this.txtEmailFunc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEmailFunc.Location = new System.Drawing.Point(216, 199);
            this.txtEmailFunc.Name = "txtEmailFunc";
            this.txtEmailFunc.Size = new System.Drawing.Size(307, 23);
            this.txtEmailFunc.TabIndex = 6;
            // 
            // labelSenha
            // 
            this.labelSenha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelSenha.AutoSize = true;
            this.labelSenha.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelSenha.Location = new System.Drawing.Point(24, 291);
            this.labelSenha.Name = "labelSenha";
            this.labelSenha.Size = new System.Drawing.Size(58, 19);
            this.labelSenha.TabIndex = 7;
            this.labelSenha.Text = "Senha";
            // 
            // mskdTxtSenhaFunc
            // 
            this.mskdTxtSenhaFunc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mskdTxtSenhaFunc.Location = new System.Drawing.Point(216, 287);
            this.mskdTxtSenhaFunc.Name = "mskdTxtSenhaFunc";
            this.mskdTxtSenhaFunc.Size = new System.Drawing.Size(307, 23);
            this.mskdTxtSenhaFunc.TabIndex = 8;
            // 
            // btnLogar
            // 
            this.btnLogar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLogar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLogar.Location = new System.Drawing.Point(206, 364);
            this.btnLogar.Name = "btnLogar";
            this.btnLogar.Size = new System.Drawing.Size(129, 46);
            this.btnLogar.TabIndex = 9;
            this.btnLogar.Text = "Logar";
            this.btnLogar.UseVisualStyleBackColor = true;
            // 
            // formLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(584, 455);
            this.Controls.Add(this.btnLogar);
            this.Controls.Add(this.mskdTxtSenhaFunc);
            this.Controls.Add(this.labelSenha);
            this.Controls.Add(this.txtEmailFunc);
            this.Controls.Add(this.labelEmailFunc);
            this.Controls.Add(this.txtNomeFunc);
            this.Controls.Add(this.txtIdFunc);
            this.Controls.Add(this.labelNomeFunc);
            this.Controls.Add(this.labelIdFunc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "formLogin";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.formLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelIdFunc;
        private System.Windows.Forms.Label labelNomeFunc;
        private System.Windows.Forms.TextBox txtIdFunc;
        private System.Windows.Forms.TextBox txtNomeFunc;
        private System.Windows.Forms.Label labelEmailFunc;
        private System.Windows.Forms.TextBox txtEmailFunc;
        private System.Windows.Forms.Label labelSenha;
        private System.Windows.Forms.MaskedTextBox mskdTxtSenhaFunc;
        private System.Windows.Forms.Button btnLogar;
    }
}