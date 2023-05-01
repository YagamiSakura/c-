using MySql.Data;
using MySql.Data.MySqlClient;

namespace 飲料點餐系統
{
    public partial class Form1 : Form
    {

  
        int sum = 0;
        public Form1()
        {
            InitializeComponent();
        }
        private int mysql_load(int number)
        {
            var dbHost = "127.0.0.1";
            var dbUser = "root";
            var dbPass = "50236";
            var dbName = "drink_data";
            var connStr = "server=" + dbHost + ";uid=" + dbUser + ";pwd=" + dbPass + ";database=" + dbName;

            MySqlConnection conn = new MySqlConnection(connStr);
            MySqlCommand command = conn.CreateCommand();

            conn.Open();

            String cmdText = "SELECT * FROM menu_date WHERE number_key = "+number.ToString();
            MySqlCommand cmd = new MySqlCommand(cmdText, conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            reader.Read();

            var price = reader.GetInt32(2);

            conn.Close();

            return price;
        }

        private void details_Click(object sender, EventArgs e)
        {
            var derail="";

            if (milk_tea_numericUpDown.Value > 0)
            {
                derail += "奶茶\t 數量:" + milk_tea_numericUpDown.Value.ToString()
                    + ",金額:" + milk_tea_numericUpDown.Value.ToString()
                    + "*"
                    + mysql_load(4).ToString()
                    + "="
                    + (milk_tea_numericUpDown.Value * mysql_load(4)).ToString()
                    + "\n";
            }
            if (Oolong_tea_numericUpDown.Value > 0)
            {
                derail += "烏龍茶\t 數量:" + Oolong_tea_numericUpDown.Value.ToString() 
                    + ",金額:" + Oolong_tea_numericUpDown.Value.ToString()
                    +"*"
                    + mysql_load(3).ToString()
                    +"="
                    +(Oolong_tea_numericUpDown.Value * mysql_load(3)).ToString()
                    + "\n";
            }
            if (black_tea_numericUpDown.Value > 0)
            {
                derail += "紅茶\t 數量:" + black_tea_numericUpDown.Value.ToString()
                    + ",金額:" + black_tea_numericUpDown.Value.ToString()
                    + "*"
                    + mysql_load(2).ToString()
                    + "="
                    + (black_tea_numericUpDown.Value * mysql_load(2)).ToString()
                    + "\n";
            }
            if (Assam_black_tea_numericUpDown.Value > 0)
            {
                derail += "阿薩姆紅茶\t 數量:" + Assam_black_tea_numericUpDown.Value.ToString()
                    + ",金額:" + Assam_black_tea_numericUpDown.Value.ToString()
                    + "*"
                    + mysql_load(1).ToString()
                    + "="
                    + (Assam_black_tea_numericUpDown.Value * mysql_load(1)).ToString()
                    + "\n";
            }
            if (scented_tea_numericUpDown.Value > 0)
            {
                derail += "牡丹花茶\t 數量:" + scented_tea_numericUpDown.Value.ToString()
                    + ",金額:" + scented_tea_numericUpDown.Value.ToString()
                    + "*"
                    + mysql_load(5).ToString()
                    + "="
                    + (scented_tea_numericUpDown.Value * mysql_load(5)).ToString()
                    + "\n";
            }
            if (white_tea_numericUpDown.Value > 0)
            {
                derail += "白茶\t 數量:" + white_tea_numericUpDown.Value.ToString()
                    + ",金額:" + white_tea_numericUpDown.Value.ToString()
                    + "*"
                    + mysql_load(6).ToString()
                    + "="
                    + (white_tea_numericUpDown.Value * mysql_load(6)).ToString()
                    + "\n";
            }
            if (Ceylon_black_tea_numericUpDown.Value > 0)
            {
                derail += "錫蘭紅茶\t 數量:" + Ceylon_black_tea_numericUpDown.Value.ToString()
                    + ",金額:" + Ceylon_black_tea_numericUpDown.Value.ToString()
                    + "*"
                    + mysql_load(7).ToString()
                    + "="
                    + (Ceylon_black_tea_numericUpDown.Value * mysql_load(7)).ToString()
                    + "\n";
            }
            if (green_tea_numericUpDown.Value > 0)
            {
                derail += "綠茶\t 數量:" + green_tea_numericUpDown.Value.ToString()
                    + ",金額:" + green_tea_numericUpDown.Value.ToString()
                    + "*"
                    + mysql_load(8).ToString()
                    + "="
                    + (green_tea_numericUpDown.Value * mysql_load(8)).ToString()
                    +"\n";
            }
            derail += "總數量:" + quantity_txt.Text + ",總金額:" + amount_txt.Text;
            MessageBox.Show(derail, "明細");

        }
        private void Check_Click(object sender, EventArgs e)
        {
            MessageBox.Show("共計"+quantity_txt.Text+"杯"+",金額共"+amount_txt.Text+"元");
        }

        private void Assam_black_tea_numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            sum_count();
        }

        private void black_tea_numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            sum_count();
        }

        private void Oolong_tea_numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            sum_count();
        }
        private void milk_tea_numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            sum_count();
        }
        private void scented_tea_numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            sum_count();
        }

        private void white_tea_numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            sum_count();
        }

        private void Ceylon_black_tea_numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            sum_count();
        }

        private void green_tea_numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            sum_count();
        }
        private void sum_count()
        {
            quantity_txt.Text = (
                Assam_black_tea_numericUpDown.Value
                + black_tea_numericUpDown.Value
                + Oolong_tea_numericUpDown.Value
                + milk_tea_numericUpDown.Value
                + scented_tea_numericUpDown.Value
                + white_tea_numericUpDown.Value
                + Ceylon_black_tea_numericUpDown.Value
                + green_tea_numericUpDown.Value
                ).ToString();

            amount_txt.Text = (
                (Assam_black_tea_numericUpDown.Value * mysql_load(1)
                + black_tea_numericUpDown.Value * mysql_load(2)
                + Oolong_tea_numericUpDown.Value * mysql_load(3)
                + milk_tea_numericUpDown.Value * mysql_load(4)
                + scented_tea_numericUpDown.Value * mysql_load(5)
                + white_tea_numericUpDown.Value * mysql_load(6)
                + Ceylon_black_tea_numericUpDown.Value * mysql_load(7)
                + green_tea_numericUpDown.Value * mysql_load(8))
                .ToString());
        }

       
    }
}