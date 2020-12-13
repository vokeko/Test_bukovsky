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
using System.IO;

namespace Test_bukovsky
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            addForm adform = new addForm();
            adform.Show();
        }

        private void readButton_Click(object sender, EventArgs e)
        {
            string connectionString;
            SqlConnection cnn;
            // definování proměnných 
            connectionString = @"Data Source=HAL-9000;Integrated Security=True;Initial Catalog=Testovacidata";
            /* VYSVĚTLENÍ:
             * Data source - název serveru, v kterém je databáze
             * Initial catalog - specifikuje název databáze
             * User ID a Password - ID uživatele a heslo              
             */

            cnn = new SqlConnection(connectionString);
            //K připojení potřebujeme proměnnou pro SqlConnection a String, který nám říká která
            cnn.Open();
            //Příkazem otevřeme připojení k databázi a zse zavřeme. Je dobé zavírat připojení k databázi po tom, co už tam nic nepotřebujeme.
            MessageBox.Show("Připojení otevřeno");

            SqlCommand command;
            //proměnná, která vykonává SQL příkazy
            SqlDataReader dataReader;
            //Proměnná která čte data z databáze
            string sql, Output = "";
            //Output - string, který je naplněn tím, co reader přečte. sql - string ve kterém jsou příkazy, které má program vykonat

            sql = "Select * from KamerTable";
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

        private void testConnectionButton_Click(object sender, EventArgs e)
        {
            string connectionString;
            SqlConnection cnn;
            // definování proměnných 
            connectionString = @"Data Source=HAL-9000;Integrated Security=True;Initial Catalog=Testovacidata";
            /* VYSVĚTLENÍ:
             * Data source - název serveru, v kterém je databáze
             * Initial catalog - specifikuje název databáze
             * User ID a Password - ID uživatele a heslo              
             */

            cnn = new SqlConnection(connectionString);
            //K připojení potřebujeme proměnnou pro SqlConnection a string
            cnn.Open();
            //Příkazem otevřeme připojení k databázi a zase zavřeme. Je dobé zavírat připojení k databázi po tom, co už tam nic nepotřebujeme.
            MessageBox.Show("Připojení úspěšné");
            cnn.Close();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            searchForm searchform = new searchForm();
            searchform.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void fromFileButton_Click(object sender, EventArgs e)
        {
            var filepath = string.Empty;
            var filecontent = string.Empty;
            bool cont = true;
            List<string> lines = new List<string>();
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                try
                {
                    dialog.Filter = "Text files (.txt)|*.txt";
                    dialog.Multiselect = false;
                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        filepath = dialog.FileName;
                        var filestream = dialog.OpenFile();
                        StreamReader reader = new StreamReader(filestream);

                        string line = reader.ReadLine();
                        while (line != null)
                        {
                            lines.Add(line);
                            line = reader.ReadLine();
                        }
                        reader.Close();
                    }
                    else
                    {
                        MessageBox.Show("Vyberte prosím soubor");
                        cont = false;
                    }
                }
                catch
                {
                    MessageBox.Show("Neplatný soubor");
                    cont = false;
                }

            }


            if (cont)
            {
                SqlCommand command;
                string connectionString;
                SqlConnection cnn;
                // definování proměnných 
                connectionString = @"Data Source=HAL-9000;Integrated Security=True;Initial Catalog=Testovacidata";

                cnn = new SqlConnection(connectionString);

                //K připojení potřebujeme proměnnou pro SqlConnection a String, který nám říká která
                cnn.Open();


                //proměnná, která vykonává SQL příkazy
                SqlDataAdapter adapter = new SqlDataAdapter();
                //Proměnná která píše data do databáze
                string sql;
                // sql - string ve kterém jsou příkazy, které má program vykonat

                string[] cells = new string[5];
                for (int x = 0; x < lines.Count; x++)
                {
                    cells = lines[x].Split('*');

                    sql = "Insert into KamerTable(VisitDateTime,Age,WasSatisfied,Sex) values('" + cells[0] + "','" + cells[1] + "','" + cells[2] + "','" + cells[3] + "')";
                    command = new SqlCommand(sql, cnn);

                    adapter.InsertCommand = new SqlCommand(sql, cnn);
                    adapter.InsertCommand.ExecuteNonQuery();
                    command.Dispose();
                }

                cnn.Close();

                MessageBox.Show("Úspěšně přidáno");
            }  
        }
    }
}
