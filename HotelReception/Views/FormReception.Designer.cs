namespace HotelReception
{
    partial class FormReception
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
            this.tabControlReception = new System.Windows.Forms.TabControl();
            this.tabPageRent = new System.Windows.Forms.TabPage();
            this.numericUpDownRentRoom = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxClientFirstName = new System.Windows.Forms.TextBox();
            this.textBoxClientPhone = new System.Windows.Forms.TextBox();
            this.textBoxClientSecondName = new System.Windows.Forms.TextBox();
            this.buttonDeleteRent = new System.Windows.Forms.Button();
            this.buttonEditRent = new System.Windows.Forms.Button();
            this.buttonAddRent = new System.Windows.Forms.Button();
            this.labelRent4 = new System.Windows.Forms.Label();
            this.labelRent3 = new System.Windows.Forms.Label();
            this.labelRent2 = new System.Windows.Forms.Label();
            this.dateTimePickerRent2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerRent1 = new System.Windows.Forms.DateTimePicker();
            this.labelRent1 = new System.Windows.Forms.Label();
            this.listBoxRents = new System.Windows.Forms.ListBox();
            this.tabPageRooms = new System.Windows.Forms.TabPage();
            this.buttonFiltr = new System.Windows.Forms.Button();
            this.labelRooms8 = new System.Windows.Forms.Label();
            this.labelRooms7 = new System.Windows.Forms.Label();
            this.dateTimePickerRooms4 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerRooms3 = new System.Windows.Forms.DateTimePicker();
            this.labelRooms6 = new System.Windows.Forms.Label();
            this.checkBoxRooms = new System.Windows.Forms.CheckBox();
            this.numericUpDownRooms1 = new System.Windows.Forms.NumericUpDown();
            this.listBoxRooms = new System.Windows.Forms.ListBox();
            this.labelUserName = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.listBoxEmployees = new System.Windows.Forms.ListBox();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.checkBoxAdmin = new System.Windows.Forms.CheckBox();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.listBoxRoomsAdmin = new System.Windows.Forms.ListBox();
            this.numericUpDownGuests = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownIdRoom = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownSingleBeds = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownDoubleBeds = new System.Windows.Forms.NumericUpDown();
            this.checkBoxBalcony = new System.Windows.Forms.CheckBox();
            this.numericUpDownCost = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.labelCost = new System.Windows.Forms.Label();
            this.buttonAddRoom = new System.Windows.Forms.Button();
            this.buttonEditRoom = new System.Windows.Forms.Button();
            this.buttonDeleteRoom = new System.Windows.Forms.Button();
            this.buttonDeleteEmployee = new System.Windows.Forms.Button();
            this.buttonEditEmployee = new System.Windows.Forms.Button();
            this.buttonAddEmployee = new System.Windows.Forms.Button();
            this.errorProviderFirst = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderLast = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderPhone = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabControlReception.SuspendLayout();
            this.tabPageRent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRentRoom)).BeginInit();
            this.tabPageRooms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRooms1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGuests)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIdRoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSingleBeds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDoubleBeds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderFirst)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderLast)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPhone)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlReception
            // 
            this.tabControlReception.Controls.Add(this.tabPageRent);
            this.tabControlReception.Controls.Add(this.tabPageRooms);
            this.tabControlReception.Location = new System.Drawing.Point(16, 48);
            this.tabControlReception.Margin = new System.Windows.Forms.Padding(4);
            this.tabControlReception.Name = "tabControlReception";
            this.tabControlReception.SelectedIndex = 0;
            this.tabControlReception.Size = new System.Drawing.Size(780, 388);
            this.tabControlReception.TabIndex = 1;
            this.tabControlReception.SelectedIndexChanged += new System.EventHandler(this.tabControlReception_SelectedIndexChanged);
            // 
            // tabPageRent
            // 
            this.tabPageRent.Controls.Add(this.numericUpDownRentRoom);
            this.tabPageRent.Controls.Add(this.label3);
            this.tabPageRent.Controls.Add(this.label2);
            this.tabPageRent.Controls.Add(this.label1);
            this.tabPageRent.Controls.Add(this.textBoxClientFirstName);
            this.tabPageRent.Controls.Add(this.textBoxClientPhone);
            this.tabPageRent.Controls.Add(this.textBoxClientSecondName);
            this.tabPageRent.Controls.Add(this.buttonDeleteRent);
            this.tabPageRent.Controls.Add(this.buttonEditRent);
            this.tabPageRent.Controls.Add(this.buttonAddRent);
            this.tabPageRent.Controls.Add(this.labelRent4);
            this.tabPageRent.Controls.Add(this.labelRent3);
            this.tabPageRent.Controls.Add(this.labelRent2);
            this.tabPageRent.Controls.Add(this.dateTimePickerRent2);
            this.tabPageRent.Controls.Add(this.dateTimePickerRent1);
            this.tabPageRent.Controls.Add(this.labelRent1);
            this.tabPageRent.Controls.Add(this.listBoxRents);
            this.tabPageRent.Location = new System.Drawing.Point(4, 25);
            this.tabPageRent.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageRent.Name = "tabPageRent";
            this.tabPageRent.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageRent.Size = new System.Drawing.Size(772, 359);
            this.tabPageRent.TabIndex = 0;
            this.tabPageRent.Text = "Wynajem";
            this.tabPageRent.UseVisualStyleBackColor = true;
            // 
            // numericUpDownRentRoom
            // 
            this.numericUpDownRentRoom.Enabled = false;
            this.numericUpDownRentRoom.Location = new System.Drawing.Point(120, 11);
            this.numericUpDownRentRoom.Name = "numericUpDownRentRoom";
            this.numericUpDownRentRoom.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownRentRoom.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "Numer tel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "Nazwisko";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Imie";
            // 
            // textBoxClientFirstName
            // 
            this.textBoxClientFirstName.Location = new System.Drawing.Point(97, 205);
            this.textBoxClientFirstName.Name = "textBoxClientFirstName";
            this.textBoxClientFirstName.Size = new System.Drawing.Size(174, 22);
            this.textBoxClientFirstName.TabIndex = 4;
            // 
            // textBoxClientPhone
            // 
            this.textBoxClientPhone.Location = new System.Drawing.Point(97, 272);
            this.textBoxClientPhone.Name = "textBoxClientPhone";
            this.textBoxClientPhone.Size = new System.Drawing.Size(174, 22);
            this.textBoxClientPhone.TabIndex = 6;
            // 
            // textBoxClientSecondName
            // 
            this.textBoxClientSecondName.Location = new System.Drawing.Point(97, 236);
            this.textBoxClientSecondName.Name = "textBoxClientSecondName";
            this.textBoxClientSecondName.Size = new System.Drawing.Size(174, 22);
            this.textBoxClientSecondName.TabIndex = 5;
            // 
            // buttonDeleteRent
            // 
            this.buttonDeleteRent.Location = new System.Drawing.Point(180, 320);
            this.buttonDeleteRent.Name = "buttonDeleteRent";
            this.buttonDeleteRent.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteRent.TabIndex = 9;
            this.buttonDeleteRent.Text = "Usun";
            this.buttonDeleteRent.UseVisualStyleBackColor = true;
            this.buttonDeleteRent.Click += new System.EventHandler(this.buttonDeleteRent_Click);
            // 
            // buttonEditRent
            // 
            this.buttonEditRent.Location = new System.Drawing.Point(100, 320);
            this.buttonEditRent.Name = "buttonEditRent";
            this.buttonEditRent.Size = new System.Drawing.Size(75, 23);
            this.buttonEditRent.TabIndex = 8;
            this.buttonEditRent.Text = "Edytuj";
            this.buttonEditRent.UseVisualStyleBackColor = true;
            this.buttonEditRent.Click += new System.EventHandler(this.buttonEditRent_Click);
            // 
            // buttonAddRent
            // 
            this.buttonAddRent.Location = new System.Drawing.Point(22, 320);
            this.buttonAddRent.Name = "buttonAddRent";
            this.buttonAddRent.Size = new System.Drawing.Size(75, 23);
            this.buttonAddRent.TabIndex = 7;
            this.buttonAddRent.Text = "Dodaj";
            this.buttonAddRent.UseVisualStyleBackColor = true;
            this.buttonAddRent.Click += new System.EventHandler(this.buttonAddRent_Click);
            // 
            // labelRent4
            // 
            this.labelRent4.AutoSize = true;
            this.labelRent4.Location = new System.Drawing.Point(9, 13);
            this.labelRent4.Name = "labelRent4";
            this.labelRent4.Size = new System.Drawing.Size(96, 17);
            this.labelRent4.TabIndex = 7;
            this.labelRent4.Text = "Numer pokoju";
            // 
            // labelRent3
            // 
            this.labelRent3.AutoSize = true;
            this.labelRent3.Location = new System.Drawing.Point(9, 92);
            this.labelRent3.Name = "labelRent3";
            this.labelRent3.Size = new System.Drawing.Size(92, 17);
            this.labelRent3.TabIndex = 5;
            this.labelRent3.Text = "Data wyjazdu";
            // 
            // labelRent2
            // 
            this.labelRent2.AutoSize = true;
            this.labelRent2.Location = new System.Drawing.Point(9, 38);
            this.labelRent2.Name = "labelRent2";
            this.labelRent2.Size = new System.Drawing.Size(103, 17);
            this.labelRent2.TabIndex = 4;
            this.labelRent2.Text = "Data przyjazdu";
            // 
            // dateTimePickerRent2
            // 
            this.dateTimePickerRent2.Enabled = false;
            this.dateTimePickerRent2.Location = new System.Drawing.Point(12, 112);
            this.dateTimePickerRent2.Name = "dateTimePickerRent2";
            this.dateTimePickerRent2.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerRent2.TabIndex = 3;
            // 
            // dateTimePickerRent1
            // 
            this.dateTimePickerRent1.Enabled = false;
            this.dateTimePickerRent1.Location = new System.Drawing.Point(12, 58);
            this.dateTimePickerRent1.Name = "dateTimePickerRent1";
            this.dateTimePickerRent1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerRent1.TabIndex = 2;
            this.dateTimePickerRent1.Value = new System.DateTime(2019, 7, 4, 18, 36, 30, 0);
            // 
            // labelRent1
            // 
            this.labelRent1.AutoSize = true;
            this.labelRent1.Location = new System.Drawing.Point(298, 4);
            this.labelRent1.Name = "labelRent1";
            this.labelRent1.Size = new System.Drawing.Size(69, 17);
            this.labelRent1.TabIndex = 1;
            this.labelRent1.Text = "Wynajmy:";
            // 
            // listBoxRents
            // 
            this.listBoxRents.FormattingEnabled = true;
            this.listBoxRents.ItemHeight = 16;
            this.listBoxRents.Location = new System.Drawing.Point(294, 24);
            this.listBoxRents.Name = "listBoxRents";
            this.listBoxRents.Size = new System.Drawing.Size(471, 308);
            this.listBoxRents.TabIndex = 10;
            this.listBoxRents.Click += new System.EventHandler(this.listBoxRents_Click);
            // 
            // tabPageRooms
            // 
            this.tabPageRooms.Controls.Add(this.buttonFiltr);
            this.tabPageRooms.Controls.Add(this.labelRooms8);
            this.tabPageRooms.Controls.Add(this.labelRooms7);
            this.tabPageRooms.Controls.Add(this.dateTimePickerRooms4);
            this.tabPageRooms.Controls.Add(this.dateTimePickerRooms3);
            this.tabPageRooms.Controls.Add(this.labelRooms6);
            this.tabPageRooms.Controls.Add(this.checkBoxRooms);
            this.tabPageRooms.Controls.Add(this.numericUpDownRooms1);
            this.tabPageRooms.Controls.Add(this.listBoxRooms);
            this.tabPageRooms.Location = new System.Drawing.Point(4, 25);
            this.tabPageRooms.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageRooms.Name = "tabPageRooms";
            this.tabPageRooms.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageRooms.Size = new System.Drawing.Size(772, 359);
            this.tabPageRooms.TabIndex = 1;
            this.tabPageRooms.Text = "Pokoje";
            this.tabPageRooms.UseVisualStyleBackColor = true;
            // 
            // buttonFiltr
            // 
            this.buttonFiltr.Location = new System.Drawing.Point(690, 7);
            this.buttonFiltr.Name = "buttonFiltr";
            this.buttonFiltr.Size = new System.Drawing.Size(63, 51);
            this.buttonFiltr.TabIndex = 4;
            this.buttonFiltr.Text = "Filtruj";
            this.buttonFiltr.UseVisualStyleBackColor = true;
            this.buttonFiltr.Click += new System.EventHandler(this.buttonFiltr_Click);
            // 
            // labelRooms8
            // 
            this.labelRooms8.AutoSize = true;
            this.labelRooms8.Location = new System.Drawing.Point(377, 21);
            this.labelRooms8.Name = "labelRooms8";
            this.labelRooms8.Size = new System.Drawing.Size(30, 17);
            this.labelRooms8.TabIndex = 7;
            this.labelRooms8.Text = "Do:";
            // 
            // labelRooms7
            // 
            this.labelRooms7.AutoSize = true;
            this.labelRooms7.Location = new System.Drawing.Point(139, 21);
            this.labelRooms7.Name = "labelRooms7";
            this.labelRooms7.Size = new System.Drawing.Size(31, 17);
            this.labelRooms7.TabIndex = 6;
            this.labelRooms7.Text = "Od:";
            // 
            // dateTimePickerRooms4
            // 
            this.dateTimePickerRooms4.Location = new System.Drawing.Point(409, 19);
            this.dateTimePickerRooms4.Name = "dateTimePickerRooms4";
            this.dateTimePickerRooms4.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerRooms4.TabIndex = 2;
            // 
            // dateTimePickerRooms3
            // 
            this.dateTimePickerRooms3.Location = new System.Drawing.Point(170, 20);
            this.dateTimePickerRooms3.Name = "dateTimePickerRooms3";
            this.dateTimePickerRooms3.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerRooms3.TabIndex = 1;
            // 
            // labelRooms6
            // 
            this.labelRooms6.AutoSize = true;
            this.labelRooms6.Location = new System.Drawing.Point(7, 21);
            this.labelRooms6.Name = "labelRooms6";
            this.labelRooms6.Size = new System.Drawing.Size(57, 17);
            this.labelRooms6.TabIndex = 3;
            this.labelRooms6.Text = "Ile osób";
            // 
            // checkBoxRooms
            // 
            this.checkBoxRooms.AutoSize = true;
            this.checkBoxRooms.Location = new System.Drawing.Point(617, 21);
            this.checkBoxRooms.Name = "checkBoxRooms";
            this.checkBoxRooms.Size = new System.Drawing.Size(67, 21);
            this.checkBoxRooms.TabIndex = 3;
            this.checkBoxRooms.Text = "Taras";
            this.checkBoxRooms.UseVisualStyleBackColor = true;
            // 
            // numericUpDownRooms1
            // 
            this.numericUpDownRooms1.Location = new System.Drawing.Point(70, 19);
            this.numericUpDownRooms1.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownRooms1.Name = "numericUpDownRooms1";
            this.numericUpDownRooms1.Size = new System.Drawing.Size(59, 22);
            this.numericUpDownRooms1.TabIndex = 0;
            // 
            // listBoxRooms
            // 
            this.listBoxRooms.FormattingEnabled = true;
            this.listBoxRooms.ItemHeight = 16;
            this.listBoxRooms.Location = new System.Drawing.Point(7, 64);
            this.listBoxRooms.Name = "listBoxRooms";
            this.listBoxRooms.Size = new System.Drawing.Size(746, 276);
            this.listBoxRooms.TabIndex = 10;
            this.listBoxRooms.DoubleClick += new System.EventHandler(this.listBoxRooms_DoubleClick);
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserName.Location = new System.Drawing.Point(316, 9);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(69, 23);
            this.labelUserName.TabIndex = 1;
            this.labelUserName.Text = "label1";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(15, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(187, 28);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Hotel   P I A S T";
            // 
            // listBoxEmployees
            // 
            this.listBoxEmployees.Location = new System.Drawing.Point(0, 0);
            this.listBoxEmployees.Name = "listBoxEmployees";
            this.listBoxEmployees.Size = new System.Drawing.Size(120, 96);
            this.listBoxEmployees.TabIndex = 0;
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(0, 0);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(100, 22);
            this.textBoxFirstName.TabIndex = 0;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(0, 0);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(100, 22);
            this.textBoxLastName.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(0, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 23);
            this.label9.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(0, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 23);
            this.label10.TabIndex = 0;
            // 
            // checkBoxAdmin
            // 
            this.checkBoxAdmin.Location = new System.Drawing.Point(0, 0);
            this.checkBoxAdmin.Name = "checkBoxAdmin";
            this.checkBoxAdmin.Size = new System.Drawing.Size(104, 24);
            this.checkBoxAdmin.TabIndex = 0;
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(0, 0);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(100, 22);
            this.textBoxPhone.TabIndex = 0;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(0, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 23);
            this.label11.TabIndex = 0;
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(0, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 23);
            this.label12.TabIndex = 0;
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(0, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(100, 23);
            this.label13.TabIndex = 0;
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Location = new System.Drawing.Point(0, 0);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(100, 22);
            this.textBoxLogin.TabIndex = 0;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(0, 0);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(100, 22);
            this.textBoxPassword.TabIndex = 0;
            // 
            // listBoxRoomsAdmin
            // 
            this.listBoxRoomsAdmin.Location = new System.Drawing.Point(0, 0);
            this.listBoxRoomsAdmin.Name = "listBoxRoomsAdmin";
            this.listBoxRoomsAdmin.Size = new System.Drawing.Size(120, 96);
            this.listBoxRoomsAdmin.TabIndex = 0;
            // 
            // numericUpDownGuests
            // 
            this.numericUpDownGuests.Location = new System.Drawing.Point(0, 0);
            this.numericUpDownGuests.Name = "numericUpDownGuests";
            this.numericUpDownGuests.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownGuests.TabIndex = 0;
            // 
            // numericUpDownIdRoom
            // 
            this.numericUpDownIdRoom.Location = new System.Drawing.Point(0, 0);
            this.numericUpDownIdRoom.Name = "numericUpDownIdRoom";
            this.numericUpDownIdRoom.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownIdRoom.TabIndex = 0;
            // 
            // numericUpDownSingleBeds
            // 
            this.numericUpDownSingleBeds.Location = new System.Drawing.Point(0, 0);
            this.numericUpDownSingleBeds.Name = "numericUpDownSingleBeds";
            this.numericUpDownSingleBeds.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownSingleBeds.TabIndex = 0;
            // 
            // numericUpDownDoubleBeds
            // 
            this.numericUpDownDoubleBeds.Location = new System.Drawing.Point(0, 0);
            this.numericUpDownDoubleBeds.Name = "numericUpDownDoubleBeds";
            this.numericUpDownDoubleBeds.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownDoubleBeds.TabIndex = 0;
            // 
            // checkBoxBalcony
            // 
            this.checkBoxBalcony.Location = new System.Drawing.Point(0, 0);
            this.checkBoxBalcony.Name = "checkBoxBalcony";
            this.checkBoxBalcony.Size = new System.Drawing.Size(104, 24);
            this.checkBoxBalcony.TabIndex = 0;
            // 
            // numericUpDownCost
            // 
            this.numericUpDownCost.Location = new System.Drawing.Point(0, 0);
            this.numericUpDownCost.Name = "numericUpDownCost";
            this.numericUpDownCost.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownCost.TabIndex = 0;
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(0, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(100, 23);
            this.label14.TabIndex = 0;
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(0, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(100, 23);
            this.label15.TabIndex = 0;
            // 
            // label16
            // 
            this.label16.Location = new System.Drawing.Point(0, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(100, 23);
            this.label16.TabIndex = 0;
            // 
            // label17
            // 
            this.label17.Location = new System.Drawing.Point(0, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(100, 23);
            this.label17.TabIndex = 0;
            // 
            // labelCost
            // 
            this.labelCost.Location = new System.Drawing.Point(0, 0);
            this.labelCost.Name = "labelCost";
            this.labelCost.Size = new System.Drawing.Size(100, 23);
            this.labelCost.TabIndex = 0;
            // 
            // buttonAddRoom
            // 
            this.buttonAddRoom.Location = new System.Drawing.Point(0, 0);
            this.buttonAddRoom.Name = "buttonAddRoom";
            this.buttonAddRoom.Size = new System.Drawing.Size(75, 23);
            this.buttonAddRoom.TabIndex = 0;
            // 
            // buttonEditRoom
            // 
            this.buttonEditRoom.Location = new System.Drawing.Point(0, 0);
            this.buttonEditRoom.Name = "buttonEditRoom";
            this.buttonEditRoom.Size = new System.Drawing.Size(75, 23);
            this.buttonEditRoom.TabIndex = 0;
            // 
            // buttonDeleteRoom
            // 
            this.buttonDeleteRoom.Location = new System.Drawing.Point(0, 0);
            this.buttonDeleteRoom.Name = "buttonDeleteRoom";
            this.buttonDeleteRoom.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteRoom.TabIndex = 0;
            // 
            // buttonDeleteEmployee
            // 
            this.buttonDeleteEmployee.Location = new System.Drawing.Point(0, 0);
            this.buttonDeleteEmployee.Name = "buttonDeleteEmployee";
            this.buttonDeleteEmployee.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteEmployee.TabIndex = 0;
            // 
            // buttonEditEmployee
            // 
            this.buttonEditEmployee.Location = new System.Drawing.Point(0, 0);
            this.buttonEditEmployee.Name = "buttonEditEmployee";
            this.buttonEditEmployee.Size = new System.Drawing.Size(75, 23);
            this.buttonEditEmployee.TabIndex = 0;
            // 
            // buttonAddEmployee
            // 
            this.buttonAddEmployee.Location = new System.Drawing.Point(0, 0);
            this.buttonAddEmployee.Name = "buttonAddEmployee";
            this.buttonAddEmployee.Size = new System.Drawing.Size(75, 23);
            this.buttonAddEmployee.TabIndex = 0;
            // 
            // errorProviderFirst
            // 
            this.errorProviderFirst.ContainerControl = this;
            // 
            // errorProviderLast
            // 
            this.errorProviderLast.ContainerControl = this;
            // 
            // errorProviderPhone
            // 
            this.errorProviderPhone.ContainerControl = this;
            // 
            // FormReception
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.labelUserName);
            this.Controls.Add(this.tabControlReception);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormReception";
            this.Text = "Hotel - Recpetion";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormReception_FormClosed);
            this.Load += new System.EventHandler(this.FormReception_Load);
            this.tabControlReception.ResumeLayout(false);
            this.tabPageRent.ResumeLayout(false);
            this.tabPageRent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRentRoom)).EndInit();
            this.tabPageRooms.ResumeLayout(false);
            this.tabPageRooms.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRooms1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGuests)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIdRoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSingleBeds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDoubleBeds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderFirst)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderLast)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPhone)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlReception;
        private System.Windows.Forms.TabPage tabPageRent;
        private System.Windows.Forms.TabPage tabPageRooms;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.DateTimePicker dateTimePickerRent2;
        private System.Windows.Forms.DateTimePicker dateTimePickerRent1;
        private System.Windows.Forms.Label labelRent1;
        private System.Windows.Forms.ListBox listBoxRents;
        private System.Windows.Forms.Button buttonAddRent;
        private System.Windows.Forms.Label labelRent4;
        private System.Windows.Forms.Label labelRent3;
        private System.Windows.Forms.Label labelRent2;
        private System.Windows.Forms.Label labelRooms8;
        private System.Windows.Forms.Label labelRooms7;
        private System.Windows.Forms.DateTimePicker dateTimePickerRooms4;
        private System.Windows.Forms.DateTimePicker dateTimePickerRooms3;
        private System.Windows.Forms.Label labelRooms6;
        private System.Windows.Forms.CheckBox checkBoxRooms;
        private System.Windows.Forms.NumericUpDown numericUpDownRooms1;
        private System.Windows.Forms.ListBox listBoxRooms;
        private System.Windows.Forms.TabPage tabPageEmployees;
        private System.Windows.Forms.TabPage tabPageRoomsAdmin;
        private System.Windows.Forms.Button buttonDeleteRent;
        private System.Windows.Forms.Button buttonEditRent;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.CheckBox checkBoxAdmin;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.ListBox listBoxEmployees;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown numericUpDownCost;
        private System.Windows.Forms.CheckBox checkBoxBalcony;
        private System.Windows.Forms.NumericUpDown numericUpDownDoubleBeds;
        private System.Windows.Forms.NumericUpDown numericUpDownSingleBeds;
        private System.Windows.Forms.NumericUpDown numericUpDownIdRoom;
        private System.Windows.Forms.NumericUpDown numericUpDownGuests;
        private System.Windows.Forms.ListBox listBoxRoomsAdmin;
        private System.Windows.Forms.Button buttonDeleteEmployee;
        private System.Windows.Forms.Button buttonEditEmployee;
        private System.Windows.Forms.Button buttonAddEmployee;
        private System.Windows.Forms.Button buttonDeleteRoom;
        private System.Windows.Forms.Button buttonEditRoom;
        private System.Windows.Forms.Button buttonAddRoom;
        private System.Windows.Forms.Label labelCost;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxClientFirstName;
        private System.Windows.Forms.TextBox textBoxClientPhone;
        private System.Windows.Forms.TextBox textBoxClientSecondName;
        private System.Windows.Forms.Button buttonFiltr;
        private System.Windows.Forms.NumericUpDown numericUpDownRentRoom;
        private System.Windows.Forms.ErrorProvider errorProviderFirst;
        private System.Windows.Forms.ErrorProvider errorProviderLast;
        private System.Windows.Forms.ErrorProvider errorProviderPhone;
    }
}