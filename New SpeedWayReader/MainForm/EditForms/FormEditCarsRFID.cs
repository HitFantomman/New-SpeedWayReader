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

namespace MainForm.EditForms
{
    public partial class FormEditCarsRFID : Form
    {
        SystemRFIDsEntities Context = new SystemRFIDsEntities();
        public FormEditCarsRFID(cars_c_RFID obj)
        {
            InitializeComponent();
            if (obj == null)
            {
                carscRFIDBindingSource.DataSource = new cars_c_RFID();
                Context.cars_c_RFID.Add(carscRFIDBindingSource.Current as cars_c_RFID);
            }
            else
            {
                carscRFIDBindingSource.DataSource = obj;
                Context.cars_c_RFID.Attach(carscRFIDBindingSource.Current as cars_c_RFID);
            }
        }
    }
}
