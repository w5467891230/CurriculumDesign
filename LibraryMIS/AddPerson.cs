using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using BLL;

namespace LibraryMIS
{
	/// <summary>
	/// AddPerson 的摘要说明。
	/// </summary>
	public class AddPerson : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button btAdd;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textName;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textID;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btClose;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textRemark;
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.Container components = null;
		private System.Windows.Forms.TextBox textPN;
		private System.Windows.Forms.ComboBox comboSex;
		private System.Windows.Forms.ComboBox comboId;
		private System.Windows.Forms.TextBox textMoney;
		private System.Windows.Forms.TextBox textCode;
		private System.Windows.Forms.TextBox textPhone;
		private SqlConnection oleConnection1 = null;

		public AddPerson()
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
            this.btAdd = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textPN = new System.Windows.Forms.TextBox();
            this.comboSex = new System.Windows.Forms.ComboBox();
            this.comboId = new System.Windows.Forms.ComboBox();
            this.textMoney = new System.Windows.Forms.TextBox();
            this.textCode = new System.Windows.Forms.TextBox();
            this.textPhone = new System.Windows.Forms.TextBox();
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
            this.btClose = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btAdd
            // 
            this.btAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btAdd.ForeColor = System.Drawing.Color.Black;
            this.btAdd.Location = new System.Drawing.Point(187, 360);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(125, 34);
            this.btAdd.TabIndex = 13;
            this.btAdd.Text = "确定";
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textPN);
            this.groupBox1.Controls.Add(this.comboSex);
            this.groupBox1.Controls.Add(this.comboId);
            this.groupBox1.Controls.Add(this.textMoney);
            this.groupBox1.Controls.Add(this.textCode);
            this.groupBox1.Controls.Add(this.textPhone);
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
            this.groupBox1.Location = new System.Drawing.Point(13, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(827, 324);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "添加借阅者";
            // 
            // textPN
            // 
            this.textPN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textPN.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textPN.Location = new System.Drawing.Point(120, 120);
            this.textPN.Name = "textPN";
            this.textPN.Size = new System.Drawing.Size(167, 28);
            this.textPN.TabIndex = 4;
            // 
            // comboSex
            // 
            this.comboSex.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboSex.Items.AddRange(new object[] {
            "男",
            "女"});
            this.comboSex.Location = new System.Drawing.Point(640, 60);
            this.comboSex.Name = "comboSex";
            this.comboSex.Size = new System.Drawing.Size(167, 26);
            this.comboSex.TabIndex = 3;
            // 
            // comboId
            // 
            this.comboId.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboId.Items.AddRange(new object[] {
            "大学生",
            "教授"});
            this.comboId.Location = new System.Drawing.Point(640, 120);
            this.comboId.Name = "comboId";
            this.comboId.Size = new System.Drawing.Size(167, 26);
            this.comboId.TabIndex = 6;
            // 
            // textMoney
            // 
            this.textMoney.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textMoney.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textMoney.Location = new System.Drawing.Point(387, 180);
            this.textMoney.Name = "textMoney";
            this.textMoney.Size = new System.Drawing.Size(166, 28);
            this.textMoney.TabIndex = 8;
            // 
            // textCode
            // 
            this.textCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textCode.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textCode.Location = new System.Drawing.Point(120, 180);
            this.textCode.Name = "textCode";
            this.textCode.Size = new System.Drawing.Size(167, 28);
            this.textCode.TabIndex = 7;
            // 
            // textPhone
            // 
            this.textPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textPhone.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textPhone.Location = new System.Drawing.Point(387, 120);
            this.textPhone.Name = "textPhone";
            this.textPhone.Size = new System.Drawing.Size(166, 28);
            this.textPhone.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(587, 120);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 24);
            this.label9.TabIndex = 10;
            this.label9.Text = "身份";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(27, 180);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 24);
            this.label8.TabIndex = 9;
            this.label8.Text = "密  码";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(320, 180);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 24);
            this.label7.TabIndex = 8;
            this.label7.Text = "罚款";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(320, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 24);
            this.label6.TabIndex = 7;
            this.label6.Text = "电话";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(27, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 24);
            this.label5.TabIndex = 6;
            this.label5.Text = "身份证号";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(587, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "性别";
            // 
            // textName
            // 
            this.textName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textName.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textName.Location = new System.Drawing.Point(387, 60);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(166, 28);
            this.textName.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(320, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "姓名";
            // 
            // textRemark
            // 
            this.textRemark.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textRemark.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textRemark.Location = new System.Drawing.Point(120, 240);
            this.textRemark.Multiline = true;
            this.textRemark.Name = "textRemark";
            this.textRemark.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textRemark.Size = new System.Drawing.Size(680, 72);
            this.textRemark.TabIndex = 9;
            // 
            // textID
            // 
            this.textID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textID.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textID.Location = new System.Drawing.Point(120, 60);
            this.textID.Name = "textID";
            this.textID.Size = new System.Drawing.Size(167, 28);
            this.textID.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Snow;
            this.label2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(27, 252);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "备   注";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(27, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "借书证号";
            // 
            // btClose
            // 
            this.btClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btClose.ForeColor = System.Drawing.Color.Black;
            this.btClose.Location = new System.Drawing.Point(547, 360);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(125, 34);
            this.btClose.TabIndex = 14;
            this.btClose.Text = "取消";
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // AddPerson
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(10, 21);
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(1065, 523);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btClose);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddPerson";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "添加借阅者";
            this.Load += new System.EventHandler(this.AddPerson_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

		}
		#endregion

		private void AddPerson_Load(object sender, System.EventArgs e)
		{
			//try
			//{
			//	oleConnection1.Open();
			//	string sql="select identity from identityinfo";
			//	SqlDataAdapter adp=new SqlDataAdapter(sql,oleConnection1);

			//	DataSet ds=new DataSet();
			//	adp.Fill(ds,"identi");
			//	comboId.DataSource=ds.Tables["identi"].DefaultView;
			//	comboId.DisplayMember="identity";
			//	comboId.ValueMember="identity";
			//	oleConnection1.Close();
			//}
			//catch (Exception ee)
			//{
			//	Console.WriteLine(ee.Message);
			//}
		}

		private void btAdd_Click(object sender, System.EventArgs e)
		{
            Model.person person = new Model.person();
            person.PID = textID.Text.Trim();
            person.PName = textName.Text.Trim();
            person.PSex = comboSex.Text.Trim();
            person.PPhone = textPhone.Text.Trim();
            person.PN = textPN.Text.Trim();
            person.PCode = textCode.Text.Trim();
            person.PMoney = textMoney.Text.Trim();
            person.identityname = comboId.Text.Trim();
            person.PRemark = textRemark.Text.Trim();

            BLL.PersonBLL personBLL = new BLL.PersonBLL();
            string result = personBLL.addPerson(person);
            if (result == "OK")
            {
                MessageBox.Show("添加成功", "提示");
            }
            else
            {
                MessageBox.Show(result, "提示");
            }
            this.Close();

            
        }

        private void clear()
        {
            textID.Text = "";
            textName.Text = "";
            comboSex.Text = "";
            textPN.Text = "";
            textCode.Text = "";
            textRemark.Text = "";
            textMoney.Text = "";
            textPhone.Text = "";
        }

        private void btClose_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}
	}
}
