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
            // Pro vkládání nových dat si aplikace otevře nové windows forms okno
        }

        private void readButton_Click(object sender, EventArgs e)
        {
            string connectionString;
            SqlConnection cnn;
            // definování proměnných 
            connectionString = @"Data Source=pzs5t5imun.database.windows.net;Initial Catalog=AUTO_ETL_META_DB;User ID=softim_recruit;Password=TNeANy5SaFDf";

            cnn = new SqlConnection(connectionString);
            cnn.Open();
            MessageBox.Show("Připojení otevřeno");

            SqlCommand command;
            //proměnná, která vykonává SQL příkazy
            SqlDataReader dataReader;
            //Proměnná která čte data z databáze
            string sql, Output = "";
            //Output - string, který je naplněn tím, co reader přečte. sql - string ve kterém jsou příkazy, které má program vykonat

            sql = "Select * from Customers";
            command = new SqlCommand(sql, cnn);
            //Sql příkaz vybere Všechny sloupce z tabulky Customers

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
                //...se output plní hodnotami z tabulky. Hodnoty se postupně přidávají po řádcích. \n udělá další odstavec 
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
            connectionString = @"Data Source=pzs5t5imun.database.windows.net;Initial Catalog=AUTO_ETL_META_DB;User ID=softim_recruit;Password=TNeANy5SaFDf";
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
            // Pro vkládání hledání dat podle datumu si aplikace otevře nové windows forms okno
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
            //definování nových proměnných. Filepath a filecontent se naplní podle cesty a zvoleného souboru. Proměnná bool určuje, jestli bude kód pokračovat - jestli se objeví chyba, tak nebude.

            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                //OpenFileDialog dialog otevře okno, které nechá uživatele vybrat soubor ke čtení

                try
                {
                    dialog.Filter = "Text files (.txt)|*.txt";
                    dialog.Multiselect = false;
                    //Soubor může mít pouze koncovku .txt. Lze vybrat jen jeden.
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
                        //Streamreader reader celý soubor přečte a uloží ho po linkách do seznamu lines. Pak se zavře.
                    }
                    else
                    {
                        MessageBox.Show("Vyberte prosím soubor");
                        cont = false;
                        //Toto se spustí v případě, že uživatel nevybere soubor
                    }
                }
                catch
                {
                    MessageBox.Show("Neplatný soubor");
                    cont = false;
                    //Pokud něco selže (např. soubor nejde přečíst), tak se spustí tento blok
                }

            }


            if (cont)
            {
                //Spustí se jen, když se nespustí bloky catch a else

                SqlCommand command;
                string connectionString;
                SqlConnection cnn;
                // definování proměnných 

                connectionString = @"Data Source=pzs5t5imun.database.windows.net;Initial Catalog=AUTO_ETL_META_DB;User ID=softim_recruit;Password=TNeANy5SaFDf";
                cnn = new SqlConnection(connectionString);
                cnn.Open();

                SqlDataAdapter adapter = new SqlDataAdapter();
                string sql;

                string[] cells = new string[5];
                for (int x = 0; x < lines.Count; x++)
                {
                    //For loop se spustí tolikrát, kolik má proměnná lines vložených hodnot

                    cells = lines[x].Split('*');
                    //Proměnná cells je naplněna rozdělenými stringy ze seznamu lines. Dělí se pomocí znamínka *

                    sql = "Insert into Customers(VisitDateTime,Age,WasSatisfied,Sex) values('" + cells[0] + "','" + cells[1] + "','" + cells[2] + "','" + cells[3] + "')";
                    command = new SqlCommand(sql, cnn);

                    adapter.InsertCommand = new SqlCommand(sql, cnn);
                    adapter.InsertCommand.ExecuteNonQuery();
                    command.Dispose();
                    //Pokud vše proběhne hladce, tak se vloží hodnoty postupně do sql databáze.
                }

                cnn.Close();

                MessageBox.Show("Úspěšně přidáno");
            }  
        }
    }
}
