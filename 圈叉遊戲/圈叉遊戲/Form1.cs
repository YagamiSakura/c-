namespace 圈叉遊戲
{
    public partial class Form1 : Form
    {
        bool n_or_c = true;
        int count = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void label_btn_Click(object sender, EventArgs e)
        {
            Label label = sender as Label;
            
            if (n_or_c)
            {   
                label.Text = "圈圈";
                count++;
                label.Enabled = false;
                player.Text = "叉叉回合";
            }
            else
            {   
                label.Text = "叉叉";
                count++;
                label.Enabled=false;
                player.Text = "圈圈回合";
            }
            win_lose();
            n_or_c = !n_or_c;
            
        }
        private void win_lose()
        {
            bool wol = false;
            if (r1.Text == r2.Text && r2.Text == r3.Text && !r2.Enabled) { wol = true; }
            else if (r4.Text == r5.Text && r5.Text == r6.Text && !r5.Enabled) { wol = true; }
            else if (r7.Text == r8.Text && r8.Text == r9.Text && !r8.Enabled) { wol = true; }

            else if (r1.Text == r4.Text && r4.Text == r7.Text && !r4.Enabled) { wol = true; }
            else if (r2.Text == r5.Text && r5.Text == r8.Text && !r5.Enabled) { wol = true; }
            else if (r3.Text == r6.Text && r6.Text == r9.Text && !r6.Enabled) { wol = true; }

            else if (r1.Text == r5.Text && r5.Text == r9.Text && !r5.Enabled) { wol = true; }
            else if (r3.Text == r5.Text && r5.Text == r7.Text && !r5.Enabled) { wol = true; }

            

            if (wol)
            {
                string winer;
                if (n_or_c) 
                {
                    winer = "圈圈";
                    noughts_win_time.Text = Convert.ToString(int.Parse(noughts_win_time.Text)+1);
                    
                }
                else 
                { 
                    winer = "叉叉";
                    crosses_win_time.Text = Convert.ToString(int.Parse(crosses_win_time.Text) + 1);
                }
                game_re();
                MessageBox.Show(winer+"勝利");
            }else
            {
                if (count == 9)
                {
                    count = 0;
                    MessageBox.Show("平手");
                    game_re();
                }
            }        
        }
        private void game_re()
        {
            n_or_c = true;
            player.Text = "圈圈回合";
            count = 0;
            r1.Enabled = true;
            r1.Text = "空白";
            r2.Enabled = true;
            r2.Text = "空白";
            r3.Enabled = true;
            r3.Text = "空白";
            r4.Enabled = true;
            r4.Text = "空白";
            r5.Enabled = true;
            r5.Text = "空白";
            r6.Enabled = true;
            r6.Text = "空白";
            r7.Enabled = true;
            r7.Text = "空白";
            r8.Enabled = true;
            r8.Text = "空白";
            r9.Enabled = true;
            r9.Text = "空白";
        }

        private void game_re_set_Click(object sender, EventArgs e)
        {   
            game_re();
        }

        private void rank_re_set_Click(object sender, EventArgs e)
        {
            noughts_win_time.Text = "0";
            crosses_win_time.Text = "0";
            game_re();
        }
    }
}