namespace _20201104_Matrix
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
            this.components = new System.ComponentModel.Container();
            this.dgw1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mniGen = new System.Windows.Forms.ToolStripMenuItem();
            this.mniTransz = new System.Windows.Forms.ToolStripMenuItem();
            this.mniParatlan = new System.Windows.Forms.ToolStripMenuItem();
            this.mniFoatlo = new System.Windows.Forms.ToolStripMenuItem();
            this.mniSorok = new System.Windows.Forms.ToolStripMenuItem();
            this.mniOszlopok = new System.Windows.Forms.ToolStripMenuItem();
            this.mniKilep = new System.Windows.Forms.ToolStripMenuItem();
            this.labelParatlan = new System.Windows.Forms.Label();
            this.labelFoatlo = new System.Windows.Forms.Label();
            this.labelSorok = new System.Windows.Forms.Label();
            this.labelOszlopok = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgw1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgw1
            // 
            this.dgw1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw1.Location = new System.Drawing.Point(12, 38);
            this.dgw1.Name = "dgw1";
            this.dgw1.Size = new System.Drawing.Size(420, 322);
            this.dgw1.TabIndex = 0;
            this.dgw1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgw1_CellContentClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniGen,
            this.mniTransz,
            this.mniParatlan,
            this.mniFoatlo,
            this.mniSorok,
            this.mniOszlopok,
            this.mniKilep});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(767, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mniGen
            // 
            this.mniGen.Name = "mniGen";
            this.mniGen.Size = new System.Drawing.Size(70, 20);
            this.mniGen.Text = "Generálás";
            this.mniGen.Click += new System.EventHandler(this.mniGen_Click);
            // 
            // mniTransz
            // 
            this.mniTransz.Name = "mniTransz";
            this.mniTransz.Size = new System.Drawing.Size(97, 20);
            this.mniTransz.Text = "Transzformálás";
            this.mniTransz.Click += new System.EventHandler(this.mniTransz_Click);
            // 
            // mniParatlan
            // 
            this.mniParatlan.Name = "mniParatlan";
            this.mniParatlan.Size = new System.Drawing.Size(149, 20);
            this.mniParatlan.Text = "Páratlan számok összege";
            this.mniParatlan.Click += new System.EventHandler(this.mniParatlan_Click);
            // 
            // mniFoatlo
            // 
            this.mniFoatlo.Name = "mniFoatlo";
            this.mniFoatlo.Size = new System.Drawing.Size(96, 20);
            this.mniFoatlo.Text = "Főátló összege";
            this.mniFoatlo.Click += new System.EventHandler(this.mniFoatlo_Click);
            // 
            // mniSorok
            // 
            this.mniSorok.Name = "mniSorok";
            this.mniSorok.Size = new System.Drawing.Size(93, 20);
            this.mniSorok.Text = "Sorok összege";
            this.mniSorok.Click += new System.EventHandler(this.mniSorok_Click);
            // 
            // mniOszlopok
            // 
            this.mniOszlopok.Name = "mniOszlopok";
            this.mniOszlopok.Size = new System.Drawing.Size(112, 20);
            this.mniOszlopok.Text = "Oszlopok összege";
            this.mniOszlopok.Click += new System.EventHandler(this.mniOszlopok_Click);
            // 
            // mniKilep
            // 
            this.mniKilep.Name = "mniKilep";
            this.mniKilep.Size = new System.Drawing.Size(56, 20);
            this.mniKilep.Text = "Kilépés";
            // 
            // labelParatlan
            // 
            this.labelParatlan.AutoSize = true;
            this.labelParatlan.Location = new System.Drawing.Point(489, 80);
            this.labelParatlan.Name = "labelParatlan";
            this.labelParatlan.Size = new System.Drawing.Size(125, 13);
            this.labelParatlan.TabIndex = 2;
            this.labelParatlan.Text = "Páratlan elemek összege";
            // 
            // labelFoatlo
            // 
            this.labelFoatlo.AutoSize = true;
            this.labelFoatlo.Location = new System.Drawing.Point(489, 132);
            this.labelFoatlo.Name = "labelFoatlo";
            this.labelFoatlo.Size = new System.Drawing.Size(35, 13);
            this.labelFoatlo.TabIndex = 3;
            this.labelFoatlo.Text = "label2";
            // 
            // labelSorok
            // 
            this.labelSorok.AutoSize = true;
            this.labelSorok.Location = new System.Drawing.Point(489, 184);
            this.labelSorok.Name = "labelSorok";
            this.labelSorok.Size = new System.Drawing.Size(35, 13);
            this.labelSorok.TabIndex = 4;
            this.labelSorok.Text = "label3";
            // 
            // labelOszlopok
            // 
            this.labelOszlopok.AutoSize = true;
            this.labelOszlopok.Location = new System.Drawing.Point(489, 236);
            this.labelOszlopok.Name = "labelOszlopok";
            this.labelOszlopok.Size = new System.Drawing.Size(35, 13);
            this.labelOszlopok.TabIndex = 5;
            this.labelOszlopok.Text = "label4";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 450);
            this.Controls.Add(this.labelOszlopok);
            this.Controls.Add(this.labelSorok);
            this.Controls.Add(this.labelFoatlo);
            this.Controls.Add(this.labelParatlan);
            this.Controls.Add(this.dgw1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Mátrix transzformáció";
            ((System.ComponentModel.ISupportInitialize)(this.dgw1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgw1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mniGen;
        private System.Windows.Forms.ToolStripMenuItem mniTransz;
        private System.Windows.Forms.ToolStripMenuItem mniParatlan;
        private System.Windows.Forms.ToolStripMenuItem mniFoatlo;
        private System.Windows.Forms.ToolStripMenuItem mniSorok;
        private System.Windows.Forms.ToolStripMenuItem mniOszlopok;
        private System.Windows.Forms.ToolStripMenuItem mniKilep;
        private System.Windows.Forms.Label labelParatlan;
        private System.Windows.Forms.Label labelFoatlo;
        private System.Windows.Forms.Label labelSorok;
        private System.Windows.Forms.Label labelOszlopok;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}

