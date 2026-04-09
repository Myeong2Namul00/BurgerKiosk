namespace BurgerKiosk
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitle = new Label();
            boxBurgerSel = new GroupBox();
            picChicken = new PictureBox();
            picBulgogi = new PictureBox();
            picHamburger = new PictureBox();
            rbtnChicken = new RadioButton();
            rbtnBulgogi = new RadioButton();
            rbtnHamburger = new RadioButton();
            boxSide = new GroupBox();
            chkCheese = new CheckBox();
            chkSauce = new CheckBox();
            chkCoke = new CheckBox();
            chkFries = new CheckBox();
            boxList = new GroupBox();
            lblTotal = new Label();
            lstOrder = new ListBox();
            btnOrder = new Button();
            btnReset = new Button();
            lblKeyHelp = new Label();
            boxBurgerSel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picChicken).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBulgogi).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picHamburger).BeginInit();
            boxSide.SuspendLayout();
            boxList.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("나눔고딕", 48F, FontStyle.Bold, GraphicsUnit.Point, 129);
            lblTitle.Location = new Point(28, 26);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(550, 74);
            lblTitle.TabIndex = 6;
            lblTitle.Text = "버거 주문 키오스크";
            // 
            // boxBurgerSel
            // 
            boxBurgerSel.Controls.Add(picChicken);
            boxBurgerSel.Controls.Add(picBulgogi);
            boxBurgerSel.Controls.Add(picHamburger);
            boxBurgerSel.Controls.Add(rbtnChicken);
            boxBurgerSel.Controls.Add(rbtnBulgogi);
            boxBurgerSel.Controls.Add(rbtnHamburger);
            boxBurgerSel.FlatStyle = FlatStyle.Flat;
            boxBurgerSel.Font = new Font("나눔고딕", 24F, FontStyle.Bold, GraphicsUnit.Point, 129);
            boxBurgerSel.ForeColor = Color.Red;
            boxBurgerSel.Location = new Point(31, 116);
            boxBurgerSel.Name = "boxBurgerSel";
            boxBurgerSel.Size = new Size(422, 535);
            boxBurgerSel.TabIndex = 0;
            boxBurgerSel.TabStop = true;
            boxBurgerSel.Text = "메뉴 선택";
            // 
            // picChicken
            // 
            picChicken.Image = Properties.Resources.chicken;
            picChicken.Location = new Point(281, 374);
            picChicken.Name = "picChicken";
            picChicken.Size = new Size(122, 113);
            picChicken.SizeMode = PictureBoxSizeMode.Zoom;
            picChicken.TabIndex = 5;
            picChicken.TabStop = false;
            // 
            // picBulgogi
            // 
            picBulgogi.Image = Properties.Resources.bulgogi;
            picBulgogi.Location = new Point(281, 229);
            picBulgogi.Name = "picBulgogi";
            picBulgogi.Size = new Size(122, 113);
            picBulgogi.SizeMode = PictureBoxSizeMode.Zoom;
            picBulgogi.TabIndex = 4;
            picBulgogi.TabStop = false;
            // 
            // picHamburger
            // 
            picHamburger.Image = Properties.Resources.hamburger;
            picHamburger.InitialImage = null;
            picHamburger.Location = new Point(281, 83);
            picHamburger.Name = "picHamburger";
            picHamburger.Size = new Size(122, 113);
            picHamburger.SizeMode = PictureBoxSizeMode.Zoom;
            picHamburger.TabIndex = 3;
            picHamburger.TabStop = false;
            // 
            // rbtnChicken
            // 
            rbtnChicken.AutoSize = true;
            rbtnChicken.ForeColor = Color.Black;
            rbtnChicken.Location = new Point(21, 411);
            rbtnChicken.Name = "rbtnChicken";
            rbtnChicken.Size = new Size(157, 40);
            rbtnChicken.TabIndex = 2;
            rbtnChicken.TabStop = true;
            rbtnChicken.Text = "치킨버거";
            rbtnChicken.UseVisualStyleBackColor = true;
            rbtnChicken.CheckedChanged += rbtnChicken_CheckedChanged;
            // 
            // rbtnBulgogi
            // 
            rbtnBulgogi.AutoSize = true;
            rbtnBulgogi.ForeColor = Color.Black;
            rbtnBulgogi.Location = new Point(21, 260);
            rbtnBulgogi.Name = "rbtnBulgogi";
            rbtnBulgogi.Size = new Size(188, 40);
            rbtnBulgogi.TabIndex = 1;
            rbtnBulgogi.TabStop = true;
            rbtnBulgogi.Text = "불고기버거";
            rbtnBulgogi.UseVisualStyleBackColor = true;
            rbtnBulgogi.CheckedChanged += rbtnBulgogi_CheckedChanged;
            // 
            // rbtnHamburger
            // 
            rbtnHamburger.AutoSize = true;
            rbtnHamburger.ForeColor = Color.Black;
            rbtnHamburger.Location = new Point(21, 117);
            rbtnHamburger.Name = "rbtnHamburger";
            rbtnHamburger.Size = new Size(126, 40);
            rbtnHamburger.TabIndex = 0;
            rbtnHamburger.TabStop = true;
            rbtnHamburger.Text = "햄버거";
            rbtnHamburger.UseVisualStyleBackColor = true;
            rbtnHamburger.CheckedChanged += rbtnHamburger_CheckedChanged;
            // 
            // boxSide
            // 
            boxSide.Controls.Add(chkCheese);
            boxSide.Controls.Add(chkSauce);
            boxSide.Controls.Add(chkCoke);
            boxSide.Controls.Add(chkFries);
            boxSide.FlatStyle = FlatStyle.Flat;
            boxSide.Font = new Font("나눔고딕", 24F, FontStyle.Bold, GraphicsUnit.Point, 129);
            boxSide.ForeColor = Color.Red;
            boxSide.Location = new Point(472, 116);
            boxSide.Name = "boxSide";
            boxSide.Size = new Size(340, 436);
            boxSide.TabIndex = 1;
            boxSide.TabStop = false;
            boxSide.Text = "추가 옵션";
            // 
            // chkCheese
            // 
            chkCheese.AutoSize = true;
            chkCheese.ForeColor = Color.Black;
            chkCheese.Location = new Point(26, 260);
            chkCheese.Name = "chkCheese";
            chkCheese.Size = new Size(168, 40);
            chkCheese.TabIndex = 3;
            chkCheese.Text = "치즈 추가";
            chkCheese.UseVisualStyleBackColor = true;
            chkCheese.CheckedChanged += chkCheese_CheckedChanged;
            // 
            // chkSauce
            // 
            chkSauce.AutoSize = true;
            chkSauce.ForeColor = Color.Black;
            chkSauce.Location = new Point(26, 348);
            chkSauce.Name = "chkSauce";
            chkSauce.Size = new Size(168, 40);
            chkSauce.TabIndex = 0;
            chkSauce.Text = "소스 추가";
            chkSauce.UseVisualStyleBackColor = true;
            chkSauce.CheckedChanged += chkSauce_CheckedChanged;
            // 
            // chkCoke
            // 
            chkCoke.AutoSize = true;
            chkCoke.ForeColor = Color.Black;
            chkCoke.Location = new Point(26, 166);
            chkCoke.Name = "chkCoke";
            chkCoke.Size = new Size(96, 40);
            chkCoke.TabIndex = 2;
            chkCoke.Text = "콜라";
            chkCoke.UseVisualStyleBackColor = true;
            chkCoke.CheckedChanged += chkCoke_CheckedChanged;
            // 
            // chkFries
            // 
            chkFries.AutoSize = true;
            chkFries.ForeColor = Color.Black;
            chkFries.Location = new Point(26, 70);
            chkFries.Name = "chkFries";
            chkFries.Size = new Size(158, 40);
            chkFries.TabIndex = 1;
            chkFries.Text = "감자튀김";
            chkFries.UseVisualStyleBackColor = true;
            chkFries.CheckedChanged += chkFries_CheckedChanged;
            // 
            // boxList
            // 
            boxList.Controls.Add(lblTotal);
            boxList.Controls.Add(lstOrder);
            boxList.FlatStyle = FlatStyle.Flat;
            boxList.Font = new Font("나눔고딕", 24F, FontStyle.Bold, GraphicsUnit.Point, 129);
            boxList.ForeColor = Color.Red;
            boxList.Location = new Point(827, 116);
            boxList.Name = "boxList";
            boxList.Size = new Size(406, 436);
            boxList.TabIndex = 2;
            boxList.TabStop = false;
            boxList.Text = "주문 내역";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("나눔고딕", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
            lblTotal.ForeColor = Color.Black;
            lblTotal.Location = new Point(9, 389);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(136, 34);
            lblTotal.TabIndex = 1;
            lblTotal.Text = "주문 금액";
            // 
            // lstOrder
            // 
            lstOrder.BorderStyle = BorderStyle.FixedSingle;
            lstOrder.FormattingEnabled = true;
            lstOrder.Location = new Point(26, 49);
            lstOrder.Name = "lstOrder";
            lstOrder.Size = new Size(347, 326);
            lstOrder.TabIndex = 0;
            // 
            // btnOrder
            // 
            btnOrder.BackColor = Color.FromArgb(192, 255, 192);
            btnOrder.FlatStyle = FlatStyle.Flat;
            btnOrder.Font = new Font("나눔고딕", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnOrder.ForeColor = Color.Black;
            btnOrder.Location = new Point(827, 567);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(406, 84);
            btnOrder.TabIndex = 4;
            btnOrder.Text = "주문하기";
            btnOrder.UseVisualStyleBackColor = false;
            btnOrder.Click += btnOrder_Click;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.FromArgb(255, 192, 192);
            btnReset.FlatStyle = FlatStyle.Flat;
            btnReset.Font = new Font("나눔고딕", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnReset.ForeColor = Color.Black;
            btnReset.Location = new Point(472, 567);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(340, 84);
            btnReset.TabIndex = 3;
            btnReset.Text = "초기화";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // lblKeyHelp
            // 
            lblKeyHelp.AutoSize = true;
            lblKeyHelp.Font = new Font("나눔고딕", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
            lblKeyHelp.Location = new Point(985, 9);
            lblKeyHelp.Name = "lblKeyHelp";
            lblKeyHelp.Size = new Size(143, 24);
            lblKeyHelp.TabIndex = 1;
            lblKeyHelp.Text = "도움말 텍스트";
            lblKeyHelp.TextAlign = ContentAlignment.TopRight;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(1264, 681);
            Controls.Add(lblKeyHelp);
            Controls.Add(btnReset);
            Controls.Add(btnOrder);
            Controls.Add(boxList);
            Controls.Add(boxSide);
            Controls.Add(boxBurgerSel);
            Controls.Add(lblTitle);
            Name = "Form1";
            Text = "BurgerKiosk";
            Load += Form1_Load;
            KeyDown += Form1_KeyDown;
            boxBurgerSel.ResumeLayout(false);
            boxBurgerSel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picChicken).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBulgogi).EndInit();
            ((System.ComponentModel.ISupportInitialize)picHamburger).EndInit();
            boxSide.ResumeLayout(false);
            boxSide.PerformLayout();
            boxList.ResumeLayout(false);
            boxList.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private GroupBox boxBurgerSel;
        private RadioButton rbtnChicken;
        private RadioButton rbtnBulgogi;
        private RadioButton rbtnHamburger;
        private GroupBox boxSide;
        private GroupBox boxList;
        private PictureBox picChicken;
        private PictureBox picBulgogi;
        private PictureBox picHamburger;
        private CheckBox chkCheese;
        private CheckBox chkSauce;
        private CheckBox chkCoke;
        private CheckBox chkFries;
        private Label lblTotal;
        private ListBox lstOrder;
        private Button btnOrder;
        private Button btnReset;
        private Label lblKeyHelp;
    }
}
