using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LibraryMIS
{
    /// <summary>
    /// ModifyCode ��ժҪ˵����
    /// </summary>
    public class ModifyCode : System.Windows.Forms.Form
    {
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textPWDNew;
        private System.Windows.Forms.TextBox textPWDNew2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textPWD;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Button btSave;
        /// <summary>
        /// ����������������
        /// </summary>
        private System.ComponentModel.Container components = null;
        public System.Windows.Forms.Label label5;
        private SqlConnection oleConnection1 = null;

        public ModifyCode()
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
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        #region Windows ������������ɵĴ���
        /// <summary>
        /// �����֧������ķ��� - ��Ҫʹ�ô���༭���޸�
        /// �˷��������ݡ�
        /// </summary>
        private void InitializeComponent()
        {
            this.label4 = new System.Windows.Forms.Label();
            this.textPWDNew = new System.Windows.Forms.TextBox();
            this.textPWDNew2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textPWD = new System.Windows.Forms.TextBox();
            this.textName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btClose = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("����", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(23, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 17);
            this.label4.TabIndex = 53;
            this.label4.Text = "�� �� ��";
            // 
            // textPWDNew
            // 
            this.textPWDNew.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textPWDNew.Font = new System.Drawing.Font("����", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
            this.textPWDNew.ForeColor = System.Drawing.SystemColors.ControlText;
            this.textPWDNew.Location = new System.Drawing.Point(87, 80);
            this.textPWDNew.Name = "textPWDNew";
            this.textPWDNew.PasswordChar = '*';
            this.textPWDNew.Size = new System.Drawing.Size(120, 21);
            this.textPWDNew.TabIndex = 46;
            this.textPWDNew.Text = "";
            // 
            // textPWDNew2
            // 
            this.textPWDNew2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textPWDNew2.Font = new System.Drawing.Font("����", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
            this.textPWDNew2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.textPWDNew2.Location = new System.Drawing.Point(87, 112);
            this.textPWDNew2.Name = "textPWDNew2";
            this.textPWDNew2.PasswordChar = '*';
            this.textPWDNew2.Size = new System.Drawing.Size(120, 21);
            this.textPWDNew2.TabIndex = 47;
            this.textPWDNew2.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("����", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(23, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 52;
            this.label3.Text = "����ȷ��";
            // 
            // textPWD
            // 
            this.textPWD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textPWD.Font = new System.Drawing.Font("����", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
            this.textPWD.ForeColor = System.Drawing.SystemColors.ControlText;
            this.textPWD.Location = new System.Drawing.Point(87, 48);
            this.textPWD.Name = "textPWD";
            this.textPWD.PasswordChar = '*';
            this.textPWD.Size = new System.Drawing.Size(120, 21);
            this.textPWD.TabIndex = 45;
            this.textPWD.Text = "";
            // 
            // textName
            // 
            this.textName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textName.Font = new System.Drawing.Font("����", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
            this.textName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.textName.Location = new System.Drawing.Point(87, 16);
            this.textName.Name = "textName";
            this.textName.ReadOnly = true;
            this.textName.Size = new System.Drawing.Size(120, 21);
            this.textName.TabIndex = 44;
            this.textName.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("����", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(23, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 17);
            this.label2.TabIndex = 51;
            this.label2.Text = "��    ��";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("����", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(23, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 50;
            this.label1.Text = "�û�����";
            // 
            // btClose
            // 
            this.btClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btClose.Font = new System.Drawing.Font("����", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
            this.btClose.ForeColor = System.Drawing.Color.Black;
            this.btClose.Location = new System.Drawing.Point(135, 152);
            this.btClose.Name = "btClose";
            this.btClose.TabIndex = 49;
            this.btClose.Text = "�˳�";
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // btSave
            // 
            this.btSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btSave.ForeColor = System.Drawing.Color.Black;
            this.btSave.Location = new System.Drawing.Point(31, 152);
            this.btSave.Name = "btSave";
            this.btSave.TabIndex = 48;
            this.btSave.Text = "ȷ��";
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(8, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 48);
            this.label5.TabIndex = 54;
            this.label5.Text = "label5";
            this.label5.Visible = false;
            // 
            // ModifyCode
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(232, 190);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textPWDNew);
            this.Controls.Add(this.textPWDNew2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textPWD);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.btSave);
            this.Name = "ModifyCode";
            this.Text = "�޸�����";
            this.Load += new System.EventHandler(this.ModifyCode_Load);
            this.ResumeLayout(false);

        }
        #endregion

        private void btSave_Click(object sender, System.EventArgs e)
        {
            if (textName.Text.Trim() == "" || textPWD.Text.Trim() == "" || textPWDNew.Text.Trim() == "" || textPWDNew2.Text.Trim() == "")
                MessageBox.Show("����д������Ϣ��", "��ʾ");
            else
            {
                oleConnection1.Open();
                SqlCommand cmd = new SqlCommand("", oleConnection1);
                string sql1 = "select * from person where PID='" + textName.Text.Trim() + "' and PCode='" + textPWD.Text.Trim() + "'";
                string sql2 = "select * from manager where MName='" + textName.Text.Trim() + "' and MCode='" + textPWD.Text.Trim() + "'";
                if (label5.Text == "����Ա")
                    cmd.CommandText = sql2;
                else
                    cmd.CommandText = sql1;

                if (null != cmd.ExecuteScalar())
                {
                    if (textPWDNew.Text.Trim() != textPWDNew2.Text.Trim())
                        MessageBox.Show("�����������벻һ�£�", "����");
                    else
                    {
                        sql1 = "update person set PCode='" + textPWDNew.Text.Trim() + "' where PID='" + textName.Text.Trim() + "'";
                        sql2 = "update manager set MCode='" + textPWDNew.Text.Trim() + "' where MName='" + textName.Text.Trim() + "'";
                        if (label5.Text == "����Ա")
                            cmd.CommandText = sql2;
                        else
                            cmd.CommandText = sql1;
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("�����޸ĳɹ���", "��ʾ");
                        this.Close();
                    }
                }
                else
                    MessageBox.Show("�������", "��ʾ");
                oleConnection1.Close();
            }
        }

        private void btClose_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void ModifyCode_Load(object sender, System.EventArgs e)
        {
            this.textName.Text = this.Tag.ToString().Trim();
        }
    }
}
