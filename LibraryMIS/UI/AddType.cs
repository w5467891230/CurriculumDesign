using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LibraryMIS
{
	/// <summary>
	/// AddType ��ժҪ˵����
	/// </summary>
	public class AddType : System.Windows.Forms.Form
	{
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox textRemark;
		private System.Windows.Forms.TextBox textName;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btClose;
		private System.Windows.Forms.Button btAdd;
		/// <summary>
		/// ����������������
		/// </summary>
		private System.ComponentModel.Container components = null;
		private SqlConnection oleConnection1 = null;

		public AddType()
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.textRemark = new System.Windows.Forms.TextBox();
			this.textName = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.btClose = new System.Windows.Forms.Button();
			this.btAdd = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.textRemark);
			this.groupBox1.Controls.Add(this.textName);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Font = new System.Drawing.Font("����_GB2312", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.groupBox1.ForeColor = System.Drawing.Color.Black;
			this.groupBox1.Location = new System.Drawing.Point(8, 16);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(280, 144);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "�������";
			// 
			// textRemark
			// 
			this.textRemark.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textRemark.Font = new System.Drawing.Font("����", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.textRemark.Location = new System.Drawing.Point(96, 80);
			this.textRemark.Multiline = true;
			this.textRemark.Name = "textRemark";
			this.textRemark.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.textRemark.Size = new System.Drawing.Size(168, 48);
			this.textRemark.TabIndex = 2;
			this.textRemark.Text = "";
			// 
			// textName
			// 
			this.textName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textName.Font = new System.Drawing.Font("����", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.textName.Location = new System.Drawing.Point(96, 40);
			this.textName.Name = "textName";
			this.textName.Size = new System.Drawing.Size(168, 21);
			this.textName.TabIndex = 1;
			this.textName.Text = "";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("����", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label2.Location = new System.Drawing.Point(32, 80);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(64, 24);
			this.label2.TabIndex = 1;
			this.label2.Text = "��������";
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("����", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label1.Location = new System.Drawing.Point(32, 40);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(64, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "��    ��";
			// 
			// btClose
			// 
			this.btClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btClose.ForeColor = System.Drawing.Color.Black;
			this.btClose.Location = new System.Drawing.Point(176, 176);
			this.btClose.Name = "btClose";
			this.btClose.TabIndex = 6;
			this.btClose.Text = "ȡ��";
			this.btClose.Click += new System.EventHandler(this.btClose_Click);
			// 
			// btAdd
			// 
			this.btAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btAdd.ForeColor = System.Drawing.Color.Black;
			this.btAdd.Location = new System.Drawing.Point(40, 176);
			this.btAdd.Name = "btAdd";
			this.btAdd.TabIndex = 5;
			this.btAdd.Text = "ȷ��";
			this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
			// 
			// AddType
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.BackColor = System.Drawing.Color.Snow;
			this.ClientSize = new System.Drawing.Size(296, 214);
			this.Controls.Add(this.btClose);
			this.Controls.Add(this.btAdd);
			this.Controls.Add(this.groupBox1);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "AddType";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "�������";
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void btAdd_Click(object sender, System.EventArgs e)
		{
			if (textName.Text.Trim()==""||textRemark.Text.Trim()=="")
				MessageBox.Show("����д������Ϣ","��ʾ");
			else
			{
				oleConnection1.Open();
				string sql = "select * from type where type='"+textName.Text.Trim()+"'";
				SqlCommand cmd = new SqlCommand(sql,oleConnection1);
				if (null!=cmd.ExecuteScalar())
					MessageBox.Show("�����ظ������������룡","��ʾ");
				else
				{
					sql="insert into type (type,tRemark) values ('"+textName.Text.Trim()+"','"+textRemark.Text.Trim()+"')";
					cmd.CommandText = sql;
					cmd.ExecuteNonQuery();
					MessageBox.Show("������ӳɹ���","��ʾ");
					textName.Clear();
					textRemark.Clear();
				}
				oleConnection1.Close();
			}
		}

		private void btClose_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}
	}
}
