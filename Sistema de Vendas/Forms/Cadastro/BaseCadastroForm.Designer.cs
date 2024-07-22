namespace Sistema_de_Vendas.Forms
{
    partial class BaseCadastroForm
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
            tblCadastroNav = new TableLayoutPanel();
            lblCadastroTitulo = new Label();
            dgvTabela = new DataGridView();
            btnEditar = new Button();
            btnApagar = new Button();
            label1 = new Label();
            lblDescricao = new Label();
            btnAdicionar = new Button();
            tblCadastroNav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTabela).BeginInit();
            SuspendLayout();
            // 
            // tblCadastroNav
            // 
            tblCadastroNav.ColumnCount = 1;
            tblCadastroNav.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblCadastroNav.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblCadastroNav.Controls.Add(lblCadastroTitulo, 0, 0);
            tblCadastroNav.Dock = DockStyle.Top;
            tblCadastroNav.Location = new Point(0, 0);
            tblCadastroNav.Name = "tblCadastroNav";
            tblCadastroNav.RowCount = 1;
            tblCadastroNav.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblCadastroNav.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblCadastroNav.Size = new Size(832, 77);
            tblCadastroNav.TabIndex = 0;
            tblCadastroNav.Paint += tableLayoutPanel1_Paint;
            // 
            // lblCadastroTitulo
            // 
            lblCadastroTitulo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblCadastroTitulo.AutoSize = true;
            lblCadastroTitulo.BackColor = Color.FromArgb(0, 0, 192);
            lblCadastroTitulo.Font = new Font("Segoe UI", 15F);
            lblCadastroTitulo.ForeColor = SystemColors.ButtonHighlight;
            lblCadastroTitulo.Location = new Point(829, 0);
            lblCadastroTitulo.Name = "lblCadastroTitulo";
            lblCadastroTitulo.Size = new Size(0, 28);
            lblCadastroTitulo.TabIndex = 0;
            // 
            // dgvTabela
            // 
            dgvTabela.AllowUserToAddRows = false;
            dgvTabela.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvTabela.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTabela.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTabela.Location = new Point(30, 130);
            dgvTabela.MultiSelect = false;
            dgvTabela.Name = "dgvTabela";
            dgvTabela.RowHeadersVisible = false;
            dgvTabela.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTabela.Size = new Size(471, 301);
            dgvTabela.TabIndex = 1;
            // 
            // btnEditar
            // 
            btnEditar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnEditar.BackColor = Color.FromArgb(0, 0, 192);
            btnEditar.ForeColor = SystemColors.ButtonHighlight;
            btnEditar.Location = new Point(626, 216);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(97, 58);
            btnEditar.TabIndex = 2;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += button1_Click;
            // 
            // btnApagar
            // 
            btnApagar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnApagar.BackColor = Color.Red;
            btnApagar.ForeColor = SystemColors.ButtonHighlight;
            btnApagar.Location = new Point(626, 300);
            btnApagar.Name = "btnApagar";
            btnApagar.Size = new Size(97, 58);
            btnApagar.TabIndex = 2;
            btnApagar.Text = "Apagar";
            btnApagar.UseVisualStyleBackColor = false;
            btnApagar.Click += button1_Click;
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(0, 0, 192);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(30, 93);
            label1.Name = "label1";
            label1.Size = new Size(125, 26);
            label1.TabIndex = 3;
            label1.Text = "ID";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // lblDescricao
            // 
            lblDescricao.BackColor = Color.FromArgb(0, 0, 192);
            lblDescricao.ForeColor = SystemColors.ButtonHighlight;
            lblDescricao.Location = new Point(161, 93);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(340, 26);
            lblDescricao.TabIndex = 3;
            lblDescricao.TextAlign = ContentAlignment.MiddleCenter;
            lblDescricao.Click += label1_Click;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnAdicionar.BackColor = Color.FromArgb(0, 0, 192);
            btnAdicionar.ForeColor = SystemColors.ButtonHighlight;
            btnAdicionar.Location = new Point(626, 130);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(97, 58);
            btnAdicionar.TabIndex = 2;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = false;
            btnAdicionar.Click += button1_Click;
            // 
            // BaseCadastroForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(832, 457);
            Controls.Add(lblDescricao);
            Controls.Add(label1);
            Controls.Add(btnApagar);
            Controls.Add(btnAdicionar);
            Controls.Add(btnEditar);
            Controls.Add(dgvTabela);
            Controls.Add(tblCadastroNav);
            Name = "BaseCadastroForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro";
            Load += BaseCadastroForm_Load;
            tblCadastroNav.ResumeLayout(false);
            tblCadastroNav.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTabela).EndInit();
            ResumeLayout(false);
        }

        #endregion

        protected TableLayoutPanel tblCadastroNav;
        protected Label lblCadastroTitulo;
        protected DataGridView dgvTabela;
        protected Button btnEditar;
        protected Button btnApagar;
        protected Label label1;
        protected Label lblDescricao;
        protected Button btnAdicionar;
    }
}