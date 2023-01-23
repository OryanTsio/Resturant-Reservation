using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace LinuxOs_Project
{
    public partial class ResForm : Form
    {
        string placeSitting;
        public ResForm()
        {
            InitializeComponent();
            
            
            
            
        }
        public ResForm(string a)
        {
            InitializeComponent();
            //for (int i = 0; i < Controls.Count; i++)
            //{
            //    if (Controls[i] is RadioButton)
            //        ((RadioButton)Controls[i]).CheckedChanged+= radioBtn_Click;
            //}
           
        }

        private void ResForm_Load(object sender, EventArgs e)
        {}

        private void lblTitle_Click(object sender, EventArgs e)
        {}

        public void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lblNumOfPeople_Click(object sender, EventArgs e)
        {}

        private void grpTable_Enter(object sender, EventArgs e)
        {}

        private void HrCombo_SelectedIndexChanged(object sender, EventArgs e)
        {}

        public void button1_Click(object sender, EventArgs e)
        {
            AddToDataBase();
            MessageBox.Show("Reservation added");
        }

        private void radioBtn_Click(object sender, EventArgs e)
        {
            placeSitting = (sender as RadioButton).Text;
        }
        public void btnTable_Click(object sender, EventArgs e)
        {
            
            if(rdInside.Checked)
            {
                placeSitting = rdInside.Text;
                Tables t = new Tables(rdInside);
                t.ShowDialog();
                
            }
            if (rdOnTheBar.Checked)
            {
                placeSitting = rdOnTheBar.Text;
                OnTheBar o = new OnTheBar(rdOnTheBar);
                o.ShowDialog();
            }
            if (rdOutside.Checked)
            {
                placeSitting = rdOutside.Text;
                Outside os = new Outside(rdOutside);
                os.ShowDialog();
            }
                 
            

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(sender.ToString());
        }

        private void txtCustomer_TextChanged(object sender, EventArgs e)
        {}
        public void AddToDataBase()
        {
            try
            {
                Random r = new Random();
                int num = r.Next(1, 10000);

                MessageBox.Show($"Phone number: {txtPhone.Text}\nTable number :{StaticClass.tableNum}\nDate: {DateCal.SelectionStart.Date}\nOn: {HrCombo.Text}\nSeating: {placeSitting}\nGuests: {txtCustomer.Text} ");

                SqlConnection mySqlConnection = new SqlConnection("server=localhost\\SQLEXPRESS;database=LynoxProject;Integrated Security=SSPI;");//kesher to database
                SqlCommand mySqlCommand = mySqlConnection.CreateCommand();
                mySqlCommand.CommandText = $"insert into Data2(PhoneNumber, TableNum, ReservationNum, ResDate, Hour, Place, People) Values('{txtPhone.Text}', {StaticClass.tableNum}, {num}, '{DateCal.SelectionStart.Date}', '{HrCombo.Text}', '{placeSitting}', {txtCustomer.Text});"; //command sql for select
                mySqlConnection.Open(); //open connection
                SqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();


                mySqlDataReader.Close();
                mySqlConnection.Close();

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);

            }
        }

        private void DateCal_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

    }
}
