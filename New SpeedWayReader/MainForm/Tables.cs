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
            Context.cars_c_RFID.Add(carscRFIDBindingSource.AddNew() as cars_c_RFID);
            ViewCarsRFID.CurrentRow.Cells[1].Selected = true;
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

        private void Tables_FormClosing(object sender, FormClosingEventArgs e)
        {
            Context.SaveChanges();
        }

        private void BtnAddChauffeur_Click(object sender, EventArgs e)
        {
            Context.chauffeurs.Add(chauffeursBindingSource.AddNew() as chauffeurs);
            ViewChauffeurs.CurrentRow.Cells[1].Selected = true;
        }

        private void BtnDeleteChauffeur_Click(object sender, EventArgs e)
        {
            if (chauffeursBindingSource.Current != null)
            {
                if (MessageBox.Show("Удалить эту запись?", "Сообщение", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Context.chauffeurs.Remove(chauffeursBindingSource.Current as chauffeurs);
                    chauffeursBindingSource.RemoveCurrent();
                    Context.SaveChanges();
                }
            }
        }

        private void BtnAddCars_Click(object sender, EventArgs e)
        {
            Context.cars.Add(carsBindingSource.AddNew() as cars);
            ViewCars.CurrentRow.Cells[1].Selected = true;
        }

        private void BtnDeleteCars_Click(object sender, EventArgs e)
        {
            if (carsBindingSource.Current != null)
            {
                if (MessageBox.Show("Удалить эту запись?", "Сообщение", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Context.cars.Remove(carsBindingSource.Current as cars);
                    carsBindingSource.RemoveCurrent();
                    Context.SaveChanges();
                }
            }
        }

        private void BtnAddTypeCar_Click(object sender, EventArgs e)
        {
            Context.type_car.Add(typecarBindingSource.AddNew() as type_car);
            ViewTypeCar.CurrentRow.Cells[1].Selected = true;
        }

        private void BtnDeleteTypeCar_Click(object sender, EventArgs e)
        {
            if (typecarBindingSource.Current != null)
            {
                if (MessageBox.Show("Удалить эту запись?", "Сообщение", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Context.type_car.Remove(typecarBindingSource.Current as type_car);
                    typecarBindingSource.RemoveCurrent();
                    Context.SaveChanges();
                }
            }
        }

        private void BtnAddStatusActive_Click(object sender, EventArgs e)
        {
            Context.status_active.Add(statusactiveBindingSource.AddNew() as status_active);
            ViewStatusActive.CurrentRow.Cells[1].Selected = true;
        }

        private void BtnDeleteStatusActive_Click(object sender, EventArgs e)
        {
            if (statusactiveBindingSource.Current != null)
            {
                if (MessageBox.Show("Удалить эту запись?", "Сообщение", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Context.status_active.Remove(statusactiveBindingSource.Current as status_active);
                    statusactiveBindingSource.RemoveCurrent();
                    Context.SaveChanges();
                }
            }
        }

        private void BtnAddRFIDMetka_Click(object sender, EventArgs e)
        {
            Context.RFID_metki.Add(rFIDmetkiBindingSource.AddNew() as RFID_metki);
            ViewRFID.CurrentRow.Cells[1].Selected = true;
        }

        private void BtnAddListAccess_Click(object sender, EventArgs e)
        {
            Context.list_access.Add(listaccessBindingSource.AddNew() as list_access);
            ViewListAccess.CurrentRow.Cells[1].Selected = true;
        }

        private void BtnDeleteRFIDMetka_Click(object sender, EventArgs e)
        {
            if (rFIDmetkiBindingSource.Current != null)
            {
                if (MessageBox.Show("Удалить эту запись?", "Сообщение", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Context.RFID_metki.Remove(rFIDmetkiBindingSource.Current as RFID_metki);
                    rFIDmetkiBindingSource.RemoveCurrent();
                    Context.SaveChanges();
                }
            }
        }

        private void BtnDeleteListAccess_Click(object sender, EventArgs e)
        {
            if (listaccessBindingSource.Current != null)
            {
                if (MessageBox.Show("Удалить эту запись?", "Сообщение", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Context.list_access.Remove(listaccessBindingSource.Current as list_access);
                    listaccessBindingSource.RemoveCurrent();
                    Context.SaveChanges();
                }
            }
        }

        private void BoxSearchHistoryVisit_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
