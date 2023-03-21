using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estoque
{
    public partial class Atualizar_estoque : Form
    {


        public Atualizar_estoque()
        {
            InitializeComponent();
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.Text = "[Selecione]";
        }

        private void Atualizar_estoque_Load(object sender, EventArgs e)
        {
            comboBox1.DisplayMember = "Nome_produtos";
            comboBox1.DataSource = Conexão.Carrega_dados_estoque();

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string Nome, Preço;
            int Quantidade;
            Nome = comboBox1.Text;
            Preço = PreçoN_produto.Text;
            Quantidade = int.Parse(QuantN_Pro.Text);

            Conexão.Atualiza_estoque(Nome, Preço, Quantidade);

            comboBox1.Text = "[Selecione]";
            PreçoN_produto.Text = ("");
            QuantN_Pro.Text = "";

        }

        private void Button_DEL_Produto_Click(object sender, EventArgs e)
        {
            string Nome;
            Nome = comboBox1.Text;
            Conexão.Deletar_produto(Nome);
            comboBox1.DataSource = Conexão.Carrega_dados_estoque();
            comboBox1.Text = "[Selecione]";
        }
    }
}
