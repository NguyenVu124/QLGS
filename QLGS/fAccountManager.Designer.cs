namespace QLGS
{
    partial class fAccountManager
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
            this.buttonSearch = new System.Windows.Forms.Button();
            this.dataGridViewListTutor = new System.Windows.Forms.DataGridView();
            this.buttonShowAll = new System.Windows.Forms.Button();
            this.textBoxSearchName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelTutorName = new System.Windows.Forms.Label();
            this.labelTutorID = new System.Windows.Forms.Label();
            this.buttonUpdateData = new System.Windows.Forms.Button();
            this.buttonCourseInfo = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonAddAccount = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListTutor)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(94)))), ((int)(((byte)(242)))));
            this.buttonSearch.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearch.ForeColor = System.Drawing.Color.White;
            this.buttonSearch.Location = new System.Drawing.Point(439, 521);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(143, 33);
            this.buttonSearch.TabIndex = 2;
            this.buttonSearch.Text = "Tìm kiếm";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // dataGridViewListTutor
            // 
            this.dataGridViewListTutor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewListTutor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListTutor.Location = new System.Drawing.Point(19, 97);
            this.dataGridViewListTutor.Name = "dataGridViewListTutor";
            this.dataGridViewListTutor.RowHeadersWidth = 15;
            this.dataGridViewListTutor.RowTemplate.Height = 24;
            this.dataGridViewListTutor.Size = new System.Drawing.Size(563, 404);
            this.dataGridViewListTutor.TabIndex = 87;
            this.dataGridViewListTutor.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewListTutor_CellClick);
            // 
            // buttonShowAll
            // 
            this.buttonShowAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(94)))), ((int)(((byte)(242)))));
            this.buttonShowAll.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonShowAll.ForeColor = System.Drawing.Color.White;
            this.buttonShowAll.Location = new System.Drawing.Point(636, 459);
            this.buttonShowAll.Name = "buttonShowAll";
            this.buttonShowAll.Size = new System.Drawing.Size(186, 33);
            this.buttonShowAll.TabIndex = 3;
            this.buttonShowAll.Text = "Hiển thị tất cả";
            this.buttonShowAll.UseVisualStyleBackColor = false;
            this.buttonShowAll.Click += new System.EventHandler(this.buttonShowAll_Click);
            // 
            // textBoxSearchName
            // 
            this.textBoxSearchName.Location = new System.Drawing.Point(19, 526);
            this.textBoxSearchName.Name = "textBoxSearchName";
            this.textBoxSearchName.Size = new System.Drawing.Size(356, 25);
            this.textBoxSearchName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(632, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 19);
            this.label1.TabIndex = 90;
            this.label1.Text = "ID Gia sư:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(632, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 19);
            this.label2.TabIndex = 91;
            this.label2.Text = "Tên gia sư:";
            // 
            // labelTutorName
            // 
            this.labelTutorName.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTutorName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelTutorName.Location = new System.Drawing.Point(724, 139);
            this.labelTutorName.Name = "labelTutorName";
            this.labelTutorName.Size = new System.Drawing.Size(121, 52);
            this.labelTutorName.TabIndex = 93;
            // 
            // labelTutorID
            // 
            this.labelTutorID.AutoSize = true;
            this.labelTutorID.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTutorID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelTutorID.Location = new System.Drawing.Point(724, 97);
            this.labelTutorID.Name = "labelTutorID";
            this.labelTutorID.Size = new System.Drawing.Size(0, 19);
            this.labelTutorID.TabIndex = 92;
            // 
            // buttonUpdateData
            // 
            this.buttonUpdateData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(94)))), ((int)(((byte)(242)))));
            this.buttonUpdateData.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdateData.ForeColor = System.Drawing.Color.White;
            this.buttonUpdateData.Location = new System.Drawing.Point(636, 216);
            this.buttonUpdateData.Name = "buttonUpdateData";
            this.buttonUpdateData.Size = new System.Drawing.Size(186, 33);
            this.buttonUpdateData.TabIndex = 94;
            this.buttonUpdateData.Text = "Thay đổi thông tin";
            this.buttonUpdateData.UseVisualStyleBackColor = false;
            this.buttonUpdateData.Click += new System.EventHandler(this.buttonUpdateData_Click);
            // 
            // buttonCourseInfo
            // 
            this.buttonCourseInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(94)))), ((int)(((byte)(242)))));
            this.buttonCourseInfo.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCourseInfo.ForeColor = System.Drawing.Color.White;
            this.buttonCourseInfo.Location = new System.Drawing.Point(636, 276);
            this.buttonCourseInfo.Name = "buttonCourseInfo";
            this.buttonCourseInfo.Size = new System.Drawing.Size(186, 33);
            this.buttonCourseInfo.TabIndex = 95;
            this.buttonCourseInfo.Text = "Thay đổi khóa học";
            this.buttonCourseInfo.UseVisualStyleBackColor = false;
            this.buttonCourseInfo.Click += new System.EventHandler(this.buttonCourseInfo_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(94)))), ((int)(((byte)(242)))));
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.ForeColor = System.Drawing.Color.White;
            this.buttonDelete.Location = new System.Drawing.Point(636, 337);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(186, 33);
            this.buttonDelete.TabIndex = 97;
            this.buttonDelete.Text = "Xóa tài khoản";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonAddAccount
            // 
            this.buttonAddAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(94)))), ((int)(((byte)(242)))));
            this.buttonAddAccount.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddAccount.ForeColor = System.Drawing.Color.White;
            this.buttonAddAccount.Location = new System.Drawing.Point(636, 399);
            this.buttonAddAccount.Name = "buttonAddAccount";
            this.buttonAddAccount.Size = new System.Drawing.Size(186, 33);
            this.buttonAddAccount.TabIndex = 98;
            this.buttonAddAccount.Text = "Thêm tài khoản";
            this.buttonAddAccount.UseVisualStyleBackColor = false;
            this.buttonAddAccount.Click += new System.EventHandler(this.buttonAddAccount_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(94)))), ((int)(((byte)(242)))));
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(19, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(563, 98);
            this.panel1.TabIndex = 99;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(129, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(335, 36);
            this.label6.TabIndex = 0;
            this.label6.Text = "QUẢN LÝ TÀI KHOẢN";
            // 
            // fAccountManager
            // 
            this.AcceptButton = this.buttonSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 572);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonAddAccount);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonCourseInfo);
            this.Controls.Add(this.buttonUpdateData);
            this.Controls.Add(this.labelTutorName);
            this.Controls.Add(this.labelTutorID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxSearchName);
            this.Controls.Add(this.buttonShowAll);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.dataGridViewListTutor);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.MaximizeBox = false;
            this.Name = "fAccountManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý tài khoản";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListTutor)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.DataGridView dataGridViewListTutor;
        private System.Windows.Forms.Button buttonShowAll;
        private System.Windows.Forms.TextBox textBoxSearchName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelTutorName;
        private System.Windows.Forms.Label labelTutorID;
        private System.Windows.Forms.Button buttonUpdateData;
        private System.Windows.Forms.Button buttonCourseInfo;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonAddAccount;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
    }
}