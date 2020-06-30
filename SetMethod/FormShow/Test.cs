using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SetMethod.FormShow
{
    public partial class Test : Form
    {
        public Test()
        {
            InitializeComponent();
            var label=new Label()
            {
                Text = "Hello",
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.Fill
            };
            this.Controls.Add(label);
        }
    }
}
