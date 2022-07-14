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
	/// Person ��ժҪ˵����
	/// </summary>
	public class Person : System.Windows.Forms.Form
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

		public Person()
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
            this.label1.Location = new System.Drawing.Point(258, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 36);
            this.label1.TabIndex = 26;
            this.label1.Text = "�� �� �� �� Ϣ";
            // 
            // btAdd
            // 
            this.btAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btAdd.ForeColor = System.Drawing.Color.Black;
            this.btAdd.Location = new System.Drawing.Point(792, 90);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(125, 34);
            this.btAdd.TabIndex = 25;
            this.btAdd.Text = "���";
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btClose
            // 
            this.btClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btClose.ForeColor = System.Drawing.Color.Black;
            this.btClose.Location = new System.Drawing.Point(792, 378);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(125, 34);
            this.btClose.TabIndex = 24;
            this.btClose.Text = "�˳�";
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // btDel
            // 
            this.btDel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btDel.ForeColor = System.Drawing.Color.Black;
            this.btDel.Location = new System.Drawing.Point(792, 282);
            this.btDel.Name = "btDel";
            this.btDel.Size = new System.Drawing.Size(125, 34);
            this.btDel.TabIndex = 23;
            this.btDel.Text = "ɾ��";
            this.btDel.Click += new System.EventHandler(this.btDel_Click);
            // 
            // btModify
            // 
            this.btModify.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btModify.ForeColor = System.Drawing.Color.Black;
            this.btModify.Location = new System.Drawing.Point(792, 186);
            this.btModify.Name = "btModify";
            this.btModify.Size = new System.Drawing.Size(125, 34);
            this.btModify.TabIndex = 22;
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
            this.dataGrid1.Location = new System.Drawing.Point(18, 66);
            this.dataGrid1.Name = "dataGrid1";
            this.dataGrid1.ParentRowsBackColor = System.Drawing.Color.White;
            this.dataGrid1.ParentRowsForeColor = System.Drawing.Color.Black;
            this.dataGrid1.ReadOnly = true;
            this.dataGrid1.SelectionBackColor = System.Drawing.Color.Navy;
            this.dataGrid1.SelectionForeColor = System.Drawing.Color.White;
            this.dataGrid1.Size = new System.Drawing.Size(747, 369);
            this.dataGrid1.TabIndex = 21;
            this.dataGrid1.Navigate += new System.Windows.Forms.NavigateEventHandler(this.dataGrid1_Navigate);
            // 
            // Person
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(10, 21);
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(1058, 576);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.btDel);
            this.Controls.Add(this.btModify);
            this.Controls.Add(this.dataGrid1);
            this.Name = "Person";
            this.Text = "��������Ϣ";
            this.Load += new System.EventHandler(this.Person_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
            this.ResumeLayout(false);

		}
        #endregion

        DataSet ds;
        private void Person_Load(object sender, System.EventArgs e)
		{

            oleConnection1.Open();
            string sql = "select PID as ����֤���,PName as ����,PSex as �Ա�,PPhone as �绰,PN as ���֤,PCode as ����," +
                "PMoney as ����,identityname as ���,PRemark as ��ע from person";
            SqlDataAdapter adp = new SqlDataAdapter(sql, oleConnection1);
            ds = new DataSet();
            ds.Clear();
            adp.Fill(ds, "person");
            dataGrid1.DataSource = ds.Tables["person"].DefaultView;
            dataGrid1.CaptionText = "����" + ds.Tables["person"].Rows.Count + "����¼";
            oleConnection1.Close();


        }

		AddPerson addPerson;
		private void btAdd_Click(object sender, System.EventArgs e)
		{
			addPerson = new AddPerson();
			addPerson.ShowDialog();
		}

		ModifyPerson modifyPerson;
		private void btModify_Click(object sender, System.EventArgs e)
		{
			if (dataGrid1.DataSource!=null || dataGrid1[dataGrid1.CurrentCell]!=null)
			{
				modifyPerson = new ModifyPerson();
				modifyPerson.textID.Text = ds.Tables["person"].Rows[dataGrid1.CurrentCell.RowNumber][0].ToString().Trim();
				modifyPerson.textName.Text = ds.Tables["person"].Rows[dataGrid1.CurrentCell.RowNumber][1].ToString().Trim();
				modifyPerson.comboSex.Text = ds.Tables["person"].Rows[dataGrid1.CurrentCell.RowNumber][2].ToString().Trim();
				modifyPerson.textPhone.Text = ds.Tables["person"].Rows[dataGrid1.CurrentCell.RowNumber][3].ToString().Trim();
				modifyPerson.textPN.Text = ds.Tables["person"].Rows[dataGrid1.CurrentCell.RowNumber][4].ToString().Trim();
				modifyPerson.textCode.Text = ds.Tables["person"].Rows[dataGrid1.CurrentCell.RowNumber][5].ToString().Trim();
				modifyPerson.textMoney.Text = ds.Tables["person"].Rows[dataGrid1.CurrentCell.RowNumber][6].ToString().Trim();
				modifyPerson.textiden.Text = ds.Tables["person"].Rows[dataGrid1.CurrentCell.RowNumber][7].ToString().Trim();
				modifyPerson.textRemark.Text = ds.Tables["person"].Rows[dataGrid1.CurrentCell.RowNumber][8].ToString().Trim();
				modifyPerson.Show();
			} 
			else
				MessageBox.Show("û��ָ����Ϣ��","��ʾ");
		}
        
		private void btDel_Click(object sender, System.EventArgs e)
		{
            Model.person person = new Model.person();
            person.PsRow = dataGrid1.CurrentRowIndex;
            person.PsData = dataGrid1.DataSource;
            person.PsCurrent = dataGrid1[dataGrid1.CurrentCell];
            person.PsXx = ds.Tables[0].Rows[dataGrid1.CurrentCell.RowNumber][0].ToString().Trim();

            BLL.PersonBLL personBLL = new BLL.PersonBLL();
            string result = personBLL.DelPersonMothed(person);
            if (result == "ɾ���ɹ�")
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

        private void dataGrid1_Navigate(object sender, NavigateEventArgs ne)
        {

        }
    }
}
