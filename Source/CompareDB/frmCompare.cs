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
    public partial class frmCompareDB : Form
    {
        private string m_ConnectionStringLeft;
        private string m_ConnectionStringRight;
        private bool bClick;
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
        int countdb1, countdb2;
        //private DataTable m_DBSame;
        public frmCompareDB()
        {
            InitializeComponent();
        }

        private void frmCompareDB_Load(object sender, EventArgs e)
        {
            Compare();
            grdLeftProperties.ClearSelection();
            grdRightProperties.ClearSelection();
            grdSame.ClearSelection();
            grdDatabaseLeft.ClearSelection();
            grdDatabaseRight.ClearSelection();
            CheckData();
        }

        private void btnCopyScriptLeft_Click(object sender, EventArgs e)
        {
            if (txtScriptDBLeft.Text != "")
            {
                txtScriptDBLeft.SelectAll();
                Clipboard.SetText(txtScriptDBLeft.Text);


                // Ensure that text is selected in the text box.    
                if (txtScriptDBLeft.SelectionLength > 0)
                {// Copy the selected text to the Clipboard.
                    txtScriptDBLeft.Copy();
                    MessageBox.Show("The Scrip was copied to Clipboard!!", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnCopyScriptRight_Click(object sender, EventArgs e)
        {
            if (txtScriptDBRight.Text != "")
            {
                txtScriptDBRight.SelectAll();
                Clipboard.SetText(txtScriptDBRight.Text);


                // Ensure that text is selected in the text box.    
                if (txtScriptDBRight.SelectionLength > 0)
                {// Copy the selected text to the Clipboard.
                    txtScriptDBRight.Copy();
                    MessageBox.Show("The Scrip was copied to Clipboard!!", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        #region Check Data
        public void CheckData()
        {
            for (int i = 0; i < grdSame.Rows.Count; i++)
            {
                SqlConnection con = new SqlConnection(connectionStringLeft);
                string queryStringPropertiesTable = "SELECT COLUMN_NAME,DATA_TYPE,CHARACTER_MAXIMUM_LENGTH,IS_NULLABLE  FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = '" + grdSame.Rows[i].Cells[0].Value + "'";
                SqlDataAdapter adapterPropertiesTable = new SqlDataAdapter(queryStringPropertiesTable, con);
                DataTable dataTablePropertiesTable = new DataTable();
                adapterPropertiesTable.Fill(dataTablePropertiesTable);
                grdLeftProperties.DataSource = dataTablePropertiesTable;
                //
                SqlConnection conn = new SqlConnection(connectionStringRight);
                string queryStringPropertiesTable2 = "SELECT COLUMN_NAME,DATA_TYPE,CHARACTER_MAXIMUM_LENGTH,IS_NULLABLE  FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = '" + grdSame.Rows[i].Cells[0].Value + "'";
                SqlDataAdapter adapterPropertiesTable2 = new SqlDataAdapter(queryStringPropertiesTable2, conn);
                DataTable dataTablePropertiesTable2 = new DataTable();
                adapterPropertiesTable2.Fill(dataTablePropertiesTable2);
                grdRightProperties.DataSource = dataTablePropertiesTable2;

                countdb1 = 0;
                countdb2 = 0;
                //different DB Left
                foreach (DataRow drDatabse1 in dataTablePropertiesTable.Rows)
                {

                    foreach (DataRow drDatabse2 in dataTablePropertiesTable2.Rows)
                    {

                        if (drDatabse1["COLUMN_NAME"].ToString() == drDatabse2["COLUMN_NAME"].ToString())
                        {
                            countdb1 += 1;
                        }
                    }

                }
                //different DB Right
                foreach (DataRow drDatabse2 in dataTablePropertiesTable.Rows)
                {

                    foreach (DataRow drDatabse1 in dataTablePropertiesTable2.Rows)
                    {

                        if (drDatabse1["COLUMN_NAME"].ToString() == drDatabse2["COLUMN_NAME"].ToString())
                        {
                            countdb2 += 1;
                        }
                    }
                }
                if (countdb1 == countdb2)
                {
                    if (dataTablePropertiesTable2.Rows.Count.ToString() == dataTablePropertiesTable.Rows.Count.ToString())
                    {
                        grdSame.Rows[i].DefaultCellStyle.BackColor = Color.LightBlue;
                    }
                    else
                    {
                        grdSame.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                    }
                }
                else
                {
                    grdSame.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                }
            }
        }
        #endregion

        #region Compare
        public void Compare()
        {
            SqlConnection conn = new SqlConnection(connectionStringLeft);
            
            String queryStringDatabase1 = "select *from sys.tables";
            SqlDataAdapter adapterDatabase1 = new SqlDataAdapter(queryStringDatabase1, conn);
            DataTable dataTableDatabase1 = new DataTable();
            adapterDatabase1.Fill(dataTableDatabase1);
            //
            SqlConnection con = new SqlConnection(connectionStringRight);
            String queryStringDatabase2 = "select *from sys.tables";
            SqlDataAdapter adapterDatabese2 = new SqlDataAdapter(queryStringDatabase2, con);
            DataTable dataTableDatabase2 = new DataTable();
            adapterDatabese2.Fill(dataTableDatabase2);
            countdb1 = 0;
            countdb2 = 0;
            grdDatabaseLeft.Rows.Clear();
            // different db left
            foreach (DataRow dr in dataTableDatabase1.Rows)
            {
                countdb1 = 0;
                foreach (DataRow dr2 in dataTableDatabase2.Rows)
                {
                    if (dr["name"].ToString() == dr2["name"].ToString())
                    {
                        countdb1 += 1;
                    }
                }
                if (countdb1 == 0)
                {
                    grdDatabaseLeft.Rows.Add(dr["name"].ToString());
                }
            }
            grdDatabaseRight.Rows.Clear();
            // different db right
            foreach (DataRow dr2 in dataTableDatabase2.Rows)
            {
                countdb1 = 0;
                foreach (DataRow dr in dataTableDatabase1.Rows)
                {
                    if (dr2["name"].ToString() == dr["name"].ToString())
                    {
                        countdb1 += 1;
                    }
                }
                if (countdb1 == 0)
                {
                    grdDatabaseRight.Rows.Add(dr2["name"].ToString());
                }
            }
            // same
            grdSame.Rows.Clear();
            foreach (DataRow dr in dataTableDatabase1.Rows)
            {
                foreach (DataRow dr2 in dataTableDatabase2.Rows)
                {
                    if (dr["name"].ToString() == dr2["name"].ToString())
                    {
                        grdSame.Rows.Add(dr["name"].ToString());
                        //m_DBSame = (DataTable)grdSame.DataSource;
                    }
                }
            }
        }
        #endregion

        private void grdSame_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;
            try
            {

                //string sqlconnectionDatabase1 = @"Data Source=.;" + "Initial Catalog=" + databasename1 + ";" + "Integrated Security=True";
                SqlConnection conn = new SqlConnection(connectionStringLeft);
                //Con
                String queryStringScripTableDB1 = "select  'create table [' + so.name + '] (' + o.list + ')' + CASE WHEN tc.Constraint_Name IS NULL THEN '' ELSE 'ALTER TABLE ' + so.Name + ' ADD CONSTRAINT ' + tc.Constraint_Name  + ' PRIMARY KEY ' + ' (' + LEFT(j.List, Len(j.List)-1) + ')' END FROM    sysobjects so cross apply (SELECT '  ['+column_name+'] ' + data_type + case data_type when 'sql_variant' then '' when 'text' then '' when 'ntext' then '' when 'xml' then '' when 'decimal' then '(' + cast(numeric_precision as varchar) + ', ' + cast(numeric_scale as varchar) + ')' else coalesce('('+case when character_maximum_length = -1 then 'MAX' else cast(character_maximum_length as varchar) end +')','') end + ' ' + CASE when exists ( select id from syscolumns where object_name(id)=so.name and name=column_name and columnproperty(id,name,'IsIdentity') = 1 ) then 'IDENTITY(' +  cast(ident_seed(so.name) as varchar) + ',' +  cast(ident_incr(so.name) as varchar) + ')' else '' end + ' ' + (case when IS_NULLABLE = 'No' then 'NOT ' else '' end ) + 'NULL ' + case when information_schema.columns.COLUMN_DEFAULT IS NOT NULL THEN 'DEFAULT '+ information_schema.columns.COLUMN_DEFAULT ELSE '' END + ', '  from information_schema.columns where table_name = so.name order by ordinal_position FOR XML PATH('')) o (list) LEFT join information_schema.table_constraints tc ON  tc.Table_name       = so.Name AND tc.Constraint_Type  = 'PRIMARY KEY' CROSS apply (select '[' + Column_Name + '], ' FROM   information_schema.key_column_usage kcu WHERE  kcu.Constraint_Name = tc.Constraint_Name ORDER BY ORDINAL_POSITION FOR XML PATH('')) j (list) WHERE   xtype = 'U' and name ='" 
                    + grdSame.Rows[dong].Cells[0].Value + "'";
                SqlDataAdapter adapterScripTable1 = new SqlDataAdapter(queryStringScripTableDB1, conn);
                DataTable dataTableSctipTableDB1 = new DataTable();
                adapterScripTable1.Fill(dataTableSctipTableDB1);
                //dgv_ScripTable.DataSource = dataTableSctipTableDB1;
                txtScriptDBLeft.Text = dataTableSctipTableDB1.Rows[0][0].ToString();
                //
                //string sqlconnectionDatabase2 = @"Data Source=.;" + "Initial Catalog=" + databasename2 + ";" + "Integrated Security=True";
                SqlConnection con = new SqlConnection(connectionStringRight);
                //Con
                String queryScripTableBD2 = "select  'create table [' + so.name + '] (' + o.list + ')' + CASE WHEN tc.Constraint_Name IS NULL THEN '' ELSE 'ALTER TABLE ' + so.Name + ' ADD CONSTRAINT ' + tc.Constraint_Name  + ' PRIMARY KEY ' + ' (' + LEFT(j.List, Len(j.List)-1) + ')' END FROM    sysobjects so cross apply (SELECT '  ['+column_name+'] ' + data_type + case data_type when 'sql_variant' then '' when 'text' then '' when 'ntext' then '' when 'xml' then '' when 'decimal' then '(' + cast(numeric_precision as varchar) + ', ' + cast(numeric_scale as varchar) + ')' else coalesce('('+case when character_maximum_length = -1 then 'MAX' else cast(character_maximum_length as varchar) end +')','') end + ' ' + CASE when exists ( select id from syscolumns where object_name(id)=so.name and name=column_name and columnproperty(id,name,'IsIdentity') = 1 ) then 'IDENTITY(' +  cast(ident_seed(so.name) as varchar) + ',' +  cast(ident_incr(so.name) as varchar) + ')' else '' end + ' ' + (case when IS_NULLABLE = 'No' then 'NOT ' else '' end ) + 'NULL ' + case when information_schema.columns.COLUMN_DEFAULT IS NOT NULL THEN 'DEFAULT '+ information_schema.columns.COLUMN_DEFAULT ELSE '' END + ', '  from information_schema.columns where table_name = so.name order by ordinal_position FOR XML PATH('')) o (list) LEFT join information_schema.table_constraints tc ON  tc.Table_name       = so.Name AND tc.Constraint_Type  = 'PRIMARY KEY' CROSS apply (select '[' + Column_Name + '], ' FROM   information_schema.key_column_usage kcu WHERE  kcu.Constraint_Name = tc.Constraint_Name ORDER BY ORDINAL_POSITION FOR XML PATH('')) j (list) WHERE   xtype = 'U' and name ='" 
                    + grdSame.Rows[dong].Cells[0].Value + "'";
                SqlDataAdapter adapterScripTable2 = new SqlDataAdapter(queryScripTableBD2, con);
                DataTable dataTableSctipTableDB2 = new DataTable();
                adapterScripTable2.Fill(dataTableSctipTableDB2);
                //dgv_ScripTable.DataSource = dataTableSctipTableDB2;
                txtScriptDBRight.Text = dataTableSctipTableDB2.Rows[0][0].ToString();
                adapterScripTable2.Fill(dataTableSctipTableDB2);
                //
                //string sqlconnectionDB1 = @"Data Source=.;" + "Initial Catalog=" + databasename1 + ";" + "Integrated Security=True";
                SqlConnection conn1 = new SqlConnection(ConnectionStringLeft);
                string queryStringGetPropertiesTableBD1 = "SELECT COLUMN_NAME,DATA_TYPE,CHARACTER_MAXIMUM_LENGTH,IS_NULLABLE  FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = '" + grdSame.Rows[dong].Cells[0].Value + "'";
                SqlDataAdapter adapterPropertiesTableDB1 = new SqlDataAdapter(queryStringGetPropertiesTableBD1, conn1);
                DataTable dataTablePropertiesTableDB1 = new DataTable();
                adapterPropertiesTableDB1.Fill(dataTablePropertiesTableDB1);
                grdLeftProperties.DataSource = dataTablePropertiesTableDB1;
                //
                //string sqlconnectionDB2 = @"Data Source=.;" + "Initial Catalog=" + databasename2 + ";" + "Integrated Security=True";
                SqlConnection conn2 = new SqlConnection(connectionStringRight);
                string queryStringGetPropertiesTableBD2 = "SELECT COLUMN_NAME,DATA_TYPE,CHARACTER_MAXIMUM_LENGTH,IS_NULLABLE  FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = '" + grdSame.Rows[dong].Cells[0].Value + "'";
                SqlDataAdapter adapterPropertiesTableDB2 = new SqlDataAdapter(queryStringGetPropertiesTableBD2, conn2);
                DataTable dataTablePropertiesTableDB2 = new DataTable();
                adapterPropertiesTableDB2.Fill(dataTablePropertiesTableDB2);
                grdRightProperties.DataSource = dataTablePropertiesTableDB2;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
        }

        private void grdSame_Click(object sender, EventArgs e)
        {
            bClick = true;
        }

        private void grdSame_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewColumn newColumn = grdSame.Columns[e.ColumnIndex];
            DataGridViewColumn oldColumn = grdSame.SortedColumn;
            ListSortDirection direction;


            if (oldColumn != null)
            {

                if (oldColumn == newColumn &&
                    grdSame.SortOrder == System.Windows.Forms.SortOrder.Ascending)
                {
                    direction = ListSortDirection.Descending;
                }
                else
                {

                    direction = ListSortDirection.Ascending;
                    oldColumn.HeaderCell.SortGlyphDirection = System.Windows.Forms.SortOrder.None;
                }
            }
            else
            {
                direction = ListSortDirection.Ascending;
            }

            // Sort the selected column.
            grdSame.Sort(newColumn, direction);
            newColumn.HeaderCell.SortGlyphDirection =
                direction == ListSortDirection.Ascending ?
                System.Windows.Forms.SortOrder.Ascending : System.Windows.Forms.SortOrder.Descending;
        }

        private void grdSame_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewColumn column in grdSame.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.Programmatic;
            }
        }

        public void DBLeft()
        {
            grdDatabaseLeft.Refresh();
            grdDatabaseLeft.Update();
        }
        public void DBRight()
        {
            grdDatabaseRight.Refresh();
            grdDatabaseRight.Update();
        }
        private void grdDatabaseLeft_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //string sqlconnection = "Data Source=.;" + "Initial Catalog=" + databasename2 + ";" + "Integrated Security=True";
                SqlConnection conn = new SqlConnection(connectionStringLeft);
                //Con
                row = e.RowIndex;
                String Seqchildc = "select  'create table [' + so.name + '] (' + o.list + ')' + CASE WHEN tc.Constraint_Name IS NULL THEN '' ELSE 'ALTER TABLE ' + so.Name + ' ADD CONSTRAINT ' + tc.Constraint_Name  + ' PRIMARY KEY ' + ' (' + LEFT(j.List, Len(j.List)-1) + ')' END FROM    sysobjects so cross apply (SELECT '  ['+column_name+'] ' + data_type + case data_type when 'sql_variant' then '' when 'text' then '' when 'ntext' then '' when 'xml' then '' when 'decimal' then '(' + cast(numeric_precision as varchar) + ', ' + cast(numeric_scale as varchar) + ')' else coalesce('('+case when character_maximum_length = -1 then 'MAX' else cast(character_maximum_length as varchar) end +')','') end + ' ' + CASE when exists ( select id from syscolumns where object_name(id)=so.name and name=column_name and columnproperty(id,name,'IsIdentity') = 1 ) then 'IDENTITY(' +  cast(ident_seed(so.name) as varchar) + ',' +  cast(ident_incr(so.name) as varchar) + ')' else '' end + ' ' + (case when IS_NULLABLE = 'No' then 'NOT ' else '' end ) + 'NULL ' + case when information_schema.columns.COLUMN_DEFAULT IS NOT NULL THEN 'DEFAULT '+ information_schema.columns.COLUMN_DEFAULT ELSE '' END + ', '  from information_schema.columns where table_name = so.name order by ordinal_position FOR XML PATH('')) o (list) LEFT join information_schema.table_constraints tc ON  tc.Table_name       = so.Name AND tc.Constraint_Type  = 'PRIMARY KEY' CROSS apply (select '[' + Column_Name + '], ' FROM   information_schema.key_column_usage kcu WHERE  kcu.Constraint_Name = tc.Constraint_Name ORDER BY ORDINAL_POSITION FOR XML PATH('')) j (list) WHERE   xtype = 'U' and name ='"
                    + grdDatabaseLeft.Rows[row].Cells[0].Value + "'";
                SqlDataAdapter ad = new SqlDataAdapter(Seqchildc, conn);
                DataTable dt = new DataTable();
                // DataRow dr = new DataRow();
                ad.Fill(dt);
                //dgv_ScripTable.DataSource = dt;
                txtScriptDBLeft.Text = dt.Rows[0][0].ToString();
                string SQL = "SELECT COLUMN_NAME,DATA_TYPE,CHARACTER_MAXIMUM_LENGTH,IS_NULLABLE  FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = '"
                    + grdDatabaseLeft.Rows[row].Cells[0].Value + "'";
                SqlDataAdapter ad2 = new SqlDataAdapter(SQL, conn);
                DataTable dt2 = new DataTable();
                ad2.Fill(dt2);
                grdLeftProperties.DataSource = dt2;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void grdDatabaseLeft_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DBLeft();
        }

        private void grdDatabaseLeft_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            grdDatabaseLeft.DefaultCellStyle.SelectionForeColor = Color.Red;
        }

        private void grdDatabaseLeft_Click(object sender, EventArgs e)
        {
            bClick = false;
        }
        int row;
        private void grdDatabaseRight_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //string sqlconnection = "Data Source=.;" + "Initial Catalog=" + databasename2 + ";" + "Integrated Security=True";
                SqlConnection conn = new SqlConnection(connectionStringRight);
                //Con
                row = e.RowIndex;
                String Seqchildc = "select  'create table [' + so.name + '] (' + o.list + ')' + CASE WHEN tc.Constraint_Name IS NULL THEN '' ELSE 'ALTER TABLE ' + so.Name + ' ADD CONSTRAINT ' + tc.Constraint_Name  + ' PRIMARY KEY ' + ' (' + LEFT(j.List, Len(j.List)-1) + ')' END FROM    sysobjects so cross apply (SELECT '  ['+column_name+'] ' + data_type + case data_type when 'sql_variant' then '' when 'text' then '' when 'ntext' then '' when 'xml' then '' when 'decimal' then '(' + cast(numeric_precision as varchar) + ', ' + cast(numeric_scale as varchar) + ')' else coalesce('('+case when character_maximum_length = -1 then 'MAX' else cast(character_maximum_length as varchar) end +')','') end + ' ' + CASE when exists ( select id from syscolumns where object_name(id)=so.name and name=column_name and columnproperty(id,name,'IsIdentity') = 1 ) then 'IDENTITY(' +  cast(ident_seed(so.name) as varchar) + ',' +  cast(ident_incr(so.name) as varchar) + ')' else '' end + ' ' + (case when IS_NULLABLE = 'No' then 'NOT ' else '' end ) + 'NULL ' + case when information_schema.columns.COLUMN_DEFAULT IS NOT NULL THEN 'DEFAULT '+ information_schema.columns.COLUMN_DEFAULT ELSE '' END + ', '  from information_schema.columns where table_name = so.name order by ordinal_position FOR XML PATH('')) o (list) LEFT join information_schema.table_constraints tc ON  tc.Table_name       = so.Name AND tc.Constraint_Type  = 'PRIMARY KEY' CROSS apply (select '[' + Column_Name + '], ' FROM   information_schema.key_column_usage kcu WHERE  kcu.Constraint_Name = tc.Constraint_Name ORDER BY ORDINAL_POSITION FOR XML PATH('')) j (list) WHERE   xtype = 'U' and name ='"
                    + grdDatabaseRight.Rows[row].Cells[0].Value + "'";
                SqlDataAdapter ad = new SqlDataAdapter(Seqchildc, conn);
                DataTable dt = new DataTable();
                // DataRow dr = new DataRow();
                ad.Fill(dt);
                //dgv_ScripTable.DataSource = dt;
                txtScriptDBRight.Text = dt.Rows[0][0].ToString();
                string SQL = "SELECT COLUMN_NAME,DATA_TYPE,CHARACTER_MAXIMUM_LENGTH,IS_NULLABLE  FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = '"
                    + grdDatabaseRight.Rows[row].Cells[0].Value + "'";
                SqlDataAdapter ad2 = new SqlDataAdapter(SQL, conn);
                DataTable dt2 = new DataTable();
                ad2.Fill(dt2);
                grdRightProperties.DataSource = dt2;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void grdDatabaseRight_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DBRight();
        }

        private void grdDatabaseRight_Click(object sender, EventArgs e)
        {
            bClick = false;
        }

        private void grdRightProperties_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewColumn column in grdSame.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.Programmatic;
            }
        }

        private void grdLeftProperties_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewColumn column in grdSame.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.Programmatic;
            }
        }

        private void grdLeftProperties_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewColumn newColumn = grdLeftProperties.Columns[e.ColumnIndex];
            DataGridViewColumn oldColumn = grdLeftProperties.SortedColumn;
            ListSortDirection direction;


            if (oldColumn != null)
            {

                if (oldColumn == newColumn &&
                    grdLeftProperties.SortOrder == System.Windows.Forms.SortOrder.Ascending)
                {
                    direction = ListSortDirection.Descending;
                }
                else
                {

                    direction = ListSortDirection.Ascending;
                    oldColumn.HeaderCell.SortGlyphDirection = System.Windows.Forms.SortOrder.None;
                }
            }
            else
            {
                direction = ListSortDirection.Ascending;
            }

            // Sort the selected column.
            grdLeftProperties.Sort(newColumn, direction);
            newColumn.HeaderCell.SortGlyphDirection =
                direction == ListSortDirection.Ascending ?
                System.Windows.Forms.SortOrder.Ascending : System.Windows.Forms.SortOrder.Descending;
        }

        string tablecopy;
        private void btnCopyLeft_Click(object sender, EventArgs e)
        {
            if (txtScriptDBLeft.Text != txtScriptDBRight.Text)
            {
                //string sqlconnection = "Data Source=.;" + "Initial Catalog=" + Databasename2 + ";" + "Integrated Security=True";
                SqlConnection source = new SqlConnection(connectionStringRight);
                MessageBox.Show("Table was copy!!");


                source.Open();
                SqlCommand cmd2;
                if (bClick == true)
                {
                    tablecopy = grdSame.Rows[row].Cells[0].Value.ToString();
                    cmd2 = new SqlCommand("Drop table " + tablecopy, source);
                    cmd2.ExecuteNonQuery();

                }

                SqlCommand cmd = new SqlCommand(txtScriptDBLeft.Text.ToString(), source);
                cmd.ExecuteNonQuery();
                source.Close();
                cmd.Dispose();
            }
            else
            {
                return;
            }
            grdSame.Refresh();
            grdSame.Update();
            Compare();
        }

        private void btnCopyRight_Click(object sender, EventArgs e)
        {
            if (txtScriptDBLeft.Text != txtScriptDBRight.Text)
            {
                //string sqlconnection = "Data Source=.;" + "Initial Catalog=" + Databasename1 + ";" + "Integrated Security=True";
                SqlConnection source = new SqlConnection(connectionStringLeft);
                MessageBox.Show("Table was copy!!");

                source.Open();
                if (bClick == true)
                {
                    tablecopy = grdSame.Rows[row].Cells[0].Value.ToString();
                    SqlCommand cmd2 = new SqlCommand("Drop table " + tablecopy, source);
                    cmd2.ExecuteNonQuery();

                }

                SqlCommand cmd = new SqlCommand(txtScriptDBRight.Text.ToString(), source);

                cmd.ExecuteNonQuery();
                source.Close();
                cmd.Dispose();
            }
            else
            {
                return;
            }

            grdSame.Refresh();
            grdSame.Update();
            Compare();
        }

        private void btnCheckDBLeft_Click(object sender, EventArgs e)
        {
            frmCheckDB frm = new frmCheckDB();
            frm.ConnectionString = connectionStringLeft;
            frm.ShowDialog();
        }

        private void btnCheckDBRight_Click(object sender, EventArgs e)
        {
            frmCheckDB frm = new frmCheckDB();
            frm.ConnectionString = connectionStringRight;
            frm.ShowDialog();
        }

    }
}