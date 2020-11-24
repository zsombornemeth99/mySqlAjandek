
namespace mySqlAjandek
{
    partial class FormAjandek
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAjandek));
            this.txtBx_nev = new System.Windows.Forms.TextBox();
            this.txtBx_uzlet = new System.Windows.Forms.TextBox();
            this.lstBx_ajandek = new System.Windows.Forms.ListBox();
            this.bttn_felvesz = new System.Windows.Forms.Button();
            this.grpBx_adatok = new System.Windows.Forms.GroupBox();
            this.lbl_uzlet = new System.Windows.Forms.Label();
            this.lbl_nev = new System.Windows.Forms.Label();
            this.lbl_id = new System.Windows.Forms.Label();
            this.bttn_torles = new System.Windows.Forms.Button();
            this.grpBx_adatok.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBx_nev
            // 
            resources.ApplyResources(this.txtBx_nev, "txtBx_nev");
            this.txtBx_nev.Name = "txtBx_nev";
            // 
            // txtBx_uzlet
            // 
            resources.ApplyResources(this.txtBx_uzlet, "txtBx_uzlet");
            this.txtBx_uzlet.Name = "txtBx_uzlet";
            // 
            // lstBx_ajandek
            // 
            this.lstBx_ajandek.FormattingEnabled = true;
            resources.ApplyResources(this.lstBx_ajandek, "lstBx_ajandek");
            this.lstBx_ajandek.Name = "lstBx_ajandek";
            this.lstBx_ajandek.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lstBx_ajandek_MouseClick);
            this.lstBx_ajandek.SelectedIndexChanged += new System.EventHandler(this.lstBx_ajandek_SelectedIndexChanged);
            this.lstBx_ajandek.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstBx_ajandek_MouseDoubleClick);
            // 
            // bttn_felvesz
            // 
            resources.ApplyResources(this.bttn_felvesz, "bttn_felvesz");
            this.bttn_felvesz.Name = "bttn_felvesz";
            this.bttn_felvesz.UseVisualStyleBackColor = true;
            this.bttn_felvesz.Click += new System.EventHandler(this.bttn_felvesz_Click);
            // 
            // grpBx_adatok
            // 
            this.grpBx_adatok.Controls.Add(this.lbl_uzlet);
            this.grpBx_adatok.Controls.Add(this.lbl_nev);
            this.grpBx_adatok.Controls.Add(this.lbl_id);
            resources.ApplyResources(this.grpBx_adatok, "grpBx_adatok");
            this.grpBx_adatok.Name = "grpBx_adatok";
            this.grpBx_adatok.TabStop = false;
            // 
            // lbl_uzlet
            // 
            resources.ApplyResources(this.lbl_uzlet, "lbl_uzlet");
            this.lbl_uzlet.Name = "lbl_uzlet";
            // 
            // lbl_nev
            // 
            resources.ApplyResources(this.lbl_nev, "lbl_nev");
            this.lbl_nev.Name = "lbl_nev";
            // 
            // lbl_id
            // 
            resources.ApplyResources(this.lbl_id, "lbl_id");
            this.lbl_id.Name = "lbl_id";
            // 
            // bttn_torles
            // 
            resources.ApplyResources(this.bttn_torles, "bttn_torles");
            this.bttn_torles.Name = "bttn_torles";
            this.bttn_torles.UseVisualStyleBackColor = true;
            this.bttn_torles.Click += new System.EventHandler(this.bttn_torles_Click);
            // 
            // FormAjandek
            // 
            this.AllowDrop = true;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bttn_torles);
            this.Controls.Add(this.grpBx_adatok);
            this.Controls.Add(this.bttn_felvesz);
            this.Controls.Add(this.lstBx_ajandek);
            this.Controls.Add(this.txtBx_uzlet);
            this.Controls.Add(this.txtBx_nev);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAjandek";
            this.grpBx_adatok.ResumeLayout(false);
            this.grpBx_adatok.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBx_nev;
        private System.Windows.Forms.TextBox txtBx_uzlet;
        private System.Windows.Forms.ListBox lstBx_ajandek;
        private System.Windows.Forms.Button bttn_felvesz;
        private System.Windows.Forms.GroupBox grpBx_adatok;
        private System.Windows.Forms.Label lbl_uzlet;
        private System.Windows.Forms.Label lbl_nev;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Button bttn_torles;
    }
}

