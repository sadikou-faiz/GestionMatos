
namespace Gestion_Matos
{
    partial class Type
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Type));
            this.ButtonQuitter = new System.Windows.Forms.Button();
            this.Btn_valider = new System.Windows.Forms.Button();
            this.Btn_supprimer = new System.Windows.Forms.Button();
            this.Btn_modification = new System.Windows.Forms.Button();
            this.Btn_nouveau = new System.Windows.Forms.Button();
            this.textBox_nom = new System.Windows.Forms.TextBox();
            this.text_box_description = new System.Windows.Forms.TextBox();
            this.text_box_type_id = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.list_box_types = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // ButtonQuitter
            // 
            this.ButtonQuitter.BackColor = System.Drawing.Color.White;
            this.ButtonQuitter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonQuitter.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButtonQuitter.Font = new System.Drawing.Font("Rubik", 10F);
            this.ButtonQuitter.ForeColor = System.Drawing.Color.Black;
            this.ButtonQuitter.Location = new System.Drawing.Point(564, 388);
            this.ButtonQuitter.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonQuitter.Name = "ButtonQuitter";
            this.ButtonQuitter.Size = new System.Drawing.Size(126, 47);
            this.ButtonQuitter.TabIndex = 102;
            this.ButtonQuitter.Text = "Quitter";
            this.ButtonQuitter.UseVisualStyleBackColor = false;
            // 
            // Btn_valider
            // 
            this.Btn_valider.BackColor = System.Drawing.Color.White;
            this.Btn_valider.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_valider.Font = new System.Drawing.Font("Rubik", 10F);
            this.Btn_valider.ForeColor = System.Drawing.Color.Black;
            this.Btn_valider.Location = new System.Drawing.Point(502, 275);
            this.Btn_valider.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_valider.Name = "Btn_valider";
            this.Btn_valider.Size = new System.Drawing.Size(188, 43);
            this.Btn_valider.TabIndex = 101;
            this.Btn_valider.Text = "Valider";
            this.Btn_valider.UseVisualStyleBackColor = false;
            this.Btn_valider.Click += new System.EventHandler(this.Btn_valider_Click);
            // 
            // Btn_supprimer
            // 
            this.Btn_supprimer.BackColor = System.Drawing.Color.White;
            this.Btn_supprimer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_supprimer.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Btn_supprimer.Font = new System.Drawing.Font("Rubik", 10F);
            this.Btn_supprimer.ForeColor = System.Drawing.Color.Black;
            this.Btn_supprimer.Location = new System.Drawing.Point(502, 332);
            this.Btn_supprimer.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_supprimer.Name = "Btn_supprimer";
            this.Btn_supprimer.Size = new System.Drawing.Size(188, 43);
            this.Btn_supprimer.TabIndex = 100;
            this.Btn_supprimer.Text = "Supprimer";
            this.Btn_supprimer.UseVisualStyleBackColor = false;
            this.Btn_supprimer.Click += new System.EventHandler(this.Btn_supprimer_Click);
            // 
            // Btn_modification
            // 
            this.Btn_modification.BackColor = System.Drawing.Color.White;
            this.Btn_modification.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_modification.Font = new System.Drawing.Font("Rubik", 10F);
            this.Btn_modification.ForeColor = System.Drawing.Color.Black;
            this.Btn_modification.Location = new System.Drawing.Point(293, 334);
            this.Btn_modification.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_modification.Name = "Btn_modification";
            this.Btn_modification.Size = new System.Drawing.Size(189, 41);
            this.Btn_modification.TabIndex = 99;
            this.Btn_modification.Text = "Modifier";
            this.Btn_modification.UseVisualStyleBackColor = false;
            this.Btn_modification.Click += new System.EventHandler(this.Btn_modification_Click);
            // 
            // Btn_nouveau
            // 
            this.Btn_nouveau.BackColor = System.Drawing.Color.White;
            this.Btn_nouveau.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_nouveau.Font = new System.Drawing.Font("Rubik", 10F);
            this.Btn_nouveau.ForeColor = System.Drawing.Color.Black;
            this.Btn_nouveau.Location = new System.Drawing.Point(292, 275);
            this.Btn_nouveau.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_nouveau.Name = "Btn_nouveau";
            this.Btn_nouveau.Size = new System.Drawing.Size(189, 43);
            this.Btn_nouveau.TabIndex = 98;
            this.Btn_nouveau.Text = "Nouveau";
            this.Btn_nouveau.UseVisualStyleBackColor = false;
            this.Btn_nouveau.Click += new System.EventHandler(this.Btn_nouveau_Click);
            // 
            // textBox_nom
            // 
            this.textBox_nom.BackColor = System.Drawing.Color.White;
            this.textBox_nom.Font = new System.Drawing.Font("Rubik", 12F);
            this.textBox_nom.ImeMode = System.Windows.Forms.ImeMode.On;
            this.textBox_nom.Location = new System.Drawing.Point(414, 119);
            this.textBox_nom.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_nom.Name = "textBox_nom";
            this.textBox_nom.Size = new System.Drawing.Size(276, 31);
            this.textBox_nom.TabIndex = 97;
            // 
            // text_box_description
            // 
            this.text_box_description.BackColor = System.Drawing.Color.White;
            this.text_box_description.Font = new System.Drawing.Font("Rubik", 12F);
            this.text_box_description.ImeMode = System.Windows.Forms.ImeMode.On;
            this.text_box_description.Location = new System.Drawing.Point(414, 174);
            this.text_box_description.Margin = new System.Windows.Forms.Padding(4);
            this.text_box_description.Multiline = true;
            this.text_box_description.Name = "text_box_description";
            this.text_box_description.Size = new System.Drawing.Size(276, 76);
            this.text_box_description.TabIndex = 96;
            // 
            // text_box_type_id
            // 
            this.text_box_type_id.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(58)))));
            this.text_box_type_id.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_box_type_id.Font = new System.Drawing.Font("Rubik", 12F);
            this.text_box_type_id.ForeColor = System.Drawing.Color.White;
            this.text_box_type_id.ImeMode = System.Windows.Forms.ImeMode.On;
            this.text_box_type_id.Location = new System.Drawing.Point(401, 73);
            this.text_box_type_id.Margin = new System.Windows.Forms.Padding(4);
            this.text_box_type_id.Name = "text_box_type_id";
            this.text_box_type_id.ReadOnly = true;
            this.text_box_type_id.Size = new System.Drawing.Size(253, 24);
            this.text_box_type_id.TabIndex = 95;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Rubik", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(289, 73);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 24);
            this.label4.TabIndex = 94;
            this.label4.Text = "Type ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rubik", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(288, 174);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 24);
            this.label1.TabIndex = 93;
            this.label1.Text = "Description";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rubik", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(288, 126);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 24);
            this.label2.TabIndex = 92;
            this.label2.Text = "Nom";
            // 
            // list_box_types
            // 
            this.list_box_types.Font = new System.Drawing.Font("Rubik", 12F);
            this.list_box_types.FormattingEnabled = true;
            this.list_box_types.ItemHeight = 24;
            this.list_box_types.Location = new System.Drawing.Point(27, 23);
            this.list_box_types.Margin = new System.Windows.Forms.Padding(4);
            this.list_box_types.Name = "list_box_types";
            this.list_box_types.Size = new System.Drawing.Size(224, 412);
            this.list_box_types.TabIndex = 91;
            this.list_box_types.SelectedIndexChanged += new System.EventHandler(this.list_box_types_SelectedIndexChanged);
            // 
            // Type
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(718, 465);
            this.Controls.Add(this.ButtonQuitter);
            this.Controls.Add(this.Btn_valider);
            this.Controls.Add(this.Btn_supprimer);
            this.Controls.Add(this.Btn_modification);
            this.Controls.Add(this.Btn_nouveau);
            this.Controls.Add(this.textBox_nom);
            this.Controls.Add(this.text_box_description);
            this.Controls.Add(this.text_box_type_id);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.list_box_types);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Type";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Gestion Matos | Types";
            this.Load += new System.EventHandler(this.Type_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonQuitter;
        private System.Windows.Forms.Button Btn_valider;
        private System.Windows.Forms.Button Btn_supprimer;
        private System.Windows.Forms.Button Btn_modification;
        private System.Windows.Forms.Button Btn_nouveau;
        private System.Windows.Forms.TextBox textBox_nom;
        private System.Windows.Forms.TextBox text_box_description;
        private System.Windows.Forms.TextBox text_box_type_id;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox list_box_types;
    }
}