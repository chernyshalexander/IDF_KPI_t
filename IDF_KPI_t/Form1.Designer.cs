using IDF_KPI_t.Utils;

namespace IDF_KPI_t
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbLoadExcel = new System.Windows.Forms.ToolStripButton();
            this.tsbSaveData = new System.Windows.Forms.ToolStripButton();
            this.tsbRevert = new System.Windows.Forms.ToolStripButton();
            this.tsbAutoRowAddMode = new System.Windows.Forms.ToolStripButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageStoreDate = new System.Windows.Forms.TabPage();
            this.pF_StoreDateActiveDataGridView = new Zuby.ADGV.AdvancedDataGridView();
            this.dateDataGridViewTextBoxColumn = new IDF_KPI_t.Utils.CalendarColumn();
            this.storeCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.planDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.forecastDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.factDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pF_StoreDateActiveBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iDF_OUTDataSet = new IDF_KPI_t.IDF_OUTDataSet();
            this.pF_PassTrafficFactBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tabPageCurRate = new System.Windows.Forms.TabPage();
            this.pF_CurrencyRateDataGridView = new Zuby.ADGV.AdvancedDataGridView();
            this.dataGridViewTextBoxColumn30 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn31 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn32 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn33 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn34 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn29 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pF_CurrencyRateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tabPageKPI = new System.Windows.Forms.TabPage();
            this.pF_KPIDataGridView = new Zuby.ADGV.AdvancedDataGridView();
            this.yearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.monthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.storeCodeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.avgReceptPlanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.avgReceptForecastDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.convCoeffPlanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.convCoeffForecastDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pF_KPIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigator2 = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripButton8 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton9 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton10 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton11 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton12 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton13 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.tabPageCatQuota = new System.Windows.Forms.TabPage();
            this.pF_CategoryQuotaDataGridView = new Zuby.ADGV.AdvancedDataGridView();
            this.yearDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.monthDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.pFCategoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iDF_OUTDataSet1 = new IDF_KPI_t.IDF_OUTDataSet();
            this.storeCodeDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quotaPlanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quotaForecastDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pF_CategoryQuotaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigator3 = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripButton15 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton16 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton17 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton18 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox3 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton19 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton20 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.tabPagePassTraffic = new System.Windows.Forms.TabPage();
            this.pF_PassTrafficDataGridView = new Zuby.ADGV.AdvancedDataGridView();
            this.dataGridViewTextBoxColumn36 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn37 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn38 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn39 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn40 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn41 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn35 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pF_PassTrafficBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigator4 = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripButton22 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton23 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton24 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton25 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox4 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton26 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton27 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator12 = new System.Windows.Forms.ToolStripSeparator();
            this.tabPagePassTrafficFact = new System.Windows.Forms.TabPage();
            this.pF_PassTrafficFactDataGridView = new Zuby.ADGV.AdvancedDataGridView();
            this.Date = new IDF_KPI_t.Utils.CalendarColumn();
            this.Month = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Terminal = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.DestinationGroup = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.PassQtyFact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pF_PassTrafficFactBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigator5 = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripButton29 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel5 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton30 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton31 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton32 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator13 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox5 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator14 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton33 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton34 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator15 = new System.Windows.Forms.ToolStripSeparator();
            this.dataGridViewTextBoxColumn24 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn25 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn26 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.storeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pF_PassTrafficFactTableAdapter = new IDF_KPI_t.IDF_OUTDataSetTableAdapters.PF_PassTrafficFactTableAdapter();
            this.tableAdapterManager = new IDF_KPI_t.IDF_OUTDataSetTableAdapters.TableAdapterManager();
            this.pF_CategoryQuotaTableAdapter = new IDF_KPI_t.IDF_OUTDataSetTableAdapters.PF_CategoryQuotaTableAdapter();
            this.pF_CurrencyRateTableAdapter = new IDF_KPI_t.IDF_OUTDataSetTableAdapters.PF_CurrencyRateTableAdapter();
            this.pF_KPITableAdapter = new IDF_KPI_t.IDF_OUTDataSetTableAdapters.PF_KPITableAdapter();
            this.pF_PassTrafficTableAdapter = new IDF_KPI_t.IDF_OUTDataSetTableAdapters.PF_PassTrafficTableAdapter();
            this.pF_StoreDateActiveTableAdapter = new IDF_KPI_t.IDF_OUTDataSetTableAdapters.PF_StoreDateActiveTableAdapter();
            this.pF_CategoryTableAdapter = new IDF_KPI_t.IDF_OUTDataSetTableAdapters.PF_CategoryTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calendarColumn1 = new IDF_KPI_t.Utils.CalendarColumn();
            this.toolStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageStoreDate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pF_StoreDateActiveDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pF_StoreDateActiveBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iDF_OUTDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pF_PassTrafficFactBindingNavigator)).BeginInit();
            this.pF_PassTrafficFactBindingNavigator.SuspendLayout();
            this.tabPageCurRate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pF_CurrencyRateDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pF_CurrencyRateBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.tabPageKPI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pF_KPIDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pF_KPIBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator2)).BeginInit();
            this.bindingNavigator2.SuspendLayout();
            this.tabPageCatQuota.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pF_CategoryQuotaDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pFCategoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iDF_OUTDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pF_CategoryQuotaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator3)).BeginInit();
            this.bindingNavigator3.SuspendLayout();
            this.tabPagePassTraffic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pF_PassTrafficDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pF_PassTrafficBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator4)).BeginInit();
            this.bindingNavigator4.SuspendLayout();
            this.tabPagePassTrafficFact.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pF_PassTrafficFactDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pF_PassTrafficFactBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator5)).BeginInit();
            this.bindingNavigator5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.storeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbLoadExcel,
            this.tsbSaveData,
            this.tsbRevert,
            this.tsbAutoRowAddMode});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStrip1.Size = new System.Drawing.Size(779, 37);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbLoadExcel
            // 
            this.tsbLoadExcel.Image = ((System.Drawing.Image)(resources.GetObject("tsbLoadExcel.Image")));
            this.tsbLoadExcel.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbLoadExcel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbLoadExcel.Name = "tsbLoadExcel";
            this.tsbLoadExcel.Size = new System.Drawing.Size(69, 34);
            this.tsbLoadExcel.Text = "Load";
            this.tsbLoadExcel.Click += new System.EventHandler(this.LoadExcel_Click);
            // 
            // tsbSaveData
            // 
            this.tsbSaveData.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tsbSaveData.Image = ((System.Drawing.Image)(resources.GetObject("tsbSaveData.Image")));
            this.tsbSaveData.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbSaveData.Name = "tsbSaveData";
            this.tsbSaveData.Size = new System.Drawing.Size(67, 34);
            this.tsbSaveData.Text = "Save";
            this.tsbSaveData.Click += new System.EventHandler(this.SaveItem_Click);
            // 
            // tsbRevert
            // 
            this.tsbRevert.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tsbRevert.Image = ((System.Drawing.Image)(resources.GetObject("tsbRevert.Image")));
            this.tsbRevert.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbRevert.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRevert.Name = "tsbRevert";
            this.tsbRevert.Size = new System.Drawing.Size(76, 34);
            this.tsbRevert.Text = "Revert";
            this.tsbRevert.Click += new System.EventHandler(this.Revert_Click);
            // 
            // tsbAutoRowAddMode
            // 
            this.tsbAutoRowAddMode.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbAutoRowAddMode.BackColor = System.Drawing.SystemColors.Control;
            this.tsbAutoRowAddMode.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tsbAutoRowAddMode.BackgroundImage")));
            this.tsbAutoRowAddMode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tsbAutoRowAddMode.CheckOnClick = true;
            this.tsbAutoRowAddMode.Image = ((System.Drawing.Image)(resources.GetObject("tsbAutoRowAddMode.Image")));
            this.tsbAutoRowAddMode.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAutoRowAddMode.Name = "tsbAutoRowAddMode";
            this.tsbAutoRowAddMode.Size = new System.Drawing.Size(159, 34);
            this.tsbAutoRowAddMode.Text = "\"Auto row add\" Mode";
            this.tsbAutoRowAddMode.Click += new System.EventHandler(this.AutoRowMode_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageStoreDate);
            this.tabControl1.Controls.Add(this.tabPageCurRate);
            this.tabControl1.Controls.Add(this.tabPageKPI);
            this.tabControl1.Controls.Add(this.tabPageCatQuota);
            this.tabControl1.Controls.Add(this.tabPagePassTraffic);
            this.tabControl1.Controls.Add(this.tabPagePassTrafficFact);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 37);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(779, 453);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPageStoreDate
            // 
            this.tabPageStoreDate.Controls.Add(this.pF_StoreDateActiveDataGridView);
            this.tabPageStoreDate.Controls.Add(this.pF_PassTrafficFactBindingNavigator);
            this.tabPageStoreDate.Location = new System.Drawing.Point(4, 25);
            this.tabPageStoreDate.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageStoreDate.Name = "tabPageStoreDate";
            this.tabPageStoreDate.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageStoreDate.Size = new System.Drawing.Size(771, 424);
            this.tabPageStoreDate.TabIndex = 1;
            this.tabPageStoreDate.Text = "Дни работы магазина";
            this.tabPageStoreDate.UseVisualStyleBackColor = true;
            // 
            // pF_StoreDateActiveDataGridView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pF_StoreDateActiveDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.pF_StoreDateActiveDataGridView.AutoGenerateColumns = false;
            this.pF_StoreDateActiveDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pF_StoreDateActiveDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dateDataGridViewTextBoxColumn,
            this.storeCodeDataGridViewTextBoxColumn,
            this.planDataGridViewTextBoxColumn,
            this.forecastDataGridViewTextBoxColumn,
            this.factDataGridViewTextBoxColumn,
            this.idDataGridViewTextBoxColumn});
            this.pF_StoreDateActiveDataGridView.DataSource = this.pF_StoreDateActiveBindingSource;
            this.pF_StoreDateActiveDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pF_StoreDateActiveDataGridView.FilterAndSortEnabled = true;
            this.pF_StoreDateActiveDataGridView.Location = new System.Drawing.Point(4, 4);
            this.pF_StoreDateActiveDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.pF_StoreDateActiveDataGridView.Name = "pF_StoreDateActiveDataGridView";
            this.pF_StoreDateActiveDataGridView.Size = new System.Drawing.Size(763, 391);
            this.pF_StoreDateActiveDataGridView.TabIndex = 4;
            this.pF_StoreDateActiveDataGridView.SortStringChanged += new System.EventHandler(this.DataGridView_SortStringChanged);
            this.pF_StoreDateActiveDataGridView.FilterStringChanged += new System.EventHandler(this.DataGridView_FilterStringChanged);
            this.pF_StoreDateActiveDataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_CellValueChanged);
            this.pF_StoreDateActiveDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.pF_PassTrafficDataGridView_DataError);
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Дата";
            this.dateDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dateDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // storeCodeDataGridViewTextBoxColumn
            // 
            this.storeCodeDataGridViewTextBoxColumn.DataPropertyName = "StoreCode";
            this.storeCodeDataGridViewTextBoxColumn.HeaderText = "Магазин";
            this.storeCodeDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.storeCodeDataGridViewTextBoxColumn.Name = "storeCodeDataGridViewTextBoxColumn";
            this.storeCodeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // planDataGridViewTextBoxColumn
            // 
            this.planDataGridViewTextBoxColumn.DataPropertyName = "Plan";
            this.planDataGridViewTextBoxColumn.HeaderText = "План";
            this.planDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.planDataGridViewTextBoxColumn.Name = "planDataGridViewTextBoxColumn";
            this.planDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // forecastDataGridViewTextBoxColumn
            // 
            this.forecastDataGridViewTextBoxColumn.DataPropertyName = "Forecast";
            this.forecastDataGridViewTextBoxColumn.HeaderText = "Прогноз";
            this.forecastDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.forecastDataGridViewTextBoxColumn.Name = "forecastDataGridViewTextBoxColumn";
            this.forecastDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // factDataGridViewTextBoxColumn
            // 
            this.factDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.factDataGridViewTextBoxColumn.DataPropertyName = "Fact";
            this.factDataGridViewTextBoxColumn.HeaderText = "Факт";
            this.factDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.factDataGridViewTextBoxColumn.Name = "factDataGridViewTextBoxColumn";
            this.factDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // pF_StoreDateActiveBindingSource
            // 
            this.pF_StoreDateActiveBindingSource.DataMember = "PF_StoreDateActive";
            this.pF_StoreDateActiveBindingSource.DataSource = this.iDF_OUTDataSet;
            // 
            // iDF_OUTDataSet
            // 
            this.iDF_OUTDataSet.DataSetName = "IDF_OUTDataSet";
            this.iDF_OUTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pF_PassTrafficFactBindingNavigator
            // 
            this.pF_PassTrafficFactBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.pF_PassTrafficFactBindingNavigator.BindingSource = this.pF_StoreDateActiveBindingSource;
            this.pF_PassTrafficFactBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.pF_PassTrafficFactBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.pF_PassTrafficFactBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pF_PassTrafficFactBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.pF_PassTrafficFactBindingNavigator.Location = new System.Drawing.Point(4, 395);
            this.pF_PassTrafficFactBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.pF_PassTrafficFactBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.pF_PassTrafficFactBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.pF_PassTrafficFactBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.pF_PassTrafficFactBindingNavigator.Name = "pF_PassTrafficFactBindingNavigator";
            this.pF_PassTrafficFactBindingNavigator.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.pF_PassTrafficFactBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.pF_PassTrafficFactBindingNavigator.Size = new System.Drawing.Size(763, 25);
            this.pF_PassTrafficFactBindingNavigator.TabIndex = 3;
            this.pF_PassTrafficFactBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(65, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tabPageCurRate
            // 
            this.tabPageCurRate.AutoScroll = true;
            this.tabPageCurRate.Controls.Add(this.pF_CurrencyRateDataGridView);
            this.tabPageCurRate.Controls.Add(this.bindingNavigator1);
            this.tabPageCurRate.Location = new System.Drawing.Point(4, 25);
            this.tabPageCurRate.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageCurRate.Name = "tabPageCurRate";
            this.tabPageCurRate.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageCurRate.Size = new System.Drawing.Size(771, 424);
            this.tabPageCurRate.TabIndex = 4;
            this.tabPageCurRate.Text = "Курс валюты";
            this.tabPageCurRate.UseVisualStyleBackColor = true;
            // 
            // pF_CurrencyRateDataGridView
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pF_CurrencyRateDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.pF_CurrencyRateDataGridView.AutoGenerateColumns = false;
            this.pF_CurrencyRateDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pF_CurrencyRateDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn30,
            this.dataGridViewTextBoxColumn31,
            this.dataGridViewTextBoxColumn32,
            this.dataGridViewTextBoxColumn33,
            this.dataGridViewTextBoxColumn34,
            this.dataGridViewTextBoxColumn29});
            this.pF_CurrencyRateDataGridView.DataSource = this.pF_CurrencyRateBindingSource;
            this.pF_CurrencyRateDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pF_CurrencyRateDataGridView.FilterAndSortEnabled = true;
            this.pF_CurrencyRateDataGridView.Location = new System.Drawing.Point(4, 4);
            this.pF_CurrencyRateDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.pF_CurrencyRateDataGridView.Name = "pF_CurrencyRateDataGridView";
            this.pF_CurrencyRateDataGridView.Size = new System.Drawing.Size(763, 391);
            this.pF_CurrencyRateDataGridView.TabIndex = 5;
            this.pF_CurrencyRateDataGridView.SortStringChanged += new System.EventHandler(this.DataGridView_SortStringChanged);
            this.pF_CurrencyRateDataGridView.FilterStringChanged += new System.EventHandler(this.DataGridView_FilterStringChanged);
            this.pF_CurrencyRateDataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_CellValueChanged);
            this.pF_CurrencyRateDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.pF_PassTrafficDataGridView_DataError);
            // 
            // dataGridViewTextBoxColumn30
            // 
            this.dataGridViewTextBoxColumn30.DataPropertyName = "CurrCode";
            this.dataGridViewTextBoxColumn30.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.dataGridViewTextBoxColumn30.HeaderText = "Валюта";
            this.dataGridViewTextBoxColumn30.Items.AddRange(new object[] {
            "USD",
            "EUR"});
            this.dataGridViewTextBoxColumn30.MinimumWidth = 22;
            this.dataGridViewTextBoxColumn30.Name = "dataGridViewTextBoxColumn30";
            this.dataGridViewTextBoxColumn30.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn30.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn31
            // 
            this.dataGridViewTextBoxColumn31.DataPropertyName = "Year";
            this.dataGridViewTextBoxColumn31.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.dataGridViewTextBoxColumn31.HeaderText = "Год";
            this.dataGridViewTextBoxColumn31.Items.AddRange(new object[] {
            "2016",
            "2017",
            "2018",
            "2019",
            "2020"});
            this.dataGridViewTextBoxColumn31.MinimumWidth = 22;
            this.dataGridViewTextBoxColumn31.Name = "dataGridViewTextBoxColumn31";
            this.dataGridViewTextBoxColumn31.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn31.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn32
            // 
            this.dataGridViewTextBoxColumn32.DataPropertyName = "Month";
            this.dataGridViewTextBoxColumn32.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.dataGridViewTextBoxColumn32.HeaderText = "Месяц";
            this.dataGridViewTextBoxColumn32.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.dataGridViewTextBoxColumn32.MinimumWidth = 22;
            this.dataGridViewTextBoxColumn32.Name = "dataGridViewTextBoxColumn32";
            this.dataGridViewTextBoxColumn32.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn32.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn33
            // 
            this.dataGridViewTextBoxColumn33.DataPropertyName = "RatePlan";
            this.dataGridViewTextBoxColumn33.HeaderText = "Курс, план";
            this.dataGridViewTextBoxColumn33.MinimumWidth = 22;
            this.dataGridViewTextBoxColumn33.Name = "dataGridViewTextBoxColumn33";
            this.dataGridViewTextBoxColumn33.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn34
            // 
            this.dataGridViewTextBoxColumn34.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn34.DataPropertyName = "RateForecast";
            this.dataGridViewTextBoxColumn34.HeaderText = "Курс, прогноз";
            this.dataGridViewTextBoxColumn34.MinimumWidth = 22;
            this.dataGridViewTextBoxColumn34.Name = "dataGridViewTextBoxColumn34";
            this.dataGridViewTextBoxColumn34.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn29
            // 
            this.dataGridViewTextBoxColumn29.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn29.HeaderText = "id";
            this.dataGridViewTextBoxColumn29.MinimumWidth = 22;
            this.dataGridViewTextBoxColumn29.Name = "dataGridViewTextBoxColumn29";
            this.dataGridViewTextBoxColumn29.ReadOnly = true;
            this.dataGridViewTextBoxColumn29.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dataGridViewTextBoxColumn29.Visible = false;
            // 
            // pF_CurrencyRateBindingSource
            // 
            this.pF_CurrencyRateBindingSource.DataMember = "PF_CurrencyRate";
            this.pF_CurrencyRateBindingSource.DataSource = this.iDF_OUTDataSet;
            this.pF_CurrencyRateBindingSource.Filter = "";
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.toolStripButton1;
            this.bindingNavigator1.BindingSource = this.pF_CurrencyRateBindingSource;
            this.bindingNavigator1.CountItem = this.toolStripLabel1;
            this.bindingNavigator1.DeleteItem = this.toolStripButton2;
            this.bindingNavigator1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripSeparator1,
            this.toolStripTextBox1,
            this.toolStripLabel1,
            this.toolStripSeparator2,
            this.toolStripButton5,
            this.toolStripButton6,
            this.toolStripSeparator3,
            this.toolStripButton1,
            this.toolStripButton2});
            this.bindingNavigator1.Location = new System.Drawing.Point(4, 395);
            this.bindingNavigator1.MoveFirstItem = this.toolStripButton3;
            this.bindingNavigator1.MoveLastItem = this.toolStripButton6;
            this.bindingNavigator1.MoveNextItem = this.toolStripButton5;
            this.bindingNavigator1.MovePreviousItem = this.toolStripButton4;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.bindingNavigator1.PositionItem = this.toolStripTextBox1;
            this.bindingNavigator1.Size = new System.Drawing.Size(763, 25);
            this.bindingNavigator1.TabIndex = 4;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.RightToLeftAutoMirrorImage = true;
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "Add new";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(35, 22);
            this.toolStripLabel1.Text = "of {0}";
            this.toolStripLabel1.ToolTipText = "Total number of items";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.RightToLeftAutoMirrorImage = true;
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "Delete";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.RightToLeftAutoMirrorImage = true;
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "Move first";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.RightToLeftAutoMirrorImage = true;
            this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton4.Text = "Move previous";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.AccessibleName = "Position";
            this.toolStripTextBox1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripTextBox1.AutoSize = false;
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(65, 23);
            this.toolStripTextBox1.Text = "0";
            this.toolStripTextBox1.ToolTipText = "Current position";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.RightToLeftAutoMirrorImage = true;
            this.toolStripButton5.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton5.Text = "Move next";
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.RightToLeftAutoMirrorImage = true;
            this.toolStripButton6.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton6.Text = "Move last";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // tabPageKPI
            // 
            this.tabPageKPI.Controls.Add(this.pF_KPIDataGridView);
            this.tabPageKPI.Controls.Add(this.bindingNavigator2);
            this.tabPageKPI.Location = new System.Drawing.Point(4, 25);
            this.tabPageKPI.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageKPI.Name = "tabPageKPI";
            this.tabPageKPI.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageKPI.Size = new System.Drawing.Size(771, 424);
            this.tabPageKPI.TabIndex = 2;
            this.tabPageKPI.Text = "КК и СЧ";
            this.tabPageKPI.UseVisualStyleBackColor = true;
            // 
            // pF_KPIDataGridView
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pF_KPIDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.pF_KPIDataGridView.AutoGenerateColumns = false;
            this.pF_KPIDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pF_KPIDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.yearDataGridViewTextBoxColumn,
            this.monthDataGridViewTextBoxColumn,
            this.storeCodeDataGridViewTextBoxColumn1,
            this.avgReceptPlanDataGridViewTextBoxColumn,
            this.avgReceptForecastDataGridViewTextBoxColumn,
            this.convCoeffPlanDataGridViewTextBoxColumn,
            this.convCoeffForecastDataGridViewTextBoxColumn,
            this.idDataGridViewTextBoxColumn1});
            this.pF_KPIDataGridView.DataSource = this.pF_KPIBindingSource;
            this.pF_KPIDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pF_KPIDataGridView.FilterAndSortEnabled = true;
            this.pF_KPIDataGridView.Location = new System.Drawing.Point(4, 4);
            this.pF_KPIDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.pF_KPIDataGridView.Name = "pF_KPIDataGridView";
            this.pF_KPIDataGridView.Size = new System.Drawing.Size(763, 391);
            this.pF_KPIDataGridView.TabIndex = 6;
            this.pF_KPIDataGridView.SortStringChanged += new System.EventHandler(this.DataGridView_SortStringChanged);
            this.pF_KPIDataGridView.FilterStringChanged += new System.EventHandler(this.DataGridView_FilterStringChanged);
            this.pF_KPIDataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_CellValueChanged);
            this.pF_KPIDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.pF_PassTrafficDataGridView_DataError);
            // 
            // yearDataGridViewTextBoxColumn
            // 
            this.yearDataGridViewTextBoxColumn.DataPropertyName = "Year";
            this.yearDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.yearDataGridViewTextBoxColumn.HeaderText = "Год";
            this.yearDataGridViewTextBoxColumn.Items.AddRange(new object[] {
            "2016",
            "2017",
            "2018",
            "2019",
            "2020"});
            this.yearDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.yearDataGridViewTextBoxColumn.Name = "yearDataGridViewTextBoxColumn";
            this.yearDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.yearDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // monthDataGridViewTextBoxColumn
            // 
            this.monthDataGridViewTextBoxColumn.DataPropertyName = "Month";
            this.monthDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.monthDataGridViewTextBoxColumn.HeaderText = "Месяц";
            this.monthDataGridViewTextBoxColumn.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.monthDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.monthDataGridViewTextBoxColumn.Name = "monthDataGridViewTextBoxColumn";
            this.monthDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.monthDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // storeCodeDataGridViewTextBoxColumn1
            // 
            this.storeCodeDataGridViewTextBoxColumn1.DataPropertyName = "StoreCode";
            this.storeCodeDataGridViewTextBoxColumn1.HeaderText = "Магазин";
            this.storeCodeDataGridViewTextBoxColumn1.MinimumWidth = 22;
            this.storeCodeDataGridViewTextBoxColumn1.Name = "storeCodeDataGridViewTextBoxColumn1";
            this.storeCodeDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // avgReceptPlanDataGridViewTextBoxColumn
            // 
            this.avgReceptPlanDataGridViewTextBoxColumn.DataPropertyName = "AvgReceptPlan";
            this.avgReceptPlanDataGridViewTextBoxColumn.HeaderText = "СЧ план";
            this.avgReceptPlanDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.avgReceptPlanDataGridViewTextBoxColumn.Name = "avgReceptPlanDataGridViewTextBoxColumn";
            this.avgReceptPlanDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // avgReceptForecastDataGridViewTextBoxColumn
            // 
            this.avgReceptForecastDataGridViewTextBoxColumn.DataPropertyName = "AvgReceptForecast";
            this.avgReceptForecastDataGridViewTextBoxColumn.HeaderText = "СЧ прогноз";
            this.avgReceptForecastDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.avgReceptForecastDataGridViewTextBoxColumn.Name = "avgReceptForecastDataGridViewTextBoxColumn";
            this.avgReceptForecastDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // convCoeffPlanDataGridViewTextBoxColumn
            // 
            this.convCoeffPlanDataGridViewTextBoxColumn.DataPropertyName = "ConvCoeffPlan";
            this.convCoeffPlanDataGridViewTextBoxColumn.HeaderText = "КК план";
            this.convCoeffPlanDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.convCoeffPlanDataGridViewTextBoxColumn.Name = "convCoeffPlanDataGridViewTextBoxColumn";
            this.convCoeffPlanDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // convCoeffForecastDataGridViewTextBoxColumn
            // 
            this.convCoeffForecastDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.convCoeffForecastDataGridViewTextBoxColumn.DataPropertyName = "ConvCoeffForecast";
            this.convCoeffForecastDataGridViewTextBoxColumn.HeaderText = "КК прогноз";
            this.convCoeffForecastDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.convCoeffForecastDataGridViewTextBoxColumn.Name = "convCoeffForecastDataGridViewTextBoxColumn";
            this.convCoeffForecastDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "id";
            this.idDataGridViewTextBoxColumn1.MinimumWidth = 22;
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.idDataGridViewTextBoxColumn1.Visible = false;
            // 
            // pF_KPIBindingSource
            // 
            this.pF_KPIBindingSource.DataMember = "PF_KPI";
            this.pF_KPIBindingSource.DataSource = this.iDF_OUTDataSet;
            // 
            // bindingNavigator2
            // 
            this.bindingNavigator2.AddNewItem = this.toolStripButton8;
            this.bindingNavigator2.BindingSource = this.pF_KPIBindingSource;
            this.bindingNavigator2.CountItem = this.toolStripLabel2;
            this.bindingNavigator2.DeleteItem = this.toolStripButton9;
            this.bindingNavigator2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bindingNavigator2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton10,
            this.toolStripButton11,
            this.toolStripSeparator4,
            this.toolStripTextBox2,
            this.toolStripLabel2,
            this.toolStripSeparator5,
            this.toolStripButton12,
            this.toolStripButton13,
            this.toolStripSeparator6,
            this.toolStripButton8,
            this.toolStripButton9});
            this.bindingNavigator2.Location = new System.Drawing.Point(4, 395);
            this.bindingNavigator2.MoveFirstItem = this.toolStripButton10;
            this.bindingNavigator2.MoveLastItem = this.toolStripButton13;
            this.bindingNavigator2.MoveNextItem = this.toolStripButton12;
            this.bindingNavigator2.MovePreviousItem = this.toolStripButton11;
            this.bindingNavigator2.Name = "bindingNavigator2";
            this.bindingNavigator2.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.bindingNavigator2.PositionItem = this.toolStripTextBox2;
            this.bindingNavigator2.Size = new System.Drawing.Size(763, 25);
            this.bindingNavigator2.TabIndex = 5;
            this.bindingNavigator2.Text = "bindingNavigator2";
            // 
            // toolStripButton8
            // 
            this.toolStripButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton8.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton8.Image")));
            this.toolStripButton8.Name = "toolStripButton8";
            this.toolStripButton8.RightToLeftAutoMirrorImage = true;
            this.toolStripButton8.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton8.Text = "Add new";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(35, 22);
            this.toolStripLabel2.Text = "of {0}";
            this.toolStripLabel2.ToolTipText = "Total number of items";
            // 
            // toolStripButton9
            // 
            this.toolStripButton9.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton9.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton9.Image")));
            this.toolStripButton9.Name = "toolStripButton9";
            this.toolStripButton9.RightToLeftAutoMirrorImage = true;
            this.toolStripButton9.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton9.Text = "Delete";
            // 
            // toolStripButton10
            // 
            this.toolStripButton10.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton10.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton10.Image")));
            this.toolStripButton10.Name = "toolStripButton10";
            this.toolStripButton10.RightToLeftAutoMirrorImage = true;
            this.toolStripButton10.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton10.Text = "Move first";
            // 
            // toolStripButton11
            // 
            this.toolStripButton11.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton11.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton11.Image")));
            this.toolStripButton11.Name = "toolStripButton11";
            this.toolStripButton11.RightToLeftAutoMirrorImage = true;
            this.toolStripButton11.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton11.Text = "Move previous";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripTextBox2
            // 
            this.toolStripTextBox2.AccessibleName = "Position";
            this.toolStripTextBox2.AutoSize = false;
            this.toolStripTextBox2.Name = "toolStripTextBox2";
            this.toolStripTextBox2.Size = new System.Drawing.Size(65, 23);
            this.toolStripTextBox2.Text = "0";
            this.toolStripTextBox2.ToolTipText = "Current position";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton12
            // 
            this.toolStripButton12.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton12.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton12.Image")));
            this.toolStripButton12.Name = "toolStripButton12";
            this.toolStripButton12.RightToLeftAutoMirrorImage = true;
            this.toolStripButton12.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton12.Text = "Move next";
            // 
            // toolStripButton13
            // 
            this.toolStripButton13.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton13.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton13.Image")));
            this.toolStripButton13.Name = "toolStripButton13";
            this.toolStripButton13.RightToLeftAutoMirrorImage = true;
            this.toolStripButton13.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton13.Text = "Move last";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // tabPageCatQuota
            // 
            this.tabPageCatQuota.BackColor = System.Drawing.Color.Transparent;
            this.tabPageCatQuota.Controls.Add(this.pF_CategoryQuotaDataGridView);
            this.tabPageCatQuota.Controls.Add(this.bindingNavigator3);
            this.tabPageCatQuota.Location = new System.Drawing.Point(4, 25);
            this.tabPageCatQuota.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageCatQuota.Name = "tabPageCatQuota";
            this.tabPageCatQuota.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageCatQuota.Size = new System.Drawing.Size(771, 424);
            this.tabPageCatQuota.TabIndex = 3;
            this.tabPageCatQuota.Text = "Доли категорий";
            // 
            // pF_CategoryQuotaDataGridView
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pF_CategoryQuotaDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.pF_CategoryQuotaDataGridView.AutoGenerateColumns = false;
            this.pF_CategoryQuotaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pF_CategoryQuotaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.yearDataGridViewTextBoxColumn1,
            this.monthDataGridViewTextBoxColumn1,
            this.categoryDataGridViewTextBoxColumn,
            this.storeCodeDataGridViewTextBoxColumn2,
            this.quotaPlanDataGridViewTextBoxColumn,
            this.quotaForecastDataGridViewTextBoxColumn,
            this.idDataGridViewTextBoxColumn2});
            this.pF_CategoryQuotaDataGridView.DataSource = this.pF_CategoryQuotaBindingSource;
            this.pF_CategoryQuotaDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pF_CategoryQuotaDataGridView.FilterAndSortEnabled = true;
            this.pF_CategoryQuotaDataGridView.Location = new System.Drawing.Point(4, 4);
            this.pF_CategoryQuotaDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.pF_CategoryQuotaDataGridView.Name = "pF_CategoryQuotaDataGridView";
            this.pF_CategoryQuotaDataGridView.Size = new System.Drawing.Size(763, 391);
            this.pF_CategoryQuotaDataGridView.TabIndex = 7;
            this.pF_CategoryQuotaDataGridView.SortStringChanged += new System.EventHandler(this.DataGridView_SortStringChanged);
            this.pF_CategoryQuotaDataGridView.FilterStringChanged += new System.EventHandler(this.DataGridView_FilterStringChanged);
            this.pF_CategoryQuotaDataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_CellValueChanged);
            this.pF_CategoryQuotaDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.pF_PassTrafficDataGridView_DataError);
            // 
            // yearDataGridViewTextBoxColumn1
            // 
            this.yearDataGridViewTextBoxColumn1.DataPropertyName = "Year";
            this.yearDataGridViewTextBoxColumn1.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.yearDataGridViewTextBoxColumn1.HeaderText = "Год";
            this.yearDataGridViewTextBoxColumn1.Items.AddRange(new object[] {
            "2016",
            "2017",
            "2018",
            "2019",
            "2020"});
            this.yearDataGridViewTextBoxColumn1.MinimumWidth = 22;
            this.yearDataGridViewTextBoxColumn1.Name = "yearDataGridViewTextBoxColumn1";
            this.yearDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.yearDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // monthDataGridViewTextBoxColumn1
            // 
            this.monthDataGridViewTextBoxColumn1.DataPropertyName = "Month";
            this.monthDataGridViewTextBoxColumn1.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.monthDataGridViewTextBoxColumn1.HeaderText = "Месяц";
            this.monthDataGridViewTextBoxColumn1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.monthDataGridViewTextBoxColumn1.MinimumWidth = 22;
            this.monthDataGridViewTextBoxColumn1.Name = "monthDataGridViewTextBoxColumn1";
            this.monthDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.monthDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            this.categoryDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.categoryDataGridViewTextBoxColumn.DataPropertyName = "Category";
            this.categoryDataGridViewTextBoxColumn.DataSource = this.pFCategoryBindingSource;
            this.categoryDataGridViewTextBoxColumn.DisplayMember = "Description";
            this.categoryDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.categoryDataGridViewTextBoxColumn.HeaderText = "Категория";
            this.categoryDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            this.categoryDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.categoryDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.categoryDataGridViewTextBoxColumn.ValueMember = "Code";
            this.categoryDataGridViewTextBoxColumn.Width = 101;
            // 
            // pFCategoryBindingSource
            // 
            this.pFCategoryBindingSource.DataMember = "PF_Category";
            this.pFCategoryBindingSource.DataSource = this.iDF_OUTDataSet1;
            // 
            // iDF_OUTDataSet1
            // 
            this.iDF_OUTDataSet1.DataSetName = "IDF_OUTDataSet";
            this.iDF_OUTDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // storeCodeDataGridViewTextBoxColumn2
            // 
            this.storeCodeDataGridViewTextBoxColumn2.DataPropertyName = "StoreCode";
            this.storeCodeDataGridViewTextBoxColumn2.HeaderText = "Магазин";
            this.storeCodeDataGridViewTextBoxColumn2.MinimumWidth = 22;
            this.storeCodeDataGridViewTextBoxColumn2.Name = "storeCodeDataGridViewTextBoxColumn2";
            this.storeCodeDataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // quotaPlanDataGridViewTextBoxColumn
            // 
            this.quotaPlanDataGridViewTextBoxColumn.DataPropertyName = "QuotaPlan";
            this.quotaPlanDataGridViewTextBoxColumn.HeaderText = "Доля план";
            this.quotaPlanDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.quotaPlanDataGridViewTextBoxColumn.Name = "quotaPlanDataGridViewTextBoxColumn";
            this.quotaPlanDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // quotaForecastDataGridViewTextBoxColumn
            // 
            this.quotaForecastDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.quotaForecastDataGridViewTextBoxColumn.DataPropertyName = "QuotaForecast";
            this.quotaForecastDataGridViewTextBoxColumn.HeaderText = "Доля прогноз";
            this.quotaForecastDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.quotaForecastDataGridViewTextBoxColumn.Name = "quotaForecastDataGridViewTextBoxColumn";
            this.quotaForecastDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // idDataGridViewTextBoxColumn2
            // 
            this.idDataGridViewTextBoxColumn2.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn2.HeaderText = "id";
            this.idDataGridViewTextBoxColumn2.MinimumWidth = 22;
            this.idDataGridViewTextBoxColumn2.Name = "idDataGridViewTextBoxColumn2";
            this.idDataGridViewTextBoxColumn2.ReadOnly = true;
            this.idDataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.idDataGridViewTextBoxColumn2.Visible = false;
            // 
            // pF_CategoryQuotaBindingSource
            // 
            this.pF_CategoryQuotaBindingSource.DataMember = "PF_CategoryQuota";
            this.pF_CategoryQuotaBindingSource.DataSource = this.iDF_OUTDataSet;
            // 
            // bindingNavigator3
            // 
            this.bindingNavigator3.AddNewItem = this.toolStripButton15;
            this.bindingNavigator3.BindingSource = this.pF_CategoryQuotaBindingSource;
            this.bindingNavigator3.CountItem = this.toolStripLabel3;
            this.bindingNavigator3.DeleteItem = this.toolStripButton16;
            this.bindingNavigator3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bindingNavigator3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton17,
            this.toolStripButton18,
            this.toolStripSeparator7,
            this.toolStripTextBox3,
            this.toolStripLabel3,
            this.toolStripSeparator8,
            this.toolStripButton19,
            this.toolStripButton20,
            this.toolStripSeparator9,
            this.toolStripButton15,
            this.toolStripButton16});
            this.bindingNavigator3.Location = new System.Drawing.Point(4, 395);
            this.bindingNavigator3.MoveFirstItem = this.toolStripButton17;
            this.bindingNavigator3.MoveLastItem = this.toolStripButton20;
            this.bindingNavigator3.MoveNextItem = this.toolStripButton19;
            this.bindingNavigator3.MovePreviousItem = this.toolStripButton18;
            this.bindingNavigator3.Name = "bindingNavigator3";
            this.bindingNavigator3.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.bindingNavigator3.PositionItem = this.toolStripTextBox3;
            this.bindingNavigator3.Size = new System.Drawing.Size(763, 25);
            this.bindingNavigator3.TabIndex = 6;
            this.bindingNavigator3.Text = "bindingNavigator3";
            // 
            // toolStripButton15
            // 
            this.toolStripButton15.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton15.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton15.Image")));
            this.toolStripButton15.Name = "toolStripButton15";
            this.toolStripButton15.RightToLeftAutoMirrorImage = true;
            this.toolStripButton15.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton15.Text = "Add new";
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(35, 22);
            this.toolStripLabel3.Text = "of {0}";
            this.toolStripLabel3.ToolTipText = "Total number of items";
            // 
            // toolStripButton16
            // 
            this.toolStripButton16.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton16.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton16.Image")));
            this.toolStripButton16.Name = "toolStripButton16";
            this.toolStripButton16.RightToLeftAutoMirrorImage = true;
            this.toolStripButton16.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton16.Text = "Delete";
            // 
            // toolStripButton17
            // 
            this.toolStripButton17.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton17.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton17.Image")));
            this.toolStripButton17.Name = "toolStripButton17";
            this.toolStripButton17.RightToLeftAutoMirrorImage = true;
            this.toolStripButton17.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton17.Text = "Move first";
            // 
            // toolStripButton18
            // 
            this.toolStripButton18.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton18.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton18.Image")));
            this.toolStripButton18.Name = "toolStripButton18";
            this.toolStripButton18.RightToLeftAutoMirrorImage = true;
            this.toolStripButton18.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton18.Text = "Move previous";
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripTextBox3
            // 
            this.toolStripTextBox3.AccessibleName = "Position";
            this.toolStripTextBox3.AutoSize = false;
            this.toolStripTextBox3.Name = "toolStripTextBox3";
            this.toolStripTextBox3.Size = new System.Drawing.Size(65, 23);
            this.toolStripTextBox3.Text = "0";
            this.toolStripTextBox3.ToolTipText = "Current position";
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton19
            // 
            this.toolStripButton19.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton19.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton19.Image")));
            this.toolStripButton19.Name = "toolStripButton19";
            this.toolStripButton19.RightToLeftAutoMirrorImage = true;
            this.toolStripButton19.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton19.Text = "Move next";
            // 
            // toolStripButton20
            // 
            this.toolStripButton20.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton20.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton20.Image")));
            this.toolStripButton20.Name = "toolStripButton20";
            this.toolStripButton20.RightToLeftAutoMirrorImage = true;
            this.toolStripButton20.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton20.Text = "Move last";
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(6, 25);
            // 
            // tabPagePassTraffic
            // 
            this.tabPagePassTraffic.AutoScroll = true;
            this.tabPagePassTraffic.Controls.Add(this.pF_PassTrafficDataGridView);
            this.tabPagePassTraffic.Controls.Add(this.bindingNavigator4);
            this.tabPagePassTraffic.Location = new System.Drawing.Point(4, 25);
            this.tabPagePassTraffic.Margin = new System.Windows.Forms.Padding(4);
            this.tabPagePassTraffic.Name = "tabPagePassTraffic";
            this.tabPagePassTraffic.Padding = new System.Windows.Forms.Padding(4);
            this.tabPagePassTraffic.Size = new System.Drawing.Size(771, 424);
            this.tabPagePassTraffic.TabIndex = 5;
            this.tabPagePassTraffic.Text = "Пассажиропоток План";
            this.tabPagePassTraffic.UseVisualStyleBackColor = true;
            // 
            // pF_PassTrafficDataGridView
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pF_PassTrafficDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.pF_PassTrafficDataGridView.AutoGenerateColumns = false;
            this.pF_PassTrafficDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pF_PassTrafficDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn36,
            this.dataGridViewTextBoxColumn37,
            this.dataGridViewTextBoxColumn38,
            this.dataGridViewTextBoxColumn39,
            this.dataGridViewTextBoxColumn40,
            this.dataGridViewTextBoxColumn41,
            this.dataGridViewTextBoxColumn35});
            this.pF_PassTrafficDataGridView.DataSource = this.pF_PassTrafficBindingSource;
            this.pF_PassTrafficDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pF_PassTrafficDataGridView.FilterAndSortEnabled = true;
            this.pF_PassTrafficDataGridView.Location = new System.Drawing.Point(4, 4);
            this.pF_PassTrafficDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.pF_PassTrafficDataGridView.Name = "pF_PassTrafficDataGridView";
            this.pF_PassTrafficDataGridView.Size = new System.Drawing.Size(763, 391);
            this.pF_PassTrafficDataGridView.TabIndex = 8;
            this.pF_PassTrafficDataGridView.SortStringChanged += new System.EventHandler(this.DataGridView_SortStringChanged);
            this.pF_PassTrafficDataGridView.FilterStringChanged += new System.EventHandler(this.DataGridView_FilterStringChanged);
            this.pF_PassTrafficDataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_CellValueChanged);
            this.pF_PassTrafficDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.pF_PassTrafficDataGridView_DataError);
            // 
            // dataGridViewTextBoxColumn36
            // 
            this.dataGridViewTextBoxColumn36.DataPropertyName = "Year";
            this.dataGridViewTextBoxColumn36.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.dataGridViewTextBoxColumn36.HeaderText = "Год";
            this.dataGridViewTextBoxColumn36.Items.AddRange(new object[] {
            "2017",
            "2018"});
            this.dataGridViewTextBoxColumn36.MinimumWidth = 22;
            this.dataGridViewTextBoxColumn36.Name = "dataGridViewTextBoxColumn36";
            this.dataGridViewTextBoxColumn36.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn36.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn37
            // 
            this.dataGridViewTextBoxColumn37.DataPropertyName = "Month";
            this.dataGridViewTextBoxColumn37.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.dataGridViewTextBoxColumn37.HeaderText = "Месяц";
            this.dataGridViewTextBoxColumn37.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.dataGridViewTextBoxColumn37.MinimumWidth = 22;
            this.dataGridViewTextBoxColumn37.Name = "dataGridViewTextBoxColumn37";
            this.dataGridViewTextBoxColumn37.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn37.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn38
            // 
            this.dataGridViewTextBoxColumn38.DataPropertyName = "Terminal";
            this.dataGridViewTextBoxColumn38.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.dataGridViewTextBoxColumn38.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.dataGridViewTextBoxColumn38.HeaderText = "Терминал";
            this.dataGridViewTextBoxColumn38.Items.AddRange(new object[] {
            "SVO-A",
            "SVO-B",
            "SVO-D",
            "SVO-E",
            "SVO-F"});
            this.dataGridViewTextBoxColumn38.MinimumWidth = 22;
            this.dataGridViewTextBoxColumn38.Name = "dataGridViewTextBoxColumn38";
            this.dataGridViewTextBoxColumn38.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn38.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn39
            // 
            this.dataGridViewTextBoxColumn39.DataPropertyName = "DestinationGroup";
            this.dataGridViewTextBoxColumn39.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.dataGridViewTextBoxColumn39.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.dataGridViewTextBoxColumn39.HeaderText = "МВЛ/ВВЛ";
            this.dataGridViewTextBoxColumn39.Items.AddRange(new object[] {
            "МВЛ",
            "ВВЛ"});
            this.dataGridViewTextBoxColumn39.MinimumWidth = 22;
            this.dataGridViewTextBoxColumn39.Name = "dataGridViewTextBoxColumn39";
            this.dataGridViewTextBoxColumn39.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn39.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn40
            // 
            this.dataGridViewTextBoxColumn40.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn40.DataPropertyName = "Plan";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.NullValue = null;
            this.dataGridViewTextBoxColumn40.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewTextBoxColumn40.HeaderText = "План";
            this.dataGridViewTextBoxColumn40.MinimumWidth = 22;
            this.dataGridViewTextBoxColumn40.Name = "dataGridViewTextBoxColumn40";
            this.dataGridViewTextBoxColumn40.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dataGridViewTextBoxColumn40.Width = 67;
            // 
            // dataGridViewTextBoxColumn41
            // 
            this.dataGridViewTextBoxColumn41.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn41.DataPropertyName = "Forecast";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dataGridViewTextBoxColumn41.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewTextBoxColumn41.HeaderText = "Прогноз";
            this.dataGridViewTextBoxColumn41.MinimumWidth = 22;
            this.dataGridViewTextBoxColumn41.Name = "dataGridViewTextBoxColumn41";
            this.dataGridViewTextBoxColumn41.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn35
            // 
            this.dataGridViewTextBoxColumn35.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn35.HeaderText = "id";
            this.dataGridViewTextBoxColumn35.MinimumWidth = 22;
            this.dataGridViewTextBoxColumn35.Name = "dataGridViewTextBoxColumn35";
            this.dataGridViewTextBoxColumn35.ReadOnly = true;
            this.dataGridViewTextBoxColumn35.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dataGridViewTextBoxColumn35.Visible = false;
            // 
            // pF_PassTrafficBindingSource
            // 
            this.pF_PassTrafficBindingSource.DataMember = "PF_PassTraffic";
            this.pF_PassTrafficBindingSource.DataSource = this.iDF_OUTDataSet;
            // 
            // bindingNavigator4
            // 
            this.bindingNavigator4.AddNewItem = this.toolStripButton22;
            this.bindingNavigator4.BindingSource = this.pF_PassTrafficBindingSource;
            this.bindingNavigator4.CountItem = this.toolStripLabel4;
            this.bindingNavigator4.DeleteItem = this.toolStripButton23;
            this.bindingNavigator4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bindingNavigator4.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton24,
            this.toolStripButton25,
            this.toolStripSeparator10,
            this.toolStripTextBox4,
            this.toolStripLabel4,
            this.toolStripSeparator11,
            this.toolStripButton26,
            this.toolStripButton27,
            this.toolStripSeparator12,
            this.toolStripButton22,
            this.toolStripButton23});
            this.bindingNavigator4.Location = new System.Drawing.Point(4, 395);
            this.bindingNavigator4.MoveFirstItem = this.toolStripButton24;
            this.bindingNavigator4.MoveLastItem = this.toolStripButton27;
            this.bindingNavigator4.MoveNextItem = this.toolStripButton26;
            this.bindingNavigator4.MovePreviousItem = this.toolStripButton25;
            this.bindingNavigator4.Name = "bindingNavigator4";
            this.bindingNavigator4.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.bindingNavigator4.PositionItem = this.toolStripTextBox4;
            this.bindingNavigator4.Size = new System.Drawing.Size(763, 25);
            this.bindingNavigator4.TabIndex = 7;
            this.bindingNavigator4.Text = "bindingNavigator4";
            // 
            // toolStripButton22
            // 
            this.toolStripButton22.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton22.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton22.Image")));
            this.toolStripButton22.Name = "toolStripButton22";
            this.toolStripButton22.RightToLeftAutoMirrorImage = true;
            this.toolStripButton22.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton22.Text = "Add new";
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(35, 22);
            this.toolStripLabel4.Text = "of {0}";
            this.toolStripLabel4.ToolTipText = "Total number of items";
            // 
            // toolStripButton23
            // 
            this.toolStripButton23.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton23.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton23.Image")));
            this.toolStripButton23.Name = "toolStripButton23";
            this.toolStripButton23.RightToLeftAutoMirrorImage = true;
            this.toolStripButton23.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton23.Text = "Delete";
            // 
            // toolStripButton24
            // 
            this.toolStripButton24.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton24.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton24.Image")));
            this.toolStripButton24.Name = "toolStripButton24";
            this.toolStripButton24.RightToLeftAutoMirrorImage = true;
            this.toolStripButton24.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton24.Text = "Move first";
            // 
            // toolStripButton25
            // 
            this.toolStripButton25.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton25.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton25.Image")));
            this.toolStripButton25.Name = "toolStripButton25";
            this.toolStripButton25.RightToLeftAutoMirrorImage = true;
            this.toolStripButton25.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton25.Text = "Move previous";
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripTextBox4
            // 
            this.toolStripTextBox4.AccessibleName = "Position";
            this.toolStripTextBox4.AutoSize = false;
            this.toolStripTextBox4.Name = "toolStripTextBox4";
            this.toolStripTextBox4.Size = new System.Drawing.Size(65, 23);
            this.toolStripTextBox4.Text = "0";
            this.toolStripTextBox4.ToolTipText = "Current position";
            // 
            // toolStripSeparator11
            // 
            this.toolStripSeparator11.Name = "toolStripSeparator11";
            this.toolStripSeparator11.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton26
            // 
            this.toolStripButton26.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton26.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton26.Image")));
            this.toolStripButton26.Name = "toolStripButton26";
            this.toolStripButton26.RightToLeftAutoMirrorImage = true;
            this.toolStripButton26.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton26.Text = "Move next";
            // 
            // toolStripButton27
            // 
            this.toolStripButton27.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton27.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton27.Image")));
            this.toolStripButton27.Name = "toolStripButton27";
            this.toolStripButton27.RightToLeftAutoMirrorImage = true;
            this.toolStripButton27.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton27.Text = "Move last";
            // 
            // toolStripSeparator12
            // 
            this.toolStripSeparator12.Name = "toolStripSeparator12";
            this.toolStripSeparator12.Size = new System.Drawing.Size(6, 25);
            // 
            // tabPagePassTrafficFact
            // 
            this.tabPagePassTrafficFact.AutoScroll = true;
            this.tabPagePassTrafficFact.Controls.Add(this.pF_PassTrafficFactDataGridView);
            this.tabPagePassTrafficFact.Controls.Add(this.bindingNavigator5);
            this.tabPagePassTrafficFact.Location = new System.Drawing.Point(4, 25);
            this.tabPagePassTrafficFact.Margin = new System.Windows.Forms.Padding(4);
            this.tabPagePassTrafficFact.Name = "tabPagePassTrafficFact";
            this.tabPagePassTrafficFact.Padding = new System.Windows.Forms.Padding(4);
            this.tabPagePassTrafficFact.Size = new System.Drawing.Size(771, 424);
            this.tabPagePassTrafficFact.TabIndex = 0;
            this.tabPagePassTrafficFact.Text = "Пассажиропоток Факт";
            this.tabPagePassTrafficFact.UseVisualStyleBackColor = true;
            // 
            // pF_PassTrafficFactDataGridView
            // 
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pF_PassTrafficFactDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle8;
            this.pF_PassTrafficFactDataGridView.AutoGenerateColumns = false;
            this.pF_PassTrafficFactDataGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.pF_PassTrafficFactDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pF_PassTrafficFactDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Date,
            this.Month,
            this.Year,
            this.Terminal,
            this.DestinationGroup,
            this.PassQtyFact,
            this.idDataGridViewTextBoxColumn3});
            this.pF_PassTrafficFactDataGridView.DataSource = this.pF_PassTrafficFactBindingSource;
            this.pF_PassTrafficFactDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pF_PassTrafficFactDataGridView.FilterAndSortEnabled = true;
            this.pF_PassTrafficFactDataGridView.Location = new System.Drawing.Point(4, 4);
            this.pF_PassTrafficFactDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.pF_PassTrafficFactDataGridView.Name = "pF_PassTrafficFactDataGridView";
            this.pF_PassTrafficFactDataGridView.Size = new System.Drawing.Size(763, 391);
            this.pF_PassTrafficFactDataGridView.TabIndex = 8;
            this.pF_PassTrafficFactDataGridView.SortStringChanged += new System.EventHandler(this.DataGridView_SortStringChanged);
            this.pF_PassTrafficFactDataGridView.FilterStringChanged += new System.EventHandler(this.DataGridView_FilterStringChanged);
            this.pF_PassTrafficFactDataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_CellValueChanged);
            this.pF_PassTrafficFactDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.pF_PassTrafficDataGridView_DataError);
            this.pF_PassTrafficFactDataGridView.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataGridView_EditingControlShowing);
            // 
            // Date
            // 
            this.Date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Date.DataPropertyName = "Date";
            this.Date.HeaderText = "Дата";
            this.Date.MinimumWidth = 22;
            this.Date.Name = "Date";
            this.Date.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.Date.Width = 71;
            // 
            // Month
            // 
            this.Month.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Month.DataPropertyName = "Month";
            this.Month.HeaderText = "Месяц";
            this.Month.MinimumWidth = 22;
            this.Month.Name = "Month";
            this.Month.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.Month.Width = 74;
            // 
            // Year
            // 
            this.Year.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Year.DataPropertyName = "Year";
            this.Year.HeaderText = "Год";
            this.Year.MinimumWidth = 22;
            this.Year.Name = "Year";
            this.Year.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.Year.Width = 56;
            // 
            // Terminal
            // 
            this.Terminal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Terminal.DataPropertyName = "Terminal";
            this.Terminal.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.Terminal.HeaderText = "Терминал";
            this.Terminal.Items.AddRange(new object[] {
            "SVO-A",
            "SVO-B",
            "SVO-D",
            "SVO-E",
            "SVO-F"});
            this.Terminal.MinimumWidth = 22;
            this.Terminal.Name = "Terminal";
            this.Terminal.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.Terminal.Width = 99;
            // 
            // DestinationGroup
            // 
            this.DestinationGroup.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.DestinationGroup.DataPropertyName = "DestinationGroup";
            this.DestinationGroup.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.DestinationGroup.HeaderText = "ВВЛ/МВЛ";
            this.DestinationGroup.Items.AddRange(new object[] {
            "ВВЛ",
            "МВЛ"});
            this.DestinationGroup.MinimumWidth = 22;
            this.DestinationGroup.Name = "DestinationGroup";
            this.DestinationGroup.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DestinationGroup.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.DestinationGroup.Width = 93;
            // 
            // PassQtyFact
            // 
            this.PassQtyFact.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PassQtyFact.DataPropertyName = "PassQtyFact";
            this.PassQtyFact.HeaderText = "Пасспоток";
            this.PassQtyFact.MinimumWidth = 22;
            this.PassQtyFact.Name = "PassQtyFact";
            this.PassQtyFact.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // idDataGridViewTextBoxColumn3
            // 
            this.idDataGridViewTextBoxColumn3.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn3.HeaderText = "id";
            this.idDataGridViewTextBoxColumn3.MinimumWidth = 22;
            this.idDataGridViewTextBoxColumn3.Name = "idDataGridViewTextBoxColumn3";
            this.idDataGridViewTextBoxColumn3.ReadOnly = true;
            this.idDataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.idDataGridViewTextBoxColumn3.Visible = false;
            // 
            // pF_PassTrafficFactBindingSource
            // 
            this.pF_PassTrafficFactBindingSource.DataMember = "PF_PassTrafficFact";
            this.pF_PassTrafficFactBindingSource.DataSource = this.iDF_OUTDataSet;
            // 
            // bindingNavigator5
            // 
            this.bindingNavigator5.AddNewItem = this.toolStripButton29;
            this.bindingNavigator5.BindingSource = this.pF_PassTrafficFactBindingSource;
            this.bindingNavigator5.CountItem = this.toolStripLabel5;
            this.bindingNavigator5.DeleteItem = this.toolStripButton30;
            this.bindingNavigator5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bindingNavigator5.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton31,
            this.toolStripButton32,
            this.toolStripSeparator13,
            this.toolStripTextBox5,
            this.toolStripLabel5,
            this.toolStripSeparator14,
            this.toolStripButton33,
            this.toolStripButton34,
            this.toolStripSeparator15,
            this.toolStripButton29,
            this.toolStripButton30});
            this.bindingNavigator5.Location = new System.Drawing.Point(4, 395);
            this.bindingNavigator5.MoveFirstItem = this.toolStripButton31;
            this.bindingNavigator5.MoveLastItem = this.toolStripButton34;
            this.bindingNavigator5.MoveNextItem = this.toolStripButton33;
            this.bindingNavigator5.MovePreviousItem = this.toolStripButton32;
            this.bindingNavigator5.Name = "bindingNavigator5";
            this.bindingNavigator5.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.bindingNavigator5.PositionItem = this.toolStripTextBox5;
            this.bindingNavigator5.Size = new System.Drawing.Size(763, 25);
            this.bindingNavigator5.TabIndex = 8;
            this.bindingNavigator5.Text = "bindingNavigator5";
            // 
            // toolStripButton29
            // 
            this.toolStripButton29.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton29.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton29.Image")));
            this.toolStripButton29.Name = "toolStripButton29";
            this.toolStripButton29.RightToLeftAutoMirrorImage = true;
            this.toolStripButton29.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton29.Text = "Add new";
            // 
            // toolStripLabel5
            // 
            this.toolStripLabel5.Name = "toolStripLabel5";
            this.toolStripLabel5.Size = new System.Drawing.Size(35, 22);
            this.toolStripLabel5.Text = "of {0}";
            this.toolStripLabel5.ToolTipText = "Total number of items";
            // 
            // toolStripButton30
            // 
            this.toolStripButton30.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton30.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton30.Image")));
            this.toolStripButton30.Name = "toolStripButton30";
            this.toolStripButton30.RightToLeftAutoMirrorImage = true;
            this.toolStripButton30.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton30.Text = "Delete";
            // 
            // toolStripButton31
            // 
            this.toolStripButton31.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton31.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton31.Image")));
            this.toolStripButton31.Name = "toolStripButton31";
            this.toolStripButton31.RightToLeftAutoMirrorImage = true;
            this.toolStripButton31.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton31.Text = "Move first";
            // 
            // toolStripButton32
            // 
            this.toolStripButton32.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton32.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton32.Image")));
            this.toolStripButton32.Name = "toolStripButton32";
            this.toolStripButton32.RightToLeftAutoMirrorImage = true;
            this.toolStripButton32.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton32.Text = "Move previous";
            // 
            // toolStripSeparator13
            // 
            this.toolStripSeparator13.Name = "toolStripSeparator13";
            this.toolStripSeparator13.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripTextBox5
            // 
            this.toolStripTextBox5.AccessibleName = "Position";
            this.toolStripTextBox5.AutoSize = false;
            this.toolStripTextBox5.Name = "toolStripTextBox5";
            this.toolStripTextBox5.Size = new System.Drawing.Size(65, 23);
            this.toolStripTextBox5.Text = "0";
            this.toolStripTextBox5.ToolTipText = "Current position";
            // 
            // toolStripSeparator14
            // 
            this.toolStripSeparator14.Name = "toolStripSeparator14";
            this.toolStripSeparator14.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton33
            // 
            this.toolStripButton33.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton33.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton33.Image")));
            this.toolStripButton33.Name = "toolStripButton33";
            this.toolStripButton33.RightToLeftAutoMirrorImage = true;
            this.toolStripButton33.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton33.Text = "Move next";
            // 
            // toolStripButton34
            // 
            this.toolStripButton34.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton34.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton34.Image")));
            this.toolStripButton34.Name = "toolStripButton34";
            this.toolStripButton34.RightToLeftAutoMirrorImage = true;
            this.toolStripButton34.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton34.Text = "Move last";
            // 
            // toolStripSeparator15
            // 
            this.toolStripSeparator15.Name = "toolStripSeparator15";
            this.toolStripSeparator15.Size = new System.Drawing.Size(6, 25);
            // 
            // dataGridViewTextBoxColumn24
            // 
            this.dataGridViewTextBoxColumn24.DataPropertyName = "Year";
            this.dataGridViewTextBoxColumn24.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.dataGridViewTextBoxColumn24.HeaderText = "Год";
            this.dataGridViewTextBoxColumn24.Items.AddRange(new object[] {
            "2017",
            "2018",
            "2019"});
            this.dataGridViewTextBoxColumn24.MinimumWidth = 22;
            this.dataGridViewTextBoxColumn24.Name = "dataGridViewTextBoxColumn24";
            this.dataGridViewTextBoxColumn24.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn24.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn25
            // 
            this.dataGridViewTextBoxColumn25.DataPropertyName = "Month";
            this.dataGridViewTextBoxColumn25.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.dataGridViewTextBoxColumn25.HeaderText = "Месяц";
            this.dataGridViewTextBoxColumn25.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.dataGridViewTextBoxColumn25.MinimumWidth = 22;
            this.dataGridViewTextBoxColumn25.Name = "dataGridViewTextBoxColumn25";
            this.dataGridViewTextBoxColumn25.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn25.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn26
            // 
            this.dataGridViewTextBoxColumn26.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn26.DataPropertyName = "Category";
            this.dataGridViewTextBoxColumn26.DataSource = this.pFCategoryBindingSource;
            this.dataGridViewTextBoxColumn26.DisplayMember = "Description";
            this.dataGridViewTextBoxColumn26.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.dataGridViewTextBoxColumn26.HeaderText = "Категория";
            this.dataGridViewTextBoxColumn26.MinimumWidth = 22;
            this.dataGridViewTextBoxColumn26.Name = "dataGridViewTextBoxColumn26";
            this.dataGridViewTextBoxColumn26.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn26.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dataGridViewTextBoxColumn26.ValueMember = "Code";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 490);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(779, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "DestinationGroup";
            this.dataGridViewTextBoxColumn6.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.dataGridViewTextBoxColumn6.HeaderText = "МВЛ/ВВЛ";
            this.dataGridViewTextBoxColumn6.Items.AddRange(new object[] {
            "МВЛ",
            "ВВЛ"});
            this.dataGridViewTextBoxColumn6.MinimumWidth = 22;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // pF_PassTrafficFactTableAdapter
            // 
            this.pF_PassTrafficFactTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.PF_CategoryQuotaTableAdapter = this.pF_CategoryQuotaTableAdapter;
            this.tableAdapterManager.PF_CategoryTableAdapter = null;
            this.tableAdapterManager.PF_CurrencyRateTableAdapter = this.pF_CurrencyRateTableAdapter;
            this.tableAdapterManager.PF_KPITableAdapter = this.pF_KPITableAdapter;
            this.tableAdapterManager.PF_PassTrafficFactTableAdapter = this.pF_PassTrafficFactTableAdapter;
            this.tableAdapterManager.PF_PassTrafficTableAdapter = this.pF_PassTrafficTableAdapter;
            this.tableAdapterManager.PF_StoreDateActiveTableAdapter = this.pF_StoreDateActiveTableAdapter;
            this.tableAdapterManager.StoreAttribTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = IDF_KPI_t.IDF_OUTDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // pF_CategoryQuotaTableAdapter
            // 
            this.pF_CategoryQuotaTableAdapter.ClearBeforeFill = true;
            // 
            // pF_CurrencyRateTableAdapter
            // 
            this.pF_CurrencyRateTableAdapter.ClearBeforeFill = true;
            // 
            // pF_KPITableAdapter
            // 
            this.pF_KPITableAdapter.ClearBeforeFill = true;
            // 
            // pF_PassTrafficTableAdapter
            // 
            this.pF_PassTrafficTableAdapter.ClearBeforeFill = true;
            // 
            // pF_StoreDateActiveTableAdapter
            // 
            this.pF_StoreDateActiveTableAdapter.ClearBeforeFill = true;
            // 
            // pF_CategoryTableAdapter
            // 
            this.pF_CategoryTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 22;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "RateForecast";
            this.dataGridViewTextBoxColumn2.HeaderText = "Курс, прогноз";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 22;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Month";
            this.dataGridViewTextBoxColumn3.HeaderText = "Месяц";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 22;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Year";
            this.dataGridViewTextBoxColumn4.HeaderText = "Год";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 22;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn5.HeaderText = "id";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 22;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dataGridViewTextBoxColumn5.Visible = false;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn7.DataPropertyName = "PassQtyFact";
            this.dataGridViewTextBoxColumn7.HeaderText = "Пасспоток";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 22;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn8.HeaderText = "id";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 22;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dataGridViewTextBoxColumn8.Visible = false;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn9.DataPropertyName = "StoreCode";
            this.dataGridViewTextBoxColumn9.HeaderText = "Магазин";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 22;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn9.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn10.DataPropertyName = "AvgReceptPlan";
            this.dataGridViewTextBoxColumn10.HeaderText = "СЧ план";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 22;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dataGridViewTextBoxColumn10.Visible = false;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Plan";
            this.dataGridViewTextBoxColumn11.HeaderText = "План";
            this.dataGridViewTextBoxColumn11.MinimumWidth = 22;
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Forecast";
            this.dataGridViewTextBoxColumn12.HeaderText = "Прогноз";
            this.dataGridViewTextBoxColumn12.MinimumWidth = 22;
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn13.DataPropertyName = "Fact";
            this.dataGridViewTextBoxColumn13.HeaderText = "Факт";
            this.dataGridViewTextBoxColumn13.MinimumWidth = 22;
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn14.HeaderText = "id";
            this.dataGridViewTextBoxColumn14.MinimumWidth = 22;
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            this.dataGridViewTextBoxColumn14.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dataGridViewTextBoxColumn14.Visible = false;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn15.DataPropertyName = "Plan";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle9.NullValue = null;
            this.dataGridViewTextBoxColumn15.DefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridViewTextBoxColumn15.HeaderText = "План";
            this.dataGridViewTextBoxColumn15.MinimumWidth = 22;
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn16.DataPropertyName = "Forecast";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dataGridViewTextBoxColumn16.DefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridViewTextBoxColumn16.HeaderText = "Прогноз";
            this.dataGridViewTextBoxColumn16.MinimumWidth = 22;
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn17.HeaderText = "id";
            this.dataGridViewTextBoxColumn17.MinimumWidth = 22;
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.ReadOnly = true;
            this.dataGridViewTextBoxColumn17.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dataGridViewTextBoxColumn17.Visible = false;
            // 
            // calendarColumn1
            // 
            this.calendarColumn1.DataPropertyName = "Date";
            this.calendarColumn1.HeaderText = "Дата";
            this.calendarColumn1.MinimumWidth = 22;
            this.calendarColumn1.Name = "calendarColumn1";
            this.calendarColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.calendarColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 512);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMain";
            this.Text = "Plan-Forecast Data Editor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPageStoreDate.ResumeLayout(false);
            this.tabPageStoreDate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pF_StoreDateActiveDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pF_StoreDateActiveBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iDF_OUTDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pF_PassTrafficFactBindingNavigator)).EndInit();
            this.pF_PassTrafficFactBindingNavigator.ResumeLayout(false);
            this.pF_PassTrafficFactBindingNavigator.PerformLayout();
            this.tabPageCurRate.ResumeLayout(false);
            this.tabPageCurRate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pF_CurrencyRateDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pF_CurrencyRateBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.tabPageKPI.ResumeLayout(false);
            this.tabPageKPI.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pF_KPIDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pF_KPIBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator2)).EndInit();
            this.bindingNavigator2.ResumeLayout(false);
            this.bindingNavigator2.PerformLayout();
            this.tabPageCatQuota.ResumeLayout(false);
            this.tabPageCatQuota.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pF_CategoryQuotaDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pFCategoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iDF_OUTDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pF_CategoryQuotaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator3)).EndInit();
            this.bindingNavigator3.ResumeLayout(false);
            this.bindingNavigator3.PerformLayout();
            this.tabPagePassTraffic.ResumeLayout(false);
            this.tabPagePassTraffic.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pF_PassTrafficDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pF_PassTrafficBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator4)).EndInit();
            this.bindingNavigator4.ResumeLayout(false);
            this.bindingNavigator4.PerformLayout();
            this.tabPagePassTrafficFact.ResumeLayout(false);
            this.tabPagePassTrafficFact.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pF_PassTrafficFactDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pF_PassTrafficFactBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator5)).EndInit();
            this.bindingNavigator5.ResumeLayout(false);
            this.bindingNavigator5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.storeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private IDF_OUTDataSet iDF_OUTDataSet;
        private System.Windows.Forms.BindingSource pF_PassTrafficFactBindingSource;
        private IDF_OUTDataSetTableAdapters.PF_PassTrafficFactTableAdapter pF_PassTrafficFactTableAdapter;
        private IDF_OUTDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private IDF_OUTDataSetTableAdapters.PF_StoreDateActiveTableAdapter pF_StoreDateActiveTableAdapter;
        private System.Windows.Forms.BindingSource pF_StoreDateActiveBindingSource;
        private IDF_OUTDataSetTableAdapters.PF_KPITableAdapter pF_KPITableAdapter;
        private System.Windows.Forms.BindingSource pF_KPIBindingSource;
        private System.Windows.Forms.BindingSource pF_CategoryQuotaBindingSource;
        private IDF_OUTDataSetTableAdapters.PF_CategoryQuotaTableAdapter pF_CategoryQuotaTableAdapter;
        private System.Windows.Forms.BindingSource pF_CurrencyRateBindingSource;
        private IDF_OUTDataSetTableAdapters.PF_CurrencyRateTableAdapter pF_CurrencyRateTableAdapter;
        private System.Windows.Forms.BindingSource pF_PassTrafficBindingSource;
        private IDF_OUTDataSetTableAdapters.PF_PassTrafficTableAdapter pF_PassTrafficTableAdapter;

        private System.Windows.Forms.BindingSource storeBindingSource;

        private IDF_OUTDataSet iDF_OUTDataSet1;
        private System.Windows.Forms.BindingSource pFCategoryBindingSource;
        private IDF_OUTDataSetTableAdapters.PF_CategoryTableAdapter pF_CategoryTableAdapter;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbSaveData;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageStoreDate;
        //private System.Windows.Forms.DataGridView pF_StoreDateActiveDataGridView;
        private Zuby.ADGV.AdvancedDataGridView pF_StoreDateActiveDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.BindingNavigator pF_PassTrafficFactBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.TabPage tabPageCurRate;
        //private System.Windows.Forms.DataGridView pF_CurrencyRateDataGridView;
        private Zuby.ADGV.AdvancedDataGridView pF_CurrencyRateDataGridView;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.TabPage tabPageKPI;
        //private System.Windows.Forms.DataGridView pF_KPIDataGridView;
        private Zuby.ADGV.AdvancedDataGridView pF_KPIDataGridView;
        //private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        //private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn16;
        //private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn17;
        //private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        //private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        //private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        //private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        //private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.BindingNavigator bindingNavigator2;
        private System.Windows.Forms.ToolStripButton toolStripButton8;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripButton toolStripButton9;
        private System.Windows.Forms.ToolStripButton toolStripButton10;
        private System.Windows.Forms.ToolStripButton toolStripButton11;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton toolStripButton12;
        private System.Windows.Forms.ToolStripButton toolStripButton13;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.TabPage tabPageCatQuota;
        //private System.Windows.Forms.DataGridView pF_CategoryQuotaDataGridView;
        private Zuby.ADGV.AdvancedDataGridView pF_CategoryQuotaDataGridView;
        //private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn23;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn24;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn25;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn26;
        //private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn27;
        //private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn28;
        //private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;
        private System.Windows.Forms.BindingNavigator bindingNavigator3;
        private System.Windows.Forms.ToolStripButton toolStripButton15;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripButton toolStripButton16;
        private System.Windows.Forms.ToolStripButton toolStripButton17;
        private System.Windows.Forms.ToolStripButton toolStripButton18;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripButton toolStripButton19;
        private System.Windows.Forms.ToolStripButton toolStripButton20;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.TabPage tabPagePassTraffic;
        //private System.Windows.Forms.DataGridView pF_PassTrafficDataGridView;
        private Zuby.ADGV.AdvancedDataGridView pF_PassTrafficDataGridView;
        private System.Windows.Forms.BindingNavigator bindingNavigator4;
        private System.Windows.Forms.ToolStripButton toolStripButton22;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripButton toolStripButton23;
        private System.Windows.Forms.ToolStripButton toolStripButton24;
        private System.Windows.Forms.ToolStripButton toolStripButton25;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator11;
        private System.Windows.Forms.ToolStripButton toolStripButton26;
        private System.Windows.Forms.ToolStripButton toolStripButton27;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator12;
        private System.Windows.Forms.TabPage tabPagePassTrafficFact;
        //private System.Windows.Forms.DataGridView pF_PassTrafficFactDataGridView;
        private Zuby.ADGV.AdvancedDataGridView pF_PassTrafficFactDataGridView;






        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingNavigator bindingNavigator5;
        private System.Windows.Forms.ToolStripButton toolStripButton29;
        private System.Windows.Forms.ToolStripLabel toolStripLabel5;
        private System.Windows.Forms.ToolStripButton toolStripButton30;
        private System.Windows.Forms.ToolStripButton toolStripButton31;
        private System.Windows.Forms.ToolStripButton toolStripButton32;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator13;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator14;
        private System.Windows.Forms.ToolStripButton toolStripButton33;
        private System.Windows.Forms.ToolStripButton toolStripButton34;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator15;
        private System.Windows.Forms.ToolStripButton tsbRevert;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private CalendarColumn calendarColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private CalendarColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn storeCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn planDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn forecastDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn factDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn30;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn31;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn32;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn33;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn34;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn29;
        private System.Windows.Forms.ToolStripButton tsbAutoRowAddMode;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private CalendarColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Month;
        private System.Windows.Forms.DataGridViewTextBoxColumn Year;
        private System.Windows.Forms.DataGridViewComboBoxColumn Terminal;
        private System.Windows.Forms.DataGridViewComboBoxColumn DestinationGroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn PassQtyFact;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewComboBoxColumn yearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn monthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn storeCodeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn avgReceptPlanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn avgReceptForecastDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn convCoeffPlanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn convCoeffForecastDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn36;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn37;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn38;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn39;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn40;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn41;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn35;
        private System.Windows.Forms.DataGridViewComboBoxColumn yearDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn monthDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn categoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn storeCodeDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn quotaPlanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quotaForecastDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn2;
        private System.Windows.Forms.ToolStripButton tsbLoadExcel;
    }
}

