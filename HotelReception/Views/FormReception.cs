using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelReception
{
    public partial class FormReception : Form, IReception
    {
        public FormReception()
        {
            InitializeComponent();
        }
        #region Properties
        private Room currentRoom = new Room();
        private Room CurrentRoom
        {
            get
            {
                currentRoom.Idroom = (int)numericUpDownIdRoom.Value;
                currentRoom.Guests = (int)numericUpDownGuests.Value;
                currentRoom.SingleBeds =(int)numericUpDownSingleBeds.Value;
                currentRoom.DoubleBeds = (int)numericUpDownDoubleBeds.Value;
                currentRoom.Occupied = false;
                currentRoom.Balcony = checkBoxBalcony.Checked;
                currentRoom.Cost = Double.Parse(textBoxCost.Text);


                return currentRoom;
            }
            set
            {
                numericUpDownIdRoom.Value = (decimal)value.Idroom;
                currentRoom.Idroom = value.Idroom;
                numericUpDownGuests.Value = value.Guests;
                numericUpDownSingleBeds.Value = value.SingleBeds;
                numericUpDownDoubleBeds.Value = value.DoubleBeds;
                checkBoxBalcony.Checked = value.Balcony;
                textBoxCost.Text = value.Cost.ToString();
            }
        }
        private Rent currentRent = new Rent();
        private Rent CurrentRent
        {
            get
            {
                currentRent.Idroom = (int)numericUpDownRentRoom.Value;
                currentRent.Start = dateTimePickerRent1.Value;
                currentRent.End = dateTimePickerRent2.Value;
                currentRent.Cost = 0;
                currentRent.Firstname = textBoxClientFirstName.Text;
                currentRent.Lastname = textBoxClientSecondName.Text;
                currentRent.Phone = textBoxClientPhone.Text;
                return currentRent;
            }
            set
            {
                numericUpDownRentRoom.Value = value.Idroom;
                dateTimePickerRent1.Value = value.Start;
                dateTimePickerRent2.Value = value.End;
                textBoxClientFirstName.Text = value.Firstname;
                textBoxClientSecondName.Text = value.Lastname;
                textBoxClientPhone.Text = value.Phone;
            }
        }

        private Employee currentEmployee =new Employee();
        private Employee CurrentEmployee
        {
            get
            {
                currentEmployee.Idworker = null;
                currentEmployee.FirstName = textBoxFirstName.Text;
                currentEmployee.LastName = textBoxLastName.Text;
                currentEmployee.IsAdmin = checkBoxAdmin.Checked;
                currentEmployee.Phone = textBoxPhone.Text;
                currentEmployee.Login = textBoxLogin.Text;
                currentEmployee.Password = textBoxPassword.Text;
                return currentEmployee;
            }
            set
            {
                textBoxFirstName.Text = value.FirstName;
                textBoxLastName.Text = value.LastName;
                checkBoxAdmin.Checked = value.IsAdmin;
                textBoxPhone.Text = value.Phone;
                textBoxLogin.Text = value.Login;
                textBoxPassword.Text = value.Password;
            }
            
        }
        #endregion

        #region IReception
        public string UserName { set => labelUserName.Text = "Jestes zalogowany jako: "+value; }
        public bool IfAdmin { get;  set; }
        public List<Employee> Employees
        {
            set
            {
                listBoxEmployees.Items.Clear();
                listBoxEmployees.Items.AddRange(value.ToArray());
            }
        }

        public List<Rent> Rents
        {
            set
            {
                listBoxRents.Items.Clear();
                listBoxRents.Items.AddRange(value.ToArray());
            }
        }

        public List<Room> Rooms
        {
            set
            {
                listBoxRooms.Items.Clear();
                listBoxRoomsAdmin.Items.Clear();
                listBoxRooms.Items.AddRange(value.ToArray());
                listBoxRoomsAdmin.Items.AddRange(value.ToArray());
            }
        }

        public event Action GetInfo;
        public event Action SelectEmployees;
        public event Action SelectRooms;
        public event Action SelectRents;

        public event Action<Rent> InsertRent;
        public event Action<Room> InsertRoom;
        public event Action<Employee> InsertEmployee;
        public event Action<Rent> UpdateRent;
        public event Action<Room> UpdateRoom;
        public event Action<Employee> UpdateEmployee;
        public event Action<int, DateTime, DateTime> DeleteRent;
        public event Action<int> DeleteRoom;
        public event Action<int> DeleteEmployee;
        public event Action<int,DateTime,DateTime,bool> SelectRoomsFilter;
        #endregion

        private void FormReception_Load(object sender, EventArgs e)
        {

            GetInfo?.Invoke();
            if (IfAdmin)
            {
                Console.WriteLine("user jest adminem");
                //dodatkowa funkcjonalnosc ktora posiada admin 
                this.tabPageEmployees = new System.Windows.Forms.TabPage();
                this.tabPageRoomsAdmin = new System.Windows.Forms.TabPage();

                #region tabPageEmployees
                // 
                // tabPageEmployees
                // 
                this.tabPageEmployees.Controls.Add(this.buttonDeleteEmployee);
                this.tabPageEmployees.Controls.Add(this.buttonEditEmployee);
                this.tabPageEmployees.Controls.Add(this.buttonAddEmployee);
                this.tabPageEmployees.Controls.Add(this.textBoxPassword);
                this.tabPageEmployees.Controls.Add(this.textBoxLogin);
                this.tabPageEmployees.Controls.Add(this.label13);
                this.tabPageEmployees.Controls.Add(this.label12);
                this.tabPageEmployees.Controls.Add(this.label11);
                this.tabPageEmployees.Controls.Add(this.textBoxPhone);
                this.tabPageEmployees.Controls.Add(this.checkBoxAdmin);
                this.tabPageEmployees.Controls.Add(this.label10);
                this.tabPageEmployees.Controls.Add(this.label9);
                this.tabPageEmployees.Controls.Add(this.textBoxLastName);
                this.tabPageEmployees.Controls.Add(this.textBoxFirstName);
                this.tabPageEmployees.Controls.Add(this.listBoxEmployees);
                this.tabPageEmployees.Location = new System.Drawing.Point(4, 25);
                this.tabPageEmployees.Name = "tabPageEmployees";
                this.tabPageEmployees.Size = new System.Drawing.Size(760, 359);
                this.tabPageEmployees.TabIndex = 2;
                this.tabPageEmployees.Text = "[Admin] Pracownicy";
                this.tabPageEmployees.UseVisualStyleBackColor = true;

                // 
                // listBoxEmployees
                // 
                this.listBoxEmployees.FormattingEnabled = true;
                this.listBoxEmployees.ItemHeight = 16;
                this.listBoxEmployees.Location = new System.Drawing.Point(280, 16);
                this.listBoxEmployees.Name = "listBox3";
                this.listBoxEmployees.Size = new System.Drawing.Size(270, 270);
                this.listBoxEmployees.TabIndex = 0;
                this.listBoxEmployees.Click += new System.EventHandler(this.listBoxEmployees_Click);

                // 
                // label9
                // 
                this.label9.AutoSize = true;
                this.label9.Location = new System.Drawing.Point(20, 100);
                this.label9.Name = "label9";
                this.label9.Size = new System.Drawing.Size(33, 17);
                this.label9.TabIndex = 3;
                this.label9.Text = "Imie";
                // 
                // textBoxFirstName
                // 
                this.textBoxFirstName.Location = new System.Drawing.Point(93, 100);
                this.textBoxFirstName.Name = "textBoxFirstName";
                this.textBoxFirstName.Size = new System.Drawing.Size(160, 22);
                this.textBoxFirstName.TabIndex = 1;
                // 
                // label10
                // 
                this.label10.AutoSize = true;
                this.label10.Location = new System.Drawing.Point(20, 140);
                this.label10.Name = "label10";
                this.label10.Size = new System.Drawing.Size(67, 17);
                this.label10.TabIndex = 4;
                this.label10.Text = "Nazwisko";
                // 
                // textBoxLastName
                // 
                this.textBoxLastName.Location = new System.Drawing.Point(93, 140);
                this.textBoxLastName.Name = "textBoxLastName";
                this.textBoxLastName.Size = new System.Drawing.Size(160, 22);
                this.textBoxLastName.TabIndex = 2;
                // 
                // checkBoxAdmin
                // 
                this.checkBoxAdmin.AutoSize = true;
                this.checkBoxAdmin.Location = new System.Drawing.Point(60, 180);
                this.checkBoxAdmin.Name = "checkBoxAdmin";
                this.checkBoxAdmin.Size = new System.Drawing.Size(69, 21);
                this.checkBoxAdmin.TabIndex = 5;
                this.checkBoxAdmin.Text = "Admin";
                this.checkBoxAdmin.UseVisualStyleBackColor = true;
                // 
                // textBox1
                // 
                this.textBoxPhone.Location = new System.Drawing.Point(93, 220);
                this.textBoxPhone.Name = "textBoxPhone";
                this.textBoxPhone.Size = new System.Drawing.Size(160, 22);
                this.textBoxPhone.TabIndex = 6;
                // 
                // label11
                // 
                this.label11.AutoSize = true;
                this.label11.Location = new System.Drawing.Point(20, 220);
                this.label11.Name = "label11";
                this.label11.Size = new System.Drawing.Size(73, 17);
                this.label11.TabIndex = 7;
                this.label11.Text = "Numer tel.";
                // 
                // label12
                // 
                this.label12.AutoSize = true;
                this.label12.Location = new System.Drawing.Point(20, 20);
                this.label12.Name = "label12";
                this.label12.Size = new System.Drawing.Size(43, 17);
                this.label12.TabIndex = 8;
                this.label12.Text = "Login";
                // 
                // textBoxLogin
                // 
                this.textBoxLogin.Location = new System.Drawing.Point(93, 20);
                this.textBoxLogin.Name = "textBoxLogin";
                this.textBoxLogin.Size = new System.Drawing.Size(160, 22);
                this.textBoxLogin.TabIndex = 10;
                // 
                // label13
                // 
                this.label13.AutoSize = true;
                this.label13.Location = new System.Drawing.Point(20, 60);
                this.label13.Name = "label13";
                this.label13.Size = new System.Drawing.Size(44, 17);
                this.label13.TabIndex = 9;
                this.label13.Text = "Haslo";
                // 
                // textBoxPassword
                // 
                this.textBoxPassword.Location = new System.Drawing.Point(93, 60);
                this.textBoxPassword.Name = "textBoxPassword";
                this.textBoxPassword.Size = new System.Drawing.Size(160, 22);
                this.textBoxPassword.TabIndex = 11;

                // 
                // buttonDeleteEmployee
                // 
                this.buttonDeleteEmployee.Location = new System.Drawing.Point(180, 260);
                this.buttonDeleteEmployee.Name = "buttonDeleteEmployee";
                this.buttonDeleteEmployee.Size = new System.Drawing.Size(75, 23);
                this.buttonDeleteEmployee.TabIndex = 16;
                this.buttonDeleteEmployee.Text = "Usun";
                this.buttonDeleteEmployee.UseVisualStyleBackColor = true;
                this.buttonDeleteEmployee.Click += new System.EventHandler(this.buttonDeleteEmployee_Click);
                // 
                // buttonEditEmployee
                // 
                this.buttonEditEmployee.Location = new System.Drawing.Point(100, 260);
                this.buttonEditEmployee.Name = "buttonEditEmployee";
                this.buttonEditEmployee.Size = new System.Drawing.Size(75, 23);
                this.buttonEditEmployee.TabIndex = 15;
                this.buttonEditEmployee.Text = "Edytuj";
                this.buttonEditEmployee.UseVisualStyleBackColor = true;
                this.buttonEditEmployee.Click += new System.EventHandler(this.buttonEditEmployee_Click);
                // 
                // buttonAddEmployee
                // 
                this.buttonAddEmployee.Location = new System.Drawing.Point(20, 260);
                this.buttonAddEmployee.Name = "buttonAddEmployee";
                this.buttonAddEmployee.Size = new System.Drawing.Size(75, 23);
                this.buttonAddEmployee.TabIndex = 14;
                this.buttonAddEmployee.Text = "Dodaj";
                this.buttonAddEmployee.UseVisualStyleBackColor = true;
                this.buttonAddEmployee.Click += new System.EventHandler(this.buttonAddEmployee_Click);
                #endregion

                #region tabPageRooms
                // 
                // tabPageRoomsAdmin
                // 
                this.tabPageRoomsAdmin.Controls.Add(this.buttonDeleteRoom);
                this.tabPageRoomsAdmin.Controls.Add(this.buttonEditRoom);
                this.tabPageRoomsAdmin.Controls.Add(this.buttonAddRoom);
                this.tabPageRoomsAdmin.Controls.Add(this.label17);
                this.tabPageRoomsAdmin.Controls.Add(this.label16);
                this.tabPageRoomsAdmin.Controls.Add(this.label15);
                this.tabPageRoomsAdmin.Controls.Add(this.label14);
                this.tabPageRoomsAdmin.Controls.Add(this.labelCost);
                this.tabPageRoomsAdmin.Controls.Add(this.textBoxCost);
                this.tabPageRoomsAdmin.Controls.Add(this.checkBoxBalcony);
                this.tabPageRoomsAdmin.Controls.Add(this.numericUpDownDoubleBeds);
                this.tabPageRoomsAdmin.Controls.Add(this.numericUpDownSingleBeds);
                this.tabPageRoomsAdmin.Controls.Add(this.numericUpDownIdRoom);
                this.tabPageRoomsAdmin.Controls.Add(this.numericUpDownGuests);
                this.tabPageRoomsAdmin.Controls.Add(this.listBoxRoomsAdmin);
                this.tabPageRoomsAdmin.Location = new System.Drawing.Point(4, 25);
                this.tabPageRoomsAdmin.Name = "tabPageRoomsAdmin";
                this.tabPageRoomsAdmin.Size = new System.Drawing.Size(760, 359);
                this.tabPageRoomsAdmin.TabIndex = 3;
                this.tabPageRoomsAdmin.Text = "[Admin] Pokoje";
                this.tabPageRoomsAdmin.UseVisualStyleBackColor = true;

                // 
                // buttonAddRoom
                // 
                this.buttonAddRoom.Location = new System.Drawing.Point(20, 260);
                this.buttonAddRoom.Name = "buttonAddRoom";
                this.buttonAddRoom.Size = new System.Drawing.Size(75, 23);
                this.buttonAddRoom.TabIndex = 11;
                this.buttonAddRoom.Text = "Dodaj";
                this.buttonAddRoom.UseVisualStyleBackColor = true;
                this.buttonAddRoom.Click += new System.EventHandler(this.buttonAddRoom_Click);
                // 
                // buttonEditRoom
                // 
                this.buttonEditRoom.Location = new System.Drawing.Point(100, 260);
                this.buttonEditRoom.Name = "buttonEditRoom";
                this.buttonEditRoom.Size = new System.Drawing.Size(75, 23);
                this.buttonEditRoom.TabIndex = 12;
                this.buttonEditRoom.Text = "Edytuj";
                this.buttonEditRoom.UseVisualStyleBackColor = true;
                this.buttonEditRoom.Click += new System.EventHandler(this.buttonEditRoom_Click);
                // 
                // buttonDeleteRoom
                // 
                this.buttonDeleteRoom.Location = new System.Drawing.Point(180, 260);
                this.buttonDeleteRoom.Name = "buttonDeleteRoom";
                this.buttonDeleteRoom.Size = new System.Drawing.Size(75, 23);
                this.buttonDeleteRoom.TabIndex = 13;
                this.buttonDeleteRoom.Text = "Usun";
                this.buttonDeleteRoom.UseVisualStyleBackColor = true;
                this.buttonDeleteRoom.Click += new System.EventHandler(this.buttonDeleteRoom_Click);
                // 
                // label14
                // 
                this.label14.AutoSize = true;
                this.label14.Location = new System.Drawing.Point(20, 20);
                this.label14.Name = "label14";
                this.label14.Size = new System.Drawing.Size(96, 17);
                this.label14.TabIndex = 7;
                this.label14.Text = "Numer pokoju";
                // 
                // label15
                // 
                this.label15.AutoSize = true;
                this.label15.Location = new System.Drawing.Point(20, 60);
                this.label15.Name = "label15";
                this.label15.Size = new System.Drawing.Size(71, 17);
                this.label15.TabIndex = 8;
                this.label15.Text = "Ilosc osob";
                // 
                // label16
                // 
                this.label16.AutoSize = true;
                this.label16.Location = new System.Drawing.Point(20, 100);
                this.label16.Name = "label16";
                this.label16.Size = new System.Drawing.Size(163, 17);
                this.label16.TabIndex = 9;
                this.label16.Text = "Ilosc pojedynczych lozek";
                // 
                // label17
                // 
                this.label17.AutoSize = true;
                this.label17.Location = new System.Drawing.Point(20, 140);
                this.label17.Name = "label17";
                this.label17.Size = new System.Drawing.Size(151, 17);
                this.label17.TabIndex = 10;
                this.label17.Text = "Ilosc podwojnych lozek";
                // 
                // labelCost
                // 
                this.labelCost.AutoSize = true;
                this.labelCost.Location = new System.Drawing.Point(20, 220);
                this.labelCost.Name = "labelCost";
                this.labelCost.Size = new System.Drawing.Size(151, 17);
                this.labelCost.TabIndex = 10;
                this.labelCost.Text = "Koszt";
                // 
                // listBoxRoomsAdmin
                // 
                this.listBoxRoomsAdmin.FormattingEnabled = true;
                this.listBoxRoomsAdmin.ItemHeight = 16;
                this.listBoxRoomsAdmin.Location = new System.Drawing.Point(324, 10);
                this.listBoxRoomsAdmin.Name = "listBox4";
                this.listBoxRoomsAdmin.Size = new System.Drawing.Size(230, 270);
                this.listBoxRoomsAdmin.TabIndex = 0;
                this.listBoxRoomsAdmin.Click += new System.EventHandler(this.listBoxRoomsAdmin_Click);
                // 
                // numericUpDownGuests
                // 
                this.numericUpDownGuests.Location = new System.Drawing.Point(193, 60);
                this.numericUpDownGuests.Name = "numericUpDownGuests";
                this.numericUpDownGuests.Size = new System.Drawing.Size(120, 22);
                this.numericUpDownGuests.TabIndex = 1;
                // 
                // numericUpDownIdRoom
                // 
                this.numericUpDownIdRoom.Location = new System.Drawing.Point(193, 20);
                this.numericUpDownIdRoom.Name = "numericUpDownIdRoom";
                this.numericUpDownIdRoom.Size = new System.Drawing.Size(120, 22);
                this.numericUpDownIdRoom.TabIndex = 2;
                // 
                // numericUpDownSingleBeds
                // 
                this.numericUpDownSingleBeds.Location = new System.Drawing.Point(193, 100);
                this.numericUpDownSingleBeds.Name = "numericUpDownSingleBeds";
                this.numericUpDownSingleBeds.Size = new System.Drawing.Size(120, 22);
                this.numericUpDownSingleBeds.TabIndex = 3;
                // 
                // numericUpDownDoubleBeds
                // 
                this.numericUpDownDoubleBeds.Location = new System.Drawing.Point(193, 140);
                this.numericUpDownDoubleBeds.Name = "numericUpDownDoublebeds";
                this.numericUpDownDoubleBeds.Size = new System.Drawing.Size(120, 22);
                this.numericUpDownDoubleBeds.TabIndex = 4;
                // 
                // checkBoxBalcony
                // 
                this.checkBoxBalcony.AutoSize = true;
                this.checkBoxBalcony.Location = new System.Drawing.Point(193, 180);
                this.checkBoxBalcony.Name = "checkBoxBalcony";
                this.checkBoxBalcony.Size = new System.Drawing.Size(67, 21);
                this.checkBoxBalcony.TabIndex = 5;
                this.checkBoxBalcony.Text = "Taras";
                this.checkBoxBalcony.UseVisualStyleBackColor = true;
                // 
                // textBoxCost
                // 
                this.textBoxCost.Location = new System.Drawing.Point(193, 220);
                this.textBoxCost.Name = "textBoxCost";
                this.textBoxCost.Size = new System.Drawing.Size(120, 22);
                this.textBoxCost.TabIndex = 6;
                #endregion


                //this.tabPageEmployees.SuspendLayout();
                //this.tabPageRoomsAdmin.SuspendLayout();

                this.tabControlReception.Controls.Add(this.tabPageEmployees);
                this.tabControlReception.Controls.Add(this.tabPageRoomsAdmin);

                //this.tabPageEmployees.ResumeLayout(false);
                //this.tabPageEmployees.PerformLayout();
                //this.tabPageRoomsAdmin.ResumeLayout(false);
                //this.tabPageRoomsAdmin.PerformLayout();
                
            }
            else
            {
                buttonEditRent.Visible = false;
                buttonDeleteRent.Visible = false;
            }
            UpdateLists();
        }

        private void UpdateLists()
        {
            if (tabControlReception.SelectedIndex == 0)
            {
                SelectRents?.Invoke();
            }
            if (tabControlReception.SelectedIndex == 1)
            {
                SelectRooms?.Invoke();
            }
            if (tabControlReception.SelectedIndex == 2)
            {
                SelectEmployees?.Invoke();
            }
            if (tabControlReception.SelectedIndex == 3)
            {
                SelectRooms?.Invoke();
            }
        }

        #region events
        private void tabControlReception_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateLists();
        }

        private void FormReception_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (IfAdmin)
            {
                this.tabControlReception.Controls[3].Controls.Clear();
                this.tabControlReception.Controls.RemoveAt(3);
                this.tabControlReception.Controls[2].Controls.Clear();
                this.tabControlReception.Controls.RemoveAt(2);
            }
        }

        private void buttonAddRent_Click(object sender, EventArgs e)
        {
            InsertRent?.Invoke(CurrentRent);
            UpdateLists();
        }

        private void buttonEditRent_Click(object sender, EventArgs e)
        {
            UpdateRent?.Invoke(CurrentRent);
            UpdateLists();
        }

        private void buttonDeleteRent_Click(object sender, EventArgs e)
        {
            if (listBoxRents.SelectedIndex != -1)
            {
                Rent tmp = (Rent)listBoxRents.SelectedItem;
                DeleteRent?.Invoke(tmp.Idroom, tmp.Start, tmp.End);
                UpdateLists();
            }
            else MessageBox.Show("Wybierz wynajem z listy");
        }

        private void buttonFiltr_Click(object sender, EventArgs e)
        {
            SelectRoomsFilter?.Invoke((int)numericUpDownRooms1.Value,dateTimePickerRooms3.Value,dateTimePickerRooms4.Value,checkBoxRooms.Checked);
        }

        private void buttonDeleteEmployee_Click(object sender, EventArgs e)
        {
            if (listBoxEmployees.SelectedIndex != -1)
            {
                Employee tmp = (Employee)listBoxEmployees.SelectedItem;
                DeleteEmployee?.Invoke((int)tmp.Idworker);
                UpdateLists();
            }
            else MessageBox.Show("Wybierz pracownika z listy");
        }

        private void buttonEditEmployee_Click(object sender, EventArgs e)
        {
            UpdateEmployee?.Invoke(CurrentEmployee);
            UpdateLists();
        }

        private void buttonAddEmployee_Click(object sender, EventArgs e)
        {
            InsertEmployee?.Invoke(CurrentEmployee);
            UpdateLists();
        }

        private void buttonDeleteRoom_Click(object sender, EventArgs e)
        {
            if (listBoxRooms.SelectedIndex != -1)
            {
                Room tmp = (Room)listBoxRoomsAdmin.SelectedItem;
                DeleteRoom?.Invoke((int)tmp.Idroom);
                UpdateLists();
            }
            else MessageBox.Show("Wybierz pokoj z listy");
        }

        private void buttonEditRoom_Click(object sender, EventArgs e)
        {
            UpdateRoom?.Invoke(CurrentRoom);
            UpdateLists();
        }

        private void buttonAddRoom_Click(object sender, EventArgs e)
        {
            InsertRoom?.Invoke(CurrentRoom);
            UpdateLists();
        }

        private void listBoxRents_Click(object sender, EventArgs e)
        {
            CurrentRent = (Rent)listBoxRents.SelectedItem;
        }

        private void listBoxEmployees_Click(object sender, EventArgs e)
        {
            CurrentEmployee = (Employee)listBoxEmployees.SelectedItem;
        }

        private void listBoxRoomsAdmin_Click(object sender, EventArgs e)
        {
            CurrentRoom = (Room)listBoxRoomsAdmin.SelectedItem;
        }
        #endregion

        private void listBoxRooms_DoubleClick(object sender, EventArgs e)
        {
            if(listBoxRooms.SelectedIndex!=-1)
            {
                tabControlReception.SelectedIndex = 0;
                Rent tmp = new Rent();
                CurrentRoom = (Room)listBoxRooms.SelectedItem;
                tmp.Idroom = (int)currentRoom.Idroom;
                tmp.Start = dateTimePickerRooms3.Value;
                tmp.End = dateTimePickerRooms4.Value;
                tmp.Firstname = "";
                tmp.Lastname = "";
                tmp.Phone = "";
                CurrentRent = tmp;
            }
        }
    }
}
