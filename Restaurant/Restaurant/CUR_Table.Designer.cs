namespace Restaurant
{
    partial class CUR_Table
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CUR_Table));
            this.tableNameLbl = new System.Windows.Forms.Label();
            this.reserveBtn = new System.Windows.Forms.Button();
            this.busyBtn = new System.Windows.Forms.Button();
            this.tableFreeBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.tableNumberLbl = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.orderLB = new System.Windows.Forms.ListBox();
            this.orderBtn = new System.Windows.Forms.Button();
            this.ColdDishes = new System.Windows.Forms.ListBox();
            this.hotDishes = new System.Windows.Forms.ListBox();
            this.culDishes = new System.Windows.Forms.ListBox();
            this.drinks = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableNameLbl
            // 
            this.tableNameLbl.AutoSize = true;
            this.tableNameLbl.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableNameLbl.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.tableNameLbl.Location = new System.Drawing.Point(119, 37);
            this.tableNameLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tableNameLbl.Name = "tableNameLbl";
            this.tableNameLbl.Size = new System.Drawing.Size(109, 29);
            this.tableNameLbl.TabIndex = 1;
            this.tableNameLbl.Text = "TABLE";
            // 
            // reserveBtn
            // 
            this.reserveBtn.BackColor = System.Drawing.SystemColors.Control;
            this.reserveBtn.Location = new System.Drawing.Point(576, 26);
            this.reserveBtn.Margin = new System.Windows.Forms.Padding(2);
            this.reserveBtn.Name = "reserveBtn";
            this.reserveBtn.Size = new System.Drawing.Size(85, 53);
            this.reserveBtn.TabIndex = 3;
            this.reserveBtn.Text = "RESERV";
            this.reserveBtn.UseVisualStyleBackColor = false;
            this.reserveBtn.Click += new System.EventHandler(this.reserveBtn_Click);
            // 
            // busyBtn
            // 
            this.busyBtn.BackColor = System.Drawing.SystemColors.Control;
            this.busyBtn.Location = new System.Drawing.Point(690, 26);
            this.busyBtn.Margin = new System.Windows.Forms.Padding(2);
            this.busyBtn.Name = "busyBtn";
            this.busyBtn.Size = new System.Drawing.Size(83, 54);
            this.busyBtn.TabIndex = 4;
            this.busyBtn.Text = "BUSY";
            this.busyBtn.UseVisualStyleBackColor = false;
            this.busyBtn.Click += new System.EventHandler(this.busyBtn_Click);
            // 
            // tableFreeBtn
            // 
            this.tableFreeBtn.BackColor = System.Drawing.SystemColors.Control;
            this.tableFreeBtn.Location = new System.Drawing.Point(802, 28);
            this.tableFreeBtn.Margin = new System.Windows.Forms.Padding(2);
            this.tableFreeBtn.Name = "tableFreeBtn";
            this.tableFreeBtn.Size = new System.Drawing.Size(85, 54);
            this.tableFreeBtn.TabIndex = 5;
            this.tableFreeBtn.Text = "FREE";
            this.tableFreeBtn.UseVisualStyleBackColor = false;
            this.tableFreeBtn.Click += new System.EventHandler(this.tableFreeBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Uighur", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(27, 139);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "COLDDISH";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Uighur", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(216, 139);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 29);
            this.label2.TabIndex = 8;
            this.label2.Text = "HOT ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Uighur", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(407, 139);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 29);
            this.label3.TabIndex = 10;
            this.label3.Text = "CULS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Uighur", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(590, 139);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 29);
            this.label4.TabIndex = 12;
            this.label4.Text = "DRINKS";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkRed;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.tableNumberLbl);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.tableNameLbl);
            this.panel1.Controls.Add(this.reserveBtn);
            this.panel1.Controls.Add(this.busyBtn);
            this.panel1.Controls.Add(this.tableFreeBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(955, 114);
            this.panel1.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Aqua;
            this.button1.Location = new System.Drawing.Point(32, 481);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 48);
            this.button1.TabIndex = 8;
            this.button1.Text = "EXIT";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tableNumberLbl
            // 
            this.tableNumberLbl.AutoSize = true;
            this.tableNumberLbl.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableNumberLbl.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.tableNumberLbl.Location = new System.Drawing.Point(232, 37);
            this.tableNumberLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tableNumberLbl.Name = "tableNumberLbl";
            this.tableNumberLbl.Size = new System.Drawing.Size(26, 29);
            this.tableNumberLbl.TabIndex = 7;
            this.tableNumberLbl.Text = "1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(17, 10);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(71, 79);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Bisque;
            this.panel2.Controls.Add(this.deleteBtn);
            this.panel2.Controls.Add(this.orderLB);
            this.panel2.Controls.Add(this.orderBtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(789, 114);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(166, 427);
            this.panel2.TabIndex = 15;
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.Color.SaddleBrown;
            this.deleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.deleteBtn.Location = new System.Drawing.Point(43, 385);
            this.deleteBtn.Margin = new System.Windows.Forms.Padding(2);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(96, 40);
            this.deleteBtn.TabIndex = 18;
            this.deleteBtn.Text = "CALCEL";
            this.deleteBtn.UseVisualStyleBackColor = false;
            // 
            // orderLB
            // 
            this.orderLB.FormattingEnabled = true;
            this.orderLB.Location = new System.Drawing.Point(0, 66);
            this.orderLB.Margin = new System.Windows.Forms.Padding(2);
            this.orderLB.Name = "orderLB";
            this.orderLB.Size = new System.Drawing.Size(168, 264);
            this.orderLB.TabIndex = 17;
            // 
            // orderBtn
            // 
            this.orderBtn.BackColor = System.Drawing.Color.SaddleBrown;
            this.orderBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.orderBtn.Location = new System.Drawing.Point(43, 334);
            this.orderBtn.Margin = new System.Windows.Forms.Padding(2);
            this.orderBtn.Name = "orderBtn";
            this.orderBtn.Size = new System.Drawing.Size(96, 40);
            this.orderBtn.TabIndex = 16;
            this.orderBtn.Text = "Accept";
            this.orderBtn.UseVisualStyleBackColor = false;
            this.orderBtn.Click += new System.EventHandler(this.orderBtn_Click);
            // 
            // ColdDishes
            // 
            this.ColdDishes.FormattingEnabled = true;
            this.ColdDishes.Location = new System.Drawing.Point(32, 180);
            this.ColdDishes.Margin = new System.Windows.Forms.Padding(2);
            this.ColdDishes.Name = "ColdDishes";
            this.ColdDishes.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.ColdDishes.Size = new System.Drawing.Size(156, 264);
            this.ColdDishes.TabIndex = 24;
            // 
            // hotDishes
            // 
            this.hotDishes.FormattingEnabled = true;
            this.hotDishes.Location = new System.Drawing.Point(221, 180);
            this.hotDishes.Margin = new System.Windows.Forms.Padding(2);
            this.hotDishes.Name = "hotDishes";
            this.hotDishes.Size = new System.Drawing.Size(156, 264);
            this.hotDishes.TabIndex = 25;
            // 
            // culDishes
            // 
            this.culDishes.FormattingEnabled = true;
            this.culDishes.Location = new System.Drawing.Point(412, 180);
            this.culDishes.Margin = new System.Windows.Forms.Padding(2);
            this.culDishes.Name = "culDishes";
            this.culDishes.Size = new System.Drawing.Size(156, 264);
            this.culDishes.TabIndex = 26;
            // 
            // drinks
            // 
            this.drinks.FormattingEnabled = true;
            this.drinks.Location = new System.Drawing.Point(595, 180);
            this.drinks.Margin = new System.Windows.Forms.Padding(2);
            this.drinks.Name = "drinks";
            this.drinks.Size = new System.Drawing.Size(156, 264);
            this.drinks.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(571, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(316, 28);
            this.label5.TabIndex = 8;
            this.label5.Text = "SELECT TABLE STATUS !!!";
            // 
            // CUR_Table
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(955, 541);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.drinks);
            this.Controls.Add(this.culDishes);
            this.Controls.Add(this.hotDishes);
            this.Controls.Add(this.ColdDishes);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CUR_Table";
            this.Text = "CurrentTableForm";
            this.Load += new System.EventHandler(this.CurrentTableForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label tableNameLbl;
        private System.Windows.Forms.Button reserveBtn;
        private System.Windows.Forms.Button busyBtn;
        private System.Windows.Forms.Button tableFreeBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label tableNumberLbl;
        private System.Windows.Forms.ListBox orderLB;
        private System.Windows.Forms.Button orderBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.ListBox ColdDishes;
        private System.Windows.Forms.ListBox hotDishes;
        private System.Windows.Forms.ListBox culDishes;
        private System.Windows.Forms.ListBox drinks;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
    }
}