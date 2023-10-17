
namespace Gestion_Matos
{
    partial class interventions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(interventions));
            this.list_box_interventions = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Text_box_intervention_materiel_id = new System.Windows.Forms.TextBox();
            this.Text_box_intervention_date = new System.Windows.Forms.TextBox();
            this.Text_box_intervention_comment = new System.Windows.Forms.TextBox();
            this.Text_box_intervention_id = new System.Windows.Forms.TextBox();
            this.ButtonQuitter = new System.Windows.Forms.Button();
            this.Btn_valider = new System.Windows.Forms.Button();
            this.Btn_supprimer = new System.Windows.Forms.Button();
            this.Btn_modification = new System.Windows.Forms.Button();
            this.Btn_nouveau = new System.Windows.Forms.Button();
            this.list_materiel = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // list_box_interventions
            // 
            this.list_box_interventions.Font = new System.Drawing.Font("Rubik", 12F);
            this.list_box_interventions.FormattingEnabled = true;
            this.list_box_interventions.ItemHeight = 24;
            this.list_box_interventions.Location = new System.Drawing.Point(24, 26);
            this.list_box_interventions.Margin = new System.Windows.Forms.Padding(4);
            this.list_box_interventions.Name = "list_box_interventions";
            this.list_box_interventions.Size = new System.Drawing.Size(231, 532);
            this.list_box_interventions.TabIndex = 50;
            this.list_box_interventions.SelectedIndexChanged += new System.EventHandler(this.list_box_interventions_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Rubik", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(286, 43);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 24);
            this.label4.TabIndex = 58;
            this.label4.Text = "Intervention ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rubik", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(286, 146);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 24);
            this.label1.TabIndex = 59;
            this.label1.Text = "Materiel ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rubik", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(286, 206);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 24);
            this.label2.TabIndex = 60;
            this.label2.Text = "Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rubik", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(286, 263);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 24);
            this.label3.TabIndex = 61;
            this.label3.Text = "Commentaire";
            // 
            // Text_box_intervention_materiel_id
            // 
            this.Text_box_intervention_materiel_id.BackColor = System.Drawing.Color.White;
            this.Text_box_intervention_materiel_id.Font = new System.Drawing.Font("Rubik", 12F);
            this.Text_box_intervention_materiel_id.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Text_box_intervention_materiel_id.Location = new System.Drawing.Point(467, 146);
            this.Text_box_intervention_materiel_id.Margin = new System.Windows.Forms.Padding(4);
            this.Text_box_intervention_materiel_id.Name = "Text_box_intervention_materiel_id";
            this.Text_box_intervention_materiel_id.ReadOnly = true;
            this.Text_box_intervention_materiel_id.Size = new System.Drawing.Size(253, 31);
            this.Text_box_intervention_materiel_id.TabIndex = 71;
            // 
            // Text_box_intervention_date
            // 
            this.Text_box_intervention_date.BackColor = System.Drawing.Color.White;
            this.Text_box_intervention_date.Font = new System.Drawing.Font("Rubik", 12F);
            this.Text_box_intervention_date.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Text_box_intervention_date.Location = new System.Drawing.Point(467, 206);
            this.Text_box_intervention_date.Margin = new System.Windows.Forms.Padding(4);
            this.Text_box_intervention_date.Name = "Text_box_intervention_date";
            this.Text_box_intervention_date.Size = new System.Drawing.Size(253, 31);
            this.Text_box_intervention_date.TabIndex = 72;
            // 
            // Text_box_intervention_comment
            // 
            this.Text_box_intervention_comment.BackColor = System.Drawing.Color.White;
            this.Text_box_intervention_comment.Font = new System.Drawing.Font("Rubik", 12F);
            this.Text_box_intervention_comment.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Text_box_intervention_comment.Location = new System.Drawing.Point(467, 263);
            this.Text_box_intervention_comment.Margin = new System.Windows.Forms.Padding(4);
            this.Text_box_intervention_comment.Multiline = true;
            this.Text_box_intervention_comment.Name = "Text_box_intervention_comment";
            this.Text_box_intervention_comment.Size = new System.Drawing.Size(253, 110);
            this.Text_box_intervention_comment.TabIndex = 73;
            // 
            // Text_box_intervention_id
            // 
            this.Text_box_intervention_id.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(58)))));
            this.Text_box_intervention_id.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Text_box_intervention_id.Font = new System.Drawing.Font("Rubik", 12F);
            this.Text_box_intervention_id.ForeColor = System.Drawing.Color.White;
            this.Text_box_intervention_id.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Text_box_intervention_id.Location = new System.Drawing.Point(467, 43);
            this.Text_box_intervention_id.Margin = new System.Windows.Forms.Padding(4);
            this.Text_box_intervention_id.Name = "Text_box_intervention_id";
            this.Text_box_intervention_id.ReadOnly = true;
            this.Text_box_intervention_id.Size = new System.Drawing.Size(253, 24);
            this.Text_box_intervention_id.TabIndex = 74;
            // 
            // ButtonQuitter
            // 
            this.ButtonQuitter.BackColor = System.Drawing.Color.White;
            this.ButtonQuitter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonQuitter.Font = new System.Drawing.Font("Rubik", 10F);
            this.ButtonQuitter.ForeColor = System.Drawing.Color.Black;
            this.ButtonQuitter.Location = new System.Drawing.Point(594, 516);
            this.ButtonQuitter.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonQuitter.Name = "ButtonQuitter";
            this.ButtonQuitter.Size = new System.Drawing.Size(126, 36);
            this.ButtonQuitter.TabIndex = 81;
            this.ButtonQuitter.Text = "Quitter";
            this.ButtonQuitter.UseVisualStyleBackColor = false;
            this.ButtonQuitter.Click += new System.EventHandler(this.ButtonQuitter_Click);
            // 
            // Btn_valider
            // 
            this.Btn_valider.BackColor = System.Drawing.Color.White;
            this.Btn_valider.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_valider.Font = new System.Drawing.Font("Rubik", 10F);
            this.Btn_valider.ForeColor = System.Drawing.Color.Black;
            this.Btn_valider.Location = new System.Drawing.Point(516, 437);
            this.Btn_valider.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_valider.Name = "Btn_valider";
            this.Btn_valider.Size = new System.Drawing.Size(204, 38);
            this.Btn_valider.TabIndex = 80;
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
            this.Btn_supprimer.Location = new System.Drawing.Point(516, 391);
            this.Btn_supprimer.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_supprimer.Name = "Btn_supprimer";
            this.Btn_supprimer.Size = new System.Drawing.Size(204, 38);
            this.Btn_supprimer.TabIndex = 79;
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
            this.Btn_modification.Location = new System.Drawing.Point(290, 439);
            this.Btn_modification.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_modification.Name = "Btn_modification";
            this.Btn_modification.Size = new System.Drawing.Size(204, 36);
            this.Btn_modification.TabIndex = 78;
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
            this.Btn_nouveau.Location = new System.Drawing.Point(290, 391);
            this.Btn_nouveau.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_nouveau.Name = "Btn_nouveau";
            this.Btn_nouveau.Size = new System.Drawing.Size(204, 38);
            this.Btn_nouveau.TabIndex = 77;
            this.Btn_nouveau.Text = "Nouveau";
            this.Btn_nouveau.UseVisualStyleBackColor = false;
            this.Btn_nouveau.Click += new System.EventHandler(this.Btn_nouveau_Click);
            // 
            // list_materiel
            // 
            this.list_materiel.Font = new System.Drawing.Font("Rubik", 12F);
            this.list_materiel.FormattingEnabled = true;
            this.list_materiel.Location = new System.Drawing.Point(467, 89);
            this.list_materiel.Name = "list_materiel";
            this.list_materiel.Size = new System.Drawing.Size(253, 32);
            this.list_materiel.TabIndex = 82;
            this.list_materiel.SelectedValueChanged += new System.EventHandler(this.list_materiel_SelectedValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Rubik", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(286, 92);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 24);
            this.label5.TabIndex = 83;
            this.label5.Text = "Nom Matériel";
            // 
            // interventions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(752, 582);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.list_materiel);
            this.Controls.Add(this.ButtonQuitter);
            this.Controls.Add(this.Btn_valider);
            this.Controls.Add(this.Btn_supprimer);
            this.Controls.Add(this.Btn_modification);
            this.Controls.Add(this.Btn_nouveau);
            this.Controls.Add(this.Text_box_intervention_id);
            this.Controls.Add(this.Text_box_intervention_comment);
            this.Controls.Add(this.Text_box_intervention_date);
            this.Controls.Add(this.Text_box_intervention_materiel_id);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.list_box_interventions);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "interventions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Interventions";
            this.Load += new System.EventHandler(this.interventions_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox list_box_interventions;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Text_box_intervention_materiel_id;
        private System.Windows.Forms.TextBox Text_box_intervention_date;
        private System.Windows.Forms.TextBox Text_box_intervention_comment;
        private System.Windows.Forms.TextBox Text_box_intervention_id;
        private System.Windows.Forms.Button ButtonQuitter;
        private System.Windows.Forms.Button Btn_valider;
        private System.Windows.Forms.Button Btn_supprimer;
        private System.Windows.Forms.Button Btn_modification;
        private System.Windows.Forms.Button Btn_nouveau;
        private System.Windows.Forms.ComboBox list_materiel;
        private System.Windows.Forms.Label label5;
    }
}