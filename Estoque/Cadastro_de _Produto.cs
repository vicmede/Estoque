namespace Estoque
{
    public partial class Cadastro_de_Produto : Form
    {
        string nome = "";
        string preço = "";
        string categoria = "";
        int quantidade;


        public Cadastro_de_Produto()
        {
            InitializeComponent();
            comboBox_CAT.Text = "[Selecione]";
        }

        private void Boton_cadastrar_Click(object sender, EventArgs e)
        {
            nome = nome_produto.Text;
            categoria = comboBox_CAT.Text;
            preço = Preço_produto.Text;
            quantidade = int.Parse(Quant_Pro.Text);

            Conexão.CadatrarP_banco(nome, categoria, preço, quantidade);

            nome_produto.Text = "";
            comboBox_CAT.Text = "[Selecione]";
            Preço_produto.Text = "";
            Quant_Pro.Text = "";

        }
    }
}
