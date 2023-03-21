namespace Estoque
{
    partial class Cadastro_de_Produto
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
            nome_produto = new TextBox();
            label_Np = new Label();
            label_PP = new Label();
            Preço_produto = new TextBox();
            boton_cadastrar = new Button();
            label1 = new Label();
            Quant_Pro = new TextBox();
            label_CAT = new Label();
            comboBox_CAT = new ComboBox();
            SuspendLayout();
            // 
            // nome_produto
            // 
            nome_produto.Location = new Point(162, 44);
            nome_produto.Name = "nome_produto";
            nome_produto.Size = new Size(157, 23);
            nome_produto.TabIndex = 0;
            // 
            // label_Np
            // 
            label_Np.AutoSize = true;
            label_Np.Location = new Point(42, 44);
            label_Np.Name = "label_Np";
            label_Np.Size = new Size(103, 15);
            label_Np.TabIndex = 1;
            label_Np.Text = "Nome do produto";
            // 
            // label_PP
            // 
            label_PP.AutoSize = true;
            label_PP.Location = new Point(42, 124);
            label_PP.Name = "label_PP";
            label_PP.Size = new Size(100, 15);
            label_PP.TabIndex = 3;
            label_PP.Text = "Preço do produto";
            // 
            // Preço_produto
            // 
            Preço_produto.Location = new Point(162, 124);
            Preço_produto.Name = "Preço_produto";
            Preço_produto.Size = new Size(157, 23);
            Preço_produto.TabIndex = 2;
            // 
            // boton_cadastrar
            // 
            boton_cadastrar.Location = new Point(203, 221);
            boton_cadastrar.Name = "boton_cadastrar";
            boton_cadastrar.Size = new Size(75, 23);
            boton_cadastrar.TabIndex = 4;
            boton_cadastrar.Text = "Cadastrar";
            boton_cadastrar.UseVisualStyleBackColor = true;
            boton_cadastrar.Click += Boton_cadastrar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 170);
            label1.Name = "label1";
            label1.Size = new Size(69, 15);
            label1.TabIndex = 6;
            label1.Text = "Quantidade";
            // 
            // Quant_Pro
            // 
            Quant_Pro.Location = new Point(162, 170);
            Quant_Pro.Name = "Quant_Pro";
            Quant_Pro.Size = new Size(157, 23);
            Quant_Pro.TabIndex = 3;
            // 
            // label_CAT
            // 
            label_CAT.AutoSize = true;
            label_CAT.Location = new Point(42, 82);
            label_CAT.Name = "label_CAT";
            label_CAT.Size = new Size(58, 15);
            label_CAT.TabIndex = 7;
            label_CAT.Text = "Categoria";
            // 
            // comboBox_CAT
            // 
            comboBox_CAT.FormattingEnabled = true;
            comboBox_CAT.Items.AddRange(new object[] { "Bebida", "Comida" });
            comboBox_CAT.Location = new Point(162, 82);
            comboBox_CAT.Name = "comboBox_CAT";
            comboBox_CAT.Size = new Size(157, 23);
            comboBox_CAT.TabIndex = 1;
            // 
            // Cadastro_de_Produto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(519, 282);
            Controls.Add(comboBox_CAT);
            Controls.Add(label_CAT);
            Controls.Add(label1);
            Controls.Add(Quant_Pro);
            Controls.Add(boton_cadastrar);
            Controls.Add(label_PP);
            Controls.Add(Preço_produto);
            Controls.Add(label_Np);
            Controls.Add(nome_produto);
            Name = "Cadastro_de_Produto";
            Text = "Cadastro de Produto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox nome_produto;
        private Label label_Np;
        private Label label_PP;
        private TextBox Preço_produto;
        private Button boton_cadastrar;
        private Label label1;
        private TextBox Quant_Pro;
        private Label label_CAT;
        private ComboBox comboBox_CAT;
    }
}