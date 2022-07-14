using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LibraryMIS
{
	/// <summary>
	/// AddIdentity ��ժҪ˵����
	/// </summary>
	public class AddIdentity : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button btClose;
		private System.Windows.Forms.Button btAdd;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		/// <summary>
		/// ����������������
		/// </summary>
		private System.ComponentModel.Container components = null;
		private System.Windows.Forms.TextBox textId;
		private System.Windows.Forms.ComboBox comboDate;
		private System.Windows.Forms.ComboBox comboNum;
		private SqlConnection oleConnection1 = null;

		public AddIdentity()
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
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboNum = new System.Windows.Forms.ComboBox();
            this.comboDate = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btClose
            // 
            this.btClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btClose.ForeColor = System.Drawing.Color.Black;
            this.btClose.Location = new System.Drawing.Point(181, 226);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(100, 30);
            this.btClose.TabIndex = 9;
            this.btClose.Text = "ȡ��";
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // btAdd
            // 
            this.btAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btAdd.ForeColor = System.Drawing.Color.Black;
            this.btAdd.Location = new System.Drawing.Point(43, 226);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(100, 30);
            this.btAdd.TabIndex = 8;
            this.btAdd.Text = "ȷ��";
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.comboNum);
            this.groupBox1.Controls.Add(this.comboDate);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textId);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(11, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(309, 195);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "������";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("����", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(256, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "��";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("����", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(256, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "��";
            // 
            // comboNum
            // 
            this.comboNum.Font = new System.Drawing.Font("����", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboNum.Items.AddRange(new object[] {
            "5",
            "10",
            "15",
            "20"});
            this.comboNum.Location = new System.Drawing.Point(149, 154);
            this.comboNum.Name = "comboNum";
            this.comboNum.Size = new System.Drawing.Size(107, 23);
            this.comboNum.TabIndex = 4;
            // 
            // comboDate
            // 
            this.comboDate.Font = new System.Drawing.Font("����", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboDate.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.comboDate.Location = new System.Drawing.Point(149, 103);
            this.comboDate.Name = "comboDate";
            this.comboDate.Size = new System.Drawing.Size(107, 23);
            this.comboDate.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("����", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(43, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "����������";
            // 
            // textId
            // 
            this.textId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textId.Font = new System.Drawing.Font("����", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textId.Location = new System.Drawing.Point(149, 51);
            this.textId.Name = "textId";
            this.textId.Size = new System.Drawing.Size(128, 25);
            this.textId.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("����", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(43, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "�����ʱ��";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("����", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(53, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "��   ��";
            // 
            // AddIdentity
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(8, 18);
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(331, 286);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddIdentity";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "������";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

		}
		#endregion

		private void btAdd_Click(object sender, System.EventArgs e)
		{
			
            ldientyBLL addIentyBLL = new ldientyBLL();

            string ID = textId.Text.Trim();
            string Num = comboNum.Text.Trim();
            string Date = comboDate.Text.Trim();
            if (ID == "" || Num == "" || Date == "")
            {
                string result = addIentyBLL.addIdentity(ID, Date,Num);
                if (result == "���ӳɹ�")
                {
                    MessageBox.Show(result, "��ʾ");
                }
                else
                {
                    MessageBox.Show(result, "��ʾ");
                }
            }
        }

		private void btClose_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}
	}
}
