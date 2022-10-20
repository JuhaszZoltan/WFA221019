namespace WFA221019
{
    partial class FrmReszletek
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
            this.lblNev = new System.Windows.Forms.Label();
            this.lblUI01 = new System.Windows.Forms.Label();
            this.lblFoglalkozasok = new System.Windows.Forms.Label();
            this.lblUI02 = new System.Windows.Forms.Label();
            this.lblEvszamok = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNev
            // 
            this.lblNev.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNev.Location = new System.Drawing.Point(12, 9);
            this.lblNev.Name = "lblNev";
            this.lblNev.Size = new System.Drawing.Size(360, 83);
            this.lblNev.TabIndex = 0;
            this.lblNev.Text = "###NEV###";
            this.lblNev.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUI01
            // 
            this.lblUI01.BackColor = System.Drawing.Color.IndianRed;
            this.lblUI01.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblUI01.Location = new System.Drawing.Point(12, 104);
            this.lblUI01.Name = "lblUI01";
            this.lblUI01.Size = new System.Drawing.Size(360, 30);
            this.lblUI01.TabIndex = 0;
            this.lblUI01.Text = "Fő foglalkozásai:";
            this.lblUI01.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFoglalkozasok
            // 
            this.lblFoglalkozasok.BackColor = System.Drawing.Color.IndianRed;
            this.lblFoglalkozasok.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFoglalkozasok.Location = new System.Drawing.Point(12, 146);
            this.lblFoglalkozasok.Name = "lblFoglalkozasok";
            this.lblFoglalkozasok.Size = new System.Drawing.Size(360, 145);
            this.lblFoglalkozasok.TabIndex = 0;
            this.lblFoglalkozasok.Text = "###\r\n[*]  foglalkozas _1\r\n[*]  foglalkozas_2\r\n###";
            // 
            // lblUI02
            // 
            this.lblUI02.BackColor = System.Drawing.Color.LightCoral;
            this.lblUI02.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblUI02.Location = new System.Drawing.Point(12, 305);
            this.lblUI02.Name = "lblUI02";
            this.lblUI02.Size = new System.Drawing.Size(152, 30);
            this.lblUI02.TabIndex = 0;
            this.lblUI02.Text = "A díjat elnyerte:";
            this.lblUI02.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblEvszamok
            // 
            this.lblEvszamok.BackColor = System.Drawing.Color.LightCoral;
            this.lblEvszamok.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEvszamok.Location = new System.Drawing.Point(170, 305);
            this.lblEvszamok.Name = "lblEvszamok";
            this.lblEvszamok.Size = new System.Drawing.Size(202, 30);
            this.lblEvszamok.TabIndex = 0;
            this.lblEvszamok.Text = "###evszamok###";
            this.lblEvszamok.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FrmReszletek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(384, 348);
            this.Controls.Add(this.lblFoglalkozasok);
            this.Controls.Add(this.lblEvszamok);
            this.Controls.Add(this.lblUI02);
            this.Controls.Add(this.lblUI01);
            this.Controls.Add(this.lblNev);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmReszletek";
            this.Text = "Részletek";
            this.Load += new System.EventHandler(this.FrmReszletek_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Label lblNev;
        private Label lblUI01;
        private Label lblFoglalkozasok;
        private Label lblUI02;
        private Label lblEvszamok;
    }
}