using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LibraryMIS
{
	/// <summary>
	/// AddUser ��ժҪ˵����
	/// </summary>
	public class AddUser : System.Windows.Forms.Form
	{
		private System.Windows.Forms.TextBox textPWDNew;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textPassword;
		private System.Windows.Forms.TextBox textName;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btClose;
		private System.Windows.Forms.Button btAdd;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton radioManage;
		private System.Windows.Forms.RadioButton radioWork;
		/// <summary>
		/// ����������������
		/// </summary>
		private System.ComponentModel.Container components = null;
		private SqlConnection oleConnection1 = null;

		public AddUser()
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
            this.textPWDNew = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.textName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btClose = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioWork = new System.Windows.Forms.RadioButton();
            this.radioManage = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textPWDNew
            // 
            this.textPWDNew.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textPWDNew.Font = new System.Drawing.Font("����", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textPWDNew.ForeColor = System.Drawing.SystemColors.ControlText;
            this.textPWDNew.Location = new System.Drawing.Point(116, 125);
            this.textPWDNew.Name = "textPWDNew";
            this.textPWDNew.PasswordChar = '*';
            this.textPWDNew.Size = new System.Drawing.Size(160, 25);
            this.textPWDNew.TabIndex = 38;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("����", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(31, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 44;
            this.label3.Text = "����ȷ��";
            // 
            // textPassword
            // 
            this.textPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textPassword.Font = new System.Drawing.Font("����", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textPassword.ForeColor = System.Drawing.SystemColors.ControlText;
            this.textPassword.Location = new System.Drawing.Point(116, 73);
            this.textPassword.Name = "textPassword";
            this.textPassword.PasswordChar = '*';
            this.textPassword.Size = new System.Drawing.Size(160, 25);
            this.textPassword.TabIndex = 37;
            // 
            // textName
            // 
            this.textName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textName.Font = new System.Drawing.Font("����", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.textName.Location = new System.Drawing.Point(116, 22);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(160, 25);
            this.textName.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("����", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(31, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 15);
            this.label2.TabIndex = 43;
            this.label2.Text = "��    ��";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("����", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(31, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 42;
            this.label1.Text = "�û�����";
            // 
            // btClose
            // 
            this.btClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btClose.Font = new System.Drawing.Font("����", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btClose.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btClose.Location = new System.Drawing.Point(181, 247);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(100, 29);
            this.btClose.TabIndex = 41;
            this.btClose.Text = "�˳�";
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // btAdd
            // 
            this.btAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btAdd.Font = new System.Drawing.Font("����", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btAdd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btAdd.Location = new System.Drawing.Point(32, 247);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(100, 29);
            this.btAdd.TabIndex = 40;
            this.btAdd.Text = "���";
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioWork);
            this.groupBox1.Controls.Add(this.radioManage);
            this.groupBox1.Location = new System.Drawing.Point(32, 165);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(245, 61);
            this.groupBox1.TabIndex = 45;
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
            // AddUser
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(8, 18);
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(367, 328);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textPWDNew);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textPassword);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.btAdd);
            this.Name = "AddUser";
            this.Text = "����û�";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		private void btAdd_Click(object sender, System.EventArgs e)
		{
			Model.manager user = new Model.manager();
			user.MName = textName.Text.Trim();
			user.MCode = textPassword.Text.Trim();
			user.MCodeRe = textPWDNew.Text.Trim();
			user.RadioManage = radioManage.Checked;
			user.RadioWork = radioWork.Checked;

			BLL.UserBLL userBLL = new BLL.UserBLL();
			string result = userBLL.AddUserMethod(user);
			if (result == "��ӳɹ�")
			{
				MessageBox.Show(result, "��ʾ");
			}
			else
			{
				MessageBox.Show(result, "��ʾ");
			}
		}

		private void btClose_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}
	}
}
