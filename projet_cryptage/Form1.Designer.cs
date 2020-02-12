namespace projet_cryptage
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.textCHEMIN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.butCHEMIN = new System.Windows.Forms.Button();
            this.texteclair = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.butcesar = new System.Windows.Forms.RadioButton();
            this.textechiffre = new System.Windows.Forms.TextBox();
            this.label83 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // textCHEMIN
            // 
            this.textCHEMIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCHEMIN.Location = new System.Drawing.Point(294, 52);
            this.textCHEMIN.Margin = new System.Windows.Forms.Padding(4);
            this.textCHEMIN.Name = "textCHEMIN";
            this.textCHEMIN.Size = new System.Drawing.Size(674, 38);
            this.textCHEMIN.TabIndex = 0;
            this.textCHEMIN.Text = "c/";
            this.textCHEMIN.TextChanged += new System.EventHandler(this.textCHEMIN_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(75, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "CHEMIN :";
            // 
            // butCHEMIN
            // 
            this.butCHEMIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butCHEMIN.Location = new System.Drawing.Point(1022, 52);
            this.butCHEMIN.Margin = new System.Windows.Forms.Padding(4);
            this.butCHEMIN.Name = "butCHEMIN";
            this.butCHEMIN.Size = new System.Drawing.Size(37, 28);
            this.butCHEMIN.TabIndex = 2;
            this.butCHEMIN.Text = "...";
            this.butCHEMIN.UseVisualStyleBackColor = true;
            this.butCHEMIN.Click += new System.EventHandler(this.butCHEMIN_Click);
            // 
            // texteclair
            // 
            this.texteclair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.texteclair.Location = new System.Drawing.Point(45, 121);
            this.texteclair.Margin = new System.Windows.Forms.Padding(4);
            this.texteclair.Multiline = true;
            this.texteclair.Name = "texteclair";
            this.texteclair.Size = new System.Drawing.Size(1026, 84);
            this.texteclair.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(106, 209);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 36);
            this.label3.TabIndex = 6;
            this.label3.Text = "METHODE :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label39.Location = new System.Drawing.Point(3, 29);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(14, 30);
            this.label39.TabIndex = 22;
            this.label39.Text = "l";
            // 
            // butcesar
            // 
            this.butcesar.AutoSize = true;
            this.butcesar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butcesar.Location = new System.Drawing.Point(326, 209);
            this.butcesar.Margin = new System.Windows.Forms.Padding(4);
            this.butcesar.Name = "butcesar";
            this.butcesar.Size = new System.Drawing.Size(244, 40);
            this.butcesar.TabIndex = 12;
            this.butcesar.TabStop = true;
            this.butcesar.Text = "Chiffre de cesar";
            this.butcesar.UseVisualStyleBackColor = true;
            this.butcesar.CheckedChanged += new System.EventHandler(this.butcesar_CheckedChanged);
            // 
            // textechiffre
            // 
            this.textechiffre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textechiffre.Location = new System.Drawing.Point(22, 409);
            this.textechiffre.Margin = new System.Windows.Forms.Padding(4);
            this.textechiffre.Multiline = true;
            this.textechiffre.Name = "textechiffre";
            this.textechiffre.Size = new System.Drawing.Size(1037, 184);
            this.textechiffre.TabIndex = 13;
            this.textechiffre.TextChanged += new System.EventHandler(this.textechiffre_TextChanged);
            // 
            // label83
            // 
            this.label83.AutoSize = true;
            this.label83.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label83.Location = new System.Drawing.Point(195, 16);
            this.label83.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label83.Name = "label83";
            this.label83.Size = new System.Drawing.Size(987, 32);
            this.label83.TabIndex = 14;
            this.label83.Text = "SELECTIONNER UN FICHIER OU ENTRER DIRECTEMENT LE TEXTE :";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Blue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(124, 346);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 37);
            this.button1.TabIndex = 18;
            this.button1.Text = "chiffrer";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(434, 346);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 37);
            this.button2.TabIndex = 19;
            this.button2.Text = "déchiffrer";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(768, 346);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(127, 37);
            this.button3.TabIndex = 20;
            this.button3.Text = "effacer";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(504, 289);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(57, 30);
            this.numericUpDown1.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(89, 289);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(382, 32);
            this.label2.TabIndex = 25;
            this.label2.Text = "choix de la clé de chiffrement";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1084, 581);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label83);
            this.Controls.Add(this.textechiffre);
            this.Controls.Add(this.butcesar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.texteclair);
            this.Controls.Add(this.butCHEMIN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textCHEMIN);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox textCHEMIN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button butCHEMIN;
        private System.Windows.Forms.TextBox texteclair;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.RadioButton butcesar;
        private System.Windows.Forms.TextBox textechiffre;
        private System.Windows.Forms.Label label83;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label2;
    }
}

