namespace 飲料點餐系統
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Check = new System.Windows.Forms.Button();
            this.amount = new System.Windows.Forms.Label();
            this.quantity = new System.Windows.Forms.Label();
            this.quantity_txt = new System.Windows.Forms.Label();
            this.amount_txt = new System.Windows.Forms.Label();
            this.milk_tea_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.details = new System.Windows.Forms.Button();
            this.milk_tea = new System.Windows.Forms.Label();
            this.black_tea = new System.Windows.Forms.Label();
            this.black_tea_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.green_tea = new System.Windows.Forms.Label();
            this.green_tea_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Ceylon_black_tea = new System.Windows.Forms.Label();
            this.Ceylon_black_tea_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Assam_black_tea = new System.Windows.Forms.Label();
            this.Assam_black_tea_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Oolong_tea = new System.Windows.Forms.Label();
            this.Oolong_tea_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.white_tea = new System.Windows.Forms.Label();
            this.white_tea_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.scented_tea = new System.Windows.Forms.Label();
            this.scented_tea_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.milk_tea_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.black_tea_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.green_tea_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ceylon_black_tea_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Assam_black_tea_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Oolong_tea_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.white_tea_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scented_tea_numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // Check
            // 
            this.Check.Location = new System.Drawing.Point(291, 328);
            this.Check.Name = "Check";
            this.Check.Size = new System.Drawing.Size(75, 23);
            this.Check.TabIndex = 6;
            this.Check.Text = "結帳";
            this.Check.UseVisualStyleBackColor = true;
            this.Check.Click += new System.EventHandler(this.Check_Click);
            // 
            // amount
            // 
            this.amount.AutoSize = true;
            this.amount.Location = new System.Drawing.Point(291, 67);
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(34, 15);
            this.amount.TabIndex = 7;
            this.amount.Text = "金額:";
            // 
            // quantity
            // 
            this.quantity.AutoSize = true;
            this.quantity.Location = new System.Drawing.Point(48, 67);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(34, 15);
            this.quantity.TabIndex = 8;
            this.quantity.Text = "數量:";
            // 
            // quantity_txt
            // 
            this.quantity_txt.AutoSize = true;
            this.quantity_txt.Location = new System.Drawing.Point(96, 67);
            this.quantity_txt.Name = "quantity_txt";
            this.quantity_txt.Size = new System.Drawing.Size(14, 15);
            this.quantity_txt.TabIndex = 9;
            this.quantity_txt.Text = "0";
            // 
            // amount_txt
            // 
            this.amount_txt.AutoSize = true;
            this.amount_txt.ForeColor = System.Drawing.Color.Red;
            this.amount_txt.Location = new System.Drawing.Point(339, 67);
            this.amount_txt.Name = "amount_txt";
            this.amount_txt.Size = new System.Drawing.Size(14, 15);
            this.amount_txt.TabIndex = 10;
            this.amount_txt.Text = "0";
            // 
            // milk_tea_numericUpDown
            // 
            this.milk_tea_numericUpDown.Location = new System.Drawing.Point(199, 112);
            this.milk_tea_numericUpDown.Name = "milk_tea_numericUpDown";
            this.milk_tea_numericUpDown.Size = new System.Drawing.Size(29, 23);
            this.milk_tea_numericUpDown.TabIndex = 11;
            this.milk_tea_numericUpDown.ValueChanged += new System.EventHandler(this.milk_tea_numericUpDown_ValueChanged);
            // 
            // details
            // 
            this.details.Location = new System.Drawing.Point(48, 328);
            this.details.Name = "details";
            this.details.Size = new System.Drawing.Size(75, 23);
            this.details.TabIndex = 17;
            this.details.Text = "明細";
            this.details.UseVisualStyleBackColor = true;
            this.details.Click += new System.EventHandler(this.details_Click);
            // 
            // milk_tea
            // 
            this.milk_tea.Font = new System.Drawing.Font("Microsoft JhengHei UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.milk_tea.Location = new System.Drawing.Point(40, 105);
            this.milk_tea.Name = "milk_tea";
            this.milk_tea.Size = new System.Drawing.Size(75, 30);
            this.milk_tea.TabIndex = 18;
            this.milk_tea.Text = "奶茶:";
            // 
            // black_tea
            // 
            this.black_tea.Font = new System.Drawing.Font("Microsoft JhengHei UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.black_tea.Location = new System.Drawing.Point(40, 220);
            this.black_tea.Name = "black_tea";
            this.black_tea.Size = new System.Drawing.Size(75, 30);
            this.black_tea.TabIndex = 20;
            this.black_tea.Text = "紅茶:";
            // 
            // black_tea_numericUpDown
            // 
            this.black_tea_numericUpDown.Location = new System.Drawing.Point(199, 227);
            this.black_tea_numericUpDown.Name = "black_tea_numericUpDown";
            this.black_tea_numericUpDown.Size = new System.Drawing.Size(29, 23);
            this.black_tea_numericUpDown.TabIndex = 19;
            this.black_tea_numericUpDown.ValueChanged += new System.EventHandler(this.black_tea_numericUpDown_ValueChanged);
            // 
            // green_tea
            // 
            this.green_tea.Font = new System.Drawing.Font("Microsoft JhengHei UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.green_tea.Location = new System.Drawing.Point(291, 105);
            this.green_tea.Name = "green_tea";
            this.green_tea.Size = new System.Drawing.Size(75, 30);
            this.green_tea.TabIndex = 22;
            this.green_tea.Text = "綠茶:";
            // 
            // green_tea_numericUpDown
            // 
            this.green_tea_numericUpDown.Location = new System.Drawing.Point(426, 112);
            this.green_tea_numericUpDown.Name = "green_tea_numericUpDown";
            this.green_tea_numericUpDown.Size = new System.Drawing.Size(29, 23);
            this.green_tea_numericUpDown.TabIndex = 21;
            this.green_tea_numericUpDown.ValueChanged += new System.EventHandler(this.green_tea_numericUpDown_ValueChanged);
            // 
            // Ceylon_black_tea
            // 
            this.Ceylon_black_tea.Font = new System.Drawing.Font("Microsoft JhengHei UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Ceylon_black_tea.Location = new System.Drawing.Point(291, 162);
            this.Ceylon_black_tea.Name = "Ceylon_black_tea";
            this.Ceylon_black_tea.Size = new System.Drawing.Size(129, 30);
            this.Ceylon_black_tea.TabIndex = 24;
            this.Ceylon_black_tea.Text = "錫蘭紅茶:";
            // 
            // Ceylon_black_tea_numericUpDown
            // 
            this.Ceylon_black_tea_numericUpDown.Location = new System.Drawing.Point(426, 169);
            this.Ceylon_black_tea_numericUpDown.Name = "Ceylon_black_tea_numericUpDown";
            this.Ceylon_black_tea_numericUpDown.Size = new System.Drawing.Size(29, 23);
            this.Ceylon_black_tea_numericUpDown.TabIndex = 23;
            this.Ceylon_black_tea_numericUpDown.ValueChanged += new System.EventHandler(this.Ceylon_black_tea_numericUpDown_ValueChanged);
            // 
            // Assam_black_tea
            // 
            this.Assam_black_tea.Font = new System.Drawing.Font("Microsoft JhengHei UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Assam_black_tea.Location = new System.Drawing.Point(40, 277);
            this.Assam_black_tea.Name = "Assam_black_tea";
            this.Assam_black_tea.Size = new System.Drawing.Size(156, 30);
            this.Assam_black_tea.TabIndex = 26;
            this.Assam_black_tea.Text = "阿薩姆紅茶:";
            // 
            // Assam_black_tea_numericUpDown
            // 
            this.Assam_black_tea_numericUpDown.Location = new System.Drawing.Point(199, 284);
            this.Assam_black_tea_numericUpDown.Name = "Assam_black_tea_numericUpDown";
            this.Assam_black_tea_numericUpDown.Size = new System.Drawing.Size(29, 23);
            this.Assam_black_tea_numericUpDown.TabIndex = 25;
            this.Assam_black_tea_numericUpDown.ValueChanged += new System.EventHandler(this.Assam_black_tea_numericUpDown_ValueChanged);
            // 
            // Oolong_tea
            // 
            this.Oolong_tea.Font = new System.Drawing.Font("Microsoft JhengHei UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Oolong_tea.Location = new System.Drawing.Point(40, 162);
            this.Oolong_tea.Name = "Oolong_tea";
            this.Oolong_tea.Size = new System.Drawing.Size(116, 30);
            this.Oolong_tea.TabIndex = 28;
            this.Oolong_tea.Text = "烏龍茶:";
            // 
            // Oolong_tea_numericUpDown
            // 
            this.Oolong_tea_numericUpDown.Location = new System.Drawing.Point(199, 169);
            this.Oolong_tea_numericUpDown.Name = "Oolong_tea_numericUpDown";
            this.Oolong_tea_numericUpDown.Size = new System.Drawing.Size(29, 23);
            this.Oolong_tea_numericUpDown.TabIndex = 27;
            this.Oolong_tea_numericUpDown.ValueChanged += new System.EventHandler(this.Oolong_tea_numericUpDown_ValueChanged);
            // 
            // white_tea
            // 
            this.white_tea.Font = new System.Drawing.Font("Microsoft JhengHei UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.white_tea.Location = new System.Drawing.Point(291, 220);
            this.white_tea.Name = "white_tea";
            this.white_tea.Size = new System.Drawing.Size(75, 30);
            this.white_tea.TabIndex = 30;
            this.white_tea.Text = "白茶:";
            // 
            // white_tea_numericUpDown
            // 
            this.white_tea_numericUpDown.Location = new System.Drawing.Point(426, 227);
            this.white_tea_numericUpDown.Name = "white_tea_numericUpDown";
            this.white_tea_numericUpDown.Size = new System.Drawing.Size(29, 23);
            this.white_tea_numericUpDown.TabIndex = 29;
            this.white_tea_numericUpDown.ValueChanged += new System.EventHandler(this.white_tea_numericUpDown_ValueChanged);
            // 
            // scented_tea
            // 
            this.scented_tea.Font = new System.Drawing.Font("Microsoft JhengHei UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.scented_tea.Location = new System.Drawing.Point(291, 277);
            this.scented_tea.Name = "scented_tea";
            this.scented_tea.Size = new System.Drawing.Size(129, 30);
            this.scented_tea.TabIndex = 32;
            this.scented_tea.Text = "牡丹花茶:";
            // 
            // scented_tea_numericUpDown
            // 
            this.scented_tea_numericUpDown.Location = new System.Drawing.Point(426, 284);
            this.scented_tea_numericUpDown.Name = "scented_tea_numericUpDown";
            this.scented_tea_numericUpDown.Size = new System.Drawing.Size(29, 23);
            this.scented_tea_numericUpDown.TabIndex = 31;
            this.scented_tea_numericUpDown.ValueChanged += new System.EventHandler(this.scented_tea_numericUpDown_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(234, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 15);
            this.label1.TabIndex = 33;
            this.label1.Text = "50元";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(234, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 15);
            this.label2.TabIndex = 34;
            this.label2.Text = "30元";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(461, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 15);
            this.label3.TabIndex = 35;
            this.label3.Text = "30元";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(461, 293);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 15);
            this.label5.TabIndex = 36;
            this.label5.Text = "40元";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(234, 291);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 15);
            this.label6.TabIndex = 37;
            this.label6.Text = "50元";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(234, 235);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 15);
            this.label7.TabIndex = 38;
            this.label7.Text = "20元";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(461, 121);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 15);
            this.label8.TabIndex = 39;
            this.label8.Text = "20元";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(461, 177);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 15);
            this.label9.TabIndex = 40;
            this.label9.Text = "50元";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 450);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.scented_tea);
            this.Controls.Add(this.scented_tea_numericUpDown);
            this.Controls.Add(this.white_tea);
            this.Controls.Add(this.white_tea_numericUpDown);
            this.Controls.Add(this.Oolong_tea);
            this.Controls.Add(this.Oolong_tea_numericUpDown);
            this.Controls.Add(this.Assam_black_tea);
            this.Controls.Add(this.Assam_black_tea_numericUpDown);
            this.Controls.Add(this.Ceylon_black_tea);
            this.Controls.Add(this.Ceylon_black_tea_numericUpDown);
            this.Controls.Add(this.green_tea);
            this.Controls.Add(this.green_tea_numericUpDown);
            this.Controls.Add(this.black_tea);
            this.Controls.Add(this.black_tea_numericUpDown);
            this.Controls.Add(this.milk_tea);
            this.Controls.Add(this.details);
            this.Controls.Add(this.milk_tea_numericUpDown);
            this.Controls.Add(this.amount_txt);
            this.Controls.Add(this.quantity_txt);
            this.Controls.Add(this.quantity);
            this.Controls.Add(this.amount);
            this.Controls.Add(this.Check);
            this.Name = "Form1";
            this.Text = "點餐系統";
            ((System.ComponentModel.ISupportInitialize)(this.milk_tea_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.black_tea_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.green_tea_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ceylon_black_tea_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Assam_black_tea_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Oolong_tea_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.white_tea_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scented_tea_numericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button Check;
        private Label amount;
        private Label quantity;
        private Label quantity_txt;
        private Label amount_txt;
        private NumericUpDown milk_tea_numericUpDown;
        private Button details;
        private Label milk_tea;
        private Label black_tea;
        private NumericUpDown black_tea_numericUpDown;
        private Label green_tea;
        private NumericUpDown green_tea_numericUpDown;
        private Label Ceylon_black_tea;
        private NumericUpDown Ceylon_black_tea_numericUpDown;
        private Label Assam_black_tea;
        private NumericUpDown Assam_black_tea_numericUpDown;
        private Label Oolong_tea;
        private NumericUpDown Oolong_tea_numericUpDown;
        private Label white_tea;
        private NumericUpDown white_tea_numericUpDown;
        private Label scented_tea;
        private NumericUpDown scented_tea_numericUpDown;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
    }
}