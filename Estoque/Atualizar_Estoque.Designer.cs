namespace Estoque
{
    partial class Atualizar_estoque
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
            comboBox1 = new ComboBox();
            label1 = new Label();
            QuantN_Pro = new TextBox();
            label_PP = new Label();
            PreçoN_produto = new TextBox();
            label_Np = new Label();
            button_ATT = new Button();
            button_DEL_Produto = new Button();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(132, 62);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(157, 23);
            comboBox1.TabIndex = 0;
            comboBox1.SelectedIndexChanged += ComboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 163);
            label1.Name = "label1";
            label1.Size = new Size(69, 15);
            label1.TabIndex = 11;
            label1.Text = "Quantidade";
            // 
            // QuantN_Pro
            // 
            QuantN_Pro.Location = new Point(132, 163);
            QuantN_Pro.Name = "QuantN_Pro";
            QuantN_Pro.Size = new Size(157, 23);
            QuantN_Pro.TabIndex = 2;
            // 
            // label_PP
            // 
            label_PP.AutoSize = true;
            label_PP.Location = new Point(12, 117);
            label_PP.Name = "label_PP";
            label_PP.Size = new Size(100, 15);
            label_PP.TabIndex = 10;
            label_PP.Text = "Preço do produto";
            // 
            // PreçoN_produto
            // 
            PreçoN_produto.Location = new Point(132, 117);
            PreçoN_produto.Name = "PreçoN_produto";
            PreçoN_produto.Size = new Size(157, 23);
            PreçoN_produto.TabIndex = 1;
            // 
            // label_Np
            // 
            label_Np.AutoSize = true;
            label_Np.Location = new Point(12, 62);
            label_Np.Name = "label_Np";
            label_Np.Size = new Size(103, 15);
            label_Np.TabIndex = 7;
            label_Np.Text = "Nome do produto";
            // 
            // button_ATT
            // 
            button_ATT.Location = new Point(172, 208);
            button_ATT.Name = "button_ATT";
            button_ATT.Size = new Size(75, 23);
            button_ATT.TabIndex = 3;
            button_ATT.Text = "Atualizar";
            button_ATT.UseVisualStyleBackColor = true;
            button_ATT.Click += Button1_Click;
            // 
            // button_DEL_Produto
            // 
            button_DEL_Produto.Location = new Point(318, 62);
            button_DEL_Produto.Name = "button_DEL_Produto";
            button_DEL_Produto.Size = new Size(110, 23);
            button_DEL_Produto.TabIndex = 4;
            button_DEL_Produto.Text = "Deletar Produto";
            button_DEL_Produto.UseVisualStyleBackColor = true;
            button_DEL_Produto.Click += Button_DEL_Produto_Click;
            // 
            // Atualizar_estoque
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(519, 282);
            Controls.Add(button_DEL_Produto);
            Controls.Add(button_ATT);
            Controls.Add(label1);
            Controls.Add(QuantN_Pro);
            Controls.Add(label_PP);
            Controls.Add(PreçoN_produto);
            Controls.Add(label_Np);
            Controls.Add(comboBox1);
            Name = "Atualizar_estoque";
            Text = "Atualizar estoque";
            Load += Atualizar_estoque_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Label label1;
        private TextBox QuantN_Pro;
        private Label label_PP;
        private TextBox PreçoN_produto;
        private Label label_Np;
        private Button button_ATT;
        private Button button_DEL_Produto;
    }
}