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
            this.SuspendLayout();
            // 
            // btnClientDashboard
            // 
            this.btnClientDashboard.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnClientDashboard.Location = new System.Drawing.Point(175, 276);
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
            this.btnFactureDashboard.Location = new System.Drawing.Point(394, 276);
            this.btnFactureDashboard.Name = "btnFactureDashboard";
            this.btnFactureDashboard.Size = new System.Drawing.Size(144, 88);
            this.btnFactureDashboard.TabIndex = 3;
            this.btnFactureDashboard.Text = "Facture";
            this.btnFactureDashboard.UseVisualStyleBackColor = false;
            this.btnFactureDashboard.Click += new System.EventHandler(this.btnFactureDashboard_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 467);
            this.Controls.Add(this.btnFactureDashboard);
            this.Controls.Add(this.btnClientDashboard);
            this.Name = "MenuForm";
            this.Text = "MenuForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClientDashboard;
        private System.Windows.Forms.Button btnFactureDashboard;
    }
}