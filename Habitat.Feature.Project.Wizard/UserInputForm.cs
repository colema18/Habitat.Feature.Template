using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Habitat.Feature.Project.Wizard
{
    public partial class UserInputForm : Form
    {
        public string FeatureName { get; set; }

        public UserInputForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FeatureName = textBox1.Text;
            this.Dispose();
        }

    }
}
