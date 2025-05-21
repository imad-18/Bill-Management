namespace gestionDeFacture
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.designationTextBox = new System.Windows.Forms.TextBox();
            this.referenceTextBox = new System.Windows.Forms.TextBox();
            this.quantiteTextBox = new System.Windows.Forms.TextBox();
            this.prixTextBox = new System.Windows.Forms.TextBox();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.designation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.prix = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.quantite = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.montant_ht = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.montant_tva = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.total_ttc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.reference = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TotalHT_textBox = new System.Windows.Forms.TextBox();
            this.TTVA_textBox = new System.Windows.Forms.TextBox();
            this.totalAPayer_textBox = new System.Windows.Forms.TextBox();
            this.ajouter_button = new System.Windows.Forms.Button();
            this.modifier_button = new System.Windows.Forms.Button();
            this.quiter_button = new System.Windows.Forms.Button();
            this.supprimer_button = new System.Windows.Forms.Button();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Désignation:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(114, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Référence:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(114, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Quantité:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(114, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Prix:";
            // 
            // designationTextBox
            // 
            this.designationTextBox.Location = new System.Drawing.Point(262, 78);
            this.designationTextBox.Name = "designationTextBox";
            this.designationTextBox.Size = new System.Drawing.Size(187, 26);
            this.designationTextBox.TabIndex = 4;
            // 
            // referenceTextBox
            // 
            this.referenceTextBox.Location = new System.Drawing.Point(262, 114);
            this.referenceTextBox.Name = "referenceTextBox";
            this.referenceTextBox.Size = new System.Drawing.Size(187, 26);
            this.referenceTextBox.TabIndex = 5;
            // 
            // quantiteTextBox
            // 
            this.quantiteTextBox.Location = new System.Drawing.Point(262, 152);
            this.quantiteTextBox.Name = "quantiteTextBox";
            this.quantiteTextBox.Size = new System.Drawing.Size(157, 26);
            this.quantiteTextBox.TabIndex = 6;
            // 
            // prixTextBox
            // 
            this.prixTextBox.Location = new System.Drawing.Point(262, 188);
            this.prixTextBox.Name = "prixTextBox";
            this.prixTextBox.Size = new System.Drawing.Size(157, 26);
            this.prixTextBox.TabIndex = 7;
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.metroPanel1.Controls.Add(this.radioButton2);
            this.metroPanel1.Controls.Add(this.radioButton1);
            this.metroPanel1.Controls.Add(this.label5);
            this.metroPanel1.CustomBackground = true;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 9;
            this.metroPanel1.Location = new System.Drawing.Point(639, 78);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(297, 62);
            this.metroPanel1.TabIndex = 8;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(118, 35);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(66, 24);
            this.radioButton2.TabIndex = 4;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "20%";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(118, 2);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(57, 24);
            this.radioButton1.TabIndex = 3;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "7%";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.TextChanged += new System.EventHandler(this.radioButton1_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "TVA: ";
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.designation,
            this.prix,
            this.quantite,
            this.montant_ht,
            this.montant_tva,
            this.total_ttc,
            this.reference});
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(118, 235);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(818, 213);
            this.listView1.TabIndex = 9;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // designation
            // 
            this.designation.Text = "Désignation";
            this.designation.Width = 122;
            // 
            // prix
            // 
            this.prix.Text = "Prix";
            this.prix.Width = 78;
            // 
            // quantite
            // 
            this.quantite.Text = "Quantité";
            this.quantite.Width = 93;
            // 
            // montant_ht
            // 
            this.montant_ht.Text = "Montant HT";
            this.montant_ht.Width = 98;
            // 
            // montant_tva
            // 
            this.montant_tva.Text = "Montant TVA";
            this.montant_tva.Width = 113;
            // 
            // total_ttc
            // 
            this.total_ttc.Text = "Total (TTC)";
            this.total_ttc.Width = 99;
            // 
            // reference
            // 
            this.reference.Text = "Référence";
            this.reference.Width = 102;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(140, 471);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(168, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Montant Total (DH):";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(426, 472);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(198, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "TVA (7% ou 20%) (DH):";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(704, 471);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(161, 20);
            this.label8.TabIndex = 12;
            this.label8.Text = "Total à payer (DH):";
            // 
            // TotalHT_textBox
            // 
            this.TotalHT_textBox.Location = new System.Drawing.Point(164, 507);
            this.TotalHT_textBox.Name = "TotalHT_textBox";
            this.TotalHT_textBox.Size = new System.Drawing.Size(161, 26);
            this.TotalHT_textBox.TabIndex = 13;
            // 
            // TTVA_textBox
            // 
            this.TTVA_textBox.Location = new System.Drawing.Point(452, 508);
            this.TTVA_textBox.Name = "TTVA_textBox";
            this.TTVA_textBox.Size = new System.Drawing.Size(188, 26);
            this.TTVA_textBox.TabIndex = 14;
            // 
            // totalAPayer_textBox
            // 
            this.totalAPayer_textBox.Location = new System.Drawing.Point(726, 507);
            this.totalAPayer_textBox.Name = "totalAPayer_textBox";
            this.totalAPayer_textBox.Size = new System.Drawing.Size(179, 26);
            this.totalAPayer_textBox.TabIndex = 15;
            // 
            // ajouter_button
            // 
            this.ajouter_button.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ajouter_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ajouter_button.Location = new System.Drawing.Point(135, 587);
            this.ajouter_button.Name = "ajouter_button";
            this.ajouter_button.Size = new System.Drawing.Size(173, 52);
            this.ajouter_button.TabIndex = 19;
            this.ajouter_button.Text = "Ajouter";
            this.ajouter_button.UseVisualStyleBackColor = false;
            this.ajouter_button.Click += new System.EventHandler(this.AjouterButton_Click);
            // 
            // modifier_button
            // 
            this.modifier_button.BackColor = System.Drawing.Color.LightSteelBlue;
            this.modifier_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifier_button.Location = new System.Drawing.Point(537, 587);
            this.modifier_button.Name = "modifier_button";
            this.modifier_button.Size = new System.Drawing.Size(166, 52);
            this.modifier_button.TabIndex = 20;
            this.modifier_button.Text = "Modifier";
            this.modifier_button.UseVisualStyleBackColor = false;
            this.modifier_button.Click += new System.EventHandler(this.modifier_button_Click);
            // 
            // quiter_button
            // 
            this.quiter_button.BackColor = System.Drawing.Color.LightSteelBlue;
            this.quiter_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quiter_button.Location = new System.Drawing.Point(743, 587);
            this.quiter_button.Name = "quiter_button";
            this.quiter_button.Size = new System.Drawing.Size(162, 52);
            this.quiter_button.TabIndex = 21;
            this.quiter_button.Text = "Quitter";
            this.quiter_button.UseVisualStyleBackColor = false;
            this.quiter_button.Click += new System.EventHandler(this.quiter_button_Click);
            // 
            // supprimer_button
            // 
            this.supprimer_button.BackColor = System.Drawing.Color.LightSteelBlue;
            this.supprimer_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supprimer_button.Location = new System.Drawing.Point(347, 587);
            this.supprimer_button.Name = "supprimer_button";
            this.supprimer_button.Size = new System.Drawing.Size(148, 52);
            this.supprimer_button.TabIndex = 23;
            this.supprimer_button.Text = "Supprimer";
            this.supprimer_button.UseVisualStyleBackColor = false;
            this.supprimer_button.Click += new System.EventHandler(this.supprimer_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 687);
            this.Controls.Add(this.supprimer_button);
            this.Controls.Add(this.quiter_button);
            this.Controls.Add(this.modifier_button);
            this.Controls.Add(this.ajouter_button);
            this.Controls.Add(this.totalAPayer_textBox);
            this.Controls.Add(this.TTVA_textBox);
            this.Controls.Add(this.TotalHT_textBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.prixTextBox);
            this.Controls.Add(this.quantiteTextBox);
            this.Controls.Add(this.referenceTextBox);
            this.Controls.Add(this.designationTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(20, 92, 20, 20);
            this.Text = "Facture";
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox designationTextBox;
        private System.Windows.Forms.TextBox referenceTextBox;
        private System.Windows.Forms.TextBox quantiteTextBox;
        private System.Windows.Forms.TextBox prixTextBox;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TotalHT_textBox;
        private System.Windows.Forms.TextBox TTVA_textBox;
        private System.Windows.Forms.TextBox totalAPayer_textBox;
        private System.Windows.Forms.Button ajouter_button;
        private System.Windows.Forms.Button modifier_button;
        private System.Windows.Forms.Button quiter_button;
        private System.Windows.Forms.ColumnHeader designation;
        private System.Windows.Forms.ColumnHeader prix;
        private System.Windows.Forms.ColumnHeader quantite;
        private System.Windows.Forms.ColumnHeader montant_ht;
        private System.Windows.Forms.ColumnHeader montant_tva;
        private System.Windows.Forms.ColumnHeader total_ttc;
        private System.Windows.Forms.ColumnHeader reference;
        private System.Windows.Forms.Button supprimer_button;
    }
}

