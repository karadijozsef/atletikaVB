namespace atletikaVB
{
    partial class atletika
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
            this.arany = new System.Windows.Forms.Label();
            this.nemzetek = new System.Windows.Forms.ListBox();
            this.aranyos_nemezetek = new System.Windows.Forms.Button();
            this.versenyszam = new System.Windows.Forms.Label();
            this.versenyszamok = new System.Windows.Forms.ListBox();
            this.helyezes = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.kereses = new System.Windows.Forms.Button();
            this.adatai = new System.Windows.Forms.Label();
            this.nev = new System.Windows.Forms.Label();
            this.eredmeny = new System.Windows.Forms.Label();
            this.nemzete = new System.Windows.Forms.Label();
            this.neve = new System.Windows.Forms.TextBox();
            this.eredmenye = new System.Windows.Forms.TextBox();
            this.nemzet = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // arany
            // 
            this.arany.AutoSize = true;
            this.arany.Location = new System.Drawing.Point(50, 36);
            this.arany.Name = "arany";
            this.arany.Size = new System.Drawing.Size(268, 18);
            this.arany.TabIndex = 0;
            this.arany.Text = "Aranyérmet szerzett nemzetek:";
            // 
            // nemzetek
            // 
            this.nemzetek.FormattingEnabled = true;
            this.nemzetek.ItemHeight = 18;
            this.nemzetek.Location = new System.Drawing.Point(53, 89);
            this.nemzetek.Name = "nemzetek";
            this.nemzetek.Size = new System.Drawing.Size(230, 400);
            this.nemzetek.TabIndex = 1;
            // 
            // aranyos_nemezetek
            // 
            this.aranyos_nemezetek.Location = new System.Drawing.Point(63, 526);
            this.aranyos_nemezetek.Name = "aranyos_nemezetek";
            this.aranyos_nemezetek.Size = new System.Drawing.Size(202, 38);
            this.aranyos_nemezetek.TabIndex = 2;
            this.aranyos_nemezetek.Text = "aranyos - nemzetek";
            this.aranyos_nemezetek.UseVisualStyleBackColor = false;
            this.aranyos_nemezetek.Click += new System.EventHandler(this.aranyos_nemezetek_Click);
            // 
            // versenyszam
            // 
            this.versenyszam.AutoSize = true;
            this.versenyszam.Location = new System.Drawing.Point(409, 36);
            this.versenyszam.Name = "versenyszam";
            this.versenyszam.Size = new System.Drawing.Size(253, 18);
            this.versenyszam.TabIndex = 3;
            this.versenyszam.Text = "Válassza ki a versenyszámot:";
            // 
            // versenyszamok
            // 
            this.versenyszamok.FormattingEnabled = true;
            this.versenyszamok.ItemHeight = 18;
            this.versenyszamok.Location = new System.Drawing.Point(412, 89);
            this.versenyszamok.Name = "versenyszamok";
            this.versenyszamok.Size = new System.Drawing.Size(250, 94);
            this.versenyszamok.TabIndex = 4;
            // 
            // helyezes
            // 
            this.helyezes.AutoSize = true;
            this.helyezes.Location = new System.Drawing.Point(409, 224);
            this.helyezes.Name = "helyezes";
            this.helyezes.Size = new System.Drawing.Size(274, 18);
            this.helyezes.TabIndex = 5;
            this.helyezes.Text = "Válassza ki az érmes helyezést:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(412, 271);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(66, 27);
            this.numericUpDown1.TabIndex = 6;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // kereses
            // 
            this.kereses.Location = new System.Drawing.Point(466, 370);
            this.kereses.Name = "kereses";
            this.kereses.Size = new System.Drawing.Size(143, 39);
            this.kereses.TabIndex = 7;
            this.kereses.Text = "Keresés";
            this.kereses.UseVisualStyleBackColor = false;
            // 
            // adatai
            // 
            this.adatai.AutoSize = true;
            this.adatai.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.adatai.Location = new System.Drawing.Point(409, 471);
            this.adatai.Name = "adatai";
            this.adatai.Size = new System.Drawing.Size(167, 18);
            this.adatai.TabIndex = 8;
            this.adatai.Text = "Versenyző adatai:";
            // 
            // nev
            // 
            this.nev.AutoSize = true;
            this.nev.Location = new System.Drawing.Point(409, 514);
            this.nev.Name = "nev";
            this.nev.Size = new System.Drawing.Size(54, 18);
            this.nev.TabIndex = 9;
            this.nev.Text = "neve:";
            // 
            // eredmeny
            // 
            this.eredmeny.AutoSize = true;
            this.eredmeny.Location = new System.Drawing.Point(409, 560);
            this.eredmeny.Name = "eredmeny";
            this.eredmeny.Size = new System.Drawing.Size(105, 18);
            this.eredmeny.TabIndex = 10;
            this.eredmeny.Text = "eredménye:";
            // 
            // nemzete
            // 
            this.nemzete.AutoSize = true;
            this.nemzete.Location = new System.Drawing.Point(409, 608);
            this.nemzete.Name = "nemzete";
            this.nemzete.Size = new System.Drawing.Size(86, 18);
            this.nemzete.TabIndex = 11;
            this.nemzete.Text = "nemzete:";
            // 
            // neve
            // 
            this.neve.Location = new System.Drawing.Point(491, 511);
            this.neve.Name = "neve";
            this.neve.Size = new System.Drawing.Size(192, 27);
            this.neve.TabIndex = 12;
            this.neve.Visible = false;
            // 
            // eredmenye
            // 
            this.eredmenye.Location = new System.Drawing.Point(537, 557);
            this.eredmenye.Name = "eredmenye";
            this.eredmenye.Size = new System.Drawing.Size(190, 27);
            this.eredmenye.TabIndex = 13;
            this.eredmenye.Visible = false;
            // 
            // nemzet
            // 
            this.nemzet.Location = new System.Drawing.Point(512, 605);
            this.nemzet.Name = "nemzet";
            this.nemzet.Size = new System.Drawing.Size(190, 27);
            this.nemzet.TabIndex = 14;
            this.nemzet.Visible = false;
            // 
            // atletika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1640, 915);
            this.Controls.Add(this.nemzet);
            this.Controls.Add(this.eredmenye);
            this.Controls.Add(this.neve);
            this.Controls.Add(this.nemzete);
            this.Controls.Add(this.eredmeny);
            this.Controls.Add(this.nev);
            this.Controls.Add(this.adatai);
            this.Controls.Add(this.kereses);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.helyezes);
            this.Controls.Add(this.versenyszamok);
            this.Controls.Add(this.versenyszam);
            this.Controls.Add(this.aranyos_nemezetek);
            this.Controls.Add(this.nemzetek);
            this.Controls.Add(this.arany);
            this.Font = new System.Drawing.Font("Verdana", 12F);
            this.ForeColor = System.Drawing.Color.DarkBlue;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "atletika";
            this.Text = "AtlétikaVB";
            this.Load += new System.EventHandler(this.atletika_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label arany;
        private System.Windows.Forms.ListBox nemzetek;
        private System.Windows.Forms.Button aranyos_nemezetek;
        private System.Windows.Forms.Label versenyszam;
        private System.Windows.Forms.ListBox versenyszamok;
        private System.Windows.Forms.Label helyezes;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button kereses;
        private System.Windows.Forms.Label adatai;
        private System.Windows.Forms.Label nev;
        private System.Windows.Forms.Label eredmeny;
        private System.Windows.Forms.Label nemzete;
        private System.Windows.Forms.TextBox neve;
        private System.Windows.Forms.TextBox eredmenye;
        private System.Windows.Forms.TextBox nemzet;
    }
}

