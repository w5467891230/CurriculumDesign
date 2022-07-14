using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace LibraryMIS
{
	/// <summary>
	/// Form1 的摘要说明。
	/// </summary>
	public class Login : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button btClose;
		private System.Windows.Forms.Button btAdd;
		private System.Windows.Forms.TextBox password;
		private System.Windows.Forms.TextBox name;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
        private System.ComponentModel.Container components = null;
        private RadioButton radioManage;
        private RadioButton radioPerson;
        private GroupBox groupBox1;
		private SqlConnection oleConnection1 = null;

		public Login()
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
				if (components != null) 
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.btClose = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.password = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.radioManage = new System.Windows.Forms.RadioButton();
            this.radioPerson = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btClose
            // 
            this.btClose.BackColor = System.Drawing.Color.Transparent;
            this.btClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btClose.ForeColor = System.Drawing.Color.Black;
            this.btClose.Location = new System.Drawing.Point(316, 307);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(100, 30);
            this.btClose.TabIndex = 20;
            this.btClose.Text = "取消";
            this.btClose.UseVisualStyleBackColor = false;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // btAdd
            // 
            this.btAdd.BackColor = System.Drawing.Color.Transparent;
            this.btAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btAdd.ForeColor = System.Drawing.Color.Black;
            this.btAdd.Location = new System.Drawing.Point(145, 307);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(100, 30);
            this.btAdd.TabIndex = 19;
            this.btAdd.Text = "确定";
            this.btAdd.UseVisualStyleBackColor = false;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // password
            // 
            this.password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.password.Location = new System.Drawing.Point(279, 244);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(133, 25);
            this.password.TabIndex = 18;
            // 
            // name
            // 
            this.name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.name.Location = new System.Drawing.Point(279, 185);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(133, 25);
            this.name.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoEllipsis = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(141, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 29);
            this.label3.TabIndex = 16;
            this.label3.Text = "密   码";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(141, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 30);
            this.label2.TabIndex = 15;
            this.label2.Text = "用户名";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(139, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 37);
            this.label1.TabIndex = 14;
            this.label1.Text = "图书馆管理信息系统";
            // 
            // radioManage
            // 
            this.radioManage.Location = new System.Drawing.Point(32, 21);
            this.radioManage.Name = "radioManage";
            this.radioManage.Size = new System.Drawing.Size(96, 30);
            this.radioManage.TabIndex = 0;
            this.radioManage.Text = "管理人员";
            // 
            // radioPerson
            // 
            this.radioPerson.Location = new System.Drawing.Point(171, 21);
            this.radioPerson.Name = "radioPerson";
            this.radioPerson.Size = new System.Drawing.Size(64, 30);
            this.radioPerson.TabIndex = 1;
            this.radioPerson.Text = "读者";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.radioPerson);
            this.groupBox1.Controls.Add(this.radioManage);
            this.groupBox1.Location = new System.Drawing.Point(145, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(267, 58);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(8, 18);
            this.BackColor = System.Drawing.Color.Snow;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(481, 405);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.password);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "登录";
            this.Load += new System.EventHandler(this.Login_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		/// <summary>
		/// 应用程序的主入口点。
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Login());
		}

		private void btAdd_Click(object sender, System.EventArgs e)
		{
			if(name.Text.Trim()==""||password.Text.Trim()=="")
				MessageBox.Show("请输入用户名和密码","提示");
			else
			{
				oleConnection1.Open();
				SqlCommand cmd=new SqlCommand("",oleConnection1);
				if (radioManage.Checked==true)
				{
					string sql="select * from manager where MName='"+name.Text.Trim()+"' and MCode='"+password.Text.Trim()+"'";
					cmd.CommandText=sql;
					if (null!=cmd.ExecuteScalar())
					{
						//隐藏登录窗口
						this.Visible=false;  
						//创建并打开主界面
						main main=new main();
						main.Tag=this.FindForm();
						SqlDataReader dr;
						cmd.CommandText=sql;
						dr=cmd.ExecuteReader();
						dr.Read();
			
						main.menuItem1.Visible=(bool)(dr.GetValue(2));
						main.menuItem2.Visible=(bool)(dr.GetValue(2));
						main.menuItem3.Visible=(bool)(dr.GetValue(2));
						main.menuItem5.Visible=(bool)(dr.GetValue(4));
					
						main.menuItem4.Visible=(bool)(dr.GetValue(3));
						main.menuItem5.Visible=(bool)(dr.GetValue(4));

						main.toolBarButton1.Visible=(bool)(dr.GetValue(2));
						main.toolBarButton2.Visible=(bool)(dr.GetValue(2));
						main.toolBarButton3.Visible=(bool)(dr.GetValue(3));
						main.toolBarButton4.Visible=(bool)(dr.GetValue(3));
						main.toolBarButton5.Visible=(bool)(dr.GetValue(4));
	
						main.statusBarPanel2.Text=name.Text.Trim();
						main.statusBarPanel6.Text="管理员";
				
						main.ShowDialog(); 
					}
					else
						MessageBox.Show("用户名或密码错误","警告");					
				}
				else if (radioPerson.Checked==true)
				{
                    string sql = "select * from person where PName='" + name.Text.Trim() + "' and PCode='" + password.Text.Trim() + "'";
					cmd.CommandText=sql;
					if (null!=cmd.ExecuteScalar())
					{
						//隐藏登录窗口
						this.Visible=false;  
						//创建并打开主界面
						main main=new main();
						main.Tag=this.FindForm();
						SqlDataReader dr;
						cmd.CommandText=sql;
						dr=cmd.ExecuteReader();
						dr.Read();
			
						main.menuItem1.Visible=(bool)(dr.GetValue(9));
						main.menuItem2.Visible=(bool)(dr.GetValue(9));
						main.menuItem3.Visible=(bool)(dr.GetValue(9));
						main.menuItem4.Visible=(bool)(dr.GetValue(9));
						main.toolBarButton1.Visible=(bool)(dr.GetValue(9));
						main.toolBarButton2.Visible=(bool)(dr.GetValue(9));
						main.toolBarButton3.Visible=(bool)(dr.GetValue(9));
						main.toolBarButton4.Visible=(bool)(dr.GetValue(9));
	
						main.statusBarPanel2.Text=name.Text.Trim();
						main.statusBarPanel6.Text="读者";
				
						main.ShowDialog(); 
					}
					else
						MessageBox.Show("用户名或密码错误","警告");			
				} 
				else
					MessageBox.Show("没有选择角色","提示");
				oleConnection1.Close();
			}
		}

		private void btClose_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

        private void Login_Load(object sender, EventArgs e)
        {
            this.AcceptButton = this.btAdd;
        }

       

     
	}
}
