namespace Receitas.View
{
    partial class FrmAtualizaIngrediente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAtualizaIngrediente));
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIngrediente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbxIngrediente = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.cbxUnidade = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtQuant = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(120, 509);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 30);
            this.button1.TabIndex = 23;
            this.button1.Text = "Salvar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 22;
            this.label1.Text = "Novo Nome";
            // 
            // txtIngrediente
            // 
            this.txtIngrediente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIngrediente.Location = new System.Drawing.Point(39, 222);
            this.txtIngrediente.Name = "txtIngrediente";
            this.txtIngrediente.Size = new System.Drawing.Size(302, 26);
            this.txtIngrediente.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "Nome do Ingrediente";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(137, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 99);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // cbxIngrediente
            // 
            this.cbxIngrediente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxIngrediente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxIngrediente.FormattingEnabled = true;
            this.cbxIngrediente.Location = new System.Drawing.Point(39, 155);
            this.cbxIngrediente.Name = "cbxIngrediente";
            this.cbxIngrediente.Size = new System.Drawing.Size(302, 28);
            this.cbxIngrediente.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 350);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 20);
            this.label4.TabIndex = 29;
            this.label4.Text = "Descrição";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricao.Location = new System.Drawing.Point(31, 375);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.PasswordChar = '*';
            this.txtDescricao.Size = new System.Drawing.Size(310, 118);
            this.txtDescricao.TabIndex = 28;
            // 
            // cbxUnidade
            // 
            this.cbxUnidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxUnidade.FormattingEnabled = true;
            this.cbxUnidade.Items.AddRange(new object[] {
            "L",
            "Ml",
            "Kg"});
            this.cbxUnidade.Location = new System.Drawing.Point(155, 306);
            this.cbxUnidade.Name = "cbxUnidade";
            this.cbxUnidade.Size = new System.Drawing.Size(186, 28);
            this.cbxUnidade.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 309);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 25;
            this.label3.Text = "Unidade";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 262);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 20);
            this.label5.TabIndex = 26;
            this.label5.Text = "Quantidade";
            // 
            // txtQuant
            // 
            this.txtQuant.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuant.Location = new System.Drawing.Point(155, 259);
            this.txtQuant.Name = "txtQuant";
            this.txtQuant.PasswordChar = '*';
            this.txtQuant.Size = new System.Drawing.Size(186, 26);
            this.txtQuant.TabIndex = 24;
            // 
            // FrmAtualizaIngrediente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 562);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.cbxUnidade);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtQuant);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIngrediente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cbxIngrediente);
            this.Name = "FrmAtualizaIngrediente";
            this.Text = "FrmAtualizaIngrediente";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIngrediente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cbxIngrediente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.ComboBox cbxUnidade;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtQuant;
    }
}