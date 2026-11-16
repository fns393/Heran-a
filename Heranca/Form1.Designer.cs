namespace Heranca
{
    partial class Form1
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
            this.Criar_ponto = new System.Windows.Forms.Button();
            this.lbl_output = new System.Windows.Forms.Label();
            this.lbl_X = new System.Windows.Forms.Label();
            this.lbl_Y = new System.Windows.Forms.Label();
            this.lbl_Z = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txt_X = new System.Windows.Forms.TextBox();
            this.txt_Y = new System.Windows.Forms.TextBox();
            this.txt_Z = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Criar_ponto
            // 
            this.Criar_ponto.Location = new System.Drawing.Point(546, 183);
            this.Criar_ponto.Name = "Criar_ponto";
            this.Criar_ponto.Size = new System.Drawing.Size(75, 23);
            this.Criar_ponto.TabIndex = 0;
            this.Criar_ponto.Text = "Criar Ponto";
            this.Criar_ponto.UseVisualStyleBackColor = true;
            this.Criar_ponto.Click += new System.EventHandler(this.Criar_ponto_Click);
            // 
            // lbl_output
            // 
            this.lbl_output.AutoSize = true;
            this.lbl_output.Location = new System.Drawing.Point(333, 313);
            this.lbl_output.Name = "lbl_output";
            this.lbl_output.Size = new System.Drawing.Size(158, 13);
            this.lbl_output.TabIndex = 1;
            this.lbl_output.Text = "Os Resultados apareceram aqui";
            // 
            // lbl_X
            // 
            this.lbl_X.AutoSize = true;
            this.lbl_X.Location = new System.Drawing.Point(236, 153);
            this.lbl_X.Name = "lbl_X";
            this.lbl_X.Size = new System.Drawing.Size(56, 13);
            this.lbl_X.TabIndex = 2;
            this.lbl_X.Text = "Valor de X";
            // 
            // lbl_Y
            // 
            this.lbl_Y.AutoSize = true;
            this.lbl_Y.Location = new System.Drawing.Point(236, 186);
            this.lbl_Y.Name = "lbl_Y";
            this.lbl_Y.Size = new System.Drawing.Size(56, 13);
            this.lbl_Y.TabIndex = 3;
            this.lbl_Y.Text = "Valor de Y";
            // 
            // lbl_Z
            // 
            this.lbl_Z.AutoSize = true;
            this.lbl_Z.Location = new System.Drawing.Point(236, 222);
            this.lbl_Z.Name = "lbl_Z";
            this.lbl_Z.Size = new System.Drawing.Size(56, 13);
            this.lbl_Z.TabIndex = 4;
            this.lbl_Z.Text = "Valor de Z";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txt_X
            // 
            this.txt_X.Location = new System.Drawing.Point(310, 150);
            this.txt_X.Name = "txt_X";
            this.txt_X.Size = new System.Drawing.Size(100, 20);
            this.txt_X.TabIndex = 6;
            // 
            // txt_Y
            // 
            this.txt_Y.Location = new System.Drawing.Point(310, 183);
            this.txt_Y.Name = "txt_Y";
            this.txt_Y.Size = new System.Drawing.Size(100, 20);
            this.txt_Y.TabIndex = 7;
            // 
            // txt_Z
            // 
            this.txt_Z.Location = new System.Drawing.Point(310, 219);
            this.txt_Z.Name = "txt_Z";
            this.txt_Z.Size = new System.Drawing.Size(100, 20);
            this.txt_Z.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_Z);
            this.Controls.Add(this.txt_Y);
            this.Controls.Add(this.txt_X);
            this.Controls.Add(this.lbl_Z);
            this.Controls.Add(this.lbl_Y);
            this.Controls.Add(this.lbl_X);
            this.Controls.Add(this.lbl_output);
            this.Controls.Add(this.Criar_ponto);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Criar_ponto;
        private System.Windows.Forms.Label lbl_output;
        private System.Windows.Forms.Label lbl_X;
        private System.Windows.Forms.Label lbl_Y;
        private System.Windows.Forms.Label lbl_Z;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txt_X;
        private System.Windows.Forms.TextBox txt_Y;
        private System.Windows.Forms.TextBox txt_Z;
    }
}

