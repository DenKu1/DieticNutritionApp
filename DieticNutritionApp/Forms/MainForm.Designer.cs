namespace DieticNutritionApp.Forms
{
    partial class MainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtLoadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xmlLoadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jsonLoadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtSaveToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.xmlSaveToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.jsonSaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.recipes = new System.Windows.Forms.TabPage();
            this.btnDeleteRec = new System.Windows.Forms.Button();
            this.btnEditRec = new System.Windows.Forms.Button();
            this.btnAddRec = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.recipesGrid = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wIngredients = new System.Windows.Forms.TabPage();
            this.btnDeleteWIng = new System.Windows.Forms.Button();
            this.btnEditWIng = new System.Windows.Forms.Button();
            this.btnAddWIng = new System.Windows.Forms.Button();
            this.wIngsGrid = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ingredients = new System.Windows.Forms.TabPage();
            this.btnDeleteIng = new System.Windows.Forms.Button();
            this.btnEditIng = new System.Windows.Forms.Button();
            this.btnAddIng = new System.Windows.Forms.Button();
            this.ingredientsGrid = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intTypes = new System.Windows.Forms.TabPage();
            this.btnDeleteIngType = new System.Windows.Forms.Button();
            this.btnEditIngType = new System.Windows.Forms.Button();
            this.btnAddIngType = new System.Windows.Forms.Button();
            this.ingTypesGrid = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.recipes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.recipesGrid)).BeginInit();
            this.wIngredients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wIngsGrid)).BeginInit();
            this.ingredients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ingredientsGrid)).BeginInit();
            this.intTypes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ingTypesGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.loadToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(788, 28);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutProgramToolStripMenuItem,
            this.restartToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // aboutProgramToolStripMenuItem
            // 
            this.aboutProgramToolStripMenuItem.Name = "aboutProgramToolStripMenuItem";
            this.aboutProgramToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.aboutProgramToolStripMenuItem.Text = "About program";
            this.aboutProgramToolStripMenuItem.Click += new System.EventHandler(this.aboutProgramToolStripMenuItem_Click);
            // 
            // restartToolStripMenuItem
            // 
            this.restartToolStripMenuItem.Name = "restartToolStripMenuItem";
            this.restartToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.restartToolStripMenuItem.Text = "Restart";
            this.restartToolStripMenuItem.Click += new System.EventHandler(this.restartToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtLoadToolStripMenuItem,
            this.xmlLoadToolStripMenuItem,
            this.jsonLoadToolStripMenuItem});
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(54, 24);
            this.loadToolStripMenuItem.Text = "Load";
            // 
            // txtLoadToolStripMenuItem
            // 
            this.txtLoadToolStripMenuItem.Name = "txtLoadToolStripMenuItem";
            this.txtLoadToolStripMenuItem.Size = new System.Drawing.Size(111, 26);
            this.txtLoadToolStripMenuItem.Text = "txt";
            this.txtLoadToolStripMenuItem.Click += new System.EventHandler(this.txtLoadToolStripMenuItem_Click);
            // 
            // xmlLoadToolStripMenuItem
            // 
            this.xmlLoadToolStripMenuItem.Name = "xmlLoadToolStripMenuItem";
            this.xmlLoadToolStripMenuItem.Size = new System.Drawing.Size(111, 26);
            this.xmlLoadToolStripMenuItem.Text = "xml";
            this.xmlLoadToolStripMenuItem.Click += new System.EventHandler(this.xmlLoadToolStripMenuItem_Click);
            // 
            // jsonLoadToolStripMenuItem
            // 
            this.jsonLoadToolStripMenuItem.Name = "jsonLoadToolStripMenuItem";
            this.jsonLoadToolStripMenuItem.Size = new System.Drawing.Size(111, 26);
            this.jsonLoadToolStripMenuItem.Text = "json";
            this.jsonLoadToolStripMenuItem.Click += new System.EventHandler(this.jsonLoadToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtSaveToolStripMenuItem1,
            this.xmlSaveToolStripMenuItem1,
            this.jsonSaveToolStripMenuItem});
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(52, 24);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // txtSaveToolStripMenuItem1
            // 
            this.txtSaveToolStripMenuItem1.Name = "txtSaveToolStripMenuItem1";
            this.txtSaveToolStripMenuItem1.Size = new System.Drawing.Size(111, 26);
            this.txtSaveToolStripMenuItem1.Text = "txt";
            this.txtSaveToolStripMenuItem1.Click += new System.EventHandler(this.txtSaveToolStripMenuItem1_Click);
            // 
            // xmlSaveToolStripMenuItem1
            // 
            this.xmlSaveToolStripMenuItem1.Name = "xmlSaveToolStripMenuItem1";
            this.xmlSaveToolStripMenuItem1.Size = new System.Drawing.Size(111, 26);
            this.xmlSaveToolStripMenuItem1.Text = "xml";
            this.xmlSaveToolStripMenuItem1.Click += new System.EventHandler(this.xmlSaveToolStripMenuItem1_Click);
            // 
            // jsonSaveToolStripMenuItem
            // 
            this.jsonSaveToolStripMenuItem.Name = "jsonSaveToolStripMenuItem";
            this.jsonSaveToolStripMenuItem.Size = new System.Drawing.Size(111, 26);
            this.jsonSaveToolStripMenuItem.Text = "json";
            this.jsonSaveToolStripMenuItem.Click += new System.EventHandler(this.jsonSaveToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.recipes);
            this.tabControl1.Controls.Add(this.wIngredients);
            this.tabControl1.Controls.Add(this.ingredients);
            this.tabControl1.Controls.Add(this.intTypes);
            this.tabControl1.Location = new System.Drawing.Point(12, 31);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(764, 602);
            this.tabControl1.TabIndex = 6;
            // 
            // recipes
            // 
            this.recipes.BackColor = System.Drawing.Color.Gainsboro;
            this.recipes.Controls.Add(this.btnDeleteRec);
            this.recipes.Controls.Add(this.btnEditRec);
            this.recipes.Controls.Add(this.btnAddRec);
            this.recipes.Controls.Add(this.btnCalculate);
            this.recipes.Controls.Add(this.recipesGrid);
            this.recipes.Location = new System.Drawing.Point(4, 25);
            this.recipes.Name = "recipes";
            this.recipes.Padding = new System.Windows.Forms.Padding(3);
            this.recipes.Size = new System.Drawing.Size(756, 573);
            this.recipes.TabIndex = 0;
            this.recipes.Text = "Recipes";
            // 
            // btnDeleteRec
            // 
            this.btnDeleteRec.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeleteRec.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteRec.Location = new System.Drawing.Point(216, 517);
            this.btnDeleteRec.Name = "btnDeleteRec";
            this.btnDeleteRec.Size = new System.Drawing.Size(100, 50);
            this.btnDeleteRec.TabIndex = 29;
            this.btnDeleteRec.Text = "Delete";
            this.btnDeleteRec.UseVisualStyleBackColor = true;
            this.btnDeleteRec.Click += new System.EventHandler(this.btnDeleteRec_Click);
            // 
            // btnEditRec
            // 
            this.btnEditRec.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditRec.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditRec.Location = new System.Drawing.Point(110, 517);
            this.btnEditRec.Name = "btnEditRec";
            this.btnEditRec.Size = new System.Drawing.Size(100, 50);
            this.btnEditRec.TabIndex = 28;
            this.btnEditRec.Text = "Edit";
            this.btnEditRec.UseVisualStyleBackColor = true;
            this.btnEditRec.Click += new System.EventHandler(this.btnEditRec_Click);
            // 
            // btnAddRec
            // 
            this.btnAddRec.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddRec.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddRec.Location = new System.Drawing.Point(4, 517);
            this.btnAddRec.Name = "btnAddRec";
            this.btnAddRec.Size = new System.Drawing.Size(100, 50);
            this.btnAddRec.TabIndex = 27;
            this.btnAddRec.Text = "Add";
            this.btnAddRec.UseVisualStyleBackColor = true;
            this.btnAddRec.Click += new System.EventHandler(this.btnAddRec_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(512, 517);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(240, 50);
            this.btnCalculate.TabIndex = 26;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // recipesGrid
            // 
            this.recipesGrid.AllowUserToAddRows = false;
            this.recipesGrid.AllowUserToDeleteRows = false;
            this.recipesGrid.AllowUserToResizeColumns = false;
            this.recipesGrid.AllowUserToResizeRows = false;
            this.recipesGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.recipesGrid.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.recipesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.recipesGrid.ColumnHeadersVisible = false;
            this.recipesGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column1});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.recipesGrid.DefaultCellStyle = dataGridViewCellStyle1;
            this.recipesGrid.Location = new System.Drawing.Point(4, 4);
            this.recipesGrid.Margin = new System.Windows.Forms.Padding(4);
            this.recipesGrid.MultiSelect = false;
            this.recipesGrid.Name = "recipesGrid";
            this.recipesGrid.ReadOnly = true;
            this.recipesGrid.RowHeadersVisible = false;
            this.recipesGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.recipesGrid.Size = new System.Drawing.Size(748, 506);
            this.recipesGrid.TabIndex = 25;
            this.recipesGrid.TabStop = false;
            this.recipesGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.recipesGrid_CellClick);
            // 
            // Column2
            // 
            this.Column2.HeaderText = "gridCheckBox";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "text";
            this.Column1.MinimumWidth = 166;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // wIngredients
            // 
            this.wIngredients.BackColor = System.Drawing.Color.Gainsboro;
            this.wIngredients.Controls.Add(this.btnDeleteWIng);
            this.wIngredients.Controls.Add(this.btnEditWIng);
            this.wIngredients.Controls.Add(this.btnAddWIng);
            this.wIngredients.Controls.Add(this.wIngsGrid);
            this.wIngredients.Location = new System.Drawing.Point(4, 25);
            this.wIngredients.Name = "wIngredients";
            this.wIngredients.Padding = new System.Windows.Forms.Padding(3);
            this.wIngredients.Size = new System.Drawing.Size(756, 573);
            this.wIngredients.TabIndex = 2;
            this.wIngredients.Text = "Weighted Ings";
            // 
            // btnDeleteWIng
            // 
            this.btnDeleteWIng.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeleteWIng.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteWIng.Location = new System.Drawing.Point(216, 518);
            this.btnDeleteWIng.Name = "btnDeleteWIng";
            this.btnDeleteWIng.Size = new System.Drawing.Size(100, 50);
            this.btnDeleteWIng.TabIndex = 36;
            this.btnDeleteWIng.Text = "Delete";
            this.btnDeleteWIng.UseVisualStyleBackColor = true;
            this.btnDeleteWIng.Click += new System.EventHandler(this.btnDeleteWIng_Click);
            // 
            // btnEditWIng
            // 
            this.btnEditWIng.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditWIng.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditWIng.Location = new System.Drawing.Point(110, 518);
            this.btnEditWIng.Name = "btnEditWIng";
            this.btnEditWIng.Size = new System.Drawing.Size(100, 50);
            this.btnEditWIng.TabIndex = 35;
            this.btnEditWIng.Text = "Edit";
            this.btnEditWIng.UseVisualStyleBackColor = true;
            this.btnEditWIng.Click += new System.EventHandler(this.btnEditWIng_Click);
            // 
            // btnAddWIng
            // 
            this.btnAddWIng.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddWIng.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddWIng.Location = new System.Drawing.Point(4, 518);
            this.btnAddWIng.Name = "btnAddWIng";
            this.btnAddWIng.Size = new System.Drawing.Size(100, 50);
            this.btnAddWIng.TabIndex = 34;
            this.btnAddWIng.Text = "Add";
            this.btnAddWIng.UseVisualStyleBackColor = true;
            this.btnAddWIng.Click += new System.EventHandler(this.btnAddWIng_Click);
            // 
            // wIngsGrid
            // 
            this.wIngsGrid.AllowUserToAddRows = false;
            this.wIngsGrid.AllowUserToDeleteRows = false;
            this.wIngsGrid.AllowUserToResizeColumns = false;
            this.wIngsGrid.AllowUserToResizeRows = false;
            this.wIngsGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.wIngsGrid.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.wIngsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.wIngsGrid.ColumnHeadersVisible = false;
            this.wIngsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.wIngsGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.wIngsGrid.Location = new System.Drawing.Point(4, 5);
            this.wIngsGrid.Margin = new System.Windows.Forms.Padding(4);
            this.wIngsGrid.MultiSelect = false;
            this.wIngsGrid.Name = "wIngsGrid";
            this.wIngsGrid.ReadOnly = true;
            this.wIngsGrid.RowHeadersVisible = false;
            this.wIngsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.wIngsGrid.Size = new System.Drawing.Size(748, 506);
            this.wIngsGrid.TabIndex = 33;
            this.wIngsGrid.TabStop = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.HeaderText = "text";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 166;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ingredients
            // 
            this.ingredients.BackColor = System.Drawing.Color.Gainsboro;
            this.ingredients.Controls.Add(this.btnDeleteIng);
            this.ingredients.Controls.Add(this.btnEditIng);
            this.ingredients.Controls.Add(this.btnAddIng);
            this.ingredients.Controls.Add(this.ingredientsGrid);
            this.ingredients.Location = new System.Drawing.Point(4, 25);
            this.ingredients.Name = "ingredients";
            this.ingredients.Padding = new System.Windows.Forms.Padding(3);
            this.ingredients.Size = new System.Drawing.Size(756, 573);
            this.ingredients.TabIndex = 1;
            this.ingredients.Text = "Ingredients";
            // 
            // btnDeleteIng
            // 
            this.btnDeleteIng.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeleteIng.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteIng.Location = new System.Drawing.Point(216, 517);
            this.btnDeleteIng.Name = "btnDeleteIng";
            this.btnDeleteIng.Size = new System.Drawing.Size(100, 50);
            this.btnDeleteIng.TabIndex = 32;
            this.btnDeleteIng.Text = "Delete";
            this.btnDeleteIng.UseVisualStyleBackColor = true;
            this.btnDeleteIng.Click += new System.EventHandler(this.btnDeleteIng_Click);
            // 
            // btnEditIng
            // 
            this.btnEditIng.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditIng.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditIng.Location = new System.Drawing.Point(110, 517);
            this.btnEditIng.Name = "btnEditIng";
            this.btnEditIng.Size = new System.Drawing.Size(100, 50);
            this.btnEditIng.TabIndex = 31;
            this.btnEditIng.Text = "Edit";
            this.btnEditIng.UseVisualStyleBackColor = true;
            this.btnEditIng.Click += new System.EventHandler(this.btnEditIng_Click);
            // 
            // btnAddIng
            // 
            this.btnAddIng.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddIng.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddIng.Location = new System.Drawing.Point(4, 517);
            this.btnAddIng.Name = "btnAddIng";
            this.btnAddIng.Size = new System.Drawing.Size(100, 50);
            this.btnAddIng.TabIndex = 30;
            this.btnAddIng.Text = "Add";
            this.btnAddIng.UseVisualStyleBackColor = true;
            this.btnAddIng.Click += new System.EventHandler(this.btnAddIng_Click);
            // 
            // ingredientsGrid
            // 
            this.ingredientsGrid.AllowUserToAddRows = false;
            this.ingredientsGrid.AllowUserToDeleteRows = false;
            this.ingredientsGrid.AllowUserToResizeColumns = false;
            this.ingredientsGrid.AllowUserToResizeRows = false;
            this.ingredientsGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.ingredientsGrid.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.ingredientsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ingredientsGrid.ColumnHeadersVisible = false;
            this.ingredientsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ingredientsGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.ingredientsGrid.Location = new System.Drawing.Point(4, 4);
            this.ingredientsGrid.Margin = new System.Windows.Forms.Padding(4);
            this.ingredientsGrid.MultiSelect = false;
            this.ingredientsGrid.Name = "ingredientsGrid";
            this.ingredientsGrid.ReadOnly = true;
            this.ingredientsGrid.RowHeadersVisible = false;
            this.ingredientsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ingredientsGrid.Size = new System.Drawing.Size(748, 506);
            this.ingredientsGrid.TabIndex = 26;
            this.ingredientsGrid.TabStop = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.HeaderText = "text";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 166;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // intTypes
            // 
            this.intTypes.BackColor = System.Drawing.Color.Gainsboro;
            this.intTypes.Controls.Add(this.btnDeleteIngType);
            this.intTypes.Controls.Add(this.btnEditIngType);
            this.intTypes.Controls.Add(this.btnAddIngType);
            this.intTypes.Controls.Add(this.ingTypesGrid);
            this.intTypes.Location = new System.Drawing.Point(4, 25);
            this.intTypes.Name = "intTypes";
            this.intTypes.Padding = new System.Windows.Forms.Padding(3);
            this.intTypes.Size = new System.Drawing.Size(756, 573);
            this.intTypes.TabIndex = 3;
            this.intTypes.Text = "Ingredient types";
            // 
            // btnDeleteIngType
            // 
            this.btnDeleteIngType.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeleteIngType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteIngType.Location = new System.Drawing.Point(216, 518);
            this.btnDeleteIngType.Name = "btnDeleteIngType";
            this.btnDeleteIngType.Size = new System.Drawing.Size(100, 50);
            this.btnDeleteIngType.TabIndex = 36;
            this.btnDeleteIngType.Text = "Delete";
            this.btnDeleteIngType.UseVisualStyleBackColor = true;
            this.btnDeleteIngType.Click += new System.EventHandler(this.btnDeleteIngType_Click);
            // 
            // btnEditIngType
            // 
            this.btnEditIngType.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditIngType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditIngType.Location = new System.Drawing.Point(110, 518);
            this.btnEditIngType.Name = "btnEditIngType";
            this.btnEditIngType.Size = new System.Drawing.Size(100, 50);
            this.btnEditIngType.TabIndex = 35;
            this.btnEditIngType.Text = "Edit";
            this.btnEditIngType.UseVisualStyleBackColor = true;
            this.btnEditIngType.Click += new System.EventHandler(this.btnEditIngType_Click);
            // 
            // btnAddIngType
            // 
            this.btnAddIngType.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddIngType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddIngType.Location = new System.Drawing.Point(4, 518);
            this.btnAddIngType.Name = "btnAddIngType";
            this.btnAddIngType.Size = new System.Drawing.Size(100, 50);
            this.btnAddIngType.TabIndex = 34;
            this.btnAddIngType.Text = "Add";
            this.btnAddIngType.UseVisualStyleBackColor = true;
            this.btnAddIngType.Click += new System.EventHandler(this.btnAddIngType_Click);
            // 
            // ingTypesGrid
            // 
            this.ingTypesGrid.AllowUserToAddRows = false;
            this.ingTypesGrid.AllowUserToDeleteRows = false;
            this.ingTypesGrid.AllowUserToResizeColumns = false;
            this.ingTypesGrid.AllowUserToResizeRows = false;
            this.ingTypesGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.ingTypesGrid.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.ingTypesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ingTypesGrid.ColumnHeadersVisible = false;
            this.ingTypesGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ingTypesGrid.DefaultCellStyle = dataGridViewCellStyle4;
            this.ingTypesGrid.Location = new System.Drawing.Point(4, 5);
            this.ingTypesGrid.Margin = new System.Windows.Forms.Padding(4);
            this.ingTypesGrid.MultiSelect = false;
            this.ingTypesGrid.Name = "ingTypesGrid";
            this.ingTypesGrid.ReadOnly = true;
            this.ingTypesGrid.RowHeadersVisible = false;
            this.ingTypesGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ingTypesGrid.Size = new System.Drawing.Size(748, 506);
            this.ingTypesGrid.TabIndex = 33;
            this.ingTypesGrid.TabStop = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.HeaderText = "text";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 166;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 645);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Dietic Nutrition App";
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.recipes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.recipesGrid)).EndInit();
            this.wIngredients.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.wIngsGrid)).EndInit();
            this.ingredients.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ingredientsGrid)).EndInit();
            this.intTypes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ingTypesGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutProgramToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage recipes;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.DataGridView recipesGrid;
        private System.Windows.Forms.TabPage ingredients;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridView ingredientsGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem txtLoadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xmlLoadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jsonLoadToolStripMenuItem;
        private System.Windows.Forms.Button btnDeleteRec;
        private System.Windows.Forms.Button btnEditRec;
        private System.Windows.Forms.Button btnAddRec;
        private System.Windows.Forms.Button btnDeleteIng;
        private System.Windows.Forms.Button btnEditIng;
        private System.Windows.Forms.Button btnAddIng;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem txtSaveToolStripMenuItem1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem xmlSaveToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem jsonSaveToolStripMenuItem;
        private System.Windows.Forms.TabPage wIngredients;
        private System.Windows.Forms.Button btnDeleteWIng;
        private System.Windows.Forms.Button btnEditWIng;
        private System.Windows.Forms.Button btnAddWIng;
        private System.Windows.Forms.DataGridView wIngsGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.TabPage intTypes;
        private System.Windows.Forms.Button btnDeleteIngType;
        private System.Windows.Forms.Button btnEditIngType;
        private System.Windows.Forms.Button btnAddIngType;
        private System.Windows.Forms.DataGridView ingTypesGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}

