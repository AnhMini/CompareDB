using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CompareDB
{
    public partial class MDIParent : Form
    {
        public MDIParent()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            frmNewComparision frm = new frmNewComparision();
            frm.ShowDialog();

            if (frm.DialogResult == DialogResult.OK)
            {
                // calculator time

                foreach (Form frmChild in this.MdiChildren)
                {
                    frmChild.Dispose();
                }
                
                // run compare
                // old form
                //frmCompareDB childForm = new frmCompareDB();
                // new form
                frmCompareTree childForm = new frmCompareTree();
                // Make it a child of this MDI form before showing it.
                childForm.ConnectionStringLeft = frm.ConnectionStringLeft;
                childForm.ConnectionStringRight = frm.ConnectionStringRight;
                childForm.MdiParent = this;
                childForm.WindowState = FormWindowState.Maximized;
                childForm.Show();
            }

        }
        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MDIParent_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized; 
            // run db form
            frmNewComparision frm = new frmNewComparision();
            frm.ShowDialog();

            if(frm.DialogResult == DialogResult.OK)
            {
                // old form
                //frmCompareDB childForm = new frmCompareDB();
                // new form
                frmCompareTree childForm = new frmCompareTree();
                // Make it a child of this MDI form before showing it.
                childForm.ConnectionStringLeft = frm.ConnectionStringLeft;
                childForm.ConnectionStringRight = frm.ConnectionStringRight;
                childForm.MdiParent = this;
                childForm.WindowState = FormWindowState.Maximized;
                childForm.Show();
            }
            
        }

       
    }
}
