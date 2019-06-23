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

        public string UserName { set => labelUserName.Text = "Jestes zalogowany jako: "+value; }
        public bool IfAdmin { get;  set; }

        public event Action GetInfo;

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
                this.tabPageEmployees.Controls.Add(this.textBox1);
                this.tabPageEmployees.Controls.Add(this.checkBox2);
                this.tabPageEmployees.Controls.Add(this.label10);
                this.tabPageEmployees.Controls.Add(this.label9);
                this.tabPageEmployees.Controls.Add(this.textBoxLastName);
                this.tabPageEmployees.Controls.Add(this.textBoxFirstName);
                this.tabPageEmployees.Controls.Add(this.listBox3);
                this.tabPageEmployees.Location = new System.Drawing.Point(4, 25);
                this.tabPageEmployees.Name = "tabPageEmployees";
                this.tabPageEmployees.Size = new System.Drawing.Size(760, 359);
                this.tabPageEmployees.TabIndex = 2;
                this.tabPageEmployees.Text = "[Admin] Pracownicy";
                this.tabPageEmployees.UseVisualStyleBackColor = true;

                // 
                // listBox3
                // 
                this.listBox3.FormattingEnabled = true;
                this.listBox3.ItemHeight = 16;
                this.listBox3.Location = new System.Drawing.Point(280, 16);
                this.listBox3.Name = "listBox3";
                this.listBox3.Size = new System.Drawing.Size(270, 270);
                this.listBox3.TabIndex = 0;
                
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
                // checkBox2
                // 
                this.checkBox2.AutoSize = true;
                this.checkBox2.Location = new System.Drawing.Point(60, 180);
                this.checkBox2.Name = "checkBox2";
                this.checkBox2.Size = new System.Drawing.Size(69, 21);
                this.checkBox2.TabIndex = 5;
                this.checkBox2.Text = "Admin";
                this.checkBox2.UseVisualStyleBackColor = true;
                // 
                // textBox1
                // 
                this.textBox1.Location = new System.Drawing.Point(93, 220);
                this.textBox1.Name = "textBox1";
                this.textBox1.Size = new System.Drawing.Size(160, 22);
                this.textBox1.TabIndex = 6;
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
                // 
                // buttonEditEmployee
                // 
                this.buttonEditEmployee.Location = new System.Drawing.Point(100, 260);
                this.buttonEditEmployee.Name = "buttonEditEmployee";
                this.buttonEditEmployee.Size = new System.Drawing.Size(75, 23);
                this.buttonEditEmployee.TabIndex = 15;
                this.buttonEditEmployee.Text = "Edytuj";
                this.buttonEditEmployee.UseVisualStyleBackColor = true;
                // 
                // buttonAddEmployee
                // 
                this.buttonAddEmployee.Location = new System.Drawing.Point(20, 260);
                this.buttonAddEmployee.Name = "buttonAddEmployee";
                this.buttonAddEmployee.Size = new System.Drawing.Size(75, 23);
                this.buttonAddEmployee.TabIndex = 14;
                this.buttonAddEmployee.Text = "Dodaj";
                this.buttonAddEmployee.UseVisualStyleBackColor = true;
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
                this.tabPageRoomsAdmin.Controls.Add(this.textBox2);
                this.tabPageRoomsAdmin.Controls.Add(this.checkBox3);
                this.tabPageRoomsAdmin.Controls.Add(this.numericUpDown5);
                this.tabPageRoomsAdmin.Controls.Add(this.numericUpDown4);
                this.tabPageRoomsAdmin.Controls.Add(this.numericUpDown3);
                this.tabPageRoomsAdmin.Controls.Add(this.numericUpDown2);
                this.tabPageRoomsAdmin.Controls.Add(this.listBox4);
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
                // 
                // buttonEditRoom
                // 
                this.buttonEditRoom.Location = new System.Drawing.Point(100, 260);
                this.buttonEditRoom.Name = "buttonEditRoom";
                this.buttonEditRoom.Size = new System.Drawing.Size(75, 23);
                this.buttonEditRoom.TabIndex = 12;
                this.buttonEditRoom.Text = "Edytuj";
                this.buttonEditRoom.UseVisualStyleBackColor = true;
                // 
                // buttonDeleteRoom
                // 
                this.buttonDeleteRoom.Location = new System.Drawing.Point(180, 260);
                this.buttonDeleteRoom.Name = "buttonDeleteRoom";
                this.buttonDeleteRoom.Size = new System.Drawing.Size(75, 23);
                this.buttonDeleteRoom.TabIndex = 13;
                this.buttonDeleteRoom.Text = "Usun";
                this.buttonDeleteRoom.UseVisualStyleBackColor = true;

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
                // listBox4
                // 
                this.listBox4.FormattingEnabled = true;
                this.listBox4.ItemHeight = 16;
                this.listBox4.Location = new System.Drawing.Point(324, 10);
                this.listBox4.Name = "listBox4";
                this.listBox4.Size = new System.Drawing.Size(230, 270);
                this.listBox4.TabIndex = 0;
                // 
                // numericUpDown2
                // 
                this.numericUpDown2.Location = new System.Drawing.Point(193, 20);
                this.numericUpDown2.Name = "numericUpDown2";
                this.numericUpDown2.Size = new System.Drawing.Size(120, 22);
                this.numericUpDown2.TabIndex = 1;
                // 
                // numericUpDown3
                // 
                this.numericUpDown3.Location = new System.Drawing.Point(193, 60);
                this.numericUpDown3.Name = "numericUpDown3";
                this.numericUpDown3.Size = new System.Drawing.Size(120, 22);
                this.numericUpDown3.TabIndex = 2;
                // 
                // numericUpDown4
                // 
                this.numericUpDown4.Location = new System.Drawing.Point(193, 100);
                this.numericUpDown4.Name = "numericUpDown4";
                this.numericUpDown4.Size = new System.Drawing.Size(120, 22);
                this.numericUpDown4.TabIndex = 3;
                // 
                // numericUpDown5
                // 
                this.numericUpDown5.Location = new System.Drawing.Point(193, 140);
                this.numericUpDown5.Name = "numericUpDown5";
                this.numericUpDown5.Size = new System.Drawing.Size(120, 22);
                this.numericUpDown5.TabIndex = 4;
                // 
                // checkBox3
                // 
                this.checkBox3.AutoSize = true;
                this.checkBox3.Location = new System.Drawing.Point(193, 180);
                this.checkBox3.Name = "checkBox3";
                this.checkBox3.Size = new System.Drawing.Size(67, 21);
                this.checkBox3.TabIndex = 5;
                this.checkBox3.Text = "Taras";
                this.checkBox3.UseVisualStyleBackColor = true;
                // 
                // textBox2
                // 
                this.textBox2.Location = new System.Drawing.Point(193, 220);
                this.textBox2.Name = "textBox2";
                this.textBox2.Size = new System.Drawing.Size(120, 22);
                this.textBox2.TabIndex = 6;
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
    }
}
