using System;
using System.Linq;
using System.Windows.Forms;
using TodooLogic;

namespace Todoo
{
    public partial class Todoo : Form
    {
        public Todoo()
        {
            InitializeComponent();
            checkCurrentTodoos();
        }

        DataHandling dataHandling = new DataHandling();

        private void btnAddNewTodoo_Click(object sender, EventArgs e)
        {
            dataHandling.addTodoo(dtPicker.Value, rtbTodoo.Text);
            dtPicker.Text = null;
            rtbTodoo.Clear();
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
            var nextUp = dataHandling.findAllUpNext();
            var formNextUpOpen = false;

            if (nextUp.Count > 0)
            {

                FormCollection fc = Application.OpenForms;

                foreach (Form frm in fc)
                {
                    if (frm.Name == "UpNext")
                    {
                        formNextUpOpen = true;
                    }
                }

                if (!formNextUpOpen)
                {
                    var formNextUp = new UpNext(nextUp);
                    formNextUp.Show();
                }
            }
        }

        private void Todoo_Load(object sender, EventArgs e)
        {

        }
    }
}
