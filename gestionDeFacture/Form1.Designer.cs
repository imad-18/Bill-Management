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
            this.panel1 = new System.Windows.Forms.Panel();
            this.facture_label = new System.Windows.Forms.Label();
            this.rs_client_label = new System.Windows.Forms.Label();
            this.if_client_label = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.IF_Client_textBox = new System.Windows.Forms.TextBox();
            this.ice_client_label = new System.Windows.Forms.Label();
            this.client_id_label = new System.Windows.Forms.Label();
            this.ICE_client_textBox = new System.Windows.Forms.TextBox();
            this.client_ID_textBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.metroPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 332);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Désignation:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 367);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Référence:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(98, 405);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Quantité:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(98, 442);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Prix:";
            // 
            // designationTextBox
            // 
            this.designationTextBox.Location = new System.Drawing.Point(246, 325);
            this.designationTextBox.Name = "designationTextBox";
            this.designationTextBox.Size = new System.Drawing.Size(187, 26);
            this.designationTextBox.TabIndex = 4;
            // 
            // referenceTextBox
            // 
            this.referenceTextBox.Location = new System.Drawing.Point(246, 361);
            this.referenceTextBox.Name = "referenceTextBox";
            this.referenceTextBox.Size = new System.Drawing.Size(187, 26);
            this.referenceTextBox.TabIndex = 5;
            // 
            // quantiteTextBox
            // 
            this.quantiteTextBox.Location = new System.Drawing.Point(246, 399);
            this.quantiteTextBox.Name = "quantiteTextBox";
            this.quantiteTextBox.Size = new System.Drawing.Size(157, 26);
            this.quantiteTextBox.TabIndex = 6;
            // 
            // prixTextBox
            // 
            this.prixTextBox.Location = new System.Drawing.Point(246, 435);
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
            this.metroPanel1.Location = new System.Drawing.Point(623, 325);
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
            this.listView1.Location = new System.Drawing.Point(102, 482);
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
            this.label6.Location = new System.Drawing.Point(124, 718);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(168, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Montant Total (DH):";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(410, 719);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(198, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "TVA (7% ou 20%) (DH):";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(688, 718);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(161, 20);
            this.label8.TabIndex = 12;
            this.label8.Text = "Total à payer (DH):";
            // 
            // TotalHT_textBox
            // 
            this.TotalHT_textBox.Location = new System.Drawing.Point(148, 754);
            this.TotalHT_textBox.Name = "TotalHT_textBox";
            this.TotalHT_textBox.Size = new System.Drawing.Size(161, 26);
            this.TotalHT_textBox.TabIndex = 13;
            // 
            // TTVA_textBox
            // 
            this.TTVA_textBox.Location = new System.Drawing.Point(436, 755);
            this.TTVA_textBox.Name = "TTVA_textBox";
            this.TTVA_textBox.Size = new System.Drawing.Size(188, 26);
            this.TTVA_textBox.TabIndex = 14;
            // 
            // totalAPayer_textBox
            // 
            this.totalAPayer_textBox.Location = new System.Drawing.Point(710, 754);
            this.totalAPayer_textBox.Name = "totalAPayer_textBox";
            this.totalAPayer_textBox.Size = new System.Drawing.Size(179, 26);
            this.totalAPayer_textBox.TabIndex = 15;
            // 
            // ajouter_button
            // 
            this.ajouter_button.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ajouter_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ajouter_button.Location = new System.Drawing.Point(119, 834);
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
            this.modifier_button.Location = new System.Drawing.Point(521, 834);
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
            this.quiter_button.Location = new System.Drawing.Point(727, 834);
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
            this.supprimer_button.Location = new System.Drawing.Point(331, 834);
            this.supprimer_button.Name = "supprimer_button";
            this.supprimer_button.Size = new System.Drawing.Size(148, 52);
            this.supprimer_button.TabIndex = 23;
            this.supprimer_button.Text = "Supprimer";
            this.supprimer_button.UseVisualStyleBackColor = false;
            this.supprimer_button.Click += new System.EventHandler(this.supprimer_button_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.textBox5);
            this.panel1.Controls.Add(this.textBox4);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.client_ID_textBox);
            this.panel1.Controls.Add(this.ICE_client_textBox);
            this.panel1.Controls.Add(this.client_id_label);
            this.panel1.Controls.Add(this.ice_client_label);
            this.panel1.Controls.Add(this.IF_Client_textBox);
            this.panel1.Controls.Add(this.metroComboBox1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.if_client_label);
            this.panel1.Controls.Add(this.rs_client_label);
            this.panel1.Controls.Add(this.facture_label);
            this.panel1.Location = new System.Drawing.Point(44, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(916, 243);
            this.panel1.TabIndex = 24;
            // 
            // facture_label
            // 
            this.facture_label.AutoSize = true;
            this.facture_label.Location = new System.Drawing.Point(49, 49);
            this.facture_label.Name = "facture_label";
            this.facture_label.Size = new System.Drawing.Size(92, 20);
            this.facture_label.TabIndex = 0;
            this.facture_label.Text = "Facture N° :";
            // 
            // rs_client_label
            // 
            this.rs_client_label.AutoSize = true;
            this.rs_client_label.Location = new System.Drawing.Point(53, 111);
            this.rs_client_label.Name = "rs_client_label";
            this.rs_client_label.Size = new System.Drawing.Size(84, 20);
            this.rs_client_label.TabIndex = 1;
            this.rs_client_label.Text = "RS Client :";
            // 
            // if_client_label
            // 
            this.if_client_label.AutoSize = true;
            this.if_client_label.Location = new System.Drawing.Point(17, 203);
            this.if_client_label.Name = "if_client_label";
            this.if_client_label.Size = new System.Drawing.Size(76, 20);
            this.if_client_label.TabIndex = 2;
            this.if_client_label.Text = "IF Client :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(163, 46);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(195, 26);
            this.textBox1.TabIndex = 3;
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 23;
            this.metroComboBox1.Location = new System.Drawing.Point(163, 111);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(195, 29);
            this.metroComboBox1.TabIndex = 4;
            // 
            // IF_Client_textBox
            // 
            this.IF_Client_textBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.IF_Client_textBox.Location = new System.Drawing.Point(101, 200);
            this.IF_Client_textBox.Name = "IF_Client_textBox";
            this.IF_Client_textBox.Size = new System.Drawing.Size(173, 26);
            this.IF_Client_textBox.TabIndex = 5;
            // 
            // ice_client_label
            // 
            this.ice_client_label.AutoSize = true;
            this.ice_client_label.Location = new System.Drawing.Point(324, 203);
            this.ice_client_label.Name = "ice_client_label";
            this.ice_client_label.Size = new System.Drawing.Size(88, 20);
            this.ice_client_label.TabIndex = 6;
            this.ice_client_label.Text = "ICE Client :";
            // 
            // client_id_label
            // 
            this.client_id_label.AutoSize = true;
            this.client_id_label.Location = new System.Drawing.Point(637, 203);
            this.client_id_label.Name = "client_id_label";
            this.client_id_label.Size = new System.Drawing.Size(78, 20);
            this.client_id_label.TabIndex = 7;
            this.client_id_label.Text = "Client ID :";
            this.client_id_label.Click += new System.EventHandler(this.label10_Click);
            // 
            // ICE_client_textBox
            // 
            this.ICE_client_textBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ICE_client_textBox.Location = new System.Drawing.Point(418, 200);
            this.ICE_client_textBox.Name = "ICE_client_textBox";
            this.ICE_client_textBox.Size = new System.Drawing.Size(173, 26);
            this.ICE_client_textBox.TabIndex = 8;
            // 
            // client_ID_textBox
            // 
            this.client_ID_textBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.client_ID_textBox.Location = new System.Drawing.Point(729, 197);
            this.client_ID_textBox.Name = "client_ID_textBox";
            this.client_ID_textBox.Size = new System.Drawing.Size(173, 26);
            this.client_ID_textBox.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(631, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 20);
            this.label9.TabIndex = 10;
            this.label9.Text = "Désignation:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(634, 67);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 20);
            this.label10.TabIndex = 11;
            this.label10.Text = "Qantité :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(634, 112);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 20);
            this.label11.TabIndex = 12;
            this.label11.Text = "Prix :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(634, 158);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(92, 20);
            this.label12.TabIndex = 13;
            this.label12.Text = "Référence :";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(729, 18);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(173, 26);
            this.textBox2.TabIndex = 14;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(729, 61);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(173, 26);
            this.textBox3.TabIndex = 15;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(729, 111);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(173, 26);
            this.textBox4.TabIndex = 16;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(729, 152);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(173, 26);
            this.textBox5.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 903);
            this.Controls.Add(this.panel1);
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
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label if_client_label;
        private System.Windows.Forms.Label rs_client_label;
        private System.Windows.Forms.Label facture_label;
        private System.Windows.Forms.TextBox textBox1;
        private MetroFramework.Controls.MetroComboBox metroComboBox1;
        private System.Windows.Forms.TextBox client_ID_textBox;
        private System.Windows.Forms.TextBox ICE_client_textBox;
        private System.Windows.Forms.Label client_id_label;
        private System.Windows.Forms.Label ice_client_label;
        private System.Windows.Forms.TextBox IF_Client_textBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
    }
}

