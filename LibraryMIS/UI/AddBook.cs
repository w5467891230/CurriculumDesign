using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LibraryMIS
{
    /// <summary>
    /// AddBook ��ժҪ˵����
    /// </summary>
    public class AddBook : System.Windows.Forms.Form
    {
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textRemark;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TextBox textWriter;
        private System.Windows.Forms.TextBox textPublish;
        private System.Windows.Forms.TextBox textNum;
        private System.Windows.Forms.TextBox textPrice;
        private System.Windows.Forms.ComboBox comboType;
        private System.Windows.Forms.DateTimePicker date1;
        /// <summary>
        /// ����������������
        /// </summary>
        private System.ComponentModel.Container components = null;
        private SqlConnection oleConnection1 = null;

        public AddBook()
        {
            //
            // Windows ���������֧���������
            //
            InitializeComponent();
            this.oleConnection1 = new SqlConnection(LibraryMIS.database.dbConnection.connection);

            //
            // TODO: �� InitializeComponent ���ú�����κι��캯������
            //
        }

        /// <summary>
        /// ������������ʹ�õ���Դ��
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        #region Windows ������������ɵĴ���
        /// <summary>
        /// �����֧������ķ��� - ��Ҫʹ�ô���༭���޸�
        /// �˷��������ݡ�
        /// </summary>
        private void InitializeComponent()
        {
            this.btClose = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.date1 = new System.Windows.Forms.DateTimePicker();
            this.comboType = new System.Windows.Forms.ComboBox();
            this.textPrice = new System.Windows.Forms.TextBox();
            this.textNum = new System.Windows.Forms.TextBox();
            this.textPublish = new System.Windows.Forms.TextBox();
            this.textWriter = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textRemark = new System.Windows.Forms.TextBox();
            this.textID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btClose
            // 
            this.btClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btClose.ForeColor = System.Drawing.Color.Black;
            this.btClose.Location = new System.Drawing.Point(437, 309);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(100, 29);
            this.btClose.TabIndex = 11;
            this.btClose.Text = "ȡ��";
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // btAdd
            // 
            this.btAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btAdd.ForeColor = System.Drawing.Color.Black;
            this.btAdd.Location = new System.Drawing.Point(149, 309);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(100, 29);
            this.btAdd.TabIndex = 10;
            this.btAdd.Text = "ȷ��";
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.date1);
            this.groupBox1.Controls.Add(this.comboType);
            this.groupBox1.Controls.Add(this.textPrice);
            this.groupBox1.Controls.Add(this.textNum);
            this.groupBox1.Controls.Add(this.textPublish);
            this.groupBox1.Controls.Add(this.textWriter);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textRemark);
            this.groupBox1.Controls.Add(this.textID);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(11, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(661, 277);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "���ͼ��";
            // 
            // date1
            // 
            this.date1.Font = new System.Drawing.Font("����", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.date1.Location = new System.Drawing.Point(96, 103);
            this.date1.Name = "date1";
            this.date1.Size = new System.Drawing.Size(133, 25);
            this.date1.TabIndex = 4;
            this.date1.Value = new System.DateTime(2007, 8, 23, 0, 0, 0, 0);
            // 
            // comboType
            // 
            this.comboType.Font = new System.Drawing.Font("����", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboType.Location = new System.Drawing.Point(512, 103);
            this.comboType.Name = "comboType";
            this.comboType.Size = new System.Drawing.Size(133, 23);
            this.comboType.TabIndex = 6;
            // 
            // textPrice
            // 
            this.textPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textPrice.Font = new System.Drawing.Font("����", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textPrice.Location = new System.Drawing.Point(309, 154);
            this.textPrice.Name = "textPrice";
            this.textPrice.Size = new System.Drawing.Size(134, 25);
            this.textPrice.TabIndex = 8;
            // 
            // textNum
            // 
            this.textNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textNum.Font = new System.Drawing.Font("����", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textNum.Location = new System.Drawing.Point(96, 154);
            this.textNum.Name = "textNum";
            this.textNum.Size = new System.Drawing.Size(133, 25);
            this.textNum.TabIndex = 7;
            // 
            // textPublish
            // 
            this.textPublish.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textPublish.Font = new System.Drawing.Font("����", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textPublish.Location = new System.Drawing.Point(309, 103);
            this.textPublish.Name = "textPublish";
            this.textPublish.Size = new System.Drawing.Size(134, 25);
            this.textPublish.TabIndex = 5;
            // 
            // textWriter
            // 
            this.textWriter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textWriter.Font = new System.Drawing.Font("����", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textWriter.Location = new System.Drawing.Point(512, 51);
            this.textWriter.Name = "textWriter";
            this.textWriter.Size = new System.Drawing.Size(133, 25);
            this.textWriter.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("����", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(469, 103);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 20);
            this.label9.TabIndex = 10;
            this.label9.Text = "����";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("����", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(21, 154);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 21);
            this.label8.TabIndex = 9;
            this.label8.Text = "��   ��";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("����", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(256, 154);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 21);
            this.label7.TabIndex = 8;
            this.label7.Text = "�� ��";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("����", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(256, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "������";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("����", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(21, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "��������";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("����", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(469, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "����";
            // 
            // textName
            // 
            this.textName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textName.Font = new System.Drawing.Font("����", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textName.Location = new System.Drawing.Point(309, 51);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(134, 25);
            this.textName.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("����", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(256, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "ͼ����";
            // 
            // textRemark
            // 
            this.textRemark.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textRemark.Font = new System.Drawing.Font("����", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textRemark.Location = new System.Drawing.Point(96, 206);
            this.textRemark.Multiline = true;
            this.textRemark.Name = "textRemark";
            this.textRemark.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textRemark.Size = new System.Drawing.Size(544, 61);
            this.textRemark.TabIndex = 9;
            // 
            // textID
            // 
            this.textID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textID.Font = new System.Drawing.Font("����", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textID.Location = new System.Drawing.Point(96, 51);
            this.textID.Name = "textID";
            this.textID.Size = new System.Drawing.Size(133, 25);
            this.textID.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("����", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(21, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "��   ע";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("����", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(21, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "ͼ����";
            // 
            // AddBook
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(8, 18);
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(747, 369);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "���ͼ��";
            this.Load += new System.EventHandler(this.AddBook_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion

        private void AddBook_Load(object sender, System.EventArgs e)
        {
            try
            {
                oleConnection1.Open();
                string sql = "select TID,type from type";
                SqlDataAdapter adp = new SqlDataAdapter(sql, oleConnection1);

                DataSet ds = new DataSet();
                adp.Fill(ds, "type");
                comboType.DataSource = ds.Tables["type"].DefaultView;
                comboType.DisplayMember = "type";
                comboType.ValueMember = "TID";
                oleConnection1.Close();
            }
            catch (Exception ee)
            {
                Console.WriteLine(ee.Message);
            }
        }

        private void btAdd_Click(object sender, System.EventArgs e)
        {
            if (textID.Text.Trim() == "" || textName.Text.Trim() == "" || textNum.Text.Trim() == "" || textWriter.Text.Trim() == "")
                MessageBox.Show("����д������Ϣ", "��ʾ");
            else
            {
                oleConnection1.Open();
                string sql = "select * from book where BID='" + textID.Text.Trim() + "'";
                SqlCommand cmd = new SqlCommand(sql, oleConnection1);
                if (null != cmd.ExecuteScalar())
                    MessageBox.Show("ͼ�����ظ�", "��ʾ");
                else
                {
                    sql = "insert into book values ('" + textID.Text.Trim() + "','" + textName.Text.Trim() + "','" + textWriter.Text.Trim() + "'," +
                        "'" + textPublish.Text.Trim() + "','" + date1.Text.Trim() + "','" + textPrice.Text.Trim() + "','" + textNum.Text.Trim() + "'," +
                        "'" + comboType.Text.Trim() + "','" + textRemark.Text.Trim() + "')";
                    cmd.CommandText = sql;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("��ӳɹ�", "��ʾ");
                    clear();
                }
                oleConnection1.Close();
            }
        }

        private void clear()
        {
            textID.Text = "";
            textName.Text = "";
            textWriter.Text = "";
            textPublish.Text = "";
            comboType.Text = "";
            textNum.Text = "";
            textPrice.Text = "";
            textRemark.Text = "";
        }

        private void btClose_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}
