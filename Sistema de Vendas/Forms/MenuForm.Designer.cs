namespace Sistema_de_Vendas
{
    partial class MenuForm
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
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            btnCadastrarCliente = new Button();
            btnCadastrarProduto = new Button();
            btnVender = new Button();
            btnContas = new Button();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(label1, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(744, 35);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.Blue;
            label1.Font = new Font("Segoe UI", 15F);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(568, 0);
            label1.Name = "label1";
            label1.Size = new Size(173, 28);
            label1.TabIndex = 0;
            label1.Text = "Sistema de vendas";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(btnCadastrarCliente, 0, 0);
            tableLayoutPanel2.Controls.Add(btnCadastrarProduto, 1, 0);
            tableLayoutPanel2.Controls.Add(btnVender, 1, 1);
            tableLayoutPanel2.Controls.Add(btnContas, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 35);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(744, 405);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // btnCadastrarCliente
            // 
            btnCadastrarCliente.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCadastrarCliente.BackColor = Color.FromArgb(0, 0, 192);
            btnCadastrarCliente.ForeColor = SystemColors.ButtonHighlight;
            btnCadastrarCliente.Location = new Point(242, 138);
            btnCadastrarCliente.Margin = new Padding(3, 3, 25, 10);
            btnCadastrarCliente.Name = "btnCadastrarCliente";
            btnCadastrarCliente.Size = new Size(105, 54);
            btnCadastrarCliente.TabIndex = 0;
            btnCadastrarCliente.Text = "Cadastrar Clientes";
            btnCadastrarCliente.UseVisualStyleBackColor = false;
            btnCadastrarCliente.Click += btnCadastrarCliente_Click;
            // 
            // btnCadastrarProduto
            // 
            btnCadastrarProduto.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnCadastrarProduto.BackColor = Color.FromArgb(0, 0, 192);
            btnCadastrarProduto.ForeColor = SystemColors.ButtonHighlight;
            btnCadastrarProduto.Location = new Point(397, 138);
            btnCadastrarProduto.Margin = new Padding(25, 3, 3, 10);
            btnCadastrarProduto.Name = "btnCadastrarProduto";
            btnCadastrarProduto.Size = new Size(105, 54);
            btnCadastrarProduto.TabIndex = 1;
            btnCadastrarProduto.Text = "Cadastrar Produtos";
            btnCadastrarProduto.UseVisualStyleBackColor = false;
            btnCadastrarProduto.Click += btnCadastrarProduto_Click;
            // 
            // btnVender
            // 
            btnVender.BackColor = Color.FromArgb(0, 0, 192);
            btnVender.ForeColor = SystemColors.ButtonHighlight;
            btnVender.Location = new Point(397, 212);
            btnVender.Margin = new Padding(25, 10, 3, 3);
            btnVender.Name = "btnVender";
            btnVender.Size = new Size(105, 54);
            btnVender.TabIndex = 3;
            btnVender.Text = "Vender";
            btnVender.UseVisualStyleBackColor = false;
            // 
            // btnContas
            // 
            btnContas.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnContas.BackColor = Color.FromArgb(0, 0, 192);
            btnContas.ForeColor = SystemColors.ButtonHighlight;
            btnContas.Location = new Point(242, 212);
            btnContas.Margin = new Padding(3, 10, 25, 3);
            btnContas.Name = "btnContas";
            btnContas.Size = new Size(105, 54);
            btnContas.TabIndex = 2;
            btnContas.Text = "Contas";
            btnContas.UseVisualStyleBackColor = false;
            // 
            // MenuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(744, 440);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            Name = "MenuForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema de Vendas";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel2;
        private Button btnCadastrarCliente;
        private Button btnCadastrarProduto;
        private Button btnVender;
        private Button btnContas;
    }
}