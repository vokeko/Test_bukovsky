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

    public partial class searchForm : Form
    {
        public searchForm()
        {
            InitializeComponent();
        }

        private void backButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void searchForm_Load(object sender, EventArgs e)
        {
            fromToCheck.Checked = true;
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            SqlCommand command;
            //proměnná, která vykonává SQL příkazy
            SqlDataReader dataReader;
            //Proměnná která čte data z databáze
            string sql, Output = "";
            //Output - string, který je naplněn tím, co reader přečte. sql - string ve kterém jsou příkazy, které má program vykonat
            string connectionString;
            SqlConnection cnn;
            // definování proměnných 

            connectionString = @"Data Source=HAL-9000;Integrated Security=True;Initial Catalog=Testovacidata";
            /* VYSVĚTLENÍ:
             * Data source - název serveru, v kterém je databáze
             * Initial catalog - specifikuje název databáze
             * User ID a Password - ID uživatele a heslo              
             */

            DateTime date1 = new DateTime(Convert.ToInt32(YearTextbox.Text), Convert.ToInt32(monthTextbox.Text), Convert.ToInt32(dayTextbox.Text), Convert.ToInt32(hourTextbox.Text), Convert.ToInt32(minuteTextbox.Text), 0);
            string sdate1 = date1.ToString("yyyy-MM-dd HH:mm:ss.fffffff");

            if (fromToCheck.Checked)
            {
                DateTime date2 = new DateTime(Convert.ToInt32(year2Textbox.Text), Convert.ToInt32(month2Textbox.Text), Convert.ToInt32(day2Textbox.Text), Convert.ToInt32(hour2Textbox.Text), Convert.ToInt32(minute2Textbox.Text), 0);
                string sdate2 = date2.ToString("yyyy-MM-dd HH:mm:ss.fffffff");
                sql = "Select * from KamerTable where VisitDateTime between '" + sdate1 + "' and '" + sdate2 + "'";
            }
            else
            {
                sql = "Select * from KamerTable where VisitDateTime = '" + sdate1 + "'";
            }

            cnn = new SqlConnection(connectionString);
            //K připojení potřebujeme proměnnou pro SqlConnection a String, který nám říká která
            cnn.Open();
            //Příkazem otevřeme připojení k databázi a zse zavřeme. Je dobé zavírat připojení k databázi po tom, co už tam nic nepotřebujeme.
            MessageBox.Show("Připojení otevřeno");

            command = new SqlCommand(sql, cnn);
            //Sql příkaz vybere sloupce VisitDateTime a Age z tabulky Customers

            dataReader = command.ExecuteReader();
            //tímto příkazem se načte výběr
            while (dataReader.Read())
            {//Dokud je co číst tak...
                int n = 0;
                bool end = false;
                do
                {
                    try
                    {
                        Output = Output + dataReader.GetValue(n) + "  ";
                    }
                    catch
                    {
                        end = true;
                    }
                    n++;
                } while (!end);
                Output = Output + "\n";
                //...se output plní hodnotami z tabulky. 0 a 1 znamenají první a druhý výsledek selectu. Hodnoty se postupně přidávají po řádcích. \n udělá další odstavec 
            }
            MessageBox.Show(Output);
            //Tabulka se ukáže ve message boxu
            cnn.Close();
            //připojení se přeruší
            command.Dispose();
            //načtený výběr se smaže
        }

        private void fromToCheck_CheckedChanged(object sender, EventArgs e)
        {
            if(fromToCheck.Checked)
            {
                day2Textbox.Enabled = true;
                month2Textbox.Enabled = true;
                year2Textbox.Enabled = true;
                hour2Textbox.Enabled = true;
                minute2Textbox.Enabled = true;
            }
            else
            {
                day2Textbox.Enabled = false;
                month2Textbox.Enabled = false;
                year2Textbox.Enabled = false;
                hour2Textbox.Enabled = false;
                minute2Textbox.Enabled = false;
            }
        }
    }
}
