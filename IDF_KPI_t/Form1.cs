using IDF_KPI_t.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zuby.ADGV;

namespace IDF_KPI_t
{
    public partial class FormMain : Form
    {
        Boolean EditedNotSaved = false;
        public FormMain()
        {
            InitializeComponent();

        }



        private void Form1_Load(object sender, EventArgs e)
        {
            RestoreState();
            LoadDataTables();
            LoadAutoRowAddMode();
            //this.pF_CategoryQuotaDataGridView.CellValueChanged+=new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_CellValueChanged);
            //this.pF_PassTrafficFactDataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_CellValueChanged);


        }

        private void LoadAutoRowAddMode()
        {

            pF_CategoryQuotaDataGridView.AllowUserToAddRows = Properties.Settings.Default.UserCanAddRow;
            pF_CurrencyRateDataGridView.AllowUserToAddRows = Properties.Settings.Default.UserCanAddRow;
            pF_KPIDataGridView.AllowUserToAddRows = Properties.Settings.Default.UserCanAddRow;
            pF_PassTrafficFactDataGridView.AllowUserToAddRows = Properties.Settings.Default.UserCanAddRow;
            pF_StoreDateActiveDataGridView.AllowUserToAddRows = Properties.Settings.Default.UserCanAddRow;
            pF_PassTrafficDataGridView.AllowUserToAddRows = Properties.Settings.Default.UserCanAddRow;
            tsbAutoRowAddMode.Checked = Properties.Settings.Default.UserCanAddRow;
            if (tsbAutoRowAddMode.Checked)
            { tsbAutoRowAddMode.BackColor = Color.PaleGreen; }
            else
            { tsbAutoRowAddMode.BackColor = Color.LightGray; }

        }

        private void SaveAutoRowAddMode()
        {
            Properties.Settings.Default.UserCanAddRow = tsbAutoRowAddMode.Checked;
            pF_CategoryQuotaDataGridView.AllowUserToAddRows = Properties.Settings.Default.UserCanAddRow;
            pF_CurrencyRateDataGridView.AllowUserToAddRows = Properties.Settings.Default.UserCanAddRow;
            pF_KPIDataGridView.AllowUserToAddRows = Properties.Settings.Default.UserCanAddRow;
            pF_PassTrafficFactDataGridView.AllowUserToAddRows = Properties.Settings.Default.UserCanAddRow;
            pF_StoreDateActiveDataGridView.AllowUserToAddRows = Properties.Settings.Default.UserCanAddRow;
            pF_PassTrafficDataGridView.AllowUserToAddRows = Properties.Settings.Default.UserCanAddRow;
            tsbAutoRowAddMode.Checked = Properties.Settings.Default.UserCanAddRow;
            if (tsbAutoRowAddMode.Checked)
            { tsbAutoRowAddMode.BackColor = Color.PaleGreen; }
            else
            { tsbAutoRowAddMode.BackColor = Color.LightGray; }

        }

        private void LoadDataTables()
        {
            // TODO: This line of code loads data into the 'iDF_OUTDataSet1.PF_Category' table. You can move, or remove it, as needed.
            this.pF_CategoryTableAdapter.Fill(this.iDF_OUTDataSet1.PF_Category);
            // TODO: This line of code loads data into the 'iDF_OUTDataSet.PF_PassTraffic' table. You can move, or remove it, as needed.
            this.pF_PassTrafficTableAdapter.Fill(this.iDF_OUTDataSet.PF_PassTraffic);
            // TODO: This line of code loads data into the 'iDF_OUTDataSet.PF_CurrencyRate' table. You can move, or remove it, as needed.
            this.pF_CurrencyRateTableAdapter.Fill(this.iDF_OUTDataSet.PF_CurrencyRate);
            // TODO: This line of code loads data into the 'iDF_OUTDataSet.PF_CategoryQuota' table. You can move, or remove it, as needed.
            this.pF_CategoryQuotaTableAdapter.Fill(this.iDF_OUTDataSet.PF_CategoryQuota);
            // TODO: This line of code loads data into the 'iDF_OUTDataSet.PF_KPI' table. You can move, or remove it, as needed.
            this.pF_KPITableAdapter.Fill(this.iDF_OUTDataSet.PF_KPI);
            // TODO: This line of code loads data into the 'iDF_OUTDataSet.PF_StoreDateActive' table. You can move, or remove it, as needed.
            this.pF_StoreDateActiveTableAdapter.Fill(this.iDF_OUTDataSet.PF_StoreDateActive);
            // TODO: This line of code loads data into the 'iDF_OUTDataSet.PF_PassTrafficFact' table. You can move, or remove it, as needed.
            this.pF_PassTrafficFactTableAdapter.Fill(this.iDF_OUTDataSet.PF_PassTrafficFact);
            EditedNotSaved = false;
        }

        private void pF_PassTrafficDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            // If the data source raises an exception when a cell value is 
            // commited, display an error message.
            if (e.Exception != null &&
                e.Context == DataGridViewDataErrorContexts.Commit)
            {
                //MessageBox.Show("CustomerID value must be unique.");
            }
        }


        private void SaveItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Сохранить изменения?", "Сохранение", MessageBoxButtons.YesNo)
                == System.Windows.Forms.DialogResult.Yes)
            {
                this.Validate();
                this.pF_PassTrafficBindingSource.EndEdit();
                this.pF_PassTrafficFactBindingSource.EndEdit();
                this.pF_StoreDateActiveBindingSource.EndEdit();
                this.pF_KPIBindingSource.EndEdit();
                this.pF_CurrencyRateBindingSource.EndEdit();
                this.pF_CategoryQuotaBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.iDF_OUTDataSet);
                EditedNotSaved = false;
            }

        }

        private void DataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            EditedNotSaved = true;
        }


        private void dataGridView_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (pF_PassTrafficFactDataGridView.CurrentCell.ColumnIndex == 0 && e.Control is DateTimePicker)
            {
                DateTimePicker dtp = e.Control as DateTimePicker;
                dtp.ValueChanged += DateTimeSelectionChanged;
            }
        }

        private void DateTimeSelectionChanged(object sender, EventArgs e)
        {
            var currentcell = pF_PassTrafficFactDataGridView.CurrentCellAddress;
            var sendingCB = sender as CalendarEditingControl;

            pF_PassTrafficFactDataGridView.Rows[currentcell.Y].Cells[1].Value =

               (Convert.ToDateTime(sendingCB.EditingControlFormattedValue.ToString()).Month);

            pF_PassTrafficFactDataGridView.Rows[currentcell.Y].Cells[2].Value =

                (Convert.ToDateTime(sendingCB.EditingControlFormattedValue.ToString()).Year);

            pF_PassTrafficFactDataGridView.CurrentCell = pF_PassTrafficFactDataGridView.Rows[currentcell.Y].Cells[3];
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveState();
            if (EditedNotSaved)
            {
                e.Cancel = true;
                if (MessageBox.Show("Есть несохраненные изменения! Все равно закрыть?", "Внимание!", MessageBoxButtons.YesNo)
                == System.Windows.Forms.DialogResult.Yes)
                {
                    e.Cancel = false;
                }
            }

        }

        private void SaveState()
        {
            if (WindowState == FormWindowState.Maximized)
            {
                Properties.Settings.Default.Location = RestoreBounds.Location;
                Properties.Settings.Default.Size = RestoreBounds.Size;
                Properties.Settings.Default.Maximised = true;
                Properties.Settings.Default.Minimised = false;
            }
            else if (WindowState == FormWindowState.Normal)
            {
                Properties.Settings.Default.Location = Location;
                Properties.Settings.Default.Size = Size;
                Properties.Settings.Default.Maximised = false;
                Properties.Settings.Default.Minimised = false;
            }
            else
            {
                Properties.Settings.Default.Location = RestoreBounds.Location;
                Properties.Settings.Default.Size = RestoreBounds.Size;
                Properties.Settings.Default.Maximised = false;
                Properties.Settings.Default.Minimised = true;
            }
            Properties.Settings.Default.Save();
        }

        private void RestoreState()
        {
            if (Properties.Settings.Default.Maximised)
            {
                WindowState = FormWindowState.Maximized;
                Location = Properties.Settings.Default.Location;
                Size = Properties.Settings.Default.Size;
            }
            else if (Properties.Settings.Default.Minimised)
            {
                WindowState = FormWindowState.Minimized;
                Location = Properties.Settings.Default.Location;
                Size = Properties.Settings.Default.Size;
            }
            else
            {
                Location = Properties.Settings.Default.Location;
                Size = Properties.Settings.Default.Size;
            }
        }

        private void Revert_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Все несохраненные изменения будут отменены! Продолжать?", "Внимание!", MessageBoxButtons.YesNo)
                == System.Windows.Forms.DialogResult.Yes)
            {
                LoadDataTables();
            }
        }

        private void DataGridView_FilterStringChanged(object sender, EventArgs e)
        {
            ((sender as DataGridView).DataSource as BindingSource).Filter =
                (sender as AdvancedDataGridView).FilterString;

        }

        private void DataGridView_SortStringChanged(object sender, EventArgs e)
        {
            ((sender as DataGridView).DataSource as BindingSource).Sort =
                          (sender as AdvancedDataGridView).SortString;
        }

        private void AutoRowMode_Click(object sender, EventArgs e)
        {
            SaveAutoRowAddMode();
        }

        private void LoadExcel_Click(object sender, EventArgs e)
        {
            MessageBoxIcon _icn;
            string _cpt;
            ProcResult _pr = LoadExcelPassTraffic();

            if (_pr.Result)
            {
                _icn = MessageBoxIcon.Information;
                _cpt = "Информация";

            }
            else { _icn = MessageBoxIcon.Error;
                _cpt = "Ошибка";
            };

            if  (_pr.Show)
            {
                MessageBox.Show(_pr.Message + Environment.NewLine + _pr.Error,
               _cpt, MessageBoxButtons.OK,
               _icn);
            }

        }


        private ProcResult LoadExcelPassTraffic()
        {
            bool _res = true;
            string _msg = String.Empty;
            string _err = String.Empty;
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "Файлы Excel (*.xlsx) |  *.xlsx";
            if (op.ShowDialog() != DialogResult.Cancel)
            {
                String filePath = op.FileName;
                DailyPassTrafficProvider pt = new DailyPassTrafficProvider(filePath);
                if (pt.VerifySource())

                {

                    try
                    {
                        _msg = Utils.Terminal.A + "/" + Utils.Terminal.International;
                        pF_PassTrafficFactTableAdapter.Insert(pt.GetFirstDate(), pt.GetFirstDate().Month, pt.GetFirstDate().Year, Utils.Terminal.A,
                            Utils.Terminal.International, pt.GetTraffic(Utils.Terminal.A, Utils.Terminal.International));

                        _msg = Utils.Terminal.D + "/" + Utils.Terminal.International;
                        pF_PassTrafficFactTableAdapter.Insert(pt.GetFirstDate(), pt.GetFirstDate().Month, pt.GetFirstDate().Year, Utils.Terminal.D,
                            Utils.Terminal.International, pt.GetTraffic(Utils.Terminal.D, Utils.Terminal.International));

                        _msg = Utils.Terminal.D + "/" + Utils.Terminal.Domestic; ;
                        pF_PassTrafficFactTableAdapter.Insert(pt.GetFirstDate(), pt.GetFirstDate().Month, pt.GetFirstDate().Year, Utils.Terminal.D,
                            Utils.Terminal.Domestic, pt.GetTraffic(Utils.Terminal.D, Utils.Terminal.Domestic));

                        _msg = Utils.Terminal.E + "/" + Utils.Terminal.International;
                        pF_PassTrafficFactTableAdapter.Insert(pt.GetFirstDate(), pt.GetFirstDate().Month, pt.GetFirstDate().Year, Utils.Terminal.E,
                            Utils.Terminal.International, pt.GetTraffic(Utils.Terminal.E, Utils.Terminal.International));

                        _msg = Utils.Terminal.F + "/" + Utils.Terminal.International;
                        pF_PassTrafficFactTableAdapter.Insert(pt.GetFirstDate(), pt.GetFirstDate().Month, pt.GetFirstDate().Year, Utils.Terminal.F,
                            Utils.Terminal.International, pt.GetTraffic(Utils.Terminal.F, Utils.Terminal.International));


                    }
                    catch (Exception e)
                    {
                        return new ProcResult(false, _msg, e.Message,true);

                    };
                    return new ProcResult(true, "Записи добавлены успешно!", String.Empty,true);
                }
                else
                { return new ProcResult(false, "Неизвестная структура файла!", String.Empty,true); }
            }
            else { return new ProcResult(false, String.Empty, String.Empty,false); }
        }

    }
}
