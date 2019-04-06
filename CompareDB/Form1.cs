using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CompareDB
{
    public partial class frmNewComparision : Form
    {
        private static readonly int LEFT = 0;
        private static readonly int RIGHT = 1;
        private string m_ServerName;
        private KetNoi m_KetNoi = new KetNoi();


        private string connectionStringLeft;

        public string ConnectionStringLeft
        {
            get { return connectionStringLeft; }
            set { connectionStringLeft = value; }
        }
        private string connectionStringRight;

        public string ConnectionStringRight
        {
            get { return connectionStringRight; }
            set { connectionStringRight = value; }
        }




        public frmNewComparision()
        {
            InitializeComponent();
            m_ServerName = SystemInformation.ComputerName;
        }
        #region Data Server Name

        // Create Data For Server Name
        public DataTable CreateDataForServerName()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Value", typeof(string));
            dt.Columns.Add("Display", typeof(string));

            DataRow dr = dt.NewRow();
            //dr["Value"] = "(local)";
            dr["Display"] = "(local)";

            dt.Rows.Add(dr);
            DataRow dr1 = dt.NewRow();
            dr1["Display"] = "";
            dt.Rows.InsertAt(dr1, 0);

            return dt;
        }
        //Server Name Left
        public void LoadServerNameLeft()
        {
            DataTable dt = CreateDataForServerName();
            cbbServerNameLeft.DataSource = dt;
            cbbServerNameLeft.DisplayMember = "Display";
            cbbServerNameLeft.ValueMember = "Display";
        }

        //Server Name Right
        public void LoadServerNameRight()
        {
            DataTable dt = CreateDataForServerName();

            cbbServerNameRight.DataSource = dt;
            cbbServerNameRight.DisplayMember = "Display";
            cbbServerNameRight.ValueMember = "Display";
        }

        #endregion

        #region Data Authentication
        //Create Data For Authentication

        public DataTable CreateDataForAuthentication()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Display", typeof(string));
            DataRow dr = dt.NewRow();
            dr["Display"] = "Windows Authentication";
            dt.Rows.Add(dr);
            DataRow dr1 = dt.NewRow();
            dr1["Display"] = "SQL Sever Authentication";
            dt.Rows.Add(dr1);
            return dt;
        }
        // Authentication Left
        public void LoadAuthenticationLeft()
        {
            cbbAuthenticationLeft.DataSource = CreateDataForAuthentication();
            cbbAuthenticationLeft.DisplayMember = "Display";
            cbbAuthenticationLeft.ValueMember = "Display";
        }

        // Authentication Right
        public void LoadAuthenticationRight()
        {
            cbbAuthenticationRight.DataSource = CreateDataForAuthentication();
            cbbAuthenticationRight.DisplayMember = "Display";
            cbbAuthenticationRight.ValueMember = "Display";
        }

        private void cbbAuthenticationLeft_TextChanged(object sender, EventArgs e)
        {
            if (cbbAuthenticationLeft.Text == "Windows Authentication")
            {
                txtLoginLeft.Enabled = false;
                txtPasswordLeft.Enabled = false;
                txtLoginLeft.Text = m_ServerName + "\\" + m_ServerName + "-PC";
            }
            else
            {
                txtLoginLeft.Enabled = true;
                txtPasswordLeft.Enabled = true;
                txtLoginLeft.ResetText();
                txtPasswordLeft.ResetText();

            }
        }

        private void cbbAuthenticationRight_TextChanged(object sender, EventArgs e)
        {
            if (cbbAuthenticationRight.Text == "Windows Authentication")
            {
                txtLoginRight.Enabled = false;
                txtPasswordRight.Enabled = false;
                txtLoginRight.Text = m_ServerName + "\\" + m_ServerName + "-PC";
            }
            else
            {
                txtLoginRight.Enabled = true;
                txtPasswordRight.Enabled = true;
                txtLoginRight.ResetText();
                txtPasswordRight.ResetText();

            }
        }

        #endregion

        #region Check Connection
        // Check connect DB Left
        public bool CheckLeftDBConnect()
        {
            bool bCheck = false;
            // windows
            if (cbbAuthenticationLeft.Text == "Windows Authentication")
            {
                bCheck = true;
            }
            //sql server
            else
            {
                string sChuoiKn = "Data Source=" + cbbServerNameLeft.Text.ToString() + ";" 
                                  + "User Id=" + txtLoginLeft.Text.ToString() 
                                  + ";" + "Password=" + txtPasswordLeft.Text.ToString() + ";";

                m_KetNoi.KiemTraKetNoi(sChuoiKn);
                if (m_KetNoi.KiemTraKetNoi(sChuoiKn) == true)
                {
                    bCheck = true;
                }
                else
                {
                    MessageBox.Show("Connect Failed!", "Error!");
                    cbbDatabaseNameLeft.Items.Clear();
                }
            }

            return bCheck;
        }
        // Check connect DB Right
        public bool CheckRightDBConnect()
        {
            bool bCheck = false;
            // windows
            if (cbbAuthenticationRight.Text == "Windows Authentication")
            {
                bCheck = true;
            }
            //sql server
            else
            {
                string sChuoiKn = "Data Source=" + cbbServerNameRight.Text.ToString() + ";" 
                                  + "User Id=" + txtLoginRight.Text.ToString() 
                                  + ";" + "Password=" + txtPasswordRight.Text.ToString() + ";";

                m_KetNoi.KiemTraKetNoi(sChuoiKn);
                if (m_KetNoi.KiemTraKetNoi(sChuoiKn) == true)
                {
                    bCheck = true;
                }
                else
                {
                    MessageBox.Show("Connect Failed!", "Error!");
                    cbbDatabaseNameRight.Items.Clear();
                }
            }

            return bCheck;
        }
        #endregion


     

        private void cbbDatabaseNameLeft_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(cbbServerNameLeft.Text))
                {
                    MessageBox.Show("Please, Import Sever Name...", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cbbServerNameLeft.Focus();
                    return;
                }
                string server = cbbServerNameLeft.Text.Trim();
                cbbDatabaseNameLeft.Items.Clear();

                if (CheckLeftDBConnect())
                {
                    using (SqlConnection con = new SqlConnection("Data Source=" + server + "; Integrated Security=True;"))
                    {
                        try
                        {
                            con.Open();
                        }
                        catch
                        {
                        }
                        DataTable databases = con.GetSchema("Databases");
                        if (databases != null)
                        {
                            foreach (DataRow dr in databases.Rows)
                            {
                                String databaseName = dr["database_name"].ToString();
                                short dbID = (short)dr["dbid"];

                                cbbDatabaseNameLeft.Items.Add(databaseName);
                            }
                        }
                    }
                    //==========

                    if (cbbDatabaseNameLeft.Items.Count > 0)
                    {
                        cbbDatabaseNameLeft.SelectedIndex = 0;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Not getting a list of databases.\nPlease check Server Name!!!", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbbServerNameLeft.Focus();
            }
        }



        private void cbbDataBaseNameRight_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(cbbServerNameRight.Text))
                {
                    MessageBox.Show("Please, Import Sever Name...", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cbbServerNameRight.Focus();
                    return;
                }
                string server = cbbServerNameRight.Text.Trim();
                cbbDatabaseNameRight.Items.Clear();

                if (CheckRightDBConnect())
                {
                    using (SqlConnection con = new SqlConnection("Data Source=" + server + "; Integrated Security=True;"))
                    {
                        try
                        {
                            con.Open();
                        }
                        catch
                        {
                        }
                        DataTable databases = con.GetSchema("Databases");
                        if (databases != null)
                        {
                            foreach (DataRow dr in databases.Rows)
                            {
                                String databaseName = dr["database_name"].ToString();
                                short dbID = (short)dr["dbid"];

                                cbbDatabaseNameRight.Items.Add(databaseName);
                            }
                        }
                    }
                    //==========

                    if (cbbDatabaseNameRight.Items.Count > 0)
                    {
                        cbbDatabaseNameRight.SelectedIndex = 0;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Not getting a list of databases.\nPlease check Server Name!!!", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbbServerNameRight.Focus();
            }
        }

        #region Main
        private void frmMain_Load(object sender, EventArgs e)
        {
            try
            {
                //Server Name
                LoadServerNameLeft();
                LoadServerNameRight();
                //Authentication
                LoadAuthenticationLeft();
                LoadAuthenticationRight();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Event Button
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCompare_Click(object sender, EventArgs e)
        {
            // check size
            // check records
            // 
            GetConnectionString(LEFT);
            GetConnectionString(RIGHT);

        }
        #endregion

        public string GetConnectionString(int iLeftRight)
        {
            if (iLeftRight == LEFT)
            {
                if (cbbAuthenticationLeft.Text == "Windows Authentication")
                {
                    return connectionStringLeft = "Data Source=" + cbbServerNameLeft.Text + "; Integrated Security=True;"
                                               // + "User Id=" + txtLoginLeft.Text.ToString()
                                                //+ ";" + "Password=" + txtPasswordLeft.Text.ToString() + ";"
                                                + " Initial Catalog=" + cbbDatabaseNameLeft.Text + ";";
                }
                else
                {
                    return connectionStringLeft = "Data Source=" + cbbServerNameLeft.Text + "; Integrated Security=True;"
                                                                   + "User Id=" + txtLoginLeft.Text.ToString()
                                                                   + ";" + "Password=" + txtPasswordLeft.Text.ToString() + ";"
                                                                   + " Initial Catalog=" + cbbDatabaseNameLeft.Text + ";";
                }
            }
            else
            {
                if (cbbAuthenticationRight.Text == "Windows Authentication")
                {
                    return connectionStringRight = "Data Source=" + cbbServerNameRight.Text + "; Integrated Security=True;"
                        // + "User Id=" + txtLoginLeft.Text.ToString()
                        //+ ";" + "Password=" + txtPasswordLeft.Text.ToString() + ";"
                                                + " Initial Catalog=" + cbbDatabaseNameRight.Text + ";";
                }
                else
                {
                    return connectionStringRight = "Data Source=" + cbbServerNameRight.Text + "; Integrated Security=True;"
                                                                   + "User Id=" + txtLoginRight.Text.ToString()
                                                                   + ";" + "Password=" + txtPasswordRight.Text.ToString() + ";"
                                                                   + " Initial Catalog=" + cbbDatabaseNameRight.Text + ";";
                }
            }
        }
    }
}