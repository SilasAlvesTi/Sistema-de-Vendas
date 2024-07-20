namespace Sistema_de_Vendas
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            var sistemaDeVendas = new MenuForm();
            sistemaDeVendas.FormClosed += (s, args) => this.Close();
            sistemaDeVendas.Show();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

    }
}
