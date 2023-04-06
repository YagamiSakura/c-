namespace 鍵盤滑鼠事件
{

    public partial class Form1 : Form
    {
        int count = 0;
        public Form1()
        {
            InitializeComponent();
        }

        [System.Runtime.InteropServices.DllImport("user32")]
        private static extern int mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);

        const int MOUSEEVENTF_LEFTDOWN = 0x0002; //模拟鼠标左键按下

        const int MOUSEEVENTF_LEFTUP = 0x0004; //模拟鼠标左键抬起
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 120)
            {
               mouse_c();
            }


        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            label2.Text = (++count).ToString();

        }

        private void mouse_c()
        {
          
            for (int i = 0; i < 50; i++)
            {              

                mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);      

                Thread.Sleep(100);

            }

        }
        private void label3_Click(object sender, EventArgs e)
        {
            
        }
    }
}
