using System.Drawing;
using System.IO;

namespace QLGS
{
    partial class fDetail
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
            this.labelTuitionTitle = new System.Windows.Forms.Label();
            this.labelDescriptionTitle = new System.Windows.Forms.Label();
            this.richTextBoxDiscription = new System.Windows.Forms.RichTextBox();
            this.labelWorkPlaceC = new System.Windows.Forms.Label();
            this.labelWorkPlace = new System.Windows.Forms.Label();
            this.labelTitleC = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelTutorID = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.textBoxTuition2 = new System.Windows.Forms.TextBox();
            this.textBoxTuition1 = new System.Windows.Forms.TextBox();
            this.labelTuition = new System.Windows.Forms.Label();
            this.labelGrade = new System.Windows.Forms.Label();
            this.labelSubject = new System.Windows.Forms.Label();
            this.labelGenderC = new System.Windows.Forms.Label();
            this.labelGender = new System.Windows.Forms.Label();
            this.labelLearnTimeTitle = new System.Windows.Forms.Label();
            this.tableLayoutPanelLearnTime = new System.Windows.Forms.TableLayoutPanel();
            this.checkBoxSunEve = new System.Windows.Forms.CheckBox();
            this.checkBoxSatAft = new System.Windows.Forms.CheckBox();
            this.checkBoxSatEve = new System.Windows.Forms.CheckBox();
            this.checkBoxSunMor = new System.Windows.Forms.CheckBox();
            this.checkBoxSunAft = new System.Windows.Forms.CheckBox();
            this.checkBoxFriMor = new System.Windows.Forms.CheckBox();
            this.checkBoxFriAft = new System.Windows.Forms.CheckBox();
            this.checkBoxFriEve = new System.Windows.Forms.CheckBox();
            this.checkBoxSatMor = new System.Windows.Forms.CheckBox();
            this.checkBoxMonEve = new System.Windows.Forms.CheckBox();
            this.checkBoxTueEve = new System.Windows.Forms.CheckBox();
            this.checkBoxWedEve = new System.Windows.Forms.CheckBox();
            this.checkBoxThuEve = new System.Windows.Forms.CheckBox();
            this.labelEvening = new System.Windows.Forms.Label();
            this.labelSaturday = new System.Windows.Forms.Label();
            this.checkBoxThuAft = new System.Windows.Forms.CheckBox();
            this.checkBoxThuMor = new System.Windows.Forms.CheckBox();
            this.checkBoxWedAft = new System.Windows.Forms.CheckBox();
            this.checkBoxWedMor = new System.Windows.Forms.CheckBox();
            this.checkBoxTueAft = new System.Windows.Forms.CheckBox();
            this.checkBoxTueMor = new System.Windows.Forms.CheckBox();
            this.checkBoxMonAft = new System.Windows.Forms.CheckBox();
            this.labelMonday = new System.Windows.Forms.Label();
            this.labelAfternoon = new System.Windows.Forms.Label();
            this.labelMorning = new System.Windows.Forms.Label();
            this.labelWeekdays = new System.Windows.Forms.Label();
            this.labelTuesday = new System.Windows.Forms.Label();
            this.labelWednesday = new System.Windows.Forms.Label();
            this.labelThursday = new System.Windows.Forms.Label();
            this.checkBoxMonMor = new System.Windows.Forms.CheckBox();
            this.labelFriday = new System.Windows.Forms.Label();
            this.labelSunday = new System.Windows.Forms.Label();
            this.textBoxSubject1 = new System.Windows.Forms.TextBox();
            this.textBoxSubject2 = new System.Windows.Forms.TextBox();
            this.textBoxGrade1 = new System.Windows.Forms.TextBox();
            this.textBoxGrade2 = new System.Windows.Forms.TextBox();
            this.textBoxGrade4 = new System.Windows.Forms.TextBox();
            this.textBoxGrade3 = new System.Windows.Forms.TextBox();
            this.textBoxSubject4 = new System.Windows.Forms.TextBox();
            this.textBoxSubject3 = new System.Windows.Forms.TextBox();
            this.textBoxTuition4 = new System.Windows.Forms.TextBox();
            this.textBoxTuition3 = new System.Windows.Forms.TextBox();
            this.labelNameC = new System.Windows.Forms.Label();
            this.labelTutorIDC = new System.Windows.Forms.Label();
            this.labelAddressC = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.labelBirthC = new System.Windows.Forms.Label();
            this.labelBirth = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.tableLayoutPanelLearnTime.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTuitionTitle
            // 
            this.labelTuitionTitle.AutoSize = true;
            this.labelTuitionTitle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTuitionTitle.ForeColor = System.Drawing.Color.Black;
            this.labelTuitionTitle.Location = new System.Drawing.Point(232, 219);
            this.labelTuitionTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTuitionTitle.Name = "labelTuitionTitle";
            this.labelTuitionTitle.Size = new System.Drawing.Size(59, 19);
            this.labelTuitionTitle.TabIndex = 85;
            this.labelTuitionTitle.Text = "Học phí:";
            // 
            // labelDescriptionTitle
            // 
            this.labelDescriptionTitle.AutoSize = true;
            this.labelDescriptionTitle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescriptionTitle.ForeColor = System.Drawing.Color.Black;
            this.labelDescriptionTitle.Location = new System.Drawing.Point(232, 27);
            this.labelDescriptionTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDescriptionTitle.Name = "labelDescriptionTitle";
            this.labelDescriptionTitle.Size = new System.Drawing.Size(88, 19);
            this.labelDescriptionTitle.TabIndex = 84;
            this.labelDescriptionTitle.Text = "Tự giới thiệu:";
            // 
            // richTextBoxDiscription
            // 
            this.richTextBoxDiscription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxDiscription.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxDiscription.Location = new System.Drawing.Point(236, 56);
            this.richTextBoxDiscription.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.richTextBoxDiscription.Name = "richTextBoxDiscription";
            this.richTextBoxDiscription.ReadOnly = true;
            this.richTextBoxDiscription.Size = new System.Drawing.Size(343, 138);
            this.richTextBoxDiscription.TabIndex = 83;
            this.richTextBoxDiscription.Text = "";
            // 
            // labelWorkPlaceC
            // 
            this.labelWorkPlaceC.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWorkPlaceC.Location = new System.Drawing.Point(95, 458);
            this.labelWorkPlaceC.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelWorkPlaceC.Name = "labelWorkPlaceC";
            this.labelWorkPlaceC.Size = new System.Drawing.Size(100, 61);
            this.labelWorkPlaceC.TabIndex = 82;
            // 
            // labelWorkPlace
            // 
            this.labelWorkPlace.AutoSize = true;
            this.labelWorkPlace.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWorkPlace.ForeColor = System.Drawing.Color.Black;
            this.labelWorkPlace.Location = new System.Drawing.Point(23, 458);
            this.labelWorkPlace.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelWorkPlace.Name = "labelWorkPlace";
            this.labelWorkPlace.Size = new System.Drawing.Size(47, 13);
            this.labelWorkPlace.TabIndex = 81;
            this.labelWorkPlace.Text = "Trường:";
            // 
            // labelTitleC
            // 
            this.labelTitleC.AutoSize = true;
            this.labelTitleC.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitleC.Location = new System.Drawing.Point(95, 431);
            this.labelTitleC.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTitleC.Name = "labelTitleC";
            this.labelTitleC.Size = new System.Drawing.Size(0, 13);
            this.labelTitleC.TabIndex = 80;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.Black;
            this.labelTitle.Location = new System.Drawing.Point(23, 431);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(51, 13);
            this.labelTitle.TabIndex = 79;
            this.labelTitle.Text = "Chức vụ:";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.ForeColor = System.Drawing.Color.Black;
            this.labelName.Location = new System.Drawing.Point(23, 319);
            this.labelName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(62, 13);
            this.labelName.TabIndex = 77;
            this.labelName.Text = "Họ và tên: ";
            // 
            // labelTutorID
            // 
            this.labelTutorID.AutoSize = true;
            this.labelTutorID.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTutorID.ForeColor = System.Drawing.Color.Black;
            this.labelTutorID.Location = new System.Drawing.Point(23, 292);
            this.labelTutorID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTutorID.Name = "labelTutorID";
            this.labelTutorID.Size = new System.Drawing.Size(60, 13);
            this.labelTutorID.TabIndex = 75;
            this.labelTutorID.Text = "Mã gia sư:";
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(26, 28);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(154, 237);
            this.pictureBox.TabIndex = 74;
            this.pictureBox.TabStop = false;
            // 
            // textBoxTuition2
            // 
            this.textBoxTuition2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTuition2.Location = new System.Drawing.Point(457, 301);
            this.textBoxTuition2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxTuition2.Multiline = true;
            this.textBoxTuition2.Name = "textBoxTuition2";
            this.textBoxTuition2.ReadOnly = true;
            this.textBoxTuition2.Size = new System.Drawing.Size(122, 24);
            this.textBoxTuition2.TabIndex = 94;
            this.textBoxTuition2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxTuition1
            // 
            this.textBoxTuition1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTuition1.Location = new System.Drawing.Point(457, 271);
            this.textBoxTuition1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxTuition1.Multiline = true;
            this.textBoxTuition1.Name = "textBoxTuition1";
            this.textBoxTuition1.ReadOnly = true;
            this.textBoxTuition1.Size = new System.Drawing.Size(122, 24);
            this.textBoxTuition1.TabIndex = 91;
            this.textBoxTuition1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelTuition
            // 
            this.labelTuition.AutoSize = true;
            this.labelTuition.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTuition.ForeColor = System.Drawing.Color.Black;
            this.labelTuition.Location = new System.Drawing.Point(454, 249);
            this.labelTuition.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTuition.Name = "labelTuition";
            this.labelTuition.Size = new System.Drawing.Size(124, 15);
            this.labelTuition.TabIndex = 90;
            this.labelTuition.Text = "Học phí (đồng/tháng)";
            // 
            // labelGrade
            // 
            this.labelGrade.AutoSize = true;
            this.labelGrade.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGrade.ForeColor = System.Drawing.Color.Black;
            this.labelGrade.Location = new System.Drawing.Point(365, 249);
            this.labelGrade.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelGrade.Name = "labelGrade";
            this.labelGrade.Size = new System.Drawing.Size(27, 15);
            this.labelGrade.TabIndex = 88;
            this.labelGrade.Text = "Lớp";
            // 
            // labelSubject
            // 
            this.labelSubject.AutoSize = true;
            this.labelSubject.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSubject.ForeColor = System.Drawing.Color.Black;
            this.labelSubject.Location = new System.Drawing.Point(232, 249);
            this.labelSubject.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSubject.Name = "labelSubject";
            this.labelSubject.Size = new System.Drawing.Size(32, 15);
            this.labelSubject.TabIndex = 86;
            this.labelSubject.Text = "Môn";
            // 
            // labelGenderC
            // 
            this.labelGenderC.AutoSize = true;
            this.labelGenderC.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGenderC.Location = new System.Drawing.Point(95, 347);
            this.labelGenderC.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelGenderC.Name = "labelGenderC";
            this.labelGenderC.Size = new System.Drawing.Size(0, 13);
            this.labelGenderC.TabIndex = 96;
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGender.ForeColor = System.Drawing.Color.Black;
            this.labelGender.Location = new System.Drawing.Point(23, 347);
            this.labelGender.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(55, 13);
            this.labelGender.TabIndex = 95;
            this.labelGender.Text = "Giới tính:";
            // 
            // labelLearnTimeTitle
            // 
            this.labelLearnTimeTitle.AutoSize = true;
            this.labelLearnTimeTitle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLearnTimeTitle.Location = new System.Drawing.Point(234, 405);
            this.labelLearnTimeTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLearnTimeTitle.Name = "labelLearnTimeTitle";
            this.labelLearnTimeTitle.Size = new System.Drawing.Size(100, 19);
            this.labelLearnTimeTitle.TabIndex = 98;
            this.labelLearnTimeTitle.Text = "Thời gian rảnh:";
            // 
            // tableLayoutPanelLearnTime
            // 
            this.tableLayoutPanelLearnTime.ColumnCount = 4;
            this.tableLayoutPanelLearnTime.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelLearnTime.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelLearnTime.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelLearnTime.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelLearnTime.Controls.Add(this.checkBoxSunEve, 3, 7);
            this.tableLayoutPanelLearnTime.Controls.Add(this.checkBoxSatAft, 2, 6);
            this.tableLayoutPanelLearnTime.Controls.Add(this.checkBoxSatEve, 3, 6);
            this.tableLayoutPanelLearnTime.Controls.Add(this.checkBoxSunMor, 1, 7);
            this.tableLayoutPanelLearnTime.Controls.Add(this.checkBoxSunAft, 2, 7);
            this.tableLayoutPanelLearnTime.Controls.Add(this.checkBoxFriMor, 1, 5);
            this.tableLayoutPanelLearnTime.Controls.Add(this.checkBoxFriAft, 2, 5);
            this.tableLayoutPanelLearnTime.Controls.Add(this.checkBoxFriEve, 3, 5);
            this.tableLayoutPanelLearnTime.Controls.Add(this.checkBoxSatMor, 1, 6);
            this.tableLayoutPanelLearnTime.Controls.Add(this.checkBoxMonEve, 3, 1);
            this.tableLayoutPanelLearnTime.Controls.Add(this.checkBoxTueEve, 3, 2);
            this.tableLayoutPanelLearnTime.Controls.Add(this.checkBoxWedEve, 3, 3);
            this.tableLayoutPanelLearnTime.Controls.Add(this.checkBoxThuEve, 3, 4);
            this.tableLayoutPanelLearnTime.Controls.Add(this.labelEvening, 3, 0);
            this.tableLayoutPanelLearnTime.Controls.Add(this.labelSaturday, 0, 6);
            this.tableLayoutPanelLearnTime.Controls.Add(this.checkBoxThuAft, 2, 4);
            this.tableLayoutPanelLearnTime.Controls.Add(this.checkBoxThuMor, 1, 4);
            this.tableLayoutPanelLearnTime.Controls.Add(this.checkBoxWedAft, 2, 3);
            this.tableLayoutPanelLearnTime.Controls.Add(this.checkBoxWedMor, 1, 3);
            this.tableLayoutPanelLearnTime.Controls.Add(this.checkBoxTueAft, 2, 2);
            this.tableLayoutPanelLearnTime.Controls.Add(this.checkBoxTueMor, 1, 2);
            this.tableLayoutPanelLearnTime.Controls.Add(this.checkBoxMonAft, 2, 1);
            this.tableLayoutPanelLearnTime.Controls.Add(this.labelMonday, 0, 1);
            this.tableLayoutPanelLearnTime.Controls.Add(this.labelAfternoon, 2, 0);
            this.tableLayoutPanelLearnTime.Controls.Add(this.labelMorning, 1, 0);
            this.tableLayoutPanelLearnTime.Controls.Add(this.labelWeekdays, 0, 0);
            this.tableLayoutPanelLearnTime.Controls.Add(this.labelTuesday, 0, 2);
            this.tableLayoutPanelLearnTime.Controls.Add(this.labelWednesday, 0, 3);
            this.tableLayoutPanelLearnTime.Controls.Add(this.labelThursday, 0, 4);
            this.tableLayoutPanelLearnTime.Controls.Add(this.checkBoxMonMor, 1, 1);
            this.tableLayoutPanelLearnTime.Controls.Add(this.labelFriday, 0, 5);
            this.tableLayoutPanelLearnTime.Controls.Add(this.labelSunday, 0, 7);
            this.tableLayoutPanelLearnTime.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanelLearnTime.Location = new System.Drawing.Point(235, 436);
            this.tableLayoutPanelLearnTime.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanelLearnTime.Name = "tableLayoutPanelLearnTime";
            this.tableLayoutPanelLearnTime.RowCount = 8;
            this.tableLayoutPanelLearnTime.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanelLearnTime.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanelLearnTime.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanelLearnTime.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanelLearnTime.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanelLearnTime.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanelLearnTime.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanelLearnTime.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanelLearnTime.Size = new System.Drawing.Size(344, 206);
            this.tableLayoutPanelLearnTime.TabIndex = 97;
            // 
            // checkBoxSunEve
            // 
            this.checkBoxSunEve.AutoSize = true;
            this.checkBoxSunEve.Enabled = false;
            this.checkBoxSunEve.Location = new System.Drawing.Point(260, 177);
            this.checkBoxSunEve.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBoxSunEve.Name = "checkBoxSunEve";
            this.checkBoxSunEve.Size = new System.Drawing.Size(15, 14);
            this.checkBoxSunEve.TabIndex = 70;
            this.checkBoxSunEve.UseVisualStyleBackColor = true;
            // 
            // checkBoxSatAft
            // 
            this.checkBoxSatAft.AutoSize = true;
            this.checkBoxSatAft.Enabled = false;
            this.checkBoxSatAft.Location = new System.Drawing.Point(174, 152);
            this.checkBoxSatAft.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBoxSatAft.Name = "checkBoxSatAft";
            this.checkBoxSatAft.Size = new System.Drawing.Size(15, 14);
            this.checkBoxSatAft.TabIndex = 69;
            this.checkBoxSatAft.UseVisualStyleBackColor = true;
            // 
            // checkBoxSatEve
            // 
            this.checkBoxSatEve.AutoSize = true;
            this.checkBoxSatEve.Enabled = false;
            this.checkBoxSatEve.Location = new System.Drawing.Point(260, 152);
            this.checkBoxSatEve.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBoxSatEve.Name = "checkBoxSatEve";
            this.checkBoxSatEve.Size = new System.Drawing.Size(15, 14);
            this.checkBoxSatEve.TabIndex = 68;
            this.checkBoxSatEve.UseVisualStyleBackColor = true;
            // 
            // checkBoxSunMor
            // 
            this.checkBoxSunMor.AutoSize = true;
            this.checkBoxSunMor.Enabled = false;
            this.checkBoxSunMor.Location = new System.Drawing.Point(88, 177);
            this.checkBoxSunMor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBoxSunMor.Name = "checkBoxSunMor";
            this.checkBoxSunMor.Size = new System.Drawing.Size(15, 14);
            this.checkBoxSunMor.TabIndex = 67;
            this.checkBoxSunMor.UseVisualStyleBackColor = true;
            // 
            // checkBoxSunAft
            // 
            this.checkBoxSunAft.AutoSize = true;
            this.checkBoxSunAft.Enabled = false;
            this.checkBoxSunAft.Location = new System.Drawing.Point(174, 177);
            this.checkBoxSunAft.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBoxSunAft.Name = "checkBoxSunAft";
            this.checkBoxSunAft.Size = new System.Drawing.Size(15, 14);
            this.checkBoxSunAft.TabIndex = 66;
            this.checkBoxSunAft.UseVisualStyleBackColor = true;
            // 
            // checkBoxFriMor
            // 
            this.checkBoxFriMor.AutoSize = true;
            this.checkBoxFriMor.Enabled = false;
            this.checkBoxFriMor.Location = new System.Drawing.Point(88, 127);
            this.checkBoxFriMor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBoxFriMor.Name = "checkBoxFriMor";
            this.checkBoxFriMor.Size = new System.Drawing.Size(15, 14);
            this.checkBoxFriMor.TabIndex = 65;
            this.checkBoxFriMor.UseVisualStyleBackColor = true;
            // 
            // checkBoxFriAft
            // 
            this.checkBoxFriAft.AutoSize = true;
            this.checkBoxFriAft.Enabled = false;
            this.checkBoxFriAft.Location = new System.Drawing.Point(174, 127);
            this.checkBoxFriAft.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBoxFriAft.Name = "checkBoxFriAft";
            this.checkBoxFriAft.Size = new System.Drawing.Size(15, 14);
            this.checkBoxFriAft.TabIndex = 64;
            this.checkBoxFriAft.UseVisualStyleBackColor = true;
            // 
            // checkBoxFriEve
            // 
            this.checkBoxFriEve.AutoSize = true;
            this.checkBoxFriEve.Enabled = false;
            this.checkBoxFriEve.Location = new System.Drawing.Point(260, 127);
            this.checkBoxFriEve.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBoxFriEve.Name = "checkBoxFriEve";
            this.checkBoxFriEve.Size = new System.Drawing.Size(15, 14);
            this.checkBoxFriEve.TabIndex = 63;
            this.checkBoxFriEve.UseVisualStyleBackColor = true;
            // 
            // checkBoxSatMor
            // 
            this.checkBoxSatMor.AutoSize = true;
            this.checkBoxSatMor.Enabled = false;
            this.checkBoxSatMor.Location = new System.Drawing.Point(88, 152);
            this.checkBoxSatMor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBoxSatMor.Name = "checkBoxSatMor";
            this.checkBoxSatMor.Size = new System.Drawing.Size(15, 14);
            this.checkBoxSatMor.TabIndex = 62;
            this.checkBoxSatMor.UseVisualStyleBackColor = true;
            // 
            // checkBoxMonEve
            // 
            this.checkBoxMonEve.AutoSize = true;
            this.checkBoxMonEve.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxMonEve.Enabled = false;
            this.checkBoxMonEve.Location = new System.Drawing.Point(260, 27);
            this.checkBoxMonEve.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBoxMonEve.Name = "checkBoxMonEve";
            this.checkBoxMonEve.Size = new System.Drawing.Size(15, 14);
            this.checkBoxMonEve.TabIndex = 61;
            this.checkBoxMonEve.UseVisualStyleBackColor = false;
            // 
            // checkBoxTueEve
            // 
            this.checkBoxTueEve.AutoSize = true;
            this.checkBoxTueEve.Enabled = false;
            this.checkBoxTueEve.Location = new System.Drawing.Point(260, 52);
            this.checkBoxTueEve.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBoxTueEve.Name = "checkBoxTueEve";
            this.checkBoxTueEve.Size = new System.Drawing.Size(15, 14);
            this.checkBoxTueEve.TabIndex = 60;
            this.checkBoxTueEve.UseVisualStyleBackColor = true;
            // 
            // checkBoxWedEve
            // 
            this.checkBoxWedEve.AutoSize = true;
            this.checkBoxWedEve.Enabled = false;
            this.checkBoxWedEve.Location = new System.Drawing.Point(260, 77);
            this.checkBoxWedEve.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBoxWedEve.Name = "checkBoxWedEve";
            this.checkBoxWedEve.Size = new System.Drawing.Size(15, 14);
            this.checkBoxWedEve.TabIndex = 59;
            this.checkBoxWedEve.UseVisualStyleBackColor = true;
            // 
            // checkBoxThuEve
            // 
            this.checkBoxThuEve.AutoSize = true;
            this.checkBoxThuEve.Enabled = false;
            this.checkBoxThuEve.Location = new System.Drawing.Point(260, 102);
            this.checkBoxThuEve.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBoxThuEve.Name = "checkBoxThuEve";
            this.checkBoxThuEve.Size = new System.Drawing.Size(15, 14);
            this.checkBoxThuEve.TabIndex = 58;
            this.checkBoxThuEve.UseVisualStyleBackColor = true;
            // 
            // labelEvening
            // 
            this.labelEvening.AutoSize = true;
            this.labelEvening.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEvening.ForeColor = System.Drawing.Color.Black;
            this.labelEvening.Location = new System.Drawing.Point(260, 0);
            this.labelEvening.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEvening.Name = "labelEvening";
            this.labelEvening.Size = new System.Drawing.Size(23, 15);
            this.labelEvening.TabIndex = 57;
            this.labelEvening.Text = "Tối";
            // 
            // labelSaturday
            // 
            this.labelSaturday.AutoSize = true;
            this.labelSaturday.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSaturday.ForeColor = System.Drawing.Color.Black;
            this.labelSaturday.Location = new System.Drawing.Point(2, 150);
            this.labelSaturday.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSaturday.Name = "labelSaturday";
            this.labelSaturday.Size = new System.Drawing.Size(36, 15);
            this.labelSaturday.TabIndex = 55;
            this.labelSaturday.Text = "Thứ 7";
            // 
            // checkBoxThuAft
            // 
            this.checkBoxThuAft.AutoSize = true;
            this.checkBoxThuAft.Enabled = false;
            this.checkBoxThuAft.Location = new System.Drawing.Point(174, 102);
            this.checkBoxThuAft.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBoxThuAft.Name = "checkBoxThuAft";
            this.checkBoxThuAft.Size = new System.Drawing.Size(15, 14);
            this.checkBoxThuAft.TabIndex = 14;
            this.checkBoxThuAft.UseVisualStyleBackColor = true;
            // 
            // checkBoxThuMor
            // 
            this.checkBoxThuMor.AutoSize = true;
            this.checkBoxThuMor.Enabled = false;
            this.checkBoxThuMor.Location = new System.Drawing.Point(88, 102);
            this.checkBoxThuMor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBoxThuMor.Name = "checkBoxThuMor";
            this.checkBoxThuMor.Size = new System.Drawing.Size(15, 14);
            this.checkBoxThuMor.TabIndex = 13;
            this.checkBoxThuMor.UseVisualStyleBackColor = true;
            // 
            // checkBoxWedAft
            // 
            this.checkBoxWedAft.AutoSize = true;
            this.checkBoxWedAft.Enabled = false;
            this.checkBoxWedAft.Location = new System.Drawing.Point(174, 77);
            this.checkBoxWedAft.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBoxWedAft.Name = "checkBoxWedAft";
            this.checkBoxWedAft.Size = new System.Drawing.Size(15, 14);
            this.checkBoxWedAft.TabIndex = 12;
            this.checkBoxWedAft.UseVisualStyleBackColor = true;
            // 
            // checkBoxWedMor
            // 
            this.checkBoxWedMor.AutoSize = true;
            this.checkBoxWedMor.Enabled = false;
            this.checkBoxWedMor.Location = new System.Drawing.Point(88, 77);
            this.checkBoxWedMor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBoxWedMor.Name = "checkBoxWedMor";
            this.checkBoxWedMor.Size = new System.Drawing.Size(15, 14);
            this.checkBoxWedMor.TabIndex = 11;
            this.checkBoxWedMor.UseVisualStyleBackColor = true;
            // 
            // checkBoxTueAft
            // 
            this.checkBoxTueAft.AutoSize = true;
            this.checkBoxTueAft.Enabled = false;
            this.checkBoxTueAft.Location = new System.Drawing.Point(174, 52);
            this.checkBoxTueAft.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBoxTueAft.Name = "checkBoxTueAft";
            this.checkBoxTueAft.Size = new System.Drawing.Size(15, 14);
            this.checkBoxTueAft.TabIndex = 10;
            this.checkBoxTueAft.UseVisualStyleBackColor = true;
            // 
            // checkBoxTueMor
            // 
            this.checkBoxTueMor.AutoSize = true;
            this.checkBoxTueMor.Enabled = false;
            this.checkBoxTueMor.Location = new System.Drawing.Point(88, 52);
            this.checkBoxTueMor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBoxTueMor.Name = "checkBoxTueMor";
            this.checkBoxTueMor.Size = new System.Drawing.Size(15, 14);
            this.checkBoxTueMor.TabIndex = 9;
            this.checkBoxTueMor.UseVisualStyleBackColor = true;
            // 
            // checkBoxMonAft
            // 
            this.checkBoxMonAft.AutoSize = true;
            this.checkBoxMonAft.Enabled = false;
            this.checkBoxMonAft.Location = new System.Drawing.Point(174, 27);
            this.checkBoxMonAft.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBoxMonAft.Name = "checkBoxMonAft";
            this.checkBoxMonAft.Size = new System.Drawing.Size(15, 14);
            this.checkBoxMonAft.TabIndex = 8;
            this.checkBoxMonAft.UseVisualStyleBackColor = true;
            // 
            // labelMonday
            // 
            this.labelMonday.AutoSize = true;
            this.labelMonday.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMonday.ForeColor = System.Drawing.Color.Black;
            this.labelMonday.Location = new System.Drawing.Point(2, 25);
            this.labelMonday.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMonday.Name = "labelMonday";
            this.labelMonday.Size = new System.Drawing.Size(36, 15);
            this.labelMonday.TabIndex = 3;
            this.labelMonday.Text = "Thứ 2";
            // 
            // labelAfternoon
            // 
            this.labelAfternoon.AutoSize = true;
            this.labelAfternoon.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAfternoon.ForeColor = System.Drawing.Color.Black;
            this.labelAfternoon.Location = new System.Drawing.Point(174, 0);
            this.labelAfternoon.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAfternoon.Name = "labelAfternoon";
            this.labelAfternoon.Size = new System.Drawing.Size(38, 15);
            this.labelAfternoon.TabIndex = 2;
            this.labelAfternoon.Text = "Chiều";
            // 
            // labelMorning
            // 
            this.labelMorning.AutoSize = true;
            this.labelMorning.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMorning.ForeColor = System.Drawing.Color.Black;
            this.labelMorning.Location = new System.Drawing.Point(88, 0);
            this.labelMorning.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMorning.Name = "labelMorning";
            this.labelMorning.Size = new System.Drawing.Size(33, 15);
            this.labelMorning.TabIndex = 1;
            this.labelMorning.Text = "Sáng";
            // 
            // labelWeekdays
            // 
            this.labelWeekdays.AutoSize = true;
            this.labelWeekdays.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWeekdays.ForeColor = System.Drawing.Color.Black;
            this.labelWeekdays.Location = new System.Drawing.Point(2, 0);
            this.labelWeekdays.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelWeekdays.Name = "labelWeekdays";
            this.labelWeekdays.Size = new System.Drawing.Size(27, 15);
            this.labelWeekdays.TabIndex = 0;
            this.labelWeekdays.Text = "Thứ";
            // 
            // labelTuesday
            // 
            this.labelTuesday.AutoSize = true;
            this.labelTuesday.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTuesday.ForeColor = System.Drawing.Color.Black;
            this.labelTuesday.Location = new System.Drawing.Point(2, 50);
            this.labelTuesday.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTuesday.Name = "labelTuesday";
            this.labelTuesday.Size = new System.Drawing.Size(36, 15);
            this.labelTuesday.TabIndex = 4;
            this.labelTuesday.Text = "Thứ 3";
            // 
            // labelWednesday
            // 
            this.labelWednesday.AutoSize = true;
            this.labelWednesday.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWednesday.ForeColor = System.Drawing.Color.Black;
            this.labelWednesday.Location = new System.Drawing.Point(2, 75);
            this.labelWednesday.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelWednesday.Name = "labelWednesday";
            this.labelWednesday.Size = new System.Drawing.Size(36, 15);
            this.labelWednesday.TabIndex = 5;
            this.labelWednesday.Text = "Thứ 4";
            // 
            // labelThursday
            // 
            this.labelThursday.AutoSize = true;
            this.labelThursday.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelThursday.ForeColor = System.Drawing.Color.Black;
            this.labelThursday.Location = new System.Drawing.Point(2, 100);
            this.labelThursday.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelThursday.Name = "labelThursday";
            this.labelThursday.Size = new System.Drawing.Size(36, 15);
            this.labelThursday.TabIndex = 6;
            this.labelThursday.Text = "Thứ 5";
            // 
            // checkBoxMonMor
            // 
            this.checkBoxMonMor.AutoSize = true;
            this.checkBoxMonMor.Enabled = false;
            this.checkBoxMonMor.Location = new System.Drawing.Point(88, 27);
            this.checkBoxMonMor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBoxMonMor.Name = "checkBoxMonMor";
            this.checkBoxMonMor.Size = new System.Drawing.Size(15, 14);
            this.checkBoxMonMor.TabIndex = 7;
            this.checkBoxMonMor.UseVisualStyleBackColor = true;
            // 
            // labelFriday
            // 
            this.labelFriday.AutoSize = true;
            this.labelFriday.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFriday.ForeColor = System.Drawing.Color.Black;
            this.labelFriday.Location = new System.Drawing.Point(2, 125);
            this.labelFriday.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFriday.Name = "labelFriday";
            this.labelFriday.Size = new System.Drawing.Size(36, 15);
            this.labelFriday.TabIndex = 15;
            this.labelFriday.Text = "Thứ 6";
            // 
            // labelSunday
            // 
            this.labelSunday.AutoSize = true;
            this.labelSunday.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSunday.ForeColor = System.Drawing.Color.Black;
            this.labelSunday.Location = new System.Drawing.Point(2, 175);
            this.labelSunday.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSunday.Name = "labelSunday";
            this.labelSunday.Size = new System.Drawing.Size(56, 15);
            this.labelSunday.TabIndex = 56;
            this.labelSunday.Text = "Chủ nhật";
            // 
            // textBoxSubject1
            // 
            this.textBoxSubject1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSubject1.Location = new System.Drawing.Point(235, 271);
            this.textBoxSubject1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxSubject1.Multiline = true;
            this.textBoxSubject1.Name = "textBoxSubject1";
            this.textBoxSubject1.ReadOnly = true;
            this.textBoxSubject1.Size = new System.Drawing.Size(108, 24);
            this.textBoxSubject1.TabIndex = 99;
            // 
            // textBoxSubject2
            // 
            this.textBoxSubject2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSubject2.Location = new System.Drawing.Point(235, 301);
            this.textBoxSubject2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxSubject2.Multiline = true;
            this.textBoxSubject2.Name = "textBoxSubject2";
            this.textBoxSubject2.ReadOnly = true;
            this.textBoxSubject2.Size = new System.Drawing.Size(108, 24);
            this.textBoxSubject2.TabIndex = 100;
            // 
            // textBoxGrade1
            // 
            this.textBoxGrade1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxGrade1.Location = new System.Drawing.Point(368, 271);
            this.textBoxGrade1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxGrade1.Multiline = true;
            this.textBoxGrade1.Name = "textBoxGrade1";
            this.textBoxGrade1.ReadOnly = true;
            this.textBoxGrade1.Size = new System.Drawing.Size(62, 24);
            this.textBoxGrade1.TabIndex = 101;
            // 
            // textBoxGrade2
            // 
            this.textBoxGrade2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxGrade2.Location = new System.Drawing.Point(368, 301);
            this.textBoxGrade2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxGrade2.Multiline = true;
            this.textBoxGrade2.Name = "textBoxGrade2";
            this.textBoxGrade2.ReadOnly = true;
            this.textBoxGrade2.Size = new System.Drawing.Size(62, 24);
            this.textBoxGrade2.TabIndex = 102;
            // 
            // textBoxGrade4
            // 
            this.textBoxGrade4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxGrade4.Location = new System.Drawing.Point(368, 363);
            this.textBoxGrade4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxGrade4.Multiline = true;
            this.textBoxGrade4.Name = "textBoxGrade4";
            this.textBoxGrade4.ReadOnly = true;
            this.textBoxGrade4.Size = new System.Drawing.Size(62, 24);
            this.textBoxGrade4.TabIndex = 108;
            // 
            // textBoxGrade3
            // 
            this.textBoxGrade3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxGrade3.Location = new System.Drawing.Point(368, 332);
            this.textBoxGrade3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxGrade3.Multiline = true;
            this.textBoxGrade3.Name = "textBoxGrade3";
            this.textBoxGrade3.ReadOnly = true;
            this.textBoxGrade3.Size = new System.Drawing.Size(62, 24);
            this.textBoxGrade3.TabIndex = 107;
            // 
            // textBoxSubject4
            // 
            this.textBoxSubject4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSubject4.Location = new System.Drawing.Point(234, 363);
            this.textBoxSubject4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxSubject4.Multiline = true;
            this.textBoxSubject4.Name = "textBoxSubject4";
            this.textBoxSubject4.ReadOnly = true;
            this.textBoxSubject4.Size = new System.Drawing.Size(108, 24);
            this.textBoxSubject4.TabIndex = 106;
            // 
            // textBoxSubject3
            // 
            this.textBoxSubject3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSubject3.Location = new System.Drawing.Point(234, 332);
            this.textBoxSubject3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxSubject3.Multiline = true;
            this.textBoxSubject3.Name = "textBoxSubject3";
            this.textBoxSubject3.ReadOnly = true;
            this.textBoxSubject3.Size = new System.Drawing.Size(108, 24);
            this.textBoxSubject3.TabIndex = 105;
            // 
            // textBoxTuition4
            // 
            this.textBoxTuition4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTuition4.Location = new System.Drawing.Point(456, 363);
            this.textBoxTuition4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxTuition4.Multiline = true;
            this.textBoxTuition4.Name = "textBoxTuition4";
            this.textBoxTuition4.ReadOnly = true;
            this.textBoxTuition4.Size = new System.Drawing.Size(122, 24);
            this.textBoxTuition4.TabIndex = 104;
            this.textBoxTuition4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxTuition3
            // 
            this.textBoxTuition3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTuition3.Location = new System.Drawing.Point(456, 332);
            this.textBoxTuition3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxTuition3.Multiline = true;
            this.textBoxTuition3.Name = "textBoxTuition3";
            this.textBoxTuition3.ReadOnly = true;
            this.textBoxTuition3.Size = new System.Drawing.Size(122, 24);
            this.textBoxTuition3.TabIndex = 103;
            this.textBoxTuition3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelNameC
            // 
            this.labelNameC.AutoSize = true;
            this.labelNameC.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNameC.Location = new System.Drawing.Point(95, 319);
            this.labelNameC.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNameC.Name = "labelNameC";
            this.labelNameC.Size = new System.Drawing.Size(0, 13);
            this.labelNameC.TabIndex = 109;
            // 
            // labelTutorIDC
            // 
            this.labelTutorIDC.AutoSize = true;
            this.labelTutorIDC.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTutorIDC.Location = new System.Drawing.Point(95, 292);
            this.labelTutorIDC.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTutorIDC.Name = "labelTutorIDC";
            this.labelTutorIDC.Size = new System.Drawing.Size(0, 13);
            this.labelTutorIDC.TabIndex = 1;
            // 
            // labelAddressC
            // 
            this.labelAddressC.AutoSize = true;
            this.labelAddressC.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddressC.Location = new System.Drawing.Point(95, 376);
            this.labelAddressC.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAddressC.Name = "labelAddressC";
            this.labelAddressC.Size = new System.Drawing.Size(0, 13);
            this.labelAddressC.TabIndex = 112;
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddress.ForeColor = System.Drawing.Color.Black;
            this.labelAddress.Location = new System.Drawing.Point(23, 376);
            this.labelAddress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(45, 13);
            this.labelAddress.TabIndex = 111;
            this.labelAddress.Text = "Địa chỉ:";
            // 
            // labelBirthC
            // 
            this.labelBirthC.AutoSize = true;
            this.labelBirthC.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBirthC.Location = new System.Drawing.Point(95, 405);
            this.labelBirthC.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelBirthC.Name = "labelBirthC";
            this.labelBirthC.Size = new System.Drawing.Size(0, 13);
            this.labelBirthC.TabIndex = 114;
            // 
            // labelBirth
            // 
            this.labelBirth.AutoSize = true;
            this.labelBirth.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBirth.ForeColor = System.Drawing.Color.Black;
            this.labelBirth.Location = new System.Drawing.Point(23, 405);
            this.labelBirth.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelBirth.Name = "labelBirth";
            this.labelBirth.Size = new System.Drawing.Size(58, 13);
            this.labelBirth.TabIndex = 113;
            this.labelBirth.Text = "Năm sinh:";
            // 
            // fDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 678);
            this.Controls.Add(this.labelBirthC);
            this.Controls.Add(this.labelBirth);
            this.Controls.Add(this.labelAddressC);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.labelTutorIDC);
            this.Controls.Add(this.labelNameC);
            this.Controls.Add(this.textBoxGrade4);
            this.Controls.Add(this.textBoxGrade3);
            this.Controls.Add(this.textBoxSubject4);
            this.Controls.Add(this.textBoxSubject3);
            this.Controls.Add(this.textBoxTuition4);
            this.Controls.Add(this.textBoxTuition3);
            this.Controls.Add(this.textBoxGrade2);
            this.Controls.Add(this.textBoxGrade1);
            this.Controls.Add(this.textBoxSubject2);
            this.Controls.Add(this.textBoxSubject1);
            this.Controls.Add(this.labelLearnTimeTitle);
            this.Controls.Add(this.tableLayoutPanelLearnTime);
            this.Controls.Add(this.labelGenderC);
            this.Controls.Add(this.labelGender);
            this.Controls.Add(this.textBoxTuition2);
            this.Controls.Add(this.textBoxTuition1);
            this.Controls.Add(this.labelTuition);
            this.Controls.Add(this.labelGrade);
            this.Controls.Add(this.labelSubject);
            this.Controls.Add(this.labelTuitionTitle);
            this.Controls.Add(this.labelDescriptionTitle);
            this.Controls.Add(this.richTextBoxDiscription);
            this.Controls.Add(this.labelWorkPlaceC);
            this.Controls.Add(this.labelWorkPlace);
            this.Controls.Add(this.labelTitleC);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelTutorID);
            this.Controls.Add(this.pictureBox);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "fDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chi tiết gia sư";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.tableLayoutPanelLearnTime.ResumeLayout(false);
            this.tableLayoutPanelLearnTime.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTuitionTitle;
        private System.Windows.Forms.Label labelDescriptionTitle;
        private System.Windows.Forms.RichTextBox richTextBoxDiscription;
        private System.Windows.Forms.Label labelWorkPlaceC;
        private System.Windows.Forms.Label labelWorkPlace;
        private System.Windows.Forms.Label labelTitleC;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelTutorID;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.TextBox textBoxTuition2;
        private System.Windows.Forms.TextBox textBoxTuition1;
        private System.Windows.Forms.Label labelTuition;
        private System.Windows.Forms.Label labelGrade;
        private System.Windows.Forms.Label labelSubject;
        private System.Windows.Forms.Label labelGenderC;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.Label labelLearnTimeTitle;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelLearnTime;
        private System.Windows.Forms.CheckBox checkBoxSunEve;
        private System.Windows.Forms.CheckBox checkBoxSatAft;
        private System.Windows.Forms.CheckBox checkBoxSatEve;
        private System.Windows.Forms.CheckBox checkBoxSunMor;
        private System.Windows.Forms.CheckBox checkBoxSunAft;
        private System.Windows.Forms.CheckBox checkBoxFriMor;
        private System.Windows.Forms.CheckBox checkBoxFriAft;
        private System.Windows.Forms.CheckBox checkBoxFriEve;
        private System.Windows.Forms.CheckBox checkBoxSatMor;
        private System.Windows.Forms.CheckBox checkBoxMonEve;
        private System.Windows.Forms.CheckBox checkBoxTueEve;
        private System.Windows.Forms.CheckBox checkBoxWedEve;
        private System.Windows.Forms.CheckBox checkBoxThuEve;
        private System.Windows.Forms.Label labelEvening;
        private System.Windows.Forms.Label labelSaturday;
        private System.Windows.Forms.CheckBox checkBoxThuAft;
        private System.Windows.Forms.CheckBox checkBoxThuMor;
        private System.Windows.Forms.CheckBox checkBoxWedAft;
        private System.Windows.Forms.CheckBox checkBoxWedMor;
        private System.Windows.Forms.CheckBox checkBoxTueAft;
        private System.Windows.Forms.CheckBox checkBoxTueMor;
        private System.Windows.Forms.CheckBox checkBoxMonAft;
        private System.Windows.Forms.Label labelMonday;
        private System.Windows.Forms.Label labelAfternoon;
        private System.Windows.Forms.Label labelMorning;
        private System.Windows.Forms.Label labelWeekdays;
        private System.Windows.Forms.Label labelTuesday;
        private System.Windows.Forms.Label labelWednesday;
        private System.Windows.Forms.Label labelThursday;
        private System.Windows.Forms.CheckBox checkBoxMonMor;
        private System.Windows.Forms.Label labelFriday;
        private System.Windows.Forms.Label labelSunday;
        private System.Windows.Forms.TextBox textBoxSubject1;
        private System.Windows.Forms.TextBox textBoxSubject2;
        private System.Windows.Forms.TextBox textBoxGrade1;
        private System.Windows.Forms.TextBox textBoxGrade2;
        private System.Windows.Forms.TextBox textBoxGrade4;
        private System.Windows.Forms.TextBox textBoxGrade3;
        private System.Windows.Forms.TextBox textBoxSubject4;
        private System.Windows.Forms.TextBox textBoxSubject3;
        private System.Windows.Forms.TextBox textBoxTuition4;
        private System.Windows.Forms.TextBox textBoxTuition3;
        private System.Windows.Forms.Label labelNameC;
        private System.Windows.Forms.Label labelTutorIDC;
        private System.Windows.Forms.Label labelAddressC;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label labelBirthC;
        private System.Windows.Forms.Label labelBirth;
    }
}