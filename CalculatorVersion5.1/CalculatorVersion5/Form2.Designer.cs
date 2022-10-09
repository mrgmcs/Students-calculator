namespace CalculatorVersion5
{
    partial class frmclc
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblresult = new System.Windows.Forms.Label();
            this.btntaghsim = new System.Windows.Forms.Button();
            this.btnzarb = new System.Windows.Forms.Button();
            this.btnpow = new System.Windows.Forms.Button();
            this.btnmenha = new System.Windows.Forms.Button();
            this.btnmin = new System.Windows.Forms.Button();
            this.btnmax = new System.Windows.Forms.Button();
            this.btnjame = new System.Windows.Forms.Button();
            this.b1 = new System.Windows.Forms.Button();
            this.b2 = new System.Windows.Forms.Button();
            this.b4 = new System.Windows.Forms.Button();
            this.b5 = new System.Windows.Forms.Button();
            this.b3 = new System.Windows.Forms.Button();
            this.b6 = new System.Windows.Forms.Button();
            this.b7 = new System.Windows.Forms.Button();
            this.b8 = new System.Windows.Forms.Button();
            this.b9 = new System.Windows.Forms.Button();
            this.b0 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.whatCanYouDoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.commandToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportBugToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.moreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cnrToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.numberpadColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xyzXydecimalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.primeNumberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gCDAndLCMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findRandomNumberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rootAndSquareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.numcounterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.btnrs = new System.Windows.Forms.Button();
            this.cmb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.colorDialog2 = new System.Windows.Forms.ColorDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Black;
            this.textBox1.Location = new System.Drawing.Point(6, 27);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(227, 34);
            this.textBox1.TabIndex = 50;
            this.textBox1.TextChanged += new System.EventHandler(this.txt1_textch);
            // 
            // lblresult
            // 
            this.lblresult.AutoSize = true;
            this.lblresult.BackColor = System.Drawing.Color.Gray;
            this.lblresult.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblresult.ForeColor = System.Drawing.Color.Black;
            this.lblresult.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblresult.Location = new System.Drawing.Point(1, 122);
            this.lblresult.Name = "lblresult";
            this.lblresult.Size = new System.Drawing.Size(25, 27);
            this.lblresult.TabIndex = 49;
            this.lblresult.Text = "0";
            // 
            // btntaghsim
            // 
            this.btntaghsim.BackColor = System.Drawing.Color.Red;
            this.btntaghsim.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntaghsim.Location = new System.Drawing.Point(48, 226);
            this.btntaghsim.Name = "btntaghsim";
            this.btntaghsim.Size = new System.Drawing.Size(45, 45);
            this.btntaghsim.TabIndex = 40;
            this.btntaghsim.Text = "÷";
            this.btntaghsim.UseVisualStyleBackColor = false;
            this.btntaghsim.Click += new System.EventHandler(this.btntaghsim_Click);
            // 
            // btnzarb
            // 
            this.btnzarb.BackColor = System.Drawing.Color.Red;
            this.btnzarb.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnzarb.Location = new System.Drawing.Point(2, 226);
            this.btnzarb.Name = "btnzarb";
            this.btnzarb.Size = new System.Drawing.Size(45, 45);
            this.btnzarb.TabIndex = 41;
            this.btnzarb.Text = "×";
            this.btnzarb.UseVisualStyleBackColor = false;
            this.btnzarb.Click += new System.EventHandler(this.btnzarb_Click);
            // 
            // btnpow
            // 
            this.btnpow.BackColor = System.Drawing.Color.Red;
            this.btnpow.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpow.Location = new System.Drawing.Point(48, 319);
            this.btnpow.Name = "btnpow";
            this.btnpow.Size = new System.Drawing.Size(45, 45);
            this.btnpow.TabIndex = 42;
            this.btnpow.Text = "X^y";
            this.btnpow.UseVisualStyleBackColor = false;
            this.btnpow.Click += new System.EventHandler(this.btnpow_Click);
            // 
            // btnmenha
            // 
            this.btnmenha.BackColor = System.Drawing.Color.Red;
            this.btnmenha.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmenha.Location = new System.Drawing.Point(48, 179);
            this.btnmenha.Name = "btnmenha";
            this.btnmenha.Size = new System.Drawing.Size(45, 45);
            this.btnmenha.TabIndex = 43;
            this.btnmenha.Text = "-";
            this.btnmenha.UseVisualStyleBackColor = false;
            this.btnmenha.Click += new System.EventHandler(this.btnmenha_Click);
            // 
            // btnmin
            // 
            this.btnmin.BackColor = System.Drawing.Color.Red;
            this.btnmin.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmin.Location = new System.Drawing.Point(2, 319);
            this.btnmin.Name = "btnmin";
            this.btnmin.Size = new System.Drawing.Size(45, 45);
            this.btnmin.TabIndex = 46;
            this.btnmin.Text = "Min";
            this.btnmin.UseVisualStyleBackColor = false;
            this.btnmin.Click += new System.EventHandler(this.btnmin_Click);
            // 
            // btnmax
            // 
            this.btnmax.BackColor = System.Drawing.Color.Red;
            this.btnmax.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmax.Location = new System.Drawing.Point(2, 272);
            this.btnmax.Name = "btnmax";
            this.btnmax.Size = new System.Drawing.Size(91, 45);
            this.btnmax.TabIndex = 47;
            this.btnmax.Text = "Max";
            this.btnmax.UseVisualStyleBackColor = false;
            this.btnmax.Click += new System.EventHandler(this.btnmax_Click);
            // 
            // btnjame
            // 
            this.btnjame.BackColor = System.Drawing.Color.Red;
            this.btnjame.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnjame.Location = new System.Drawing.Point(2, 179);
            this.btnjame.Name = "btnjame";
            this.btnjame.Size = new System.Drawing.Size(45, 45);
            this.btnjame.TabIndex = 48;
            this.btnjame.Text = "+";
            this.btnjame.UseVisualStyleBackColor = false;
            this.btnjame.Click += new System.EventHandler(this.btnjame_Click);
            // 
            // b1
            // 
            this.b1.BackColor = System.Drawing.Color.Red;
            this.b1.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b1.Location = new System.Drawing.Point(94, 179);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(45, 45);
            this.b1.TabIndex = 40;
            this.b1.Text = "1";
            this.b1.UseVisualStyleBackColor = false;
            this.b1.Click += new System.EventHandler(this.button_Click);
            // 
            // b2
            // 
            this.b2.BackColor = System.Drawing.Color.Red;
            this.b2.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b2.Location = new System.Drawing.Point(141, 179);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(45, 45);
            this.b2.TabIndex = 40;
            this.b2.Text = "2";
            this.b2.UseVisualStyleBackColor = false;
            this.b2.Click += new System.EventHandler(this.button_Click);
            // 
            // b4
            // 
            this.b4.BackColor = System.Drawing.Color.Red;
            this.b4.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b4.Location = new System.Drawing.Point(94, 226);
            this.b4.Name = "b4";
            this.b4.Size = new System.Drawing.Size(45, 45);
            this.b4.TabIndex = 40;
            this.b4.Text = "4";
            this.b4.UseVisualStyleBackColor = false;
            this.b4.Click += new System.EventHandler(this.button_Click);
            // 
            // b5
            // 
            this.b5.BackColor = System.Drawing.Color.Red;
            this.b5.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b5.Location = new System.Drawing.Point(141, 226);
            this.b5.Name = "b5";
            this.b5.Size = new System.Drawing.Size(45, 45);
            this.b5.TabIndex = 40;
            this.b5.Text = "5";
            this.b5.UseVisualStyleBackColor = false;
            this.b5.Click += new System.EventHandler(this.button_Click);
            // 
            // b3
            // 
            this.b3.BackColor = System.Drawing.Color.Red;
            this.b3.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b3.Location = new System.Drawing.Point(188, 179);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(45, 45);
            this.b3.TabIndex = 40;
            this.b3.Text = "3";
            this.b3.UseVisualStyleBackColor = false;
            this.b3.Click += new System.EventHandler(this.button_Click);
            // 
            // b6
            // 
            this.b6.BackColor = System.Drawing.Color.Red;
            this.b6.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b6.Location = new System.Drawing.Point(188, 226);
            this.b6.Name = "b6";
            this.b6.Size = new System.Drawing.Size(45, 45);
            this.b6.TabIndex = 40;
            this.b6.Text = "6";
            this.b6.UseVisualStyleBackColor = false;
            this.b6.Click += new System.EventHandler(this.button_Click);
            // 
            // b7
            // 
            this.b7.BackColor = System.Drawing.Color.Red;
            this.b7.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b7.Location = new System.Drawing.Point(94, 272);
            this.b7.Name = "b7";
            this.b7.Size = new System.Drawing.Size(45, 45);
            this.b7.TabIndex = 40;
            this.b7.Text = "7";
            this.b7.UseVisualStyleBackColor = false;
            this.b7.Click += new System.EventHandler(this.button_Click);
            // 
            // b8
            // 
            this.b8.BackColor = System.Drawing.Color.Red;
            this.b8.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b8.Location = new System.Drawing.Point(141, 272);
            this.b8.Name = "b8";
            this.b8.Size = new System.Drawing.Size(45, 45);
            this.b8.TabIndex = 40;
            this.b8.Text = "8";
            this.b8.UseVisualStyleBackColor = false;
            this.b8.Click += new System.EventHandler(this.button_Click);
            // 
            // b9
            // 
            this.b9.BackColor = System.Drawing.Color.Red;
            this.b9.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b9.Location = new System.Drawing.Point(188, 272);
            this.b9.Name = "b9";
            this.b9.Size = new System.Drawing.Size(45, 45);
            this.b9.TabIndex = 40;
            this.b9.Text = "9";
            this.b9.UseVisualStyleBackColor = false;
            this.b9.Click += new System.EventHandler(this.button_Click);
            // 
            // b0
            // 
            this.b0.BackColor = System.Drawing.Color.Red;
            this.b0.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b0.Location = new System.Drawing.Point(94, 319);
            this.b0.Name = "b0";
            this.b0.Size = new System.Drawing.Size(45, 45);
            this.b0.TabIndex = 40;
            this.b0.Text = "0";
            this.b0.UseVisualStyleBackColor = false;
            this.b0.Click += new System.EventHandler(this.button_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.AllowItemReorder = true;
            this.menuStrip1.BackColor = System.Drawing.Color.Gray;
            this.menuStrip1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem,
            this.moreToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(240, 24);
            this.menuStrip1.TabIndex = 52;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.whatCanYouDoToolStripMenuItem,
            this.commandToolStripMenuItem,
            this.reportBugToolStripMenuItem1});
            this.helpToolStripMenuItem.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // whatCanYouDoToolStripMenuItem
            // 
            this.whatCanYouDoToolStripMenuItem.Name = "whatCanYouDoToolStripMenuItem";
            this.whatCanYouDoToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.whatCanYouDoToolStripMenuItem.Text = "&What can you do?";
            this.whatCanYouDoToolStripMenuItem.Click += new System.EventHandler(this.whatCanYouDoToolStripMenuItem_Click);
            // 
            // commandToolStripMenuItem
            // 
            this.commandToolStripMenuItem.Name = "commandToolStripMenuItem";
            this.commandToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.commandToolStripMenuItem.Text = "C&ommand";
            this.commandToolStripMenuItem.Click += new System.EventHandler(this.commandToolStripMenuItem_Click);
            // 
            // reportBugToolStripMenuItem1
            // 
            this.reportBugToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
            this.reportBugToolStripMenuItem1.Name = "reportBugToolStripMenuItem1";
            this.reportBugToolStripMenuItem1.Size = new System.Drawing.Size(164, 22);
            this.reportBugToolStripMenuItem1.Text = "ReportBug";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem1.Text = "QR Barcode";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem2.Text = "Report in Email";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // moreToolStripMenuItem
            // 
            this.moreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cnrToolStripMenuItem,
            this.numberpadColorToolStripMenuItem,
            this.xyzXydecimalToolStripMenuItem,
            this.primeNumberToolStripMenuItem,
            this.gCDAndLCMToolStripMenuItem,
            this.findRandomNumberToolStripMenuItem,
            this.rootAndSquareToolStripMenuItem,
            this.nToolStripMenuItem,
            this.numcounterToolStripMenuItem});
            this.moreToolStripMenuItem.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moreToolStripMenuItem.Name = "moreToolStripMenuItem";
            this.moreToolStripMenuItem.Size = new System.Drawing.Size(119, 20);
            this.moreToolStripMenuItem.Text = "&More Items/Options";
            // 
            // cnrToolStripMenuItem
            // 
            this.cnrToolStripMenuItem.Name = "cnrToolStripMenuItem";
            this.cnrToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.cnrToolStripMenuItem.Text = "&Backgroung color";
            this.cnrToolStripMenuItem.Click += new System.EventHandler(this.cnrToolStripMenuItem_Click);
            // 
            // numberpadColorToolStripMenuItem
            // 
            this.numberpadColorToolStripMenuItem.Name = "numberpadColorToolStripMenuItem";
            this.numberpadColorToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.numberpadColorToolStripMenuItem.Text = "&Numberpad color";
            this.numberpadColorToolStripMenuItem.Click += new System.EventHandler(this.numberpadColorToolStripMenuItem_Click);
            // 
            // xyzXydecimalToolStripMenuItem
            // 
            this.xyzXydecimalToolStripMenuItem.Name = "xyzXydecimalToolStripMenuItem";
            this.xyzXydecimalToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.xyzXydecimalToolStripMenuItem.Text = "&Divisible numbers";
            this.xyzXydecimalToolStripMenuItem.Click += new System.EventHandler(this.xyzXydecimalToolStripMenuItem_Click);
            // 
            // primeNumberToolStripMenuItem
            // 
            this.primeNumberToolStripMenuItem.Name = "primeNumberToolStripMenuItem";
            this.primeNumberToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.primeNumberToolStripMenuItem.Text = "&Prime number";
            this.primeNumberToolStripMenuItem.Click += new System.EventHandler(this.primeNumberToolStripMenuItem_Click);
            // 
            // gCDAndLCMToolStripMenuItem
            // 
            this.gCDAndLCMToolStripMenuItem.Name = "gCDAndLCMToolStripMenuItem";
            this.gCDAndLCMToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.gCDAndLCMToolStripMenuItem.Text = "&GCD and LCM";
            this.gCDAndLCMToolStripMenuItem.Click += new System.EventHandler(this.gCDAndLCMToolStripMenuItem_Click);
            // 
            // findRandomNumberToolStripMenuItem
            // 
            this.findRandomNumberToolStripMenuItem.Name = "findRandomNumberToolStripMenuItem";
            this.findRandomNumberToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.findRandomNumberToolStripMenuItem.Text = "&Find Random number";
            this.findRandomNumberToolStripMenuItem.Click += new System.EventHandler(this.findRandomNumberToolStripMenuItem_Click);
            // 
            // rootAndSquareToolStripMenuItem
            // 
            this.rootAndSquareToolStripMenuItem.Name = "rootAndSquareToolStripMenuItem";
            this.rootAndSquareToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.rootAndSquareToolStripMenuItem.Text = "&Root and Square";
            this.rootAndSquareToolStripMenuItem.Click += new System.EventHandler(this.rootAndSquareToolStripMenuItem_Click);
            // 
            // nToolStripMenuItem
            // 
            this.nToolStripMenuItem.Name = "nToolStripMenuItem";
            this.nToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.nToolStripMenuItem.Text = "n&!";
            this.nToolStripMenuItem.Click += new System.EventHandler(this.nToolStripMenuItem_Click);
            // 
            // numcounterToolStripMenuItem
            // 
            this.numcounterToolStripMenuItem.Name = "numcounterToolStripMenuItem";
            this.numcounterToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.numcounterToolStripMenuItem.Text = "num-co&unter";
            this.numcounterToolStripMenuItem.Click += new System.EventHandler(this.numcounterToolStripMenuItem_Click);
            // 
            // btnrs
            // 
            this.btnrs.BackColor = System.Drawing.Color.Red;
            this.btnrs.Font = new System.Drawing.Font("Lucida Console", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrs.Location = new System.Drawing.Point(141, 319);
            this.btnrs.Name = "btnrs";
            this.btnrs.Size = new System.Drawing.Size(45, 45);
            this.btnrs.TabIndex = 44;
            this.btnrs.Text = "=";
            this.btnrs.UseVisualStyleBackColor = false;
            this.btnrs.Click += new System.EventHandler(this.btnrs_Click);
            // 
            // cmb
            // 
            this.cmb.FormattingEnabled = true;
            this.cmb.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/",
            "min",
            "max ",
            "x^y"});
            this.cmb.Location = new System.Drawing.Point(188, 152);
            this.cmb.Name = "cmb";
            this.cmb.Size = new System.Drawing.Size(71, 21);
            this.cmb.TabIndex = 53;
            this.cmb.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gray;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 29);
            this.label1.TabIndex = 54;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Red;
            this.button5.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(188, 319);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(45, 45);
            this.button5.TabIndex = 58;
            this.button5.Text = "C";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.MediumOrchid;
            this.button6.Enabled = false;
            this.button6.Font = new System.Drawing.Font("Exotc350 DmBd BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(-60, 152);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(343, 25);
            this.button6.TabIndex = 59;
            this.button6.Text = "   SMART CALCULATOR";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.Black;
            this.textBox2.Location = new System.Drawing.Point(6, 84);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(227, 34);
            this.textBox2.TabIndex = 51;
            this.textBox2.Click += new System.EventHandler(this.textbox2_Click);
            // 
            // frmclc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(240, 372);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblresult);
            this.Controls.Add(this.b9);
            this.Controls.Add(this.b0);
            this.Controls.Add(this.b8);
            this.Controls.Add(this.b7);
            this.Controls.Add(this.b6);
            this.Controls.Add(this.b3);
            this.Controls.Add(this.b5);
            this.Controls.Add(this.b4);
            this.Controls.Add(this.b2);
            this.Controls.Add(this.b1);
            this.Controls.Add(this.btntaghsim);
            this.Controls.Add(this.btnzarb);
            this.Controls.Add(this.btnpow);
            this.Controls.Add(this.btnmenha);
            this.Controls.Add(this.btnrs);
            this.Controls.Add(this.btnmin);
            this.Controls.Add(this.btnmax);
            this.Controls.Add(this.btnjame);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frmclc";
            this.ShowIcon = false;
            this.Text = "Smart Calculator";
            this.Load += new System.EventHandler(this.frmclc_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblresult;
        private System.Windows.Forms.Button btntaghsim;
        private System.Windows.Forms.Button btnzarb;
        private System.Windows.Forms.Button btnpow;
        private System.Windows.Forms.Button btnmenha;
        private System.Windows.Forms.Button btnmin;
        private System.Windows.Forms.Button btnmax;
        private System.Windows.Forms.Button btnjame;
        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.Button b2;
        private System.Windows.Forms.Button b4;
        private System.Windows.Forms.Button b5;
        private System.Windows.Forms.Button b3;
        private System.Windows.Forms.Button b6;
        private System.Windows.Forms.Button b7;
        private System.Windows.Forms.Button b8;
        private System.Windows.Forms.Button b9;
        private System.Windows.Forms.Button b0;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem moreToolStripMenuItem;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button btnrs;
        private System.Windows.Forms.ComboBox cmb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem whatCanYouDoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem commandToolStripMenuItem;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.ToolStripMenuItem cnrToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xyzXydecimalToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ToolStripMenuItem primeNumberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem numberpadColorToolStripMenuItem;
        private System.Windows.Forms.ColorDialog colorDialog2;
        private System.Windows.Forms.ToolStripMenuItem gCDAndLCMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findRandomNumberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rootAndSquareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportBugToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem nToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem numcounterToolStripMenuItem;
    }
}