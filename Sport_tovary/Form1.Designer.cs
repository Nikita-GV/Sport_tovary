
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.Label iD_postavshikaLabel;
            System.Windows.Forms.Label name_postavshikaLabel;
            System.Windows.Forms.Label kontaktniy_nomerLabel;
            System.Windows.Forms.Label kontaktnoe_litsoLabel;
            System.Windows.Forms.Label stranaLabel;
            System.Windows.Forms.Label domLabel;
            System.Windows.Forms.Label ulitsaLabel;
            System.Windows.Forms.Label gorodLabel;
            this.dataBase = new Sport_tovary.DataBase();
            this.postavshikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.postavshikTableAdapter = new Sport_tovary.DataBaseTableAdapters.PostavshikTableAdapter();
            this.tableAdapterManager = new Sport_tovary.DataBaseTableAdapters.TableAdapterManager();
            this.postavshikBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.postavshikBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
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
            iD_postavshikaLabel = new System.Windows.Forms.Label();
            name_postavshikaLabel = new System.Windows.Forms.Label();
            kontaktniy_nomerLabel = new System.Windows.Forms.Label();
            kontaktnoe_litsoLabel = new System.Windows.Forms.Label();
            stranaLabel = new System.Windows.Forms.Label();
            domLabel = new System.Windows.Forms.Label();
            ulitsaLabel = new System.Windows.Forms.Label();
            gorodLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataBase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postavshikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postavshikBindingNavigator)).BeginInit();
            this.postavshikBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.postavshikDataGridView)).BeginInit();
            this.SuspendLayout();
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
            // 
            // postavshikTableAdapter
            // 
            this.postavshikTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Postavshik_zakypkaTableAdapter = null;
            this.tableAdapterManager.PostavshikTableAdapter = this.postavshikTableAdapter;
            this.tableAdapterManager.Prodaga_sport_tovaryTableAdapter = null;
            this.tableAdapterManager.ProdagaTableAdapter = null;
            this.tableAdapterManager.Proizvoditel_postavshikTableAdapter = null;
            this.tableAdapterManager.Proizvoditel_sport_tovaryTableAdapter = null;
            this.tableAdapterManager.ProizvoditelTableAdapter = null;
            this.tableAdapterManager.Sport_tovaryTableAdapter = null;
            this.tableAdapterManager.StorageTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Sport_tovary.DataBaseTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ZakypkaTableAdapter = null;
            // 
            // postavshikBindingNavigator
            // 
            this.postavshikBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.postavshikBindingNavigator.BindingSource = this.postavshikBindingSource;
            this.postavshikBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.postavshikBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.postavshikBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.bindingNavigatorDeleteItem,
            this.postavshikBindingNavigatorSaveItem});
            this.postavshikBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.postavshikBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.postavshikBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.postavshikBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.postavshikBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.postavshikBindingNavigator.Name = "postavshikBindingNavigator";
            this.postavshikBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.postavshikBindingNavigator.Size = new System.Drawing.Size(958, 25);
            this.postavshikBindingNavigator.TabIndex = 0;
            this.postavshikBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 15);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // postavshikBindingNavigatorSaveItem
            // 
            this.postavshikBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.postavshikBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("postavshikBindingNavigatorSaveItem.Image")));
            this.postavshikBindingNavigatorSaveItem.Name = "postavshikBindingNavigatorSaveItem";
            this.postavshikBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.postavshikBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.postavshikBindingNavigatorSaveItem.Click += new System.EventHandler(this.postavshikBindingNavigatorSaveItem_Click);
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
            // iD_postavshikaLabel
            // 
            iD_postavshikaLabel.AutoSize = true;
            iD_postavshikaLabel.Location = new System.Drawing.Point(681, 235);
            iD_postavshikaLabel.Name = "iD_postavshikaLabel";
            iD_postavshikaLabel.Size = new System.Drawing.Size(81, 13);
            iD_postavshikaLabel.TabIndex = 2;
            iD_postavshikaLabel.Text = "ID postavshika:";
            // 
            // iD_postavshikaTextBox
            // 
            this.iD_postavshikaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.postavshikBindingSource, "ID_postavshika", true));
            this.iD_postavshikaTextBox.Location = new System.Drawing.Point(785, 235);
            this.iD_postavshikaTextBox.Name = "iD_postavshikaTextBox";
            this.iD_postavshikaTextBox.Size = new System.Drawing.Size(100, 20);
            this.iD_postavshikaTextBox.TabIndex = 3;
            // 
            // name_postavshikaLabel
            // 
            name_postavshikaLabel.AutoSize = true;
            name_postavshikaLabel.Location = new System.Drawing.Point(681, 264);
            name_postavshikaLabel.Name = "name_postavshikaLabel";
            name_postavshikaLabel.Size = new System.Drawing.Size(98, 13);
            name_postavshikaLabel.TabIndex = 4;
            name_postavshikaLabel.Text = "Name postavshika:";
            // 
            // name_postavshikaTextBox
            // 
            this.name_postavshikaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.postavshikBindingSource, "Name_postavshika", true));
            this.name_postavshikaTextBox.Location = new System.Drawing.Point(785, 261);
            this.name_postavshikaTextBox.Name = "name_postavshikaTextBox";
            this.name_postavshikaTextBox.Size = new System.Drawing.Size(100, 20);
            this.name_postavshikaTextBox.TabIndex = 5;
            // 
            // kontaktniy_nomerLabel
            // 
            kontaktniy_nomerLabel.AutoSize = true;
            kontaktniy_nomerLabel.Location = new System.Drawing.Point(681, 290);
            kontaktniy_nomerLabel.Name = "kontaktniy_nomerLabel";
            kontaktniy_nomerLabel.Size = new System.Drawing.Size(92, 13);
            kontaktniy_nomerLabel.TabIndex = 6;
            kontaktniy_nomerLabel.Text = "Kontaktniy nomer:";
            // 
            // kontaktniy_nomerTextBox
            // 
            this.kontaktniy_nomerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.postavshikBindingSource, "Kontaktniy_nomer", true));
            this.kontaktniy_nomerTextBox.Location = new System.Drawing.Point(785, 287);
            this.kontaktniy_nomerTextBox.Name = "kontaktniy_nomerTextBox";
            this.kontaktniy_nomerTextBox.Size = new System.Drawing.Size(100, 20);
            this.kontaktniy_nomerTextBox.TabIndex = 7;
            // 
            // kontaktnoe_litsoLabel
            // 
            kontaktnoe_litsoLabel.AutoSize = true;
            kontaktnoe_litsoLabel.Location = new System.Drawing.Point(681, 316);
            kontaktnoe_litsoLabel.Name = "kontaktnoe_litsoLabel";
            kontaktnoe_litsoLabel.Size = new System.Drawing.Size(86, 13);
            kontaktnoe_litsoLabel.TabIndex = 8;
            kontaktnoe_litsoLabel.Text = "Kontaktnoe litso:";
            // 
            // kontaktnoe_litsoTextBox
            // 
            this.kontaktnoe_litsoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.postavshikBindingSource, "Kontaktnoe_litso", true));
            this.kontaktnoe_litsoTextBox.Location = new System.Drawing.Point(785, 313);
            this.kontaktnoe_litsoTextBox.Name = "kontaktnoe_litsoTextBox";
            this.kontaktnoe_litsoTextBox.Size = new System.Drawing.Size(100, 20);
            this.kontaktnoe_litsoTextBox.TabIndex = 9;
            // 
            // stranaLabel
            // 
            stranaLabel.AutoSize = true;
            stranaLabel.Location = new System.Drawing.Point(681, 342);
            stranaLabel.Name = "stranaLabel";
            stranaLabel.Size = new System.Drawing.Size(41, 13);
            stranaLabel.TabIndex = 10;
            stranaLabel.Text = "Strana:";
            // 
            // stranaTextBox
            // 
            this.stranaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.postavshikBindingSource, "Strana", true));
            this.stranaTextBox.Location = new System.Drawing.Point(785, 339);
            this.stranaTextBox.Name = "stranaTextBox";
            this.stranaTextBox.Size = new System.Drawing.Size(100, 20);
            this.stranaTextBox.TabIndex = 11;
            // 
            // domLabel
            // 
            domLabel.AutoSize = true;
            domLabel.Location = new System.Drawing.Point(681, 368);
            domLabel.Name = "domLabel";
            domLabel.Size = new System.Drawing.Size(32, 13);
            domLabel.TabIndex = 12;
            domLabel.Text = "Dom:";
            // 
            // domTextBox
            // 
            this.domTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.postavshikBindingSource, "Dom", true));
            this.domTextBox.Location = new System.Drawing.Point(785, 365);
            this.domTextBox.Name = "domTextBox";
            this.domTextBox.Size = new System.Drawing.Size(100, 20);
            this.domTextBox.TabIndex = 13;
            // 
            // ulitsaLabel
            // 
            ulitsaLabel.AutoSize = true;
            ulitsaLabel.Location = new System.Drawing.Point(681, 394);
            ulitsaLabel.Name = "ulitsaLabel";
            ulitsaLabel.Size = new System.Drawing.Size(36, 13);
            ulitsaLabel.TabIndex = 14;
            ulitsaLabel.Text = "Ulitsa:";
            // 
            // ulitsaTextBox
            // 
            this.ulitsaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.postavshikBindingSource, "Ulitsa", true));
            this.ulitsaTextBox.Location = new System.Drawing.Point(785, 391);
            this.ulitsaTextBox.Name = "ulitsaTextBox";
            this.ulitsaTextBox.Size = new System.Drawing.Size(100, 20);
            this.ulitsaTextBox.TabIndex = 15;
            // 
            // gorodLabel
            // 
            gorodLabel.AutoSize = true;
            gorodLabel.Location = new System.Drawing.Point(681, 420);
            gorodLabel.Name = "gorodLabel";
            gorodLabel.Size = new System.Drawing.Size(39, 13);
            gorodLabel.TabIndex = 16;
            gorodLabel.Text = "Gorod:";
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 578);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(iD_postavshikaLabel);
            this.Controls.Add(this.iD_postavshikaTextBox);
            this.Controls.Add(name_postavshikaLabel);
            this.Controls.Add(this.name_postavshikaTextBox);
            this.Controls.Add(kontaktniy_nomerLabel);
            this.Controls.Add(this.kontaktniy_nomerTextBox);
            this.Controls.Add(kontaktnoe_litsoLabel);
            this.Controls.Add(this.kontaktnoe_litsoTextBox);
            this.Controls.Add(stranaLabel);
            this.Controls.Add(this.stranaTextBox);
            this.Controls.Add(domLabel);
            this.Controls.Add(this.domTextBox);
            this.Controls.Add(ulitsaLabel);
            this.Controls.Add(this.ulitsaTextBox);
            this.Controls.Add(gorodLabel);
            this.Controls.Add(this.gorodTextBox);
            this.Controls.Add(this.postavshikDataGridView);
            this.Controls.Add(this.postavshikBindingNavigator);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataBase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postavshikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postavshikBindingNavigator)).EndInit();
            this.postavshikBindingNavigator.ResumeLayout(false);
            this.postavshikBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.postavshikDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataBase dataBase;
        private System.Windows.Forms.BindingSource postavshikBindingSource;
        private DataBaseTableAdapters.PostavshikTableAdapter postavshikTableAdapter;
        private DataBaseTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator postavshikBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton postavshikBindingNavigatorSaveItem;
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
    }
}

