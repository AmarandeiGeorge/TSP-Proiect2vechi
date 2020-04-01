namespace WinFormGUI
{
    partial class PhotoView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PhotoView));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.SavePhotoMenu = new System.Windows.Forms.ToolStripButton();
            this.ViewPhotoMenu = new System.Windows.Forms.ToolStripButton();
            this.SavePhotoPanel = new System.Windows.Forms.Panel();
            this.PictureCointainer = new System.Windows.Forms.PictureBox();
            this.discardBtn = new System.Windows.Forms.Button();
            this.AddPropertyBtn = new System.Windows.Forms.Button();
            this.PropertyInput = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.PropertiesCheckList = new System.Windows.Forms.CheckedListBox();
            this.label11 = new System.Windows.Forms.Label();
            this.AddPeopleBtn = new System.Windows.Forms.Button();
            this.SurnameInput = new System.Windows.Forms.TextBox();
            this.NameInput = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.PeopleCheckList = new System.Windows.Forms.CheckedListBox();
            this.eventInput = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ChooseFileBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.descriptionInput = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.photoDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.locationInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.titleInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.savePhotoBtn = new System.Windows.Forms.Button();
            this.ShowPhotosPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.descriptionBox = new System.Windows.Forms.RichTextBox();
            this.dataLabel = new System.Windows.Forms.Label();
            this.locatieLabel = new System.Windows.Forms.Label();
            this.titluLabel = new System.Windows.Forms.Label();
            this.bigPicture = new System.Windows.Forms.PictureBox();
            this.button7 = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.toolStrip1.SuspendLayout();
            this.SavePhotoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureCointainer)).BeginInit();
            this.ShowPhotosPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bigPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SavePhotoMenu,
            this.ViewPhotoMenu});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1331, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // SavePhotoMenu
            // 
            this.SavePhotoMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.SavePhotoMenu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.SavePhotoMenu.Image = ((System.Drawing.Image)(resources.GetObject("SavePhotoMenu.Image")));
            this.SavePhotoMenu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SavePhotoMenu.Name = "SavePhotoMenu";
            this.SavePhotoMenu.Size = new System.Drawing.Size(93, 24);
            this.SavePhotoMenu.Text = "Save Photos";
            this.SavePhotoMenu.Click += new System.EventHandler(this.SavePhotoMenu_Click);
            // 
            // ViewPhotoMenu
            // 
            this.ViewPhotoMenu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ViewPhotoMenu.Image = ((System.Drawing.Image)(resources.GetObject("ViewPhotoMenu.Image")));
            this.ViewPhotoMenu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ViewPhotoMenu.Name = "ViewPhotoMenu";
            this.ViewPhotoMenu.Size = new System.Drawing.Size(94, 24);
            this.ViewPhotoMenu.Text = "View Photos";
            this.ViewPhotoMenu.Click += new System.EventHandler(this.ViewPhotoMenu_Click);
            // 
            // SavePhotoPanel
            // 
            this.SavePhotoPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SavePhotoPanel.Controls.Add(this.PictureCointainer);
            this.SavePhotoPanel.Controls.Add(this.discardBtn);
            this.SavePhotoPanel.Controls.Add(this.AddPropertyBtn);
            this.SavePhotoPanel.Controls.Add(this.PropertyInput);
            this.SavePhotoPanel.Controls.Add(this.label10);
            this.SavePhotoPanel.Controls.Add(this.PropertiesCheckList);
            this.SavePhotoPanel.Controls.Add(this.label11);
            this.SavePhotoPanel.Controls.Add(this.AddPeopleBtn);
            this.SavePhotoPanel.Controls.Add(this.SurnameInput);
            this.SavePhotoPanel.Controls.Add(this.NameInput);
            this.SavePhotoPanel.Controls.Add(this.label8);
            this.SavePhotoPanel.Controls.Add(this.label7);
            this.SavePhotoPanel.Controls.Add(this.PeopleCheckList);
            this.SavePhotoPanel.Controls.Add(this.eventInput);
            this.SavePhotoPanel.Controls.Add(this.label6);
            this.SavePhotoPanel.Controls.Add(this.ChooseFileBtn);
            this.SavePhotoPanel.Controls.Add(this.label5);
            this.SavePhotoPanel.Controls.Add(this.descriptionInput);
            this.SavePhotoPanel.Controls.Add(this.label4);
            this.SavePhotoPanel.Controls.Add(this.photoDate);
            this.SavePhotoPanel.Controls.Add(this.label3);
            this.SavePhotoPanel.Controls.Add(this.locationInput);
            this.SavePhotoPanel.Controls.Add(this.label2);
            this.SavePhotoPanel.Controls.Add(this.titleInput);
            this.SavePhotoPanel.Controls.Add(this.label1);
            this.SavePhotoPanel.Controls.Add(this.savePhotoBtn);
            this.SavePhotoPanel.Location = new System.Drawing.Point(0, 30);
            this.SavePhotoPanel.Name = "SavePhotoPanel";
            this.SavePhotoPanel.Size = new System.Drawing.Size(1331, 724);
            this.SavePhotoPanel.TabIndex = 1;
            // 
            // PictureCointainer
            // 
            this.PictureCointainer.Location = new System.Drawing.Point(482, 27);
            this.PictureCointainer.Name = "PictureCointainer";
            this.PictureCointainer.Size = new System.Drawing.Size(820, 602);
            this.PictureCointainer.TabIndex = 0;
            this.PictureCointainer.TabStop = false;
            // 
            // discardBtn
            // 
            this.discardBtn.BackColor = System.Drawing.Color.Chocolate;
            this.discardBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.discardBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.discardBtn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discardBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.discardBtn.Location = new System.Drawing.Point(817, 635);
            this.discardBtn.Name = "discardBtn";
            this.discardBtn.Size = new System.Drawing.Size(143, 61);
            this.discardBtn.TabIndex = 27;
            this.discardBtn.Text = "Discard";
            this.discardBtn.UseVisualStyleBackColor = false;
            this.discardBtn.Click += new System.EventHandler(this.discardBtn_Click);
            // 
            // AddPropertyBtn
            // 
            this.AddPropertyBtn.BackColor = System.Drawing.Color.Chocolate;
            this.AddPropertyBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddPropertyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddPropertyBtn.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.AddPropertyBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AddPropertyBtn.Location = new System.Drawing.Point(365, 493);
            this.AddPropertyBtn.Name = "AddPropertyBtn";
            this.AddPropertyBtn.Size = new System.Drawing.Size(111, 36);
            this.AddPropertyBtn.TabIndex = 26;
            this.AddPropertyBtn.Text = "Adauga";
            this.AddPropertyBtn.UseVisualStyleBackColor = false;
            this.AddPropertyBtn.Click += new System.EventHandler(this.AddPropertyBtn_Click);
            // 
            // PropertyInput
            // 
            this.PropertyInput.BackColor = System.Drawing.Color.OldLace;
            this.PropertyInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PropertyInput.Font = new System.Drawing.Font("Tahoma", 10.8F);
            this.PropertyInput.Location = new System.Drawing.Point(168, 496);
            this.PropertyInput.Name = "PropertyInput";
            this.PropertyInput.Size = new System.Drawing.Size(191, 29);
            this.PropertyInput.TabIndex = 24;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(38, 498);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(124, 23);
            this.label10.TabIndex = 22;
            this.label10.Text = "Proprietate:";
            // 
            // PropertiesCheckList
            // 
            this.PropertiesCheckList.FormattingEnabled = true;
            this.PropertiesCheckList.Location = new System.Drawing.Point(168, 386);
            this.PropertiesCheckList.Name = "PropertiesCheckList";
            this.PropertiesCheckList.Size = new System.Drawing.Size(308, 89);
            this.PropertiesCheckList.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(72, 386);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 29);
            this.label11.TabIndex = 20;
            this.label11.Text = "Altele:";
            // 
            // AddPeopleBtn
            // 
            this.AddPeopleBtn.BackColor = System.Drawing.Color.Chocolate;
            this.AddPeopleBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddPeopleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddPeopleBtn.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.AddPeopleBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AddPeopleBtn.Location = new System.Drawing.Point(365, 295);
            this.AddPeopleBtn.Name = "AddPeopleBtn";
            this.AddPeopleBtn.Size = new System.Drawing.Size(111, 64);
            this.AddPeopleBtn.TabIndex = 19;
            this.AddPeopleBtn.Text = "Adauga";
            this.AddPeopleBtn.UseVisualStyleBackColor = false;
            this.AddPeopleBtn.Click += new System.EventHandler(this.AddPeopleBtn_Click);
            // 
            // SurnameInput
            // 
            this.SurnameInput.BackColor = System.Drawing.Color.OldLace;
            this.SurnameInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SurnameInput.Font = new System.Drawing.Font("Tahoma", 10.8F);
            this.SurnameInput.Location = new System.Drawing.Point(168, 330);
            this.SurnameInput.Name = "SurnameInput";
            this.SurnameInput.Size = new System.Drawing.Size(191, 29);
            this.SurnameInput.TabIndex = 18;
            // 
            // NameInput
            // 
            this.NameInput.BackColor = System.Drawing.Color.OldLace;
            this.NameInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NameInput.Font = new System.Drawing.Font("Tahoma", 10.8F);
            this.NameInput.Location = new System.Drawing.Point(168, 295);
            this.NameInput.Name = "NameInput";
            this.NameInput.Size = new System.Drawing.Size(191, 29);
            this.NameInput.TabIndex = 17;
            this.NameInput.TextChanged += new System.EventHandler(this.NameInput_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(65, 330);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 23);
            this.label8.TabIndex = 16;
            this.label8.Text = "Prenume:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(93, 295);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 23);
            this.label7.TabIndex = 15;
            this.label7.Text = "Nume:";
            // 
            // PeopleCheckList
            // 
            this.PeopleCheckList.FormattingEnabled = true;
            this.PeopleCheckList.Location = new System.Drawing.Point(168, 195);
            this.PeopleCheckList.Name = "PeopleCheckList";
            this.PeopleCheckList.Size = new System.Drawing.Size(308, 89);
            this.PeopleCheckList.TabIndex = 14;
            // 
            // eventInput
            // 
            this.eventInput.BackColor = System.Drawing.Color.OldLace;
            this.eventInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.eventInput.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventInput.Location = new System.Drawing.Point(168, 154);
            this.eventInput.Name = "eventInput";
            this.eventInput.Size = new System.Drawing.Size(308, 35);
            this.eventInput.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 29);
            this.label6.TabIndex = 12;
            this.label6.Text = "Eveniment:";
            // 
            // ChooseFileBtn
            // 
            this.ChooseFileBtn.BackColor = System.Drawing.Color.Chocolate;
            this.ChooseFileBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChooseFileBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChooseFileBtn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChooseFileBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ChooseFileBtn.Location = new System.Drawing.Point(966, 635);
            this.ChooseFileBtn.Name = "ChooseFileBtn";
            this.ChooseFileBtn.Size = new System.Drawing.Size(143, 61);
            this.ChooseFileBtn.TabIndex = 11;
            this.ChooseFileBtn.Text = "Choose";
            this.ChooseFileBtn.UseVisualStyleBackColor = false;
            this.ChooseFileBtn.Click += new System.EventHandler(this.ChooseFileBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(59, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 29);
            this.label5.TabIndex = 10;
            this.label5.Text = "People:";
            // 
            // descriptionInput
            // 
            this.descriptionInput.BackColor = System.Drawing.SystemColors.Window;
            this.descriptionInput.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionInput.Location = new System.Drawing.Point(168, 557);
            this.descriptionInput.Name = "descriptionInput";
            this.descriptionInput.Size = new System.Drawing.Size(308, 139);
            this.descriptionInput.TabIndex = 9;
            this.descriptionInput.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 557);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 29);
            this.label4.TabIndex = 8;
            this.label4.Text = "Descriere:";
            // 
            // photoDate
            // 
            this.photoDate.CalendarMonthBackground = System.Drawing.Color.OldLace;
            this.photoDate.CalendarTitleBackColor = System.Drawing.Color.OldLace;
            this.photoDate.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.photoDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.photoDate.Location = new System.Drawing.Point(168, 113);
            this.photoDate.Name = "photoDate";
            this.photoDate.Size = new System.Drawing.Size(308, 35);
            this.photoDate.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(84, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "Data:";
            // 
            // locationInput
            // 
            this.locationInput.BackColor = System.Drawing.Color.OldLace;
            this.locationInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.locationInput.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationInput.Location = new System.Drawing.Point(168, 72);
            this.locationInput.Name = "locationInput";
            this.locationInput.Size = new System.Drawing.Size(308, 35);
            this.locationInput.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(53, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Locatie:";
            // 
            // titleInput
            // 
            this.titleInput.BackColor = System.Drawing.Color.OldLace;
            this.titleInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.titleInput.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleInput.Location = new System.Drawing.Point(168, 27);
            this.titleInput.Name = "titleInput";
            this.titleInput.Size = new System.Drawing.Size(308, 35);
            this.titleInput.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(86, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Titlu:";
            // 
            // savePhotoBtn
            // 
            this.savePhotoBtn.BackColor = System.Drawing.Color.Chocolate;
            this.savePhotoBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.savePhotoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.savePhotoBtn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savePhotoBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.savePhotoBtn.Location = new System.Drawing.Point(1115, 635);
            this.savePhotoBtn.Name = "savePhotoBtn";
            this.savePhotoBtn.Size = new System.Drawing.Size(187, 61);
            this.savePhotoBtn.TabIndex = 1;
            this.savePhotoBtn.Text = "Save";
            this.savePhotoBtn.UseVisualStyleBackColor = false;
            this.savePhotoBtn.Click += new System.EventHandler(this.savePhotoBtn_Click);
            // 
            // ShowPhotosPanel
            // 
            this.ShowPhotosPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ShowPhotosPanel.Controls.Add(this.panel1);
            this.ShowPhotosPanel.Controls.Add(this.button7);
            this.ShowPhotosPanel.Controls.Add(this.checkedListBox1);
            this.ShowPhotosPanel.Controls.Add(this.label9);
            this.ShowPhotosPanel.Controls.Add(this.button6);
            this.ShowPhotosPanel.Controls.Add(this.textBox6);
            this.ShowPhotosPanel.Controls.Add(this.button5);
            this.ShowPhotosPanel.Controls.Add(this.textBox5);
            this.ShowPhotosPanel.Controls.Add(this.button4);
            this.ShowPhotosPanel.Controls.Add(this.textBox4);
            this.ShowPhotosPanel.Controls.Add(this.button3);
            this.ShowPhotosPanel.Controls.Add(this.textBox3);
            this.ShowPhotosPanel.Controls.Add(this.button2);
            this.ShowPhotosPanel.Controls.Add(this.textBox2);
            this.ShowPhotosPanel.Controls.Add(this.button1);
            this.ShowPhotosPanel.Controls.Add(this.textBox1);
            this.ShowPhotosPanel.Controls.Add(this.listView1);
            this.ShowPhotosPanel.Location = new System.Drawing.Point(0, 27);
            this.ShowPhotosPanel.Name = "ShowPhotosPanel";
            this.ShowPhotosPanel.Size = new System.Drawing.Size(1331, 724);
            this.ShowPhotosPanel.TabIndex = 28;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.descriptionBox);
            this.panel1.Controls.Add(this.dataLabel);
            this.panel1.Controls.Add(this.locatieLabel);
            this.panel1.Controls.Add(this.titluLabel);
            this.panel1.Controls.Add(this.bigPicture);
            this.panel1.Location = new System.Drawing.Point(616, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(703, 710);
            this.panel1.TabIndex = 41;
            // 
            // descriptionBox
            // 
            this.descriptionBox.Location = new System.Drawing.Point(3, 478);
            this.descriptionBox.Name = "descriptionBox";
            this.descriptionBox.Size = new System.Drawing.Size(697, 96);
            this.descriptionBox.TabIndex = 45;
            this.descriptionBox.Text = "";
            // 
            // dataLabel
            // 
            this.dataLabel.AutoSize = true;
            this.dataLabel.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataLabel.Location = new System.Drawing.Point(560, 5);
            this.dataLabel.Name = "dataLabel";
            this.dataLabel.Size = new System.Drawing.Size(73, 34);
            this.dataLabel.TabIndex = 44;
            this.dataLabel.Text = "Data";
            // 
            // locatieLabel
            // 
            this.locatieLabel.AutoSize = true;
            this.locatieLabel.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locatieLabel.Location = new System.Drawing.Point(307, 5);
            this.locatieLabel.Name = "locatieLabel";
            this.locatieLabel.Size = new System.Drawing.Size(102, 34);
            this.locatieLabel.TabIndex = 43;
            this.locatieLabel.Text = "Locatie";
            // 
            // titluLabel
            // 
            this.titluLabel.AutoSize = true;
            this.titluLabel.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titluLabel.Location = new System.Drawing.Point(3, 5);
            this.titluLabel.Name = "titluLabel";
            this.titluLabel.Size = new System.Drawing.Size(68, 34);
            this.titluLabel.TabIndex = 42;
            this.titluLabel.Text = "Titlu";
            // 
            // bigPicture
            // 
            this.bigPicture.Location = new System.Drawing.Point(3, 42);
            this.bigPicture.Name = "bigPicture";
            this.bigPicture.Size = new System.Drawing.Size(697, 429);
            this.bigPicture.TabIndex = 0;
            this.bigPicture.TabStop = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Chocolate;
            this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.button7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button7.Location = new System.Drawing.Point(33, 628);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(260, 48);
            this.button7.TabIndex = 40;
            this.button7.Text = "Search by Friends";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(3, 421);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(321, 191);
            this.checkedListBox1.TabIndex = 39;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(27, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 34);
            this.label9.TabIndex = 38;
            this.label9.Text = "Search:";
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Chocolate;
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.button6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button6.Location = new System.Drawing.Point(172, 368);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(152, 36);
            this.button6.TabIndex = 37;
            this.button6.Text = "Search by Other";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.Color.OldLace;
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox6.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.Location = new System.Drawing.Point(3, 369);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(163, 35);
            this.textBox6.TabIndex = 36;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Chocolate;
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.button5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button5.Location = new System.Drawing.Point(172, 298);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(152, 36);
            this.button5.TabIndex = 35;
            this.button5.Text = "Search by Other";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.OldLace;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox5.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(3, 299);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(163, 35);
            this.textBox5.TabIndex = 34;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Chocolate;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.button4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button4.Location = new System.Drawing.Point(172, 231);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(152, 36);
            this.button4.TabIndex = 33;
            this.button4.Text = "Search by Event";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.OldLace;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox4.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(3, 232);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(163, 35);
            this.textBox4.TabIndex = 32;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Chocolate;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.button3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.Location = new System.Drawing.Point(172, 168);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(152, 36);
            this.button3.TabIndex = 31;
            this.button3.Text = "Search by Location";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.OldLace;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(3, 169);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(163, 35);
            this.textBox3.TabIndex = 30;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Chocolate;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(172, 109);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(152, 36);
            this.button2.TabIndex = 29;
            this.button2.Text = "Search by Location";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.OldLace;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(3, 110);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(163, 35);
            this.textBox2.TabIndex = 28;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Chocolate;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(172, 48);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 36);
            this.button1.TabIndex = 27;
            this.button1.Text = "Search by Title";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.OldLace;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(3, 49);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(163, 35);
            this.textBox1.TabIndex = 5;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(328, 7);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(282, 710);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            this.listView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseClick);
            // 
            // PhotoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(1331, 756);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.ShowPhotosPanel);
            this.Controls.Add(this.SavePhotoPanel);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "PhotoView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GUI";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.SavePhotoPanel.ResumeLayout(false);
            this.SavePhotoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureCointainer)).EndInit();
            this.ShowPhotosPanel.ResumeLayout(false);
            this.ShowPhotosPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bigPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton SavePhotoMenu;
        private System.Windows.Forms.ToolStripButton ViewPhotoMenu;
        private System.Windows.Forms.Panel SavePhotoPanel;
        private System.Windows.Forms.PictureBox PictureCointainer;
        private System.Windows.Forms.Button savePhotoBtn;
        private System.Windows.Forms.TextBox titleInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox locationInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker photoDate;
        private System.Windows.Forms.RichTextBox descriptionInput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button ChooseFileBtn;
        private System.Windows.Forms.TextBox eventInput;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckedListBox PeopleCheckList;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button AddPropertyBtn;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckedListBox PropertiesCheckList;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button AddPeopleBtn;
        private System.Windows.Forms.TextBox SurnameInput;
        private System.Windows.Forms.TextBox NameInput;
        private System.Windows.Forms.Button discardBtn;
        private System.Windows.Forms.TextBox PropertyInput;
        private System.Windows.Forms.Panel ShowPhotosPanel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox bigPicture;
        private System.Windows.Forms.Label titluLabel;
        private System.Windows.Forms.Label locatieLabel;
        private System.Windows.Forms.Label dataLabel;
        private System.Windows.Forms.RichTextBox descriptionBox;
    }
}

