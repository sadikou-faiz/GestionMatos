
namespace GestionMatos_Matos
{
    partial class Client
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.list_box_client = new System.Windows.Forms.ListBox();
            this.text_box_client_id = new System.Windows.Forms.TextBox();
            this.text_box_mail = new System.Windows.Forms.TextBox();
            this.textBox_nom = new System.Windows.Forms.TextBox();
            this.textBox_tel = new System.Windows.Forms.TextBox();
            this.Btn_nouveau = new System.Windows.Forms.Button();
            this.Btn_modification = new System.Windows.Forms.Button();
            this.Btn_supprimer = new System.Windows.Forms.Button();
            this.Btn_valider = new System.Windows.Forms.Button();
            this.ButtonQuitter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Rubik", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(270, 54);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 24);
            this.label4.TabIndex = 57;
            this.label4.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rubik", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(269, 205);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 24);
            this.label3.TabIndex = 55;
            this.label3.Text = "Téléphone";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rubik", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(269, 155);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 24);
            this.label1.TabIndex = 53;
            this.label1.Text = "Adresse Mail";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rubik", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(269, 107);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 24);
            this.label2.TabIndex = 51;
            this.label2.Text = "Nom";
            // 
            // list_box_client
            // 
            this.list_box_client.Font = new System.Drawing.Font("Rubik", 12F);
            this.list_box_client.FormattingEnabled = true;
            this.list_box_client.ItemHeight = 24;
            this.list_box_client.Location = new System.Drawing.Point(23, 26);
            this.list_box_client.Margin = new System.Windows.Forms.Padding(4);
            this.list_box_client.Name = "list_box_client";
            this.list_box_client.Size = new System.Drawing.Size(215, 412);
            this.list_box_client.TabIndex = 49;
            this.list_box_client.SelectedIndexChanged += new System.EventHandler(this.list_box_client_SelectedIndexChanged);
            // 
            // text_box_client_id
            // 
            this.text_box_client_id.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(58)))));
            this.text_box_client_id.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_box_client_id.Font = new System.Drawing.Font("Rubik", 12F);
            this.text_box_client_id.ForeColor = System.Drawing.Color.White;
            this.text_box_client_id.ImeMode = System.Windows.Forms.ImeMode.On;
            this.text_box_client_id.Location = new System.Drawing.Point(405, 54);
            this.text_box_client_id.Margin = new System.Windows.Forms.Padding(4);
            this.text_box_client_id.Name = "text_box_client_id";
            this.text_box_client_id.ReadOnly = true;
            this.text_box_client_id.Size = new System.Drawing.Size(253, 24);
            this.text_box_client_id.TabIndex = 65;
            // 
            // text_box_mail
            // 
            this.text_box_mail.BackColor = System.Drawing.Color.White;
            this.text_box_mail.Font = new System.Drawing.Font("Rubik", 12F);
            this.text_box_mail.ImeMode = System.Windows.Forms.ImeMode.On;
            this.text_box_mail.Location = new System.Drawing.Point(405, 148);
            this.text_box_mail.Margin = new System.Windows.Forms.Padding(4);
            this.text_box_mail.Name = "text_box_mail";
            this.text_box_mail.Size = new System.Drawing.Size(253, 31);
            this.text_box_mail.TabIndex = 69;
            // 
            // textBox_nom
            // 
            this.textBox_nom.BackColor = System.Drawing.Color.White;
            this.textBox_nom.Font = new System.Drawing.Font("Rubik", 12F);
            this.textBox_nom.ImeMode = System.Windows.Forms.ImeMode.On;
            this.textBox_nom.Location = new System.Drawing.Point(405, 100);
            this.textBox_nom.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_nom.Name = "textBox_nom";
            this.textBox_nom.Size = new System.Drawing.Size(253, 31);
            this.textBox_nom.TabIndex = 70;
            // 
            // textBox_tel
            // 
            this.textBox_tel.BackColor = System.Drawing.Color.White;
            this.textBox_tel.Font = new System.Drawing.Font("Rubik", 12F);
            this.textBox_tel.ImeMode = System.Windows.Forms.ImeMode.On;
            this.textBox_tel.Location = new System.Drawing.Point(405, 198);
            this.textBox_tel.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_tel.Name = "textBox_tel";
            this.textBox_tel.Size = new System.Drawing.Size(253, 31);
            this.textBox_tel.TabIndex = 71;
            // 
            // Btn_nouveau
            // 
            this.Btn_nouveau.BackColor = System.Drawing.Color.White;
            this.Btn_nouveau.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_nouveau.Font = new System.Drawing.Font("Rubik", 10F);
            this.Btn_nouveau.ForeColor = System.Drawing.Color.Black;
            this.Btn_nouveau.Location = new System.Drawing.Point(273, 261);
            this.Btn_nouveau.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_nouveau.Name = "Btn_nouveau";
            this.Btn_nouveau.Size = new System.Drawing.Size(189, 38);
            this.Btn_nouveau.TabIndex = 72;
            this.Btn_nouveau.Text = "Nouveau";
            this.Btn_nouveau.UseVisualStyleBackColor = false;
            this.Btn_nouveau.Click += new System.EventHandler(this.Btn_nouveau_Click);
            // 
            // Btn_modification
            // 
            this.Btn_modification.BackColor = System.Drawing.Color.White;
            this.Btn_modification.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_modification.Font = new System.Drawing.Font("Rubik", 10F);
            this.Btn_modification.ForeColor = System.Drawing.Color.Black;
            this.Btn_modification.Location = new System.Drawing.Point(274, 309);
            this.Btn_modification.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_modification.Name = "Btn_modification";
            this.Btn_modification.Size = new System.Drawing.Size(189, 36);
            this.Btn_modification.TabIndex = 73;
            this.Btn_modification.Text = "Modifier";
            this.Btn_modification.UseVisualStyleBackColor = false;
            this.Btn_modification.Click += new System.EventHandler(this.Btn_modification_Click);
            // 
            // Btn_supprimer
            // 
            this.Btn_supprimer.BackColor = System.Drawing.Color.White;
            this.Btn_supprimer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_supprimer.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Btn_supprimer.Font = new System.Drawing.Font("Rubik", 10F);
            this.Btn_supprimer.ForeColor = System.Drawing.Color.Black;
            this.Btn_supprimer.Location = new System.Drawing.Point(470, 261);
            this.Btn_supprimer.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_supprimer.Name = "Btn_supprimer";
            this.Btn_supprimer.Size = new System.Drawing.Size(188, 38);
            this.Btn_supprimer.TabIndex = 74;
            this.Btn_supprimer.Text = "Supprimer";
            this.Btn_supprimer.UseVisualStyleBackColor = false;
            this.Btn_supprimer.Click += new System.EventHandler(this.Btn_supprimer_Click);
            // 
            // Btn_valider
            // 
            this.Btn_valider.BackColor = System.Drawing.Color.White;
            this.Btn_valider.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_valider.Font = new System.Drawing.Font("Rubik", 10F);
            this.Btn_valider.ForeColor = System.Drawing.Color.Black;
            this.Btn_valider.Location = new System.Drawing.Point(470, 307);
            this.Btn_valider.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_valider.Name = "Btn_valider";
            this.Btn_valider.Size = new System.Drawing.Size(188, 38);
            this.Btn_valider.TabIndex = 75;
            this.Btn_valider.Text = "Valider";
            this.Btn_valider.UseVisualStyleBackColor = false;
            this.Btn_valider.Click += new System.EventHandler(this.Btn_valider_Click);
            // 
            // ButtonQuitter
            // 
            this.ButtonQuitter.BackColor = System.Drawing.Color.White;
            this.ButtonQuitter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonQuitter.Font = new System.Drawing.Font("Rubik", 10F);
            this.ButtonQuitter.ForeColor = System.Drawing.Color.Black;
            this.ButtonQuitter.Location = new System.Drawing.Point(532, 402);
            this.ButtonQuitter.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonQuitter.Name = "ButtonQuitter";
            this.ButtonQuitter.Size = new System.Drawing.Size(126, 36);
            this.ButtonQuitter.TabIndex = 76;
            this.ButtonQuitter.Text = "Quitter";
            this.ButtonQuitter.UseVisualStyleBackColor = false;
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(677, 463);
            this.Controls.Add(this.ButtonQuitter);
            this.Controls.Add(this.Btn_valider);
            this.Controls.Add(this.Btn_supprimer);
            this.Controls.Add(this.Btn_modification);
            this.Controls.Add(this.Btn_nouveau);
            this.Controls.Add(this.textBox_tel);
            this.Controls.Add(this.textBox_nom);
            this.Controls.Add(this.text_box_mail);
            this.Controls.Add(this.text_box_client_id);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.list_box_client);
            this.Font = new System.Drawing.Font("Rubik", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(699, 514);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(699, 514);
            this.Name = "Client";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Gestion Matos | Clients";
            this.Load += new System.EventHandler(this.client_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox list_box_client;
        private System.Windows.Forms.TextBox text_box_client_id;
        private System.Windows.Forms.TextBox text_box_mail;
        private System.Windows.Forms.TextBox textBox_nom;
        private System.Windows.Forms.TextBox textBox_tel;
        private System.Windows.Forms.Button Btn_nouveau;
        private System.Windows.Forms.Button Btn_modification;
        private System.Windows.Forms.Button Btn_supprimer;
        private System.Windows.Forms.Button Btn_valider;
        private System.Windows.Forms.Button ButtonQuitter;
    }
}