using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LibraryMIS
{
	/// <summary>
	/// ModifyUser 的摘要说明。
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
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.Container components = null;
		private SqlConnection oleConnection1 = null;

		public ModifyUser()
		{
			//
			// Windows 窗体设计器支持所必需的
			//
			InitializeComponent();
			this.oleConnection1 = new SqlConnection(LibraryMIS.database.dbConnection.connection);

			//
			// TODO: 在 InitializeComponent 调用后添加任何构造函数代码
			//
		}

		/// <summary>
		/// 清理所有正在使用的资源。
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

		#region Windows 窗体设计器生成的代码
		/// <summary>
		/// 设计器支持所需的方法 - 不要使用代码编辑器修改
		/// 此方法的内容。
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
            this.radioWork.Text = "工作员";
            // 
            // radioManage
            // 
            this.radioManage.Location = new System.Drawing.Point(128, 21);
            this.radioManage.Name = "radioManage";
            this.radioManage.Size = new System.Drawing.Size(85, 30);
            this.radioManage.TabIndex = 0;
            this.radioManage.Text = "管理员";
            // 
            // textName
            // 
            this.textName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textName.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.textName.Location = new System.Drawing.Point(115, 21);
            this.textName.Name = "textName";
            this.textName.ReadOnly = true;
            this.textName.Size = new System.Drawing.Size(160, 21);
            this.textName.TabIndex = 46;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(29, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 51;
            this.label1.Text = "用户名称";
            // 
            // btClose
            // 
            this.btClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btClose.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btClose.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btClose.Location = new System.Drawing.Point(181, 165);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(100, 29);
            this.btClose.TabIndex = 50;
            this.btClose.Text = "退出";
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // btModify
            // 
            this.btModify.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btModify.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btModify.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btModify.Location = new System.Drawing.Point(32, 165);
            this.btModify.Name = "btModify";
            this.btModify.Size = new System.Drawing.Size(100, 29);
            this.btModify.TabIndex = 49;
            this.btModify.Text = "修改";
            this.btModify.Click += new System.EventHandler(this.btModify_Click);
            // 
            // ModifyUser
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(8, 18);
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(362, 230);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.btModify);
            this.Name = "ModifyUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "修改权限";
            this.Load += new System.EventHandler(this.ModifyUser_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		private void btModify_Click(object sender, System.EventArgs e)
		{
            Model.manager manager = new Model.manager();
            manager.RadioManage = radioManage.Checked;
            manager.RadioWork = radioWork.Checked;
            manager.MName = textName.Text.Trim();

            BLL.UserBLL userBLL = new BLL.UserBLL();
            string result = userBLL.ModifyUserMtehod(manager);
            if (result == "修改成功")
            {
                MessageBox.Show(result, "提示");
                this.Close();
            }
            else
            {
                MessageBox.Show(result, "提示");
                this.Close();
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
