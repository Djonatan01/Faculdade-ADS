namespace Poo_Conteudo10_exercicios
{
    partial class Exercico1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lbPerimetro = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Largura = new System.Windows.Forms.TextBox();
            this.txt_altura = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btArea = new System.Windows.Forms.Button();
            this.btPerimetro = new System.Windows.Forms.Button();
            this.btDiagonal = new System.Windows.Forms.Button();
            this.lbArea = new System.Windows.Forms.Label();
            this.lbDiagonal = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SuspendLayout();
            // 
            // lbPerimetro
            // 
            this.lbPerimetro.AutoSize = true;
            this.lbPerimetro.Location = new System.Drawing.Point(199, 219);
            this.lbPerimetro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPerimetro.Name = "lbPerimetro";
            this.lbPerimetro.Size = new System.Drawing.Size(0, 20);
            this.lbPerimetro.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Informe a largura do retângulo";
            // 
            // txt_Largura
            // 
            this.txt_Largura.Location = new System.Drawing.Point(42, 62);
            this.txt_Largura.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Largura.Name = "txt_Largura";
            this.txt_Largura.Size = new System.Drawing.Size(148, 26);
            this.txt_Largura.TabIndex = 1;
            this.txt_Largura.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Largura.TextChanged += new System.EventHandler(this.txt_Largura_TextChanged);
            this.txt_Largura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Largura_KeyPress);
            // 
            // txt_altura
            // 
            this.txt_altura.Location = new System.Drawing.Point(318, 62);
            this.txt_altura.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_altura.Name = "txt_altura";
            this.txt_altura.Size = new System.Drawing.Size(148, 26);
            this.txt_altura.TabIndex = 2;
            this.txt_altura.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_altura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_altura_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(291, 18);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Informe a altura do retângulo";
            // 
            // btArea
            // 
            this.btArea.Location = new System.Drawing.Point(42, 162);
            this.btArea.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btArea.Name = "btArea";
            this.btArea.Size = new System.Drawing.Size(112, 35);
            this.btArea.TabIndex = 4;
            this.btArea.Text = "Área";
            this.btArea.UseVisualStyleBackColor = true;
            this.btArea.Click += new System.EventHandler(this.btArea_Click);
            // 
            // btPerimetro
            // 
            this.btPerimetro.Location = new System.Drawing.Point(195, 162);
            this.btPerimetro.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btPerimetro.Name = "btPerimetro";
            this.btPerimetro.Size = new System.Drawing.Size(112, 35);
            this.btPerimetro.TabIndex = 5;
            this.btPerimetro.Text = "Perímetro";
            this.btPerimetro.UseVisualStyleBackColor = true;
            this.btPerimetro.Click += new System.EventHandler(this.btPerimetro_Click);
            // 
            // btDiagonal
            // 
            this.btDiagonal.Location = new System.Drawing.Point(356, 162);
            this.btDiagonal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btDiagonal.Name = "btDiagonal";
            this.btDiagonal.Size = new System.Drawing.Size(112, 35);
            this.btDiagonal.TabIndex = 6;
            this.btDiagonal.Text = "Diagonal";
            this.btDiagonal.UseVisualStyleBackColor = true;
            this.btDiagonal.Click += new System.EventHandler(this.btDiagonal_Click);
            // 
            // lbArea
            // 
            this.lbArea.AutoSize = true;
            this.lbArea.Location = new System.Drawing.Point(54, 219);
            this.lbArea.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbArea.Name = "lbArea";
            this.lbArea.Size = new System.Drawing.Size(0, 20);
            this.lbArea.TabIndex = 7;
            // 
            // lbDiagonal
            // 
            this.lbDiagonal.AutoSize = true;
            this.lbDiagonal.Location = new System.Drawing.Point(352, 219);
            this.lbDiagonal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDiagonal.Name = "lbDiagonal";
            this.lbDiagonal.Size = new System.Drawing.Size(0, 20);
            this.lbDiagonal.TabIndex = 9;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Exercico1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 385);
            this.Controls.Add(this.lbDiagonal);
            this.Controls.Add(this.lbPerimetro);
            this.Controls.Add(this.lbArea);
            this.Controls.Add(this.btDiagonal);
            this.Controls.Add(this.btPerimetro);
            this.Controls.Add(this.btArea);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_altura);
            this.Controls.Add(this.txt_Largura);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Exercico1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exercício1";
            this.Load += new System.EventHandler(this.Exercico1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Largura;
        private System.Windows.Forms.TextBox txt_altura;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btArea;
        private System.Windows.Forms.Button btPerimetro;
        private System.Windows.Forms.Button btDiagonal;
        private System.Windows.Forms.Label lbArea;
        private System.Windows.Forms.Label lbDiagonal;
        private System.Windows.Forms.Label lbPerimetro;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}

