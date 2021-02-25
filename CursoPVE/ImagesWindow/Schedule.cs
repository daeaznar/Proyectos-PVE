using ImagesWindow.DataOperations;
using System;
using System.Windows.Forms;

namespace ImagesWindow
{
    public partial class Schedule : Form
    {
        private EventManager manager;
        private long currentEvent;
        public Schedule()
        {
            manager = new EventManager();
            InitializeComponent();
            dtgEvents.DataSource = manager.Read();
            currentEvent = 0;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtSubject.Text))
                {
                    MessageBox.Show("Please enter a Subject");
                    return;
                }

                //Another way to save data to DB
                var eventCreated = new Data.Event()
                {
                    Subject = txtSubject.Text,
                    EventDate = dttEvent.Value  
                };
                //eventCreated
                if (manager.Create(eventCreated))
                {
                    MessageBox.Show("Event saved", "Success");
                    dtgEvents.DataSource = manager.Read();
                }
                else
                {
                    MessageBox.Show("Event couldn't be saved. Please contact IT", "Error");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("An error occure while saving data", "Error");
            }
        }

        private void dtgEvents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Verifys that clicked cell is not a header
            if (e.RowIndex > -1) 
            {
                currentEvent = Convert.ToInt64(dtgEvents[0, e.RowIndex].Value); //Saves and converts EventId into currentEvent
                txtSubject.Text = dtgEvents[1, e.RowIndex].Value.ToString();    //Saves and converts Subject 
                dttEvent.Value = Convert.ToDateTime(dtgEvents[2, e.RowIndex].Value);    //Saves and converts EventDate
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (currentEvent == 0)
                {
                    MessageBox.Show("Please select a record to update from the table");
                }
                if (string.IsNullOrEmpty(txtSubject.Text))
                {
                    MessageBox.Show("Please enter a Subject");
                    return;
                }

                //Another way to save data to DB
                var eventUpdated = new Data.Event()
                {
                    EventId = currentEvent,
                    Subject = txtSubject.Text,
                    EventDate = dttEvent.Value
                };

                //eventCreated
                if (manager.Update(eventUpdated))
                {
                    MessageBox.Show("Event saved", "Success");
                    dtgEvents.DataSource = manager.Read();
                }
                else
                {
                    MessageBox.Show("Event couldn't be saved. Please contact IT", "Error");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("An error occure while saving data", "Error");
            }
        }
    }
}
