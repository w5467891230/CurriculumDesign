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
	/// PersonQuery ��ժҪ˵����
	/// </summary>
	public class PersonQuery : System.Windows.Forms.Form
	{
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.DataGrid dataGrid2;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.DataGrid dataGrid1;
		/// <summary>
		/// ����������������
		/// </summary>
		private System.ComponentModel.Container components = null;
		private System.Windows.Forms.DataGrid dataGrid3;
		private SqlConnection oleConnection1 = null;

		public PersonQuery()
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
            this.dataGrid2 = new System.Windows.Forms.DataGrid();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGrid1 = new System.Windows.Forms.DataGrid();
            this.dataGrid3 = new System.Windows.Forms.DataGrid();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid3)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(8, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(568, 104);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "������Ϣ";
            // 
            // dataGrid2
            // 
            this.dataGrid2.AllowSorting = false;
            this.dataGrid2.AlternatingBackColor = System.Drawing.Color.LightGray;
            this.dataGrid2.BackColor = System.Drawing.Color.DarkGray;
            this.dataGrid2.CaptionBackColor = System.Drawing.Color.White;
            this.dataGrid2.CaptionFont = new System.Drawing.Font("Verdana", 10F);
            this.dataGrid2.CaptionForeColor = System.Drawing.Color.Navy;
            this.dataGrid2.DataMember = "";
            this.dataGrid2.ForeColor = System.Drawing.Color.Black;
            this.dataGrid2.GridLineColor = System.Drawing.Color.Black;
            this.dataGrid2.GridLineStyle = System.Windows.Forms.DataGridLineStyle.None;
            this.dataGrid2.HeaderBackColor = System.Drawing.Color.Silver;
            this.dataGrid2.HeaderForeColor = System.Drawing.Color.Black;
            this.dataGrid2.LinkColor = System.Drawing.Color.Navy;
            this.dataGrid2.Location = new System.Drawing.Point(16, 32);
            this.dataGrid2.Name = "dataGrid2";
            this.dataGrid2.ParentRowsBackColor = System.Drawing.Color.White;
            this.dataGrid2.ParentRowsForeColor = System.Drawing.Color.Black;
            this.dataGrid2.ReadOnly = true;
            this.dataGrid2.SelectionBackColor = System.Drawing.Color.Navy;
            this.dataGrid2.SelectionForeColor = System.Drawing.Color.White;
            this.dataGrid2.Size = new System.Drawing.Size(553, 72);
            this.dataGrid2.TabIndex = 33;
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(8, 120);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(568, 192);
            this.groupBox2.TabIndex = 34;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "������Ϣ";
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
            this.dataGrid1.Location = new System.Drawing.Point(16, 144);
            this.dataGrid1.Name = "dataGrid1";
            this.dataGrid1.ParentRowsBackColor = System.Drawing.Color.White;
            this.dataGrid1.ParentRowsForeColor = System.Drawing.Color.Black;
            this.dataGrid1.ReadOnly = true;
            this.dataGrid1.SelectionBackColor = System.Drawing.Color.Navy;
            this.dataGrid1.SelectionForeColor = System.Drawing.Color.White;
            this.dataGrid1.Size = new System.Drawing.Size(553, 160);
            this.dataGrid1.TabIndex = 35;
            // 
            // dataGrid3
            // 
            this.dataGrid3.AllowSorting = false;
            this.dataGrid3.AlternatingBackColor = System.Drawing.Color.LightGray;
            this.dataGrid3.BackColor = System.Drawing.Color.DarkGray;
            this.dataGrid3.CaptionBackColor = System.Drawing.Color.White;
            this.dataGrid3.CaptionFont = new System.Drawing.Font("Verdana", 10F);
            this.dataGrid3.CaptionForeColor = System.Drawing.Color.Navy;
            this.dataGrid3.DataMember = "";
            this.dataGrid3.ForeColor = System.Drawing.Color.Black;
            this.dataGrid3.GridLineColor = System.Drawing.Color.Black;
            this.dataGrid3.GridLineStyle = System.Windows.Forms.DataGridLineStyle.None;
            this.dataGrid3.HeaderBackColor = System.Drawing.Color.Silver;
            this.dataGrid3.HeaderForeColor = System.Drawing.Color.Black;
            this.dataGrid3.LinkColor = System.Drawing.Color.Navy;
            this.dataGrid3.Location = new System.Drawing.Point(296, 184);
            this.dataGrid3.Name = "dataGrid3";
            this.dataGrid3.ParentRowsBackColor = System.Drawing.Color.White;
            this.dataGrid3.ParentRowsForeColor = System.Drawing.Color.Black;
            this.dataGrid3.ReadOnly = true;
            this.dataGrid3.SelectionBackColor = System.Drawing.Color.Navy;
            this.dataGrid3.SelectionForeColor = System.Drawing.Color.White;
            this.dataGrid3.Size = new System.Drawing.Size(200, 80);
            this.dataGrid3.TabIndex = 36;
            this.dataGrid3.Visible = false;
            // 
            // PersonQuery
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(582, 316);
            this.Controls.Add(this.dataGrid3);
            this.Controls.Add(this.dataGrid1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataGrid2);
            this.Controls.Add(this.groupBox1);
            this.Name = "PersonQuery";
            this.Text = "�����߲�ѯ";
            this.Load += new System.EventHandler(this.PersonQuery_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid3)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		DataSet ds;
		private void PersonQuery_Load(object sender, System.EventArgs e)
		{
			oleConnection1.Open();
			string sql1 = "select PName as ����,PSex as �Ա�,PN as ���֤,PMoney as ����,identityname as ��� "+
				"from person where PName='"+this.Tag.ToString().Trim()+"'";
            string sql3 = "select BID from bookOut where PID = (select PID from person where PName='" + this.Tag.ToString().Trim() + "')";
			SqlDataAdapter adp = new SqlDataAdapter(sql1,oleConnection1);
			SqlDataAdapter adp3 = new SqlDataAdapter(sql3,oleConnection1);
			ds = new DataSet();
			ds.Clear();
			adp.Fill(ds,"person");
			adp3.Fill(ds,"bookid");
			dataGrid2.DataSource = ds.Tables["person"].DefaultView;
			dataGrid2.CaptionText = "����"+ds.Tables["person"].Rows.Count+"����¼";
			dataGrid3.DataSource = ds.Tables["bookid"].DefaultView;
			for (int x=0;x<ds.Tables["bookid"].Rows.Count;x++)
			{
				string sql2="select book.BID as ͼ����,BName as ͼ����,BWriter as ����,BPublish as ������,BDate as ��������,BPrice as �۸�,"+
					"[type] as ����,ODate as ��������,"+
                    "dateAdd(m,(select longTime from identityinfo where identityname=(select identityname from person where PID='" + this.Tag.ToString().Trim() + "')),ODate) as Ӧ������ from book,bookOut where book.BID = bookOut.BID and book.BID = '" + ds.Tables["bookid"].Rows[x][0] + "'" +
                    " and PID=(select PID from person where PName='" + this.Tag.ToString().Trim() + "')";
				SqlDataAdapter adp2 = new SqlDataAdapter(sql2,oleConnection1);
				adp2.Fill(ds,"bookout");
				dataGrid1.DataSource = ds.Tables["bookout"].DefaultView;
				dataGrid1.CaptionText = "�ѽ�ͼ��"+ds.Tables["bookout"].Rows.Count+"��";
			}
			oleConnection1.Close();
		}

	}
}
