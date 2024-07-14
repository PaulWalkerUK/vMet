using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vMet
{
    public partial class AirportDialog : Form
    {
        public string Icao { get; private set; }

        public AirportDialog(List<Airport> airports, Airport currentAirport )
        {
            InitializeComponent();
            List<Airport> listAirports = new List<Airport>();

            if (currentAirport ==null)
            {
                Airport blankAirport = new Airport("","", 0, 0, 0, null);
                listAirports.Add(blankAirport);
            }
            listAirports.AddRange(airports);

            airportComboBox.DataSource = listAirports;
            airportComboBox.DisplayMember = "FullIcaoName";
            airportComboBox.ValueMember = "Icao";

            if (currentAirport != null)
            {
                airportComboBox.SelectedValue = currentAirport.Icao;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Icao = airportComboBox.SelectedValue as string;

            if (!string.IsNullOrEmpty(Icao) )
            {
                DialogResult = DialogResult.OK;
            }
        }
    }
}
