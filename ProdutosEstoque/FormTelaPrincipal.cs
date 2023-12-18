using System.Globalization;
namespace ProdutosEstoque
{
    public partial class FormTelaPrincipal : Form
    {
        public FormTelaPrincipal()
        {
            InitializeComponent();
        }

        Produto produto = new Produto();

        private void buttonNovo_Click(object sender, EventArgs e)
        {
            PreparaCampos("novo");
        }

        private void buttonAdicionar_Click(object sender, EventArgs e)
        {
            if (VerificaPreenchimentoDosCampos() == true)
            {
                RealizaOperacao("adicionar");
                LerDados();
                lblDadosProduto.Visible = true;
            }
            else
            {
                MessageBox.Show("Preencha todos os campos: Descrição, Preço e Quantidade.");
            }
        }

        private void buttonRemover_Click(object sender, EventArgs e)
        {
            if (VerificaPreenchimentoDosCampos() == true)
            {
                RealizaOperacao("remover");
                LerDados();
                lblDadosProduto.Visible = true;
            }
            else
            {
                MessageBox.Show("Preencha todos os campos: Descrição, Preço e Quantidade.");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PreparaCampos("load");
        }

        private bool VerificaPreenchimentoDosCampos()
        {
            if (txtDescricao.Text != "" && txtPreco.Text != "" && txtQuantidade.Text != "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void RealizaOperacao(string tipoOperacao)
        {
            produto.Nome = txtDescricao.Text;
            produto.Preco = double.Parse(txtPreco.Text);
            if (tipoOperacao == "adicionar")
            {
                produto.AdicionarProduto(int.Parse(txtQuantidade.Text));
            }
            else
            {
                produto.RemoverProduto(int.Parse(txtQuantidade.Text));
            }
        }

        private void LerDados()
        {
            txtEstoqueTotal.Text = produto.QuantidadeEstoque.ToString("F2", CultureInfo.InvariantCulture);
            txtValorTotal.Text = produto.ValorTotalEstoque.ToString("F2", CultureInfo.InvariantCulture);
            lblDadosProduto.Text = produto.ToString();
        }

        private void PreparaCampos(string tipo) 
        {
            if (tipo == "load")
            {
                txtDescricao.Enabled = false;
                txtPreco.Enabled = false;
                txtQuantidade.Enabled = false;
                buttonAdicionar.Enabled = false;
                buttonRemover.Enabled = false;
                txtValorTotal.Enabled = false;
                txtEstoqueTotal.Enabled = false;
                lblDadosProduto.Visible = false;
            }
            else if (tipo == "novo")
            {
                txtDescricao.Enabled = true;
                txtPreco.Enabled = true;
                txtQuantidade.Enabled = true;
                buttonAdicionar.Enabled = true;
                buttonRemover.Enabled = true;
                buttonNovo.Visible = false;
            }
                
        }
        private void txtPreco_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se a tecla digitada não for número ou o BackSpace
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08 && e.KeyChar != ',')
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
        }

        private void txtQuantidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se a tecla digitada não for número ou o BackSpace
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08 && e.KeyChar != ',')
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
        }
    }
}
