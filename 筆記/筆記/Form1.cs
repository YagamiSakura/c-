using System.Data;

namespace 筆記
{
    public partial class Form1 : Form
    {

        DataTable sourse;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load1(object sender, EventArgs e)
        {
            sourse = new DataTable();
            sourse.Columns.Add("標題");//新增至資料表
            sourse.Columns.Add("訊息");//新增至資料表
            dataGridView1.DataSource = sourse;//記憶體資料表存放至dataGridView1
            dataGridView1.Columns["標題"].Width = 183;//標題行長度
            dataGridView1.Columns["訊息"].Visible = false;//隱藏         
        }

        private void reset_Click(object sender, EventArgs e)
        {
            txt_title.Clear();//標題清空
            txt_messages.Clear();//訊息清空
        }

        private void save_Click(object sender, EventArgs e)
        {
            sourse.Rows.Add(txt_title.Text,txt_messages.Text);//txt_title => 資料表標題欄 txt_messages => 資料表訊息欄

            txt_title.Clear();//標題清空
            txt_messages.Clear();//訊息清空
        }

        private void load_Click(object sender, EventArgs e)
        {
            try
            {
                int index = dataGridView1.CurrentCell.RowIndex;//dataGridView儲存格資料列

                if (index > -1)
                {
                    txt_title.Text = sourse.Rows[index].ItemArray[0].ToString();//根據dataGridView資料列 讀取datatable.sourse中的資料 ItemArray為資料行第一資料"標題" 
                    txt_messages.Text = sourse.Rows[index].ItemArray[1].ToString();//根據dataGridView資料列 讀取sourse中的資料 ItemArray為資料行第二資料"訊息" 
                }

            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);//彈跳錯誤訊息
            }       
        }

        private void del_Click(object sender, EventArgs e)
        {
            try
            {
                int index = dataGridView1.CurrentCell.RowIndex;//dataGridView儲存格資料列
                sourse.Rows[index].Delete();//刪除sourse中的資料儲存列
            }catch (Exception exx)
            {
                MessageBox.Show(exx.Message);//彈跳錯誤訊息
            }
        }
    }
}