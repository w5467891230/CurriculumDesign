using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LibraryMIS
{
	/// <summary>
	/// ModifyUser ��ժҪ˵����
	/// </summary>
	public class ModifyUser : System.Windows.Forms.Form
	{
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton radioWork;
		private System.Windows.Forms.RadioButton radioManage;
		public System.Windows.Forms.TextBox textName;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btClose;
		private System.Windows.Forms.Button btModify;
		/// <summary>
		/// ����������������
		/// </summary>
		private System.ComponentModel.Container components = null;
		private SqlConnection oleConnection1 = null;

		public ModifyUser()
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
            this.radioWork = new System.Windows.Forms.RadioButton();
            this.radioManage = new System.Windows.Forms.RadioButton();
            this.textName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btClose = new System.Windows.Forms.Button();
            this.btModify = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioWork);
            this.groupBox1.Controls.Add(this.radioManage);
            this.groupBox1.Location = new System.Drawing.Point(32, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(245, 62);
            this.groupBox1.TabIndex = 54;
            this.groupBox1.TabStop = false;
            // 
            // radioWork
            // 
            this.radioWork.Location = new System.Drawing.Point(32, 21);
            this.radioWork.Name = "radioWork";
            this.radioWork.Size = new System.Drawing.Size(85, 30);
            this.radioWork.TabIndex = 1;
            this.radioWork.Text = "����Ա";
            // 
            // radioManage
            // 
            this.radioManage.Location = new System.Drawing.Point(128, 21);
            this.radioManage.Name = "radioManage";
            this.radioManage.Size = new System.Drawing.Size(85, 30);
            this.radioManage.TabIndex = 0;
            this.radioManage.Text = "����Ա";
            // 
            // textName
            // 
            this.textName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textName.Font = new System.Drawing.Font("����", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.textName.Location = new System.Drawing.Point(115, 21);
            this.textName.Name = "textName";
            this.textName.ReadOnly = true;
            this.textName.Size = new System.Drawing.Size(160, 25);
            this.textName.TabIndex = 46;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("����", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(29, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 51;
            this.label1.Text = "�û�����";
            // 
            // btClose
            // 
            this.btClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btClose.Font = new System.Drawing.Font("����", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btClose.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btClose.Location = new System.Drawing.Point(181, 165);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(100, 29);
            this.btClose.TabIndex = 50;
            this.btClose.Text = "�˳�";
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // btModify
            // 
            this.btModify.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btModify.Font = new System.Drawing.Font("����", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btModify.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btModify.Location = new System.Drawing.Point(32, 165);
            this.btModify.Name = "btModify";
            this.btModify.Size = new System.Drawing.Size(100, 29);
            this.btModify.TabIndex = 49;
            this.btModify.Text = "�޸�";
            this.btModify.Click += new System.EventHandler(this.btModify_Click);
            // 
            // ModifyUser
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(8, 18);
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(346, 340);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.btModify);
            this.Name = "ModifyUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "�޸�Ȩ��";
            this.Load += new System.EventHandler(this.ModifyUser_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		private void btModify_Click(object sender, System.EventArgs e)
		{
			 if (radioManage.Checked==false&&radioWork.Checked==false)
				MessageBox.Show("��ѡ��Ȩ��","��ʾ");
			else
			{
				oleConnection1.Open();
				string sql;
				if (radioManage.Checked==true)
					sql = "update manager set manage=true,work=false,query=false where MName='"+textName.Text.Trim()+"'";
				else
					sql = "update manager set manage=false,work=true,query=false where MName='"+textName.Text.Trim()+"'";

				SqlCommand cmd = new SqlCommand(sql,oleConnection1);
				cmd.ExecuteNonQuery();
				MessageBox.Show("�޸ĳɹ�","��ʾ");
				this.Close();
				
				oleConnection1.Close();
			}
		}

        private void ModifyUser_Load(object sender, EventArgs e)
        {

        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
	}
}
