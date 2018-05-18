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
using Impinj.OctaneSdk;
using Org.LLRP.LTK.LLRPV1;
using Org.LLRP.LTK.LLRPV1.DataType;
using Org.LLRP.LTK.LLRPV1.Impinj;

namespace MainForm
{
    public partial class Main : Form
    {
        SystemRFIDsEntities Context;
        Settings fsettings = new Settings();
        private ImpinjReader reader = new ImpinjReader();
        static LLRPClient readerR = new LLRPClient();
        public Main()
        {
            InitializeComponent();
            Context = new SystemRFIDsEntities();
            try
            {
                // Подключение к считывателю.
                // Подключение по введенному IP или имени  считывателя
                reader.Connect("");
                if (reader.IsConnected)
                {
                    Random rand = new Random();
                    TimerTags.Interval = rand.Next(10000, 15000);
                    TimerTags.Enabled = true;
                    // Подготовка к считыванию
                    if (!reader.QueryStatus().IsSingulating)
                    {
                        // Старт считывания
                        reader.Start();
                        Add_RoSpec();
                        Enable_RoSpec();
                    }
                    //Вызов метода отображения информации с меток
                    reader.TagsReported += OnTagsReported;
                }
                else
                {
                    MessageBox.Show("Считыватель не подключен!", "Подключение...", MessageBoxButtons.OK);
                    TimerTags.Enabled = false;
                    Random rand = new Random();
                    TimerTags.Interval = rand.Next(10000, 15000);
                    fsettings.ShowDialog();
                    TimerTags.Enabled = true;
                }
            }
            catch (OctaneSdkException ex)
            {
                // Ошибка пакета Octane
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                // Ошибки программы
                MessageBox.Show(ex.Message);
            }
        }

        static void Delete_RoSpec()
        {
            MSG_DELETE_ROSPEC msg = new MSG_DELETE_ROSPEC();
            msg.ROSpecID = 0;
            MSG_ERROR_MESSAGE msg_err;

            MSG_DELETE_ROSPEC_RESPONSE rsp =
            readerR.DELETE_ROSPEC(msg, out msg_err, 2000);
        }

        static void Add_RoSpec()
        {
            MSG_ERROR_MESSAGE msg_err;
            MSG_ADD_ROSPEC msg = new MSG_ADD_ROSPEC();

            // Reader Operation Spec (ROSpec)
            msg.ROSpec = new PARAM_ROSpec();
            // ROSpec должен быть по умолчанию не доступен
            msg.ROSpec.CurrentState = ENUM_ROSpecState.Disabled;
            // The ROSpec ID может получить числовой ID
            msg.ROSpec.ROSpecID = 123;
            // ROBoundarySpec
            // Specifies the start and stop triggers for the ROSpec
            msg.ROSpec.ROBoundarySpec = new PARAM_ROBoundarySpec();
            // Immediate start trigger
            // The reader will start reading tags as soon as the ROSpec
            // is enabled
            msg.ROSpec.ROBoundarySpec.ROSpecStartTrigger =
               new PARAM_ROSpecStartTrigger();
            msg.ROSpec.ROBoundarySpec.ROSpecStartTrigger
               .ROSpecStartTriggerType = ENUM_ROSpecStartTriggerType.Immediate;

            // No stop trigger. Keep reading tags until the ROSpec is disabled.
            msg.ROSpec.ROBoundarySpec.ROSpecStopTrigger =
               new PARAM_ROSpecStopTrigger();
            msg.ROSpec.ROBoundarySpec.ROSpecStopTrigger.ROSpecStopTriggerType =
               ENUM_ROSpecStopTriggerType.Null;

            // Antenna Inventory Spec (AISpec)
            // Specifies which antennas and protocol to use
            msg.ROSpec.SpecParameter = new UNION_SpecParameter();
            PARAM_AISpec aiSpec = new PARAM_AISpec();
            aiSpec.AntennaIDs = new UInt16Array();
            // Enable all antennas
            aiSpec.AntennaIDs.Add(0);
            // No AISpec stop trigger. It stops when the ROSpec stops.
            aiSpec.AISpecStopTrigger = new PARAM_AISpecStopTrigger();
            aiSpec.AISpecStopTrigger.AISpecStopTriggerType =
               ENUM_AISpecStopTriggerType.Null;
            aiSpec.InventoryParameterSpec =
               new PARAM_InventoryParameterSpec[1];
            aiSpec.InventoryParameterSpec[0] =
               new PARAM_InventoryParameterSpec();
            aiSpec.InventoryParameterSpec[0].InventoryParameterSpecID = 1234;
            aiSpec.InventoryParameterSpec[0].ProtocolID =
               ENUM_AirProtocols.EPCGlobalClass1Gen2;
            msg.ROSpec.SpecParameter.Add(aiSpec);

            // Report Spec
            msg.ROSpec.ROReportSpec = new PARAM_ROReportSpec();
            // Send a report for every tag read
            msg.ROSpec.ROReportSpec.ROReportTrigger =
               ENUM_ROReportTriggerType.Upon_N_Tags_Or_End_Of_ROSpec;
            msg.ROSpec.ROReportSpec.N = 1;
            msg.ROSpec.ROReportSpec.TagReportContentSelector =
               new PARAM_TagReportContentSelector();

            MSG_ADD_ROSPEC_RESPONSE rsp =
               readerR.ADD_ROSPEC(msg, out msg_err, 2000);
        }

        static void Enable_RoSpec()
        {
            MSG_ERROR_MESSAGE msg_err;
            MSG_ENABLE_ROSPEC msg = new MSG_ENABLE_ROSPEC();
            msg.ROSpecID = 1111;
            MSG_ENABLE_ROSPEC_RESPONSE rsp =
            readerR.ENABLE_ROSPEC(msg, out msg_err, 2000);
        }

        private void UpdateListbox(List<Tag> list)
        {
            // Вставка информации о метке в текущее время
            DateTime now = DateTime.Now;

            foreach (var tag in list)
            {
                //ListTags.Items.Add(ListTags.Items.Count + ") EPC: " + tag.Epc + "\n   Номер антенны: " + tag.AntennaPortNumber + "\n   Дата и время: " + now);
            }

        }

        private void OnTagsReported(ImpinjReader sender, TagReport report)
        {
            // Это событие которое обнавляет информацию в ListBox со считывателя во время считывания.
            //Action action = delegate()(снять)
            //{(снять)
            //    UpdateListbox(report.Tags);(снять)
            //};(снять)
            //Dispatcher.BeginInvoke(System.Windows.Threading.DispatcherPriority.Normal, action);(снять)
        }

        private void UpdateListah()
        {
            DateTime now = DateTime.Now;
            Random Ran = new Random();
            int car = Ran.Next(1, 4);
            string carT = "а" + Ran.Next(0, 10) + Ran.Next(0, 10) + Ran.Next(0, 10) + "бв";
            int AntennaPortNumber = Ran.Next(1, 3);
            bool visit = new bool();
            visit = Convert.ToBoolean(Ran.Next(0, 2));
            string avisit;
            if (visit == true) avisit = "Разрешено";
            else avisit = "Не разрешено";
            string tvisit;
            if (AntennaPortNumber == 1) tvisit = "Въезд";
            else tvisit = "Выезд";
            ViewHistory.Focus();
            ViewHistory.Rows.Add(now, carT, tvisit, avisit);
            //BoxNumberCar.Text = ViewHistory.CurrentRow.Cells[number_car.Index].Value.ToString();
            //ListTags.Items.Add(counter + ") Дата и время: " + now + "\n   Номер антенны: " + AntennaPortNumber);
            //ListTags.Items.Add("\n   EPC: " + Epc + "\n   № машины: " + machine + "\n   Тип проезда: " + tvisit + "\n   Доступ: " + avisit);
            if (visit == false)
            {
                if (AntennaPortNumber == 1)
                {
                    MessageBox.Show("Машине на проезде въезд запрещен!!!");
                }
                else
                {
                    MessageBox.Show("Машине на проезде выезд запрещен!!!");
                }

            }
        }

        private void TimerTags_Tick(object sender, EventArgs e)
        {
            UpdateListah();
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            TimerTags.Enabled = false;
            try
            {
                var result = MessageBox.Show("Вы точно хотите выйти?", "Выход из программы", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    e.Cancel = false;
                }
                else if (result == DialogResult.No)
                {
                    e.Cancel = true;
                }
                // Отключение считывания считывателя
                if (reader.QueryStatus().IsSingulating)
                {
                    Delete_RoSpec();
                    reader.Stop();
                }
                if (reader.IsConnected)
                {
                    try
                    {
                        // Отключение считывания считывателя
                        if (reader.QueryStatus().IsSingulating)
                        {
                               Delete_RoSpec();
                                reader.Stop();
                        }
                       // Отсоединение от считывателя
                       reader.Disconnect();
                    }
                    catch (OctaneSdkException ex)
                    {
                        // Ошибки пакета Octane
                        MessageBox.Show(ex.Message);
                    }
                    catch (Exception ex)
                    {
                        // Ошибки программы
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            catch (OctaneSdkException ex)
            {
                // Ошибки пакета Octane
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                // Ошибки программы
                MessageBox.Show(ex.Message);
            }
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void ViewHistory_MouseClick(object sender, MouseEventArgs e)
        {
            BoxNumberCar.Text = ViewHistory.CurrentRow.Cells[1].Value.ToString();
        }

        private void BtnSettings_Click(object sender, EventArgs e)
        {
            TimerTags.Enabled = false;
            fsettings.ShowDialog();
            TimerTags.Enabled = true;
        }
    }
}
