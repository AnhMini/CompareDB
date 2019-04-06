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
    public partial class frmCompareTree : Form
    {
        
        private static readonly int LEFT = 0;
        private static readonly int RIGHT = 1;

        private TreeNode m_NodeLeft = null;
        private TreeNode m_NodeRight = null;
        // Connection string left
        private string connectionStringLeft;

        public string ConnectionStringLeft
        {
            get { return connectionStringLeft; }
            set { connectionStringLeft = value; }
        }
        // Connection string right
        private string connectionStringRight;

        public string ConnectionStringRight
        {
            get { return connectionStringRight; }
            set { connectionStringRight = value; }
        }
       
        public frmCompareTree()
        {
            InitializeComponent();
        }

        // get server name + (Database Name)
        public string GetServerName(string connectstring)
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.ConnectionString = connectstring;
            return builder.DataSource + "(" + builder.InitialCatalog + ")";
        }

        #region CountData

        // count tables
        private int CountTables(string connectionString)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand cmd = new SqlCommand("select count(*) from sys.tables", connection);

            int iCountTables = (int)cmd.ExecuteScalar();
            connection.Dispose();
            connection.Close();

            return iCountTables;
        }
        // count stored procedures
        private int CountStoredProcedures(string connectionString)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand cmd = new SqlCommand("SELECT Count(*)  FROM dbo.sysobjects WHERE (type = 'P')", connection);

            int iCountStoredProcedures = (int)cmd.ExecuteScalar();
            connection.Dispose();
            connection.Close();

            return iCountStoredProcedures;
        }
        // count triggers
        private int CountTriggers(string connectionString)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand cmd = new SqlCommand("SELECT Count(*) FROM sys.triggers", connection);

            int iCountTriggers = (int)cmd.ExecuteScalar();
            connection.Dispose();
            connection.Close();

            return iCountTriggers;
        }
        #endregion

        #region tree
       
        public void LoadTree(TreeView trvObj, string connectionString,int leftOrRight)
        {
            TreeNode mainNode = new TreeNode();
            mainNode.Name = "mainNode";
            mainNode.Text = GetServerName(connectionString);
            mainNode.Tag = "Root";
            mainNode.ImageIndex = 0;
            mainNode.SelectedImageIndex = 0;
            trvObj.Nodes.Add(mainNode);
            //
            TreeNode nodeTables = new TreeNode();
            nodeTables.Name = "Tables(" + CountTables(connectionString) + ")";
            nodeTables.Text = "Tables(" + CountTables(connectionString) + ")";
            nodeTables.Tag = "Tables";
            nodeTables.ImageIndex = 1;
            nodeTables.SelectedImageIndex = 1;
            //
            TreeNode nodeStoredProcedures = new TreeNode();
            nodeStoredProcedures.Name = "Stored Procedures(" + CountStoredProcedures(connectionString) + ")";
            nodeStoredProcedures.Text = "Stored Procedures(" + CountStoredProcedures(connectionString) + ")";
            nodeStoredProcedures.Tag = "Stored Procedures";
            nodeStoredProcedures.ImageIndex = 1;
            nodeStoredProcedures.SelectedImageIndex = 1;
            //
            TreeNode nodeTriggers = new TreeNode();
            nodeTriggers.Name = "Triggers(" + CountTriggers(connectionString) + ")";
            nodeTriggers.Text = "Triggers(" + CountTriggers(connectionString) + ")";
            nodeTriggers.Tag = "Triggers";
            nodeTriggers.ImageIndex = 1;
            nodeTriggers.SelectedImageIndex = 1;
            //

            mainNode.Nodes.Add(nodeTables);
            mainNode.Nodes.Add(nodeStoredProcedures);
            mainNode.Nodes.Add(nodeTriggers);
            mainNode.Expand();
            // load child
            // GetData(GetTables(connectionStringLeft), GetTables(connectionStringRight))
            if (leftOrRight == LEFT)
            {
                LoadTreeLeftChildNode(GetData(GetTables(connectionStringLeft), GetTables(connectionStringRight)), nodeTables, connectionString,"Table");
                LoadTreeLeftChildNode(GetData(GetStoredProcedures(connectionStringLeft), GetStoredProcedures(connectionStringRight)), nodeStoredProcedures, connectionString,"Proc");
                LoadTreeLeftChildNode(GetData(GetTriggers(connectionStringLeft), GetTriggers(connectionStringRight)), nodeTriggers, connectionString,"Trigger");
            }
            else
            {
                LoadTreeRightChildNode(GetData(GetTables(connectionStringLeft), GetTables(connectionStringRight)), nodeTables, connectionString, "Table");
                LoadTreeRightChildNode(GetData(GetStoredProcedures(connectionStringLeft), GetStoredProcedures(connectionStringRight)), nodeStoredProcedures, connectionString, "Proc");
                LoadTreeRightChildNode(GetData(GetTriggers(connectionStringLeft), GetTriggers(connectionStringRight)), nodeTriggers, connectionString, "Trigger");
            }
            //LoadTreeChildNode(GetStoredProcedures(connectionString), nodeStoredProcedures, connectionString);
            //LoadTreeChildNode(GetTriggers(connectionString), nodeTriggers, connectionString);

        }
        // load tree child node
        public void LoadTreeChildNode(DataTable dt, TreeNode parentNode,string connectionString)
        {
            if (dt == null || dt.Rows.Count <= 0)
            {
                return;
            }
            foreach (DataRow dr in dt.Rows)
            {
                TreeNode nodeChild = new TreeNode();
                nodeChild.Name = dr["Name"].ToString();
                nodeChild.Text = dr["Name"].ToString();
                nodeChild.Tag = dr["Name"].ToString();
                parentNode.Nodes.Add(nodeChild);
                
                DataTable dtColumns = GetColumnsInTable(connectionString, dr["Name"].ToString());
                if (dtColumns != null && dtColumns.Rows.Count > 0)
                {
                    TreeNode nodeColumns = new TreeNode();
                    nodeColumns.Name = "Columns(" + (GetColumnsInTable(connectionString, dr["Name"].ToString())).Rows.Count + ")";
                    nodeColumns.Text = "Columns(" + (GetColumnsInTable(connectionString, dr["Name"].ToString())).Rows.Count + ")";
                    nodeColumns.Tag = "Columns(" + (GetColumnsInTable(connectionString, dr["Name"].ToString())).Rows.Count + ")";
                    nodeChild.Nodes.Add(nodeColumns);

                    foreach (DataRow drColumn in dtColumns.Rows)
                    {
                        TreeNode nodeChildc = new TreeNode();
                        nodeChildc.Name = drColumn["Column_name"].ToString();
                        nodeChildc.Text = drColumn["Column_name"].ToString();
                        nodeChildc.Tag = drColumn["Column_name"].ToString();
                        nodeColumns.Nodes.Add(nodeChildc);
                    }
                }
            }
        }

        public void LoadTreeLeftChildNode(DataTable dt, TreeNode parentNode, string connectionString,string tag)
        {
            if (dt == null || dt.Rows.Count <= 0)
            {
                return;
            }
            int icount = 0;
            foreach (DataRow dr in dt.Rows)
            {
                TreeNode nodeChild = new TreeNode();
                nodeChild.Name = dr["NameLeft"].ToString();
                nodeChild.Text = dr["NameLeft"].ToString();
                nodeChild.Tag = tag+icount;
                if (dr["NameLeft"].ToString() == "")
                {
                    nodeChild.ImageIndex = 4;
                    nodeChild.SelectedImageIndex = 4;
                }
                else
                {
                    nodeChild.ImageIndex = 2;
                    nodeChild.SelectedImageIndex = 2;
                }
                
                if ((int)dr["SameLeft"] == 1)
                {
                    nodeChild.ForeColor = Color.Red;
                }
                else
                {
                    nodeChild.ForeColor = Color.Blue;
                }
                parentNode.Nodes.Add(nodeChild);

                DataTable dtColumns = GetColumnsInTable(connectionString, dr["NameLeft"].ToString());
                if (dtColumns != null && dtColumns.Rows.Count > 0)
                {
                    TreeNode nodeColumns = new TreeNode();
                    nodeColumns.Name = "Columns(" + (GetColumnsInTable(connectionString, dr["NameLeft"].ToString())).Rows.Count + ")";
                    nodeColumns.Text = "Columns(" + (GetColumnsInTable(connectionString, dr["NameLeft"].ToString())).Rows.Count + ")";
                    nodeColumns.Tag = "Columns_" + dr["NameLeft"].ToString();
                    nodeColumns.ImageIndex = 3;
                    nodeColumns.SelectedImageIndex = 3;
                    nodeChild.Nodes.Add(nodeColumns);

                    foreach (DataRow drColumn in dtColumns.Rows)
                    {
                        TreeNode nodeChildc = new TreeNode();
                        nodeChildc.Name = drColumn["Column_name"].ToString();
                        nodeChildc.Text = drColumn["Column_name"].ToString();
                        nodeChildc.Tag = "Column_"+drColumn["Column_name"].ToString();
                        nodeChildc.ImageIndex = 4;
                        nodeChildc.SelectedImageIndex = 4;
                        nodeColumns.Nodes.Add(nodeChildc);
                    }
                }
                icount++;
            }
        }

        public void LoadTreeRightChildNode(DataTable dt, TreeNode parentNode, string connectionString, string tag)
        {
            if (dt == null || dt.Rows.Count <= 0)
            {
                return;
            }
            int icount = 0;
            foreach (DataRow dr in dt.Rows)
            {
                TreeNode nodeChild = new TreeNode();
                nodeChild.Name = dr["NameRight"].ToString();
                nodeChild.Text = dr["NameRight"].ToString();
                nodeChild.Tag = tag + icount;
                if (dr["NameRight"].ToString() == "")
                {
                    nodeChild.ImageIndex = 4;
                    nodeChild.SelectedImageIndex = 4;
                }
                else
                {
                    nodeChild.ImageIndex = 2;
                    nodeChild.SelectedImageIndex = 2;
                }
                if ((int)dr["SameRight"] == 1)
                {
                    nodeChild.ForeColor = Color.Red;
                }
                else
                {
                    nodeChild.ForeColor = Color.Blue;
                }
                parentNode.Nodes.Add(nodeChild);

                DataTable dtColumns = GetColumnsInTable(connectionString, dr["NameRight"].ToString());
                if (dtColumns != null && dtColumns.Rows.Count > 0)
                {
                    TreeNode nodeColumns = new TreeNode();
                    nodeColumns.Name = "Columns(" + (GetColumnsInTable(connectionString, dr["NameRight"].ToString())).Rows.Count + ")";
                    nodeColumns.Text = "Columns(" + (GetColumnsInTable(connectionString, dr["NameRight"].ToString())).Rows.Count + ")";
                    nodeColumns.Tag = "Columns(" + (GetColumnsInTable(connectionString, dr["NameRight"].ToString())).Rows.Count + ")";
                    nodeColumns.ImageIndex = 3;
                    nodeColumns.SelectedImageIndex = 3;

                    nodeChild.Nodes.Add(nodeColumns);

                    foreach (DataRow drColumn in dtColumns.Rows)
                    {
                        TreeNode nodeChildc = new TreeNode();
                        nodeChildc.Name = drColumn["Column_name"].ToString();
                        nodeChildc.Text = drColumn["Column_name"].ToString();
                        nodeChildc.Tag = drColumn["Column_name"].ToString();
                        nodeChildc.ImageIndex = 4;
                        nodeChildc.SelectedImageIndex = 4;
                        nodeColumns.Nodes.Add(nodeChildc);
                    }
                }
                icount++;
            }
        }

        #endregion

        #region LoadData

        // load tables

        private DataTable GetTables(string connectionString)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string sQuery = "SELECT *  FROM sys.tables";

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sQuery, connection);
            DataTable dt = new DataTable();
            sqlDataAdapter.Fill(dt);
            connection.Dispose();
            connection.Close();
            return dt;
        }
        // load stored procedures
        private DataTable GetStoredProcedures(string connectionString)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string sQuery = "SELECT *  FROM dbo.sysobjects WHERE (type = 'P')";

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sQuery, connection);
            DataTable dt = new DataTable();
            sqlDataAdapter.Fill(dt);
            connection.Dispose();
            connection.Close();
            return dt;
        }
        // load trigger
        private DataTable GetTriggers(string connectionString)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string sQuery = "SELECT * FROM sys.triggers";

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sQuery, connection);
            DataTable dt = new DataTable();
            sqlDataAdapter.Fill(dt);
            connection.Dispose();
            connection.Close();
            return dt;
        }
        // get columns in table
        private DataTable GetColumnsInTable(string connectionString, string tableName)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string sQuery = "select * from INFORMATION_SCHEMA.COLUMNS where TABLE_NAME='" + tableName + "'";

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sQuery, connection);
            DataTable dt = new DataTable();
            sqlDataAdapter.Fill(dt);
            connection.Dispose();
            connection.Close();
            return dt;
        }

        #endregion

        #region Create Data
        // Data 
        public DataTable CreateData()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("NameLeft",typeof(string));
            dt.Columns.Add("SameLeft", typeof(int));
            dt.Columns.Add("NameRight", typeof(string));
            dt.Columns.Add("SameRight", typeof(int));
            return dt;
        }


        public DataTable GetData(DataTable dtLeft, DataTable dtRight)
        {
            DataTable dt = CreateData();
                    
            foreach (DataRow drLeft in dtLeft.Rows)
            {
                string nameLeft = drLeft["Name"].ToString();
                //DataRow[] myResultR = dtRight.Select();
                DataRow[] drRow = dtRight.Select("Name ='" + nameLeft + "'");

                if (drRow != null && drRow.Length > 0)
                    {
                        DataRow dr = dt.NewRow();
                        dr["NameLeft"] = drLeft["Name"].ToString();
                        dr["SameLeft"] = 1;
                        dr["NameRight"] = drLeft["Name"].ToString();
                        dr["SameRight"] = 1;
                        dt.Rows.Add(dr);

                    }
            }

            //DataTable dttemp = dtLeft.Select("Name in " + dtRight.Select());

            //DataRow[] myResultL = dtLeft.Select();
            
            //DataRow[] myResultNotIn = dtLeft.Select("Name not in ("+myResultR[].ItemArray["name"]+")");



            DataTable dtCopy = dt.Copy();
            if (dtCopy == null || dtCopy.Rows.Count <= 0)
            {
                foreach (DataRow drLeft in dtLeft.Rows)
                {
                    DataRow dr = dt.NewRow();
                    dr["NameLeft"] = drLeft["Name"].ToString();
                    dr["SameLeft"] = 0;
                    dr["NameRight"] = "";
                    dr["SameRight"] = 0;
                    dt.Rows.Add(dr);
                }
                foreach (DataRow drRight in dtRight.Rows)
                {
                    DataRow dr = dt.NewRow();
                    dr["NameLeft"] = "";
                    dr["SameLeft"] = 0;
                    dr["NameRight"] = drRight["Name"].ToString();
                    dr["SameRight"] = 0;
                    dt.Rows.Add(dr);
                }
            }
            // remove exist
            //DataTable dtLeftC = dtLeft.Copy();
            foreach (DataRow drLeft in dtLeft.Rows)
            {
                string nameLeft = drLeft["Name"].ToString();
                //DataRow[] myResultR = dtRight.Select();
                DataRow[] drRow = dtCopy.Select("nameLeft ='" + nameLeft + "'");

                if (drRow.Length <= 0)
                {
                    DataRow dr = dt.NewRow();
                    dr["NameLeft"] = drLeft["Name"].ToString();
                    dr["SameLeft"] = 0;
                    dr["NameRight"] = "";
                    dr["SameRight"] = 0;
                    dt.Rows.Add(dr);
                }
            }

            foreach (DataRow drRight in dtRight.Rows)
            {
                string nameRight = drRight["Name"].ToString();

                DataRow[] drRow = dtCopy.Select("nameRight ='" + nameRight + "'");
                if (drRow.Length <= 0)
                {
                    DataRow dr = dt.NewRow();
                    dr["NameLeft"] = "";
                    dr["SameLeft"] = 0;
                    dr["NameRight"] = drRight["Name"].ToString();
                    dr["SameRight"] = 0;
                    dt.Rows.Add(dr);
                }
            }
            return dt;
        }
        #endregion
        //
        // find by tag
        #region Find By Tag
        private TreeNode FindByTag(TreeView trv, string tag)
        {
            TreeNode node = null;
            TreeNodeCollection nodes = trv.Nodes;
            foreach (TreeNode n in nodes)
            {
                node = FindRecursiveTag(n, tag);
            }
            return node;
        }
        #region new
        
        //private TreeNode FindRecursiveTag(TreeNode treeNode, string tag)
        //{
        //    TreeNode node = new TreeNode();
        //    //bool bCheckBreak = true;
        //    if (treeNode.Tag.ToString() == tag)
        //    {
        //        treeNode.BackColor = Color.DarkGray;
        //        node = treeNode;
        //        return node;
        //    }
        //    else
        //    {
        //        foreach (TreeNode tn in treeNode.Nodes)
        //        {
        //                // if the text properties match, color the item
        //                if (tn.Tag.ToString() == tag)
        //                {
        //                    tn.BackColor = Color.DarkGray;
        //                    node = tn;
        //                    break;
        //                }
        //                // tag for table / column
        //                FindRecursiveTag(tn, tag);
        //        }
        //        return node;
        //    }
        //    return node;
        //}
        #endregion
        #region old

        private TreeNode FindRecursiveTag(TreeNode treeNode, string tag)
        {
            TreeNode node = new TreeNode();
            //bool bCheckBreak = true;
            if (treeNode.Tag.ToString() == tag)
            {
                treeNode.BackColor = Color.DarkGray;
                node = treeNode;
                return node;
            }
            else
            {
                //
                int i = 0;
                foreach (TreeNode tn in treeNode.Nodes)
                {
                    //
                    if (i < treeNode.Nodes.Count - 1)
                    {
                        // if the text properties match, color the item
                        if (tn.Tag.ToString() == tag)
                        {
                            tn.BackColor = Color.DarkGray;
                            node = tn;
                            //bCheckBreak = true;
                            return node;
                        }
                        i++;
                        //node = FindRecursiveTag(tn, tag);
                    }
                    else
                    {
                        // tag for table / column
                        for (int j = 0; j < treeNode.Nodes.Count; j++)
                        {
                            node = FindRecursiveTag(treeNode.Nodes[j], tag);
                            if (node != null)
                            {
                                return node;
                            }
                        }
                    }
                    //
                }
                return node;
            }
        }
        #endregion
        #endregion

        #region Clear BackColor
        private void ClearBackColor(TreeView trv)
        {
            TreeNodeCollection nodes = trv.Nodes;
            foreach (TreeNode n in nodes)
            {
                ClearRecursive(n);
            }
        }

        // called by ClearBackColor function
        private void ClearRecursive(TreeNode treeNode)
        {
            treeNode.BackColor = Color.White;
            foreach (TreeNode tn in treeNode.Nodes)
            {
                tn.BackColor = Color.White;
                ClearRecursive(tn);
            }
        }
        #endregion

        #region Code Reference
        
        public string GetPath(TreeNode node)
        {
            IList<int> path = GetNodePathIndexes(node);
            StringBuilder fullPath = new StringBuilder("trvDBRight");
            foreach (int index in path)
            {
                fullPath.AppendFormat(".Nodes[{0}]", index);
                //node = trvDBRight.Nodes[index];
            }
            return fullPath.ToString();
        }
        public IList<int> GetNodePathIndexes(TreeNode node)
        {
            List<int> indexes = new List<int>();
            TreeNode currentNode = node;
            while (currentNode != null)
            {
                TreeNode parentNode = currentNode.Parent;
                if (parentNode != null)
                {
                    indexes.Add(parentNode.Nodes.IndexOf(currentNode));
                }
                else
                {
                    indexes.Add(currentNode.TreeView.Nodes.IndexOf(currentNode));
                }
                currentNode = parentNode;
            }
            indexes.Reverse();
            return indexes;
        }

        public TreeNode GetNodeFromPath(TreeNodeCollection nodes, string path, TreeView trv)
        {
            TreeNode foundNode = null;
            foreach (TreeNode tn in nodes)
            {
                if (tn.FullPath == path)
                {
                    trv.SelectedNode = tn;
                    trv.SelectedNode.EnsureVisible();
                    trv.Focus();
                    return tn;
                }
                else if (tn.Nodes.Count > 0)
                {
                    foundNode = GetNodeFromPath(tn.Nodes, path,trv);
                }
                if (foundNode != null)
                    return foundNode;
            }
            return null;
        }

        public string GetFullPath(TreeView trv, string path)
        {
            path = path.Remove(0,trv.Name.Length + 1);
            return path;
        }

        public TreeNode GetNodeFromPath(string path,TreeView trvS)
        {
            TreeNode foundNode = null;
            foreach (TreeNode tn in trvS.Nodes)
            {
                
                //if (tn.FullPath == path)
                if (GetPath(tn) == path)
                {
                    return tn;
                }
                else if (tn.Nodes.Count > 0)
                {
                    foundNode = GetNodeFromPath(path,trvS);
                }
                if (foundNode != null)
                    return foundNode;
            }
            return null;
        }
        #endregion

        #region Get Script Table
        public string GetScriptTable(string connectionString, string tableName)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            //Con
            String queryStringScripTableDB1 = "select  'create table [' + so.name + '] (' + o.list + ')'"
                + " + CASE WHEN tc.Constraint_Name IS NULL THEN '' ELSE 'ALTER TABLE ' + so.Name + ' ADD CONSTRAINT ' "
                + " + tc.Constraint_Name  + ' PRIMARY KEY ' + ' (' + LEFT(j.List, Len(j.List)-1) + ')' END "
                + " FROM    sysobjects so cross apply (SELECT '  ['+column_name+'] ' + data_type + case data_type "
                + " when 'sql_variant' then '' when 'text' then '' when 'ntext' then '' when 'xml' then '' "
                + " when 'decimal' then '(' + cast(numeric_precision as varchar) + ', ' "
                + " + cast(numeric_scale as varchar) + ')' else coalesce('('+case when character_maximum_length = -1 "
                + " then 'MAX' else cast(character_maximum_length as varchar) end +')','') end + ' ' + CASE "
                + " when exists ( select id from syscolumns where object_name(id)=so.name and name=column_name and "
                + " columnproperty(id,name,'IsIdentity') = 1 ) then 'IDENTITY(' +  cast(ident_seed(so.name) as varchar) "
                + " + ',' +  cast(ident_incr(so.name) as varchar) + ')' else '' end + ' ' + (case when IS_NULLABLE = 'No' "
                + "then 'NOT ' else '' end ) + 'NULL ' + case when information_schema.columns.COLUMN_DEFAULT IS NOT NULL"
                + " THEN 'DEFAULT '+ information_schema.columns.COLUMN_DEFAULT ELSE '' END + ', '  from information_schema.columns "
                + " where table_name = so.name order by ordinal_position FOR XML PATH('')) o (list) LEFT join "
                + " information_schema.table_constraints tc ON  tc.Table_name       = so.Name AND tc.Constraint_Type  = 'PRIMARY KEY' "
                + " CROSS apply (select '[' + Column_Name + '], ' FROM   information_schema.key_column_usage kcu"
                + " WHERE  kcu.Constraint_Name = tc.Constraint_Name ORDER BY ORDINAL_POSITION FOR XML PATH('')) j (list) "
                + " WHERE   xtype = 'U' and name ='" + tableName + "'";

            SqlDataAdapter adapterScripTable1 = new SqlDataAdapter(queryStringScripTableDB1, conn);
            DataTable dataTableSctipTableDB1 = new DataTable();
            adapterScripTable1.Fill(dataTableSctipTableDB1);
            return dataTableSctipTableDB1.Rows[0][0].ToString();
        }
        #endregion

        #region ValidControl
        public void ValidButton(bool b)
        {
            btnCopyToLeftAll.Enabled = b;
            btnCopyToRightAll.Enabled = !b;
        }
        public void ValidButtonStart(bool b)
        {
            btnCopyToLeft.Enabled = b;
            btnCopyToLeftAll.Enabled = b;
            btnCopyToRight.Enabled = b;
            btnCopyToRightAll.Enabled = b;

        }
        #endregion

        #region Data For Copy
        // get tables copy
        public DataTable GetDataForCopy(DataTable dtLeft, DataTable dtRight)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("TABLE_NAME", typeof(string));
            foreach (DataRow drLeft in dtLeft.Rows)
            {
                string nameLeft = drLeft["Name"].ToString();
                //DataRow[] myResultR = dtRight.Select();
                DataRow[] drRow = dtRight.Select("Name ='" + nameLeft + "'");

                if (drRow == null || drRow.Length <= 0)
                {
                    DataRow dr = dt.NewRow();
                    dr["TABLE_NAME"] = drLeft["Name"].ToString();
                    dt.Rows.Add(dr);
                }
            }
            return dt;
        }
        public void CopyAll(DataTable dt, string connectionSource, string connectionDestination)
        {
            foreach (DataRow dr in dt.Rows)
            {
                string commandScript = GetScriptTable(connectionSource, dr["TABLE_NAME"].ToString());
                try
                {
                    SqlConnection source = new SqlConnection(connectionDestination);
                    source.Open();
                    SqlCommand cmd = new SqlCommand(commandScript, source);
                    cmd.ExecuteNonQuery();
                    source.Close();
                    cmd.Dispose();
                }
                catch (Exception ex)
                {
                    return;
                }
            }
        }
        #endregion

        #region Event
        private void frmCompareTree_Load(object sender, EventArgs e)
        {
            LoadTree(trvDBLeft, connectionStringLeft, LEFT);
            LoadTree(trvDBRight, connectionStringRight, RIGHT);
            ValidButtonStart(false);
        }
       

        private void trvDBLeft_AfterSelect(object sender, TreeViewEventArgs e)
        {
            try
            {
                ClearBackColor(trvDBRight);
                ClearBackColor(trvDBLeft);
                TreeView trv = (TreeView)sender;
                TreeNode nodeSelect = e.Node;
                string tag = nodeSelect.Tag.ToString();
                TreeNode node = FindByTag(trvDBRight, tag);

                m_NodeLeft = nodeSelect;// trvDBLeft.SelectedNode;
                btnCopyToLeft.Enabled = false;
                btnCopyToRight.Enabled = false;
                if (m_NodeLeft != null && m_NodeLeft.Text != ""
                    && m_NodeLeft.Tag.ToString() != "Root"
                    && m_NodeLeft.Tag.ToString() != "Tables"
                    && m_NodeLeft.Tag.ToString() != "Stored Procedures"
                    && m_NodeLeft.Tag.ToString() != "Triggers"
                    && m_NodeLeft.ForeColor == Color.Blue
                    &&m_NodeLeft.Tag.ToString().Substring(0, 4) != "Proc"
                        && m_NodeLeft.Tag.ToString().Substring(0, 4) != "Trig"
                        && m_NodeLeft.Tag.ToString().Substring(0, 4) != "Colu")
                {
                    btnCopyToRight.Enabled = true;
                }
                // lay du lieu tables do vao luoi
                grdProperties.DataSource = null;
                txtScripts.Text = "";
                if (m_NodeLeft != null && m_NodeLeft.Text != ""
                    && m_NodeLeft.Tag.ToString() != "Root"
                    && m_NodeLeft.Tag.ToString() != "Tables"
                    && m_NodeLeft.Tag.ToString() != "Stored Procedures"
                    && m_NodeLeft.Tag.ToString() != "Triggers")
                {
                    SqlConnection conn = new SqlConnection(connectionStringLeft);
                    string SQL = "SELECT COLUMN_NAME,DATA_TYPE,CHARACTER_MAXIMUM_LENGTH,IS_NULLABLE  FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = '"
                        + m_NodeLeft.Text + "'";
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(SQL, conn);
                    DataTable dtProperties = new DataTable();
                    sqlDataAdapter.Fill(dtProperties);
                    grdProperties.DataSource = dtProperties;
                    // lay script table
                    if (m_NodeLeft.Tag.ToString().Substring(0, 4) != "Proc"
                        && m_NodeLeft.Tag.ToString().Substring(0, 4) != "Trig"
                        && m_NodeLeft.Tag.ToString().Substring(0, 4) != "Colu")
                    {
                        txtScripts.Text = GetScriptTable(connectionStringLeft, m_NodeLeft.Text);
                    }
                }
               

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void trvDBRight_AfterSelect(object sender, TreeViewEventArgs e)
        {
            try
            {
                ClearBackColor(trvDBRight);
                ClearBackColor(trvDBLeft);
                TreeView trv = (TreeView)sender;
                TreeNode nodeSelect = e.Node;
                string tag = nodeSelect.Tag.ToString();
                TreeNode node = FindByTag(trvDBLeft, tag);


                m_NodeRight = trvDBRight.SelectedNode;
                btnCopyToLeft.Enabled = false;
                btnCopyToRight.Enabled = false;
                if (m_NodeRight != null && m_NodeRight.Text != ""
                    && m_NodeRight.Tag.ToString() != "Root"
                    && m_NodeRight.Tag.ToString() != "Tables"
                    && m_NodeRight.Tag.ToString() != "Stored Procedures"
                    && m_NodeRight.Tag.ToString() != "Triggers"
                    && m_NodeRight.ForeColor == Color.Blue
                    && m_NodeRight.Tag.ToString().Substring(0, 4) != "Proc"
                        && m_NodeRight.Tag.ToString().Substring(0, 4) != "Trig"
                        && m_NodeRight.Tag.ToString().Substring(0, 4) != "Colu")
                {
                    btnCopyToLeft.Enabled = true;
                }
                // lay du lieu tables do vao luoi
                grdProperties.DataSource = null;
                txtScripts.Text = "";
                if (m_NodeRight != null && m_NodeRight.Text != ""
                    && m_NodeRight.Tag.ToString() != "Root"
                    && m_NodeRight.Tag.ToString() != "Tables"
                    && m_NodeRight.Tag.ToString() != "Stored Procedures"
                    && m_NodeRight.Tag.ToString() != "Triggers")
                {
                    SqlConnection conn = new SqlConnection(connectionStringRight);
                    string SQL = "SELECT COLUMN_NAME,DATA_TYPE,CHARACTER_MAXIMUM_LENGTH,IS_NULLABLE  FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = '"
                        + m_NodeRight.Text + "'";
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(SQL, conn);
                    DataTable dtProperties = new DataTable();
                    sqlDataAdapter.Fill(dtProperties);
                    grdProperties.DataSource = dtProperties;

                    // lay script table
                    if (m_NodeRight.Tag.ToString().Substring(0, 4) != "Proc"
                        && m_NodeRight.Tag.ToString().Substring(0, 4) != "Trig"
                        && m_NodeRight.Tag.ToString().Substring(0, 4) != "Colu")
                    {
                        txtScripts.Text = GetScriptTable(connectionStringRight, m_NodeRight.Text);
                    }
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void trvDBLeft_AfterExpand(object sender, TreeViewEventArgs e)
        {
            try
            {
                
                TreeNode nodeSelect = e.Node;
                string tag = nodeSelect.Tag.ToString();
                TreeNode node = FindByTag(trvDBRight, tag);
                if (node != null)
                {
                    node.Expand();
                }
                trvDBLeft_AfterSelect(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void trvDBRight_AfterExpand(object sender, TreeViewEventArgs e)
        {
            try
            {
                TreeNode nodeSelect = e.Node;
                string tag = nodeSelect.Tag.ToString();
                TreeNode node = FindByTag(trvDBLeft, tag);
                if (node != null)
                {
                    node.Expand();
                }
                trvDBRight_AfterSelect(sender, e);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void trvDBLeft_AfterCollapse(object sender, TreeViewEventArgs e)
        {
            try
            {
                TreeNode nodeSelect = e.Node;
                string tag = nodeSelect.Tag.ToString();
                TreeNode node = FindByTag(trvDBRight, tag);
                if (node != null)
                {
                    node.Collapse();
                }
                trvDBLeft_AfterSelect(sender, e);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void trvDBRight_AfterCollapse(object sender, TreeViewEventArgs e)
        {
            try
            {
                TreeNode nodeSelect = e.Node;
                string tag = nodeSelect.Tag.ToString();
                TreeNode node = FindByTag(trvDBLeft, tag);
                if (node != null)
                {
                    node.Collapse();
                }
                trvDBRight_AfterSelect(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void trvDBLeft_Click(object sender, EventArgs e)
        {
            try
            {
                ValidButton(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void trvDBRight_Click(object sender, EventArgs e)
        {
            try
            {
                ValidButton(true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // copy left to right All
        private void btnCopyToRightAll_Click(object sender, EventArgs e)
        {
            try
            {
                // get difference tables
                DataTable dt = new DataTable();
                dt = GetDataForCopy(GetTables(connectionStringLeft),GetTables(connectionStringRight));
                // excute copy
                CopyAll(dt, connectionStringLeft, connectionStringRight);
                trvDBLeft.Nodes.Clear();
                trvDBRight.Nodes.Clear();
                frmCompareTree_Load(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        

        // copy left to right
        private void btnCopyToRight_Click(object sender, EventArgs e)
        {
            try
            {
                string tableName = m_NodeLeft.Text;
                //get script dbleft
                string commandScript = GetScriptTable(connectionStringLeft, tableName);
                // excute dbright
                SqlConnection source = new SqlConnection(connectionStringRight);
                MessageBox.Show("Table was copy!!");
                source.Open();
                
                SqlCommand cmd = new SqlCommand(commandScript, source);
                cmd.ExecuteNonQuery();
                source.Close();
                cmd.Dispose();
                // Load data
                trvDBLeft.Nodes.Clear();
                trvDBRight.Nodes.Clear();
                frmCompareTree_Load(null, null);
                //m_NodeLeft = FindByTag(trvDBLeft, m_NodeLeft.Tag.ToString());

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // copy right to left
        private void btnCopyToLeft_Click(object sender, EventArgs e)
        {
            try
            {
                string tableName = m_NodeRight.Text;
                //get script dbleft
                string commandScript = GetScriptTable(connectionStringRight, tableName);
                // excute dbright
                SqlConnection source = new SqlConnection(connectionStringLeft);
                MessageBox.Show("Table was copy!!");
                source.Open();
                SqlCommand cmd = new SqlCommand(commandScript, source);
                cmd.ExecuteNonQuery();
                source.Close();
                cmd.Dispose();
                // Load data
                trvDBLeft.Nodes.Clear();
                trvDBRight.Nodes.Clear();
                frmCompareTree_Load(null, null);
                //m_NodeLeft = FindByTag(trvDBLeft, m_NodeLeft.Tag.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // copy right to left All
        private void btnCopyToLeftAll_Click(object sender, EventArgs e)
        {
            try
            {
                // get difference tables
                DataTable dt = new DataTable();
                dt = GetDataForCopy(GetTables(connectionStringRight), GetTables(connectionStringLeft));
                // excute copy
                CopyAll(dt, connectionStringRight, connectionStringLeft);
                trvDBLeft.Nodes.Clear();
                trvDBRight.Nodes.Clear();
                frmCompareTree_Load(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion

    }
}




