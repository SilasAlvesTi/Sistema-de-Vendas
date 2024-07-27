namespace Sistema_de_Vendas.Forms.Cadastro.ProdutosForms
{
    partial class CriarEditarProdutoForm
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
            lvlIdTexto = new Label();
            txtTitulo = new Label();
            lblNome = new Label();
            txtNome = new TextBox();
            btnAdicionar = new Button();
            btnCancelar = new Button();
            lblId = new Label();
            lblPreco = new Label();
            txtPreco = new TextBox();
            lvlEstoque = new Label();
            txtEstoque = new TextBox();
            SuspendLayout();
            // 
            // lvlIdTexto
            // 
            lvlIdTexto.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lvlIdTexto.AutoSize = true;
            lvlIdTexto.Font = new Font("Segoe UI", 11F);
            lvlIdTexto.Location = new Point(43, 107);
            lvlIdTexto.Name = "lvlIdTexto";
            lvlIdTexto.Size = new Size(101, 20);
            lvlIdTexto.TabIndex = 1;
            lvlIdTexto.Text = "Id do Produto";
            // 
            // txtTitulo
            // 
            txtTitulo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtTitulo.Font = new Font("Segoe UI", 20F);
            txtTitulo.Location = new Point(12, 9);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(472, 61);
            txtTitulo.TabIndex = 0;
            txtTitulo.Text = "Adicionar Produto";
            txtTitulo.TextAlign = ContentAlignment.TopRight;
            // 
            // lblNome
            // 
            lblNome.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI", 11F);
            lblNome.Location = new Point(43, 155);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(50, 20);
            lblNome.TabIndex = 1;
            lblNome.Text = "Nome";
            // 
            // txtNome
            // 
            txtNome.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtNome.Location = new Point(133, 156);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(334, 23);
            txtNome.TabIndex = 0;
            // 
            // btnAdicionar
            // 
            btnAdicionar.BackColor = Color.FromArgb(0, 0, 192);
            btnAdicionar.ForeColor = SystemColors.ButtonHighlight;
            btnAdicionar.Location = new Point(177, 273);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(75, 23);
            btnAdicionar.TabIndex = 3;
            btnAdicionar.Text = "Atualizar";
            btnAdicionar.UseVisualStyleBackColor = false;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Red;
            btnCancelar.ForeColor = SystemColors.ButtonHighlight;
            btnCancelar.Location = new Point(258, 273);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 4;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // lblId
            // 
            lblId.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblId.AutoSize = true;
            lblId.Font = new Font("Segoe UI", 11F);
            lblId.Location = new Point(177, 107);
            lblId.Name = "lblId";
            lblId.Size = new Size(24, 20);
            lblId.TabIndex = 1;
            lblId.Text = "ID";
            // 
            // lblPreco
            // 
            lblPreco.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblPreco.AutoSize = true;
            lblPreco.Font = new Font("Segoe UI", 11F);
            lblPreco.Location = new Point(43, 184);
            lblPreco.Name = "lblPreco";
            lblPreco.Size = new Size(46, 20);
            lblPreco.TabIndex = 1;
            lblPreco.Text = "Preço";
            // 
            // txtPreco
            // 
            txtPreco.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtPreco.Location = new Point(133, 185);
            txtPreco.Name = "txtPreco";
            txtPreco.Size = new Size(334, 23);
            txtPreco.TabIndex = 1;
            // 
            // lvlEstoque
            // 
            lvlEstoque.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lvlEstoque.AutoSize = true;
            lvlEstoque.Font = new Font("Segoe UI", 11F);
            lvlEstoque.Location = new Point(43, 213);
            lvlEstoque.Name = "lvlEstoque";
            lvlEstoque.Size = new Size(62, 20);
            lvlEstoque.TabIndex = 1;
            lvlEstoque.Text = "Estoque";
            // 
            // txtEstoque
            // 
            txtEstoque.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtEstoque.Location = new Point(133, 214);
            txtEstoque.Name = "txtEstoque";
            txtEstoque.Size = new Size(334, 23);
            txtEstoque.TabIndex = 2;
            // 
            // CriarEditarProdutoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(496, 335);
            Controls.Add(btnCancelar);
            Controls.Add(btnAdicionar);
            Controls.Add(txtEstoque);
            Controls.Add(txtPreco);
            Controls.Add(txtNome);
            Controls.Add(lvlEstoque);
            Controls.Add(lvlIdTexto);
            Controls.Add(lblPreco);
            Controls.Add(lblId);
            Controls.Add(lblNome);
            Controls.Add(txtTitulo);
            Name = "CriarEditarProdutoForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Produtos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txtTitulo;
        private Label lblNome;
        private TextBox txtNome;
        private Button btnAdicionar;
        private Button btnCancelar;
        private Label lblId;
        private Label lvlIdTexto;
        private Label lblPreco;
        private TextBox txtPreco;
        private Label lvlEstoque;
        private TextBox txtEstoque;
    }
}