using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Test_bukovsky
{
    public partial class addForm : Form
    {
        public addForm()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
            //Zavře okno
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {

            bool error = false;
            char gen;
            int age = 0;
            Boolean was;
            DateTime newdate;
            string convertedDate;
            //Definování proměnných.Error určuje, jestli došlo k chybě při procesu (tj. - spustilo se catch)

            try
            {
                newdate = new DateTime(Convert.ToInt32(yearTextbox.Text), Convert.ToInt32(monthTextbox.Text), Convert.ToInt32(dayTextbox.Text), Convert.ToInt32(hourTextbox.Text), Convert.ToInt32(minutesTextbox.Text), 0);
                convertedDate = newdate.ToString("yyyy-MM-dd HH:mm:ss.fffffff");
            }
            catch
            {
                error = true;
                newdate = new DateTime(1, 1, 1);
                convertedDate = newdate.ToString();
                MessageBox.Show("Zadejte prosím validní datum");
                //Pokud není možné převézt čísla na fungující datum tak se aktivuje tento catch
            }

            if (genderCombo.SelectedIndex == 0)
            {
                gen = 'm';
            }
            else
            {
                gen = 'f';
            }

            if (wasSatisfiedCombo.SelectedIndex == 0)
            {
                was = true;
            }
            else
            {
                was = false;
            }

            try
            {
                age = Convert.ToInt32(ageTextbox.Text);
            }
            catch
            {
                error = true;
                MessageBox.Show("Zadejte prosím validní číslo");
            }

            if(!error)
            {
                string connectionString;
                SqlConnection cnn;
                connectionString = @"Data Source=HAL-9000;Integrated Security=True;Initial Catalog=Testovacidata";

                cnn = new SqlConnection(connectionString);
                cnn.Open();

                SqlCommand command;
                //proměnná, která vykonává SQL příkazy
                SqlDataAdapter adapter = new SqlDataAdapter();
                //Proměnná která umí psát data do databáze
                string sql;
                // sql - string ve kterém jsou příkazy, které má program vykonat

                sql = "Insert into KamerTable(VisitDateTime,Age,WasSatisfied,Sex) values('" + convertedDate + "','" + age + "','" + was + "','" + gen + "')";
                command = new SqlCommand(sql, cnn);
                //Program vloží do SQL databáze řádek s hodnotami, které převezme z políček

                adapter.InsertCommand = new SqlCommand(sql, cnn);

                adapter.InsertCommand.ExecuteNonQuery();

                command.Dispose();
                cnn.Close();

                MessageBox.Show("Úspěšně přidáno");
                this.Close();

            }
        }

        private void addForm_Load(object sender, EventArgs e)
        {
            wasSatisfiedCombo.SelectedIndex = 0;
            genderCombo.SelectedIndex = 0;
        }
    }
}
