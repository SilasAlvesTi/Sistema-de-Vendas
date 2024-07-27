namespace Sistema_de_Vendas.Forms.Cadastro
{
    partial class BaseCriarEditarForm
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
            Label lvlIdTexto;
            txtTitulo = new Label();
            lblNome = new Label();
            txtNome = new TextBox();
            btnAdicionar = new Button();
            btnCancelar = new Button();
            lblId = new Label();
            lvlIdTexto = new Label();
            SuspendLayout();
            // 
            // txtTitulo
            // 
            txtTitulo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtTitulo.Font = new Font("Segoe UI", 20F);
            txtTitulo.Location = new Point(12, 9);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(472, 61);
            txtTitulo.TabIndex = 0;
            txtTitulo.Text = "Adicionar Cliente";
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
            txtNome.TabIndex = 2;
            // 
            // btnAdicionar
            // 
            btnAdicionar.BackColor = Color.FromArgb(0, 0, 192);
            btnAdicionar.ForeColor = SystemColors.ButtonHighlight;
            btnAdicionar.Location = new Point(177, 273);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(75, 23);
            btnAdicionar.TabIndex = 3;
            btnAdicionar.Text = "Adicionar";
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
            btnCancelar.TabIndex = 3;
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
            // lvlIdTexto
            // 
            lvlIdTexto.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lvlIdTexto.AutoSize = true;
            lvlIdTexto.Font = new Font("Segoe UI", 11F);
            lvlIdTexto.Location = new Point(43, 107);
            lvlIdTexto.Name = "lvlIdTexto";
            lvlIdTexto.Size = new Size(97, 20);
            lvlIdTexto.TabIndex = 1;
            lvlIdTexto.Text = "Id do CLiente";
            // 
            // BaseCriarEditarForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(496, 335);
            Controls.Add(btnCancelar);
            Controls.Add(btnAdicionar);
            Controls.Add(txtNome);
            Controls.Add(lvlIdTexto);
            Controls.Add(lblId);
            Controls.Add(lblNome);
            Controls.Add(txtTitulo);
            Name = "BaseCriarEditarForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Clientes";
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
    }
}