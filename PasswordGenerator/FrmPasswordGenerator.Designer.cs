namespace PasswordGenerator
{
	partial class frmPasswordGenerator
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
			this.btnGeneratePassword = new System.Windows.Forms.Button();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.grpAddlSpecChars = new System.Windows.Forms.GroupBox();
			this.chk58 = new System.Windows.Forms.CheckBox();
			this.chk47 = new System.Windows.Forms.CheckBox();
			this.chk126 = new System.Windows.Forms.CheckBox();
			this.chk125 = new System.Windows.Forms.CheckBox();
			this.chk93 = new System.Windows.Forms.CheckBox();
			this.chk43 = new System.Windows.Forms.CheckBox();
			this.chk124 = new System.Windows.Forms.CheckBox();
			this.chk123 = new System.Windows.Forms.CheckBox();
			this.chk63 = new System.Windows.Forms.CheckBox();
			this.chk45 = new System.Windows.Forms.CheckBox();
			this.chk91 = new System.Windows.Forms.CheckBox();
			this.chk96 = new System.Windows.Forms.CheckBox();
			this.chk34 = new System.Windows.Forms.CheckBox();
			this.chk95 = new System.Windows.Forms.CheckBox();
			this.chk39 = new System.Windows.Forms.CheckBox();
			this.chk92 = new System.Windows.Forms.CheckBox();
			this.chk61 = new System.Windows.Forms.CheckBox();
			this.chk62 = new System.Windows.Forms.CheckBox();
			this.chk46 = new System.Windows.Forms.CheckBox();
			this.chk44 = new System.Windows.Forms.CheckBox();
			this.chk60 = new System.Windows.Forms.CheckBox();
			this.chk59 = new System.Windows.Forms.CheckBox();
			this.chk33 = new System.Windows.Forms.CheckBox();
			this.chk42 = new System.Windows.Forms.CheckBox();
			this.chk38 = new System.Windows.Forms.CheckBox();
			this.chk37 = new System.Windows.Forms.CheckBox();
			this.chk36 = new System.Windows.Forms.CheckBox();
			this.chk40 = new System.Windows.Forms.CheckBox();
			this.chk35 = new System.Windows.Forms.CheckBox();
			this.chk41 = new System.Windows.Forms.CheckBox();
			this.chk94 = new System.Windows.Forms.CheckBox();
			this.chk64 = new System.Windows.Forms.CheckBox();
			this.grpCommonSpecChars = new System.Windows.Forms.GroupBox();
			this.rbAllSpecChars = new System.Windows.Forms.RadioButton();
			this.rbCommonSpecChars = new System.Windows.Forms.RadioButton();
			this.rbCustomSpecChars = new System.Windows.Forms.RadioButton();
			this.rbNoSpecChars = new System.Windows.Forms.RadioButton();
			this.panel1 = new System.Windows.Forms.Panel();
			this.txtMaxLen = new System.Windows.Forms.TextBox();
			this.txtMinLen = new System.Windows.Forms.TextBox();
			this.chkIsTroll = new System.Windows.Forms.CheckBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.grpAddlSpecChars.SuspendLayout();
			this.grpCommonSpecChars.SuspendLayout();
			this.panel1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnGeneratePassword
			// 
			this.btnGeneratePassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnGeneratePassword.Location = new System.Drawing.Point(143, 458);
			this.btnGeneratePassword.Name = "btnGeneratePassword";
			this.btnGeneratePassword.Size = new System.Drawing.Size(144, 43);
			this.btnGeneratePassword.TabIndex = 0;
			this.btnGeneratePassword.Text = "Generate Password";
			this.btnGeneratePassword.UseVisualStyleBackColor = true;
			this.btnGeneratePassword.Click += new System.EventHandler(this.btnGeneratePassword_Click);
			// 
			// txtPassword
			// 
			this.txtPassword.Location = new System.Drawing.Point(143, 26);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.Size = new System.Drawing.Size(253, 27);
			this.txtPassword.TabIndex = 1;
			this.txtPassword.Click += new System.EventHandler(this.Common_SelectAll);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(33, 57);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(86, 20);
			this.label1.TabIndex = 4;
			this.label1.Text = "Min Length:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(197, 57);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(89, 20);
			this.label2.TabIndex = 5;
			this.label2.Text = "Max Length:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(33, 29);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(107, 20);
			this.label3.TabIndex = 6;
			this.label3.Text = "New Password:";
			// 
			// grpAddlSpecChars
			// 
			this.grpAddlSpecChars.Controls.Add(this.chk58);
			this.grpAddlSpecChars.Controls.Add(this.chk47);
			this.grpAddlSpecChars.Controls.Add(this.chk126);
			this.grpAddlSpecChars.Controls.Add(this.chk125);
			this.grpAddlSpecChars.Controls.Add(this.chk93);
			this.grpAddlSpecChars.Controls.Add(this.chk43);
			this.grpAddlSpecChars.Controls.Add(this.chk124);
			this.grpAddlSpecChars.Controls.Add(this.chk123);
			this.grpAddlSpecChars.Controls.Add(this.chk63);
			this.grpAddlSpecChars.Controls.Add(this.chk45);
			this.grpAddlSpecChars.Controls.Add(this.chk91);
			this.grpAddlSpecChars.Controls.Add(this.chk96);
			this.grpAddlSpecChars.Controls.Add(this.chk34);
			this.grpAddlSpecChars.Controls.Add(this.chk95);
			this.grpAddlSpecChars.Controls.Add(this.chk39);
			this.grpAddlSpecChars.Controls.Add(this.chk92);
			this.grpAddlSpecChars.Controls.Add(this.chk61);
			this.grpAddlSpecChars.Controls.Add(this.chk62);
			this.grpAddlSpecChars.Controls.Add(this.chk46);
			this.grpAddlSpecChars.Controls.Add(this.chk44);
			this.grpAddlSpecChars.Controls.Add(this.chk60);
			this.grpAddlSpecChars.Controls.Add(this.chk59);
			this.grpAddlSpecChars.Location = new System.Drawing.Point(36, 342);
			this.grpAddlSpecChars.Name = "grpAddlSpecChars";
			this.grpAddlSpecChars.Size = new System.Drawing.Size(360, 107);
			this.grpAddlSpecChars.TabIndex = 7;
			this.grpAddlSpecChars.TabStop = false;
			this.grpAddlSpecChars.Text = "Additional Special Characters";
			// 
			// chk58
			// 
			this.chk58.AutoSize = true;
			this.chk58.Checked = true;
			this.chk58.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chk58.Location = new System.Drawing.Point(314, 21);
			this.chk58.Name = "chk58";
			this.chk58.Size = new System.Drawing.Size(34, 24);
			this.chk58.TabIndex = 22;
			this.chk58.Text = ":";
			this.chk58.UseVisualStyleBackColor = true;
			this.chk58.Click += new System.EventHandler(this.chkSC_Click);
			// 
			// chk47
			// 
			this.chk47.AutoSize = true;
			this.chk47.Checked = true;
			this.chk47.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chk47.Location = new System.Drawing.Point(274, 21);
			this.chk47.Name = "chk47";
			this.chk47.Size = new System.Drawing.Size(37, 24);
			this.chk47.TabIndex = 31;
			this.chk47.Text = "/";
			this.chk47.UseVisualStyleBackColor = true;
			this.chk47.Click += new System.EventHandler(this.chkSC_Click);
			// 
			// chk126
			// 
			this.chk126.AutoSize = true;
			this.chk126.Checked = true;
			this.chk126.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chk126.Location = new System.Drawing.Point(274, 75);
			this.chk126.Name = "chk126";
			this.chk126.Size = new System.Drawing.Size(41, 24);
			this.chk126.TabIndex = 0;
			this.chk126.Text = "~";
			this.chk126.UseVisualStyleBackColor = true;
			this.chk126.Click += new System.EventHandler(this.chkSC_Click);
			// 
			// chk125
			// 
			this.chk125.AutoSize = true;
			this.chk125.Checked = true;
			this.chk125.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chk125.Location = new System.Drawing.Point(233, 75);
			this.chk125.Name = "chk125";
			this.chk125.Size = new System.Drawing.Size(36, 24);
			this.chk125.TabIndex = 19;
			this.chk125.Text = "}";
			this.chk125.UseVisualStyleBackColor = true;
			this.chk125.Click += new System.EventHandler(this.chkSC_Click);
			// 
			// chk93
			// 
			this.chk93.AutoSize = true;
			this.chk93.Checked = true;
			this.chk93.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chk93.Location = new System.Drawing.Point(6, 75);
			this.chk93.Name = "chk93";
			this.chk93.Size = new System.Drawing.Size(36, 24);
			this.chk93.TabIndex = 21;
			this.chk93.Text = "]";
			this.chk93.UseVisualStyleBackColor = true;
			this.chk93.Click += new System.EventHandler(this.chkSC_Click);
			// 
			// chk43
			// 
			this.chk43.AutoSize = true;
			this.chk43.Checked = true;
			this.chk43.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chk43.Location = new System.Drawing.Point(101, 21);
			this.chk43.Name = "chk43";
			this.chk43.Size = new System.Drawing.Size(41, 24);
			this.chk43.TabIndex = 11;
			this.chk43.Text = "+";
			this.chk43.UseVisualStyleBackColor = true;
			this.chk43.Click += new System.EventHandler(this.chkSC_Click);
			// 
			// chk124
			// 
			this.chk124.AutoSize = true;
			this.chk124.Checked = true;
			this.chk124.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chk124.Location = new System.Drawing.Point(189, 75);
			this.chk124.Name = "chk124";
			this.chk124.Size = new System.Drawing.Size(35, 24);
			this.chk124.TabIndex = 14;
			this.chk124.Text = "|";
			this.chk124.UseVisualStyleBackColor = true;
			this.chk124.Click += new System.EventHandler(this.chkSC_Click);
			// 
			// chk123
			// 
			this.chk123.AutoSize = true;
			this.chk123.Checked = true;
			this.chk123.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chk123.Location = new System.Drawing.Point(145, 75);
			this.chk123.Name = "chk123";
			this.chk123.Size = new System.Drawing.Size(36, 24);
			this.chk123.TabIndex = 18;
			this.chk123.Text = "{";
			this.chk123.UseVisualStyleBackColor = true;
			this.chk123.Click += new System.EventHandler(this.chkSC_Click);
			// 
			// chk63
			// 
			this.chk63.AutoSize = true;
			this.chk63.Checked = true;
			this.chk63.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chk63.Location = new System.Drawing.Point(189, 48);
			this.chk63.Name = "chk63";
			this.chk63.Size = new System.Drawing.Size(38, 24);
			this.chk63.TabIndex = 30;
			this.chk63.Text = "?";
			this.chk63.UseVisualStyleBackColor = true;
			this.chk63.Click += new System.EventHandler(this.chkSC_Click);
			// 
			// chk45
			// 
			this.chk45.AutoSize = true;
			this.chk45.Checked = true;
			this.chk45.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chk45.Location = new System.Drawing.Point(189, 21);
			this.chk45.Name = "chk45";
			this.chk45.Size = new System.Drawing.Size(37, 24);
			this.chk45.TabIndex = 10;
			this.chk45.Text = "-";
			this.chk45.UseVisualStyleBackColor = true;
			this.chk45.Click += new System.EventHandler(this.chkSC_Click);
			// 
			// chk91
			// 
			this.chk91.AutoSize = true;
			this.chk91.Checked = true;
			this.chk91.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chk91.Location = new System.Drawing.Point(233, 48);
			this.chk91.Name = "chk91";
			this.chk91.Size = new System.Drawing.Size(36, 24);
			this.chk91.TabIndex = 20;
			this.chk91.Text = "[";
			this.chk91.UseVisualStyleBackColor = true;
			this.chk91.Click += new System.EventHandler(this.chkSC_Click);
			// 
			// chk96
			// 
			this.chk96.AutoSize = true;
			this.chk96.Checked = true;
			this.chk96.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chk96.Location = new System.Drawing.Point(101, 75);
			this.chk96.Name = "chk96";
			this.chk96.Size = new System.Drawing.Size(35, 24);
			this.chk96.TabIndex = 13;
			this.chk96.Text = "`";
			this.chk96.UseVisualStyleBackColor = true;
			this.chk96.Click += new System.EventHandler(this.chkSC_Click);
			// 
			// chk34
			// 
			this.chk34.AutoSize = true;
			this.chk34.Checked = true;
			this.chk34.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chk34.Location = new System.Drawing.Point(6, 21);
			this.chk34.Name = "chk34";
			this.chk34.Size = new System.Drawing.Size(37, 24);
			this.chk34.TabIndex = 24;
			this.chk34.Text = "\"";
			this.chk34.UseVisualStyleBackColor = true;
			this.chk34.Click += new System.EventHandler(this.chkSC_Click);
			// 
			// chk95
			// 
			this.chk95.AutoSize = true;
			this.chk95.Checked = true;
			this.chk95.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chk95.Location = new System.Drawing.Point(51, 75);
			this.chk95.Name = "chk95";
			this.chk95.Size = new System.Drawing.Size(37, 24);
			this.chk95.TabIndex = 9;
			this.chk95.Text = "_";
			this.chk95.UseVisualStyleBackColor = true;
			this.chk95.Click += new System.EventHandler(this.chkSC_Click);
			// 
			// chk39
			// 
			this.chk39.AutoSize = true;
			this.chk39.Checked = true;
			this.chk39.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chk39.Location = new System.Drawing.Point(51, 21);
			this.chk39.Name = "chk39";
			this.chk39.Size = new System.Drawing.Size(34, 24);
			this.chk39.TabIndex = 25;
			this.chk39.Text = "\'";
			this.chk39.UseVisualStyleBackColor = true;
			this.chk39.Click += new System.EventHandler(this.chkSC_Click);
			// 
			// chk92
			// 
			this.chk92.AutoSize = true;
			this.chk92.Checked = true;
			this.chk92.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chk92.Location = new System.Drawing.Point(274, 48);
			this.chk92.Name = "chk92";
			this.chk92.Size = new System.Drawing.Size(37, 24);
			this.chk92.TabIndex = 15;
			this.chk92.Text = "\\";
			this.chk92.UseVisualStyleBackColor = true;
			this.chk92.Click += new System.EventHandler(this.chkSC_Click);
			// 
			// chk61
			// 
			this.chk61.AutoSize = true;
			this.chk61.Checked = true;
			this.chk61.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chk61.Location = new System.Drawing.Point(101, 48);
			this.chk61.Name = "chk61";
			this.chk61.Size = new System.Drawing.Size(41, 24);
			this.chk61.TabIndex = 12;
			this.chk61.Text = "=";
			this.chk61.UseVisualStyleBackColor = true;
			this.chk61.Click += new System.EventHandler(this.chkSC_Click);
			// 
			// chk62
			// 
			this.chk62.AutoSize = true;
			this.chk62.Checked = true;
			this.chk62.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chk62.Location = new System.Drawing.Point(145, 48);
			this.chk62.Name = "chk62";
			this.chk62.Size = new System.Drawing.Size(41, 24);
			this.chk62.TabIndex = 27;
			this.chk62.Text = ">";
			this.chk62.UseVisualStyleBackColor = true;
			this.chk62.Click += new System.EventHandler(this.chkSC_Click);
			// 
			// chk46
			// 
			this.chk46.AutoSize = true;
			this.chk46.Checked = true;
			this.chk46.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chk46.Location = new System.Drawing.Point(233, 21);
			this.chk46.Name = "chk46";
			this.chk46.Size = new System.Drawing.Size(34, 24);
			this.chk46.TabIndex = 29;
			this.chk46.Text = ".";
			this.chk46.UseVisualStyleBackColor = true;
			this.chk46.Click += new System.EventHandler(this.chkSC_Click);
			// 
			// chk44
			// 
			this.chk44.AutoSize = true;
			this.chk44.Checked = true;
			this.chk44.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chk44.Location = new System.Drawing.Point(145, 21);
			this.chk44.Name = "chk44";
			this.chk44.Size = new System.Drawing.Size(34, 24);
			this.chk44.TabIndex = 28;
			this.chk44.Text = ",";
			this.chk44.UseVisualStyleBackColor = true;
			this.chk44.CheckedChanged += new System.EventHandler(this.chk44_CheckedChanged);
			this.chk44.Click += new System.EventHandler(this.chkSC_Click);
			// 
			// chk60
			// 
			this.chk60.AutoSize = true;
			this.chk60.Checked = true;
			this.chk60.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chk60.Location = new System.Drawing.Point(51, 48);
			this.chk60.Name = "chk60";
			this.chk60.Size = new System.Drawing.Size(41, 24);
			this.chk60.TabIndex = 26;
			this.chk60.Text = "<";
			this.chk60.UseVisualStyleBackColor = true;
			this.chk60.Click += new System.EventHandler(this.chkSC_Click);
			// 
			// chk59
			// 
			this.chk59.AutoSize = true;
			this.chk59.Checked = true;
			this.chk59.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chk59.Location = new System.Drawing.Point(6, 48);
			this.chk59.Name = "chk59";
			this.chk59.Size = new System.Drawing.Size(34, 24);
			this.chk59.TabIndex = 23;
			this.chk59.Text = ";";
			this.chk59.UseVisualStyleBackColor = true;
			this.chk59.Click += new System.EventHandler(this.chkSC_Click);
			// 
			// chk33
			// 
			this.chk33.AutoSize = true;
			this.chk33.Checked = true;
			this.chk33.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chk33.Location = new System.Drawing.Point(8, 21);
			this.chk33.Name = "chk33";
			this.chk33.Size = new System.Drawing.Size(35, 24);
			this.chk33.TabIndex = 1;
			this.chk33.Text = "!";
			this.chk33.UseVisualStyleBackColor = true;
			this.chk33.Click += new System.EventHandler(this.chkSC_Click);
			// 
			// chk42
			// 
			this.chk42.AutoSize = true;
			this.chk42.Checked = true;
			this.chk42.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chk42.Location = new System.Drawing.Point(101, 48);
			this.chk42.Name = "chk42";
			this.chk42.Size = new System.Drawing.Size(37, 24);
			this.chk42.TabIndex = 8;
			this.chk42.Text = "*";
			this.chk42.UseVisualStyleBackColor = true;
			this.chk42.Click += new System.EventHandler(this.chkSC_Click);
			// 
			// chk38
			// 
			this.chk38.AutoSize = true;
			this.chk38.Checked = true;
			this.chk38.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chk38.Location = new System.Drawing.Point(51, 48);
			this.chk38.Name = "chk38";
			this.chk38.Size = new System.Drawing.Size(43, 24);
			this.chk38.TabIndex = 7;
			this.chk38.Text = "&&";
			this.chk38.UseVisualStyleBackColor = true;
			this.chk38.Click += new System.EventHandler(this.chkSC_Click);
			// 
			// chk37
			// 
			this.chk37.AutoSize = true;
			this.chk37.Checked = true;
			this.chk37.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chk37.Location = new System.Drawing.Point(189, 21);
			this.chk37.Name = "chk37";
			this.chk37.Size = new System.Drawing.Size(43, 24);
			this.chk37.TabIndex = 5;
			this.chk37.Text = "%";
			this.chk37.UseVisualStyleBackColor = true;
			this.chk37.Click += new System.EventHandler(this.chkSC_Click);
			// 
			// chk36
			// 
			this.chk36.AutoSize = true;
			this.chk36.Checked = true;
			this.chk36.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chk36.Location = new System.Drawing.Point(145, 21);
			this.chk36.Name = "chk36";
			this.chk36.Size = new System.Drawing.Size(39, 24);
			this.chk36.TabIndex = 4;
			this.chk36.Text = "$";
			this.chk36.UseVisualStyleBackColor = true;
			this.chk36.Click += new System.EventHandler(this.chkSC_Click);
			// 
			// chk40
			// 
			this.chk40.AutoSize = true;
			this.chk40.Checked = true;
			this.chk40.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chk40.Location = new System.Drawing.Point(145, 48);
			this.chk40.Name = "chk40";
			this.chk40.Size = new System.Drawing.Size(36, 24);
			this.chk40.TabIndex = 16;
			this.chk40.Text = "(";
			this.chk40.UseVisualStyleBackColor = true;
			this.chk40.Click += new System.EventHandler(this.chkSC_Click);
			// 
			// chk35
			// 
			this.chk35.AutoSize = true;
			this.chk35.Checked = true;
			this.chk35.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chk35.Location = new System.Drawing.Point(101, 21);
			this.chk35.Name = "chk35";
			this.chk35.Size = new System.Drawing.Size(40, 24);
			this.chk35.TabIndex = 3;
			this.chk35.Text = "#";
			this.chk35.UseVisualStyleBackColor = true;
			this.chk35.Click += new System.EventHandler(this.chkSC_Click);
			// 
			// chk41
			// 
			this.chk41.AutoSize = true;
			this.chk41.Checked = true;
			this.chk41.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chk41.Location = new System.Drawing.Point(189, 48);
			this.chk41.Name = "chk41";
			this.chk41.Size = new System.Drawing.Size(36, 24);
			this.chk41.TabIndex = 17;
			this.chk41.Text = ")";
			this.chk41.UseVisualStyleBackColor = true;
			this.chk41.Click += new System.EventHandler(this.chkSC_Click);
			// 
			// chk94
			// 
			this.chk94.AutoSize = true;
			this.chk94.Checked = true;
			this.chk94.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chk94.Location = new System.Drawing.Point(8, 48);
			this.chk94.Name = "chk94";
			this.chk94.Size = new System.Drawing.Size(41, 24);
			this.chk94.TabIndex = 6;
			this.chk94.Text = "^";
			this.chk94.UseVisualStyleBackColor = true;
			this.chk94.Click += new System.EventHandler(this.chkSC_Click);
			// 
			// chk64
			// 
			this.chk64.AutoSize = true;
			this.chk64.Checked = true;
			this.chk64.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chk64.Location = new System.Drawing.Point(51, 21);
			this.chk64.Name = "chk64";
			this.chk64.Size = new System.Drawing.Size(45, 24);
			this.chk64.TabIndex = 2;
			this.chk64.Text = "@";
			this.chk64.UseVisualStyleBackColor = true;
			this.chk64.Click += new System.EventHandler(this.chkSC_Click);
			// 
			// grpCommonSpecChars
			// 
			this.grpCommonSpecChars.Controls.Add(this.chk41);
			this.grpCommonSpecChars.Controls.Add(this.chk33);
			this.grpCommonSpecChars.Controls.Add(this.chk42);
			this.grpCommonSpecChars.Controls.Add(this.chk64);
			this.grpCommonSpecChars.Controls.Add(this.chk35);
			this.grpCommonSpecChars.Controls.Add(this.chk38);
			this.grpCommonSpecChars.Controls.Add(this.chk36);
			this.grpCommonSpecChars.Controls.Add(this.chk40);
			this.grpCommonSpecChars.Controls.Add(this.chk94);
			this.grpCommonSpecChars.Controls.Add(this.chk37);
			this.grpCommonSpecChars.Location = new System.Drawing.Point(36, 254);
			this.grpCommonSpecChars.Name = "grpCommonSpecChars";
			this.grpCommonSpecChars.Size = new System.Drawing.Size(246, 82);
			this.grpCommonSpecChars.TabIndex = 9;
			this.grpCommonSpecChars.TabStop = false;
			this.grpCommonSpecChars.Text = "Common Special Characters";
			// 
			// rbAllSpecChars
			// 
			this.rbAllSpecChars.AutoSize = true;
			this.rbAllSpecChars.Checked = true;
			this.rbAllSpecChars.Location = new System.Drawing.Point(3, 3);
			this.rbAllSpecChars.Name = "rbAllSpecChars";
			this.rbAllSpecChars.Size = new System.Drawing.Size(173, 24);
			this.rbAllSpecChars.TabIndex = 10;
			this.rbAllSpecChars.TabStop = true;
			this.rbAllSpecChars.Text = "All Special Characters";
			this.rbAllSpecChars.UseVisualStyleBackColor = true;
			this.rbAllSpecChars.Click += new System.EventHandler(this.rbAllSpec_Click);
			// 
			// rbCommonSpecChars
			// 
			this.rbCommonSpecChars.AutoSize = true;
			this.rbCommonSpecChars.Location = new System.Drawing.Point(3, 30);
			this.rbCommonSpecChars.Name = "rbCommonSpecChars";
			this.rbCommonSpecChars.Size = new System.Drawing.Size(216, 24);
			this.rbCommonSpecChars.TabIndex = 11;
			this.rbCommonSpecChars.Text = "Common Special Characters";
			this.rbCommonSpecChars.UseVisualStyleBackColor = true;
			this.rbCommonSpecChars.Click += new System.EventHandler(this.rbCommonSpecChars_Click);
			// 
			// rbCustomSpecChars
			// 
			this.rbCustomSpecChars.AutoSize = true;
			this.rbCustomSpecChars.Location = new System.Drawing.Point(3, 57);
			this.rbCustomSpecChars.Name = "rbCustomSpecChars";
			this.rbCustomSpecChars.Size = new System.Drawing.Size(264, 24);
			this.rbCustomSpecChars.TabIndex = 13;
			this.rbCustomSpecChars.TabStop = true;
			this.rbCustomSpecChars.Text = "Custom Special Character Selection";
			this.rbCustomSpecChars.UseVisualStyleBackColor = true;
			this.rbCustomSpecChars.Click += new System.EventHandler(this.rbCustomSpecChars_Click);
			// 
			// rbNoSpecChars
			// 
			this.rbNoSpecChars.AutoSize = true;
			this.rbNoSpecChars.Location = new System.Drawing.Point(3, 84);
			this.rbNoSpecChars.Name = "rbNoSpecChars";
			this.rbNoSpecChars.Size = new System.Drawing.Size(175, 24);
			this.rbNoSpecChars.TabIndex = 12;
			this.rbNoSpecChars.TabStop = true;
			this.rbNoSpecChars.Text = "No Special Characters";
			this.rbNoSpecChars.UseVisualStyleBackColor = true;
			this.rbNoSpecChars.Click += new System.EventHandler(this.rbNoneSpec_Click);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.rbAllSpecChars);
			this.panel1.Controls.Add(this.rbCustomSpecChars);
			this.panel1.Controls.Add(this.rbCommonSpecChars);
			this.panel1.Controls.Add(this.rbNoSpecChars);
			this.panel1.Location = new System.Drawing.Point(36, 82);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(268, 109);
			this.panel1.TabIndex = 14;
			// 
			// txtMaxLen
			// 
			this.txtMaxLen.Location = new System.Drawing.Point(288, 54);
			this.txtMaxLen.MaxLength = 2;
			this.txtMaxLen.Name = "txtMaxLen";
			this.txtMaxLen.Size = new System.Drawing.Size(36, 27);
			this.txtMaxLen.TabIndex = 3;
			this.txtMaxLen.Text = "16";
			this.txtMaxLen.WordWrap = false;
			this.txtMaxLen.Click += new System.EventHandler(this.Common_SelectAll);
			// 
			// txtMinLen
			// 
			this.txtMinLen.Location = new System.Drawing.Point(143, 54);
			this.txtMinLen.MaxLength = 2;
			this.txtMinLen.Name = "txtMinLen";
			this.txtMinLen.Size = new System.Drawing.Size(36, 27);
			this.txtMinLen.TabIndex = 2;
			this.txtMinLen.Text = "8";
			this.txtMinLen.WordWrap = false;
			this.txtMinLen.Click += new System.EventHandler(this.Common_SelectAll);
			// 
			// chkIsTroll
			// 
			this.chkIsTroll.AutoSize = true;
			this.chkIsTroll.Checked = true;
			this.chkIsTroll.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkIsTroll.Location = new System.Drawing.Point(6, 21);
			this.chkIsTroll.Name = "chkIsTroll";
			this.chkIsTroll.Size = new System.Drawing.Size(202, 24);
			this.chkIsTroll.TabIndex = 15;
			this.chkIsTroll.Text = "Troll Data Breach CSV File";
			this.chkIsTroll.UseVisualStyleBackColor = true;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.chkIsTroll);
			this.groupBox1.Location = new System.Drawing.Point(36, 197);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(246, 51);
			this.groupBox1.TabIndex = 16;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Add Comma to Middle of Password";
			// 
			// frmPasswordGenerator
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.ClientSize = new System.Drawing.Size(439, 513);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.grpCommonSpecChars);
			this.Controls.Add(this.grpAddlSpecChars);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtMaxLen);
			this.Controls.Add(this.txtMinLen);
			this.Controls.Add(this.txtPassword);
			this.Controls.Add(this.btnGeneratePassword);
			this.Name = "frmPasswordGenerator";
			this.Text = "Password Generator";
			this.grpAddlSpecChars.ResumeLayout(false);
			this.grpAddlSpecChars.PerformLayout();
			this.grpCommonSpecChars.ResumeLayout(false);
			this.grpCommonSpecChars.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnGeneratePassword;
		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.GroupBox grpAddlSpecChars;
		private System.Windows.Forms.CheckBox chk47;
		private System.Windows.Forms.CheckBox chk33;
		private System.Windows.Forms.CheckBox chk42;
		private System.Windows.Forms.CheckBox chk126;
		private System.Windows.Forms.CheckBox chk38;
		private System.Windows.Forms.CheckBox chk125;
		private System.Windows.Forms.CheckBox chk37;
		private System.Windows.Forms.CheckBox chk93;
		private System.Windows.Forms.CheckBox chk43;
		private System.Windows.Forms.CheckBox chk124;
		private System.Windows.Forms.CheckBox chk36;
		private System.Windows.Forms.CheckBox chk123;
		private System.Windows.Forms.CheckBox chk40;
		private System.Windows.Forms.CheckBox chk63;
		private System.Windows.Forms.CheckBox chk45;
		private System.Windows.Forms.CheckBox chk91;
		private System.Windows.Forms.CheckBox chk35;
		private System.Windows.Forms.CheckBox chk96;
		private System.Windows.Forms.CheckBox chk41;
		private System.Windows.Forms.CheckBox chk34;
		private System.Windows.Forms.CheckBox chk95;
		private System.Windows.Forms.CheckBox chk39;
		private System.Windows.Forms.CheckBox chk92;
		private System.Windows.Forms.CheckBox chk61;
		private System.Windows.Forms.CheckBox chk94;
		private System.Windows.Forms.CheckBox chk64;
		private System.Windows.Forms.CheckBox chk62;
		private System.Windows.Forms.CheckBox chk58;
		private System.Windows.Forms.CheckBox chk46;
		private System.Windows.Forms.CheckBox chk44;
		private System.Windows.Forms.CheckBox chk60;
		private System.Windows.Forms.CheckBox chk59;
		private System.Windows.Forms.GroupBox grpCommonSpecChars;
		private System.Windows.Forms.RadioButton rbAllSpecChars;
		private System.Windows.Forms.RadioButton rbCommonSpecChars;
		private System.Windows.Forms.RadioButton rbCustomSpecChars;
		private System.Windows.Forms.RadioButton rbNoSpecChars;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TextBox txtMaxLen;
		private System.Windows.Forms.TextBox txtMinLen;
		private System.Windows.Forms.CheckBox chkIsTroll;
		private System.Windows.Forms.GroupBox groupBox1;
	}
}