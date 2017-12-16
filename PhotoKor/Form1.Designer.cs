namespace PhotoKor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbClose = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbAppName = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ibPicture = new Emgu.CV.UI.ImageBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.winter_btn = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.summer_btn = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.sunny_btn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.autumn_btn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.forest_btn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.greyhisto_btn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.histogram_btn = new System.Windows.Forms.Button();
            this.grayscale_btn = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.trackBar3 = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.lbRed = new System.Windows.Forms.Label();
            this.lbRGBLevel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetChangesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showOriginalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label13 = new System.Windows.Forms.Label();
            this.vertical_flip_btn = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.horizontal_flip_btn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ibPicture)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.pbClose);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.lbAppName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1273, 25);
            this.panel1.TabIndex = 0;
            // 
            // pbClose
            // 
            this.pbClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.pbClose.Image = ((System.Drawing.Image)(resources.GetObject("pbClose.Image")));
            this.pbClose.Location = new System.Drawing.Point(1238, 0);
            this.pbClose.Name = "pbClose";
            this.pbClose.Size = new System.Drawing.Size(25, 25);
            this.pbClose.TabIndex = 1;
            this.pbClose.TabStop = false;
            this.pbClose.Click += new System.EventHandler(this.pbClose_Click);
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(1263, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 25);
            this.panel3.TabIndex = 2;
            // 
            // lbAppName
            // 
            this.lbAppName.BackColor = System.Drawing.Color.Transparent;
            this.lbAppName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbAppName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAppName.ForeColor = System.Drawing.Color.White;
            this.lbAppName.Location = new System.Drawing.Point(0, 0);
            this.lbAppName.Name = "lbAppName";
            this.lbAppName.Size = new System.Drawing.Size(1273, 25);
            this.lbAppName.TabIndex = 1;
            this.lbAppName.Text = "PhotoKor";
            this.lbAppName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ibPicture);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.menuStrip1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1273, 755);
            this.panel2.TabIndex = 1;
            // 
            // ibPicture
            // 
            this.ibPicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ibPicture.Location = new System.Drawing.Point(0, 24);
            this.ibPicture.Name = "ibPicture";
            this.ibPicture.Size = new System.Drawing.Size(1073, 631);
            this.ibPicture.TabIndex = 2;
            this.ibPicture.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DarkGray;
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel5.Controls.Add(this.label12);
            this.panel5.Controls.Add(this.button1);
            this.panel5.Controls.Add(this.label11);
            this.panel5.Controls.Add(this.winter_btn);
            this.panel5.Controls.Add(this.label10);
            this.panel5.Controls.Add(this.summer_btn);
            this.panel5.Controls.Add(this.label9);
            this.panel5.Controls.Add(this.sunny_btn);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Controls.Add(this.autumn_btn);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.forest_btn);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.greyhisto_btn);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.histogram_btn);
            this.panel5.Controls.Add(this.grayscale_btn);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 655);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1073, 100);
            this.panel5.TabIndex = 2;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(805, 84);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 13);
            this.label12.TabIndex = 17;
            this.label12.Text = "Winter";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(780, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 75);
            this.button1.TabIndex = 16;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(709, 84);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 13);
            this.label11.TabIndex = 15;
            this.label11.Text = "Winter";
            // 
            // winter_btn
            // 
            this.winter_btn.Location = new System.Drawing.Point(684, 6);
            this.winter_btn.Name = "winter_btn";
            this.winter_btn.Size = new System.Drawing.Size(90, 75);
            this.winter_btn.TabIndex = 14;
            this.winter_btn.UseVisualStyleBackColor = true;
            this.winter_btn.Click += new System.EventHandler(this.winter_btn_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(420, 84);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "Summer";
            // 
            // summer_btn
            // 
            this.summer_btn.Location = new System.Drawing.Point(396, 6);
            this.summer_btn.Name = "summer_btn";
            this.summer_btn.Size = new System.Drawing.Size(90, 75);
            this.summer_btn.TabIndex = 12;
            this.summer_btn.UseVisualStyleBackColor = true;
            this.summer_btn.Click += new System.EventHandler(this.summer_btn_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(613, 84);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Sunny";
            // 
            // sunny_btn
            // 
            this.sunny_btn.Location = new System.Drawing.Point(588, 6);
            this.sunny_btn.Name = "sunny_btn";
            this.sunny_btn.Size = new System.Drawing.Size(90, 75);
            this.sunny_btn.TabIndex = 10;
            this.sunny_btn.UseVisualStyleBackColor = true;
            this.sunny_btn.Click += new System.EventHandler(this.sunny_btn_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(518, 84);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Autumn";
            // 
            // autumn_btn
            // 
            this.autumn_btn.Location = new System.Drawing.Point(492, 6);
            this.autumn_btn.Name = "autumn_btn";
            this.autumn_btn.Size = new System.Drawing.Size(90, 75);
            this.autumn_btn.TabIndex = 8;
            this.autumn_btn.UseVisualStyleBackColor = true;
            this.autumn_btn.Click += new System.EventHandler(this.autumn_btn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(332, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Forest";
            // 
            // forest_btn
            // 
            this.forest_btn.Location = new System.Drawing.Point(300, 6);
            this.forest_btn.Name = "forest_btn";
            this.forest_btn.Size = new System.Drawing.Size(90, 75);
            this.forest_btn.TabIndex = 6;
            this.forest_btn.UseVisualStyleBackColor = true;
            this.forest_btn.Click += new System.EventHandler(this.forest_btn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(230, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Foggy";
            // 
            // greyhisto_btn
            // 
            this.greyhisto_btn.Location = new System.Drawing.Point(204, 6);
            this.greyhisto_btn.Name = "greyhisto_btn";
            this.greyhisto_btn.Size = new System.Drawing.Size(90, 75);
            this.greyhisto_btn.TabIndex = 4;
            this.greyhisto_btn.UseVisualStyleBackColor = true;
            this.greyhisto_btn.Click += new System.EventHandler(this.greyhisto_btn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(127, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Histogram";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Grayscale";
            // 
            // histogram_btn
            // 
            this.histogram_btn.Location = new System.Drawing.Point(108, 6);
            this.histogram_btn.Name = "histogram_btn";
            this.histogram_btn.Size = new System.Drawing.Size(90, 75);
            this.histogram_btn.TabIndex = 1;
            this.histogram_btn.UseVisualStyleBackColor = true;
            this.histogram_btn.Click += new System.EventHandler(this.histogram_btn_Click);
            // 
            // grayscale_btn
            // 
            this.grayscale_btn.Location = new System.Drawing.Point(12, 6);
            this.grayscale_btn.Name = "grayscale_btn";
            this.grayscale_btn.Size = new System.Drawing.Size(90, 75);
            this.grayscale_btn.TabIndex = 0;
            this.grayscale_btn.UseVisualStyleBackColor = true;
            this.grayscale_btn.Click += new System.EventHandler(this.grayscale_btn_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkGray;
            this.panel4.Controls.Add(this.label14);
            this.panel4.Controls.Add(this.horizontal_flip_btn);
            this.panel4.Controls.Add(this.label13);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.vertical_flip_btn);
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(1073, 24);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 731);
            this.panel4.TabIndex = 1;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(0, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Functions:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.DarkGray;
            this.panel6.Controls.Add(this.trackBar3);
            this.panel6.Controls.Add(this.label2);
            this.panel6.Controls.Add(this.trackBar2);
            this.panel6.Controls.Add(this.label1);
            this.panel6.Controls.Add(this.trackBar1);
            this.panel6.Controls.Add(this.lbRed);
            this.panel6.Controls.Add(this.lbRGBLevel);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(200, 236);
            this.panel6.TabIndex = 0;
            // 
            // trackBar3
            // 
            this.trackBar3.Dock = System.Windows.Forms.DockStyle.Top;
            this.trackBar3.Location = new System.Drawing.Point(0, 190);
            this.trackBar3.Name = "trackBar3";
            this.trackBar3.Size = new System.Drawing.Size(200, 45);
            this.trackBar3.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(0, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Blue:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trackBar2
            // 
            this.trackBar2.Dock = System.Windows.Forms.DockStyle.Top;
            this.trackBar2.Location = new System.Drawing.Point(0, 120);
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(200, 45);
            this.trackBar2.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(0, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Green:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trackBar1
            // 
            this.trackBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.trackBar1.Location = new System.Drawing.Point(0, 50);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(200, 45);
            this.trackBar1.TabIndex = 5;
            // 
            // lbRed
            // 
            this.lbRed.BackColor = System.Drawing.Color.Transparent;
            this.lbRed.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbRed.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbRed.ForeColor = System.Drawing.Color.Red;
            this.lbRed.Location = new System.Drawing.Point(0, 25);
            this.lbRed.Name = "lbRed";
            this.lbRed.Size = new System.Drawing.Size(200, 25);
            this.lbRed.TabIndex = 3;
            this.lbRed.Text = "Red:";
            this.lbRed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbRGBLevel
            // 
            this.lbRGBLevel.BackColor = System.Drawing.Color.Transparent;
            this.lbRGBLevel.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbRGBLevel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRGBLevel.ForeColor = System.Drawing.Color.White;
            this.lbRGBLevel.Location = new System.Drawing.Point(0, 0);
            this.lbRGBLevel.Name = "lbRGBLevel";
            this.lbRGBLevel.Size = new System.Drawing.Size(200, 25);
            this.lbRGBLevel.TabIndex = 2;
            this.lbRGBLevel.Text = "RGB level:";
            this.lbRGBLevel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DimGray;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1273, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.saveAsToolStripMenuItem.Text = "Save as...";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resetChangesToolStripMenuItem,
            this.showOriginalToolStripMenuItem});
            this.editToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // resetChangesToolStripMenuItem
            // 
            this.resetChangesToolStripMenuItem.Name = "resetChangesToolStripMenuItem";
            this.resetChangesToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.resetChangesToolStripMenuItem.Text = "Reset changes";
            // 
            // showOriginalToolStripMenuItem
            // 
            this.showOriginalToolStripMenuItem.Name = "showOriginalToolStripMenuItem";
            this.showOriginalToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.showOriginalToolStripMenuItem.Text = "Show original";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(26, 342);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(42, 13);
            this.label13.TabIndex = 19;
            this.label13.Text = "Vertical";
            // 
            // vertical_flip_btn
            // 
            this.vertical_flip_btn.Location = new System.Drawing.Point(3, 264);
            this.vertical_flip_btn.Name = "vertical_flip_btn";
            this.vertical_flip_btn.Size = new System.Drawing.Size(90, 75);
            this.vertical_flip_btn.TabIndex = 18;
            this.vertical_flip_btn.UseVisualStyleBackColor = true;
            this.vertical_flip_btn.Click += new System.EventHandler(this.vertical_flip_btn_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(132, 342);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(54, 13);
            this.label14.TabIndex = 21;
            this.label14.Text = "Horizontal";
            // 
            // horizontal_flip_btn
            // 
            this.horizontal_flip_btn.Location = new System.Drawing.Point(107, 264);
            this.horizontal_flip_btn.Name = "horizontal_flip_btn";
            this.horizontal_flip_btn.Size = new System.Drawing.Size(90, 75);
            this.horizontal_flip_btn.TabIndex = 20;
            this.horizontal_flip_btn.UseVisualStyleBackColor = true;
            this.horizontal_flip_btn.Click += new System.EventHandler(this.horizontal_flip_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1273, 780);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ibPicture)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetChangesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showOriginalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.PictureBox pbClose;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbAppName;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lbRGBLevel;
        private System.Windows.Forms.TrackBar trackBar3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label lbRed;
        private System.Windows.Forms.Label label3;
        private Emgu.CV.UI.ImageBox ibPicture;
        private System.Windows.Forms.Button grayscale_btn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button histogram_btn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button greyhisto_btn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button forest_btn;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button summer_btn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button sunny_btn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button autumn_btn;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button winter_btn;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button horizontal_flip_btn;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button vertical_flip_btn;
    }
}

