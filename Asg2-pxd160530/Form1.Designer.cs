namespace Asg2_pxd160530
{
    partial class MainForm
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
            this.ctlRecordListView = new System.Windows.Forms.ListView();
            this.clhdrFullName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhdrPhoneNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ctlStatusBar = new System.Windows.Forms.StatusStrip();
            this.lblActivityStatusBar = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.ctlFirstName = new System.Windows.Forms.TextBox();
            this.ctlMiddleInitial = new System.Windows.Forms.TextBox();
            this.lblMiddleInitial = new System.Windows.Forms.Label();
            this.ctlLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.ctlAddressLine1 = new System.Windows.Forms.TextBox();
            this.lblAddressLine1 = new System.Windows.Forms.Label();
            this.ctlAddressLine2 = new System.Windows.Forms.TextBox();
            this.lblAddressLine2 = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.ctlCity = new System.Windows.Forms.TextBox();
            this.lblDateReceived = new System.Windows.Forms.Label();
            this.lblProofOfPurchase = new System.Windows.Forms.Label();
            this.ctlEmailAddress = new System.Windows.Forms.TextBox();
            this.lblEmailAddress = new System.Windows.Forms.Label();
            this.ctlPhoneNumber = new System.Windows.Forms.TextBox();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.ctlZipCode = new System.Windows.Forms.TextBox();
            this.lblZipCode = new System.Windows.Forms.Label();
            this.ctlState = new System.Windows.Forms.TextBox();
            this.lblState = new System.Windows.Forms.Label();
            this.ctlDateReceived = new System.Windows.Forms.DateTimePicker();
            this.ctlProofOfPurchasedAttached = new System.Windows.Forms.RadioButton();
            this.ctlProofOfPurchasedNotAttached = new System.Windows.Forms.RadioButton();
            this.ctlDelete = new System.Windows.Forms.Button();
            this.ctlModify = new System.Windows.Forms.Button();
            this.ctlAdd = new System.Windows.Forms.Button();
            this.lblClearButtonHelp = new System.Windows.Forms.Label();
            this.ctlStatusBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // ctlRecordListView
            // 
            this.ctlRecordListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clhdrFullName,
            this.clhdrPhoneNumber});
            this.ctlRecordListView.FullRowSelect = true;
            this.ctlRecordListView.HideSelection = false;
            this.ctlRecordListView.Location = new System.Drawing.Point(12, 12);
            this.ctlRecordListView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ctlRecordListView.MultiSelect = false;
            this.ctlRecordListView.Name = "ctlRecordListView";
            this.ctlRecordListView.Size = new System.Drawing.Size(496, 642);
            this.ctlRecordListView.TabIndex = 0;
            this.ctlRecordListView.UseCompatibleStateImageBehavior = false;
            this.ctlRecordListView.View = System.Windows.Forms.View.Details;
            this.ctlRecordListView.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.ctlRecordListView_ColumnClick);
            this.ctlRecordListView.SelectedIndexChanged += new System.EventHandler(this.ctlRecordListView_SelectedIndexChanged);
            // 
            // clhdrFullName
            // 
            this.clhdrFullName.Text = "Full Name";
            this.clhdrFullName.Width = 184;
            // 
            // clhdrPhoneNumber
            // 
            this.clhdrPhoneNumber.Text = "Phone Number";
            this.clhdrPhoneNumber.Width = 184;
            // 
            // ctlStatusBar
            // 
            this.ctlStatusBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ctlStatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblActivityStatusBar});
            this.ctlStatusBar.Location = new System.Drawing.Point(0, 676);
            this.ctlStatusBar.Name = "ctlStatusBar";
            this.ctlStatusBar.Padding = new System.Windows.Forms.Padding(1, 0, 13, 0);
            this.ctlStatusBar.Size = new System.Drawing.Size(1237, 22);
            this.ctlStatusBar.TabIndex = 1;
            // 
            // lblActivityStatusBar
            // 
            this.lblActivityStatusBar.Name = "lblActivityStatusBar";
            this.lblActivityStatusBar.Size = new System.Drawing.Size(0, 17);
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(680, 31);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(98, 20);
            this.lblFirstName.TabIndex = 2;
            this.lblFirstName.Text = "First Name*";
            // 
            // ctlFirstName
            // 
            this.ctlFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctlFirstName.Location = new System.Drawing.Point(789, 27);
            this.ctlFirstName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ctlFirstName.MaxLength = 20;
            this.ctlFirstName.Name = "ctlFirstName";
            this.ctlFirstName.Size = new System.Drawing.Size(257, 27);
            this.ctlFirstName.TabIndex = 1;
            this.ctlFirstName.TextChanged += new System.EventHandler(this.ctl_TextChange);
            this.ctlFirstName.Leave += new System.EventHandler(this.ctl_TextChange);
            // 
            // ctlMiddleInitial
            // 
            this.ctlMiddleInitial.CausesValidation = false;
            this.ctlMiddleInitial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctlMiddleInitial.Location = new System.Drawing.Point(789, 74);
            this.ctlMiddleInitial.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ctlMiddleInitial.MaxLength = 1;
            this.ctlMiddleInitial.Name = "ctlMiddleInitial";
            this.ctlMiddleInitial.Size = new System.Drawing.Size(23, 27);
            this.ctlMiddleInitial.TabIndex = 2;
            this.ctlMiddleInitial.TextChanged += new System.EventHandler(this.ctl_TextChange);
            // 
            // lblMiddleInitial
            // 
            this.lblMiddleInitial.AutoSize = true;
            this.lblMiddleInitial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMiddleInitial.Location = new System.Drawing.Point(669, 76);
            this.lblMiddleInitial.Name = "lblMiddleInitial";
            this.lblMiddleInitial.Size = new System.Drawing.Size(102, 20);
            this.lblMiddleInitial.TabIndex = 4;
            this.lblMiddleInitial.Text = "Middle Initial";
            // 
            // ctlLastName
            // 
            this.ctlLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctlLastName.Location = new System.Drawing.Point(789, 121);
            this.ctlLastName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ctlLastName.MaxLength = 20;
            this.ctlLastName.Name = "ctlLastName";
            this.ctlLastName.Size = new System.Drawing.Size(257, 27);
            this.ctlLastName.TabIndex = 3;
            this.ctlLastName.TextChanged += new System.EventHandler(this.ctl_TextChange);
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(680, 122);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(97, 20);
            this.lblLastName.TabIndex = 6;
            this.lblLastName.Text = "Last Name*";
            // 
            // ctlAddressLine1
            // 
            this.ctlAddressLine1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctlAddressLine1.Location = new System.Drawing.Point(789, 167);
            this.ctlAddressLine1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ctlAddressLine1.MaxLength = 35;
            this.ctlAddressLine1.Name = "ctlAddressLine1";
            this.ctlAddressLine1.Size = new System.Drawing.Size(413, 27);
            this.ctlAddressLine1.TabIndex = 4;
            this.ctlAddressLine1.TextChanged += new System.EventHandler(this.ctl_TextChange);
            // 
            // lblAddressLine1
            // 
            this.lblAddressLine1.AutoSize = true;
            this.lblAddressLine1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddressLine1.Location = new System.Drawing.Point(643, 171);
            this.lblAddressLine1.Name = "lblAddressLine1";
            this.lblAddressLine1.Size = new System.Drawing.Size(128, 20);
            this.lblAddressLine1.TabIndex = 8;
            this.lblAddressLine1.Text = "Address Line 1*";
            // 
            // ctlAddressLine2
            // 
            this.ctlAddressLine2.CausesValidation = false;
            this.ctlAddressLine2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctlAddressLine2.Location = new System.Drawing.Point(789, 214);
            this.ctlAddressLine2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ctlAddressLine2.MaxLength = 35;
            this.ctlAddressLine2.Name = "ctlAddressLine2";
            this.ctlAddressLine2.Size = new System.Drawing.Size(413, 27);
            this.ctlAddressLine2.TabIndex = 5;
            this.ctlAddressLine2.TextChanged += new System.EventHandler(this.ctl_TextChange);
            // 
            // lblAddressLine2
            // 
            this.lblAddressLine2.AutoSize = true;
            this.lblAddressLine2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddressLine2.Location = new System.Drawing.Point(643, 215);
            this.lblAddressLine2.Name = "lblAddressLine2";
            this.lblAddressLine2.Size = new System.Drawing.Size(122, 20);
            this.lblAddressLine2.TabIndex = 10;
            this.lblAddressLine2.Text = "Address Line 2";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.Location = new System.Drawing.Point(739, 262);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(44, 20);
            this.lblCity.TabIndex = 12;
            this.lblCity.Text = "City*";
            // 
            // ctlCity
            // 
            this.ctlCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctlCity.Location = new System.Drawing.Point(789, 261);
            this.ctlCity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ctlCity.MaxLength = 25;
            this.ctlCity.Name = "ctlCity";
            this.ctlCity.Size = new System.Drawing.Size(309, 27);
            this.ctlCity.TabIndex = 6;
            this.ctlCity.TextChanged += new System.EventHandler(this.ctl_TextChange);
            // 
            // lblDateReceived
            // 
            this.lblDateReceived.AutoSize = true;
            this.lblDateReceived.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateReceived.Location = new System.Drawing.Point(645, 548);
            this.lblDateReceived.Name = "lblDateReceived";
            this.lblDateReceived.Size = new System.Drawing.Size(125, 20);
            this.lblDateReceived.TabIndex = 24;
            this.lblDateReceived.Text = "Date Received*";
            // 
            // lblProofOfPurchase
            // 
            this.lblProofOfPurchase.AutoSize = true;
            this.lblProofOfPurchase.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProofOfPurchase.Location = new System.Drawing.Point(529, 497);
            this.lblProofOfPurchase.Name = "lblProofOfPurchase";
            this.lblProofOfPurchase.Size = new System.Drawing.Size(226, 20);
            this.lblProofOfPurchase.TabIndex = 22;
            this.lblProofOfPurchase.Text = "Proof of purchase attached?*";
            // 
            // ctlEmailAddress
            // 
            this.ctlEmailAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctlEmailAddress.Location = new System.Drawing.Point(789, 448);
            this.ctlEmailAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ctlEmailAddress.MaxLength = 60;
            this.ctlEmailAddress.Name = "ctlEmailAddress";
            this.ctlEmailAddress.Size = new System.Drawing.Size(431, 27);
            this.ctlEmailAddress.TabIndex = 10;
            this.ctlEmailAddress.TextChanged += new System.EventHandler(this.ctl_TextChange);
            // 
            // lblEmailAddress
            // 
            this.lblEmailAddress.AutoSize = true;
            this.lblEmailAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailAddress.Location = new System.Drawing.Point(647, 453);
            this.lblEmailAddress.Name = "lblEmailAddress";
            this.lblEmailAddress.Size = new System.Drawing.Size(128, 20);
            this.lblEmailAddress.TabIndex = 20;
            this.lblEmailAddress.Text = "E-mail address*";
            // 
            // ctlPhoneNumber
            // 
            this.ctlPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctlPhoneNumber.Location = new System.Drawing.Point(789, 401);
            this.ctlPhoneNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ctlPhoneNumber.MaxLength = 21;
            this.ctlPhoneNumber.Name = "ctlPhoneNumber";
            this.ctlPhoneNumber.Size = new System.Drawing.Size(257, 27);
            this.ctlPhoneNumber.TabIndex = 9;
            this.ctlPhoneNumber.TextChanged += new System.EventHandler(this.ctl_TextChange);
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNumber.Location = new System.Drawing.Point(645, 405);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(126, 20);
            this.lblPhoneNumber.TabIndex = 18;
            this.lblPhoneNumber.Text = "Phone Number*";
            // 
            // ctlZipCode
            // 
            this.ctlZipCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctlZipCode.Location = new System.Drawing.Point(789, 354);
            this.ctlZipCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ctlZipCode.MaxLength = 10;
            this.ctlZipCode.Name = "ctlZipCode";
            this.ctlZipCode.Size = new System.Drawing.Size(116, 27);
            this.ctlZipCode.TabIndex = 8;
            this.ctlZipCode.TextChanged += new System.EventHandler(this.ctl_TextChange);
            // 
            // lblZipCode
            // 
            this.lblZipCode.AutoSize = true;
            this.lblZipCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZipCode.Location = new System.Drawing.Point(696, 357);
            this.lblZipCode.Name = "lblZipCode";
            this.lblZipCode.Size = new System.Drawing.Size(81, 20);
            this.lblZipCode.TabIndex = 16;
            this.lblZipCode.Text = "Zip Code*";
            // 
            // ctlState
            // 
            this.ctlState.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctlState.Location = new System.Drawing.Point(789, 308);
            this.ctlState.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ctlState.MaxLength = 2;
            this.ctlState.Name = "ctlState";
            this.ctlState.Size = new System.Drawing.Size(36, 27);
            this.ctlState.TabIndex = 7;
            this.ctlState.TextChanged += new System.EventHandler(this.ctl_TextChange);
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblState.Location = new System.Drawing.Point(725, 309);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(54, 20);
            this.lblState.TabIndex = 14;
            this.lblState.Text = "State*";
            // 
            // ctlDateReceived
            // 
            this.ctlDateReceived.Location = new System.Drawing.Point(789, 544);
            this.ctlDateReceived.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ctlDateReceived.Name = "ctlDateReceived";
            this.ctlDateReceived.Size = new System.Drawing.Size(257, 22);
            this.ctlDateReceived.TabIndex = 13;
            this.ctlDateReceived.CloseUp += new System.EventHandler(this.ctlDateReceived_CloseUp);
            this.ctlDateReceived.ValueChanged += new System.EventHandler(this.ctl_TextChange);
            this.ctlDateReceived.DropDown += new System.EventHandler(this.ctlDateReceived_DropDown);
            // 
            // ctlProofOfPurchasedAttached
            // 
            this.ctlProofOfPurchasedAttached.AutoSize = true;
            this.ctlProofOfPurchasedAttached.Checked = true;
            this.ctlProofOfPurchasedAttached.Location = new System.Drawing.Point(789, 497);
            this.ctlProofOfPurchasedAttached.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ctlProofOfPurchasedAttached.Name = "ctlProofOfPurchasedAttached";
            this.ctlProofOfPurchasedAttached.Size = new System.Drawing.Size(53, 21);
            this.ctlProofOfPurchasedAttached.TabIndex = 11;
            this.ctlProofOfPurchasedAttached.TabStop = true;
            this.ctlProofOfPurchasedAttached.Text = "Yes";
            this.ctlProofOfPurchasedAttached.UseVisualStyleBackColor = true;
            this.ctlProofOfPurchasedAttached.CheckedChanged += new System.EventHandler(this.ctl_TextChange);
            // 
            // ctlProofOfPurchasedNotAttached
            // 
            this.ctlProofOfPurchasedNotAttached.AutoSize = true;
            this.ctlProofOfPurchasedNotAttached.Location = new System.Drawing.Point(855, 497);
            this.ctlProofOfPurchasedNotAttached.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ctlProofOfPurchasedNotAttached.Name = "ctlProofOfPurchasedNotAttached";
            this.ctlProofOfPurchasedNotAttached.Size = new System.Drawing.Size(47, 21);
            this.ctlProofOfPurchasedNotAttached.TabIndex = 12;
            this.ctlProofOfPurchasedNotAttached.TabStop = true;
            this.ctlProofOfPurchasedNotAttached.Text = "No";
            this.ctlProofOfPurchasedNotAttached.UseVisualStyleBackColor = true;
            this.ctlProofOfPurchasedNotAttached.CheckedChanged += new System.EventHandler(this.ctl_TextChange);
            // 
            // ctlDelete
            // 
            this.ctlDelete.Enabled = false;
            this.ctlDelete.Location = new System.Drawing.Point(1045, 606);
            this.ctlDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ctlDelete.Name = "ctlDelete";
            this.ctlDelete.Size = new System.Drawing.Size(112, 37);
            this.ctlDelete.TabIndex = 16;
            this.ctlDelete.Text = "Delete";
            this.ctlDelete.UseVisualStyleBackColor = true;
            this.ctlDelete.Click += new System.EventHandler(this.ctlDelete_Click);
            // 
            // ctlModify
            // 
            this.ctlModify.Enabled = false;
            this.ctlModify.Location = new System.Drawing.Point(837, 606);
            this.ctlModify.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ctlModify.Name = "ctlModify";
            this.ctlModify.Size = new System.Drawing.Size(121, 37);
            this.ctlModify.TabIndex = 15;
            this.ctlModify.Text = "Modify";
            this.ctlModify.UseVisualStyleBackColor = true;
            this.ctlModify.Click += new System.EventHandler(this.ctlModify_Click);
            // 
            // ctlAdd
            // 
            this.ctlAdd.Enabled = false;
            this.ctlAdd.Location = new System.Drawing.Point(624, 606);
            this.ctlAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ctlAdd.Name = "ctlAdd";
            this.ctlAdd.Size = new System.Drawing.Size(127, 37);
            this.ctlAdd.TabIndex = 14;
            this.ctlAdd.Text = "Add";
            this.ctlAdd.UseVisualStyleBackColor = true;
            this.ctlAdd.Click += new System.EventHandler(this.ctlAdd_Click);
            // 
            // lblClearButtonHelp
            // 
            this.lblClearButtonHelp.AutoSize = true;
            this.lblClearButtonHelp.Location = new System.Drawing.Point(984, 677);
            this.lblClearButtonHelp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClearButtonHelp.Name = "lblClearButtonHelp";
            this.lblClearButtonHelp.Size = new System.Drawing.Size(243, 17);
            this.lblClearButtonHelp.TabIndex = 25;
            this.lblClearButtonHelp.Text = "Press Escape (Esc) to clear the form.";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1237, 698);
            this.Controls.Add(this.lblClearButtonHelp);
            this.Controls.Add(this.ctlAdd);
            this.Controls.Add(this.ctlModify);
            this.Controls.Add(this.ctlDelete);
            this.Controls.Add(this.ctlProofOfPurchasedNotAttached);
            this.Controls.Add(this.ctlProofOfPurchasedAttached);
            this.Controls.Add(this.ctlDateReceived);
            this.Controls.Add(this.lblDateReceived);
            this.Controls.Add(this.lblProofOfPurchase);
            this.Controls.Add(this.ctlEmailAddress);
            this.Controls.Add(this.lblEmailAddress);
            this.Controls.Add(this.ctlPhoneNumber);
            this.Controls.Add(this.lblPhoneNumber);
            this.Controls.Add(this.ctlZipCode);
            this.Controls.Add(this.lblZipCode);
            this.Controls.Add(this.ctlState);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.ctlCity);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.ctlAddressLine2);
            this.Controls.Add(this.lblAddressLine2);
            this.Controls.Add(this.ctlAddressLine1);
            this.Controls.Add(this.lblAddressLine1);
            this.Controls.Add(this.ctlLastName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.ctlMiddleInitial);
            this.Controls.Add(this.lblMiddleInitial);
            this.Controls.Add(this.ctlFirstName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.ctlStatusBar);
            this.Controls.Add(this.ctlRecordListView);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.Text = "Rebate Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.ctlStatusBar.ResumeLayout(false);
            this.ctlStatusBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView ctlRecordListView;
        private System.Windows.Forms.ColumnHeader clhdrFullName;
        private System.Windows.Forms.ColumnHeader clhdrPhoneNumber;
        private System.Windows.Forms.StatusStrip ctlStatusBar;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox ctlFirstName;
        private System.Windows.Forms.TextBox ctlMiddleInitial;
        private System.Windows.Forms.Label lblMiddleInitial;
        private System.Windows.Forms.TextBox ctlLastName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox ctlAddressLine1;
        private System.Windows.Forms.Label lblAddressLine1;
        private System.Windows.Forms.TextBox ctlAddressLine2;
        private System.Windows.Forms.Label lblAddressLine2;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.TextBox ctlCity;
        private System.Windows.Forms.Label lblDateReceived;
        private System.Windows.Forms.Label lblProofOfPurchase;
        private System.Windows.Forms.TextBox ctlEmailAddress;
        private System.Windows.Forms.Label lblEmailAddress;
        private System.Windows.Forms.TextBox ctlPhoneNumber;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.TextBox ctlZipCode;
        private System.Windows.Forms.Label lblZipCode;
        private System.Windows.Forms.TextBox ctlState;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.DateTimePicker ctlDateReceived;
        private System.Windows.Forms.RadioButton ctlProofOfPurchasedAttached;
        private System.Windows.Forms.RadioButton ctlProofOfPurchasedNotAttached;
        private System.Windows.Forms.Button ctlDelete;
        private System.Windows.Forms.Button ctlModify;
        private System.Windows.Forms.Button ctlAdd;
        private System.Windows.Forms.ToolStripStatusLabel lblActivityStatusBar;
        private System.Windows.Forms.Label lblClearButtonHelp;
    }
}

