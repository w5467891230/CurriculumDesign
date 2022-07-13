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
	/// User ��ժҪ˵����
	/// </summary>
	public class User : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGrid dataGrid1;
		private System.Windows.Forms.Button btClose;
		private System.Windows.Forms.Button btDel;
		private System.Windows.Forms.Button btModify;
		/// <summary>
		/// ����������������
		/// </summary>
		private System.ComponentModel.Container components = null;
		private SqlConnection oleConnection1 = null;

		public User()
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGrid1 = new System.Windows.Forms.DataGrid();
            this.btClose = new System.Windows.Forms.Button();
            this.btDel = new System.Windows.Forms.Button();
            this.btModify = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(203, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 31);
            this.label1.TabIndex = 22;
            this.label1.Text = "�� �� �� ��";
            // 
            // dataGrid1
            // 
            this.dataGrid1.AllowSorting = false;
            this.dataGrid1.AlternatingBackColor = System.Drawing.Color.LightGray;
            this.dataGrid1.BackColor = System.Drawing.Color.DarkGray;
            this.dataGrid1.CaptionBackColor = System.Drawing.Color.White;
            this.dataGrid1.CaptionFont = new System.Drawing.Font("Verdana", 10F);
            this.dataGrid1.CaptionForeColor = System.Drawing.Color.Navy;
            this.dataGrid1.DataMember = "";
            this.dataGrid1.ForeColor = System.Drawing.Color.Black;
            this.dataGrid1.GridLineColor = System.Drawing.Color.Black;
            this.dataGrid1.GridLineStyle = System.Windows.Forms.DataGridLineStyle.None;
            this.dataGrid1.HeaderBackColor = System.Drawing.Color.Silver;
            this.dataGrid1.HeaderForeColor = System.Drawing.Color.Black;
            this.dataGrid1.LinkColor = System.Drawing.Color.Navy;
            this.dataGrid1.Location = new System.Drawing.Point(11, 57);
            this.dataGrid1.Name = "dataGrid1";
            this.dataGrid1.ParentRowsBackColor = System.Drawing.Color.White;
            this.dataGrid1.ParentRowsForeColor = System.Drawing.Color.Black;
            this.dataGrid1.ReadOnly = true;
            this.dataGrid1.SelectionBackColor = System.Drawing.Color.Navy;
            this.dataGrid1.SelectionForeColor = System.Drawing.Color.White;
            this.dataGrid1.Size = new System.Drawing.Size(597, 316);
            this.dataGrid1.TabIndex = 21;
            // 
            // btClose
            // 
            this.btClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btClose.ForeColor = System.Drawing.Color.Black;
            this.btClose.Location = new System.Drawing.Point(629, 267);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(100, 30);
            this.btClose.TabIndex = 25;
            this.btClose.Text = "�˳�";
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // btDel
            // 
            this.btDel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btDel.ForeColor = System.Drawing.Color.Black;
            this.btDel.Location = new System.Drawing.Point(629, 185);
            this.btDel.Name = "btDel";
            this.btDel.Size = new System.Drawing.Size(100, 30);
            this.btDel.TabIndex = 24;
            this.btDel.Text = "ɾ��";
            this.btDel.Click += new System.EventHandler(this.btDel_Click);
            // 
            // btModify
            // 
            this.btModify.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btModify.ForeColor = System.Drawing.Color.Black;
            this.btModify.Location = new System.Drawing.Point(629, 103);
            this.btModify.Name = "btModify";
            this.btModify.Size = new System.Drawing.Size(100, 29);
            this.btModify.TabIndex = 23;
            this.btModify.Text = "�޸�";
            this.btModify.Click += new System.EventHandler(this.btModify_Click);
            // 
            // User
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(8, 18);
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(753, 444);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.btDel);
            this.Controls.Add(this.btModify);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGrid1);
            this.Name = "User";
            this.Text = "�û��б�";
            this.Load += new System.EventHandler(this.User_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		DataSet ds;
		private void User_Load(object sender, System.EventArgs e)
		{
			oleConnection1.Open();
			string sql = "select MName as �û���,MCode as ����,manage as Ȩ��1,work as Ȩ��2,query as Ȩ��3 from manager";
			SqlDataAdapter adp = new SqlDataAdapter(sql,oleConnection1);
			ds = new DataSet();
			ds.Clear();
			adp.Fill(ds,"user");
			dataGrid1.DataSource = ds.Tables["user"].DefaultView;
			dataGrid1.CaptionText = "����"+ds.Tables["user"].Rows.Count+"����¼";
			oleConnection1.Close();
		}

		ModifyUser modifyUser;
		private void btModify_Click(object sender, System.EventArgs e)
		{
			if (dataGrid1.CurrentRowIndex>=0&&dataGrid1.DataSource!=null&&dataGrid1[dataGrid1.CurrentCell]!=null)
			{
				modifyUser = new ModifyUser();
				modifyUser.textName.Text = ds.Tables[0].Rows[dataGrid1.CurrentCell.RowNumber][0].ToString().Trim();
				modifyUser.ShowDialog();
			}
		}

		private void btDel_Click(object sender, System.EventArgs e)
		{
			if (dataGrid1.CurrentRowIndex>=0&&dataGrid1.DataSource!=null&&dataGrid1[dataGrid1.CurrentCell]!=null)
			{
				oleConnection1.Open();
				string sql="delete * from manager where MName = '"+ds.Tables["user"].Rows[dataGrid1.CurrentCell.RowNumber][0].ToString().Trim()+"'";
				SqlCommand cmd = new SqlCommand(sql,oleConnection1);
				cmd.ExecuteNonQuery();
				MessageBox.Show("ɾ���û�'"+ds.Tables[0].Rows[dataGrid1.CurrentCell.RowNumber][0].ToString().Trim()+"'�ɹ�","��ʾ");
				
				oleConnection1.Close();
			} 
			else
				return;
		}

		private void btClose_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}
	}
}
