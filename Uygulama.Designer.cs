namespace _10019SelahattinSaylam
{
    partial class Uygulama
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
            this.SSmetroButton1 = new MetroFramework.Controls.MetroButton();
            this.SSmetroButton2 = new MetroFramework.Controls.MetroButton();
            this.SSmetroLink1 = new MetroFramework.Controls.MetroLink();
            this.SuspendLayout();
            // 
            // SSmetroButton1
            // 
            this.SSmetroButton1.Location = new System.Drawing.Point(85, 182);
            this.SSmetroButton1.Name = "SSmetroButton1";
            this.SSmetroButton1.Size = new System.Drawing.Size(131, 23);
            this.SSmetroButton1.TabIndex = 0;
            this.SSmetroButton1.Text = "Rehber";
            this.SSmetroButton1.UseSelectable = true;
            this.SSmetroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // SSmetroButton2
            // 
            this.SSmetroButton2.Location = new System.Drawing.Point(85, 112);
            this.SSmetroButton2.Name = "SSmetroButton2";
            this.SSmetroButton2.Size = new System.Drawing.Size(131, 23);
            this.SSmetroButton2.TabIndex = 1;
            this.SSmetroButton2.Text = "Matematik İşlem";
            this.SSmetroButton2.UseSelectable = true;
            this.SSmetroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // SSmetroLink1
            // 
            this.SSmetroLink1.Location = new System.Drawing.Point(9, 63);
            this.SSmetroLink1.Name = "SSmetroLink1";
            this.SSmetroLink1.Size = new System.Drawing.Size(75, 23);
            this.SSmetroLink1.TabIndex = 2;
            this.SSmetroLink1.Text = "Girişe Dön";
            this.SSmetroLink1.UseSelectable = true;
            this.SSmetroLink1.Click += new System.EventHandler(this.metroLink1_Click);
            // 
            // Uygulama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 331);
            this.Controls.Add(this.SSmetroLink1);
            this.Controls.Add(this.SSmetroButton2);
            this.Controls.Add(this.SSmetroButton1);
            this.Name = "Uygulama";
            this.Text = "Uygulama";
            this.Load += new System.EventHandler(this.Uygulama_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton SSmetroButton1;
        private MetroFramework.Controls.MetroButton SSmetroButton2;
        private MetroFramework.Controls.MetroLink SSmetroLink1;
    }
}