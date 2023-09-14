
namespace Compra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEstoque = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMin = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMax = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.lblCompra = new System.Windows.Forms.Label();
            this.picAlerta = new System.Windows.Forms.PictureBox();
            this.picMedio = new System.Windows.Forms.PictureBox();
            this.picOk = new System.Windows.Forms.PictureBox();
            this.lblResposta = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAlerta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMedio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOk)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(742, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(56, 50);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(12, 69);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(335, 313);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(242, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(344, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Preencha as informações";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(93, 385);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "Air Jordan";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(150, 416);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 31);
            this.label3.TabIndex = 4;
            this.label3.Text = "4";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(353, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(203, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Qual saldo em estoque?";
            // 
            // txtEstoque
            // 
            this.txtEstoque.Location = new System.Drawing.Point(357, 101);
            this.txtEstoque.Name = "txtEstoque";
            this.txtEstoque.Size = new System.Drawing.Size(229, 20);
            this.txtEstoque.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(353, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(212, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Valor mínimo do estoque:";
            // 
            // txtMin
            // 
            this.txtMin.Location = new System.Drawing.Point(357, 173);
            this.txtMin.Name = "txtMin";
            this.txtMin.Size = new System.Drawing.Size(229, 20);
            this.txtMin.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(353, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(216, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Valor máximo do estoque:";
            // 
            // txtMax
            // 
            this.txtMax.Location = new System.Drawing.Point(357, 246);
            this.txtMax.Name = "txtMax";
            this.txtMax.Size = new System.Drawing.Size(229, 20);
            this.txtMax.TabIndex = 10;
            this.txtMax.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(371, 285);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 11;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(609, 140);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(179, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Necessidade de compra";
            // 
            // lblCompra
            // 
            this.lblCompra.AutoSize = true;
            this.lblCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompra.Location = new System.Drawing.Point(687, 173);
            this.lblCompra.Name = "lblCompra";
            this.lblCompra.Size = new System.Drawing.Size(0, 29);
            this.lblCompra.TabIndex = 13;
            // 
            // picAlerta
            // 
            this.picAlerta.Image = ((System.Drawing.Image)(resources.GetObject("picAlerta.Image")));
            this.picAlerta.Location = new System.Drawing.Point(357, 375);
            this.picAlerta.Name = "picAlerta";
            this.picAlerta.Size = new System.Drawing.Size(116, 100);
            this.picAlerta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAlerta.TabIndex = 14;
            this.picAlerta.TabStop = false;
            this.picAlerta.Visible = false;
            // 
            // picMedio
            // 
            this.picMedio.Image = ((System.Drawing.Image)(resources.GetObject("picMedio.Image")));
            this.picMedio.Location = new System.Drawing.Point(497, 375);
            this.picMedio.Name = "picMedio";
            this.picMedio.Size = new System.Drawing.Size(116, 100);
            this.picMedio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMedio.TabIndex = 15;
            this.picMedio.TabStop = false;
            this.picMedio.Visible = false;
            // 
            // picOk
            // 
            this.picOk.Image = ((System.Drawing.Image)(resources.GetObject("picOk.Image")));
            this.picOk.Location = new System.Drawing.Point(633, 375);
            this.picOk.Name = "picOk";
            this.picOk.Size = new System.Drawing.Size(116, 100);
            this.picOk.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picOk.TabIndex = 16;
            this.picOk.TabStop = false;
            this.picOk.Visible = false;
            // 
            // lblResposta
            // 
            this.lblResposta.AutoSize = true;
            this.lblResposta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResposta.Location = new System.Drawing.Point(504, 333);
            this.lblResposta.Name = "lblResposta";
            this.lblResposta.Size = new System.Drawing.Size(0, 20);
            this.lblResposta.TabIndex = 17;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(452, 285);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 18;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(800, 487);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.lblResposta);
            this.Controls.Add(this.picOk);
            this.Controls.Add(this.picMedio);
            this.Controls.Add(this.picAlerta);
            this.Controls.Add(this.lblCompra);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtMax);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtMin);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtEstoque);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAlerta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMedio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOk)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEstoque;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMax;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblCompra;
        private System.Windows.Forms.PictureBox picAlerta;
        private System.Windows.Forms.PictureBox picMedio;
        private System.Windows.Forms.PictureBox picOk;
        private System.Windows.Forms.Label lblResposta;
        private System.Windows.Forms.Button btnLimpar;
    }
}

