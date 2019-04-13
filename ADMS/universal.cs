using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADMS
{
    public partial class universal : MetroForm
    {
        private Form universalForm = new Form();
        public Form getForm
        {
            get { return universalForm; }
            set { universalForm = value; }
        }
        public universal()
        {
            InitializeComponent();
        }

        private void universal_Load(object sender, EventArgs e)
        {

        }

        private void selectionPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void jobseekButton_Click(object sender, EventArgs e)
        {
            jobSeeker jb = new jobSeeker();
            jb.ShowDialog();
        }

        private void portalModarator_Click(object sender, EventArgs e)
        {
            PM pm = new PM();
            pm.ShowDialog();
        }

        private void empButton_Click(object sender, EventArgs e)
        {
            emp em = new emp();
            em.ShowDialog();

        }
    }
}
