namespace SPECSON_WorkFlow_Manager
{
    partial class MainPage
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.beforeStartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cOMPortSelectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gasTypesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tab_Main = new System.Windows.Forms.TabControl();
            this.tabPage_ManualControl = new System.Windows.Forms.TabPage();
            this.button_Stop = new System.Windows.Forms.Button();
            this.button_Start = new System.Windows.Forms.Button();
            this.label29 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox_COMPort = new System.Windows.Forms.TextBox();
            this.label_COMPort = new System.Windows.Forms.Label();
            this.textBox_BaudRate = new System.Windows.Forms.TextBox();
            this.label_BaudRate = new System.Windows.Forms.Label();
            this.textBox_Parity = new System.Windows.Forms.TextBox();
            this.label_Parity = new System.Windows.Forms.Label();
            this.textBox_DataBits = new System.Windows.Forms.TextBox();
            this.label_DataBits = new System.Windows.Forms.Label();
            this.textBox_StopBit = new System.Windows.Forms.TextBox();
            this.label_StopBit = new System.Windows.Forms.Label();
            this.groupBox_Temperature = new System.Windows.Forms.GroupBox();
            this.label_CellTemp = new System.Windows.Forms.Label();
            this.textBox_CellTemp = new System.Windows.Forms.TextBox();
            this.label_ResistanceTemp = new System.Windows.Forms.Label();
            this.button11 = new System.Windows.Forms.Button();
            this.textBox_ResistanceTemp = new System.Windows.Forms.TextBox();
            this.button10 = new System.Windows.Forms.Button();
            this.button_TempSet = new System.Windows.Forms.Button();
            this.numericUpDown_TempRamp = new System.Windows.Forms.NumericUpDown();
            this.label_TempRamp = new System.Windows.Forms.Label();
            this.numericUpDown_TempTarget = new System.Windows.Forms.NumericUpDown();
            this.checkBox_TempRamp = new System.Windows.Forms.CheckBox();
            this.label26 = new System.Windows.Forms.Label();
            this.textBox_OpTime = new System.Windows.Forms.TextBox();
            this.button_MFCSetAll = new System.Windows.Forms.Button();
            this.groupBox_MFC5 = new System.Windows.Forms.GroupBox();
            this.label24 = new System.Windows.Forms.Label();
            this.textBox_MFC5Percentage = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.textBox_MFC5ActualFlow = new System.Windows.Forms.TextBox();
            this.textBox_MFC5GasName = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.numericUpDown_MFC5FlowRate = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox_MFC5Time = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.button_MFCSet = new System.Windows.Forms.Button();
            this.groupBox_MFC4 = new System.Windows.Forms.GroupBox();
            this.label23 = new System.Windows.Forms.Label();
            this.textBox_MFC4Percentage = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.textBox_MFC4GasName = new System.Windows.Forms.TextBox();
            this.textBox_MFC4ActualFlow = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.numericUpDown_MFC4FlowRate = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox_MFC4Time = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.button_MFC4Set = new System.Windows.Forms.Button();
            this.groupBox_MFC3 = new System.Windows.Forms.GroupBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.textBox_MFC3Percentage = new System.Windows.Forms.TextBox();
            this.textBox_MFC3ActualFlow = new System.Windows.Forms.TextBox();
            this.textBox_MFC3GasName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.numericUpDown_MFC3FlowRate = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_MFC3Time = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.button_MFC3Set = new System.Windows.Forms.Button();
            this.groupBox_MFC2 = new System.Windows.Forms.GroupBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.textBox_MFC2Percentage = new System.Windows.Forms.TextBox();
            this.textBox_MFC2GasName = new System.Windows.Forms.TextBox();
            this.textBox_MFC2ActualFlow = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDown_MFC2FlowRate = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_MFC2Time = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.button_MFC2Set = new System.Windows.Forms.Button();
            this.groupBox_MFC1 = new System.Windows.Forms.GroupBox();
            this.label_MFC1Percentage = new System.Windows.Forms.Label();
            this.textBox_MFC1Percentage = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.textBox_MFC1ActualFlow = new System.Windows.Forms.TextBox();
            this.textBox_MFC1GasName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown_MFC1FlowRate = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_MFC1Time = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox_MFC1Time = new System.Windows.Forms.CheckBox();
            this.button_MFC1Set = new System.Windows.Forms.Button();
            this.tabPage_Automation = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.numericUpDown_MFC1fq = new System.Windows.Forms.NumericUpDown();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.textBox_AutoCellTemp = new System.Windows.Forms.TextBox();
            this.label34 = new System.Windows.Forms.Label();
            this.textBox_AutoResistanceTemp = new System.Windows.Forms.TextBox();
            this.label33 = new System.Windows.Forms.Label();
            this.groupBox_Operation = new System.Windows.Forms.GroupBox();
            this.textBox_AutoTime = new System.Windows.Forms.TextBox();
            this.AutoStepNum = new System.Windows.Forms.TextBox();
            this.button_SkipNextStep = new System.Windows.Forms.Button();
            this.label35 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.label44 = new System.Windows.Forms.Label();
            this.textBox_AutoMFC5Percentage = new System.Windows.Forms.TextBox();
            this.label45 = new System.Windows.Forms.Label();
            this.textBox_AutoMFC5ActualFlow = new System.Windows.Forms.TextBox();
            this.textBox_AutoMFC5GasName = new System.Windows.Forms.TextBox();
            this.label46 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label31 = new System.Windows.Forms.Label();
            this.textBox_AutoMFC4Percentage = new System.Windows.Forms.TextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.textBox_AutoMFC4ActualFlow = new System.Windows.Forms.TextBox();
            this.textBox_AutoMFC4GasName = new System.Windows.Forms.TextBox();
            this.label43 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label27 = new System.Windows.Forms.Label();
            this.textBox_AutoMFC3Percentage = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.textBox_AutoMFC3ActualFlow = new System.Windows.Forms.TextBox();
            this.textBox_AutoMFC3GasName = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label39 = new System.Windows.Forms.Label();
            this.textBox_AutoMFC2Percentage = new System.Windows.Forms.TextBox();
            this.label40 = new System.Windows.Forms.Label();
            this.textBox_AutoMFC2ActualFlow = new System.Windows.Forms.TextBox();
            this.textBox_AutoMFC2GasName = new System.Windows.Forms.TextBox();
            this.label42 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label37 = new System.Windows.Forms.Label();
            this.textBox_AutoMFC1Percentage = new System.Windows.Forms.TextBox();
            this.label38 = new System.Windows.Forms.Label();
            this.textBox_AutoMFC1ActualFlow = new System.Windows.Forms.TextBox();
            this.textBox_AutoMFC1GasName = new System.Windows.Forms.TextBox();
            this.label41 = new System.Windows.Forms.Label();
            this.button_AutomationStop = new System.Windows.Forms.Button();
            this.button_BrowseAndLoadFile = new System.Windows.Forms.Button();
            this.button_AutomationStart = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage_GraphData = new System.Windows.Forms.TabPage();
            this.label_graphTemp = new System.Windows.Forms.Label();
            this.label_graphMFC5 = new System.Windows.Forms.Label();
            this.label_graphMFC4 = new System.Windows.Forms.Label();
            this.label_graphMFC3 = new System.Windows.Forms.Label();
            this.label_graphMFC2 = new System.Windows.Forms.Label();
            this.label_graphMFC1 = new System.Windows.Forms.Label();
            this.chart_Temp = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart_MFC5 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart_MFC4 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart_MFC3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart_MFC2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button_exportMFC1 = new System.Windows.Forms.Button();
            this.chart_MFC1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridView_All = new System.Windows.Forms.DataGridView();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MFC1_Actual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MFC2_Actual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MFC3_Actual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MFC4_Actual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bos2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Temp_Out = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Temp_Set = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MFC1_Set = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MFC2_Set = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MFC3_Set = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MFC4_Set = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timer_Write = new System.Windows.Forms.Timer(this.components);
            this.timer_Read = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.tab_Main.SuspendLayout();
            this.tabPage_ManualControl.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox_Temperature.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_TempRamp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_TempTarget)).BeginInit();
            this.groupBox_MFC5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_MFC5FlowRate)).BeginInit();
            this.groupBox_MFC4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_MFC4FlowRate)).BeginInit();
            this.groupBox_MFC3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_MFC3FlowRate)).BeginInit();
            this.groupBox_MFC2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_MFC2FlowRate)).BeginInit();
            this.groupBox_MFC1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_MFC1FlowRate)).BeginInit();
            this.tabPage_Automation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_MFC1fq)).BeginInit();
            this.groupBox9.SuspendLayout();
            this.groupBox_Operation.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage_GraphData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_Temp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_MFC5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_MFC4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_MFC3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_MFC2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_MFC1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_All)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.beforeStartToolStripMenuItem,
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1202, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // beforeStartToolStripMenuItem
            // 
            this.beforeStartToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cOMPortSelectionToolStripMenuItem,
            this.gasTypesToolStripMenuItem});
            this.beforeStartToolStripMenuItem.Name = "beforeStartToolStripMenuItem";
            this.beforeStartToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.beforeStartToolStripMenuItem.Text = "Before Start!";
            // 
            // cOMPortSelectionToolStripMenuItem
            // 
            this.cOMPortSelectionToolStripMenuItem.Name = "cOMPortSelectionToolStripMenuItem";
            this.cOMPortSelectionToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.cOMPortSelectionToolStripMenuItem.Text = "COM Port Selection";
            this.cOMPortSelectionToolStripMenuItem.Click += new System.EventHandler(this.Click_COMPortSelection);
            // 
            // gasTypesToolStripMenuItem
            // 
            this.gasTypesToolStripMenuItem.Name = "gasTypesToolStripMenuItem";
            this.gasTypesToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.gasTypesToolStripMenuItem.Text = "Gas Types";
            this.gasTypesToolStripMenuItem.Click += new System.EventHandler(this.Click_GasTypes);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.loadToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.newToolStripMenuItem.Text = "New";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.loadToolStripMenuItem.Text = "Load";
            // 
            // tab_Main
            // 
            this.tab_Main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tab_Main.Controls.Add(this.tabPage_ManualControl);
            this.tab_Main.Controls.Add(this.tabPage_Automation);
            this.tab_Main.Controls.Add(this.tabPage_GraphData);
            this.tab_Main.Location = new System.Drawing.Point(-3, 27);
            this.tab_Main.Name = "tab_Main";
            this.tab_Main.SelectedIndex = 0;
            this.tab_Main.Size = new System.Drawing.Size(1208, 726);
            this.tab_Main.TabIndex = 1;
            // 
            // tabPage_ManualControl
            // 
            this.tabPage_ManualControl.BackColor = System.Drawing.Color.Black;
            this.tabPage_ManualControl.BackgroundImage = global::SPECSON_WorkFlow_Manager.Properties.Resources.Adsız_tasarım__5_;
            this.tabPage_ManualControl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage_ManualControl.Controls.Add(this.button_Stop);
            this.tabPage_ManualControl.Controls.Add(this.button_Start);
            this.tabPage_ManualControl.Controls.Add(this.label29);
            this.tabPage_ManualControl.Controls.Add(this.groupBox2);
            this.tabPage_ManualControl.Controls.Add(this.groupBox_Temperature);
            this.tabPage_ManualControl.Controls.Add(this.textBox_OpTime);
            this.tabPage_ManualControl.Controls.Add(this.button_MFCSetAll);
            this.tabPage_ManualControl.Controls.Add(this.groupBox_MFC5);
            this.tabPage_ManualControl.Controls.Add(this.groupBox_MFC4);
            this.tabPage_ManualControl.Controls.Add(this.groupBox_MFC3);
            this.tabPage_ManualControl.Controls.Add(this.groupBox_MFC2);
            this.tabPage_ManualControl.Controls.Add(this.groupBox_MFC1);
            this.tabPage_ManualControl.Location = new System.Drawing.Point(4, 22);
            this.tabPage_ManualControl.Name = "tabPage_ManualControl";
            this.tabPage_ManualControl.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_ManualControl.Size = new System.Drawing.Size(1200, 700);
            this.tabPage_ManualControl.TabIndex = 0;
            this.tabPage_ManualControl.Text = "Manual Control";
            this.tabPage_ManualControl.Click += new System.EventHandler(this.tabPage_ManualControl_Click);
            // 
            // button_Stop
            // 
            this.button_Stop.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_Stop.Location = new System.Drawing.Point(1025, 527);
            this.button_Stop.Name = "button_Stop";
            this.button_Stop.Size = new System.Drawing.Size(120, 30);
            this.button_Stop.TabIndex = 88;
            this.button_Stop.Text = "STOP";
            this.button_Stop.UseVisualStyleBackColor = true;
            this.button_Stop.Click += new System.EventHandler(this.click_Stop);
            // 
            // button_Start
            // 
            this.button_Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_Start.Location = new System.Drawing.Point(899, 527);
            this.button_Start.Name = "button_Start";
            this.button_Start.Size = new System.Drawing.Size(120, 30);
            this.button_Start.TabIndex = 87;
            this.button_Start.Text = "START";
            this.button_Start.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button_Start.UseVisualStyleBackColor = true;
            this.button_Start.Click += new System.EventHandler(this.Click_Start);
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.BackColor = System.Drawing.Color.Transparent;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label29.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label29.Location = new System.Drawing.Point(937, 478);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(168, 18);
            this.label29.TabIndex = 34;
            this.label29.Text = "Operation Time (min)";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.textBox_COMPort);
            this.groupBox2.Controls.Add(this.label_COMPort);
            this.groupBox2.Controls.Add(this.textBox_BaudRate);
            this.groupBox2.Controls.Add(this.label_BaudRate);
            this.groupBox2.Controls.Add(this.textBox_Parity);
            this.groupBox2.Controls.Add(this.label_Parity);
            this.groupBox2.Controls.Add(this.textBox_DataBits);
            this.groupBox2.Controls.Add(this.label_DataBits);
            this.groupBox2.Controls.Add(this.textBox_StopBit);
            this.groupBox2.Controls.Add(this.label_StopBit);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox2.Location = new System.Drawing.Point(855, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(337, 181);
            this.groupBox2.TabIndex = 47;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "COM Port Paramaters";
            // 
            // textBox_COMPort
            // 
            this.textBox_COMPort.Location = new System.Drawing.Point(168, 34);
            this.textBox_COMPort.Name = "textBox_COMPort";
            this.textBox_COMPort.Size = new System.Drawing.Size(100, 22);
            this.textBox_COMPort.TabIndex = 0;
            // 
            // label_COMPort
            // 
            this.label_COMPort.AutoSize = true;
            this.label_COMPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_COMPort.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label_COMPort.Location = new System.Drawing.Point(81, 35);
            this.label_COMPort.Name = "label_COMPort";
            this.label_COMPort.Size = new System.Drawing.Size(76, 16);
            this.label_COMPort.TabIndex = 1;
            this.label_COMPort.Text = "COM Port ";
            // 
            // textBox_BaudRate
            // 
            this.textBox_BaudRate.Location = new System.Drawing.Point(168, 60);
            this.textBox_BaudRate.Name = "textBox_BaudRate";
            this.textBox_BaudRate.Size = new System.Drawing.Size(100, 22);
            this.textBox_BaudRate.TabIndex = 2;
            // 
            // label_BaudRate
            // 
            this.label_BaudRate.AutoSize = true;
            this.label_BaudRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_BaudRate.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label_BaudRate.Location = new System.Drawing.Point(81, 61);
            this.label_BaudRate.Name = "label_BaudRate";
            this.label_BaudRate.Size = new System.Drawing.Size(80, 16);
            this.label_BaudRate.TabIndex = 3;
            this.label_BaudRate.Text = "Baud Rate";
            // 
            // textBox_Parity
            // 
            this.textBox_Parity.Location = new System.Drawing.Point(168, 86);
            this.textBox_Parity.Name = "textBox_Parity";
            this.textBox_Parity.Size = new System.Drawing.Size(100, 22);
            this.textBox_Parity.TabIndex = 4;
            // 
            // label_Parity
            // 
            this.label_Parity.AutoSize = true;
            this.label_Parity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_Parity.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label_Parity.Location = new System.Drawing.Point(81, 87);
            this.label_Parity.Name = "label_Parity";
            this.label_Parity.Size = new System.Drawing.Size(47, 16);
            this.label_Parity.TabIndex = 5;
            this.label_Parity.Text = "Parity";
            // 
            // textBox_DataBits
            // 
            this.textBox_DataBits.Location = new System.Drawing.Point(168, 112);
            this.textBox_DataBits.Name = "textBox_DataBits";
            this.textBox_DataBits.Size = new System.Drawing.Size(100, 22);
            this.textBox_DataBits.TabIndex = 6;
            // 
            // label_DataBits
            // 
            this.label_DataBits.AutoSize = true;
            this.label_DataBits.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_DataBits.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label_DataBits.Location = new System.Drawing.Point(81, 113);
            this.label_DataBits.Name = "label_DataBits";
            this.label_DataBits.Size = new System.Drawing.Size(70, 16);
            this.label_DataBits.TabIndex = 7;
            this.label_DataBits.Text = "Data Bits";
            // 
            // textBox_StopBit
            // 
            this.textBox_StopBit.Location = new System.Drawing.Point(168, 138);
            this.textBox_StopBit.Name = "textBox_StopBit";
            this.textBox_StopBit.Size = new System.Drawing.Size(100, 22);
            this.textBox_StopBit.TabIndex = 8;
            // 
            // label_StopBit
            // 
            this.label_StopBit.AutoSize = true;
            this.label_StopBit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_StopBit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label_StopBit.Location = new System.Drawing.Point(81, 139);
            this.label_StopBit.Name = "label_StopBit";
            this.label_StopBit.Size = new System.Drawing.Size(61, 16);
            this.label_StopBit.TabIndex = 9;
            this.label_StopBit.Text = "Stop Bit";
            // 
            // groupBox_Temperature
            // 
            this.groupBox_Temperature.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox_Temperature.BackColor = System.Drawing.Color.Transparent;
            this.groupBox_Temperature.Controls.Add(this.label_CellTemp);
            this.groupBox_Temperature.Controls.Add(this.textBox_CellTemp);
            this.groupBox_Temperature.Controls.Add(this.label_ResistanceTemp);
            this.groupBox_Temperature.Controls.Add(this.button11);
            this.groupBox_Temperature.Controls.Add(this.textBox_ResistanceTemp);
            this.groupBox_Temperature.Controls.Add(this.button10);
            this.groupBox_Temperature.Controls.Add(this.button_TempSet);
            this.groupBox_Temperature.Controls.Add(this.numericUpDown_TempRamp);
            this.groupBox_Temperature.Controls.Add(this.label_TempRamp);
            this.groupBox_Temperature.Controls.Add(this.numericUpDown_TempTarget);
            this.groupBox_Temperature.Controls.Add(this.checkBox_TempRamp);
            this.groupBox_Temperature.Controls.Add(this.label26);
            this.groupBox_Temperature.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox_Temperature.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox_Temperature.Location = new System.Drawing.Point(855, 286);
            this.groupBox_Temperature.Name = "groupBox_Temperature";
            this.groupBox_Temperature.Size = new System.Drawing.Size(337, 181);
            this.groupBox_Temperature.TabIndex = 36;
            this.groupBox_Temperature.TabStop = false;
            this.groupBox_Temperature.Text = "Temperature (0-700°C)";
            // 
            // label_CellTemp
            // 
            this.label_CellTemp.AutoSize = true;
            this.label_CellTemp.Enabled = false;
            this.label_CellTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_CellTemp.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label_CellTemp.Location = new System.Drawing.Point(191, 134);
            this.label_CellTemp.Name = "label_CellTemp";
            this.label_CellTemp.Size = new System.Drawing.Size(78, 16);
            this.label_CellTemp.TabIndex = 46;
            this.label_CellTemp.Text = "Cell Temp";
            // 
            // textBox_CellTemp
            // 
            this.textBox_CellTemp.Enabled = false;
            this.textBox_CellTemp.Location = new System.Drawing.Point(170, 153);
            this.textBox_CellTemp.Name = "textBox_CellTemp";
            this.textBox_CellTemp.Size = new System.Drawing.Size(120, 22);
            this.textBox_CellTemp.TabIndex = 45;
            this.textBox_CellTemp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_ResistanceTemp
            // 
            this.label_ResistanceTemp.AutoSize = true;
            this.label_ResistanceTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_ResistanceTemp.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label_ResistanceTemp.Location = new System.Drawing.Point(41, 134);
            this.label_ResistanceTemp.Name = "label_ResistanceTemp";
            this.label_ResistanceTemp.Size = new System.Drawing.Size(129, 16);
            this.label_ResistanceTemp.TabIndex = 37;
            this.label_ResistanceTemp.Text = "Resistance Temp";
            // 
            // button11
            // 
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button11.Location = new System.Drawing.Point(188, 81);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(80, 44);
            this.button11.TabIndex = 44;
            this.button11.Text = "GO-TO \r\n105°C";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.Click_GoTo105);
            // 
            // textBox_ResistanceTemp
            // 
            this.textBox_ResistanceTemp.Location = new System.Drawing.Point(43, 153);
            this.textBox_ResistanceTemp.Name = "textBox_ResistanceTemp";
            this.textBox_ResistanceTemp.Size = new System.Drawing.Size(121, 22);
            this.textBox_ResistanceTemp.TabIndex = 36;
            this.textBox_ResistanceTemp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button10
            // 
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button10.Location = new System.Drawing.Point(65, 81);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(80, 44);
            this.button10.TabIndex = 43;
            this.button10.Text = "COOL \r\n25°C";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.Click_TempCool25);
            // 
            // button_TempSet
            // 
            this.button_TempSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_TempSet.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_TempSet.Location = new System.Drawing.Point(232, 21);
            this.button_TempSet.Name = "button_TempSet";
            this.button_TempSet.Size = new System.Drawing.Size(80, 51);
            this.button_TempSet.TabIndex = 36;
            this.button_TempSet.Text = "SET";
            this.button_TempSet.UseVisualStyleBackColor = true;
            this.button_TempSet.Click += new System.EventHandler(this.Click_TempSet);
            // 
            // numericUpDown_TempRamp
            // 
            this.numericUpDown_TempRamp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numericUpDown_TempRamp.Location = new System.Drawing.Point(151, 49);
            this.numericUpDown_TempRamp.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown_TempRamp.Name = "numericUpDown_TempRamp";
            this.numericUpDown_TempRamp.Size = new System.Drawing.Size(75, 22);
            this.numericUpDown_TempRamp.TabIndex = 42;
            // 
            // label_TempRamp
            // 
            this.label_TempRamp.AutoSize = true;
            this.label_TempRamp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_TempRamp.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label_TempRamp.Location = new System.Drawing.Point(44, 51);
            this.label_TempRamp.Name = "label_TempRamp";
            this.label_TempRamp.Size = new System.Drawing.Size(107, 16);
            this.label_TempRamp.TabIndex = 40;
            this.label_TempRamp.Text = "Ramp (sec/°C)";
            // 
            // numericUpDown_TempTarget
            // 
            this.numericUpDown_TempTarget.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numericUpDown_TempTarget.Location = new System.Drawing.Point(151, 21);
            this.numericUpDown_TempTarget.Maximum = new decimal(new int[] {
            700,
            0,
            0,
            0});
            this.numericUpDown_TempTarget.Name = "numericUpDown_TempTarget";
            this.numericUpDown_TempTarget.Size = new System.Drawing.Size(75, 22);
            this.numericUpDown_TempTarget.TabIndex = 36;
            // 
            // checkBox_TempRamp
            // 
            this.checkBox_TempRamp.AutoSize = true;
            this.checkBox_TempRamp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBox_TempRamp.Location = new System.Drawing.Point(29, 53);
            this.checkBox_TempRamp.Name = "checkBox_TempRamp";
            this.checkBox_TempRamp.Size = new System.Drawing.Size(15, 14);
            this.checkBox_TempRamp.TabIndex = 38;
            this.checkBox_TempRamp.UseVisualStyleBackColor = true;
            this.checkBox_TempRamp.CheckStateChanged += new System.EventHandler(this.CheckStateChanged_Ramp);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label26.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label26.Location = new System.Drawing.Point(22, 23);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(126, 16);
            this.label26.TabIndex = 39;
            this.label26.Text = "Target Temp (°C)";
            // 
            // textBox_OpTime
            // 
            this.textBox_OpTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_OpTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_OpTime.Location = new System.Drawing.Point(899, 499);
            this.textBox_OpTime.Name = "textBox_OpTime";
            this.textBox_OpTime.Size = new System.Drawing.Size(246, 24);
            this.textBox_OpTime.TabIndex = 23;
            this.textBox_OpTime.Text = "00 : 00 : 00";
            this.textBox_OpTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button_MFCSetAll
            // 
            this.button_MFCSetAll.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_MFCSetAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_MFCSetAll.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_MFCSetAll.Location = new System.Drawing.Point(132, 666);
            this.button_MFCSetAll.Name = "button_MFCSetAll";
            this.button_MFCSetAll.Size = new System.Drawing.Size(175, 23);
            this.button_MFCSetAll.TabIndex = 18;
            this.button_MFCSetAll.Text = "SET ALL";
            this.button_MFCSetAll.UseVisualStyleBackColor = true;
            this.button_MFCSetAll.Click += new System.EventHandler(this.Click_SetAll);
            // 
            // groupBox_MFC5
            // 
            this.groupBox_MFC5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox_MFC5.BackColor = System.Drawing.Color.Transparent;
            this.groupBox_MFC5.Controls.Add(this.label24);
            this.groupBox_MFC5.Controls.Add(this.textBox_MFC5Percentage);
            this.groupBox_MFC5.Controls.Add(this.label20);
            this.groupBox_MFC5.Controls.Add(this.textBox_MFC5ActualFlow);
            this.groupBox_MFC5.Controls.Add(this.textBox_MFC5GasName);
            this.groupBox_MFC5.Controls.Add(this.label13);
            this.groupBox_MFC5.Controls.Add(this.numericUpDown_MFC5FlowRate);
            this.groupBox_MFC5.Controls.Add(this.label14);
            this.groupBox_MFC5.Controls.Add(this.textBox_MFC5Time);
            this.groupBox_MFC5.Controls.Add(this.label15);
            this.groupBox_MFC5.Controls.Add(this.checkBox5);
            this.groupBox_MFC5.Controls.Add(this.button_MFCSet);
            this.groupBox_MFC5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox_MFC5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox_MFC5.Location = new System.Drawing.Point(11, 532);
            this.groupBox_MFC5.Name = "groupBox_MFC5";
            this.groupBox_MFC5.Size = new System.Drawing.Size(415, 128);
            this.groupBox_MFC5.TabIndex = 21;
            this.groupBox_MFC5.TabStop = false;
            this.groupBox_MFC5.Text = "MFC5 ( - )";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label24.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label24.Location = new System.Drawing.Point(247, 25);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(87, 16);
            this.label24.TabIndex = 35;
            this.label24.Text = "Percentage";
            // 
            // textBox_MFC5Percentage
            // 
            this.textBox_MFC5Percentage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_MFC5Percentage.Location = new System.Drawing.Point(245, 44);
            this.textBox_MFC5Percentage.Name = "textBox_MFC5Percentage";
            this.textBox_MFC5Percentage.Size = new System.Drawing.Size(92, 22);
            this.textBox_MFC5Percentage.TabIndex = 34;
            this.textBox_MFC5Percentage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label20.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label20.Location = new System.Drawing.Point(73, 103);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(86, 16);
            this.label20.TabIndex = 32;
            this.label20.Text = "Actual Flow";
            // 
            // textBox_MFC5ActualFlow
            // 
            this.textBox_MFC5ActualFlow.Location = new System.Drawing.Point(165, 100);
            this.textBox_MFC5ActualFlow.Name = "textBox_MFC5ActualFlow";
            this.textBox_MFC5ActualFlow.Size = new System.Drawing.Size(75, 22);
            this.textBox_MFC5ActualFlow.TabIndex = 31;
            this.textBox_MFC5ActualFlow.Text = "0";
            this.textBox_MFC5ActualFlow.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_MFC5GasName
            // 
            this.textBox_MFC5GasName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_MFC5GasName.Location = new System.Drawing.Point(84, 44);
            this.textBox_MFC5GasName.Name = "textBox_MFC5GasName";
            this.textBox_MFC5GasName.Size = new System.Drawing.Size(155, 22);
            this.textBox_MFC5GasName.TabIndex = 10;
            this.textBox_MFC5GasName.Text = "Disable";
            this.textBox_MFC5GasName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_MFC5GasName.TextChanged += new System.EventHandler(this.TextChanged_MFC5GasNam);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label13.Location = new System.Drawing.Point(258, 75);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(80, 16);
            this.label13.TabIndex = 17;
            this.label13.Text = "Time (min)";
            // 
            // numericUpDown_MFC5FlowRate
            // 
            this.numericUpDown_MFC5FlowRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numericUpDown_MFC5FlowRate.Location = new System.Drawing.Point(84, 73);
            this.numericUpDown_MFC5FlowRate.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDown_MFC5FlowRate.Name = "numericUpDown_MFC5FlowRate";
            this.numericUpDown_MFC5FlowRate.Size = new System.Drawing.Size(75, 22);
            this.numericUpDown_MFC5FlowRate.TabIndex = 11;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label14.Location = new System.Drawing.Point(5, 78);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(76, 16);
            this.label14.TabIndex = 16;
            this.label14.Text = "Flow Rate";
            // 
            // textBox_MFC5Time
            // 
            this.textBox_MFC5Time.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_MFC5Time.Location = new System.Drawing.Point(165, 72);
            this.textBox_MFC5Time.Name = "textBox_MFC5Time";
            this.textBox_MFC5Time.Size = new System.Drawing.Size(75, 22);
            this.textBox_MFC5Time.TabIndex = 12;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label15.Location = new System.Drawing.Point(85, 25);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(80, 16);
            this.label15.TabIndex = 15;
            this.label15.Text = "Gas Name";
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBox5.Location = new System.Drawing.Point(245, 77);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(15, 14);
            this.checkBox5.TabIndex = 13;
            this.checkBox5.UseVisualStyleBackColor = true;
            this.checkBox5.CheckStateChanged += new System.EventHandler(this.CheckStateChanged_MFC5Time);
            // 
            // button_MFCSet
            // 
            this.button_MFCSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_MFCSet.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_MFCSet.Location = new System.Drawing.Point(343, 72);
            this.button_MFCSet.Name = "button_MFCSet";
            this.button_MFCSet.Size = new System.Drawing.Size(65, 23);
            this.button_MFCSet.TabIndex = 14;
            this.button_MFCSet.Text = "SET";
            this.button_MFCSet.UseVisualStyleBackColor = true;
            this.button_MFCSet.Click += new System.EventHandler(this.Click_SetMFC5);
            // 
            // groupBox_MFC4
            // 
            this.groupBox_MFC4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox_MFC4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox_MFC4.Controls.Add(this.label23);
            this.groupBox_MFC4.Controls.Add(this.textBox_MFC4Percentage);
            this.groupBox_MFC4.Controls.Add(this.label18);
            this.groupBox_MFC4.Controls.Add(this.textBox_MFC4GasName);
            this.groupBox_MFC4.Controls.Add(this.textBox_MFC4ActualFlow);
            this.groupBox_MFC4.Controls.Add(this.label10);
            this.groupBox_MFC4.Controls.Add(this.numericUpDown_MFC4FlowRate);
            this.groupBox_MFC4.Controls.Add(this.label11);
            this.groupBox_MFC4.Controls.Add(this.textBox_MFC4Time);
            this.groupBox_MFC4.Controls.Add(this.label12);
            this.groupBox_MFC4.Controls.Add(this.checkBox4);
            this.groupBox_MFC4.Controls.Add(this.button_MFC4Set);
            this.groupBox_MFC4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox_MFC4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox_MFC4.Location = new System.Drawing.Point(11, 402);
            this.groupBox_MFC4.Name = "groupBox_MFC4";
            this.groupBox_MFC4.Size = new System.Drawing.Size(415, 131);
            this.groupBox_MFC4.TabIndex = 20;
            this.groupBox_MFC4.TabStop = false;
            this.groupBox_MFC4.Text = "MFC4 (20 sscm)";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label23.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label23.Location = new System.Drawing.Point(247, 18);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(87, 16);
            this.label23.TabIndex = 35;
            this.label23.Text = "Percentage";
            // 
            // textBox_MFC4Percentage
            // 
            this.textBox_MFC4Percentage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_MFC4Percentage.Location = new System.Drawing.Point(245, 37);
            this.textBox_MFC4Percentage.Name = "textBox_MFC4Percentage";
            this.textBox_MFC4Percentage.Size = new System.Drawing.Size(93, 22);
            this.textBox_MFC4Percentage.TabIndex = 34;
            this.textBox_MFC4Percentage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label18.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label18.Location = new System.Drawing.Point(71, 97);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(86, 16);
            this.label18.TabIndex = 28;
            this.label18.Text = "Actual Flow";
            // 
            // textBox_MFC4GasName
            // 
            this.textBox_MFC4GasName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_MFC4GasName.Location = new System.Drawing.Point(82, 37);
            this.textBox_MFC4GasName.Name = "textBox_MFC4GasName";
            this.textBox_MFC4GasName.Size = new System.Drawing.Size(157, 22);
            this.textBox_MFC4GasName.TabIndex = 10;
            this.textBox_MFC4GasName.Text = "Disable";
            this.textBox_MFC4GasName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_MFC4GasName.TextChanged += new System.EventHandler(this.TextChanged_MFC4GasNam);
            // 
            // textBox_MFC4ActualFlow
            // 
            this.textBox_MFC4ActualFlow.Location = new System.Drawing.Point(164, 94);
            this.textBox_MFC4ActualFlow.Name = "textBox_MFC4ActualFlow";
            this.textBox_MFC4ActualFlow.Size = new System.Drawing.Size(75, 22);
            this.textBox_MFC4ActualFlow.TabIndex = 27;
            this.textBox_MFC4ActualFlow.Text = "0";
            this.textBox_MFC4ActualFlow.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label10.Location = new System.Drawing.Point(257, 69);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 16);
            this.label10.TabIndex = 17;
            this.label10.Text = "Time (min)";
            // 
            // numericUpDown_MFC4FlowRate
            // 
            this.numericUpDown_MFC4FlowRate.DecimalPlaces = 1;
            this.numericUpDown_MFC4FlowRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numericUpDown_MFC4FlowRate.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDown_MFC4FlowRate.Location = new System.Drawing.Point(83, 67);
            this.numericUpDown_MFC4FlowRate.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDown_MFC4FlowRate.Name = "numericUpDown_MFC4FlowRate";
            this.numericUpDown_MFC4FlowRate.Size = new System.Drawing.Size(75, 22);
            this.numericUpDown_MFC4FlowRate.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label11.Location = new System.Drawing.Point(4, 72);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 16);
            this.label11.TabIndex = 16;
            this.label11.Text = "Flow Rate";
            // 
            // textBox_MFC4Time
            // 
            this.textBox_MFC4Time.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_MFC4Time.Location = new System.Drawing.Point(164, 66);
            this.textBox_MFC4Time.Name = "textBox_MFC4Time";
            this.textBox_MFC4Time.Size = new System.Drawing.Size(75, 22);
            this.textBox_MFC4Time.TabIndex = 12;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label12.Location = new System.Drawing.Point(118, 18);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 16);
            this.label12.TabIndex = 15;
            this.label12.Text = "Gas Name";
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBox4.Location = new System.Drawing.Point(245, 71);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(15, 14);
            this.checkBox4.TabIndex = 13;
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckStateChanged += new System.EventHandler(this.CheckStateChanged_MFC4Time);
            // 
            // button_MFC4Set
            // 
            this.button_MFC4Set.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_MFC4Set.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_MFC4Set.Location = new System.Drawing.Point(343, 67);
            this.button_MFC4Set.Name = "button_MFC4Set";
            this.button_MFC4Set.Size = new System.Drawing.Size(65, 23);
            this.button_MFC4Set.TabIndex = 14;
            this.button_MFC4Set.Text = "SET";
            this.button_MFC4Set.UseVisualStyleBackColor = true;
            this.button_MFC4Set.Click += new System.EventHandler(this.Click_SetMFC4);
            // 
            // groupBox_MFC3
            // 
            this.groupBox_MFC3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox_MFC3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox_MFC3.Controls.Add(this.label22);
            this.groupBox_MFC3.Controls.Add(this.label19);
            this.groupBox_MFC3.Controls.Add(this.textBox_MFC3Percentage);
            this.groupBox_MFC3.Controls.Add(this.textBox_MFC3ActualFlow);
            this.groupBox_MFC3.Controls.Add(this.textBox_MFC3GasName);
            this.groupBox_MFC3.Controls.Add(this.label7);
            this.groupBox_MFC3.Controls.Add(this.numericUpDown_MFC3FlowRate);
            this.groupBox_MFC3.Controls.Add(this.label8);
            this.groupBox_MFC3.Controls.Add(this.textBox_MFC3Time);
            this.groupBox_MFC3.Controls.Add(this.label9);
            this.groupBox_MFC3.Controls.Add(this.checkBox3);
            this.groupBox_MFC3.Controls.Add(this.button_MFC3Set);
            this.groupBox_MFC3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox_MFC3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox_MFC3.Location = new System.Drawing.Point(11, 271);
            this.groupBox_MFC3.Name = "groupBox_MFC3";
            this.groupBox_MFC3.Size = new System.Drawing.Size(415, 131);
            this.groupBox_MFC3.TabIndex = 19;
            this.groupBox_MFC3.TabStop = false;
            this.groupBox_MFC3.Text = "MFC3 (20 sscm)";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label22.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label22.Location = new System.Drawing.Point(247, 25);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(87, 16);
            this.label22.TabIndex = 35;
            this.label22.Text = "Percentage";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label19.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label19.Location = new System.Drawing.Point(72, 103);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(86, 16);
            this.label19.TabIndex = 30;
            this.label19.Text = "Actual Flow";
            // 
            // textBox_MFC3Percentage
            // 
            this.textBox_MFC3Percentage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_MFC3Percentage.Location = new System.Drawing.Point(245, 44);
            this.textBox_MFC3Percentage.Name = "textBox_MFC3Percentage";
            this.textBox_MFC3Percentage.Size = new System.Drawing.Size(92, 22);
            this.textBox_MFC3Percentage.TabIndex = 34;
            this.textBox_MFC3Percentage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_MFC3ActualFlow
            // 
            this.textBox_MFC3ActualFlow.Location = new System.Drawing.Point(163, 100);
            this.textBox_MFC3ActualFlow.Name = "textBox_MFC3ActualFlow";
            this.textBox_MFC3ActualFlow.Size = new System.Drawing.Size(76, 22);
            this.textBox_MFC3ActualFlow.TabIndex = 29;
            this.textBox_MFC3ActualFlow.Text = "0";
            this.textBox_MFC3ActualFlow.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_MFC3GasName
            // 
            this.textBox_MFC3GasName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_MFC3GasName.Location = new System.Drawing.Point(82, 44);
            this.textBox_MFC3GasName.Name = "textBox_MFC3GasName";
            this.textBox_MFC3GasName.Size = new System.Drawing.Size(157, 22);
            this.textBox_MFC3GasName.TabIndex = 10;
            this.textBox_MFC3GasName.Text = "Disable";
            this.textBox_MFC3GasName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_MFC3GasName.TextChanged += new System.EventHandler(this.TextChanged_MFC3GasNam);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(258, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 16);
            this.label7.TabIndex = 17;
            this.label7.Text = "Time (min)";
            // 
            // numericUpDown_MFC3FlowRate
            // 
            this.numericUpDown_MFC3FlowRate.DecimalPlaces = 1;
            this.numericUpDown_MFC3FlowRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numericUpDown_MFC3FlowRate.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDown_MFC3FlowRate.Location = new System.Drawing.Point(82, 72);
            this.numericUpDown_MFC3FlowRate.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDown_MFC3FlowRate.Name = "numericUpDown_MFC3FlowRate";
            this.numericUpDown_MFC3FlowRate.Size = new System.Drawing.Size(75, 22);
            this.numericUpDown_MFC3FlowRate.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Location = new System.Drawing.Point(3, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 16);
            this.label8.TabIndex = 16;
            this.label8.Text = "Flow Rate";
            // 
            // textBox_MFC3Time
            // 
            this.textBox_MFC3Time.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_MFC3Time.Location = new System.Drawing.Point(163, 71);
            this.textBox_MFC3Time.Name = "textBox_MFC3Time";
            this.textBox_MFC3Time.Size = new System.Drawing.Size(76, 22);
            this.textBox_MFC3Time.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.Location = new System.Drawing.Point(118, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 16);
            this.label9.TabIndex = 15;
            this.label9.Text = "Gas Name";
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBox3.Location = new System.Drawing.Point(245, 76);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(15, 14);
            this.checkBox3.TabIndex = 13;
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckStateChanged += new System.EventHandler(this.CheckStateChanged_MFC3Time);
            // 
            // button_MFC3Set
            // 
            this.button_MFC3Set.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_MFC3Set.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_MFC3Set.Location = new System.Drawing.Point(343, 72);
            this.button_MFC3Set.Name = "button_MFC3Set";
            this.button_MFC3Set.Size = new System.Drawing.Size(65, 23);
            this.button_MFC3Set.TabIndex = 14;
            this.button_MFC3Set.Text = "SET";
            this.button_MFC3Set.UseVisualStyleBackColor = true;
            this.button_MFC3Set.Click += new System.EventHandler(this.Click_SetMFC3);
            // 
            // groupBox_MFC2
            // 
            this.groupBox_MFC2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox_MFC2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox_MFC2.Controls.Add(this.label21);
            this.groupBox_MFC2.Controls.Add(this.label17);
            this.groupBox_MFC2.Controls.Add(this.textBox_MFC2Percentage);
            this.groupBox_MFC2.Controls.Add(this.textBox_MFC2GasName);
            this.groupBox_MFC2.Controls.Add(this.textBox_MFC2ActualFlow);
            this.groupBox_MFC2.Controls.Add(this.label4);
            this.groupBox_MFC2.Controls.Add(this.numericUpDown_MFC2FlowRate);
            this.groupBox_MFC2.Controls.Add(this.label5);
            this.groupBox_MFC2.Controls.Add(this.textBox_MFC2Time);
            this.groupBox_MFC2.Controls.Add(this.label6);
            this.groupBox_MFC2.Controls.Add(this.checkBox2);
            this.groupBox_MFC2.Controls.Add(this.button_MFC2Set);
            this.groupBox_MFC2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox_MFC2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox_MFC2.Location = new System.Drawing.Point(11, 140);
            this.groupBox_MFC2.Name = "groupBox_MFC2";
            this.groupBox_MFC2.Size = new System.Drawing.Size(415, 131);
            this.groupBox_MFC2.TabIndex = 19;
            this.groupBox_MFC2.TabStop = false;
            this.groupBox_MFC2.Text = "MFC2 (20 sscm)";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label21.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label21.Location = new System.Drawing.Point(247, 24);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(87, 16);
            this.label21.TabIndex = 33;
            this.label21.Text = "Percentage";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label17.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label17.Location = new System.Drawing.Point(72, 99);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(86, 16);
            this.label17.TabIndex = 28;
            this.label17.Text = "Actual Flow";
            // 
            // textBox_MFC2Percentage
            // 
            this.textBox_MFC2Percentage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_MFC2Percentage.Location = new System.Drawing.Point(245, 43);
            this.textBox_MFC2Percentage.Name = "textBox_MFC2Percentage";
            this.textBox_MFC2Percentage.Size = new System.Drawing.Size(93, 22);
            this.textBox_MFC2Percentage.TabIndex = 32;
            this.textBox_MFC2Percentage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_MFC2GasName
            // 
            this.textBox_MFC2GasName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_MFC2GasName.Location = new System.Drawing.Point(82, 43);
            this.textBox_MFC2GasName.Name = "textBox_MFC2GasName";
            this.textBox_MFC2GasName.Size = new System.Drawing.Size(157, 22);
            this.textBox_MFC2GasName.TabIndex = 10;
            this.textBox_MFC2GasName.Text = "Disable";
            this.textBox_MFC2GasName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_MFC2GasName.TextChanged += new System.EventHandler(this.TextChanged_MFC2GasNam);
            // 
            // textBox_MFC2ActualFlow
            // 
            this.textBox_MFC2ActualFlow.Location = new System.Drawing.Point(164, 96);
            this.textBox_MFC2ActualFlow.Name = "textBox_MFC2ActualFlow";
            this.textBox_MFC2ActualFlow.Size = new System.Drawing.Size(75, 22);
            this.textBox_MFC2ActualFlow.TabIndex = 27;
            this.textBox_MFC2ActualFlow.Text = "0";
            this.textBox_MFC2ActualFlow.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(258, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "Time (min)";
            // 
            // numericUpDown_MFC2FlowRate
            // 
            this.numericUpDown_MFC2FlowRate.DecimalPlaces = 1;
            this.numericUpDown_MFC2FlowRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numericUpDown_MFC2FlowRate.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDown_MFC2FlowRate.Location = new System.Drawing.Point(83, 69);
            this.numericUpDown_MFC2FlowRate.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDown_MFC2FlowRate.Name = "numericUpDown_MFC2FlowRate";
            this.numericUpDown_MFC2FlowRate.Size = new System.Drawing.Size(75, 22);
            this.numericUpDown_MFC2FlowRate.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(4, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = "Flow Rate";
            // 
            // textBox_MFC2Time
            // 
            this.textBox_MFC2Time.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_MFC2Time.Location = new System.Drawing.Point(164, 68);
            this.textBox_MFC2Time.Name = "textBox_MFC2Time";
            this.textBox_MFC2Time.Size = new System.Drawing.Size(75, 22);
            this.textBox_MFC2Time.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(118, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "Gas Name";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBox2.Location = new System.Drawing.Point(245, 71);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(15, 14);
            this.checkBox2.TabIndex = 13;
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckStateChanged += new System.EventHandler(this.CheckStateChanged_MFC2Time);
            // 
            // button_MFC2Set
            // 
            this.button_MFC2Set.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_MFC2Set.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_MFC2Set.Location = new System.Drawing.Point(343, 71);
            this.button_MFC2Set.Name = "button_MFC2Set";
            this.button_MFC2Set.Size = new System.Drawing.Size(66, 23);
            this.button_MFC2Set.TabIndex = 14;
            this.button_MFC2Set.Text = "SET";
            this.button_MFC2Set.UseVisualStyleBackColor = true;
            this.button_MFC2Set.Click += new System.EventHandler(this.Click_SetMFC2);
            // 
            // groupBox_MFC1
            // 
            this.groupBox_MFC1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox_MFC1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox_MFC1.Controls.Add(this.label_MFC1Percentage);
            this.groupBox_MFC1.Controls.Add(this.textBox_MFC1Percentage);
            this.groupBox_MFC1.Controls.Add(this.label16);
            this.groupBox_MFC1.Controls.Add(this.textBox_MFC1ActualFlow);
            this.groupBox_MFC1.Controls.Add(this.textBox_MFC1GasName);
            this.groupBox_MFC1.Controls.Add(this.label3);
            this.groupBox_MFC1.Controls.Add(this.numericUpDown_MFC1FlowRate);
            this.groupBox_MFC1.Controls.Add(this.label2);
            this.groupBox_MFC1.Controls.Add(this.textBox_MFC1Time);
            this.groupBox_MFC1.Controls.Add(this.label1);
            this.groupBox_MFC1.Controls.Add(this.checkBox_MFC1Time);
            this.groupBox_MFC1.Controls.Add(this.button_MFC1Set);
            this.groupBox_MFC1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox_MFC1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox_MFC1.Location = new System.Drawing.Point(11, 9);
            this.groupBox_MFC1.Name = "groupBox_MFC1";
            this.groupBox_MFC1.Size = new System.Drawing.Size(415, 131);
            this.groupBox_MFC1.TabIndex = 18;
            this.groupBox_MFC1.TabStop = false;
            this.groupBox_MFC1.Text = "MFC1 (50 sscm)";
            // 
            // label_MFC1Percentage
            // 
            this.label_MFC1Percentage.AutoSize = true;
            this.label_MFC1Percentage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_MFC1Percentage.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label_MFC1Percentage.Location = new System.Drawing.Point(247, 22);
            this.label_MFC1Percentage.Name = "label_MFC1Percentage";
            this.label_MFC1Percentage.Size = new System.Drawing.Size(87, 16);
            this.label_MFC1Percentage.TabIndex = 31;
            this.label_MFC1Percentage.Text = "Percentage";
            // 
            // textBox_MFC1Percentage
            // 
            this.textBox_MFC1Percentage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_MFC1Percentage.Location = new System.Drawing.Point(245, 41);
            this.textBox_MFC1Percentage.Name = "textBox_MFC1Percentage";
            this.textBox_MFC1Percentage.Size = new System.Drawing.Size(92, 22);
            this.textBox_MFC1Percentage.TabIndex = 27;
            this.textBox_MFC1Percentage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label16.Location = new System.Drawing.Point(72, 99);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(86, 16);
            this.label16.TabIndex = 26;
            this.label16.Text = "Actual Flow";
            // 
            // textBox_MFC1ActualFlow
            // 
            this.textBox_MFC1ActualFlow.Location = new System.Drawing.Point(164, 96);
            this.textBox_MFC1ActualFlow.Name = "textBox_MFC1ActualFlow";
            this.textBox_MFC1ActualFlow.Size = new System.Drawing.Size(75, 22);
            this.textBox_MFC1ActualFlow.TabIndex = 25;
            this.textBox_MFC1ActualFlow.Text = "0";
            this.textBox_MFC1ActualFlow.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_MFC1GasName
            // 
            this.textBox_MFC1GasName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_MFC1GasName.Location = new System.Drawing.Point(82, 41);
            this.textBox_MFC1GasName.Name = "textBox_MFC1GasName";
            this.textBox_MFC1GasName.Size = new System.Drawing.Size(157, 22);
            this.textBox_MFC1GasName.TabIndex = 10;
            this.textBox_MFC1GasName.Text = "Disable";
            this.textBox_MFC1GasName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_MFC1GasName.TextChanged += new System.EventHandler(this.TextChanged_MFC1GasName);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(258, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "Time (min)";
            // 
            // numericUpDown_MFC1FlowRate
            // 
            this.numericUpDown_MFC1FlowRate.DecimalPlaces = 1;
            this.numericUpDown_MFC1FlowRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numericUpDown_MFC1FlowRate.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDown_MFC1FlowRate.Location = new System.Drawing.Point(83, 69);
            this.numericUpDown_MFC1FlowRate.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDown_MFC1FlowRate.Name = "numericUpDown_MFC1FlowRate";
            this.numericUpDown_MFC1FlowRate.Size = new System.Drawing.Size(75, 22);
            this.numericUpDown_MFC1FlowRate.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(4, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Flow Rate";
            // 
            // textBox_MFC1Time
            // 
            this.textBox_MFC1Time.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_MFC1Time.Location = new System.Drawing.Point(164, 68);
            this.textBox_MFC1Time.Name = "textBox_MFC1Time";
            this.textBox_MFC1Time.Size = new System.Drawing.Size(75, 22);
            this.textBox_MFC1Time.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(118, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "Gas Name";
            // 
            // checkBox_MFC1Time
            // 
            this.checkBox_MFC1Time.AutoSize = true;
            this.checkBox_MFC1Time.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBox_MFC1Time.Location = new System.Drawing.Point(245, 73);
            this.checkBox_MFC1Time.Name = "checkBox_MFC1Time";
            this.checkBox_MFC1Time.Size = new System.Drawing.Size(15, 14);
            this.checkBox_MFC1Time.TabIndex = 13;
            this.checkBox_MFC1Time.UseVisualStyleBackColor = true;
            this.checkBox_MFC1Time.CheckStateChanged += new System.EventHandler(this.CheckStateChanged_MFC1Time);
            // 
            // button_MFC1Set
            // 
            this.button_MFC1Set.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_MFC1Set.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_MFC1Set.Location = new System.Drawing.Point(343, 68);
            this.button_MFC1Set.Name = "button_MFC1Set";
            this.button_MFC1Set.Size = new System.Drawing.Size(65, 23);
            this.button_MFC1Set.TabIndex = 14;
            this.button_MFC1Set.Text = "SET";
            this.button_MFC1Set.UseVisualStyleBackColor = true;
            this.button_MFC1Set.Click += new System.EventHandler(this.Click_SetMFC1);
            // 
            // tabPage_Automation
            // 
            this.tabPage_Automation.BackColor = System.Drawing.Color.Black;
            this.tabPage_Automation.BackgroundImage = global::SPECSON_WorkFlow_Manager.Properties.Resources.Adsız_tasarım__6_;
            this.tabPage_Automation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tabPage_Automation.Controls.Add(this.button1);
            this.tabPage_Automation.Controls.Add(this.numericUpDown_MFC1fq);
            this.tabPage_Automation.Controls.Add(this.groupBox9);
            this.tabPage_Automation.Controls.Add(this.groupBox_Operation);
            this.tabPage_Automation.Controls.Add(this.groupBox7);
            this.tabPage_Automation.Controls.Add(this.groupBox6);
            this.tabPage_Automation.Controls.Add(this.groupBox5);
            this.tabPage_Automation.Controls.Add(this.groupBox4);
            this.tabPage_Automation.Controls.Add(this.groupBox3);
            this.tabPage_Automation.Controls.Add(this.button_AutomationStop);
            this.tabPage_Automation.Controls.Add(this.button_BrowseAndLoadFile);
            this.tabPage_Automation.Controls.Add(this.button_AutomationStart);
            this.tabPage_Automation.Controls.Add(this.dataGridView1);
            this.tabPage_Automation.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Automation.Name = "tabPage_Automation";
            this.tabPage_Automation.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Automation.Size = new System.Drawing.Size(1200, 700);
            this.tabPage_Automation.TabIndex = 1;
            this.tabPage_Automation.Text = "Automation";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(865, 628);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 23);
            this.button1.TabIndex = 93;
            this.button1.Text = "SET";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.click_GraphFqSetButton);
            // 
            // numericUpDown_MFC1fq
            // 
            this.numericUpDown_MFC1fq.DecimalPlaces = 1;
            this.numericUpDown_MFC1fq.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numericUpDown_MFC1fq.Location = new System.Drawing.Point(865, 600);
            this.numericUpDown_MFC1fq.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown_MFC1fq.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_MFC1fq.Name = "numericUpDown_MFC1fq";
            this.numericUpDown_MFC1fq.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown_MFC1fq.TabIndex = 92;
            this.numericUpDown_MFC1fq.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // groupBox9
            // 
            this.groupBox9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox9.BackColor = System.Drawing.Color.Transparent;
            this.groupBox9.Controls.Add(this.textBox_AutoCellTemp);
            this.groupBox9.Controls.Add(this.label34);
            this.groupBox9.Controls.Add(this.textBox_AutoResistanceTemp);
            this.groupBox9.Controls.Add(this.label33);
            this.groupBox9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox9.Location = new System.Drawing.Point(76, 563);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(177, 117);
            this.groupBox9.TabIndex = 89;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Temperature (0-700°C)";
            // 
            // textBox_AutoCellTemp
            // 
            this.textBox_AutoCellTemp.Enabled = false;
            this.textBox_AutoCellTemp.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_AutoCellTemp.Location = new System.Drawing.Point(114, 37);
            this.textBox_AutoCellTemp.Name = "textBox_AutoCellTemp";
            this.textBox_AutoCellTemp.Size = new System.Drawing.Size(49, 27);
            this.textBox_AutoCellTemp.TabIndex = 82;
            this.textBox_AutoCellTemp.Text = "0";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.BackColor = System.Drawing.Color.Transparent;
            this.label34.Enabled = false;
            this.label34.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label34.Location = new System.Drawing.Point(11, 41);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(78, 16);
            this.label34.TabIndex = 83;
            this.label34.Text = "Cell Temp";
            // 
            // textBox_AutoResistanceTemp
            // 
            this.textBox_AutoResistanceTemp.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_AutoResistanceTemp.Location = new System.Drawing.Point(114, 70);
            this.textBox_AutoResistanceTemp.Name = "textBox_AutoResistanceTemp";
            this.textBox_AutoResistanceTemp.Size = new System.Drawing.Size(49, 27);
            this.textBox_AutoResistanceTemp.TabIndex = 84;
            this.textBox_AutoResistanceTemp.Text = "0";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.BackColor = System.Drawing.Color.Transparent;
            this.label33.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label33.Location = new System.Drawing.Point(11, 74);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(91, 16);
            this.label33.TabIndex = 85;
            this.label33.Text = "Resis Temp";
            // 
            // groupBox_Operation
            // 
            this.groupBox_Operation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox_Operation.BackColor = System.Drawing.Color.Transparent;
            this.groupBox_Operation.Controls.Add(this.textBox_AutoTime);
            this.groupBox_Operation.Controls.Add(this.AutoStepNum);
            this.groupBox_Operation.Controls.Add(this.button_SkipNextStep);
            this.groupBox_Operation.Controls.Add(this.label35);
            this.groupBox_Operation.Controls.Add(this.label36);
            this.groupBox_Operation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox_Operation.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox_Operation.Location = new System.Drawing.Point(76, 440);
            this.groupBox_Operation.Name = "groupBox_Operation";
            this.groupBox_Operation.Size = new System.Drawing.Size(177, 117);
            this.groupBox_Operation.TabIndex = 88;
            this.groupBox_Operation.TabStop = false;
            this.groupBox_Operation.Text = "Operation";
            // 
            // textBox_AutoTime
            // 
            this.textBox_AutoTime.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_AutoTime.Location = new System.Drawing.Point(114, 19);
            this.textBox_AutoTime.Name = "textBox_AutoTime";
            this.textBox_AutoTime.Size = new System.Drawing.Size(49, 27);
            this.textBox_AutoTime.TabIndex = 72;
            this.textBox_AutoTime.Text = "0";
            // 
            // AutoStepNum
            // 
            this.AutoStepNum.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AutoStepNum.Location = new System.Drawing.Point(114, 52);
            this.AutoStepNum.Name = "AutoStepNum";
            this.AutoStepNum.Size = new System.Drawing.Size(49, 27);
            this.AutoStepNum.TabIndex = 70;
            this.AutoStepNum.Text = "0";
            // 
            // button_SkipNextStep
            // 
            this.button_SkipNextStep.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_SkipNextStep.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_SkipNextStep.Location = new System.Drawing.Point(14, 82);
            this.button_SkipNextStep.Name = "button_SkipNextStep";
            this.button_SkipNextStep.Size = new System.Drawing.Size(149, 30);
            this.button_SkipNextStep.TabIndex = 1;
            this.button_SkipNextStep.Text = "Skip Next Step";
            this.button_SkipNextStep.UseVisualStyleBackColor = true;
            this.button_SkipNextStep.Click += new System.EventHandler(this.Click_SkipNextStep);
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.BackColor = System.Drawing.Color.Transparent;
            this.label35.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label35.Location = new System.Drawing.Point(11, 23);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(81, 16);
            this.label35.TabIndex = 69;
            this.label35.Text = "Time (sec)";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.BackColor = System.Drawing.Color.Transparent;
            this.label36.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label36.Location = new System.Drawing.Point(11, 56);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(97, 16);
            this.label36.TabIndex = 71;
            this.label36.Text = "Step Number";
            // 
            // groupBox7
            // 
            this.groupBox7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox7.BackColor = System.Drawing.Color.Transparent;
            this.groupBox7.Controls.Add(this.label44);
            this.groupBox7.Controls.Add(this.textBox_AutoMFC5Percentage);
            this.groupBox7.Controls.Add(this.label45);
            this.groupBox7.Controls.Add(this.textBox_AutoMFC5ActualFlow);
            this.groupBox7.Controls.Add(this.textBox_AutoMFC5GasName);
            this.groupBox7.Controls.Add(this.label46);
            this.groupBox7.Enabled = false;
            this.groupBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox7.Location = new System.Drawing.Point(852, 440);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(277, 117);
            this.groupBox7.TabIndex = 89;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "MFC5 (20 mL/min)";
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label44.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label44.Location = new System.Drawing.Point(186, 20);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(87, 16);
            this.label44.TabIndex = 31;
            this.label44.Text = "Percentage";
            // 
            // textBox_AutoMFC5Percentage
            // 
            this.textBox_AutoMFC5Percentage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_AutoMFC5Percentage.Location = new System.Drawing.Point(187, 39);
            this.textBox_AutoMFC5Percentage.Name = "textBox_AutoMFC5Percentage";
            this.textBox_AutoMFC5Percentage.Size = new System.Drawing.Size(84, 22);
            this.textBox_AutoMFC5Percentage.TabIndex = 27;
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label45.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label45.Location = new System.Drawing.Point(98, 67);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(86, 16);
            this.label45.TabIndex = 26;
            this.label45.Text = "Actual Flow";
            // 
            // textBox_AutoMFC5ActualFlow
            // 
            this.textBox_AutoMFC5ActualFlow.Location = new System.Drawing.Point(52, 86);
            this.textBox_AutoMFC5ActualFlow.Name = "textBox_AutoMFC5ActualFlow";
            this.textBox_AutoMFC5ActualFlow.Size = new System.Drawing.Size(175, 22);
            this.textBox_AutoMFC5ActualFlow.TabIndex = 25;
            this.textBox_AutoMFC5ActualFlow.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_AutoMFC5GasName
            // 
            this.textBox_AutoMFC5GasName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_AutoMFC5GasName.Location = new System.Drawing.Point(7, 39);
            this.textBox_AutoMFC5GasName.Name = "textBox_AutoMFC5GasName";
            this.textBox_AutoMFC5GasName.Size = new System.Drawing.Size(172, 22);
            this.textBox_AutoMFC5GasName.TabIndex = 10;
            this.textBox_AutoMFC5GasName.Text = "Disable";
            this.textBox_AutoMFC5GasName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label46.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label46.Location = new System.Drawing.Point(53, 20);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(80, 16);
            this.label46.TabIndex = 15;
            this.label46.Text = "Gas Name";
            // 
            // groupBox6
            // 
            this.groupBox6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox6.BackColor = System.Drawing.Color.Transparent;
            this.groupBox6.Controls.Add(this.label31);
            this.groupBox6.Controls.Add(this.textBox_AutoMFC4Percentage);
            this.groupBox6.Controls.Add(this.label32);
            this.groupBox6.Controls.Add(this.textBox_AutoMFC4ActualFlow);
            this.groupBox6.Controls.Add(this.textBox_AutoMFC4GasName);
            this.groupBox6.Controls.Add(this.label43);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox6.Location = new System.Drawing.Point(569, 563);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(277, 117);
            this.groupBox6.TabIndex = 88;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "MFC4 (50 mL/min)";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label31.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label31.Location = new System.Drawing.Point(186, 20);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(87, 16);
            this.label31.TabIndex = 31;
            this.label31.Text = "Percentage";
            // 
            // textBox_AutoMFC4Percentage
            // 
            this.textBox_AutoMFC4Percentage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_AutoMFC4Percentage.Location = new System.Drawing.Point(187, 39);
            this.textBox_AutoMFC4Percentage.Name = "textBox_AutoMFC4Percentage";
            this.textBox_AutoMFC4Percentage.Size = new System.Drawing.Size(84, 22);
            this.textBox_AutoMFC4Percentage.TabIndex = 27;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label32.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label32.Location = new System.Drawing.Point(98, 67);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(86, 16);
            this.label32.TabIndex = 26;
            this.label32.Text = "Actual Flow";
            // 
            // textBox_AutoMFC4ActualFlow
            // 
            this.textBox_AutoMFC4ActualFlow.Location = new System.Drawing.Point(52, 86);
            this.textBox_AutoMFC4ActualFlow.Name = "textBox_AutoMFC4ActualFlow";
            this.textBox_AutoMFC4ActualFlow.Size = new System.Drawing.Size(175, 22);
            this.textBox_AutoMFC4ActualFlow.TabIndex = 25;
            this.textBox_AutoMFC4ActualFlow.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_AutoMFC4GasName
            // 
            this.textBox_AutoMFC4GasName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_AutoMFC4GasName.Location = new System.Drawing.Point(7, 39);
            this.textBox_AutoMFC4GasName.Name = "textBox_AutoMFC4GasName";
            this.textBox_AutoMFC4GasName.Size = new System.Drawing.Size(172, 22);
            this.textBox_AutoMFC4GasName.TabIndex = 10;
            this.textBox_AutoMFC4GasName.Text = "Disable";
            this.textBox_AutoMFC4GasName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label43.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label43.Location = new System.Drawing.Point(53, 20);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(80, 16);
            this.label43.TabIndex = 15;
            this.label43.Text = "Gas Name";
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox5.BackColor = System.Drawing.Color.Transparent;
            this.groupBox5.Controls.Add(this.label27);
            this.groupBox5.Controls.Add(this.textBox_AutoMFC3Percentage);
            this.groupBox5.Controls.Add(this.label28);
            this.groupBox5.Controls.Add(this.textBox_AutoMFC3ActualFlow);
            this.groupBox5.Controls.Add(this.textBox_AutoMFC3GasName);
            this.groupBox5.Controls.Add(this.label30);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox5.Location = new System.Drawing.Point(569, 440);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(277, 117);
            this.groupBox5.TabIndex = 88;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "MFC3 (500 mL/min)";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label27.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label27.Location = new System.Drawing.Point(186, 20);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(87, 16);
            this.label27.TabIndex = 31;
            this.label27.Text = "Percentage";
            // 
            // textBox_AutoMFC3Percentage
            // 
            this.textBox_AutoMFC3Percentage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_AutoMFC3Percentage.Location = new System.Drawing.Point(187, 39);
            this.textBox_AutoMFC3Percentage.Name = "textBox_AutoMFC3Percentage";
            this.textBox_AutoMFC3Percentage.Size = new System.Drawing.Size(84, 22);
            this.textBox_AutoMFC3Percentage.TabIndex = 27;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label28.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label28.Location = new System.Drawing.Point(98, 67);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(86, 16);
            this.label28.TabIndex = 26;
            this.label28.Text = "Actual Flow";
            // 
            // textBox_AutoMFC3ActualFlow
            // 
            this.textBox_AutoMFC3ActualFlow.Location = new System.Drawing.Point(52, 86);
            this.textBox_AutoMFC3ActualFlow.Name = "textBox_AutoMFC3ActualFlow";
            this.textBox_AutoMFC3ActualFlow.Size = new System.Drawing.Size(175, 22);
            this.textBox_AutoMFC3ActualFlow.TabIndex = 25;
            this.textBox_AutoMFC3ActualFlow.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_AutoMFC3GasName
            // 
            this.textBox_AutoMFC3GasName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_AutoMFC3GasName.Location = new System.Drawing.Point(7, 39);
            this.textBox_AutoMFC3GasName.Name = "textBox_AutoMFC3GasName";
            this.textBox_AutoMFC3GasName.Size = new System.Drawing.Size(172, 22);
            this.textBox_AutoMFC3GasName.TabIndex = 10;
            this.textBox_AutoMFC3GasName.Text = "Disable";
            this.textBox_AutoMFC3GasName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label30.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label30.Location = new System.Drawing.Point(53, 20);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(80, 16);
            this.label30.TabIndex = 15;
            this.label30.Text = "Gas Name";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.label39);
            this.groupBox4.Controls.Add(this.textBox_AutoMFC2Percentage);
            this.groupBox4.Controls.Add(this.label40);
            this.groupBox4.Controls.Add(this.textBox_AutoMFC2ActualFlow);
            this.groupBox4.Controls.Add(this.textBox_AutoMFC2GasName);
            this.groupBox4.Controls.Add(this.label42);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox4.Location = new System.Drawing.Point(275, 563);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(277, 117);
            this.groupBox4.TabIndex = 88;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "MFC2 (500 mL/min)";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label39.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label39.Location = new System.Drawing.Point(186, 20);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(87, 16);
            this.label39.TabIndex = 31;
            this.label39.Text = "Percentage";
            // 
            // textBox_AutoMFC2Percentage
            // 
            this.textBox_AutoMFC2Percentage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_AutoMFC2Percentage.Location = new System.Drawing.Point(187, 39);
            this.textBox_AutoMFC2Percentage.Name = "textBox_AutoMFC2Percentage";
            this.textBox_AutoMFC2Percentage.Size = new System.Drawing.Size(84, 22);
            this.textBox_AutoMFC2Percentage.TabIndex = 27;
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label40.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label40.Location = new System.Drawing.Point(98, 67);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(86, 16);
            this.label40.TabIndex = 26;
            this.label40.Text = "Actual Flow";
            // 
            // textBox_AutoMFC2ActualFlow
            // 
            this.textBox_AutoMFC2ActualFlow.Location = new System.Drawing.Point(52, 86);
            this.textBox_AutoMFC2ActualFlow.Name = "textBox_AutoMFC2ActualFlow";
            this.textBox_AutoMFC2ActualFlow.Size = new System.Drawing.Size(175, 22);
            this.textBox_AutoMFC2ActualFlow.TabIndex = 25;
            this.textBox_AutoMFC2ActualFlow.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_AutoMFC2GasName
            // 
            this.textBox_AutoMFC2GasName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_AutoMFC2GasName.Location = new System.Drawing.Point(7, 39);
            this.textBox_AutoMFC2GasName.Name = "textBox_AutoMFC2GasName";
            this.textBox_AutoMFC2GasName.Size = new System.Drawing.Size(172, 22);
            this.textBox_AutoMFC2GasName.TabIndex = 10;
            this.textBox_AutoMFC2GasName.Text = "Disable";
            this.textBox_AutoMFC2GasName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label42.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label42.Location = new System.Drawing.Point(53, 20);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(80, 16);
            this.label42.TabIndex = 15;
            this.label42.Text = "Gas Name";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.label37);
            this.groupBox3.Controls.Add(this.textBox_AutoMFC1Percentage);
            this.groupBox3.Controls.Add(this.label38);
            this.groupBox3.Controls.Add(this.textBox_AutoMFC1ActualFlow);
            this.groupBox3.Controls.Add(this.textBox_AutoMFC1GasName);
            this.groupBox3.Controls.Add(this.label41);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox3.Location = new System.Drawing.Point(275, 440);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(277, 117);
            this.groupBox3.TabIndex = 87;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "MFC1 (1000 mL/min)";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label37.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label37.Location = new System.Drawing.Point(186, 20);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(87, 16);
            this.label37.TabIndex = 31;
            this.label37.Text = "Percentage";
            // 
            // textBox_AutoMFC1Percentage
            // 
            this.textBox_AutoMFC1Percentage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_AutoMFC1Percentage.Location = new System.Drawing.Point(187, 39);
            this.textBox_AutoMFC1Percentage.Name = "textBox_AutoMFC1Percentage";
            this.textBox_AutoMFC1Percentage.Size = new System.Drawing.Size(84, 22);
            this.textBox_AutoMFC1Percentage.TabIndex = 27;
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label38.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label38.Location = new System.Drawing.Point(98, 67);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(86, 16);
            this.label38.TabIndex = 26;
            this.label38.Text = "Actual Flow";
            // 
            // textBox_AutoMFC1ActualFlow
            // 
            this.textBox_AutoMFC1ActualFlow.Location = new System.Drawing.Point(52, 86);
            this.textBox_AutoMFC1ActualFlow.Name = "textBox_AutoMFC1ActualFlow";
            this.textBox_AutoMFC1ActualFlow.Size = new System.Drawing.Size(175, 22);
            this.textBox_AutoMFC1ActualFlow.TabIndex = 25;
            this.textBox_AutoMFC1ActualFlow.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_AutoMFC1GasName
            // 
            this.textBox_AutoMFC1GasName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_AutoMFC1GasName.Location = new System.Drawing.Point(7, 39);
            this.textBox_AutoMFC1GasName.Name = "textBox_AutoMFC1GasName";
            this.textBox_AutoMFC1GasName.Size = new System.Drawing.Size(172, 22);
            this.textBox_AutoMFC1GasName.TabIndex = 10;
            this.textBox_AutoMFC1GasName.Text = "Disable";
            this.textBox_AutoMFC1GasName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label41.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label41.Location = new System.Drawing.Point(53, 20);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(80, 16);
            this.label41.TabIndex = 15;
            this.label41.Text = "Gas Name";
            // 
            // button_AutomationStop
            // 
            this.button_AutomationStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_AutomationStop.Location = new System.Drawing.Point(1009, 628);
            this.button_AutomationStop.Name = "button_AutomationStop";
            this.button_AutomationStop.Size = new System.Drawing.Size(120, 30);
            this.button_AutomationStop.TabIndex = 86;
            this.button_AutomationStop.Text = "STOP";
            this.button_AutomationStop.UseVisualStyleBackColor = true;
            this.button_AutomationStop.Click += new System.EventHandler(this.Click_AutoStop);
            // 
            // button_BrowseAndLoadFile
            // 
            this.button_BrowseAndLoadFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_BrowseAndLoadFile.Location = new System.Drawing.Point(490, 394);
            this.button_BrowseAndLoadFile.Name = "button_BrowseAndLoadFile";
            this.button_BrowseAndLoadFile.Size = new System.Drawing.Size(220, 30);
            this.button_BrowseAndLoadFile.TabIndex = 3;
            this.button_BrowseAndLoadFile.Text = "BROWSE AND LOAD FILE";
            this.button_BrowseAndLoadFile.UseVisualStyleBackColor = true;
            this.button_BrowseAndLoadFile.Click += new System.EventHandler(this.Click_BrowseandLoadFile);
            // 
            // button_AutomationStart
            // 
            this.button_AutomationStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_AutomationStart.Location = new System.Drawing.Point(1009, 594);
            this.button_AutomationStart.Name = "button_AutomationStart";
            this.button_AutomationStart.Size = new System.Drawing.Size(120, 30);
            this.button_AutomationStart.TabIndex = 2;
            this.button_AutomationStart.Text = "START";
            this.button_AutomationStart.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button_AutomationStart.UseVisualStyleBackColor = true;
            this.button_AutomationStart.Click += new System.EventHandler(this.Click_AutoStart);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(11, 11);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1178, 376);
            this.dataGridView1.TabIndex = 0;
            // 
            // tabPage_GraphData
            // 
            this.tabPage_GraphData.BackColor = System.Drawing.Color.Black;
            this.tabPage_GraphData.BackgroundImage = global::SPECSON_WorkFlow_Manager.Properties.Resources.Adsız_tasarım__6_;
            this.tabPage_GraphData.Controls.Add(this.label_graphTemp);
            this.tabPage_GraphData.Controls.Add(this.label_graphMFC5);
            this.tabPage_GraphData.Controls.Add(this.label_graphMFC4);
            this.tabPage_GraphData.Controls.Add(this.label_graphMFC3);
            this.tabPage_GraphData.Controls.Add(this.label_graphMFC2);
            this.tabPage_GraphData.Controls.Add(this.label_graphMFC1);
            this.tabPage_GraphData.Controls.Add(this.chart_Temp);
            this.tabPage_GraphData.Controls.Add(this.chart_MFC5);
            this.tabPage_GraphData.Controls.Add(this.chart_MFC4);
            this.tabPage_GraphData.Controls.Add(this.chart_MFC3);
            this.tabPage_GraphData.Controls.Add(this.chart_MFC2);
            this.tabPage_GraphData.Controls.Add(this.button_exportMFC1);
            this.tabPage_GraphData.Controls.Add(this.chart_MFC1);
            this.tabPage_GraphData.Controls.Add(this.dataGridView_All);
            this.tabPage_GraphData.Location = new System.Drawing.Point(4, 22);
            this.tabPage_GraphData.Name = "tabPage_GraphData";
            this.tabPage_GraphData.Size = new System.Drawing.Size(1200, 700);
            this.tabPage_GraphData.TabIndex = 2;
            this.tabPage_GraphData.Text = "Graphs & Data";
            // 
            // label_graphTemp
            // 
            this.label_graphTemp.AutoSize = true;
            this.label_graphTemp.BackColor = System.Drawing.Color.Transparent;
            this.label_graphTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_graphTemp.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label_graphTemp.Location = new System.Drawing.Point(623, 499);
            this.label_graphTemp.Name = "label_graphTemp";
            this.label_graphTemp.Size = new System.Drawing.Size(96, 16);
            this.label_graphTemp.TabIndex = 29;
            this.label_graphTemp.Text = "Temperature";
            // 
            // label_graphMFC5
            // 
            this.label_graphMFC5.AutoSize = true;
            this.label_graphMFC5.BackColor = System.Drawing.Color.Transparent;
            this.label_graphMFC5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_graphMFC5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label_graphMFC5.Location = new System.Drawing.Point(623, 309);
            this.label_graphMFC5.Name = "label_graphMFC5";
            this.label_graphMFC5.Size = new System.Drawing.Size(59, 16);
            this.label_graphMFC5.TabIndex = 28;
            this.label_graphMFC5.Text = "MFC5 - ";
            // 
            // label_graphMFC4
            // 
            this.label_graphMFC4.AutoSize = true;
            this.label_graphMFC4.BackColor = System.Drawing.Color.Transparent;
            this.label_graphMFC4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_graphMFC4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label_graphMFC4.Location = new System.Drawing.Point(623, 117);
            this.label_graphMFC4.Name = "label_graphMFC4";
            this.label_graphMFC4.Size = new System.Drawing.Size(55, 16);
            this.label_graphMFC4.TabIndex = 27;
            this.label_graphMFC4.Text = "MFC4 -";
            // 
            // label_graphMFC3
            // 
            this.label_graphMFC3.AutoSize = true;
            this.label_graphMFC3.BackColor = System.Drawing.Color.Transparent;
            this.label_graphMFC3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_graphMFC3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label_graphMFC3.Location = new System.Drawing.Point(85, 497);
            this.label_graphMFC3.Name = "label_graphMFC3";
            this.label_graphMFC3.Size = new System.Drawing.Size(55, 16);
            this.label_graphMFC3.TabIndex = 26;
            this.label_graphMFC3.Text = "MFC3 -";
            // 
            // label_graphMFC2
            // 
            this.label_graphMFC2.AutoSize = true;
            this.label_graphMFC2.BackColor = System.Drawing.Color.Transparent;
            this.label_graphMFC2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_graphMFC2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label_graphMFC2.Location = new System.Drawing.Point(85, 307);
            this.label_graphMFC2.Name = "label_graphMFC2";
            this.label_graphMFC2.Size = new System.Drawing.Size(59, 16);
            this.label_graphMFC2.TabIndex = 25;
            this.label_graphMFC2.Text = "MFC2 - ";
            // 
            // label_graphMFC1
            // 
            this.label_graphMFC1.AutoSize = true;
            this.label_graphMFC1.BackColor = System.Drawing.Color.Transparent;
            this.label_graphMFC1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_graphMFC1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label_graphMFC1.Location = new System.Drawing.Point(85, 115);
            this.label_graphMFC1.Name = "label_graphMFC1";
            this.label_graphMFC1.Size = new System.Drawing.Size(59, 16);
            this.label_graphMFC1.TabIndex = 24;
            this.label_graphMFC1.Text = "MFC1 - ";
            // 
            // chart_Temp
            // 
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisX2.MajorGrid.Enabled = false;
            chartArea1.AxisY.MajorGrid.Enabled = false;
            chartArea1.AxisY2.MajorGrid.Enabled = false;
            chartArea1.Name = "ChartArea1";
            this.chart_Temp.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart_Temp.Legends.Add(legend1);
            this.chart_Temp.Location = new System.Drawing.Point(626, 516);
            this.chart_Temp.Name = "chart_Temp";
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Resistance";
            series2.BorderWidth = 3;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Set";
            this.chart_Temp.Series.Add(series1);
            this.chart_Temp.Series.Add(series2);
            this.chart_Temp.Size = new System.Drawing.Size(497, 168);
            this.chart_Temp.TabIndex = 23;
            this.chart_Temp.Text = "chart1";
            // 
            // chart_MFC5
            // 
            chartArea2.AxisX.MajorGrid.Enabled = false;
            chartArea2.AxisX2.MajorGrid.Enabled = false;
            chartArea2.AxisY.MajorGrid.Enabled = false;
            chartArea2.AxisY2.MajorGrid.Enabled = false;
            chartArea2.Name = "ChartArea1";
            this.chart_MFC5.ChartAreas.Add(chartArea2);
            this.chart_MFC5.Enabled = false;
            legend2.Name = "Legend1";
            this.chart_MFC5.Legends.Add(legend2);
            this.chart_MFC5.Location = new System.Drawing.Point(626, 328);
            this.chart_MFC5.Name = "chart_MFC5";
            series3.BorderWidth = 3;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.Name = "Actual";
            series4.BorderWidth = 3;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Legend = "Legend1";
            series4.Name = "Set";
            this.chart_MFC5.Series.Add(series3);
            this.chart_MFC5.Series.Add(series4);
            this.chart_MFC5.Size = new System.Drawing.Size(497, 168);
            this.chart_MFC5.TabIndex = 22;
            this.chart_MFC5.Text = "chart1";
            // 
            // chart_MFC4
            // 
            chartArea3.AxisX.MajorGrid.Enabled = false;
            chartArea3.AxisX2.MajorGrid.Enabled = false;
            chartArea3.AxisY.MajorGrid.Enabled = false;
            chartArea3.AxisY2.MajorGrid.Enabled = false;
            chartArea3.Name = "ChartArea1";
            this.chart_MFC4.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart_MFC4.Legends.Add(legend3);
            this.chart_MFC4.Location = new System.Drawing.Point(626, 136);
            this.chart_MFC4.Name = "chart_MFC4";
            series5.BorderWidth = 3;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Legend = "Legend1";
            series5.Name = "Actual";
            series6.BorderWidth = 3;
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.Legend = "Legend1";
            series6.Name = "Set";
            this.chart_MFC4.Series.Add(series5);
            this.chart_MFC4.Series.Add(series6);
            this.chart_MFC4.Size = new System.Drawing.Size(497, 168);
            this.chart_MFC4.TabIndex = 21;
            this.chart_MFC4.Text = "chart1";
            // 
            // chart_MFC3
            // 
            chartArea4.AxisX.MajorGrid.Enabled = false;
            chartArea4.AxisX2.MajorGrid.Enabled = false;
            chartArea4.AxisY.MajorGrid.Enabled = false;
            chartArea4.AxisY2.MajorGrid.Enabled = false;
            chartArea4.Name = "ChartArea1";
            this.chart_MFC3.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart_MFC3.Legends.Add(legend4);
            this.chart_MFC3.Location = new System.Drawing.Point(88, 516);
            this.chart_MFC3.Name = "chart_MFC3";
            series7.BorderWidth = 3;
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series7.Legend = "Legend1";
            series7.Name = "Actual";
            series8.BorderWidth = 3;
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series8.Legend = "Legend1";
            series8.Name = "Set";
            this.chart_MFC3.Series.Add(series7);
            this.chart_MFC3.Series.Add(series8);
            this.chart_MFC3.Size = new System.Drawing.Size(497, 168);
            this.chart_MFC3.TabIndex = 20;
            this.chart_MFC3.Text = "chart1";
            // 
            // chart_MFC2
            // 
            chartArea5.AxisX.MajorGrid.Enabled = false;
            chartArea5.AxisX2.MajorGrid.Enabled = false;
            chartArea5.AxisY.MajorGrid.Enabled = false;
            chartArea5.AxisY2.MajorGrid.Enabled = false;
            chartArea5.Name = "ChartArea1";
            this.chart_MFC2.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chart_MFC2.Legends.Add(legend5);
            this.chart_MFC2.Location = new System.Drawing.Point(88, 328);
            this.chart_MFC2.Name = "chart_MFC2";
            series9.BorderWidth = 3;
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series9.Legend = "Legend1";
            series9.Name = "Actual";
            series10.BorderWidth = 3;
            series10.ChartArea = "ChartArea1";
            series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series10.Legend = "Legend1";
            series10.Name = "Set";
            this.chart_MFC2.Series.Add(series9);
            this.chart_MFC2.Series.Add(series10);
            this.chart_MFC2.Size = new System.Drawing.Size(497, 168);
            this.chart_MFC2.TabIndex = 19;
            this.chart_MFC2.Text = "chart1";
            // 
            // button_exportMFC1
            // 
            this.button_exportMFC1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_exportMFC1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_exportMFC1.Location = new System.Drawing.Point(1086, 33);
            this.button_exportMFC1.Name = "button_exportMFC1";
            this.button_exportMFC1.Size = new System.Drawing.Size(90, 23);
            this.button_exportMFC1.TabIndex = 18;
            this.button_exportMFC1.Text = "EXPORT";
            this.button_exportMFC1.UseVisualStyleBackColor = true;
            this.button_exportMFC1.Click += new System.EventHandler(this.click_ExportMFC1);
            // 
            // chart_MFC1
            // 
            chartArea6.AxisX.MajorGrid.Enabled = false;
            chartArea6.AxisX2.MajorGrid.Enabled = false;
            chartArea6.AxisY.MajorGrid.Enabled = false;
            chartArea6.AxisY2.MajorGrid.Enabled = false;
            chartArea6.Name = "ChartArea1";
            this.chart_MFC1.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.chart_MFC1.Legends.Add(legend6);
            this.chart_MFC1.Location = new System.Drawing.Point(88, 136);
            this.chart_MFC1.Name = "chart_MFC1";
            series11.BorderWidth = 3;
            series11.ChartArea = "ChartArea1";
            series11.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series11.Legend = "Legend1";
            series11.Name = "Actual";
            series12.BorderWidth = 3;
            series12.ChartArea = "ChartArea1";
            series12.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series12.Legend = "Legend1";
            series12.Name = "Set";
            this.chart_MFC1.Series.Add(series11);
            this.chart_MFC1.Series.Add(series12);
            this.chart_MFC1.Size = new System.Drawing.Size(497, 168);
            this.chart_MFC1.TabIndex = 17;
            this.chart_MFC1.Text = "chart1";
            // 
            // dataGridView_All
            // 
            this.dataGridView_All.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_All.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Time,
            this.MFC1_Actual,
            this.MFC2_Actual,
            this.MFC3_Actual,
            this.MFC4_Actual,
            this.bos2,
            this.Temp_Out,
            this.Temp_Set,
            this.bos,
            this.MFC1_Set,
            this.MFC2_Set,
            this.MFC3_Set,
            this.MFC4_Set});
            this.dataGridView_All.Location = new System.Drawing.Point(146, 3);
            this.dataGridView_All.Name = "dataGridView_All";
            this.dataGridView_All.Size = new System.Drawing.Size(923, 109);
            this.dataGridView_All.TabIndex = 16;
            // 
            // Time
            // 
            this.Time.HeaderText = "Time";
            this.Time.Name = "Time";
            this.Time.Width = 60;
            // 
            // MFC1_Actual
            // 
            this.MFC1_Actual.HeaderText = "MFC1 Actual";
            this.MFC1_Actual.Name = "MFC1_Actual";
            this.MFC1_Actual.Width = 60;
            // 
            // MFC2_Actual
            // 
            this.MFC2_Actual.HeaderText = "MFC2 Actual";
            this.MFC2_Actual.Name = "MFC2_Actual";
            this.MFC2_Actual.Width = 60;
            // 
            // MFC3_Actual
            // 
            this.MFC3_Actual.HeaderText = "MFC3 Actual";
            this.MFC3_Actual.Name = "MFC3_Actual";
            this.MFC3_Actual.Width = 60;
            // 
            // MFC4_Actual
            // 
            this.MFC4_Actual.HeaderText = "MFC4 Actual";
            this.MFC4_Actual.Name = "MFC4_Actual";
            this.MFC4_Actual.Width = 60;
            // 
            // bos2
            // 
            this.bos2.HeaderText = "-";
            this.bos2.Name = "bos2";
            this.bos2.Width = 20;
            // 
            // Temp_Out
            // 
            this.Temp_Out.HeaderText = "Temp Out";
            this.Temp_Out.Name = "Temp_Out";
            this.Temp_Out.Width = 60;
            // 
            // Temp_Set
            // 
            this.Temp_Set.HeaderText = "Temp Set";
            this.Temp_Set.Name = "Temp_Set";
            this.Temp_Set.Width = 60;
            // 
            // bos
            // 
            this.bos.HeaderText = "-";
            this.bos.Name = "bos";
            this.bos.Width = 20;
            // 
            // MFC1_Set
            // 
            this.MFC1_Set.HeaderText = "MFC1 Set";
            this.MFC1_Set.Name = "MFC1_Set";
            this.MFC1_Set.Width = 60;
            // 
            // MFC2_Set
            // 
            this.MFC2_Set.HeaderText = "MFC2 Set";
            this.MFC2_Set.Name = "MFC2_Set";
            this.MFC2_Set.Width = 60;
            // 
            // MFC3_Set
            // 
            this.MFC3_Set.HeaderText = "MFC3 Set";
            this.MFC3_Set.Name = "MFC3_Set";
            this.MFC3_Set.Width = 60;
            // 
            // MFC4_Set
            // 
            this.MFC4_Set.HeaderText = "MFC4 Set";
            this.MFC4_Set.Name = "MFC4_Set";
            this.MFC4_Set.Width = 60;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1202, 745);
            this.Controls.Add(this.tab_Main);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainPage";
            this.Text = "SPECSON Workflow Manager";
            this.Load += new System.EventHandler(this.MainPage_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tab_Main.ResumeLayout(false);
            this.tabPage_ManualControl.ResumeLayout(false);
            this.tabPage_ManualControl.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox_Temperature.ResumeLayout(false);
            this.groupBox_Temperature.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_TempRamp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_TempTarget)).EndInit();
            this.groupBox_MFC5.ResumeLayout(false);
            this.groupBox_MFC5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_MFC5FlowRate)).EndInit();
            this.groupBox_MFC4.ResumeLayout(false);
            this.groupBox_MFC4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_MFC4FlowRate)).EndInit();
            this.groupBox_MFC3.ResumeLayout(false);
            this.groupBox_MFC3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_MFC3FlowRate)).EndInit();
            this.groupBox_MFC2.ResumeLayout(false);
            this.groupBox_MFC2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_MFC2FlowRate)).EndInit();
            this.groupBox_MFC1.ResumeLayout(false);
            this.groupBox_MFC1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_MFC1FlowRate)).EndInit();
            this.tabPage_Automation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_MFC1fq)).EndInit();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox_Operation.ResumeLayout(false);
            this.groupBox_Operation.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage_GraphData.ResumeLayout(false);
            this.tabPage_GraphData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_Temp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_MFC5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_MFC4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_MFC3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_MFC2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_MFC1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_All)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem beforeStartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cOMPortSelectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gasTypesToolStripMenuItem;
        private System.Windows.Forms.TabControl tab_Main;
        private System.Windows.Forms.TabPage tabPage_ManualControl;
        private System.Windows.Forms.TabPage tabPage_Automation;
        private System.Windows.Forms.TabPage tabPage_GraphData;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.CheckBox checkBox_MFC1Time;
        private System.Windows.Forms.TextBox textBox_MFC1Time;
        private System.Windows.Forms.NumericUpDown numericUpDown_MFC1FlowRate;
        private System.Windows.Forms.TextBox textBox_MFC1GasName;
        private System.Windows.Forms.GroupBox groupBox_MFC3;
        private System.Windows.Forms.TextBox textBox_MFC3GasName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numericUpDown_MFC3FlowRate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_MFC3Time;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.Button button_MFC3Set;
        private System.Windows.Forms.GroupBox groupBox_MFC2;
        private System.Windows.Forms.TextBox textBox_MFC2GasName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDown_MFC2FlowRate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_MFC2Time;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Button button_MFC2Set;
        private System.Windows.Forms.GroupBox groupBox_MFC1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_MFC1Set;
        private System.Windows.Forms.GroupBox groupBox_MFC5;
        private System.Windows.Forms.TextBox textBox_MFC5GasName;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown numericUpDown_MFC5FlowRate;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox_MFC5Time;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.Button button_MFCSet;
        private System.Windows.Forms.GroupBox groupBox_MFC4;
        private System.Windows.Forms.TextBox textBox_MFC4GasName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown numericUpDown_MFC4FlowRate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox_MFC4Time;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.Button button_MFC4Set;
        private System.Windows.Forms.TextBox textBox_OpTime;
        private System.Windows.Forms.Button button_MFCSetAll;
        private System.Windows.Forms.Label label_StopBit;
        private System.Windows.Forms.TextBox textBox_StopBit;
        private System.Windows.Forms.Label label_DataBits;
        private System.Windows.Forms.TextBox textBox_DataBits;
        private System.Windows.Forms.Label label_Parity;
        private System.Windows.Forms.TextBox textBox_Parity;
        private System.Windows.Forms.Label label_BaudRate;
        private System.Windows.Forms.TextBox textBox_BaudRate;
        private System.Windows.Forms.Label label_COMPort;
        private System.Windows.Forms.TextBox textBox_COMPort;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBox_MFC1ActualFlow;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox textBox_MFC5ActualFlow;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox textBox_MFC4ActualFlow;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox textBox_MFC3ActualFlow;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textBox_MFC2ActualFlow;
        private System.Windows.Forms.TextBox textBox_MFC1Percentage;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox textBox_MFC5Percentage;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox textBox_MFC4Percentage;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox textBox_MFC3Percentage;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox textBox_MFC2Percentage;
        private System.Windows.Forms.Label label_MFC1Percentage;
        private System.Windows.Forms.GroupBox groupBox_Temperature;
        private System.Windows.Forms.Label label_TempRamp;
        private System.Windows.Forms.NumericUpDown numericUpDown_TempTarget;
        private System.Windows.Forms.CheckBox checkBox_TempRamp;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label_CellTemp;
        private System.Windows.Forms.TextBox textBox_CellTemp;
        private System.Windows.Forms.Label label_ResistanceTemp;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.TextBox textBox_ResistanceTemp;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button_TempSet;
        private System.Windows.Forms.NumericUpDown numericUpDown_TempRamp;
        private System.Windows.Forms.Button button_Stop;
        private System.Windows.Forms.Button button_Start;
        private System.Windows.Forms.Button button_AutomationStop;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.TextBox textBox_AutoResistanceTemp;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.TextBox textBox_AutoCellTemp;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.TextBox AutoStepNum;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Button button_BrowseAndLoadFile;
        private System.Windows.Forms.Button button_AutomationStart;
        private System.Windows.Forms.Button button_SkipNextStep;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.GroupBox groupBox_Operation;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.TextBox textBox_AutoMFC5Percentage;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.TextBox textBox_AutoMFC5ActualFlow;
        private System.Windows.Forms.TextBox textBox_AutoMFC5GasName;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.TextBox textBox_AutoMFC4Percentage;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.TextBox textBox_AutoMFC4ActualFlow;
        private System.Windows.Forms.TextBox textBox_AutoMFC4GasName;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox textBox_AutoMFC3Percentage;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox textBox_AutoMFC3ActualFlow;
        private System.Windows.Forms.TextBox textBox_AutoMFC3GasName;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.TextBox textBox_AutoMFC2Percentage;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.TextBox textBox_AutoMFC2ActualFlow;
        private System.Windows.Forms.TextBox textBox_AutoMFC2GasName;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.TextBox textBox_AutoMFC1Percentage;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.TextBox textBox_AutoMFC1ActualFlow;
        private System.Windows.Forms.TextBox textBox_AutoMFC1GasName;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Timer timer_Write;
        private System.Windows.Forms.Timer timer_Read;
        private System.Windows.Forms.DataGridView dataGridView_All;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_MFC1;
        private System.Windows.Forms.Button button_exportMFC1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown numericUpDown_MFC1fq;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_Temp;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_MFC5;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_MFC4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_MFC3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_MFC2;
        private System.Windows.Forms.Label label_graphTemp;
        private System.Windows.Forms.Label label_graphMFC5;
        private System.Windows.Forms.Label label_graphMFC4;
        private System.Windows.Forms.Label label_graphMFC3;
        private System.Windows.Forms.Label label_graphMFC2;
        private System.Windows.Forms.Label label_graphMFC1;
        private System.Windows.Forms.TextBox textBox_AutoTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn MFC1_Actual;
        private System.Windows.Forms.DataGridViewTextBoxColumn MFC2_Actual;
        private System.Windows.Forms.DataGridViewTextBoxColumn MFC3_Actual;
        private System.Windows.Forms.DataGridViewTextBoxColumn MFC4_Actual;
        private System.Windows.Forms.DataGridViewTextBoxColumn bos2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Temp_Out;
        private System.Windows.Forms.DataGridViewTextBoxColumn Temp_Set;
        private System.Windows.Forms.DataGridViewTextBoxColumn bos;
        private System.Windows.Forms.DataGridViewTextBoxColumn MFC1_Set;
        private System.Windows.Forms.DataGridViewTextBoxColumn MFC2_Set;
        private System.Windows.Forms.DataGridViewTextBoxColumn MFC3_Set;
        private System.Windows.Forms.DataGridViewTextBoxColumn MFC4_Set;
    }
}

