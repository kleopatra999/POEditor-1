using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace POEditor
{
    public partial class FormProjects : Form
    {
        Project project;

        public FormProjects ()
        {
            InitializeComponent ();
        }

        private void FormProjects_Load (object sender, EventArgs e)
        {
            project = new Project ();

            project = Project.Load ("D:\\test.poe");

            Project.Save (project, "D:\\test.poe");
        }
    }
}
