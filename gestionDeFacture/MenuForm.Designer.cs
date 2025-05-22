namespace gestionDeFacture
{
    partial class MenuForm
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
            this.btnClientDashboard = new System.Windows.Forms.Button();
            this.btnFactureDashboard = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClientDashboard
            // 
            this.btnClientDashboard.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnClientDashboard.Location = new System.Drawing.Point(195, 180);
            this.btnClientDashboard.Name = "btnClientDashboard";
            this.btnClientDashboard.Size = new System.Drawing.Size(143, 88);
            this.btnClientDashboard.TabIndex = 2;
            this.btnClientDashboard.Text = "Client";
            this.btnClientDashboard.UseVisualStyleBackColor = false;
            this.btnClientDashboard.Click += new System.EventHandler(this.btnClientDashboard_Click);
            // 
            // btnFactureDashboard
            // 
            this.btnFactureDashboard.BackColor = System.Drawing.Color.RosyBrown;
            this.btnFactureDashboard.Location = new System.Drawing.Point(413, 180);
            this.btnFactureDashboard.Name = "btnFactureDashboard";
            this.btnFactureDashboard.Size = new System.Drawing.Size(144, 88);
            this.btnFactureDashboard.TabIndex = 3;
            this.btnFactureDashboard.Text = "Facture";
            this.btnFactureDashboard.UseVisualStyleBackColor = false;
            this.btnFactureDashboard.Click += new System.EventHandler(this.btnFactureDashboard_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(248, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 41);
            this.label1.TabIndex = 4;
            this.label1.Text = "Bill Management";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.Location = new System.Drawing.Point(687, 402);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 39);
            this.button1.TabIndex = 5;
            this.button1.Text = "Quit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 467);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFactureDashboard);
            this.Controls.Add(this.btnClientDashboard);
            this.Name = "MenuForm";
            this.Text = "MenuForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClientDashboard;
        private System.Windows.Forms.Button btnFactureDashboard;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}