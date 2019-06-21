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

        public string UserName { set => labelUserName.Text = value; }
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
                // tabPageRoomsAdmin
                // 
                this.tabPageRoomsAdmin.Controls.Add(this.buttonDeleteRoom);
                this.tabPageRoomsAdmin.Controls.Add(this.buttonEditRoom);
                this.tabPageRoomsAdmin.Controls.Add(this.buttonAddRoom);
                this.tabPageRoomsAdmin.Controls.Add(this.label17);
                this.tabPageRoomsAdmin.Controls.Add(this.label16);
                this.tabPageRoomsAdmin.Controls.Add(this.label15);
                this.tabPageRoomsAdmin.Controls.Add(this.label14);
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

                this.tabPageEmployees.SuspendLayout();
                this.tabPageRoomsAdmin.SuspendLayout();

                this.tabControlReception.Controls.Add(this.tabPageEmployees);
                this.tabControlReception.Controls.Add(this.tabPageRoomsAdmin);

                this.tabPageEmployees.ResumeLayout(false);
                this.tabPageEmployees.PerformLayout();
                this.tabPageRoomsAdmin.ResumeLayout(false);
                this.tabPageRoomsAdmin.PerformLayout();
            }
            else
            {
                buttonEdit.Visible = false;
                buttonDelete.Visible = false;
            }

        }
    }
}
