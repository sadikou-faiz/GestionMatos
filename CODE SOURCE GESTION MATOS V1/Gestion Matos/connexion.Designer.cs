
namespace Gestion_Matos
{
    partial class connexion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(connexion));
            this.button_connexion = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_mdp = new System.Windows.Forms.TextBox();
            this.textBox_pseudo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.error = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_connexion
            // 
            this.button_connexion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(119)))), ((int)(((byte)(242)))));
            this.button_connexion.Font = new System.Drawing.Font("Rubik", 10F);
            this.button_connexion.ForeColor = System.Drawing.Color.White;
            this.button_connexion.Location = new System.Drawing.Point(32, 480);
            this.button_connexion.Name = "button_connexion";
            this.button_connexion.Size = new System.Drawing.Size(352, 40);
            this.button_connexion.TabIndex = 82;
            this.button_connexion.Text = "Connexion";
            this.button_connexion.UseVisualStyleBackColor = false;
            this.button_connexion.Click += new System.EventHandler(this.button_connexion_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rubik", 12F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(28, 390);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 24);
            this.label3.TabIndex = 81;
            this.label3.Text = "Mot de passe";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rubik", 12F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(28, 314);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 24);
            this.label2.TabIndex = 80;
            this.label2.Text = "Identifiant";
            // 
            // textBox_mdp
            // 
            this.textBox_mdp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_mdp.Font = new System.Drawing.Font("Rubik", 12F);
            this.textBox_mdp.ImeMode = System.Windows.Forms.ImeMode.On;
            this.textBox_mdp.Location = new System.Drawing.Point(32, 418);
            this.textBox_mdp.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_mdp.Name = "textBox_mdp";
            this.textBox_mdp.Size = new System.Drawing.Size(352, 31);
            this.textBox_mdp.TabIndex = 79;
            this.textBox_mdp.UseSystemPasswordChar = true;
            // 
            // textBox_pseudo
            // 
            this.textBox_pseudo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_pseudo.Font = new System.Drawing.Font("Rubik", 12F);
            this.textBox_pseudo.ImeMode = System.Windows.Forms.ImeMode.On;
            this.textBox_pseudo.Location = new System.Drawing.Point(32, 342);
            this.textBox_pseudo.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_pseudo.Name = "textBox_pseudo";
            this.textBox_pseudo.Size = new System.Drawing.Size(352, 31);
            this.textBox_pseudo.TabIndex = 78;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rubik", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(55, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 51);
            this.label1.TabIndex = 83;
            this.label1.Text = "CONNEXION";
            // 
            // error
            // 
            this.error.AutoSize = true;
            this.error.Font = new System.Drawing.Font("Rubik", 10F);
            this.error.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(48)))), ((int)(((byte)(37)))));
            this.error.Location = new System.Drawing.Point(28, 273);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(0, 20);
            this.error.TabIndex = 85;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(123, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(231, 170);
            this.pictureBox1.TabIndex = 86;
            this.pictureBox1.TabStop = false;
            // 
            // connexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(419, 555);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.error);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_connexion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_mdp);
            this.Controls.Add(this.textBox_pseudo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "connexion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CONNEXION GESTION  MATOS";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_connexion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_mdp;
        private System.Windows.Forms.TextBox textBox_pseudo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label error;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}