namespace Ver
{
    partial class Form1
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
            this.txt_yol = new System.Windows.Forms.Label();
            this.lbl_vkod = new System.Windows.Forms.Label();
            this.lbl_vadi_acik = new System.Windows.Forms.Label();
            this.lbl_dadi_acik = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_yol
            // 
            this.txt_yol.AutoSize = true;
            this.txt_yol.Location = new System.Drawing.Point(87, 48);
            this.txt_yol.Name = "txt_yol";
            this.txt_yol.Size = new System.Drawing.Size(35, 13);
            this.txt_yol.TabIndex = 0;
            this.txt_yol.Text = "label1";
            this.txt_yol.Visible = false;
            // 
            // lbl_vkod
            // 
            this.lbl_vkod.AutoSize = true;
            this.lbl_vkod.Location = new System.Drawing.Point(105, 131);
            this.lbl_vkod.Name = "lbl_vkod";
            this.lbl_vkod.Size = new System.Drawing.Size(35, 13);
            this.lbl_vkod.TabIndex = 1;
            this.lbl_vkod.Text = "label1";
            this.lbl_vkod.Visible = false;
            // 
            // lbl_vadi_acik
            // 
            this.lbl_vadi_acik.AutoSize = true;
            this.lbl_vadi_acik.Location = new System.Drawing.Point(105, 183);
            this.lbl_vadi_acik.Name = "lbl_vadi_acik";
            this.lbl_vadi_acik.Size = new System.Drawing.Size(35, 13);
            this.lbl_vadi_acik.TabIndex = 2;
            this.lbl_vadi_acik.Text = "label1";
            this.lbl_vadi_acik.Visible = false;
            // 
            // lbl_dadi_acik
            // 
            this.lbl_dadi_acik.AutoSize = true;
            this.lbl_dadi_acik.Location = new System.Drawing.Point(120, 83);
            this.lbl_dadi_acik.Name = "lbl_dadi_acik";
            this.lbl_dadi_acik.Size = new System.Drawing.Size(35, 13);
            this.lbl_dadi_acik.TabIndex = 3;
            this.lbl_dadi_acik.Text = "label1";
            this.lbl_dadi_acik.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(120, 0);
            this.Controls.Add(this.lbl_dadi_acik);
            this.Controls.Add(this.lbl_vadi_acik);
            this.Controls.Add(this.lbl_vkod);
            this.Controls.Add(this.txt_yol);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txt_yol;
        private System.Windows.Forms.Label lbl_vkod;
        private System.Windows.Forms.Label lbl_vadi_acik;
        private System.Windows.Forms.Label lbl_dadi_acik;
    }
}

