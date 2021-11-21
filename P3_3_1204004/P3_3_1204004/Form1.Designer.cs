namespace P3_3_1204004
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbScanner = new System.Windows.Forms.RadioButton();
            this.rbMonitor = new System.Windows.Forms.RadioButton();
            this.rbPrinter = new System.Windows.Forms.RadioButton();
            this.rbMouse = new System.Windows.Forms.RadioButton();
            this.rbKeyboard = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.tsGambar = new System.Windows.Forms.ToolStrip();
            this.tbsmouse = new System.Windows.Forms.ToolStripButton();
            this.tbsprinter = new System.Windows.Forms.ToolStripButton();
            this.tbskeyboard = new System.Windows.Forms.ToolStripButton();
            this.tsbScanner = new System.Windows.Forms.ToolStripButton();
            this.tbsMonitor = new System.Windows.Forms.ToolStripButton();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tslKetGambar = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1.SuspendLayout();
            this.tsGambar.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbScanner);
            this.groupBox1.Controls.Add(this.rbMonitor);
            this.groupBox1.Controls.Add(this.rbPrinter);
            this.groupBox1.Controls.Add(this.rbMouse);
            this.groupBox1.Controls.Add(this.rbKeyboard);
            this.groupBox1.Location = new System.Drawing.Point(45, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(175, 220);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nama Gambar";
            // 
            // rbScanner
            // 
            this.rbScanner.AutoSize = true;
            this.rbScanner.Location = new System.Drawing.Point(45, 180);
            this.rbScanner.Name = "rbScanner";
            this.rbScanner.Size = new System.Drawing.Size(65, 17);
            this.rbScanner.TabIndex = 7;
            this.rbScanner.TabStop = true;
            this.rbScanner.Text = "Scanner";
            this.rbScanner.UseVisualStyleBackColor = true;
            // 
            // rbMonitor
            // 
            this.rbMonitor.AutoSize = true;
            this.rbMonitor.Location = new System.Drawing.Point(45, 24);
            this.rbMonitor.Name = "rbMonitor";
            this.rbMonitor.Size = new System.Drawing.Size(60, 17);
            this.rbMonitor.TabIndex = 3;
            this.rbMonitor.TabStop = true;
            this.rbMonitor.Text = "Monitor";
            this.rbMonitor.UseVisualStyleBackColor = true;
            // 
            // rbPrinter
            // 
            this.rbPrinter.AutoSize = true;
            this.rbPrinter.Location = new System.Drawing.Point(45, 141);
            this.rbPrinter.Name = "rbPrinter";
            this.rbPrinter.Size = new System.Drawing.Size(55, 17);
            this.rbPrinter.TabIndex = 5;
            this.rbPrinter.TabStop = true;
            this.rbPrinter.Text = "Printer";
            this.rbPrinter.UseVisualStyleBackColor = true;
            // 
            // rbMouse
            // 
            this.rbMouse.AutoSize = true;
            this.rbMouse.Location = new System.Drawing.Point(45, 102);
            this.rbMouse.Name = "rbMouse";
            this.rbMouse.Size = new System.Drawing.Size(57, 17);
            this.rbMouse.TabIndex = 6;
            this.rbMouse.TabStop = true;
            this.rbMouse.Text = "Mouse";
            this.rbMouse.UseVisualStyleBackColor = true;
            // 
            // rbKeyboard
            // 
            this.rbKeyboard.AutoSize = true;
            this.rbKeyboard.Location = new System.Drawing.Point(45, 63);
            this.rbKeyboard.Name = "rbKeyboard";
            this.rbKeyboard.Size = new System.Drawing.Size(70, 17);
            this.rbKeyboard.TabIndex = 4;
            this.rbKeyboard.TabStop = true;
            this.rbKeyboard.Text = "Keyboard";
            this.rbKeyboard.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(392, 14);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pilih salah satu item berikut dan klik pada gambar yang sesuai!";
            // 
            // tsGambar
            // 
            this.tsGambar.Dock = System.Windows.Forms.DockStyle.None;
            this.tsGambar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsGambar.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.tsGambar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbsmouse,
            this.tbsprinter,
            this.tbskeyboard,
            this.tsbScanner,
            this.tbsMonitor});
            this.tsGambar.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.tsGambar.Location = new System.Drawing.Point(281, 60);
            this.tsGambar.Name = "tsGambar";
            this.tsGambar.Size = new System.Drawing.Size(61, 272);
            this.tsGambar.TabIndex = 3;
            this.tsGambar.Text = "toolStrip1";
            // 
            // tbsmouse
            // 
            this.tbsmouse.AutoSize = false;
            this.tbsmouse.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbsmouse.Image = ((System.Drawing.Image)(resources.GetObject("tbsmouse.Image")));
            this.tbsmouse.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbsmouse.Name = "tbsmouse";
            this.tbsmouse.Size = new System.Drawing.Size(60, 60);
            this.tbsmouse.Text = "mouse";
            this.tbsmouse.Click += new System.EventHandler(this.tbsmouse_Click);
            // 
            // tbsprinter
            // 
            this.tbsprinter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbsprinter.Image = ((System.Drawing.Image)(resources.GetObject("tbsprinter.Image")));
            this.tbsprinter.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbsprinter.Name = "tbsprinter";
            this.tbsprinter.Size = new System.Drawing.Size(59, 44);
            this.tbsprinter.Text = "Printer";
            this.tbsprinter.Click += new System.EventHandler(this.tbsprinter_Click);
            // 
            // tbskeyboard
            // 
            this.tbskeyboard.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbskeyboard.Image = ((System.Drawing.Image)(resources.GetObject("tbskeyboard.Image")));
            this.tbskeyboard.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbskeyboard.Name = "tbskeyboard";
            this.tbskeyboard.Size = new System.Drawing.Size(59, 44);
            this.tbskeyboard.Text = "Keyboard";
            this.tbskeyboard.Click += new System.EventHandler(this.tbskeyboard_Click);
            // 
            // tsbScanner
            // 
            this.tsbScanner.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbScanner.Image = ((System.Drawing.Image)(resources.GetObject("tsbScanner.Image")));
            this.tsbScanner.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbScanner.Name = "tsbScanner";
            this.tsbScanner.Size = new System.Drawing.Size(59, 44);
            this.tsbScanner.Text = "Scanner";
            this.tsbScanner.Click += new System.EventHandler(this.tsbScanner_Click);
            // 
            // tbsMonitor
            // 
            this.tbsMonitor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbsMonitor.Image = ((System.Drawing.Image)(resources.GetObject("tbsMonitor.Image")));
            this.tbsMonitor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbsMonitor.Name = "tbsMonitor";
            this.tbsMonitor.Size = new System.Drawing.Size(59, 44);
            this.tbsMonitor.Text = "Monitor";
            this.tbsMonitor.Click += new System.EventHandler(this.tbsMonitor_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslKetGambar});
            this.statusStrip1.Location = new System.Drawing.Point(0, 409);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(455, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tslKetGambar
            // 
            this.tslKetGambar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tslKetGambar.Name = "tslKetGambar";
            this.tslKetGambar.Size = new System.Drawing.Size(0, 17);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 431);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tsGambar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tsGambar.ResumeLayout(false);
            this.tsGambar.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbScanner;
        private System.Windows.Forms.RadioButton rbMonitor;
        private System.Windows.Forms.RadioButton rbPrinter;
        private System.Windows.Forms.RadioButton rbMouse;
        private System.Windows.Forms.RadioButton rbKeyboard;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip tsGambar;
        private System.Windows.Forms.ToolStripButton tbsmouse;
        private System.Windows.Forms.ToolStripButton tbsprinter;
        private System.Windows.Forms.ToolStripButton tbskeyboard;
        private System.Windows.Forms.ToolStripButton tsbScanner;
        private System.Windows.Forms.ToolStripButton tbsMonitor;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tslKetGambar;
    }
}

