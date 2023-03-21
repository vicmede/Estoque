using Mysqlx.Expect;

namespace Estoque
{
    public partial class TL : Form

    {
        readonly Cadastro_de_Produto CP = new();
        readonly Atualizar_estoque AE = new();

        public TL()
        {
            InitializeComponent();
        }



        private void Cadatro_P_Click(object sender, EventArgs e)
        {
            CP.ShowDialog();
        }

        private void TL_Load(object sender, EventArgs e)
        {
            Conexão.Conectar();
            dGV_estoque.DataSource = Conexão.Carrega_dados_estoque();
        }

        private void ATT_Estoque_Click(object sender, EventArgs e)
        {
            AE.ShowDialog();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            dGV_estoque.DataSource = Conexão.Carrega_dados_estoque();
        }


    }
}