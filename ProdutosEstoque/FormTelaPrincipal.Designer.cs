namespace ProdutosEstoque
{
    partial class FormTelaPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitulo = new Label();
            buttonNovo = new Button();
            lblDescricao = new Label();
            txtDescricao = new TextBox();
            txtPreco = new TextBox();
            lblPreco = new Label();
            txtQuantidade = new TextBox();
            lblQuantidade = new Label();
            buttonAdicionar = new Button();
            buttonRemover = new Button();
            txtValorTotal = new TextBox();
            lblValorTotal = new Label();
            txtEstoqueTotal = new TextBox();
            lblEstoqueTotal = new Label();
            lblDadosProduto = new Label();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(294, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(212, 30);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Controle de Estoque";
            // 
            // buttonNovo
            // 
            buttonNovo.BackColor = Color.FromArgb(0, 192, 0);
            buttonNovo.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonNovo.Location = new Point(291, 183);
            buttonNovo.Name = "buttonNovo";
            buttonNovo.Size = new Size(215, 79);
            buttonNovo.TabIndex = 1;
            buttonNovo.Text = "Novo Produto";
            buttonNovo.UseVisualStyleBackColor = false;
            buttonNovo.Click += buttonNovo_Click;
            // 
            // lblDescricao
            // 
            lblDescricao.AutoSize = true;
            lblDescricao.Location = new Point(23, 70);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(61, 15);
            lblDescricao.TabIndex = 2;
            lblDescricao.Text = "Descricao:";
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(90, 67);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(416, 23);
            txtDescricao.TabIndex = 3;
            // 
            // txtPreco
            // 
            txtPreco.Location = new Point(90, 96);
            txtPreco.Name = "txtPreco";
            txtPreco.Size = new Size(416, 23);
            txtPreco.TabIndex = 5;
            txtPreco.KeyPress += txtPreco_KeyPress;
            // 
            // lblPreco
            // 
            lblPreco.AutoSize = true;
            lblPreco.Location = new Point(44, 99);
            lblPreco.Name = "lblPreco";
            lblPreco.Size = new Size(40, 15);
            lblPreco.TabIndex = 4;
            lblPreco.Text = "Preço:";
            // 
            // txtQuantidade
            // 
            txtQuantidade.Location = new Point(90, 125);
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.Size = new Size(416, 23);
            txtQuantidade.TabIndex = 7;
            txtQuantidade.KeyPress += txtQuantidade_KeyPress;
            // 
            // lblQuantidade
            // 
            lblQuantidade.AutoSize = true;
            lblQuantidade.Location = new Point(12, 128);
            lblQuantidade.Name = "lblQuantidade";
            lblQuantidade.Size = new Size(72, 15);
            lblQuantidade.TabIndex = 6;
            lblQuantidade.Text = "Quantidade:";
            // 
            // buttonAdicionar
            // 
            buttonAdicionar.BackColor = Color.FromArgb(0, 192, 0);
            buttonAdicionar.Location = new Point(512, 124);
            buttonAdicionar.Name = "buttonAdicionar";
            buttonAdicionar.Size = new Size(75, 23);
            buttonAdicionar.TabIndex = 8;
            buttonAdicionar.Text = "Adicionar";
            buttonAdicionar.UseVisualStyleBackColor = false;
            buttonAdicionar.Click += buttonAdicionar_Click;
            // 
            // buttonRemover
            // 
            buttonRemover.BackColor = Color.Red;
            buttonRemover.Location = new Point(593, 124);
            buttonRemover.Name = "buttonRemover";
            buttonRemover.Size = new Size(75, 23);
            buttonRemover.TabIndex = 9;
            buttonRemover.Text = "Remover";
            buttonRemover.UseVisualStyleBackColor = false;
            buttonRemover.Click += buttonRemover_Click;
            // 
            // txtValorTotal
            // 
            txtValorTotal.Location = new Point(90, 154);
            txtValorTotal.Name = "txtValorTotal";
            txtValorTotal.Size = new Size(416, 23);
            txtValorTotal.TabIndex = 11;
            // 
            // lblValorTotal
            // 
            lblValorTotal.AutoSize = true;
            lblValorTotal.Location = new Point(12, 157);
            lblValorTotal.Name = "lblValorTotal";
            lblValorTotal.Size = new Size(64, 15);
            lblValorTotal.TabIndex = 10;
            lblValorTotal.Text = "Valor Total:";
            // 
            // txtEstoqueTotal
            // 
            txtEstoqueTotal.Location = new Point(601, 153);
            txtEstoqueTotal.Name = "txtEstoqueTotal";
            txtEstoqueTotal.Size = new Size(187, 23);
            txtEstoqueTotal.TabIndex = 13;
            // 
            // lblEstoqueTotal
            // 
            lblEstoqueTotal.AutoSize = true;
            lblEstoqueTotal.Location = new Point(515, 156);
            lblEstoqueTotal.Name = "lblEstoqueTotal";
            lblEstoqueTotal.Size = new Size(80, 15);
            lblEstoqueTotal.TabIndex = 12;
            lblEstoqueTotal.Text = "Estoque Total:";
            // 
            // lblDadosProduto
            // 
            lblDadosProduto.AutoSize = true;
            lblDadosProduto.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDadosProduto.Location = new Point(12, 339);
            lblDadosProduto.Name = "lblDadosProduto";
            lblDadosProduto.Size = new Size(201, 17);
            lblDadosProduto.TabIndex = 14;
            lblDadosProduto.Text = "Dados Atualizados do Produto:";
            // 
            // FormTelaPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(lblDadosProduto);
            Controls.Add(txtEstoqueTotal);
            Controls.Add(lblEstoqueTotal);
            Controls.Add(txtValorTotal);
            Controls.Add(lblValorTotal);
            Controls.Add(buttonRemover);
            Controls.Add(buttonAdicionar);
            Controls.Add(txtQuantidade);
            Controls.Add(lblQuantidade);
            Controls.Add(txtPreco);
            Controls.Add(lblPreco);
            Controls.Add(txtDescricao);
            Controls.Add(lblDescricao);
            Controls.Add(buttonNovo);
            Controls.Add(lblTitulo);
            Name = "FormTelaPrincipal";
            Text = "FormTelaPrincipal";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Button buttonNovo;
        private Label lblDescricao;
        private TextBox txtDescricao;
        private TextBox txtPreco;
        private Label lblPreco;
        private TextBox txtQuantidade;
        private Label lblQuantidade;
        private Button buttonAdicionar;
        private Button buttonRemover;
        private TextBox txtValorTotal;
        private Label lblValorTotal;
        private TextBox txtEstoqueTotal;
        private Label lblEstoqueTotal;
        private Label lblDadosProduto;
    }
}
