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
            dataGridView1 = new DataGridView();
            btnAdicionar = new Button();
            button1 = new Button();
            btnEditar = new Button();
            btnApagar = new Button();
            label1 = new Label();
            label2 = new Label();
            tblCadastroNav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(30, 130);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(471, 301);
            dataGridView1.TabIndex = 1;
            // 
            // btnAdicionar
            // 
            btnAdicionar.BackColor = Color.FromArgb(0, 0, 192);
            btnAdicionar.ForeColor = SystemColors.ButtonHighlight;
            btnAdicionar.Location = new Point(626, 140);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(97, 58);
            btnAdicionar.TabIndex = 2;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = false;
            btnAdicionar.Click += button1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(626, 216);
            button1.Name = "button1";
            button1.Size = new Size(97, 58);
            button1.TabIndex = 2;
            button1.Text = "Adicionar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnEditar
            // 
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
            btnApagar.BackColor = Color.Red;
            btnApagar.ForeColor = SystemColors.ButtonHighlight;
            btnApagar.Location = new Point(626, 291);
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
            // label2
            // 
            label2.BackColor = Color.FromArgb(0, 0, 192);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(161, 93);
            label2.Name = "label2";
            label2.Size = new Size(340, 26);
            label2.TabIndex = 3;
            label2.Text = "Descrição";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.Click += label1_Click;
            // 
            // BaseCadastroForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(832, 457);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnApagar);
            Controls.Add(btnEditar);
            Controls.Add(button1);
            Controls.Add(btnAdicionar);
            Controls.Add(dataGridView1);
            Controls.Add(tblCadastroNav);
            Name = "BaseCadastroForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro";
            Load += BaseCadastroForm_Load;
            tblCadastroNav.ResumeLayout(false);
            tblCadastroNav.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblCadastroNav;
        protected Label lblCadastroTitulo;
        private DataGridView dataGridView1;
        private Button btnAdicionar;
        private Button button1;
        private Button btnEditar;
        private Button btnApagar;
        private Label label1;
        private Label label2;
    }
}