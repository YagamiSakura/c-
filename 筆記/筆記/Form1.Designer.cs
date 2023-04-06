namespace 筆記
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_title = new System.Windows.Forms.TextBox();
            this.txt_messages = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.reset = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.load = new System.Windows.Forms.Button();
            this.del = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "標題:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "訊息內容:";
            // 
            // txt_title
            // 
            this.txt_title.Location = new System.Drawing.Point(103, 9);
            this.txt_title.Name = "txt_title";
            this.txt_title.Size = new System.Drawing.Size(186, 23);
            this.txt_title.TabIndex = 2;
            this.txt_title.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_messages
            // 
            this.txt_messages.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_messages.Location = new System.Drawing.Point(103, 56);
            this.txt_messages.Multiline = true;
            this.txt_messages.Name = "txt_messages";
            this.txt_messages.Size = new System.Drawing.Size(186, 141);
            this.txt_messages.TabIndex = 3;
            this.txt_messages.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(103, 229);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(186, 188);
            this.dataGridView1.TabIndex = 4;
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(309, 12);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(75, 23);
            this.reset.TabIndex = 5;
            this.reset.Text = "重置";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(309, 56);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 23);
            this.save.TabIndex = 6;
            this.save.Text = "儲存";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // load
            // 
            this.load.Location = new System.Drawing.Point(309, 99);
            this.load.Name = "load";
            this.load.Size = new System.Drawing.Size(75, 23);
            this.load.TabIndex = 7;
            this.load.Text = "讀取";
            this.load.UseVisualStyleBackColor = true;
            this.load.Click += new System.EventHandler(this.load_Click);
            // 
            // del
            // 
            this.del.Location = new System.Drawing.Point(309, 142);
            this.del.Name = "del";
            this.del.Size = new System.Drawing.Size(75, 23);
            this.del.TabIndex = 8;
            this.del.Text = "刪除";
            this.del.UseVisualStyleBackColor = true;
            this.del.Click += new System.EventHandler(this.del_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 452);
            this.Controls.Add(this.del);
            this.Controls.Add(this.load);
            this.Controls.Add(this.save);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt_messages);
            this.Controls.Add(this.txt_title);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txt_title;
        private TextBox txt_messages;
        private DataGridView dataGridView1;
        private Button reset;
        private Button save;
        private Button load;
        private Button del;
    }
}