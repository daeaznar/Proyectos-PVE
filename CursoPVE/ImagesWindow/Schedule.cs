using ImagesWindow.Data;
using ImagesWindow.DataOperations;
using System;
using System.Drawing;
using System.Windows.Forms;
using Tools;

namespace ImagesWindow
{
    public partial class Schedule : Form
    {
        private EventManager manager;
        private long currentEvent;

        private ModelValidation<Event> validation;
        public Schedule()
        {
            manager = new EventManager();
            validation = new ModelValidation<Event>();
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

        //Delete records in DB
        private void dtgEvents_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenu contextMenu = new ContextMenu();
                var item = contextMenu.MenuItems.Add("Delete");
                item.Click += Item_Click;

                var index = dtgEvents.HitTest(e.X, e.Y).RowIndex;
                if (index > -1)
                {
                    currentEvent = Convert.ToInt64(dtgEvents[0, index].Value);
                    contextMenu.Show(dtgEvents, new Point(e.X, e.Y));
                }
                else
                {
                    MessageBox.Show("Please click one of the table rows");
                }
            }
        }

        private void Item_Click(object sender, EventArgs e)
        {
            try
            {
                var eventToDelete = new Data.Event()
                {
                    EventId = currentEvent
                };

                var errors = validation.Validate(eventToDelete);
                if (errors.Count > 0)
                {
                    foreach (var error in errors)
                    {
                       var temp = error.ErrorMessage;
                    }
                    MessageBox.Show("Event has invalid data");
                    return;
                }

                if (manager.Delete(eventToDelete))
                {
                    MessageBox.Show("Event deleted");
                    dtgEvents.DataSource = manager.Read();
                }
                else
                {
                    MessageBox.Show("Event couldn't be deleted. Please contact IT", "Error");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("An error occured while saving data. Please try again later", "Error");
            }
        }
    }
}
