namespace MDIWINDOWFORM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openFromOnesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Form2")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }
            //if (IsOpen == false)
            //{
            //    Form2.form2 = new Form2();
            //    form2.MdiParent = this;
            //    form2.show();
            //}
        }

        private void openFromMultipleTimesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.MdiParent = this;
            form3.Show();
        }

        private void closeAllFormsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form frm in this.MdiChildren)
            {
                if (!frm.Focused)
                {
                    frm.Visible = false;
                    frm.Dispose();
                }
            }
        }
    }
}