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
        SystemRFIDsEntities Context;
        public Tables()
        {
            InitializeComponent();
        }

        private void Tables_Load(object sender, EventArgs e)
        {
            Context = new SystemRFIDsEntities();
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
            using (EditForms.FormEditCarsRFID frmCarsRFID=new EditForms.FormEditCarsRFID(null))
            {
                if (frmCarsRFID.ShowDialog()==DialogResult.OK)
                {
                    carscRFIDBindingSource.DataSource = Context.cars_c_RFID.ToList();
                }
            }
        }

        private void BtnEditCarsRFID_Click(object sender, EventArgs e)
        {
            if (carscRFIDBindingSource.Current == null)
            {
                return;
            }
            using (EditForms.FormEditCarsRFID frmCarsRFID = new EditForms.FormEditCarsRFID(carscRFIDBindingSource.Current as cars_c_RFID))
            {
                if (frmCarsRFID.ShowDialog() == DialogResult.OK)
                {
                    carscRFIDBindingSource.DataSource = Context.cars_c_RFID.ToList();
                }
            }
        }

        private void BtnDeleteCarsRFID_Click(object sender, EventArgs e)
        {
            if (carscRFIDBindingSource.Current != null)
            {
                if (MessageBox.Show("Удалить эту запись?", "Сообщение", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Context.cars_c_RFID.Remove(carscRFIDBindingSource.Current as cars_c_RFID);
                    carscRFIDBindingSource.RemoveCurrent();
                    Context.SaveChanges();
                }
            }
        }
    }
}
