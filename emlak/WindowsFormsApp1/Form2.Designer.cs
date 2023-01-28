namespace WindowsFormsApp1
{
    partial class Form2
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.anasayfaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iletişimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oyunlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bilgiYarışmasıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zarAtmaOyunuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.şikayetEtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışYapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(295, 326);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 39);
            this.button1.TabIndex = 0;
            this.button1.Text = "şikayeti gönder";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(204, 152);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(357, 159);
            this.textBox1.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.anasayfaToolStripMenuItem,
            this.iletişimToolStripMenuItem,
            this.oyunlarToolStripMenuItem,
            this.şikayetEtToolStripMenuItem,
            this.çıkışYapToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(804, 25);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // anasayfaToolStripMenuItem
            // 
            this.anasayfaToolStripMenuItem.Name = "anasayfaToolStripMenuItem";
            this.anasayfaToolStripMenuItem.Size = new System.Drawing.Size(80, 21);
            this.anasayfaToolStripMenuItem.Text = "Anasayfa ";
            this.anasayfaToolStripMenuItem.Click += new System.EventHandler(this.anasayfaToolStripMenuItem_Click);
            // 
            // iletişimToolStripMenuItem
            // 
            this.iletişimToolStripMenuItem.Name = "iletişimToolStripMenuItem";
            this.iletişimToolStripMenuItem.Size = new System.Drawing.Size(70, 21);
            this.iletişimToolStripMenuItem.Text = "İletişim ";
            this.iletişimToolStripMenuItem.Click += new System.EventHandler(this.iletişimToolStripMenuItem_Click);
            // 
            // oyunlarToolStripMenuItem
            // 
            this.oyunlarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bilgiYarışmasıToolStripMenuItem,
            this.zarAtmaOyunuToolStripMenuItem});
            this.oyunlarToolStripMenuItem.Name = "oyunlarToolStripMenuItem";
            this.oyunlarToolStripMenuItem.Size = new System.Drawing.Size(69, 21);
            this.oyunlarToolStripMenuItem.Text = "Oyunlar";
            // 
            // bilgiYarışmasıToolStripMenuItem
            // 
            this.bilgiYarışmasıToolStripMenuItem.Name = "bilgiYarışmasıToolStripMenuItem";
            this.bilgiYarışmasıToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.bilgiYarışmasıToolStripMenuItem.Text = "Bilgi yarışması";
            this.bilgiYarışmasıToolStripMenuItem.Click += new System.EventHandler(this.bilgiYarışmasıToolStripMenuItem_Click);
            // 
            // zarAtmaOyunuToolStripMenuItem
            // 
            this.zarAtmaOyunuToolStripMenuItem.Name = "zarAtmaOyunuToolStripMenuItem";
            this.zarAtmaOyunuToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.zarAtmaOyunuToolStripMenuItem.Text = "Zar  atma oyunu";
            this.zarAtmaOyunuToolStripMenuItem.Click += new System.EventHandler(this.zarAtmaOyunuToolStripMenuItem_Click);
            // 
            // şikayetEtToolStripMenuItem
            // 
            this.şikayetEtToolStripMenuItem.Name = "şikayetEtToolStripMenuItem";
            this.şikayetEtToolStripMenuItem.Size = new System.Drawing.Size(80, 21);
            this.şikayetEtToolStripMenuItem.Text = "Şikayet et";
            this.şikayetEtToolStripMenuItem.Click += new System.EventHandler(this.şikayetEtToolStripMenuItem_Click);
            // 
            // çıkışYapToolStripMenuItem
            // 
            this.çıkışYapToolStripMenuItem.Name = "çıkışYapToolStripMenuItem";
            this.çıkışYapToolStripMenuItem.Size = new System.Drawing.Size(75, 21);
            this.çıkışYapToolStripMenuItem.Text = "Çıkış yap";
            this.çıkışYapToolStripMenuItem.Click += new System.EventHandler(this.çıkışYapToolStripMenuItem_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(804, 469);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem anasayfaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iletişimToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oyunlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bilgiYarışmasıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zarAtmaOyunuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem şikayetEtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışYapToolStripMenuItem;
    }
}