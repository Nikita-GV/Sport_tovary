
namespace Sport_tovary
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label iD_tovaraLabel1;
            System.Windows.Forms.Label name_tovaraLabel2;
            System.Windows.Forms.Label materialLabel;
            System.Windows.Forms.Label razmerLabel;
            System.Windows.Forms.Label forma_tovaraLabel;
            System.Windows.Forms.Label iD_tovaraLabel2;
            System.Windows.Forms.Label sylka_na_tovarLabel;
            System.Windows.Forms.Label price_zakypkiLabel;
            System.Windows.Forms.Label price_prodagyLabel1;
            System.Windows.Forms.Label kolichestvo_tovarovLabel;
            System.Windows.Forms.Label nomer_zakypkiLabel;
            System.Windows.Forms.Label name_postavshikaLabel1;
            System.Windows.Forms.Label sposob_dostavkiLabel1;
            System.Windows.Forms.Label price_zakypkiLabel1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.iD_postavshikaLabel = new System.Windows.Forms.Label();
            this.name_postavshikaLabel = new System.Windows.Forms.Label();
            this.kontaktniy_nomerLabel = new System.Windows.Forms.Label();
            this.kontaktnoe_litsoLabel = new System.Windows.Forms.Label();
            this.stranaLabel = new System.Windows.Forms.Label();
            this.domLabel = new System.Windows.Forms.Label();
            this.ulitsaLabel = new System.Windows.Forms.Label();
            this.gorodLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.nomer_prodagyLabel = new System.Windows.Forms.Label();
            this.name_tovaraLabel = new System.Windows.Forms.Label();
            this.sposob_dostavkiLabel = new System.Windows.Forms.Label();
            this.kolichestvo_prodavaemyh_edinitsLabel = new System.Windows.Forms.Label();
            this.price_prodagyLabel = new System.Windows.Forms.Label();
            this.name_storeLabel = new System.Windows.Forms.Label();
            this.iD_tovaraLabel = new System.Windows.Forms.Label();
            this.kontaktniy_nomerLabel1 = new System.Windows.Forms.Label();
            this.kontaktnoe_litsoLabel1 = new System.Windows.Forms.Label();
            this.name_tovaraLabel1 = new System.Windows.Forms.Label();
            this.stranaLabel1 = new System.Windows.Forms.Label();
            this.domLabel1 = new System.Windows.Forms.Label();
            this.ulitsaLabel1 = new System.Windows.Forms.Label();
            this.gorodLabel1 = new System.Windows.Forms.Label();
            this.name_proizvoditelLabel = new System.Windows.Forms.Label();
            this.dataBase = new Sport_tovary.DataBase();
            this.postavshikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.postavshikTableAdapter = new Sport_tovary.DataBaseTableAdapters.PostavshikTableAdapter();
            this.tableAdapterManager = new Sport_tovary.DataBaseTableAdapters.TableAdapterManager();
            this.postavshik_zakypkaTableAdapter = new Sport_tovary.DataBaseTableAdapters.Postavshik_zakypkaTableAdapter();
            this.prodaga_sport_tovaryTableAdapter = new Sport_tovary.DataBaseTableAdapters.Prodaga_sport_tovaryTableAdapter();
            this.prodagaTableAdapter = new Sport_tovary.DataBaseTableAdapters.ProdagaTableAdapter();
            this.postavshikDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iD_postavshikaTextBox = new System.Windows.Forms.TextBox();
            this.name_postavshikaTextBox = new System.Windows.Forms.TextBox();
            this.kontaktniy_nomerTextBox = new System.Windows.Forms.TextBox();
            this.kontaktnoe_litsoTextBox = new System.Windows.Forms.TextBox();
            this.stranaTextBox = new System.Windows.Forms.TextBox();
            this.domTextBox = new System.Windows.Forms.TextBox();
            this.ulitsaTextBox = new System.Windows.Forms.TextBox();
            this.gorodTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Postavshik = new System.Windows.Forms.TabPage();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prodaga = new System.Windows.Forms.TabPage();
            this.bindingNavigator2 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem1 = new System.Windows.Forms.ToolStripButton();
            this.prodagaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorCountItem1 = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem1 = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.nomer_prodagyTextBox = new System.Windows.Forms.TextBox();
            this.name_tovaraTextBox = new System.Windows.Forms.TextBox();
            this.sposob_dostavkiTextBox = new System.Windows.Forms.TextBox();
            this.kolichestvo_prodavaemyh_edinitsTextBox = new System.Windows.Forms.TextBox();
            this.price_prodagyTextBox = new System.Windows.Forms.TextBox();
            this.name_storeTextBox = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.prodagaDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Proizvoditel = new System.Windows.Forms.TabPage();
            this.bindingNavigator3 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem2 = new System.Windows.Forms.ToolStripButton();
            this.proizvoditelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorCountItem2 = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem2 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem2 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem2 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem2 = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem2 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem2 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.iD_tovaraTextBox = new System.Windows.Forms.TextBox();
            this.kontaktniy_nomerTextBox1 = new System.Windows.Forms.TextBox();
            this.kontaktnoe_litsoTextBox1 = new System.Windows.Forms.TextBox();
            this.name_tovaraTextBox1 = new System.Windows.Forms.TextBox();
            this.stranaTextBox1 = new System.Windows.Forms.TextBox();
            this.domTextBox1 = new System.Windows.Forms.TextBox();
            this.ulitsaTextBox1 = new System.Windows.Forms.TextBox();
            this.gorodTextBox1 = new System.Windows.Forms.TextBox();
            this.name_proizvoditelTextBox = new System.Windows.Forms.TextBox();
            this.proizvoditelDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn25 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn26 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn27 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn28 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn29 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn30 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn31 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sportivnie_tovary = new System.Windows.Forms.TabPage();
            this.bindingNavigator4 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem3 = new System.Windows.Forms.ToolStripButton();
            this.sport_tovaryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorCountItem3 = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem3 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem3 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem3 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem3 = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem3 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem3 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator11 = new System.Windows.Forms.ToolStripSeparator();
            this.iD_tovaraTextBox1 = new System.Windows.Forms.TextBox();
            this.name_tovaraTextBox2 = new System.Windows.Forms.TextBox();
            this.materialTextBox = new System.Windows.Forms.TextBox();
            this.razmerTextBox = new System.Windows.Forms.TextBox();
            this.forma_tovaraTextBox = new System.Windows.Forms.TextBox();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.sport_tovaryDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn32 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn33 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn34 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn35 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn36 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Storage = new System.Windows.Forms.TabPage();
            this.bindingNavigator5 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem4 = new System.Windows.Forms.ToolStripButton();
            this.storageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorCountItem4 = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem4 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem4 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem4 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator12 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem4 = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator13 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem4 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem4 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator14 = new System.Windows.Forms.ToolStripSeparator();
            this.button12 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.iD_tovaraTextBox2 = new System.Windows.Forms.TextBox();
            this.sylka_na_tovarTextBox = new System.Windows.Forms.TextBox();
            this.price_zakypkiTextBox = new System.Windows.Forms.TextBox();
            this.price_prodagyTextBox1 = new System.Windows.Forms.TextBox();
            this.kolichestvo_tovarovTextBox = new System.Windows.Forms.TextBox();
            this.storageDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn37 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn38 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn39 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn40 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn41 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Zakypka = new System.Windows.Forms.TabPage();
            this.bindingNavigator6 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem5 = new System.Windows.Forms.ToolStripButton();
            this.zakypkaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorCountItem5 = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem5 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem5 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem5 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator15 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem5 = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator16 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem5 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem5 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator17 = new System.Windows.Forms.ToolStripSeparator();
            this.button14 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.nomer_zakypkiTextBox = new System.Windows.Forms.TextBox();
            this.name_postavshikaTextBox1 = new System.Windows.Forms.TextBox();
            this.sposob_dostavkiTextBox1 = new System.Windows.Forms.TextBox();
            this.price_zakypkiTextBox1 = new System.Windows.Forms.TextBox();
            this.zakypkaDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn42 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn43 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn44 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn45 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postavshik_zakypkaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prodaga_sport_tovaryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.proizvoditel_postavshikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.proizvoditel_sport_tovaryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.proizvoditelTableAdapter = new Sport_tovary.DataBaseTableAdapters.ProizvoditelTableAdapter();
            this.sport_tovaryTableAdapter = new Sport_tovary.DataBaseTableAdapters.Sport_tovaryTableAdapter();
            this.storageTableAdapter = new Sport_tovary.DataBaseTableAdapters.StorageTableAdapter();
            this.zakypkaTableAdapter = new Sport_tovary.DataBaseTableAdapters.ZakypkaTableAdapter();
            this.proizvoditel_postavshikTableAdapter = new Sport_tovary.DataBaseTableAdapters.Proizvoditel_postavshikTableAdapter();
            this.proizvoditel_sport_tovaryTableAdapter = new Sport_tovary.DataBaseTableAdapters.Proizvoditel_sport_tovaryTableAdapter();
            iD_tovaraLabel1 = new System.Windows.Forms.Label();
            name_tovaraLabel2 = new System.Windows.Forms.Label();
            materialLabel = new System.Windows.Forms.Label();
            razmerLabel = new System.Windows.Forms.Label();
            forma_tovaraLabel = new System.Windows.Forms.Label();
            iD_tovaraLabel2 = new System.Windows.Forms.Label();
            sylka_na_tovarLabel = new System.Windows.Forms.Label();
            price_zakypkiLabel = new System.Windows.Forms.Label();
            price_prodagyLabel1 = new System.Windows.Forms.Label();
            kolichestvo_tovarovLabel = new System.Windows.Forms.Label();
            nomer_zakypkiLabel = new System.Windows.Forms.Label();
            name_postavshikaLabel1 = new System.Windows.Forms.Label();
            sposob_dostavkiLabel1 = new System.Windows.Forms.Label();
            price_zakypkiLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataBase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postavshikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postavshikDataGridView)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.Postavshik.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.Prodaga.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator2)).BeginInit();
            this.bindingNavigator2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prodagaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodagaDataGridView)).BeginInit();
            this.Proizvoditel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator3)).BeginInit();
            this.bindingNavigator3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.proizvoditelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proizvoditelDataGridView)).BeginInit();
            this.Sportivnie_tovary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator4)).BeginInit();
            this.bindingNavigator4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sport_tovaryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sport_tovaryDataGridView)).BeginInit();
            this.Storage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator5)).BeginInit();
            this.bindingNavigator5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.storageBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storageDataGridView)).BeginInit();
            this.Zakypka.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator6)).BeginInit();
            this.bindingNavigator6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zakypkaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zakypkaDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postavshik_zakypkaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodaga_sport_tovaryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proizvoditel_postavshikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proizvoditel_sport_tovaryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // iD_tovaraLabel1
            // 
            iD_tovaraLabel1.AutoSize = true;
            iD_tovaraLabel1.Location = new System.Drawing.Point(580, 239);
            iD_tovaraLabel1.Name = "iD_tovaraLabel1";
            iD_tovaraLabel1.Size = new System.Drawing.Size(54, 13);
            iD_tovaraLabel1.TabIndex = 3;
            iD_tovaraLabel1.Text = "ID tovara:";
            // 
            // name_tovaraLabel2
            // 
            name_tovaraLabel2.AutoSize = true;
            name_tovaraLabel2.Location = new System.Drawing.Point(580, 265);
            name_tovaraLabel2.Name = "name_tovaraLabel2";
            name_tovaraLabel2.Size = new System.Drawing.Size(71, 13);
            name_tovaraLabel2.TabIndex = 5;
            name_tovaraLabel2.Text = "Name tovara:";
            // 
            // materialLabel
            // 
            materialLabel.AutoSize = true;
            materialLabel.Location = new System.Drawing.Point(580, 291);
            materialLabel.Name = "materialLabel";
            materialLabel.Size = new System.Drawing.Size(47, 13);
            materialLabel.TabIndex = 7;
            materialLabel.Text = "Material:";
            // 
            // razmerLabel
            // 
            razmerLabel.AutoSize = true;
            razmerLabel.Location = new System.Drawing.Point(580, 317);
            razmerLabel.Name = "razmerLabel";
            razmerLabel.Size = new System.Drawing.Size(46, 13);
            razmerLabel.TabIndex = 9;
            razmerLabel.Text = "Razmer:";
            // 
            // forma_tovaraLabel
            // 
            forma_tovaraLabel.AutoSize = true;
            forma_tovaraLabel.Location = new System.Drawing.Point(580, 343);
            forma_tovaraLabel.Name = "forma_tovaraLabel";
            forma_tovaraLabel.Size = new System.Drawing.Size(72, 13);
            forma_tovaraLabel.TabIndex = 11;
            forma_tovaraLabel.Text = "Forma tovara:";
            // 
            // iD_tovaraLabel2
            // 
            iD_tovaraLabel2.AutoSize = true;
            iD_tovaraLabel2.Location = new System.Drawing.Point(584, 242);
            iD_tovaraLabel2.Name = "iD_tovaraLabel2";
            iD_tovaraLabel2.Size = new System.Drawing.Size(54, 13);
            iD_tovaraLabel2.TabIndex = 1;
            iD_tovaraLabel2.Text = "ID tovara:";
            // 
            // sylka_na_tovarLabel
            // 
            sylka_na_tovarLabel.AutoSize = true;
            sylka_na_tovarLabel.Location = new System.Drawing.Point(584, 268);
            sylka_na_tovarLabel.Name = "sylka_na_tovarLabel";
            sylka_na_tovarLabel.Size = new System.Drawing.Size(78, 13);
            sylka_na_tovarLabel.TabIndex = 3;
            sylka_na_tovarLabel.Text = "Sylka na tovar:";
            // 
            // price_zakypkiLabel
            // 
            price_zakypkiLabel.AutoSize = true;
            price_zakypkiLabel.Location = new System.Drawing.Point(584, 294);
            price_zakypkiLabel.Name = "price_zakypkiLabel";
            price_zakypkiLabel.Size = new System.Drawing.Size(73, 13);
            price_zakypkiLabel.TabIndex = 5;
            price_zakypkiLabel.Text = "Price zakypki:";
            // 
            // price_prodagyLabel1
            // 
            price_prodagyLabel1.AutoSize = true;
            price_prodagyLabel1.Location = new System.Drawing.Point(584, 320);
            price_prodagyLabel1.Name = "price_prodagyLabel1";
            price_prodagyLabel1.Size = new System.Drawing.Size(75, 13);
            price_prodagyLabel1.TabIndex = 7;
            price_prodagyLabel1.Text = "Price prodagy:";
            // 
            // kolichestvo_tovarovLabel
            // 
            kolichestvo_tovarovLabel.AutoSize = true;
            kolichestvo_tovarovLabel.Location = new System.Drawing.Point(584, 346);
            kolichestvo_tovarovLabel.Name = "kolichestvo_tovarovLabel";
            kolichestvo_tovarovLabel.Size = new System.Drawing.Size(104, 13);
            kolichestvo_tovarovLabel.TabIndex = 9;
            kolichestvo_tovarovLabel.Text = "Kolichestvo tovarov:";
            // 
            // nomer_zakypkiLabel
            // 
            nomer_zakypkiLabel.AutoSize = true;
            nomer_zakypkiLabel.Location = new System.Drawing.Point(472, 239);
            nomer_zakypkiLabel.Name = "nomer_zakypkiLabel";
            nomer_zakypkiLabel.Size = new System.Drawing.Size(80, 13);
            nomer_zakypkiLabel.TabIndex = 1;
            nomer_zakypkiLabel.Text = "Nomer zakypki:";
            // 
            // name_postavshikaLabel1
            // 
            name_postavshikaLabel1.AutoSize = true;
            name_postavshikaLabel1.Location = new System.Drawing.Point(472, 265);
            name_postavshikaLabel1.Name = "name_postavshikaLabel1";
            name_postavshikaLabel1.Size = new System.Drawing.Size(98, 13);
            name_postavshikaLabel1.TabIndex = 3;
            name_postavshikaLabel1.Text = "Name postavshika:";
            // 
            // sposob_dostavkiLabel1
            // 
            sposob_dostavkiLabel1.AutoSize = true;
            sposob_dostavkiLabel1.Location = new System.Drawing.Point(472, 291);
            sposob_dostavkiLabel1.Name = "sposob_dostavkiLabel1";
            sposob_dostavkiLabel1.Size = new System.Drawing.Size(89, 13);
            sposob_dostavkiLabel1.TabIndex = 5;
            sposob_dostavkiLabel1.Text = "Sposob dostavki:";
            // 
            // price_zakypkiLabel1
            // 
            price_zakypkiLabel1.AutoSize = true;
            price_zakypkiLabel1.Location = new System.Drawing.Point(472, 317);
            price_zakypkiLabel1.Name = "price_zakypkiLabel1";
            price_zakypkiLabel1.Size = new System.Drawing.Size(73, 13);
            price_zakypkiLabel1.TabIndex = 7;
            price_zakypkiLabel1.Text = "Price zakypki:";
            // 
            // iD_postavshikaLabel
            // 
            this.iD_postavshikaLabel.AutoSize = true;
            this.iD_postavshikaLabel.Location = new System.Drawing.Point(681, 235);
            this.iD_postavshikaLabel.Name = "iD_postavshikaLabel";
            this.iD_postavshikaLabel.Size = new System.Drawing.Size(81, 13);
            this.iD_postavshikaLabel.TabIndex = 2;
            this.iD_postavshikaLabel.Text = "ID postavshika:";
            // 
            // name_postavshikaLabel
            // 
            this.name_postavshikaLabel.AutoSize = true;
            this.name_postavshikaLabel.Location = new System.Drawing.Point(681, 264);
            this.name_postavshikaLabel.Name = "name_postavshikaLabel";
            this.name_postavshikaLabel.Size = new System.Drawing.Size(98, 13);
            this.name_postavshikaLabel.TabIndex = 4;
            this.name_postavshikaLabel.Text = "Name postavshika:";
            // 
            // kontaktniy_nomerLabel
            // 
            this.kontaktniy_nomerLabel.AutoSize = true;
            this.kontaktniy_nomerLabel.Location = new System.Drawing.Point(681, 290);
            this.kontaktniy_nomerLabel.Name = "kontaktniy_nomerLabel";
            this.kontaktniy_nomerLabel.Size = new System.Drawing.Size(92, 13);
            this.kontaktniy_nomerLabel.TabIndex = 6;
            this.kontaktniy_nomerLabel.Text = "Kontaktniy nomer:";
            // 
            // kontaktnoe_litsoLabel
            // 
            this.kontaktnoe_litsoLabel.AutoSize = true;
            this.kontaktnoe_litsoLabel.Location = new System.Drawing.Point(681, 316);
            this.kontaktnoe_litsoLabel.Name = "kontaktnoe_litsoLabel";
            this.kontaktnoe_litsoLabel.Size = new System.Drawing.Size(86, 13);
            this.kontaktnoe_litsoLabel.TabIndex = 8;
            this.kontaktnoe_litsoLabel.Text = "Kontaktnoe litso:";
            // 
            // stranaLabel
            // 
            this.stranaLabel.AutoSize = true;
            this.stranaLabel.Location = new System.Drawing.Point(681, 342);
            this.stranaLabel.Name = "stranaLabel";
            this.stranaLabel.Size = new System.Drawing.Size(41, 13);
            this.stranaLabel.TabIndex = 10;
            this.stranaLabel.Text = "Strana:";
            // 
            // domLabel
            // 
            this.domLabel.AutoSize = true;
            this.domLabel.Location = new System.Drawing.Point(681, 368);
            this.domLabel.Name = "domLabel";
            this.domLabel.Size = new System.Drawing.Size(32, 13);
            this.domLabel.TabIndex = 12;
            this.domLabel.Text = "Dom:";
            // 
            // ulitsaLabel
            // 
            this.ulitsaLabel.AutoSize = true;
            this.ulitsaLabel.Location = new System.Drawing.Point(681, 394);
            this.ulitsaLabel.Name = "ulitsaLabel";
            this.ulitsaLabel.Size = new System.Drawing.Size(36, 13);
            this.ulitsaLabel.TabIndex = 14;
            this.ulitsaLabel.Text = "Ulitsa:";
            // 
            // gorodLabel
            // 
            this.gorodLabel.AutoSize = true;
            this.gorodLabel.Location = new System.Drawing.Point(681, 420);
            this.gorodLabel.Name = "gorodLabel";
            this.gorodLabel.Size = new System.Drawing.Size(39, 13);
            this.gorodLabel.TabIndex = 16;
            this.gorodLabel.Text = "Gorod:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(781, 228);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "ID postavshika:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(781, 254);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Name postavshika:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(781, 280);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Kontaktniy nomer:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(781, 306);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Kontaktnoe litso:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(781, 332);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Strana:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(781, 358);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "Dom:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(781, 384);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 33;
            this.label7.Text = "Ulitsa:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(781, 410);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 35;
            this.label8.Text = "Gorod:";
            // 
            // nomer_prodagyLabel
            // 
            this.nomer_prodagyLabel.AutoSize = true;
            this.nomer_prodagyLabel.Location = new System.Drawing.Point(665, 256);
            this.nomer_prodagyLabel.Name = "nomer_prodagyLabel";
            this.nomer_prodagyLabel.Size = new System.Drawing.Size(82, 13);
            this.nomer_prodagyLabel.TabIndex = 3;
            this.nomer_prodagyLabel.Text = "Nomer prodagy:";
            // 
            // name_tovaraLabel
            // 
            this.name_tovaraLabel.AutoSize = true;
            this.name_tovaraLabel.Location = new System.Drawing.Point(665, 282);
            this.name_tovaraLabel.Name = "name_tovaraLabel";
            this.name_tovaraLabel.Size = new System.Drawing.Size(71, 13);
            this.name_tovaraLabel.TabIndex = 5;
            this.name_tovaraLabel.Text = "Name tovara:";
            // 
            // sposob_dostavkiLabel
            // 
            this.sposob_dostavkiLabel.AutoSize = true;
            this.sposob_dostavkiLabel.Location = new System.Drawing.Point(665, 308);
            this.sposob_dostavkiLabel.Name = "sposob_dostavkiLabel";
            this.sposob_dostavkiLabel.Size = new System.Drawing.Size(89, 13);
            this.sposob_dostavkiLabel.TabIndex = 7;
            this.sposob_dostavkiLabel.Text = "Sposob dostavki:";
            // 
            // kolichestvo_prodavaemyh_edinitsLabel
            // 
            this.kolichestvo_prodavaemyh_edinitsLabel.AutoSize = true;
            this.kolichestvo_prodavaemyh_edinitsLabel.Location = new System.Drawing.Point(665, 334);
            this.kolichestvo_prodavaemyh_edinitsLabel.Name = "kolichestvo_prodavaemyh_edinitsLabel";
            this.kolichestvo_prodavaemyh_edinitsLabel.Size = new System.Drawing.Size(165, 13);
            this.kolichestvo_prodavaemyh_edinitsLabel.TabIndex = 9;
            this.kolichestvo_prodavaemyh_edinitsLabel.Text = "Kolichestvo prodavaemyh edinits:";
            // 
            // price_prodagyLabel
            // 
            this.price_prodagyLabel.AutoSize = true;
            this.price_prodagyLabel.Location = new System.Drawing.Point(665, 360);
            this.price_prodagyLabel.Name = "price_prodagyLabel";
            this.price_prodagyLabel.Size = new System.Drawing.Size(75, 13);
            this.price_prodagyLabel.TabIndex = 11;
            this.price_prodagyLabel.Text = "Price prodagy:";
            // 
            // name_storeLabel
            // 
            this.name_storeLabel.AutoSize = true;
            this.name_storeLabel.Location = new System.Drawing.Point(665, 386);
            this.name_storeLabel.Name = "name_storeLabel";
            this.name_storeLabel.Size = new System.Drawing.Size(64, 13);
            this.name_storeLabel.TabIndex = 13;
            this.name_storeLabel.Text = "Name store:";
            // 
            // iD_tovaraLabel
            // 
            this.iD_tovaraLabel.AutoSize = true;
            this.iD_tovaraLabel.Location = new System.Drawing.Point(712, 290);
            this.iD_tovaraLabel.Name = "iD_tovaraLabel";
            this.iD_tovaraLabel.Size = new System.Drawing.Size(54, 13);
            this.iD_tovaraLabel.TabIndex = 1;
            this.iD_tovaraLabel.Text = "ID tovara:";
            // 
            // kontaktniy_nomerLabel1
            // 
            this.kontaktniy_nomerLabel1.AutoSize = true;
            this.kontaktniy_nomerLabel1.Location = new System.Drawing.Point(712, 316);
            this.kontaktniy_nomerLabel1.Name = "kontaktniy_nomerLabel1";
            this.kontaktniy_nomerLabel1.Size = new System.Drawing.Size(92, 13);
            this.kontaktniy_nomerLabel1.TabIndex = 3;
            this.kontaktniy_nomerLabel1.Text = "Kontaktniy nomer:";
            // 
            // kontaktnoe_litsoLabel1
            // 
            this.kontaktnoe_litsoLabel1.AutoSize = true;
            this.kontaktnoe_litsoLabel1.Location = new System.Drawing.Point(712, 342);
            this.kontaktnoe_litsoLabel1.Name = "kontaktnoe_litsoLabel1";
            this.kontaktnoe_litsoLabel1.Size = new System.Drawing.Size(86, 13);
            this.kontaktnoe_litsoLabel1.TabIndex = 5;
            this.kontaktnoe_litsoLabel1.Text = "Kontaktnoe litso:";
            // 
            // name_tovaraLabel1
            // 
            this.name_tovaraLabel1.AutoSize = true;
            this.name_tovaraLabel1.Location = new System.Drawing.Point(712, 368);
            this.name_tovaraLabel1.Name = "name_tovaraLabel1";
            this.name_tovaraLabel1.Size = new System.Drawing.Size(71, 13);
            this.name_tovaraLabel1.TabIndex = 7;
            this.name_tovaraLabel1.Text = "Name tovara:";
            // 
            // stranaLabel1
            // 
            this.stranaLabel1.AutoSize = true;
            this.stranaLabel1.Location = new System.Drawing.Point(712, 394);
            this.stranaLabel1.Name = "stranaLabel1";
            this.stranaLabel1.Size = new System.Drawing.Size(41, 13);
            this.stranaLabel1.TabIndex = 9;
            this.stranaLabel1.Text = "Strana:";
            // 
            // domLabel1
            // 
            this.domLabel1.AutoSize = true;
            this.domLabel1.Location = new System.Drawing.Point(712, 420);
            this.domLabel1.Name = "domLabel1";
            this.domLabel1.Size = new System.Drawing.Size(32, 13);
            this.domLabel1.TabIndex = 11;
            this.domLabel1.Text = "Dom:";
            // 
            // ulitsaLabel1
            // 
            this.ulitsaLabel1.AutoSize = true;
            this.ulitsaLabel1.Location = new System.Drawing.Point(712, 446);
            this.ulitsaLabel1.Name = "ulitsaLabel1";
            this.ulitsaLabel1.Size = new System.Drawing.Size(36, 13);
            this.ulitsaLabel1.TabIndex = 13;
            this.ulitsaLabel1.Text = "Ulitsa:";
            // 
            // gorodLabel1
            // 
            this.gorodLabel1.AutoSize = true;
            this.gorodLabel1.Location = new System.Drawing.Point(712, 472);
            this.gorodLabel1.Name = "gorodLabel1";
            this.gorodLabel1.Size = new System.Drawing.Size(39, 13);
            this.gorodLabel1.TabIndex = 15;
            this.gorodLabel1.Text = "Gorod:";
            // 
            // name_proizvoditelLabel
            // 
            this.name_proizvoditelLabel.AutoSize = true;
            this.name_proizvoditelLabel.Location = new System.Drawing.Point(712, 498);
            this.name_proizvoditelLabel.Name = "name_proizvoditelLabel";
            this.name_proizvoditelLabel.Size = new System.Drawing.Size(94, 13);
            this.name_proizvoditelLabel.TabIndex = 17;
            this.name_proizvoditelLabel.Text = "Name proizvoditel:";
            // 
            // dataBase
            // 
            this.dataBase.DataSetName = "DataBase";
            this.dataBase.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // postavshikBindingSource
            // 
            this.postavshikBindingSource.DataMember = "Postavshik";
            this.postavshikBindingSource.DataSource = this.dataBase;
            this.postavshikBindingSource.CurrentChanged += new System.EventHandler(this.postavshikBindingSource_CurrentChanged);
            // 
            // postavshikTableAdapter
            // 
            this.postavshikTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Postavshik_zakypkaTableAdapter = this.postavshik_zakypkaTableAdapter;
            this.tableAdapterManager.PostavshikTableAdapter = this.postavshikTableAdapter;
            this.tableAdapterManager.Prodaga_sport_tovaryTableAdapter = this.prodaga_sport_tovaryTableAdapter;
            this.tableAdapterManager.ProdagaTableAdapter = this.prodagaTableAdapter;
            this.tableAdapterManager.Proizvoditel_postavshikTableAdapter = null;
            this.tableAdapterManager.Proizvoditel_sport_tovaryTableAdapter = null;
            this.tableAdapterManager.ProizvoditelTableAdapter = null;
            this.tableAdapterManager.Sport_tovaryTableAdapter = null;
            this.tableAdapterManager.StorageTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Sport_tovary.DataBaseTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ZakypkaTableAdapter = null;
            // 
            // postavshik_zakypkaTableAdapter
            // 
            this.postavshik_zakypkaTableAdapter.ClearBeforeFill = true;
            // 
            // prodaga_sport_tovaryTableAdapter
            // 
            this.prodaga_sport_tovaryTableAdapter.ClearBeforeFill = true;
            // 
            // prodagaTableAdapter
            // 
            this.prodagaTableAdapter.ClearBeforeFill = true;
            // 
            // postavshikDataGridView
            // 
            this.postavshikDataGridView.AutoGenerateColumns = false;
            this.postavshikDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.postavshikDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.postavshikDataGridView.DataSource = this.postavshikBindingSource;
            this.postavshikDataGridView.Location = new System.Drawing.Point(21, 28);
            this.postavshikDataGridView.Name = "postavshikDataGridView";
            this.postavshikDataGridView.Size = new System.Drawing.Size(855, 162);
            this.postavshikDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_postavshika";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID_postavshika";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name_postavshika";
            this.dataGridViewTextBoxColumn2.HeaderText = "Name_postavshika";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Kontaktniy_nomer";
            this.dataGridViewTextBoxColumn3.HeaderText = "Kontaktniy_nomer";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Kontaktnoe_litso";
            this.dataGridViewTextBoxColumn4.HeaderText = "Kontaktnoe_litso";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Strana";
            this.dataGridViewTextBoxColumn5.HeaderText = "Strana";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Dom";
            this.dataGridViewTextBoxColumn6.HeaderText = "Dom";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Ulitsa";
            this.dataGridViewTextBoxColumn7.HeaderText = "Ulitsa";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Gorod";
            this.dataGridViewTextBoxColumn8.HeaderText = "Gorod";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // iD_postavshikaTextBox
            // 
            this.iD_postavshikaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.postavshikBindingSource, "ID_postavshika", true));
            this.iD_postavshikaTextBox.Location = new System.Drawing.Point(785, 235);
            this.iD_postavshikaTextBox.Name = "iD_postavshikaTextBox";
            this.iD_postavshikaTextBox.Size = new System.Drawing.Size(100, 20);
            this.iD_postavshikaTextBox.TabIndex = 3;
            // 
            // name_postavshikaTextBox
            // 
            this.name_postavshikaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.postavshikBindingSource, "Name_postavshika", true));
            this.name_postavshikaTextBox.Location = new System.Drawing.Point(785, 261);
            this.name_postavshikaTextBox.Name = "name_postavshikaTextBox";
            this.name_postavshikaTextBox.Size = new System.Drawing.Size(100, 20);
            this.name_postavshikaTextBox.TabIndex = 5;
            // 
            // kontaktniy_nomerTextBox
            // 
            this.kontaktniy_nomerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.postavshikBindingSource, "Kontaktniy_nomer", true));
            this.kontaktniy_nomerTextBox.Location = new System.Drawing.Point(785, 287);
            this.kontaktniy_nomerTextBox.Name = "kontaktniy_nomerTextBox";
            this.kontaktniy_nomerTextBox.Size = new System.Drawing.Size(100, 20);
            this.kontaktniy_nomerTextBox.TabIndex = 7;
            // 
            // kontaktnoe_litsoTextBox
            // 
            this.kontaktnoe_litsoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.postavshikBindingSource, "Kontaktnoe_litso", true));
            this.kontaktnoe_litsoTextBox.Location = new System.Drawing.Point(785, 313);
            this.kontaktnoe_litsoTextBox.Name = "kontaktnoe_litsoTextBox";
            this.kontaktnoe_litsoTextBox.Size = new System.Drawing.Size(100, 20);
            this.kontaktnoe_litsoTextBox.TabIndex = 9;
            // 
            // stranaTextBox
            // 
            this.stranaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.postavshikBindingSource, "Strana", true));
            this.stranaTextBox.Location = new System.Drawing.Point(785, 339);
            this.stranaTextBox.Name = "stranaTextBox";
            this.stranaTextBox.Size = new System.Drawing.Size(100, 20);
            this.stranaTextBox.TabIndex = 11;
            // 
            // domTextBox
            // 
            this.domTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.postavshikBindingSource, "Dom", true));
            this.domTextBox.Location = new System.Drawing.Point(785, 365);
            this.domTextBox.Name = "domTextBox";
            this.domTextBox.Size = new System.Drawing.Size(100, 20);
            this.domTextBox.TabIndex = 13;
            // 
            // ulitsaTextBox
            // 
            this.ulitsaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.postavshikBindingSource, "Ulitsa", true));
            this.ulitsaTextBox.Location = new System.Drawing.Point(785, 391);
            this.ulitsaTextBox.Name = "ulitsaTextBox";
            this.ulitsaTextBox.Size = new System.Drawing.Size(100, 20);
            this.ulitsaTextBox.TabIndex = 15;
            // 
            // gorodTextBox
            // 
            this.gorodTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.postavshikBindingSource, "Gorod", true));
            this.gorodTextBox.Location = new System.Drawing.Point(785, 417);
            this.gorodTextBox.Name = "gorodTextBox";
            this.gorodTextBox.Size = new System.Drawing.Size(100, 20);
            this.gorodTextBox.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(896, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "new record";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(896, 80);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 19;
            this.button2.Text = "save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Postavshik);
            this.tabControl1.Controls.Add(this.Prodaga);
            this.tabControl1.Controls.Add(this.Proizvoditel);
            this.tabControl1.Controls.Add(this.Sportivnie_tovary);
            this.tabControl1.Controls.Add(this.Storage);
            this.tabControl1.Controls.Add(this.Zakypka);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1089, 578);
            this.tabControl1.TabIndex = 20;
            // 
            // Postavshik
            // 
            this.Postavshik.Controls.Add(this.bindingNavigator1);
            this.Postavshik.Controls.Add(this.button3);
            this.Postavshik.Controls.Add(this.button4);
            this.Postavshik.Controls.Add(this.label1);
            this.Postavshik.Controls.Add(this.textBox1);
            this.Postavshik.Controls.Add(this.label2);
            this.Postavshik.Controls.Add(this.textBox2);
            this.Postavshik.Controls.Add(this.label3);
            this.Postavshik.Controls.Add(this.textBox3);
            this.Postavshik.Controls.Add(this.label4);
            this.Postavshik.Controls.Add(this.textBox4);
            this.Postavshik.Controls.Add(this.label5);
            this.Postavshik.Controls.Add(this.textBox5);
            this.Postavshik.Controls.Add(this.label6);
            this.Postavshik.Controls.Add(this.textBox6);
            this.Postavshik.Controls.Add(this.label7);
            this.Postavshik.Controls.Add(this.textBox7);
            this.Postavshik.Controls.Add(this.label8);
            this.Postavshik.Controls.Add(this.textBox8);
            this.Postavshik.Controls.Add(this.dataGridView1);
            this.Postavshik.Location = new System.Drawing.Point(4, 22);
            this.Postavshik.Name = "Postavshik";
            this.Postavshik.Padding = new System.Windows.Forms.Padding(3);
            this.Postavshik.Size = new System.Drawing.Size(1081, 552);
            this.Postavshik.TabIndex = 0;
            this.Postavshik.Text = "Postavshik";
            this.Postavshik.UseVisualStyleBackColor = true;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.BindingSource = this.postavshikBindingSource;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.bindingNavigator1.Location = new System.Drawing.Point(3, 3);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(1075, 25);
            this.bindingNavigator1.TabIndex = 39;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(878, 111);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 38;
            this.button3.Text = "save";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(878, 58);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 37;
            this.button4.Text = "new record";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.postavshikBindingSource, "ID_postavshika", true));
            this.textBox1.Location = new System.Drawing.Point(892, 228);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 22;
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.postavshikBindingSource, "Name_postavshika", true));
            this.textBox2.Location = new System.Drawing.Point(892, 254);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 24;
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.postavshikBindingSource, "Kontaktniy_nomer", true));
            this.textBox3.Location = new System.Drawing.Point(892, 280);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 26;
            // 
            // textBox4
            // 
            this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.postavshikBindingSource, "Kontaktnoe_litso", true));
            this.textBox4.Location = new System.Drawing.Point(892, 306);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 28;
            // 
            // textBox5
            // 
            this.textBox5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.postavshikBindingSource, "Strana", true));
            this.textBox5.Location = new System.Drawing.Point(892, 332);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 30;
            // 
            // textBox6
            // 
            this.textBox6.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.postavshikBindingSource, "Dom", true));
            this.textBox6.Location = new System.Drawing.Point(892, 358);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 32;
            // 
            // textBox7
            // 
            this.textBox7.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.postavshikBindingSource, "Ulitsa", true));
            this.textBox7.Location = new System.Drawing.Point(892, 384);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 20);
            this.textBox7.TabIndex = 34;
            // 
            // textBox8
            // 
            this.textBox8.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.postavshikBindingSource, "Gorod", true));
            this.textBox8.Location = new System.Drawing.Point(892, 410);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(100, 20);
            this.textBox8.TabIndex = 36;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16});
            this.dataGridView1.DataSource = this.postavshikBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(3, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(855, 162);
            this.dataGridView1.TabIndex = 20;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "ID_postavshika";
            this.dataGridViewTextBoxColumn9.HeaderText = "ID_postavshika";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Name_postavshika";
            this.dataGridViewTextBoxColumn10.HeaderText = "Name_postavshika";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Kontaktniy_nomer";
            this.dataGridViewTextBoxColumn11.HeaderText = "Kontaktniy_nomer";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Kontaktnoe_litso";
            this.dataGridViewTextBoxColumn12.HeaderText = "Kontaktnoe_litso";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "Strana";
            this.dataGridViewTextBoxColumn13.HeaderText = "Strana";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "Dom";
            this.dataGridViewTextBoxColumn14.HeaderText = "Dom";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "Ulitsa";
            this.dataGridViewTextBoxColumn15.HeaderText = "Ulitsa";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "Gorod";
            this.dataGridViewTextBoxColumn16.HeaderText = "Gorod";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            // 
            // Prodaga
            // 
            this.Prodaga.AutoScroll = true;
            this.Prodaga.Controls.Add(this.bindingNavigator2);
            this.Prodaga.Controls.Add(this.nomer_prodagyLabel);
            this.Prodaga.Controls.Add(this.nomer_prodagyTextBox);
            this.Prodaga.Controls.Add(this.name_tovaraLabel);
            this.Prodaga.Controls.Add(this.name_tovaraTextBox);
            this.Prodaga.Controls.Add(this.sposob_dostavkiLabel);
            this.Prodaga.Controls.Add(this.sposob_dostavkiTextBox);
            this.Prodaga.Controls.Add(this.kolichestvo_prodavaemyh_edinitsLabel);
            this.Prodaga.Controls.Add(this.kolichestvo_prodavaemyh_edinitsTextBox);
            this.Prodaga.Controls.Add(this.price_prodagyLabel);
            this.Prodaga.Controls.Add(this.price_prodagyTextBox);
            this.Prodaga.Controls.Add(this.name_storeLabel);
            this.Prodaga.Controls.Add(this.name_storeTextBox);
            this.Prodaga.Controls.Add(this.button6);
            this.Prodaga.Controls.Add(this.button5);
            this.Prodaga.Controls.Add(this.prodagaDataGridView);
            this.Prodaga.Location = new System.Drawing.Point(4, 22);
            this.Prodaga.Name = "Prodaga";
            this.Prodaga.Padding = new System.Windows.Forms.Padding(3);
            this.Prodaga.Size = new System.Drawing.Size(1081, 552);
            this.Prodaga.TabIndex = 1;
            this.Prodaga.Text = "Prodaga";
            this.Prodaga.UseVisualStyleBackColor = true;
            // 
            // bindingNavigator2
            // 
            this.bindingNavigator2.AddNewItem = this.bindingNavigatorAddNewItem1;
            this.bindingNavigator2.BindingSource = this.prodagaBindingSource;
            this.bindingNavigator2.CountItem = this.bindingNavigatorCountItem1;
            this.bindingNavigator2.DeleteItem = this.bindingNavigatorDeleteItem1;
            this.bindingNavigator2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem1,
            this.bindingNavigatorMovePreviousItem1,
            this.bindingNavigatorSeparator3,
            this.bindingNavigatorPositionItem1,
            this.bindingNavigatorCountItem1,
            this.bindingNavigatorSeparator4,
            this.bindingNavigatorMoveNextItem1,
            this.bindingNavigatorMoveLastItem1,
            this.bindingNavigatorSeparator5,
            this.bindingNavigatorAddNewItem1,
            this.bindingNavigatorDeleteItem1});
            this.bindingNavigator2.Location = new System.Drawing.Point(3, 3);
            this.bindingNavigator2.MoveFirstItem = this.bindingNavigatorMoveFirstItem1;
            this.bindingNavigator2.MoveLastItem = this.bindingNavigatorMoveLastItem1;
            this.bindingNavigator2.MoveNextItem = this.bindingNavigatorMoveNextItem1;
            this.bindingNavigator2.MovePreviousItem = this.bindingNavigatorMovePreviousItem1;
            this.bindingNavigator2.Name = "bindingNavigator2";
            this.bindingNavigator2.PositionItem = this.bindingNavigatorPositionItem1;
            this.bindingNavigator2.Size = new System.Drawing.Size(1075, 25);
            this.bindingNavigator2.TabIndex = 15;
            this.bindingNavigator2.Text = "bindingNavigator2";
            // 
            // bindingNavigatorAddNewItem1
            // 
            this.bindingNavigatorAddNewItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem1.Image")));
            this.bindingNavigatorAddNewItem1.Name = "bindingNavigatorAddNewItem1";
            this.bindingNavigatorAddNewItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem1.Text = "Добавить";
            // 
            // prodagaBindingSource
            // 
            this.prodagaBindingSource.DataMember = "Prodaga";
            this.prodagaBindingSource.DataSource = this.dataBase;
            this.prodagaBindingSource.CurrentChanged += new System.EventHandler(this.prodagaBindingSource_CurrentChanged);
            // 
            // bindingNavigatorCountItem1
            // 
            this.bindingNavigatorCountItem1.Name = "bindingNavigatorCountItem1";
            this.bindingNavigatorCountItem1.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem1.Text = "для {0}";
            this.bindingNavigatorCountItem1.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem1
            // 
            this.bindingNavigatorDeleteItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem1.Image")));
            this.bindingNavigatorDeleteItem1.Name = "bindingNavigatorDeleteItem1";
            this.bindingNavigatorDeleteItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem1.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem1
            // 
            this.bindingNavigatorMoveFirstItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem1.Image")));
            this.bindingNavigatorMoveFirstItem1.Name = "bindingNavigatorMoveFirstItem1";
            this.bindingNavigatorMoveFirstItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem1.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem1
            // 
            this.bindingNavigatorMovePreviousItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem1.Image")));
            this.bindingNavigatorMovePreviousItem1.Name = "bindingNavigatorMovePreviousItem1";
            this.bindingNavigatorMovePreviousItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem1.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator3
            // 
            this.bindingNavigatorSeparator3.Name = "bindingNavigatorSeparator3";
            this.bindingNavigatorSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem1
            // 
            this.bindingNavigatorPositionItem1.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem1.AutoSize = false;
            this.bindingNavigatorPositionItem1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem1.Name = "bindingNavigatorPositionItem1";
            this.bindingNavigatorPositionItem1.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem1.Text = "0";
            this.bindingNavigatorPositionItem1.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator4
            // 
            this.bindingNavigatorSeparator4.Name = "bindingNavigatorSeparator4";
            this.bindingNavigatorSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem1
            // 
            this.bindingNavigatorMoveNextItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem1.Image")));
            this.bindingNavigatorMoveNextItem1.Name = "bindingNavigatorMoveNextItem1";
            this.bindingNavigatorMoveNextItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem1.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem1
            // 
            this.bindingNavigatorMoveLastItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem1.Image")));
            this.bindingNavigatorMoveLastItem1.Name = "bindingNavigatorMoveLastItem1";
            this.bindingNavigatorMoveLastItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem1.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator5
            // 
            this.bindingNavigatorSeparator5.Name = "bindingNavigatorSeparator5";
            this.bindingNavigatorSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // nomer_prodagyTextBox
            // 
            this.nomer_prodagyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.prodagaBindingSource, "Nomer_prodagy", true));
            this.nomer_prodagyTextBox.Location = new System.Drawing.Point(836, 253);
            this.nomer_prodagyTextBox.Name = "nomer_prodagyTextBox";
            this.nomer_prodagyTextBox.Size = new System.Drawing.Size(100, 20);
            this.nomer_prodagyTextBox.TabIndex = 4;
            // 
            // name_tovaraTextBox
            // 
            this.name_tovaraTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.prodagaBindingSource, "Name_tovara", true));
            this.name_tovaraTextBox.Location = new System.Drawing.Point(836, 279);
            this.name_tovaraTextBox.Name = "name_tovaraTextBox";
            this.name_tovaraTextBox.Size = new System.Drawing.Size(100, 20);
            this.name_tovaraTextBox.TabIndex = 6;
            // 
            // sposob_dostavkiTextBox
            // 
            this.sposob_dostavkiTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.prodagaBindingSource, "Sposob_dostavki", true));
            this.sposob_dostavkiTextBox.Location = new System.Drawing.Point(836, 305);
            this.sposob_dostavkiTextBox.Name = "sposob_dostavkiTextBox";
            this.sposob_dostavkiTextBox.Size = new System.Drawing.Size(100, 20);
            this.sposob_dostavkiTextBox.TabIndex = 8;
            // 
            // kolichestvo_prodavaemyh_edinitsTextBox
            // 
            this.kolichestvo_prodavaemyh_edinitsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.prodagaBindingSource, "Kolichestvo_prodavaemyh_edinits", true));
            this.kolichestvo_prodavaemyh_edinitsTextBox.Location = new System.Drawing.Point(836, 331);
            this.kolichestvo_prodavaemyh_edinitsTextBox.Name = "kolichestvo_prodavaemyh_edinitsTextBox";
            this.kolichestvo_prodavaemyh_edinitsTextBox.Size = new System.Drawing.Size(100, 20);
            this.kolichestvo_prodavaemyh_edinitsTextBox.TabIndex = 10;
            // 
            // price_prodagyTextBox
            // 
            this.price_prodagyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.prodagaBindingSource, "Price_prodagy", true));
            this.price_prodagyTextBox.Location = new System.Drawing.Point(836, 357);
            this.price_prodagyTextBox.Name = "price_prodagyTextBox";
            this.price_prodagyTextBox.Size = new System.Drawing.Size(100, 20);
            this.price_prodagyTextBox.TabIndex = 12;
            // 
            // name_storeTextBox
            // 
            this.name_storeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.prodagaBindingSource, "Name_store", true));
            this.name_storeTextBox.Location = new System.Drawing.Point(836, 383);
            this.name_storeTextBox.Name = "name_storeTextBox";
            this.name_storeTextBox.Size = new System.Drawing.Size(100, 20);
            this.name_storeTextBox.TabIndex = 14;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(679, 109);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 2;
            this.button6.Text = "save";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(679, 71);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 1;
            this.button5.Text = "new record";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // prodagaDataGridView
            // 
            this.prodagaDataGridView.AutoGenerateColumns = false;
            this.prodagaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.prodagaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18,
            this.dataGridViewTextBoxColumn19,
            this.dataGridViewTextBoxColumn20,
            this.dataGridViewTextBoxColumn21,
            this.dataGridViewTextBoxColumn22});
            this.prodagaDataGridView.DataSource = this.prodagaBindingSource;
            this.prodagaDataGridView.Location = new System.Drawing.Point(6, 31);
            this.prodagaDataGridView.Name = "prodagaDataGridView";
            this.prodagaDataGridView.Size = new System.Drawing.Size(651, 208);
            this.prodagaDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "Nomer_prodagy";
            this.dataGridViewTextBoxColumn17.HeaderText = "Nomer_prodagy";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "Name_tovara";
            this.dataGridViewTextBoxColumn18.HeaderText = "Name_tovara";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "Sposob_dostavki";
            this.dataGridViewTextBoxColumn19.HeaderText = "Sposob_dostavki";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.DataPropertyName = "Kolichestvo_prodavaemyh_edinits";
            this.dataGridViewTextBoxColumn20.HeaderText = "Kolichestvo_prodavaemyh_edinits";
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            // 
            // dataGridViewTextBoxColumn21
            // 
            this.dataGridViewTextBoxColumn21.DataPropertyName = "Price_prodagy";
            this.dataGridViewTextBoxColumn21.HeaderText = "Price_prodagy";
            this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            // 
            // dataGridViewTextBoxColumn22
            // 
            this.dataGridViewTextBoxColumn22.DataPropertyName = "Name_store";
            this.dataGridViewTextBoxColumn22.HeaderText = "Name_store";
            this.dataGridViewTextBoxColumn22.Name = "dataGridViewTextBoxColumn22";
            // 
            // Proizvoditel
            // 
            this.Proizvoditel.Controls.Add(this.bindingNavigator3);
            this.Proizvoditel.Controls.Add(this.button8);
            this.Proizvoditel.Controls.Add(this.button7);
            this.Proizvoditel.Controls.Add(this.iD_tovaraLabel);
            this.Proizvoditel.Controls.Add(this.iD_tovaraTextBox);
            this.Proizvoditel.Controls.Add(this.kontaktniy_nomerLabel1);
            this.Proizvoditel.Controls.Add(this.kontaktniy_nomerTextBox1);
            this.Proizvoditel.Controls.Add(this.kontaktnoe_litsoLabel1);
            this.Proizvoditel.Controls.Add(this.kontaktnoe_litsoTextBox1);
            this.Proizvoditel.Controls.Add(this.name_tovaraLabel1);
            this.Proizvoditel.Controls.Add(this.name_tovaraTextBox1);
            this.Proizvoditel.Controls.Add(this.stranaLabel1);
            this.Proizvoditel.Controls.Add(this.stranaTextBox1);
            this.Proizvoditel.Controls.Add(this.domLabel1);
            this.Proizvoditel.Controls.Add(this.domTextBox1);
            this.Proizvoditel.Controls.Add(this.ulitsaLabel1);
            this.Proizvoditel.Controls.Add(this.ulitsaTextBox1);
            this.Proizvoditel.Controls.Add(this.gorodLabel1);
            this.Proizvoditel.Controls.Add(this.gorodTextBox1);
            this.Proizvoditel.Controls.Add(this.name_proizvoditelLabel);
            this.Proizvoditel.Controls.Add(this.name_proizvoditelTextBox);
            this.Proizvoditel.Controls.Add(this.proizvoditelDataGridView);
            this.Proizvoditel.Location = new System.Drawing.Point(4, 22);
            this.Proizvoditel.Name = "Proizvoditel";
            this.Proizvoditel.Size = new System.Drawing.Size(1081, 552);
            this.Proizvoditel.TabIndex = 2;
            this.Proizvoditel.Text = "Proizvoditel";
            this.Proizvoditel.UseVisualStyleBackColor = true;
            // 
            // bindingNavigator3
            // 
            this.bindingNavigator3.AddNewItem = this.bindingNavigatorAddNewItem2;
            this.bindingNavigator3.BindingSource = this.proizvoditelBindingSource;
            this.bindingNavigator3.CountItem = this.bindingNavigatorCountItem2;
            this.bindingNavigator3.DeleteItem = this.bindingNavigatorDeleteItem2;
            this.bindingNavigator3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem2,
            this.bindingNavigatorMovePreviousItem2,
            this.bindingNavigatorSeparator6,
            this.bindingNavigatorPositionItem2,
            this.bindingNavigatorCountItem2,
            this.bindingNavigatorSeparator7,
            this.bindingNavigatorMoveNextItem2,
            this.bindingNavigatorMoveLastItem2,
            this.bindingNavigatorSeparator8,
            this.bindingNavigatorAddNewItem2,
            this.bindingNavigatorDeleteItem2});
            this.bindingNavigator3.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator3.MoveFirstItem = this.bindingNavigatorMoveFirstItem2;
            this.bindingNavigator3.MoveLastItem = this.bindingNavigatorMoveLastItem2;
            this.bindingNavigator3.MoveNextItem = this.bindingNavigatorMoveNextItem2;
            this.bindingNavigator3.MovePreviousItem = this.bindingNavigatorMovePreviousItem2;
            this.bindingNavigator3.Name = "bindingNavigator3";
            this.bindingNavigator3.PositionItem = this.bindingNavigatorPositionItem2;
            this.bindingNavigator3.Size = new System.Drawing.Size(1081, 25);
            this.bindingNavigator3.TabIndex = 23;
            this.bindingNavigator3.Text = "bindingNavigator3";
            // 
            // bindingNavigatorAddNewItem2
            // 
            this.bindingNavigatorAddNewItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem2.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem2.Image")));
            this.bindingNavigatorAddNewItem2.Name = "bindingNavigatorAddNewItem2";
            this.bindingNavigatorAddNewItem2.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem2.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem2.Text = "Добавить";
            // 
            // proizvoditelBindingSource
            // 
            this.proizvoditelBindingSource.DataMember = "Proizvoditel";
            this.proizvoditelBindingSource.DataSource = this.dataBase;
            this.proizvoditelBindingSource.CurrentChanged += new System.EventHandler(this.proizvoditelBindingSource_CurrentChanged);
            // 
            // bindingNavigatorCountItem2
            // 
            this.bindingNavigatorCountItem2.Name = "bindingNavigatorCountItem2";
            this.bindingNavigatorCountItem2.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem2.Text = "для {0}";
            this.bindingNavigatorCountItem2.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem2
            // 
            this.bindingNavigatorDeleteItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem2.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem2.Image")));
            this.bindingNavigatorDeleteItem2.Name = "bindingNavigatorDeleteItem2";
            this.bindingNavigatorDeleteItem2.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem2.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem2.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem2
            // 
            this.bindingNavigatorMoveFirstItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem2.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem2.Image")));
            this.bindingNavigatorMoveFirstItem2.Name = "bindingNavigatorMoveFirstItem2";
            this.bindingNavigatorMoveFirstItem2.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem2.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem2.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem2
            // 
            this.bindingNavigatorMovePreviousItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem2.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem2.Image")));
            this.bindingNavigatorMovePreviousItem2.Name = "bindingNavigatorMovePreviousItem2";
            this.bindingNavigatorMovePreviousItem2.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem2.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem2.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator6
            // 
            this.bindingNavigatorSeparator6.Name = "bindingNavigatorSeparator6";
            this.bindingNavigatorSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem2
            // 
            this.bindingNavigatorPositionItem2.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem2.AutoSize = false;
            this.bindingNavigatorPositionItem2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem2.Name = "bindingNavigatorPositionItem2";
            this.bindingNavigatorPositionItem2.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem2.Text = "0";
            this.bindingNavigatorPositionItem2.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator7
            // 
            this.bindingNavigatorSeparator7.Name = "bindingNavigatorSeparator7";
            this.bindingNavigatorSeparator7.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem2
            // 
            this.bindingNavigatorMoveNextItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem2.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem2.Image")));
            this.bindingNavigatorMoveNextItem2.Name = "bindingNavigatorMoveNextItem2";
            this.bindingNavigatorMoveNextItem2.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem2.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem2.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem2
            // 
            this.bindingNavigatorMoveLastItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem2.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem2.Image")));
            this.bindingNavigatorMoveLastItem2.Name = "bindingNavigatorMoveLastItem2";
            this.bindingNavigatorMoveLastItem2.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem2.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem2.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator8
            // 
            this.bindingNavigatorSeparator8.Name = "bindingNavigatorSeparator8";
            this.bindingNavigatorSeparator8.Size = new System.Drawing.Size(6, 25);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(983, 145);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 22;
            this.button8.Text = "save";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(983, 93);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 21;
            this.button7.Text = "new record";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // iD_tovaraTextBox
            // 
            this.iD_tovaraTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.proizvoditelBindingSource, "ID_tovara", true));
            this.iD_tovaraTextBox.Location = new System.Drawing.Point(812, 287);
            this.iD_tovaraTextBox.Name = "iD_tovaraTextBox";
            this.iD_tovaraTextBox.Size = new System.Drawing.Size(100, 20);
            this.iD_tovaraTextBox.TabIndex = 2;
            // 
            // kontaktniy_nomerTextBox1
            // 
            this.kontaktniy_nomerTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.proizvoditelBindingSource, "Kontaktniy_nomer", true));
            this.kontaktniy_nomerTextBox1.Location = new System.Drawing.Point(812, 313);
            this.kontaktniy_nomerTextBox1.Name = "kontaktniy_nomerTextBox1";
            this.kontaktniy_nomerTextBox1.Size = new System.Drawing.Size(100, 20);
            this.kontaktniy_nomerTextBox1.TabIndex = 4;
            // 
            // kontaktnoe_litsoTextBox1
            // 
            this.kontaktnoe_litsoTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.proizvoditelBindingSource, "Kontaktnoe_litso", true));
            this.kontaktnoe_litsoTextBox1.Location = new System.Drawing.Point(812, 339);
            this.kontaktnoe_litsoTextBox1.Name = "kontaktnoe_litsoTextBox1";
            this.kontaktnoe_litsoTextBox1.Size = new System.Drawing.Size(100, 20);
            this.kontaktnoe_litsoTextBox1.TabIndex = 6;
            // 
            // name_tovaraTextBox1
            // 
            this.name_tovaraTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.proizvoditelBindingSource, "Name_tovara", true));
            this.name_tovaraTextBox1.Location = new System.Drawing.Point(812, 365);
            this.name_tovaraTextBox1.Name = "name_tovaraTextBox1";
            this.name_tovaraTextBox1.Size = new System.Drawing.Size(100, 20);
            this.name_tovaraTextBox1.TabIndex = 8;
            // 
            // stranaTextBox1
            // 
            this.stranaTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.proizvoditelBindingSource, "Strana", true));
            this.stranaTextBox1.Location = new System.Drawing.Point(812, 391);
            this.stranaTextBox1.Name = "stranaTextBox1";
            this.stranaTextBox1.Size = new System.Drawing.Size(100, 20);
            this.stranaTextBox1.TabIndex = 10;
            // 
            // domTextBox1
            // 
            this.domTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.proizvoditelBindingSource, "Dom", true));
            this.domTextBox1.Location = new System.Drawing.Point(812, 417);
            this.domTextBox1.Name = "domTextBox1";
            this.domTextBox1.Size = new System.Drawing.Size(100, 20);
            this.domTextBox1.TabIndex = 12;
            // 
            // ulitsaTextBox1
            // 
            this.ulitsaTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.proizvoditelBindingSource, "Ulitsa", true));
            this.ulitsaTextBox1.Location = new System.Drawing.Point(812, 443);
            this.ulitsaTextBox1.Name = "ulitsaTextBox1";
            this.ulitsaTextBox1.Size = new System.Drawing.Size(100, 20);
            this.ulitsaTextBox1.TabIndex = 14;
            // 
            // gorodTextBox1
            // 
            this.gorodTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.proizvoditelBindingSource, "Gorod", true));
            this.gorodTextBox1.Location = new System.Drawing.Point(812, 469);
            this.gorodTextBox1.Name = "gorodTextBox1";
            this.gorodTextBox1.Size = new System.Drawing.Size(100, 20);
            this.gorodTextBox1.TabIndex = 16;
            // 
            // name_proizvoditelTextBox
            // 
            this.name_proizvoditelTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.proizvoditelBindingSource, "Name_proizvoditel", true));
            this.name_proizvoditelTextBox.Location = new System.Drawing.Point(812, 495);
            this.name_proizvoditelTextBox.Name = "name_proizvoditelTextBox";
            this.name_proizvoditelTextBox.Size = new System.Drawing.Size(100, 20);
            this.name_proizvoditelTextBox.TabIndex = 18;
            // 
            // proizvoditelDataGridView
            // 
            this.proizvoditelDataGridView.AutoGenerateColumns = false;
            this.proizvoditelDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.proizvoditelDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn23,
            this.dataGridViewTextBoxColumn24,
            this.dataGridViewTextBoxColumn25,
            this.dataGridViewTextBoxColumn26,
            this.dataGridViewTextBoxColumn27,
            this.dataGridViewTextBoxColumn28,
            this.dataGridViewTextBoxColumn29,
            this.dataGridViewTextBoxColumn30,
            this.dataGridViewTextBoxColumn31});
            this.proizvoditelDataGridView.DataSource = this.proizvoditelBindingSource;
            this.proizvoditelDataGridView.Location = new System.Drawing.Point(0, 28);
            this.proizvoditelDataGridView.Name = "proizvoditelDataGridView";
            this.proizvoditelDataGridView.Size = new System.Drawing.Size(949, 220);
            this.proizvoditelDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn23
            // 
            this.dataGridViewTextBoxColumn23.DataPropertyName = "ID_tovara";
            this.dataGridViewTextBoxColumn23.HeaderText = "ID_tovara";
            this.dataGridViewTextBoxColumn23.Name = "dataGridViewTextBoxColumn23";
            // 
            // dataGridViewTextBoxColumn24
            // 
            this.dataGridViewTextBoxColumn24.DataPropertyName = "Kontaktniy_nomer";
            this.dataGridViewTextBoxColumn24.HeaderText = "Kontaktniy_nomer";
            this.dataGridViewTextBoxColumn24.Name = "dataGridViewTextBoxColumn24";
            // 
            // dataGridViewTextBoxColumn25
            // 
            this.dataGridViewTextBoxColumn25.DataPropertyName = "Kontaktnoe_litso";
            this.dataGridViewTextBoxColumn25.HeaderText = "Kontaktnoe_litso";
            this.dataGridViewTextBoxColumn25.Name = "dataGridViewTextBoxColumn25";
            // 
            // dataGridViewTextBoxColumn26
            // 
            this.dataGridViewTextBoxColumn26.DataPropertyName = "Name_tovara";
            this.dataGridViewTextBoxColumn26.HeaderText = "Name_tovara";
            this.dataGridViewTextBoxColumn26.Name = "dataGridViewTextBoxColumn26";
            // 
            // dataGridViewTextBoxColumn27
            // 
            this.dataGridViewTextBoxColumn27.DataPropertyName = "Strana";
            this.dataGridViewTextBoxColumn27.HeaderText = "Strana";
            this.dataGridViewTextBoxColumn27.Name = "dataGridViewTextBoxColumn27";
            // 
            // dataGridViewTextBoxColumn28
            // 
            this.dataGridViewTextBoxColumn28.DataPropertyName = "Dom";
            this.dataGridViewTextBoxColumn28.HeaderText = "Dom";
            this.dataGridViewTextBoxColumn28.Name = "dataGridViewTextBoxColumn28";
            // 
            // dataGridViewTextBoxColumn29
            // 
            this.dataGridViewTextBoxColumn29.DataPropertyName = "Ulitsa";
            this.dataGridViewTextBoxColumn29.HeaderText = "Ulitsa";
            this.dataGridViewTextBoxColumn29.Name = "dataGridViewTextBoxColumn29";
            // 
            // dataGridViewTextBoxColumn30
            // 
            this.dataGridViewTextBoxColumn30.DataPropertyName = "Gorod";
            this.dataGridViewTextBoxColumn30.HeaderText = "Gorod";
            this.dataGridViewTextBoxColumn30.Name = "dataGridViewTextBoxColumn30";
            // 
            // dataGridViewTextBoxColumn31
            // 
            this.dataGridViewTextBoxColumn31.DataPropertyName = "Name_proizvoditel";
            this.dataGridViewTextBoxColumn31.HeaderText = "Name_proizvoditel";
            this.dataGridViewTextBoxColumn31.Name = "dataGridViewTextBoxColumn31";
            // 
            // Sportivnie_tovary
            // 
            this.Sportivnie_tovary.Controls.Add(this.bindingNavigator4);
            this.Sportivnie_tovary.Controls.Add(iD_tovaraLabel1);
            this.Sportivnie_tovary.Controls.Add(this.iD_tovaraTextBox1);
            this.Sportivnie_tovary.Controls.Add(name_tovaraLabel2);
            this.Sportivnie_tovary.Controls.Add(this.name_tovaraTextBox2);
            this.Sportivnie_tovary.Controls.Add(materialLabel);
            this.Sportivnie_tovary.Controls.Add(this.materialTextBox);
            this.Sportivnie_tovary.Controls.Add(razmerLabel);
            this.Sportivnie_tovary.Controls.Add(this.razmerTextBox);
            this.Sportivnie_tovary.Controls.Add(forma_tovaraLabel);
            this.Sportivnie_tovary.Controls.Add(this.forma_tovaraTextBox);
            this.Sportivnie_tovary.Controls.Add(this.button10);
            this.Sportivnie_tovary.Controls.Add(this.button9);
            this.Sportivnie_tovary.Controls.Add(this.sport_tovaryDataGridView);
            this.Sportivnie_tovary.Location = new System.Drawing.Point(4, 22);
            this.Sportivnie_tovary.Name = "Sportivnie_tovary";
            this.Sportivnie_tovary.Size = new System.Drawing.Size(1081, 552);
            this.Sportivnie_tovary.TabIndex = 3;
            this.Sportivnie_tovary.Text = "Sportivnie_tovary";
            this.Sportivnie_tovary.UseVisualStyleBackColor = true;
            // 
            // bindingNavigator4
            // 
            this.bindingNavigator4.AddNewItem = this.bindingNavigatorAddNewItem3;
            this.bindingNavigator4.BindingSource = this.sport_tovaryBindingSource;
            this.bindingNavigator4.CountItem = this.bindingNavigatorCountItem3;
            this.bindingNavigator4.DeleteItem = this.bindingNavigatorDeleteItem3;
            this.bindingNavigator4.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem3,
            this.bindingNavigatorMovePreviousItem3,
            this.bindingNavigatorSeparator9,
            this.bindingNavigatorPositionItem3,
            this.bindingNavigatorCountItem3,
            this.bindingNavigatorSeparator10,
            this.bindingNavigatorMoveNextItem3,
            this.bindingNavigatorMoveLastItem3,
            this.bindingNavigatorSeparator11,
            this.bindingNavigatorAddNewItem3,
            this.bindingNavigatorDeleteItem3});
            this.bindingNavigator4.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator4.MoveFirstItem = this.bindingNavigatorMoveFirstItem3;
            this.bindingNavigator4.MoveLastItem = this.bindingNavigatorMoveLastItem3;
            this.bindingNavigator4.MoveNextItem = this.bindingNavigatorMoveNextItem3;
            this.bindingNavigator4.MovePreviousItem = this.bindingNavigatorMovePreviousItem3;
            this.bindingNavigator4.Name = "bindingNavigator4";
            this.bindingNavigator4.PositionItem = this.bindingNavigatorPositionItem3;
            this.bindingNavigator4.Size = new System.Drawing.Size(1081, 25);
            this.bindingNavigator4.TabIndex = 13;
            this.bindingNavigator4.Text = "bindingNavigator4";
            // 
            // bindingNavigatorAddNewItem3
            // 
            this.bindingNavigatorAddNewItem3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem3.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem3.Image")));
            this.bindingNavigatorAddNewItem3.Name = "bindingNavigatorAddNewItem3";
            this.bindingNavigatorAddNewItem3.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem3.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem3.Text = "Добавить";
            // 
            // sport_tovaryBindingSource
            // 
            this.sport_tovaryBindingSource.DataMember = "Sport_tovary";
            this.sport_tovaryBindingSource.DataSource = this.dataBase;
            // 
            // bindingNavigatorCountItem3
            // 
            this.bindingNavigatorCountItem3.Name = "bindingNavigatorCountItem3";
            this.bindingNavigatorCountItem3.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem3.Text = "для {0}";
            this.bindingNavigatorCountItem3.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem3
            // 
            this.bindingNavigatorDeleteItem3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem3.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem3.Image")));
            this.bindingNavigatorDeleteItem3.Name = "bindingNavigatorDeleteItem3";
            this.bindingNavigatorDeleteItem3.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem3.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem3.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem3
            // 
            this.bindingNavigatorMoveFirstItem3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem3.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem3.Image")));
            this.bindingNavigatorMoveFirstItem3.Name = "bindingNavigatorMoveFirstItem3";
            this.bindingNavigatorMoveFirstItem3.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem3.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem3.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem3
            // 
            this.bindingNavigatorMovePreviousItem3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem3.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem3.Image")));
            this.bindingNavigatorMovePreviousItem3.Name = "bindingNavigatorMovePreviousItem3";
            this.bindingNavigatorMovePreviousItem3.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem3.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem3.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator9
            // 
            this.bindingNavigatorSeparator9.Name = "bindingNavigatorSeparator9";
            this.bindingNavigatorSeparator9.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem3
            // 
            this.bindingNavigatorPositionItem3.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem3.AutoSize = false;
            this.bindingNavigatorPositionItem3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem3.Name = "bindingNavigatorPositionItem3";
            this.bindingNavigatorPositionItem3.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem3.Text = "0";
            this.bindingNavigatorPositionItem3.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator10
            // 
            this.bindingNavigatorSeparator10.Name = "bindingNavigatorSeparator10";
            this.bindingNavigatorSeparator10.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem3
            // 
            this.bindingNavigatorMoveNextItem3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem3.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem3.Image")));
            this.bindingNavigatorMoveNextItem3.Name = "bindingNavigatorMoveNextItem3";
            this.bindingNavigatorMoveNextItem3.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem3.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem3.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem3
            // 
            this.bindingNavigatorMoveLastItem3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem3.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem3.Image")));
            this.bindingNavigatorMoveLastItem3.Name = "bindingNavigatorMoveLastItem3";
            this.bindingNavigatorMoveLastItem3.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem3.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem3.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator11
            // 
            this.bindingNavigatorSeparator11.Name = "bindingNavigatorSeparator11";
            this.bindingNavigatorSeparator11.Size = new System.Drawing.Size(6, 25);
            // 
            // iD_tovaraTextBox1
            // 
            this.iD_tovaraTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sport_tovaryBindingSource, "ID_tovara", true));
            this.iD_tovaraTextBox1.Location = new System.Drawing.Point(658, 236);
            this.iD_tovaraTextBox1.Name = "iD_tovaraTextBox1";
            this.iD_tovaraTextBox1.Size = new System.Drawing.Size(100, 20);
            this.iD_tovaraTextBox1.TabIndex = 4;
            // 
            // name_tovaraTextBox2
            // 
            this.name_tovaraTextBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sport_tovaryBindingSource, "Name_tovara", true));
            this.name_tovaraTextBox2.Location = new System.Drawing.Point(658, 262);
            this.name_tovaraTextBox2.Name = "name_tovaraTextBox2";
            this.name_tovaraTextBox2.Size = new System.Drawing.Size(100, 20);
            this.name_tovaraTextBox2.TabIndex = 6;
            // 
            // materialTextBox
            // 
            this.materialTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sport_tovaryBindingSource, "Material", true));
            this.materialTextBox.Location = new System.Drawing.Point(658, 288);
            this.materialTextBox.Name = "materialTextBox";
            this.materialTextBox.Size = new System.Drawing.Size(100, 20);
            this.materialTextBox.TabIndex = 8;
            // 
            // razmerTextBox
            // 
            this.razmerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sport_tovaryBindingSource, "Razmer", true));
            this.razmerTextBox.Location = new System.Drawing.Point(658, 314);
            this.razmerTextBox.Name = "razmerTextBox";
            this.razmerTextBox.Size = new System.Drawing.Size(100, 20);
            this.razmerTextBox.TabIndex = 10;
            // 
            // forma_tovaraTextBox
            // 
            this.forma_tovaraTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sport_tovaryBindingSource, "Forma_tovara", true));
            this.forma_tovaraTextBox.Location = new System.Drawing.Point(658, 340);
            this.forma_tovaraTextBox.Name = "forma_tovaraTextBox";
            this.forma_tovaraTextBox.Size = new System.Drawing.Size(100, 20);
            this.forma_tovaraTextBox.TabIndex = 12;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(577, 116);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 23);
            this.button10.TabIndex = 2;
            this.button10.Text = "save";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click_1);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(577, 73);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 23);
            this.button9.TabIndex = 1;
            this.button9.Text = "new record";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click_1);
            // 
            // sport_tovaryDataGridView
            // 
            this.sport_tovaryDataGridView.AutoGenerateColumns = false;
            this.sport_tovaryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sport_tovaryDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn32,
            this.dataGridViewTextBoxColumn33,
            this.dataGridViewTextBoxColumn34,
            this.dataGridViewTextBoxColumn35,
            this.dataGridViewTextBoxColumn36});
            this.sport_tovaryDataGridView.DataSource = this.sport_tovaryBindingSource;
            this.sport_tovaryDataGridView.Location = new System.Drawing.Point(3, 28);
            this.sport_tovaryDataGridView.Name = "sport_tovaryDataGridView";
            this.sport_tovaryDataGridView.Size = new System.Drawing.Size(546, 198);
            this.sport_tovaryDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn32
            // 
            this.dataGridViewTextBoxColumn32.DataPropertyName = "ID_tovara";
            this.dataGridViewTextBoxColumn32.HeaderText = "ID_tovara";
            this.dataGridViewTextBoxColumn32.Name = "dataGridViewTextBoxColumn32";
            // 
            // dataGridViewTextBoxColumn33
            // 
            this.dataGridViewTextBoxColumn33.DataPropertyName = "Name_tovara";
            this.dataGridViewTextBoxColumn33.HeaderText = "Name_tovara";
            this.dataGridViewTextBoxColumn33.Name = "dataGridViewTextBoxColumn33";
            // 
            // dataGridViewTextBoxColumn34
            // 
            this.dataGridViewTextBoxColumn34.DataPropertyName = "Material";
            this.dataGridViewTextBoxColumn34.HeaderText = "Material";
            this.dataGridViewTextBoxColumn34.Name = "dataGridViewTextBoxColumn34";
            // 
            // dataGridViewTextBoxColumn35
            // 
            this.dataGridViewTextBoxColumn35.DataPropertyName = "Razmer";
            this.dataGridViewTextBoxColumn35.HeaderText = "Razmer";
            this.dataGridViewTextBoxColumn35.Name = "dataGridViewTextBoxColumn35";
            // 
            // dataGridViewTextBoxColumn36
            // 
            this.dataGridViewTextBoxColumn36.DataPropertyName = "Forma_tovara";
            this.dataGridViewTextBoxColumn36.HeaderText = "Forma_tovara";
            this.dataGridViewTextBoxColumn36.Name = "dataGridViewTextBoxColumn36";
            // 
            // Storage
            // 
            this.Storage.Controls.Add(this.bindingNavigator5);
            this.Storage.Controls.Add(this.button12);
            this.Storage.Controls.Add(this.button11);
            this.Storage.Controls.Add(iD_tovaraLabel2);
            this.Storage.Controls.Add(this.iD_tovaraTextBox2);
            this.Storage.Controls.Add(sylka_na_tovarLabel);
            this.Storage.Controls.Add(this.sylka_na_tovarTextBox);
            this.Storage.Controls.Add(price_zakypkiLabel);
            this.Storage.Controls.Add(this.price_zakypkiTextBox);
            this.Storage.Controls.Add(price_prodagyLabel1);
            this.Storage.Controls.Add(this.price_prodagyTextBox1);
            this.Storage.Controls.Add(kolichestvo_tovarovLabel);
            this.Storage.Controls.Add(this.kolichestvo_tovarovTextBox);
            this.Storage.Controls.Add(this.storageDataGridView);
            this.Storage.Location = new System.Drawing.Point(4, 22);
            this.Storage.Name = "Storage";
            this.Storage.Size = new System.Drawing.Size(1081, 552);
            this.Storage.TabIndex = 4;
            this.Storage.Text = "Storage";
            this.Storage.UseVisualStyleBackColor = true;
            // 
            // bindingNavigator5
            // 
            this.bindingNavigator5.AddNewItem = this.bindingNavigatorAddNewItem4;
            this.bindingNavigator5.BindingSource = this.storageBindingSource;
            this.bindingNavigator5.CountItem = this.bindingNavigatorCountItem4;
            this.bindingNavigator5.DeleteItem = this.bindingNavigatorDeleteItem4;
            this.bindingNavigator5.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem4,
            this.bindingNavigatorMovePreviousItem4,
            this.bindingNavigatorSeparator12,
            this.bindingNavigatorPositionItem4,
            this.bindingNavigatorCountItem4,
            this.bindingNavigatorSeparator13,
            this.bindingNavigatorMoveNextItem4,
            this.bindingNavigatorMoveLastItem4,
            this.bindingNavigatorSeparator14,
            this.bindingNavigatorAddNewItem4,
            this.bindingNavigatorDeleteItem4});
            this.bindingNavigator5.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator5.MoveFirstItem = this.bindingNavigatorMoveFirstItem4;
            this.bindingNavigator5.MoveLastItem = this.bindingNavigatorMoveLastItem4;
            this.bindingNavigator5.MoveNextItem = this.bindingNavigatorMoveNextItem4;
            this.bindingNavigator5.MovePreviousItem = this.bindingNavigatorMovePreviousItem4;
            this.bindingNavigator5.Name = "bindingNavigator5";
            this.bindingNavigator5.PositionItem = this.bindingNavigatorPositionItem4;
            this.bindingNavigator5.Size = new System.Drawing.Size(1081, 25);
            this.bindingNavigator5.TabIndex = 13;
            this.bindingNavigator5.Text = "bindingNavigator5";
            // 
            // bindingNavigatorAddNewItem4
            // 
            this.bindingNavigatorAddNewItem4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem4.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem4.Image")));
            this.bindingNavigatorAddNewItem4.Name = "bindingNavigatorAddNewItem4";
            this.bindingNavigatorAddNewItem4.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem4.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem4.Text = "Добавить";
            // 
            // storageBindingSource
            // 
            this.storageBindingSource.DataMember = "Storage";
            this.storageBindingSource.DataSource = this.dataBase;
            // 
            // bindingNavigatorCountItem4
            // 
            this.bindingNavigatorCountItem4.Name = "bindingNavigatorCountItem4";
            this.bindingNavigatorCountItem4.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem4.Text = "для {0}";
            this.bindingNavigatorCountItem4.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem4
            // 
            this.bindingNavigatorDeleteItem4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem4.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem4.Image")));
            this.bindingNavigatorDeleteItem4.Name = "bindingNavigatorDeleteItem4";
            this.bindingNavigatorDeleteItem4.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem4.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem4.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem4
            // 
            this.bindingNavigatorMoveFirstItem4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem4.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem4.Image")));
            this.bindingNavigatorMoveFirstItem4.Name = "bindingNavigatorMoveFirstItem4";
            this.bindingNavigatorMoveFirstItem4.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem4.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem4.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem4
            // 
            this.bindingNavigatorMovePreviousItem4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem4.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem4.Image")));
            this.bindingNavigatorMovePreviousItem4.Name = "bindingNavigatorMovePreviousItem4";
            this.bindingNavigatorMovePreviousItem4.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem4.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem4.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator12
            // 
            this.bindingNavigatorSeparator12.Name = "bindingNavigatorSeparator12";
            this.bindingNavigatorSeparator12.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem4
            // 
            this.bindingNavigatorPositionItem4.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem4.AutoSize = false;
            this.bindingNavigatorPositionItem4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem4.Name = "bindingNavigatorPositionItem4";
            this.bindingNavigatorPositionItem4.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem4.Text = "0";
            this.bindingNavigatorPositionItem4.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator13
            // 
            this.bindingNavigatorSeparator13.Name = "bindingNavigatorSeparator13";
            this.bindingNavigatorSeparator13.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem4
            // 
            this.bindingNavigatorMoveNextItem4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem4.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem4.Image")));
            this.bindingNavigatorMoveNextItem4.Name = "bindingNavigatorMoveNextItem4";
            this.bindingNavigatorMoveNextItem4.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem4.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem4.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem4
            // 
            this.bindingNavigatorMoveLastItem4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem4.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem4.Image")));
            this.bindingNavigatorMoveLastItem4.Name = "bindingNavigatorMoveLastItem4";
            this.bindingNavigatorMoveLastItem4.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem4.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem4.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator14
            // 
            this.bindingNavigatorSeparator14.Name = "bindingNavigatorSeparator14";
            this.bindingNavigatorSeparator14.Size = new System.Drawing.Size(6, 25);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(563, 120);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(75, 23);
            this.button12.TabIndex = 12;
            this.button12.Text = "save";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(563, 78);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(75, 23);
            this.button11.TabIndex = 11;
            this.button11.Text = "new record";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // iD_tovaraTextBox2
            // 
            this.iD_tovaraTextBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.storageBindingSource, "ID_tovara", true));
            this.iD_tovaraTextBox2.Location = new System.Drawing.Point(694, 239);
            this.iD_tovaraTextBox2.Name = "iD_tovaraTextBox2";
            this.iD_tovaraTextBox2.Size = new System.Drawing.Size(100, 20);
            this.iD_tovaraTextBox2.TabIndex = 2;
            // 
            // sylka_na_tovarTextBox
            // 
            this.sylka_na_tovarTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.storageBindingSource, "Sylka_na_tovar", true));
            this.sylka_na_tovarTextBox.Location = new System.Drawing.Point(694, 265);
            this.sylka_na_tovarTextBox.Name = "sylka_na_tovarTextBox";
            this.sylka_na_tovarTextBox.Size = new System.Drawing.Size(100, 20);
            this.sylka_na_tovarTextBox.TabIndex = 4;
            // 
            // price_zakypkiTextBox
            // 
            this.price_zakypkiTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.storageBindingSource, "Price_zakypki", true));
            this.price_zakypkiTextBox.Location = new System.Drawing.Point(694, 291);
            this.price_zakypkiTextBox.Name = "price_zakypkiTextBox";
            this.price_zakypkiTextBox.Size = new System.Drawing.Size(100, 20);
            this.price_zakypkiTextBox.TabIndex = 6;
            // 
            // price_prodagyTextBox1
            // 
            this.price_prodagyTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.storageBindingSource, "Price_prodagy", true));
            this.price_prodagyTextBox1.Location = new System.Drawing.Point(694, 317);
            this.price_prodagyTextBox1.Name = "price_prodagyTextBox1";
            this.price_prodagyTextBox1.Size = new System.Drawing.Size(100, 20);
            this.price_prodagyTextBox1.TabIndex = 8;
            // 
            // kolichestvo_tovarovTextBox
            // 
            this.kolichestvo_tovarovTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.storageBindingSource, "Kolichestvo_tovarov", true));
            this.kolichestvo_tovarovTextBox.Location = new System.Drawing.Point(694, 343);
            this.kolichestvo_tovarovTextBox.Name = "kolichestvo_tovarovTextBox";
            this.kolichestvo_tovarovTextBox.Size = new System.Drawing.Size(100, 20);
            this.kolichestvo_tovarovTextBox.TabIndex = 10;
            // 
            // storageDataGridView
            // 
            this.storageDataGridView.AutoGenerateColumns = false;
            this.storageDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.storageDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn37,
            this.dataGridViewTextBoxColumn38,
            this.dataGridViewTextBoxColumn39,
            this.dataGridViewTextBoxColumn40,
            this.dataGridViewTextBoxColumn41});
            this.storageDataGridView.DataSource = this.storageBindingSource;
            this.storageDataGridView.Location = new System.Drawing.Point(0, 28);
            this.storageDataGridView.Name = "storageDataGridView";
            this.storageDataGridView.Size = new System.Drawing.Size(546, 220);
            this.storageDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn37
            // 
            this.dataGridViewTextBoxColumn37.DataPropertyName = "ID_tovara";
            this.dataGridViewTextBoxColumn37.HeaderText = "ID_tovara";
            this.dataGridViewTextBoxColumn37.Name = "dataGridViewTextBoxColumn37";
            // 
            // dataGridViewTextBoxColumn38
            // 
            this.dataGridViewTextBoxColumn38.DataPropertyName = "Sylka_na_tovar";
            this.dataGridViewTextBoxColumn38.HeaderText = "Sylka_na_tovar";
            this.dataGridViewTextBoxColumn38.Name = "dataGridViewTextBoxColumn38";
            // 
            // dataGridViewTextBoxColumn39
            // 
            this.dataGridViewTextBoxColumn39.DataPropertyName = "Price_zakypki";
            this.dataGridViewTextBoxColumn39.HeaderText = "Price_zakypki";
            this.dataGridViewTextBoxColumn39.Name = "dataGridViewTextBoxColumn39";
            // 
            // dataGridViewTextBoxColumn40
            // 
            this.dataGridViewTextBoxColumn40.DataPropertyName = "Price_prodagy";
            this.dataGridViewTextBoxColumn40.HeaderText = "Price_prodagy";
            this.dataGridViewTextBoxColumn40.Name = "dataGridViewTextBoxColumn40";
            // 
            // dataGridViewTextBoxColumn41
            // 
            this.dataGridViewTextBoxColumn41.DataPropertyName = "Kolichestvo_tovarov";
            this.dataGridViewTextBoxColumn41.HeaderText = "Kolichestvo_tovarov";
            this.dataGridViewTextBoxColumn41.Name = "dataGridViewTextBoxColumn41";
            // 
            // Zakypka
            // 
            this.Zakypka.Controls.Add(this.bindingNavigator6);
            this.Zakypka.Controls.Add(this.button14);
            this.Zakypka.Controls.Add(this.button13);
            this.Zakypka.Controls.Add(nomer_zakypkiLabel);
            this.Zakypka.Controls.Add(this.nomer_zakypkiTextBox);
            this.Zakypka.Controls.Add(name_postavshikaLabel1);
            this.Zakypka.Controls.Add(this.name_postavshikaTextBox1);
            this.Zakypka.Controls.Add(sposob_dostavkiLabel1);
            this.Zakypka.Controls.Add(this.sposob_dostavkiTextBox1);
            this.Zakypka.Controls.Add(price_zakypkiLabel1);
            this.Zakypka.Controls.Add(this.price_zakypkiTextBox1);
            this.Zakypka.Controls.Add(this.zakypkaDataGridView);
            this.Zakypka.Location = new System.Drawing.Point(4, 22);
            this.Zakypka.Name = "Zakypka";
            this.Zakypka.Size = new System.Drawing.Size(1081, 552);
            this.Zakypka.TabIndex = 5;
            this.Zakypka.Text = "Zakypka";
            this.Zakypka.UseVisualStyleBackColor = true;
            // 
            // bindingNavigator6
            // 
            this.bindingNavigator6.AddNewItem = this.bindingNavigatorAddNewItem5;
            this.bindingNavigator6.BindingSource = this.zakypkaBindingSource;
            this.bindingNavigator6.CountItem = this.bindingNavigatorCountItem5;
            this.bindingNavigator6.DeleteItem = this.bindingNavigatorDeleteItem5;
            this.bindingNavigator6.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem5,
            this.bindingNavigatorMovePreviousItem5,
            this.bindingNavigatorSeparator15,
            this.bindingNavigatorPositionItem5,
            this.bindingNavigatorCountItem5,
            this.bindingNavigatorSeparator16,
            this.bindingNavigatorMoveNextItem5,
            this.bindingNavigatorMoveLastItem5,
            this.bindingNavigatorSeparator17,
            this.bindingNavigatorAddNewItem5,
            this.bindingNavigatorDeleteItem5});
            this.bindingNavigator6.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator6.MoveFirstItem = this.bindingNavigatorMoveFirstItem5;
            this.bindingNavigator6.MoveLastItem = this.bindingNavigatorMoveLastItem5;
            this.bindingNavigator6.MoveNextItem = this.bindingNavigatorMoveNextItem5;
            this.bindingNavigator6.MovePreviousItem = this.bindingNavigatorMovePreviousItem5;
            this.bindingNavigator6.Name = "bindingNavigator6";
            this.bindingNavigator6.PositionItem = this.bindingNavigatorPositionItem5;
            this.bindingNavigator6.Size = new System.Drawing.Size(1081, 25);
            this.bindingNavigator6.TabIndex = 11;
            this.bindingNavigator6.Text = "bindingNavigator6";
            // 
            // bindingNavigatorAddNewItem5
            // 
            this.bindingNavigatorAddNewItem5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem5.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem5.Image")));
            this.bindingNavigatorAddNewItem5.Name = "bindingNavigatorAddNewItem5";
            this.bindingNavigatorAddNewItem5.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem5.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem5.Text = "Добавить";
            // 
            // zakypkaBindingSource
            // 
            this.zakypkaBindingSource.DataMember = "Zakypka";
            this.zakypkaBindingSource.DataSource = this.dataBase;
            // 
            // bindingNavigatorCountItem5
            // 
            this.bindingNavigatorCountItem5.Name = "bindingNavigatorCountItem5";
            this.bindingNavigatorCountItem5.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem5.Text = "для {0}";
            this.bindingNavigatorCountItem5.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem5
            // 
            this.bindingNavigatorDeleteItem5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem5.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem5.Image")));
            this.bindingNavigatorDeleteItem5.Name = "bindingNavigatorDeleteItem5";
            this.bindingNavigatorDeleteItem5.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem5.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem5.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem5
            // 
            this.bindingNavigatorMoveFirstItem5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem5.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem5.Image")));
            this.bindingNavigatorMoveFirstItem5.Name = "bindingNavigatorMoveFirstItem5";
            this.bindingNavigatorMoveFirstItem5.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem5.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem5.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem5
            // 
            this.bindingNavigatorMovePreviousItem5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem5.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem5.Image")));
            this.bindingNavigatorMovePreviousItem5.Name = "bindingNavigatorMovePreviousItem5";
            this.bindingNavigatorMovePreviousItem5.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem5.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem5.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator15
            // 
            this.bindingNavigatorSeparator15.Name = "bindingNavigatorSeparator15";
            this.bindingNavigatorSeparator15.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem5
            // 
            this.bindingNavigatorPositionItem5.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem5.AutoSize = false;
            this.bindingNavigatorPositionItem5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem5.Name = "bindingNavigatorPositionItem5";
            this.bindingNavigatorPositionItem5.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem5.Text = "0";
            this.bindingNavigatorPositionItem5.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator16
            // 
            this.bindingNavigatorSeparator16.Name = "bindingNavigatorSeparator16";
            this.bindingNavigatorSeparator16.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem5
            // 
            this.bindingNavigatorMoveNextItem5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem5.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem5.Image")));
            this.bindingNavigatorMoveNextItem5.Name = "bindingNavigatorMoveNextItem5";
            this.bindingNavigatorMoveNextItem5.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem5.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem5.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem5
            // 
            this.bindingNavigatorMoveLastItem5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem5.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem5.Image")));
            this.bindingNavigatorMoveLastItem5.Name = "bindingNavigatorMoveLastItem5";
            this.bindingNavigatorMoveLastItem5.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem5.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem5.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator17
            // 
            this.bindingNavigatorSeparator17.Name = "bindingNavigatorSeparator17";
            this.bindingNavigatorSeparator17.Size = new System.Drawing.Size(6, 25);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(475, 132);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(75, 23);
            this.button14.TabIndex = 10;
            this.button14.Text = "save";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(475, 84);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(75, 23);
            this.button13.TabIndex = 9;
            this.button13.Text = "new record";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // nomer_zakypkiTextBox
            // 
            this.nomer_zakypkiTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zakypkaBindingSource, "Nomer_zakypki", true));
            this.nomer_zakypkiTextBox.Location = new System.Drawing.Point(576, 236);
            this.nomer_zakypkiTextBox.Name = "nomer_zakypkiTextBox";
            this.nomer_zakypkiTextBox.Size = new System.Drawing.Size(100, 20);
            this.nomer_zakypkiTextBox.TabIndex = 2;
            // 
            // name_postavshikaTextBox1
            // 
            this.name_postavshikaTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zakypkaBindingSource, "Name_postavshika", true));
            this.name_postavshikaTextBox1.Location = new System.Drawing.Point(576, 262);
            this.name_postavshikaTextBox1.Name = "name_postavshikaTextBox1";
            this.name_postavshikaTextBox1.Size = new System.Drawing.Size(100, 20);
            this.name_postavshikaTextBox1.TabIndex = 4;
            // 
            // sposob_dostavkiTextBox1
            // 
            this.sposob_dostavkiTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zakypkaBindingSource, "Sposob_dostavki", true));
            this.sposob_dostavkiTextBox1.Location = new System.Drawing.Point(576, 288);
            this.sposob_dostavkiTextBox1.Name = "sposob_dostavkiTextBox1";
            this.sposob_dostavkiTextBox1.Size = new System.Drawing.Size(100, 20);
            this.sposob_dostavkiTextBox1.TabIndex = 6;
            // 
            // price_zakypkiTextBox1
            // 
            this.price_zakypkiTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zakypkaBindingSource, "Price_zakypki", true));
            this.price_zakypkiTextBox1.Location = new System.Drawing.Point(576, 314);
            this.price_zakypkiTextBox1.Name = "price_zakypkiTextBox1";
            this.price_zakypkiTextBox1.Size = new System.Drawing.Size(100, 20);
            this.price_zakypkiTextBox1.TabIndex = 8;
            // 
            // zakypkaDataGridView
            // 
            this.zakypkaDataGridView.AutoGenerateColumns = false;
            this.zakypkaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.zakypkaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn42,
            this.dataGridViewTextBoxColumn43,
            this.dataGridViewTextBoxColumn44,
            this.dataGridViewTextBoxColumn45});
            this.zakypkaDataGridView.DataSource = this.zakypkaBindingSource;
            this.zakypkaDataGridView.Location = new System.Drawing.Point(0, 28);
            this.zakypkaDataGridView.Name = "zakypkaDataGridView";
            this.zakypkaDataGridView.Size = new System.Drawing.Size(446, 220);
            this.zakypkaDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn42
            // 
            this.dataGridViewTextBoxColumn42.DataPropertyName = "Nomer_zakypki";
            this.dataGridViewTextBoxColumn42.HeaderText = "Nomer_zakypki";
            this.dataGridViewTextBoxColumn42.Name = "dataGridViewTextBoxColumn42";
            // 
            // dataGridViewTextBoxColumn43
            // 
            this.dataGridViewTextBoxColumn43.DataPropertyName = "Name_postavshika";
            this.dataGridViewTextBoxColumn43.HeaderText = "Name_postavshika";
            this.dataGridViewTextBoxColumn43.Name = "dataGridViewTextBoxColumn43";
            // 
            // dataGridViewTextBoxColumn44
            // 
            this.dataGridViewTextBoxColumn44.DataPropertyName = "Sposob_dostavki";
            this.dataGridViewTextBoxColumn44.HeaderText = "Sposob_dostavki";
            this.dataGridViewTextBoxColumn44.Name = "dataGridViewTextBoxColumn44";
            // 
            // dataGridViewTextBoxColumn45
            // 
            this.dataGridViewTextBoxColumn45.DataPropertyName = "Price_zakypki";
            this.dataGridViewTextBoxColumn45.HeaderText = "Price_zakypki";
            this.dataGridViewTextBoxColumn45.Name = "dataGridViewTextBoxColumn45";
            // 
            // postavshik_zakypkaBindingSource
            // 
            this.postavshik_zakypkaBindingSource.DataMember = "Postavshik_zakypka";
            this.postavshik_zakypkaBindingSource.DataSource = this.dataBase;
            // 
            // prodaga_sport_tovaryBindingSource
            // 
            this.prodaga_sport_tovaryBindingSource.DataMember = "Prodaga_sport_tovary";
            this.prodaga_sport_tovaryBindingSource.DataSource = this.dataBase;
            // 
            // proizvoditel_postavshikBindingSource
            // 
            this.proizvoditel_postavshikBindingSource.DataMember = "Proizvoditel_postavshik";
            this.proizvoditel_postavshikBindingSource.DataSource = this.dataBase;
            // 
            // proizvoditel_sport_tovaryBindingSource
            // 
            this.proizvoditel_sport_tovaryBindingSource.DataMember = "Proizvoditel_sport_tovary";
            this.proizvoditel_sport_tovaryBindingSource.DataSource = this.dataBase;
            // 
            // proizvoditelTableAdapter
            // 
            this.proizvoditelTableAdapter.ClearBeforeFill = true;
            // 
            // sport_tovaryTableAdapter
            // 
            this.sport_tovaryTableAdapter.ClearBeforeFill = true;
            // 
            // storageTableAdapter
            // 
            this.storageTableAdapter.ClearBeforeFill = true;
            // 
            // zakypkaTableAdapter
            // 
            this.zakypkaTableAdapter.ClearBeforeFill = true;
            // 
            // proizvoditel_postavshikTableAdapter
            // 
            this.proizvoditel_postavshikTableAdapter.ClearBeforeFill = true;
            // 
            // proizvoditel_sport_tovaryTableAdapter
            // 
            this.proizvoditel_sport_tovaryTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 578);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.iD_postavshikaLabel);
            this.Controls.Add(this.iD_postavshikaTextBox);
            this.Controls.Add(this.name_postavshikaLabel);
            this.Controls.Add(this.name_postavshikaTextBox);
            this.Controls.Add(this.kontaktniy_nomerLabel);
            this.Controls.Add(this.kontaktniy_nomerTextBox);
            this.Controls.Add(this.kontaktnoe_litsoLabel);
            this.Controls.Add(this.kontaktnoe_litsoTextBox);
            this.Controls.Add(this.stranaLabel);
            this.Controls.Add(this.stranaTextBox);
            this.Controls.Add(this.domLabel);
            this.Controls.Add(this.domTextBox);
            this.Controls.Add(this.ulitsaLabel);
            this.Controls.Add(this.ulitsaTextBox);
            this.Controls.Add(this.gorodLabel);
            this.Controls.Add(this.gorodTextBox);
            this.Controls.Add(this.postavshikDataGridView);
            this.Name = "Form1";
            this.Text = "Спортивные товары";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataBase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postavshikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postavshikDataGridView)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.Postavshik.ResumeLayout(false);
            this.Postavshik.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.Prodaga.ResumeLayout(false);
            this.Prodaga.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator2)).EndInit();
            this.bindingNavigator2.ResumeLayout(false);
            this.bindingNavigator2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prodagaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodagaDataGridView)).EndInit();
            this.Proizvoditel.ResumeLayout(false);
            this.Proizvoditel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator3)).EndInit();
            this.bindingNavigator3.ResumeLayout(false);
            this.bindingNavigator3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.proizvoditelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proizvoditelDataGridView)).EndInit();
            this.Sportivnie_tovary.ResumeLayout(false);
            this.Sportivnie_tovary.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator4)).EndInit();
            this.bindingNavigator4.ResumeLayout(false);
            this.bindingNavigator4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sport_tovaryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sport_tovaryDataGridView)).EndInit();
            this.Storage.ResumeLayout(false);
            this.Storage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator5)).EndInit();
            this.bindingNavigator5.ResumeLayout(false);
            this.bindingNavigator5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.storageBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storageDataGridView)).EndInit();
            this.Zakypka.ResumeLayout(false);
            this.Zakypka.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator6)).EndInit();
            this.bindingNavigator6.ResumeLayout(false);
            this.bindingNavigator6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zakypkaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zakypkaDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postavshik_zakypkaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodaga_sport_tovaryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proizvoditel_postavshikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proizvoditel_sport_tovaryBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataBase dataBase;
        private System.Windows.Forms.BindingSource postavshikBindingSource;
        private DataBaseTableAdapters.PostavshikTableAdapter postavshikTableAdapter;
        private DataBaseTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView postavshikDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.TextBox iD_postavshikaTextBox;
        private System.Windows.Forms.TextBox name_postavshikaTextBox;
        private System.Windows.Forms.TextBox kontaktniy_nomerTextBox;
        private System.Windows.Forms.TextBox kontaktnoe_litsoTextBox;
        private System.Windows.Forms.TextBox stranaTextBox;
        private System.Windows.Forms.TextBox domTextBox;
        private System.Windows.Forms.TextBox ulitsaTextBox;
        private System.Windows.Forms.TextBox gorodTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Postavshik;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.TabPage Prodaga;
        private System.Windows.Forms.BindingSource prodagaBindingSource;
        private DataBaseTableAdapters.ProdagaTableAdapter prodagaTableAdapter;
        private System.Windows.Forms.TextBox nomer_prodagyTextBox;
        private System.Windows.Forms.TextBox name_tovaraTextBox;
        private System.Windows.Forms.TextBox sposob_dostavkiTextBox;
        private System.Windows.Forms.TextBox kolichestvo_prodavaemyh_edinitsTextBox;
        private System.Windows.Forms.TextBox price_prodagyTextBox;
        private System.Windows.Forms.TextBox name_storeTextBox;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridView prodagaDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;
        private System.Windows.Forms.TabPage Proizvoditel;
        private System.Windows.Forms.TabPage Storage;
        private System.Windows.Forms.TabPage Zakypka;
        private System.Windows.Forms.BindingSource proizvoditelBindingSource;
        private DataBaseTableAdapters.ProizvoditelTableAdapter proizvoditelTableAdapter;
        private System.Windows.Forms.DataGridView proizvoditelDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn23;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn24;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn25;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn26;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn27;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn28;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn29;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn30;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn31;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TextBox iD_tovaraTextBox;
        private System.Windows.Forms.TextBox kontaktniy_nomerTextBox1;
        private System.Windows.Forms.TextBox kontaktnoe_litsoTextBox1;
        private System.Windows.Forms.TextBox name_tovaraTextBox1;
        private System.Windows.Forms.TextBox stranaTextBox1;
        private System.Windows.Forms.TextBox domTextBox1;
        private System.Windows.Forms.TextBox ulitsaTextBox1;
        private System.Windows.Forms.TextBox gorodTextBox1;
        private System.Windows.Forms.TextBox name_proizvoditelTextBox;
        private System.Windows.Forms.Label iD_postavshikaLabel;
        private System.Windows.Forms.Label name_postavshikaLabel;
        private System.Windows.Forms.Label kontaktniy_nomerLabel;
        private System.Windows.Forms.Label kontaktnoe_litsoLabel;
        private System.Windows.Forms.Label stranaLabel;
        private System.Windows.Forms.Label domLabel;
        private System.Windows.Forms.Label ulitsaLabel;
        private System.Windows.Forms.Label gorodLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label nomer_prodagyLabel;
        private System.Windows.Forms.Label name_tovaraLabel;
        private System.Windows.Forms.Label sposob_dostavkiLabel;
        private System.Windows.Forms.Label kolichestvo_prodavaemyh_edinitsLabel;
        private System.Windows.Forms.Label price_prodagyLabel;
        private System.Windows.Forms.Label name_storeLabel;
        private System.Windows.Forms.Label iD_tovaraLabel;
        private System.Windows.Forms.Label kontaktniy_nomerLabel1;
        private System.Windows.Forms.Label kontaktnoe_litsoLabel1;
        private System.Windows.Forms.Label name_tovaraLabel1;
        private System.Windows.Forms.Label stranaLabel1;
        private System.Windows.Forms.Label domLabel1;
        private System.Windows.Forms.Label ulitsaLabel1;
        private System.Windows.Forms.Label gorodLabel1;
        private System.Windows.Forms.Label name_proizvoditelLabel;
        private System.Windows.Forms.BindingSource sport_tovaryBindingSource;
        private DataBaseTableAdapters.Sport_tovaryTableAdapter sport_tovaryTableAdapter;
        private System.Windows.Forms.TabPage Sportivnie_tovary;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.DataGridView sport_tovaryDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn32;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn33;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn34;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn35;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn36;
        private System.Windows.Forms.TextBox iD_tovaraTextBox1;
        private System.Windows.Forms.TextBox name_tovaraTextBox2;
        private System.Windows.Forms.TextBox materialTextBox;
        private System.Windows.Forms.TextBox razmerTextBox;
        private System.Windows.Forms.TextBox forma_tovaraTextBox;
        private System.Windows.Forms.BindingSource storageBindingSource;
        private DataBaseTableAdapters.StorageTableAdapter storageTableAdapter;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.TextBox iD_tovaraTextBox2;
        private System.Windows.Forms.TextBox sylka_na_tovarTextBox;
        private System.Windows.Forms.TextBox price_zakypkiTextBox;
        private System.Windows.Forms.TextBox price_prodagyTextBox1;
        private System.Windows.Forms.TextBox kolichestvo_tovarovTextBox;
        private System.Windows.Forms.DataGridView storageDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn37;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn38;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn39;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn40;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn41;
        private System.Windows.Forms.BindingSource zakypkaBindingSource;
        private DataBaseTableAdapters.ZakypkaTableAdapter zakypkaTableAdapter;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.TextBox nomer_zakypkiTextBox;
        private System.Windows.Forms.TextBox name_postavshikaTextBox1;
        private System.Windows.Forms.TextBox sposob_dostavkiTextBox1;
        private System.Windows.Forms.TextBox price_zakypkiTextBox1;
        private System.Windows.Forms.DataGridView zakypkaDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn42;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn43;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn44;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn45;
        private System.Windows.Forms.BindingSource postavshik_zakypkaBindingSource;
        private DataBaseTableAdapters.Postavshik_zakypkaTableAdapter postavshik_zakypkaTableAdapter;
        private System.Windows.Forms.BindingSource prodaga_sport_tovaryBindingSource;
        private DataBaseTableAdapters.Prodaga_sport_tovaryTableAdapter prodaga_sport_tovaryTableAdapter;
        private System.Windows.Forms.BindingSource proizvoditel_postavshikBindingSource;
        private DataBaseTableAdapters.Proizvoditel_postavshikTableAdapter proizvoditel_postavshikTableAdapter;
        private System.Windows.Forms.BindingSource proizvoditel_sport_tovaryBindingSource;
        private DataBaseTableAdapters.Proizvoditel_sport_tovaryTableAdapter proizvoditel_sport_tovaryTableAdapter;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
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
        private System.Windows.Forms.BindingNavigator bindingNavigator2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem1;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator3;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator4;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator5;
        private System.Windows.Forms.BindingNavigator bindingNavigator3;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem2;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem2;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator6;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem2;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator7;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem2;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator8;
        private System.Windows.Forms.BindingNavigator bindingNavigator4;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem3;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem3;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem3;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem3;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem3;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator9;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem3;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator10;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem3;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem3;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator11;
        private System.Windows.Forms.BindingNavigator bindingNavigator5;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem4;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem4;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem4;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem4;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem4;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator12;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem4;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator13;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem4;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem4;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator14;
        private System.Windows.Forms.BindingNavigator bindingNavigator6;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem5;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem5;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem5;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem5;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem5;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator15;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem5;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator16;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem5;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem5;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator17;
    }
}

