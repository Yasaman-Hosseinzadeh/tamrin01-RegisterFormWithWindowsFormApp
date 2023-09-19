namespace WinFormsAppRegister
{
    partial class RegisterForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            FirstNameLabel = new Label();
            LastNameLabel = new Label();
            CellphoneLabel = new Label();
            NatinalcodeLabel = new Label();
            GenderLabel = new Label();
            FirstNameTextBox = new TextBox();
            LastNametextBox = new TextBox();
            CellphoneTextBox = new TextBox();
            NationalcodetextBox = new TextBox();
            FemaleradioButton = new RadioButton();
            MaleradioButton = new RadioButton();
            RegisterButton = new Button();
            RoleLabel = new Label();
            isAdminCheckBox = new CheckBox();
            ManagerSectiontextBox = new TextBox();
            ManagerSectionLabel = new Label();
            ManagerCodeLabel = new Label();
            ManagerCodeTextBox = new NumericUpDown();
            PersonDataGridView = new DataGridView();
            AdminDataGridView = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            OtherRadioButton = new RadioButton();
            UnknownRadioButton = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)ManagerCodeTextBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PersonDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AdminDataGridView).BeginInit();
            SuspendLayout();
            // 
            // FirstNameLabel
            // 
            FirstNameLabel.AutoSize = true;
            FirstNameLabel.Location = new Point(1148, 24);
            FirstNameLabel.Name = "FirstNameLabel";
            FirstNameLabel.Size = new Size(21, 15);
            FirstNameLabel.TabIndex = 0;
            FirstNameLabel.Text = "نام";
            // 
            // LastNameLabel
            // 
            LastNameLabel.AutoSize = true;
            LastNameLabel.Location = new Point(1100, 68);
            LastNameLabel.Name = "LastNameLabel";
            LastNameLabel.Size = new Size(69, 15);
            LastNameLabel.TabIndex = 1;
            LastNameLabel.Text = "نام خانوادگی";
            // 
            // CellphoneLabel
            // 
            CellphoneLabel.AutoSize = true;
            CellphoneLabel.Location = new Point(1076, 114);
            CellphoneLabel.Name = "CellphoneLabel";
            CellphoneLabel.Size = new Size(93, 15);
            CellphoneLabel.TabIndex = 2;
            CellphoneLabel.Text = "شماره تلفن همراه";
            // 
            // NatinalcodeLabel
            // 
            NatinalcodeLabel.AutoSize = true;
            NatinalcodeLabel.Location = new Point(1126, 157);
            NatinalcodeLabel.Name = "NatinalcodeLabel";
            NatinalcodeLabel.Size = new Size(43, 15);
            NatinalcodeLabel.TabIndex = 3;
            NatinalcodeLabel.Text = "کد ملی";
            // 
            // GenderLabel
            // 
            GenderLabel.AutoSize = true;
            GenderLabel.Location = new Point(1126, 211);
            GenderLabel.Name = "GenderLabel";
            GenderLabel.Size = new Size(43, 15);
            GenderLabel.TabIndex = 4;
            GenderLabel.Text = "جنسیت";
            // 
            // FirstNameTextBox
            // 
            FirstNameTextBox.Location = new Point(853, 12);
            FirstNameTextBox.Name = "FirstNameTextBox";
            FirstNameTextBox.Size = new Size(197, 23);
            FirstNameTextBox.TabIndex = 5;
            FirstNameTextBox.TextAlign = HorizontalAlignment.Right;
            // 
            // LastNametextBox
            // 
            LastNametextBox.Location = new Point(853, 60);
            LastNametextBox.Name = "LastNametextBox";
            LastNametextBox.Size = new Size(197, 23);
            LastNametextBox.TabIndex = 6;
            LastNametextBox.TextAlign = HorizontalAlignment.Right;
            // 
            // CellphoneTextBox
            // 
            CellphoneTextBox.Location = new Point(853, 106);
            CellphoneTextBox.Name = "CellphoneTextBox";
            CellphoneTextBox.Size = new Size(197, 23);
            CellphoneTextBox.TabIndex = 7;
            CellphoneTextBox.TextAlign = HorizontalAlignment.Right;
            // 
            // NationalcodetextBox
            // 
            NationalcodetextBox.Location = new Point(853, 149);
            NationalcodetextBox.Name = "NationalcodetextBox";
            NationalcodetextBox.Size = new Size(197, 23);
            NationalcodetextBox.TabIndex = 8;
            NationalcodetextBox.TextAlign = HorizontalAlignment.Right;
            // 
            // FemaleradioButton
            // 
            FemaleradioButton.AutoSize = true;
            FemaleradioButton.Location = new Point(1044, 207);
            FemaleradioButton.Name = "FemaleradioButton";
            FemaleradioButton.Size = new Size(38, 19);
            FemaleradioButton.TabIndex = 9;
            FemaleradioButton.TabStop = true;
            FemaleradioButton.Text = "زن";
            FemaleradioButton.UseVisualStyleBackColor = true;
            // 
            // MaleradioButton
            // 
            MaleradioButton.AutoSize = true;
            MaleradioButton.Location = new Point(982, 207);
            MaleradioButton.Name = "MaleradioButton";
            MaleradioButton.Size = new Size(42, 19);
            MaleradioButton.TabIndex = 10;
            MaleradioButton.TabStop = true;
            MaleradioButton.Text = "مرد";
            MaleradioButton.UseVisualStyleBackColor = true;
            // 
            // RegisterButton
            // 
            RegisterButton.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            RegisterButton.Location = new Point(853, 409);
            RegisterButton.Name = "RegisterButton";
            RegisterButton.Size = new Size(316, 42);
            RegisterButton.TabIndex = 11;
            RegisterButton.Text = "ثبت نام";
            RegisterButton.UseVisualStyleBackColor = true;
            RegisterButton.Click += RegisterButton_Click;
            // 
            // RoleLabel
            // 
            RoleLabel.AutoSize = true;
            RoleLabel.Location = new Point(1138, 262);
            RoleLabel.Name = "RoleLabel";
            RoleLabel.Size = new Size(31, 15);
            RoleLabel.TabIndex = 14;
            RoleLabel.Text = "نقش";
            // 
            // isAdminCheckBox
            // 
            isAdminCheckBox.AutoSize = true;
            isAdminCheckBox.Location = new Point(1035, 262);
            isAdminCheckBox.Name = "isAdminCheckBox";
            isAdminCheckBox.Size = new Size(15, 14);
            isAdminCheckBox.TabIndex = 15;
            isAdminCheckBox.UseVisualStyleBackColor = true;
            isAdminCheckBox.CheckedChanged += isAdminCheckBox_CheckedChanged;
            // 
            // ManagerSectiontextBox
            // 
            ManagerSectiontextBox.Location = new Point(853, 298);
            ManagerSectiontextBox.Name = "ManagerSectiontextBox";
            ManagerSectiontextBox.Size = new Size(197, 23);
            ManagerSectiontextBox.TabIndex = 16;
            ManagerSectiontextBox.TextAlign = HorizontalAlignment.Right;
            // 
            // ManagerSectionLabel
            // 
            ManagerSectionLabel.AutoSize = true;
            ManagerSectionLabel.Location = new Point(1096, 306);
            ManagerSectionLabel.Name = "ManagerSectionLabel";
            ManagerSectionLabel.Size = new Size(73, 15);
            ManagerSectionLabel.TabIndex = 17;
            ManagerSectionLabel.Text = "بخش مدیریت";
            // 
            // ManagerCodeLabel
            // 
            ManagerCodeLabel.AutoSize = true;
            ManagerCodeLabel.Location = new Point(1109, 354);
            ManagerCodeLabel.Name = "ManagerCodeLabel";
            ManagerCodeLabel.Size = new Size(60, 15);
            ManagerCodeLabel.TabIndex = 18;
            ManagerCodeLabel.Text = "کد مدیریت";
            // 
            // ManagerCodeTextBox
            // 
            ManagerCodeTextBox.Location = new Point(853, 346);
            ManagerCodeTextBox.Name = "ManagerCodeTextBox";
            ManagerCodeTextBox.Size = new Size(197, 23);
            ManagerCodeTextBox.TabIndex = 19;
            ManagerCodeTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // PersonDataGridView
            // 
            PersonDataGridView.BackgroundColor = Color.White;
            PersonDataGridView.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.BackColor = Color.LightSkyBlue;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            PersonDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            PersonDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PersonDataGridView.Location = new Point(13, 27);
            PersonDataGridView.Name = "PersonDataGridView";
            PersonDataGridView.RightToLeft = RightToLeft.Yes;
            PersonDataGridView.RowTemplate.Height = 25;
            PersonDataGridView.Size = new Size(806, 191);
            PersonDataGridView.TabIndex = 20;
            // 
            // AdminDataGridView
            // 
            AdminDataGridView.BackgroundColor = Color.White;
            AdminDataGridView.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.LightSkyBlue;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            AdminDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            AdminDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AdminDataGridView.Location = new Point(12, 269);
            AdminDataGridView.Name = "AdminDataGridView";
            AdminDataGridView.RightToLeft = RightToLeft.Yes;
            AdminDataGridView.RowTemplate.Height = 25;
            AdminDataGridView.Size = new Size(806, 182);
            AdminDataGridView.TabIndex = 21;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(747, 238);
            label1.Name = "label1";
            label1.Size = new Size(71, 15);
            label1.TabIndex = 22;
            label1.Text = "لیست مدیران";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(747, 9);
            label2.Name = "label2";
            label2.Size = new Size(72, 15);
            label2.TabIndex = 23;
            label2.Text = "لیست کاربران";
            // 
            // OtherRadioButton
            // 
            OtherRadioButton.AutoSize = true;
            OtherRadioButton.Location = new Point(916, 207);
            OtherRadioButton.Name = "OtherRadioButton";
            OtherRadioButton.Size = new Size(47, 19);
            OtherRadioButton.TabIndex = 24;
            OtherRadioButton.TabStop = true;
            OtherRadioButton.Text = "سایر";
            OtherRadioButton.UseVisualStyleBackColor = true;
            // 
            // UnknownRadioButton
            // 
            UnknownRadioButton.AutoSize = true;
            UnknownRadioButton.Location = new Point(838, 207);
            UnknownRadioButton.Name = "UnknownRadioButton";
            UnknownRadioButton.Size = new Size(72, 19);
            UnknownRadioButton.TabIndex = 25;
            UnknownRadioButton.TabStop = true;
            UnknownRadioButton.Text = "نامشخص";
            UnknownRadioButton.UseVisualStyleBackColor = true;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1193, 707);
            Controls.Add(UnknownRadioButton);
            Controls.Add(OtherRadioButton);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(AdminDataGridView);
            Controls.Add(PersonDataGridView);
            Controls.Add(ManagerCodeTextBox);
            Controls.Add(ManagerCodeLabel);
            Controls.Add(ManagerSectionLabel);
            Controls.Add(ManagerSectiontextBox);
            Controls.Add(isAdminCheckBox);
            Controls.Add(RoleLabel);
            Controls.Add(RegisterButton);
            Controls.Add(MaleradioButton);
            Controls.Add(FemaleradioButton);
            Controls.Add(NationalcodetextBox);
            Controls.Add(CellphoneTextBox);
            Controls.Add(LastNametextBox);
            Controls.Add(FirstNameTextBox);
            Controls.Add(GenderLabel);
            Controls.Add(NatinalcodeLabel);
            Controls.Add(CellphoneLabel);
            Controls.Add(LastNameLabel);
            Controls.Add(FirstNameLabel);
            Name = "RegisterForm";
            Text = "فرم ثبت نام";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)ManagerCodeTextBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)PersonDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)AdminDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label FirstNameLabel;
        private Label LastNameLabel;
        private Label CellphoneLabel;
        private Label NatinalcodeLabel;
        private Label GenderLabel;
        private TextBox FirstNameTextBox;
        private TextBox LastNametextBox;
        private TextBox CellphoneTextBox;
        private TextBox NationalcodetextBox;
        private RadioButton FemaleradioButton;
        private RadioButton MaleradioButton;
        private Button RegisterButton;
        private Label OutPutMessageLabel;
        private TextBox OutPutTextBox;
        private Label RoleLabel;
        private CheckBox isAdminCheckBox;
        private TextBox ManagerSectiontextBox;
        private Label ManagerSectionLabel;
        private Label ManagerCodeLabel;
        private NumericUpDown ManagerCodeTextBox;
        private DataGridView PersonDataGridView;
        private DataGridView AdminDataGridView;
        private Label label1;
        private Label label2;
        private RadioButton OtherRadioButton;
        private RadioButton UnknownRadioButton;
    }
}