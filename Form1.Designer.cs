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
            boxList = new GroupBox();
            chkFries = new CheckBox();
            chkCoke = new CheckBox();
            chkSauce = new CheckBox();
            chkCheese = new CheckBox();
            lstResult = new ListBox();
            lblTotal = new Label();
            btnOrder = new Button();
            btnReset = new Button();
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
            lblTitle.TabIndex = 0;
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
            boxBurgerSel.TabIndex = 1;
            boxBurgerSel.TabStop = false;
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
            boxSide.TabIndex = 2;
            boxSide.TabStop = false;
            boxSide.Text = "추가 옵션";
            // 
            // boxList
            // 
            boxList.Controls.Add(lblTotal);
            boxList.Controls.Add(lstResult);
            boxList.FlatStyle = FlatStyle.Flat;
            boxList.Font = new Font("나눔고딕", 24F, FontStyle.Bold, GraphicsUnit.Point, 129);
            boxList.ForeColor = Color.Red;
            boxList.Location = new Point(827, 116);
            boxList.Name = "boxList";
            boxList.Size = new Size(406, 436);
            boxList.TabIndex = 3;
            boxList.TabStop = false;
            boxList.Text = "주문 내역";
            // 
            // chkFries
            // 
            chkFries.AutoSize = true;
            chkFries.ForeColor = Color.Black;
            chkFries.Location = new Point(26, 70);
            chkFries.Name = "chkFries";
            chkFries.Size = new Size(158, 40);
            chkFries.TabIndex = 0;
            chkFries.Text = "감자튀김";
            chkFries.UseVisualStyleBackColor = true;
            // 
            // chkCoke
            // 
            chkCoke.AutoSize = true;
            chkCoke.ForeColor = Color.Black;
            chkCoke.Location = new Point(26, 166);
            chkCoke.Name = "chkCoke";
            chkCoke.Size = new Size(96, 40);
            chkCoke.TabIndex = 1;
            chkCoke.Text = "콜라";
            chkCoke.UseVisualStyleBackColor = true;
            // 
            // chkSauce
            // 
            chkSauce.AutoSize = true;
            chkSauce.ForeColor = Color.Black;
            chkSauce.Location = new Point(26, 348);
            chkSauce.Name = "chkSauce";
            chkSauce.Size = new Size(168, 40);
            chkSauce.TabIndex = 2;
            chkSauce.Text = "소스 추가";
            chkSauce.UseVisualStyleBackColor = true;
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
            // 
            // lstResult
            // 
            lstResult.BorderStyle = BorderStyle.FixedSingle;
            lstResult.FormattingEnabled = true;
            lstResult.Location = new Point(26, 49);
            lstResult.Name = "lstResult";
            lstResult.Size = new Size(347, 290);
            lstResult.TabIndex = 0;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("나눔고딕", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
            lblTotal.Location = new Point(26, 363);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(174, 43);
            lblTotal.TabIndex = 1;
            lblTotal.Text = "주문 금액";
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
            btnReset.TabIndex = 5;
            btnReset.Text = "초기화";
            btnReset.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(1264, 681);
            Controls.Add(btnReset);
            Controls.Add(btnOrder);
            Controls.Add(boxList);
            Controls.Add(boxSide);
            Controls.Add(boxBurgerSel);
            Controls.Add(lblTitle);
            Name = "Form1";
            Text = "BurgerKiosk";
            Load += Form1_Load;
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
        private ListBox lstResult;
        private Button btnOrder;
        private Button btnReset;
    }
}
