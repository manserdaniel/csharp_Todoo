using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TodooData;
using TodooLogic;

namespace Todoo
{
    public partial class UpNext : Form
    {
        List<todoo> todoos = new List<todoo>();
        DataHandling dataHandling = new DataHandling();

        public UpNext()
        {
            InitializeComponent();
        }

        public UpNext(List<todoo> nextTodoos)
        {
            InitializeComponent();
            checkCurrentTodoos();
            todoos = nextTodoos;
        }

        private void updateList()
        {
            lboxUpNext.Text = "";
            lboxUpNextDate.Text = "";
            todoos = dataHandling.findAllUpNext();
            lboxUpNext.DataSource = todoos.Select(todoo => todoo.text).ToList();
            lboxUpNextDate.DataSource = todoos.Select(todoo => todoo.date).ToList();
        }

        public void checkCurrentTodoos()
        {
            var timerToCheck = new Timer();
            timerToCheck.Interval = 1000;
            timerToCheck.Tick += onTimerEvent;
            timerToCheck.Start();
        }

        private void onTimerEvent(Object source, EventArgs e)
        {
            updateList();
        }

        private void btnSaveDone_Click(object sender, EventArgs e)
        {
            List<Boolean> checkBoxes = new List<Boolean>() { cboxDone1.Checked, cboxDone2.Checked, cboxDone3.Checked, cboxDone4.Checked, cboxDone5.Checked,
                                                             cboxDone6.Checked, cboxDone7.Checked, cboxDone8.Checked, cboxDone9.Checked, cboxDone10.Checked };
            dataHandling.deleteTodoo(checkBoxes);
        }

    }
}
