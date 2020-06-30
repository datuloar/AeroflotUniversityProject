using System;
using System.Windows.Forms;
using AeroflotProjectUniversity.Scripts;

namespace AeroflotProjectUniversity
{
    public partial class AeroflotMainForm : Form
    {
        private AirplaneEdit _editAirplane;
        public AeroflotMainForm()
        {
            InitializeComponent();
        }

        private void AeroflotMainForm_Load(object sender, EventArgs e)
        {
            MessageBox.Show("University project by github datuloar");
            //System.Diagnostics.Process.Start("https://github.com/datuloar");
        }

        private void FillButton_Click(object sender, EventArgs e)
        {
            _editAirplane = new AirplaneEdit();
            listBox1.Items.Clear();
            listBox1.Items.AddRange(_editAirplane.GetListAirplanes());
            ClearListButton.Enabled = true;
        }

        private void ClearListButton_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            _editAirplane.ClearAirplanes();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                int index = listBox1.Items.IndexOf(listBox1.SelectedItem);
                if (MessageBox.Show(this, "String  " + listBox1.SelectedItem, "Delete?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    _editAirplane.RemoveAirplane(index);
                    listBox1.Items.Clear();
                    listBox1.Items.AddRange(_editAirplane.GetListAirplanes());
                }
            }
            else
            {
                MessageBox.Show(this, "A row is not selected for deletion!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (_editAirplane is BaseAirplane)
            {
                string destination = DestinationBox.Text.Trim();
                string flightNumber = FlightNumberBox.Text.ToUpper().Trim();
                string typeAirplane = TypeAirplaneBox.Text.Trim();
                string departureDate = maskedTextBox1.Text.Trim();

                if (destination == "" || flightNumber == "" || typeAirplane == "" || departureDate.Length != 10)
                {

                    MessageBox.Show(this, "There are no characters in the string", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string[] dateArray = departureDate.Split('.');
                int[] date = new int[3];

                for (int i = 0; i < date.Length; i++)
                {
                    date[i] = int.Parse(dateArray[i]);
                }

                if (_editAirplane.AddAirplane(destination, flightNumber, typeAirplane, date) < 0)
                {
                    listBox1.Items.Clear();
                    listBox1.Items.AddRange(_editAirplane.GetListAirplanes());
                    ClearListButton.Enabled = true;
                }
                else
                {
                    MessageBox.Show(this, "Re-entering data!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(this, "The list was not created", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SearchTypeAirplaneButton_Click(object sender, EventArgs e)
        {
            string typeAirplane = SearchTypeAirplaneBox.Text.Trim();
            if (_editAirplane is BaseAirplane)
            {
                if (_editAirplane.GetListByTypeAirplane(typeAirplane).Count != 0)
                {
                    MessageBox.Show(this, $"Type airplane {typeAirplane} was found", "FOUNDED!", MessageBoxButtons.OK, MessageBoxIcon.Question);

                    listBox1.Items.Clear();
                    listBox1.Items.AddRange(_editAirplane.GetListByTypeAirplane(typeAirplane).ToArray());
                }
                else
                {
                    MessageBox.Show(this, $"Type airplane {typeAirplane} was not found", "NOT FOUNDED!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(this, "The list was not created", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void OutList(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            if (radioButton1.Checked)
            {
                listBox1.Items.AddRange(_editAirplane.GetListByAirplanes(new AirplaneIComparerBase()));
            }
            else if (radioButton2.Checked)
            {
                listBox1.Items.AddRange(_editAirplane.GetListByAirplanes(new AirplaneIComparerDestination()));
            }
            else if (radioButton3.Checked)
            {
                listBox1.Items.AddRange(_editAirplane.GetListByAirplanes(new AirplaneIComparerTypeAirplane()));
            }
            else if (radioButton4.Checked)
            {
                listBox1.Items.AddRange(_editAirplane.GetListByAirplanes(new AirplaneIComparerDepartureDate()));
            }
        }
    }
}
