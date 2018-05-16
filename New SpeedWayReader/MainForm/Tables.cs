using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataModel;

namespace MainForm
{
    public partial class Tables : Form
    {
        SystemRFIDsEntities Context = new SystemRFIDsEntities();
        public Tables()
        {
            InitializeComponent();
        }

        private void Tables_Load(object sender, EventArgs e)
        {
            historyvisitBindingSource.DataSource = Context.history_visit.ToList();
            carscRFIDBindingSource.DataSource = Context.cars_c_RFID.ToList();
            statusactiveBindingSource.DataSource = Context.status_active.ToList();
            carsBindingSource.DataSource = Context.cars.ToList();
            typecarBindingSource.DataSource = Context.type_car.ToList();
            rFIDmetkiBindingSource.DataSource = Context.RFID_metki.ToList();
            listaccessBindingSource.DataSource = Context.list_access.ToList();
            chauffeursBindingSource.DataSource = Context.chauffeurs.ToList();
        }

        private void BtnAddCarsRFID_Click(object sender, EventArgs e)
        {

        }

        private void BtnEditCarsRFID_Click(object sender, EventArgs e)
        {

        }

        private void BtnDeleteCarsRFID_Click(object sender, EventArgs e)
        {

        }
    }
}
