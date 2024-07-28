namespace Sistema_de_Vendas.Forms.Vender
{
    partial class VenderForm
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
            txtClienteNome = new TextBox();
            lbl1 = new Label();
            btnAdicionarCampo = new Button();
            painelProdutos = new FlowLayoutPanel();
            finalizarCompra = new Button();
            SuspendLayout();
            // 
            // txtClienteNome
            // 
            txtClienteNome.BackColor = Color.WhiteSmoke;
            txtClienteNome.Location = new Point(119, 50);
            txtClienteNome.Name = "txtClienteNome";
            txtClienteNome.Size = new Size(408, 23);
            txtClienteNome.TabIndex = 0;
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Location = new Point(53, 53);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(44, 15);
            lbl1.TabIndex = 1;
            lbl1.Text = "Cliente";
            // 
            // btnAdicionarCampo
            // 
            btnAdicionarCampo.BackColor = Color.FromArgb(0, 0, 192);
            btnAdicionarCampo.ForeColor = SystemColors.ButtonHighlight;
            btnAdicionarCampo.Location = new Point(655, 127);
            btnAdicionarCampo.Name = "btnAdicionarCampo";
            btnAdicionarCampo.Size = new Size(107, 56);
            btnAdicionarCampo.TabIndex = 3;
            btnAdicionarCampo.Text = "Adicionar Produto";
            btnAdicionarCampo.UseVisualStyleBackColor = false;
            btnAdicionarCampo.Click += AdicionarCampo;
            // 
            // painelProdutos
            // 
            painelProdutos.Location = new Point(53, 115);
            painelProdutos.Name = "painelProdutos";
            painelProdutos.Size = new Size(574, 286);
            painelProdutos.TabIndex = 2;
            // 
            // finalizarCompra
            // 
            finalizarCompra.BackColor = Color.FromArgb(0, 192, 0);
            finalizarCompra.ForeColor = SystemColors.ButtonHighlight;
            finalizarCompra.Location = new Point(655, 345);
            finalizarCompra.Name = "finalizarCompra";
            finalizarCompra.Size = new Size(107, 56);
            finalizarCompra.TabIndex = 3;
            finalizarCompra.Text = "Finalizar Compra";
            finalizarCompra.UseVisualStyleBackColor = false;
            finalizarCompra.Click += SalvarVenda;
            // 
            // VenderForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(800, 450);
            Controls.Add(painelProdutos);
            Controls.Add(finalizarCompra);
            Controls.Add(btnAdicionarCampo);
            Controls.Add(lbl1);
            Controls.Add(txtClienteNome);
            Name = "VenderForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "VenderForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtClienteNome;
        private Label lbl1;
        private Button btnAdicionarCampo;
        private FlowLayoutPanel painelProdutos;
        private Button finalizarCompra;
    }
}