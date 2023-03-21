namespace Estoque
{
    partial class TL
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
            ESTOQUE = new Label();
            ATT_Estoque = new Button();
            Cadastro_P = new Button();
            dGV_estoque = new DataGridView();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dGV_estoque).BeginInit();
            SuspendLayout();
            // 
            // ESTOQUE
            // 
            ESTOQUE.AutoSize = true;
            ESTOQUE.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            ESTOQUE.Location = new Point(270, 9);
            ESTOQUE.Name = "ESTOQUE";
            ESTOQUE.Size = new Size(220, 37);
            ESTOQUE.TabIndex = 0;
            ESTOQUE.Text = "ESTOQUE DO  ZÉ";
            // 
            // ATT_Estoque
            // 
            ATT_Estoque.Location = new Point(590, 161);
            ATT_Estoque.Name = "ATT_Estoque";
            ATT_Estoque.Size = new Size(177, 23);
            ATT_Estoque.TabIndex = 1;
            ATT_Estoque.Text = "Atualizar Estoque";
            ATT_Estoque.UseVisualStyleBackColor = true;
            ATT_Estoque.Click += ATT_Estoque_Click;
            // 
            // Cadastro_P
            // 
            Cadastro_P.Location = new Point(590, 121);
            Cadastro_P.Name = "Cadastro_P";
            Cadastro_P.Size = new Size(177, 23);
            Cadastro_P.TabIndex = 0;
            Cadastro_P.Text = "Cadastrar Produto";
            Cadastro_P.UseVisualStyleBackColor = true;
            Cadastro_P.Click += Cadatro_P_Click;
            // 
            // dGV_estoque
            // 
            dGV_estoque.AllowDrop = true;
            dGV_estoque.AllowUserToAddRows = false;
            dGV_estoque.AllowUserToDeleteRows = false;
            dGV_estoque.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dGV_estoque.Location = new Point(12, 121);
            dGV_estoque.Name = "dGV_estoque";
            dGV_estoque.ReadOnly = true;
            dGV_estoque.RowTemplate.Height = 25;
            dGV_estoque.Size = new Size(514, 210);
            dGV_estoque.TabIndex = 8;
            // 
            // button1
            // 
            button1.Location = new Point(219, 337);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "Atualizar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Button1_Click;
            // 
            // TL
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 451);
            Controls.Add(button1);
            Controls.Add(dGV_estoque);
            Controls.Add(ATT_Estoque);
            Controls.Add(Cadastro_P);
            Controls.Add(ESTOQUE);
            Name = "TL";
            Text = "Estoque do  zé";
            Load += TL_Load;
            ((System.ComponentModel.ISupportInitialize)dGV_estoque).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ESTOQUE;
        private Button ATT_Estoque;
        private Button Cadastro_P;
        private DataGridView dGV_estoque;
        private Button button1;
    }
}