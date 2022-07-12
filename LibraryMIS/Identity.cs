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
	/// Identity ��ժҪ˵����
	/// </summary>
	public class Identity : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btAdd;
		private System.Windows.Forms.Button btClose;
		private System.Windows.Forms.Button btDel;
		private System.Windows.Forms.Button btModify;
		private System.Windows.Forms.DataGrid dataGrid1;
		/// <summary>
		/// ����������������
		/// </summary>
		private System.ComponentModel.Container components = null;
		private SqlConnection oleConnection1 = null;

		public Identity()
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
            this.btAdd = new System.Windows.Forms.Button();
            this.btClose = new System.Windows.Forms.Button();
            this.btDel = new System.Windows.Forms.Button();
            this.btModify = new System.Windows.Forms.Button();
            this.dataGrid1 = new System.Windows.Forms.DataGrid();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(155, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 24);
            this.label1.TabIndex = 32;
            this.label1.Text = "�� �� �� Ϣ";
            // 
            // btAdd
            // 
            this.btAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btAdd.ForeColor = System.Drawing.Color.Black;
            this.btAdd.Location = new System.Drawing.Point(475, 60);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(75, 23);
            this.btAdd.TabIndex = 31;
            this.btAdd.Text = "���";
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btClose
            // 
            this.btClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btClose.ForeColor = System.Drawing.Color.Black;
            this.btClose.Location = new System.Drawing.Point(475, 252);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(75, 23);
            this.btClose.TabIndex = 30;
            this.btClose.Text = "�˳�";
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // btDel
            // 
            this.btDel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btDel.ForeColor = System.Drawing.Color.Black;
            this.btDel.Location = new System.Drawing.Point(475, 188);
            this.btDel.Name = "btDel";
            this.btDel.Size = new System.Drawing.Size(75, 23);
            this.btDel.TabIndex = 29;
            this.btDel.Text = "ɾ��";
            this.btDel.Click += new System.EventHandler(this.btDel_Click);
            // 
            // btModify
            // 
            this.btModify.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btModify.ForeColor = System.Drawing.Color.Black;
            this.btModify.Location = new System.Drawing.Point(475, 124);
            this.btModify.Name = "btModify";
            this.btModify.Size = new System.Drawing.Size(75, 23);
            this.btModify.TabIndex = 28;
            this.btModify.Text = "�޸�";
            this.btModify.Click += new System.EventHandler(this.btModify_Click);
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
            this.dataGrid1.Location = new System.Drawing.Point(11, 44);
            this.dataGrid1.Name = "dataGrid1";
            this.dataGrid1.ParentRowsBackColor = System.Drawing.Color.White;
            this.dataGrid1.ParentRowsForeColor = System.Drawing.Color.Black;
            this.dataGrid1.ReadOnly = true;
            this.dataGrid1.SelectionBackColor = System.Drawing.Color.Navy;
            this.dataGrid1.SelectionForeColor = System.Drawing.Color.White;
            this.dataGrid1.Size = new System.Drawing.Size(448, 246);
            this.dataGrid1.TabIndex = 27;
            // 
            // Identity
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(560, 302);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.btDel);
            this.Controls.Add(this.btModify);
            this.Controls.Add(this.dataGrid1);
            this.Name = "Identity";
            this.Text = "���";
            this.Load += new System.EventHandler(this.Identity_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		DataSet ds;
		private void Identity_Load(object sender, System.EventArgs e)
		{
			oleConnection1.Open();
			string sql = "select identityname as '���',longTime as '�����ʱ��',bigNum as '����������' from identityinfo";
			SqlDataAdapter adp = new SqlDataAdapter(sql,oleConnection1);
			ds = new DataSet();
			ds.Clear();
			adp.Fill(ds,"identity");
			dataGrid1.DataSource = ds.Tables["identity"].DefaultView;
			dataGrid1.CaptionText = "����"+ds.Tables["identity"].Rows.Count+"����¼";
			oleConnection1.Close();
		}

		AddIdentity addIdentity;
		private void btAdd_Click(object sender, System.EventArgs e)
		{
			addIdentity = new AddIdentity();
			addIdentity.ShowDialog();
		}

		private void btModify_Click(object sender, System.EventArgs e)
		{
		
		}

		private void btDel_Click(object sender, System.EventArgs e)
		{
			if (dataGrid1.CurrentRowIndex>=0&&dataGrid1.DataSource!=null&&dataGrid1[dataGrid1.CurrentCell]!=null)
			{
				oleConnection1.Open();
				string sql= "select * from person where identityname='" + ds.Tables["identity"].Rows[dataGrid1.CurrentCell.RowNumber][0].ToString().Trim()+"'";
				SqlCommand cmd = new SqlCommand(sql,oleConnection1);
				
                SqlDataReader dr;
				dr = cmd.ExecuteReader();
				if (dr.Read())
				{
					MessageBox.Show("ɾ�����'"+ds.Tables["identity"].Rows[dataGrid1.CurrentCell.RowNumber][0].ToString().Trim()+"'ʧ�ܣ��и���ݵĶ��ߴ��ڣ�","��ʾ");
					dr.Close();
				} 
				else
				{
					dr.Close();
					sql = "delete * from identityinfo where identityname not in(select distinct identityname from person) and identityname=  " +
						"'"+ds.Tables["identity"].Rows[dataGrid1.CurrentCell.RowNumber][0].ToString().Trim()+"'";
					cmd.CommandText = sql;
					cmd.ExecuteNonQuery();
					MessageBox.Show("ɾ�����'"+ds.Tables[0].Rows[dataGrid1.CurrentCell.RowNumber][0].ToString().Trim()+"'�ɹ�","��ʾ");
				}
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
