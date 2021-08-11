namespace PLC_Controller
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ManualMoveGrpBox = new System.Windows.Forms.GroupBox();
            this.ManualNoStopRadioBtn = new System.Windows.Forms.RadioButton();
            this.ManualStepDistComboBox = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.ManualStepRadioBox = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label70 = new System.Windows.Forms.Label();
            this.label71 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label65 = new System.Windows.Forms.Label();
            this.ManualXNegBtn = new System.Windows.Forms.Button();
            this.label23 = new System.Windows.Forms.Label();
            this.ManualZNegBtn = new System.Windows.Forms.Button();
            this.ManualYPosBtn = new System.Windows.Forms.Button();
            this.label62 = new System.Windows.Forms.Label();
            this.ManualXPosBtn = new System.Windows.Forms.Button();
            this.ManualYNegBtn = new System.Windows.Forms.Button();
            this.ManualZPosBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ZCurPosTxtBox = new System.Windows.Forms.TextBox();
            this.YCurPosTxtBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.XCurPosTxtBox = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.ManualAsnPosGrpBox = new System.Windows.Forms.GroupBox();
            this.ManualZPosTxtBox = new System.Windows.Forms.TextBox();
            this.label59 = new System.Windows.Forms.Label();
            this.ManualAsnPosMoveBtn = new System.Windows.Forms.Button();
            this.label98 = new System.Windows.Forms.Label();
            this.label97 = new System.Windows.Forms.Label();
            this.ManualYPosTxtBox = new System.Windows.Forms.TextBox();
            this.ManualXPosTxtBox = new System.Windows.Forms.TextBox();
            this.ManualAsnPosRadioBtn = new System.Windows.Forms.RadioButton();
            this.ManualMoveGrpBox.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.ManualAsnPosGrpBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ManualMoveGrpBox
            // 
            this.ManualMoveGrpBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ManualMoveGrpBox.Controls.Add(this.ManualNoStopRadioBtn);
            this.ManualMoveGrpBox.Controls.Add(this.ManualStepDistComboBox);
            this.ManualMoveGrpBox.Controls.Add(this.label18);
            this.ManualMoveGrpBox.Controls.Add(this.ManualStepRadioBox);
            this.ManualMoveGrpBox.Controls.Add(this.groupBox2);
            this.ManualMoveGrpBox.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ManualMoveGrpBox.Location = new System.Drawing.Point(12, 111);
            this.ManualMoveGrpBox.Name = "ManualMoveGrpBox";
            this.ManualMoveGrpBox.Size = new System.Drawing.Size(431, 345);
            this.ManualMoveGrpBox.TabIndex = 24;
            this.ManualMoveGrpBox.TabStop = false;
            // 
            // ManualNoStopRadioBtn
            // 
            this.ManualNoStopRadioBtn.AutoSize = true;
            this.ManualNoStopRadioBtn.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ManualNoStopRadioBtn.Location = new System.Drawing.Point(8, 98);
            this.ManualNoStopRadioBtn.Name = "ManualNoStopRadioBtn";
            this.ManualNoStopRadioBtn.Size = new System.Drawing.Size(104, 28);
            this.ManualNoStopRadioBtn.TabIndex = 167;
            this.ManualNoStopRadioBtn.Text = "連續移動";
            this.ManualNoStopRadioBtn.UseVisualStyleBackColor = true;
            this.ManualNoStopRadioBtn.Click += new System.EventHandler(this.ManualNoStopRadioBtn_Click);
            // 
            // ManualStepDistComboBox
            // 
            this.ManualStepDistComboBox.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ManualStepDistComboBox.FormattingEnabled = true;
            this.ManualStepDistComboBox.Items.AddRange(new object[] {
            "0.001",
            "0.002",
            "0.005",
            "0.01",
            "0.02",
            "0.05",
            "0.1",
            "0.2",
            "0.5",
            "1",
            "2",
            "5",
            "10"});
            this.ManualStepDistComboBox.Location = new System.Drawing.Point(32, 53);
            this.ManualStepDistComboBox.Name = "ManualStepDistComboBox";
            this.ManualStepDistComboBox.Size = new System.Drawing.Size(80, 32);
            this.ManualStepDistComboBox.TabIndex = 166;
            this.ManualStepDistComboBox.Text = "0.005";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label18.Location = new System.Drawing.Point(112, 63);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(30, 16);
            this.label18.TabIndex = 165;
            this.label18.Text = "mm";
            // 
            // ManualStepRadioBox
            // 
            this.ManualStepRadioBox.AutoSize = true;
            this.ManualStepRadioBox.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ManualStepRadioBox.Location = new System.Drawing.Point(6, 26);
            this.ManualStepRadioBox.Name = "ManualStepRadioBox";
            this.ManualStepRadioBox.Size = new System.Drawing.Size(142, 28);
            this.ManualStepRadioBox.TabIndex = 164;
            this.ManualStepRadioBox.Text = "步進吋動距離";
            this.ManualStepRadioBox.UseVisualStyleBackColor = true;
            this.ManualStepRadioBox.Click += new System.EventHandler(this.ManualStepRadioBox_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label70);
            this.groupBox2.Controls.Add(this.label71);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.label65);
            this.groupBox2.Controls.Add(this.ManualXNegBtn);
            this.groupBox2.Controls.Add(this.label23);
            this.groupBox2.Controls.Add(this.ManualZNegBtn);
            this.groupBox2.Controls.Add(this.ManualYPosBtn);
            this.groupBox2.Controls.Add(this.label62);
            this.groupBox2.Controls.Add(this.ManualXPosBtn);
            this.groupBox2.Controls.Add(this.ManualYNegBtn);
            this.groupBox2.Controls.Add(this.ManualZPosBtn);
            this.groupBox2.Location = new System.Drawing.Point(154, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(264, 314);
            this.groupBox2.TabIndex = 163;
            this.groupBox2.TabStop = false;
            // 
            // label70
            // 
            this.label70.AutoSize = true;
            this.label70.BackColor = System.Drawing.Color.Transparent;
            this.label70.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label70.Location = new System.Drawing.Point(13, 291);
            this.label70.Name = "label70";
            this.label70.Size = new System.Drawing.Size(51, 20);
            this.label70.TabIndex = 153;
            this.label70.Text = "Y向外";
            // 
            // label71
            // 
            this.label71.AutoSize = true;
            this.label71.BackColor = System.Drawing.Color.Transparent;
            this.label71.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label71.Location = new System.Drawing.Point(185, 19);
            this.label71.Name = "label71";
            this.label71.Size = new System.Drawing.Size(51, 20);
            this.label71.TabIndex = 154;
            this.label71.Text = "Y向內";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label19.Location = new System.Drawing.Point(12, 105);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(51, 20);
            this.label19.TabIndex = 149;
            this.label19.Text = "X向左";
            // 
            // label65
            // 
            this.label65.AutoSize = true;
            this.label65.BackColor = System.Drawing.Color.Transparent;
            this.label65.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label65.Location = new System.Drawing.Point(113, 289);
            this.label65.Name = "label65";
            this.label65.Size = new System.Drawing.Size(51, 20);
            this.label65.TabIndex = 152;
            this.label65.Text = "Z向下";
            // 
            // ManualXNegBtn
            // 
            this.ManualXNegBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ManualXNegBtn.BackgroundImage")));
            this.ManualXNegBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ManualXNegBtn.Location = new System.Drawing.Point(16, 126);
            this.ManualXNegBtn.Name = "ManualXNegBtn";
            this.ManualXNegBtn.Size = new System.Drawing.Size(77, 80);
            this.ManualXNegBtn.TabIndex = 17;
            this.ManualXNegBtn.UseVisualStyleBackColor = true;
            this.ManualXNegBtn.Click += new System.EventHandler(this.ManualXNegBtn_Click);
            this.ManualXNegBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ManualXNegBtn_MouseDown);
            this.ManualXNegBtn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ManualXNegBtn_MouseUp);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.Transparent;
            this.label23.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label23.Location = new System.Drawing.Point(185, 209);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(51, 20);
            this.label23.TabIndex = 150;
            this.label23.Text = "X向右";
            // 
            // ManualZNegBtn
            // 
            this.ManualZNegBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ManualZNegBtn.BackgroundImage")));
            this.ManualZNegBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ManualZNegBtn.Location = new System.Drawing.Point(90, 42);
            this.ManualZNegBtn.Name = "ManualZNegBtn";
            this.ManualZNegBtn.Size = new System.Drawing.Size(77, 80);
            this.ManualZNegBtn.TabIndex = 148;
            this.ManualZNegBtn.UseVisualStyleBackColor = true;
            this.ManualZNegBtn.Click += new System.EventHandler(this.ManualZNegBtn_Click);
            this.ManualZNegBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ManualZNegBtn_MouseDown);
            this.ManualZNegBtn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ManualZNegBtn_MouseUp);
            // 
            // ManualYPosBtn
            // 
            this.ManualYPosBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ManualYPosBtn.BackgroundImage")));
            this.ManualYPosBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ManualYPosBtn.Location = new System.Drawing.Point(173, 40);
            this.ManualYPosBtn.Name = "ManualYPosBtn";
            this.ManualYPosBtn.Size = new System.Drawing.Size(77, 80);
            this.ManualYPosBtn.TabIndex = 15;
            this.ManualYPosBtn.UseVisualStyleBackColor = true;
            this.ManualYPosBtn.Click += new System.EventHandler(this.ManualYPosBtn_Click);
            this.ManualYPosBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ManualYPosBtn_MouseDown);
            this.ManualYPosBtn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ManualYPosBtn_MouseUp);
            // 
            // label62
            // 
            this.label62.AutoSize = true;
            this.label62.BackColor = System.Drawing.Color.Transparent;
            this.label62.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label62.Location = new System.Drawing.Point(105, 18);
            this.label62.Name = "label62";
            this.label62.Size = new System.Drawing.Size(51, 20);
            this.label62.TabIndex = 151;
            this.label62.Text = "Z向上";
            // 
            // ManualXPosBtn
            // 
            this.ManualXPosBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ManualXPosBtn.BackgroundImage")));
            this.ManualXPosBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ManualXPosBtn.Location = new System.Drawing.Point(173, 126);
            this.ManualXPosBtn.Name = "ManualXPosBtn";
            this.ManualXPosBtn.Size = new System.Drawing.Size(77, 80);
            this.ManualXPosBtn.TabIndex = 16;
            this.ManualXPosBtn.UseVisualStyleBackColor = true;
            this.ManualXPosBtn.Click += new System.EventHandler(this.ManualXPosBtn_Click);
            this.ManualXPosBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ManualXPosBtn_MouseClick);
            this.ManualXPosBtn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ManualXPosBtn_MouseUp);
            // 
            // ManualYNegBtn
            // 
            this.ManualYNegBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ManualYNegBtn.BackgroundImage")));
            this.ManualYNegBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ManualYNegBtn.Location = new System.Drawing.Point(16, 209);
            this.ManualYNegBtn.Name = "ManualYNegBtn";
            this.ManualYNegBtn.Size = new System.Drawing.Size(77, 80);
            this.ManualYNegBtn.TabIndex = 18;
            this.ManualYNegBtn.UseVisualStyleBackColor = true;
            this.ManualYNegBtn.Click += new System.EventHandler(this.ManualYNegBtn_Click);
            this.ManualYNegBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ManualYNegBtn_MouseDown);
            this.ManualYNegBtn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ManualYNegBtn_MouseUp);
            // 
            // ManualZPosBtn
            // 
            this.ManualZPosBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ManualZPosBtn.BackgroundImage")));
            this.ManualZPosBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ManualZPosBtn.Location = new System.Drawing.Point(99, 209);
            this.ManualZPosBtn.Name = "ManualZPosBtn";
            this.ManualZPosBtn.Size = new System.Drawing.Size(77, 80);
            this.ManualZPosBtn.TabIndex = 147;
            this.ManualZPosBtn.UseVisualStyleBackColor = true;
            this.ManualZPosBtn.Click += new System.EventHandler(this.ManualZPosBtn_Click);
            this.ManualZPosBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ManualZPosBtn_MouseDown);
            this.ManualZPosBtn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ManualZPosBtn_MouseUp);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ZCurPosTxtBox);
            this.groupBox1.Controls.Add(this.YCurPosTxtBox);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.XCurPosTxtBox);
            this.groupBox1.Controls.Add(this.label28);
            this.groupBox1.Location = new System.Drawing.Point(12, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(821, 100);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            // 
            // ZCurPosTxtBox
            // 
            this.ZCurPosTxtBox.BackColor = System.Drawing.SystemColors.Window;
            this.ZCurPosTxtBox.Font = new System.Drawing.Font("Microsoft JhengHei", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ZCurPosTxtBox.Location = new System.Drawing.Point(571, 16);
            this.ZCurPosTxtBox.Name = "ZCurPosTxtBox";
            this.ZCurPosTxtBox.ReadOnly = true;
            this.ZCurPosTxtBox.Size = new System.Drawing.Size(216, 71);
            this.ZCurPosTxtBox.TabIndex = 195;
            this.ZCurPosTxtBox.Text = "0";
            // 
            // YCurPosTxtBox
            // 
            this.YCurPosTxtBox.BackColor = System.Drawing.SystemColors.Window;
            this.YCurPosTxtBox.Font = new System.Drawing.Font("Microsoft JhengHei", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.YCurPosTxtBox.Location = new System.Drawing.Point(323, 16);
            this.YCurPosTxtBox.Name = "YCurPosTxtBox";
            this.YCurPosTxtBox.ReadOnly = true;
            this.YCurPosTxtBox.Size = new System.Drawing.Size(216, 71);
            this.YCurPosTxtBox.TabIndex = 194;
            this.YCurPosTxtBox.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft JhengHei", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label10.Location = new System.Drawing.Point(538, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 37);
            this.label10.TabIndex = 193;
            this.label10.Text = "Z";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft JhengHei", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.Location = new System.Drawing.Point(294, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 37);
            this.label9.TabIndex = 192;
            this.label9.Text = "Y";
            // 
            // XCurPosTxtBox
            // 
            this.XCurPosTxtBox.BackColor = System.Drawing.SystemColors.Window;
            this.XCurPosTxtBox.Font = new System.Drawing.Font("Microsoft JhengHei", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.XCurPosTxtBox.Location = new System.Drawing.Point(72, 16);
            this.XCurPosTxtBox.Name = "XCurPosTxtBox";
            this.XCurPosTxtBox.ReadOnly = true;
            this.XCurPosTxtBox.Size = new System.Drawing.Size(216, 71);
            this.XCurPosTxtBox.TabIndex = 191;
            this.XCurPosTxtBox.Text = "0";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft JhengHei", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label28.Location = new System.Drawing.Point(34, 13);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(36, 37);
            this.label28.TabIndex = 190;
            this.label28.Text = "X";
            // 
            // ManualAsnPosGrpBox
            // 
            this.ManualAsnPosGrpBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ManualAsnPosGrpBox.Controls.Add(this.ManualZPosTxtBox);
            this.ManualAsnPosGrpBox.Controls.Add(this.label59);
            this.ManualAsnPosGrpBox.Controls.Add(this.ManualAsnPosMoveBtn);
            this.ManualAsnPosGrpBox.Controls.Add(this.label98);
            this.ManualAsnPosGrpBox.Controls.Add(this.label97);
            this.ManualAsnPosGrpBox.Controls.Add(this.ManualYPosTxtBox);
            this.ManualAsnPosGrpBox.Controls.Add(this.ManualXPosTxtBox);
            this.ManualAsnPosGrpBox.Controls.Add(this.ManualAsnPosRadioBtn);
            this.ManualAsnPosGrpBox.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ManualAsnPosGrpBox.Location = new System.Drawing.Point(449, 125);
            this.ManualAsnPosGrpBox.Name = "ManualAsnPosGrpBox";
            this.ManualAsnPosGrpBox.Size = new System.Drawing.Size(199, 331);
            this.ManualAsnPosGrpBox.TabIndex = 161;
            this.ManualAsnPosGrpBox.TabStop = false;
            this.ManualAsnPosGrpBox.Text = "指定座標";
            // 
            // ManualZPosTxtBox
            // 
            this.ManualZPosTxtBox.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ManualZPosTxtBox.Location = new System.Drawing.Point(61, 141);
            this.ManualZPosTxtBox.Name = "ManualZPosTxtBox";
            this.ManualZPosTxtBox.Size = new System.Drawing.Size(121, 33);
            this.ManualZPosTxtBox.TabIndex = 141;
            this.ManualZPosTxtBox.Text = "100";
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.label59.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label59.Location = new System.Drawing.Point(6, 144);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(50, 24);
            this.label59.TabIndex = 140;
            this.label59.Text = "Z軸 :";
            // 
            // ManualAsnPosMoveBtn
            // 
            this.ManualAsnPosMoveBtn.BackColor = System.Drawing.Color.SteelBlue;
            this.ManualAsnPosMoveBtn.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ManualAsnPosMoveBtn.Location = new System.Drawing.Point(56, 286);
            this.ManualAsnPosMoveBtn.Name = "ManualAsnPosMoveBtn";
            this.ManualAsnPosMoveBtn.Size = new System.Drawing.Size(126, 39);
            this.ManualAsnPosMoveBtn.TabIndex = 139;
            this.ManualAsnPosMoveBtn.Text = "移動";
            this.ManualAsnPosMoveBtn.UseVisualStyleBackColor = false;
            this.ManualAsnPosMoveBtn.Click += new System.EventHandler(this.ManualAsnPosMoveBtn_Click);
            // 
            // label98
            // 
            this.label98.AutoSize = true;
            this.label98.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label98.Location = new System.Drawing.Point(6, 107);
            this.label98.Name = "label98";
            this.label98.Size = new System.Drawing.Size(49, 24);
            this.label98.TabIndex = 25;
            this.label98.Text = "Y軸 :";
            // 
            // label97
            // 
            this.label97.AutoSize = true;
            this.label97.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label97.Location = new System.Drawing.Point(5, 72);
            this.label97.Name = "label97";
            this.label97.Size = new System.Drawing.Size(50, 24);
            this.label97.TabIndex = 24;
            this.label97.Text = "X軸 :";
            // 
            // ManualYPosTxtBox
            // 
            this.ManualYPosTxtBox.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ManualYPosTxtBox.Location = new System.Drawing.Point(61, 102);
            this.ManualYPosTxtBox.Name = "ManualYPosTxtBox";
            this.ManualYPosTxtBox.Size = new System.Drawing.Size(121, 33);
            this.ManualYPosTxtBox.TabIndex = 23;
            this.ManualYPosTxtBox.Text = "-176.271";
            // 
            // ManualXPosTxtBox
            // 
            this.ManualXPosTxtBox.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ManualXPosTxtBox.Location = new System.Drawing.Point(62, 65);
            this.ManualXPosTxtBox.Name = "ManualXPosTxtBox";
            this.ManualXPosTxtBox.Size = new System.Drawing.Size(121, 33);
            this.ManualXPosTxtBox.TabIndex = 22;
            this.ManualXPosTxtBox.Text = "-8.5";
            // 
            // ManualAsnPosRadioBtn
            // 
            this.ManualAsnPosRadioBtn.AutoSize = true;
            this.ManualAsnPosRadioBtn.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ManualAsnPosRadioBtn.Location = new System.Drawing.Point(10, 31);
            this.ManualAsnPosRadioBtn.Name = "ManualAsnPosRadioBtn";
            this.ManualAsnPosRadioBtn.Size = new System.Drawing.Size(104, 28);
            this.ManualAsnPosRadioBtn.TabIndex = 21;
            this.ManualAsnPosRadioBtn.Text = "指定座標";
            this.ManualAsnPosRadioBtn.UseVisualStyleBackColor = true;
            this.ManualAsnPosRadioBtn.Click += new System.EventHandler(this.ManualAsnPosRadioBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 456);
            this.Controls.Add(this.ManualAsnPosGrpBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ManualMoveGrpBox);
            this.Name = "Form1";
            this.Text = "20181213 PLC Controller";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ManualMoveGrpBox.ResumeLayout(false);
            this.ManualMoveGrpBox.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ManualAsnPosGrpBox.ResumeLayout(false);
            this.ManualAsnPosGrpBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox ManualMoveGrpBox;
        private System.Windows.Forms.RadioButton ManualNoStopRadioBtn;
        private System.Windows.Forms.ComboBox ManualStepDistComboBox;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.RadioButton ManualStepRadioBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label70;
        private System.Windows.Forms.Label label71;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label65;
        private System.Windows.Forms.Button ManualXNegBtn;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Button ManualZNegBtn;
        private System.Windows.Forms.Button ManualYPosBtn;
        private System.Windows.Forms.Label label62;
        private System.Windows.Forms.Button ManualXPosBtn;
        private System.Windows.Forms.Button ManualYNegBtn;
        private System.Windows.Forms.Button ManualZPosBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox ZCurPosTxtBox;
        private System.Windows.Forms.TextBox YCurPosTxtBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox XCurPosTxtBox;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.GroupBox ManualAsnPosGrpBox;
        private System.Windows.Forms.TextBox ManualZPosTxtBox;
        private System.Windows.Forms.Label label59;
        private System.Windows.Forms.Button ManualAsnPosMoveBtn;
        private System.Windows.Forms.Label label98;
        private System.Windows.Forms.Label label97;
        private System.Windows.Forms.TextBox ManualYPosTxtBox;
        private System.Windows.Forms.TextBox ManualXPosTxtBox;
        private System.Windows.Forms.RadioButton ManualAsnPosRadioBtn;
    }
}

