using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calender_Creator
{
    public partial class EditCalendarItem : Form
    {
        public EditCalendarItem()
        {
            InitializeComponent();
        }

        private void EditCalendarItem_Load(object sender, EventArgs e)
        {
            SetEverything();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void allDayCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            startsTimePanel.Visible = allDayCheckBox.Checked;
            endsTimePanel.Visible = allDayCheckBox.Checked;
        }

        void SetEverything()
        {
            startsTimePanel.Visible = allDayCheckBox.Checked;
            endsTimePanel.Visible = allDayCheckBox.Checked;
        }
    }
}
