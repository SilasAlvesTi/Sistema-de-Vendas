namespace Sistema_de_Vendas.Forms.Contas
{
    partial class ContasForm
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
            lblTitulo = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            dataGridView1 = new DataGridView();
            btnAdicionar = new Button();
            btnEditar = new Button();
            btnCancelarConta = new Button();
            btnApagar = new Button();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(lblTitulo, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(747, 38);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.FromArgb(0, 0, 192);
            lblTitulo.Font = new Font("Segoe UI", 15F);
            lblTitulo.ForeColor = SystemColors.ButtonHighlight;
            lblTitulo.Location = new Point(672, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(72, 28);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Contas";
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(0, 0, 192);
            label1.Font = new Font("Segoe UI", 11F);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(24, 74);
            label1.Name = "label1";
            label1.Size = new Size(113, 36);
            label1.TabIndex = 1;
            label1.Text = "ID";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.BackColor = Color.FromArgb(0, 0, 192);
            label2.Font = new Font("Segoe UI", 11F);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(167, 74);
            label2.Name = "label2";
            label2.Size = new Size(174, 36);
            label2.TabIndex = 1;
            label2.Text = "Descrição";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.BackColor = Color.FromArgb(0, 0, 192);
            label3.Font = new Font("Segoe UI", 11F);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(388, 74);
            label3.Name = "label3";
            label3.Size = new Size(336, 36);
            label3.TabIndex = 1;
            label3.Text = "Status venda";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 128);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(726, 249);
            dataGridView1.TabIndex = 2;
            // 
            // btnAdicionar
            // 
            btnAdicionar.BackColor = Color.FromArgb(0, 0, 192);
            btnAdicionar.ForeColor = SystemColors.ButtonHighlight;
            btnAdicionar.Location = new Point(12, 392);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(125, 35);
            btnAdicionar.TabIndex = 3;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = false;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.FromArgb(0, 0, 192);
            btnEditar.ForeColor = SystemColors.ButtonHighlight;
            btnEditar.Location = new Point(167, 392);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(125, 35);
            btnEditar.TabIndex = 3;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            // 
            // btnCancelarConta
            // 
            btnCancelarConta.BackColor = Color.Red;
            btnCancelarConta.ForeColor = SystemColors.ButtonHighlight;
            btnCancelarConta.Location = new Point(325, 392);
            btnCancelarConta.Name = "btnCancelarConta";
            btnCancelarConta.Size = new Size(221, 35);
            btnCancelarConta.TabIndex = 3;
            btnCancelarConta.Text = "Cancelar Conta";
            btnCancelarConta.UseVisualStyleBackColor = false;
            // 
            // btnApagar
            // 
            btnApagar.BackColor = Color.Red;
            btnApagar.ForeColor = SystemColors.ButtonHighlight;
            btnApagar.Location = new Point(581, 392);
            btnApagar.Name = "btnApagar";
            btnApagar.Size = new Size(157, 35);
            btnApagar.TabIndex = 3;
            btnApagar.Text = "Apagar";
            btnApagar.UseVisualStyleBackColor = false;
            // 
            // ContasForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(747, 439);
            Controls.Add(btnApagar);
            Controls.Add(btnCancelarConta);
            Controls.Add(btnEditar);
            Controls.Add(btnAdicionar);
            Controls.Add(dataGridView1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tableLayoutPanel1);
            Name = "ContasForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Vendas";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label lblTitulo;
        private Label label1;
        private Label label2;
        private Label label3;
        private DataGridView dataGridView1;
        private Button btnAdicionar;
        private Button btnEditar;
        private Button btnCancelarConta;
        private Button btnApagar;
    }
}