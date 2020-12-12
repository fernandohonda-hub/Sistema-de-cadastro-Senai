namespace CadastrosBeta
{
    partial class FrmPrincipal
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
            this.button1 = new System.Windows.Forms.Button();
            this.LblClientes = new System.Windows.Forms.Label();
            this.LblProdutos = new System.Windows.Forms.Label();
            this.BtnProdutos = new System.Windows.Forms.PictureBox();
            this.BtnClientes = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.BtnProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(363, 273);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 41);
            this.button1.TabIndex = 0;
            this.button1.Text = "Sair";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LblClientes
            // 
            this.LblClientes.AutoSize = true;
            this.LblClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblClientes.Location = new System.Drawing.Point(35, 147);
            this.LblClientes.Name = "LblClientes";
            this.LblClientes.Size = new System.Drawing.Size(153, 16);
            this.LblClientes.TabIndex = 2;
            this.LblClientes.Text = "Cadastro de Clientes";
            // 
            // LblProdutos
            // 
            this.LblProdutos.AutoSize = true;
            this.LblProdutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblProdutos.Location = new System.Drawing.Point(206, 147);
            this.LblProdutos.Name = "LblProdutos";
            this.LblProdutos.Size = new System.Drawing.Size(159, 16);
            this.LblProdutos.TabIndex = 4;
            this.LblProdutos.Text = "Cadastro de Produtos";
            this.LblProdutos.Click += new System.EventHandler(this.LblProdutos_Click);
            // 
            // BtnProdutos
            // 
            this.BtnProdutos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnProdutos.Image = global::CadastrosBeta.Properties.Resources.produtos;
            this.BtnProdutos.Location = new System.Drawing.Point(209, 12);
            this.BtnProdutos.Name = "BtnProdutos";
            this.BtnProdutos.Size = new System.Drawing.Size(156, 132);
            this.BtnProdutos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BtnProdutos.TabIndex = 3;
            this.BtnProdutos.TabStop = false;
            this.BtnProdutos.Click += new System.EventHandler(this.BtnProdutos_Click);
            // 
            // BtnClientes
            // 
            this.BtnClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnClientes.Image = global::CadastrosBeta.Properties.Resources.cadastro_clientes;
            this.BtnClientes.Location = new System.Drawing.Point(26, 12);
            this.BtnClientes.Name = "BtnClientes";
            this.BtnClientes.Size = new System.Drawing.Size(162, 132);
            this.BtnClientes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BtnClientes.TabIndex = 1;
            this.BtnClientes.TabStop = false;
            this.BtnClientes.Click += new System.EventHandler(this.BtnClientes_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 326);
            this.Controls.Add(this.LblProdutos);
            this.Controls.Add(this.BtnProdutos);
            this.Controls.Add(this.LblClientes);
            this.Controls.Add(this.BtnClientes);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aplicativo de Cadastro";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmPrincipal_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.BtnProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox BtnClientes;
        private System.Windows.Forms.Label LblClientes;
        private System.Windows.Forms.PictureBox BtnProdutos;
        private System.Windows.Forms.Label LblProdutos;
    }
}