namespace DieticNutritionApp.Forms
{
    partial class AddIngTypeForm
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
            this.rbIndependentType = new System.Windows.Forms.RadioButton();
            this.rbCookingDepType = new System.Windows.Forms.RadioButton();
            this.rbTempDepType = new System.Windows.Forms.RadioButton();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbAdditional = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbCookingType = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rbIndependentType
            // 
            this.rbIndependentType.AutoSize = true;
            this.rbIndependentType.Location = new System.Drawing.Point(15, 12);
            this.rbIndependentType.Name = "rbIndependentType";
            this.rbIndependentType.Size = new System.Drawing.Size(139, 21);
            this.rbIndependentType.TabIndex = 0;
            this.rbIndependentType.TabStop = true;
            this.rbIndependentType.Text = "Independent type";
            this.rbIndependentType.UseVisualStyleBackColor = true;
            // 
            // rbCookingDepType
            // 
            this.rbCookingDepType.AutoSize = true;
            this.rbCookingDepType.Location = new System.Drawing.Point(15, 39);
            this.rbCookingDepType.Name = "rbCookingDepType";
            this.rbCookingDepType.Size = new System.Drawing.Size(183, 21);
            this.rbCookingDepType.TabIndex = 1;
            this.rbCookingDepType.TabStop = true;
            this.rbCookingDepType.Text = "Cooking dependent type";
            this.rbCookingDepType.UseVisualStyleBackColor = true;
            // 
            // rbTempDepType
            // 
            this.rbTempDepType.AutoSize = true;
            this.rbTempDepType.Location = new System.Drawing.Point(15, 66);
            this.rbTempDepType.Name = "rbTempDepType";
            this.rbTempDepType.Size = new System.Drawing.Size(203, 21);
            this.rbTempDepType.TabIndex = 2;
            this.rbTempDepType.TabStop = true;
            this.rbTempDepType.Text = "Teperature dependent type";
            this.rbTempDepType.UseVisualStyleBackColor = true;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(120, 126);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(100, 22);
            this.tbName.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Additional";
            // 
            // tbAdditional
            // 
            this.tbAdditional.Location = new System.Drawing.Point(120, 154);
            this.tbAdditional.Name = "tbAdditional";
            this.tbAdditional.Size = new System.Drawing.Size(100, 22);
            this.tbAdditional.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Cooking type";
            // 
            // tbCookingType
            // 
            this.tbCookingType.Location = new System.Drawing.Point(120, 183);
            this.tbCookingType.Name = "tbCookingType";
            this.tbCookingType.Size = new System.Drawing.Size(100, 22);
            this.tbCookingType.TabIndex = 7;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(79, 218);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 16;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // AddIngTypeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(232, 253);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbCookingType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbAdditional);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.rbTempDepType);
            this.Controls.Add(this.rbCookingDepType);
            this.Controls.Add(this.rbIndependentType);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(250, 300);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(250, 300);
            this.Name = "AddIngTypeForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Add Ingredient Type";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbIndependentType;
        private System.Windows.Forms.RadioButton rbCookingDepType;
        private System.Windows.Forms.RadioButton rbTempDepType;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbAdditional;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbCookingType;
        private System.Windows.Forms.Button btnOk;
    }
}