namespace Circustrein
{
    partial class Form
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
            this.lbl_addAnimals = new System.Windows.Forms.Label();
            this.lb_selectedAnimals = new System.Windows.Forms.ListBox();
            this.combo_animalSize = new System.Windows.Forms.ComboBox();
            this.cb_iscarnivore = new System.Windows.Forms.CheckBox();
            this.lb_wagons = new System.Windows.Forms.ListBox();
            this.lbl_amount = new System.Windows.Forms.Label();
            this.btn_addAnimal = new System.Windows.Forms.Button();
            this.num_amount = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.num_amount)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_addAnimals
            // 
            this.lbl_addAnimals.AutoSize = true;
            this.lbl_addAnimals.Location = new System.Drawing.Point(13, 13);
            this.lbl_addAnimals.Name = "lbl_addAnimals";
            this.lbl_addAnimals.Size = new System.Drawing.Size(64, 13);
            this.lbl_addAnimals.TabIndex = 0;
            this.lbl_addAnimals.Text = "Add animals";
            // 
            // lb_selectedAnimals
            // 
            this.lb_selectedAnimals.FormattingEnabled = true;
            this.lb_selectedAnimals.Location = new System.Drawing.Point(16, 161);
            this.lb_selectedAnimals.Name = "lb_selectedAnimals";
            this.lb_selectedAnimals.Size = new System.Drawing.Size(182, 277);
            this.lb_selectedAnimals.TabIndex = 1;
            // 
            // combo_animalSize
            // 
            this.combo_animalSize.FormattingEnabled = true;
            this.combo_animalSize.Location = new System.Drawing.Point(12, 43);
            this.combo_animalSize.Name = "combo_animalSize";
            this.combo_animalSize.Size = new System.Drawing.Size(121, 21);
            this.combo_animalSize.TabIndex = 2;
            this.combo_animalSize.Text = "Select Size";
            // 
            // cb_iscarnivore
            // 
            this.cb_iscarnivore.AutoSize = true;
            this.cb_iscarnivore.Location = new System.Drawing.Point(12, 70);
            this.cb_iscarnivore.Name = "cb_iscarnivore";
            this.cb_iscarnivore.Size = new System.Drawing.Size(82, 17);
            this.cb_iscarnivore.TabIndex = 3;
            this.cb_iscarnivore.Text = "Is Carnivore";
            this.cb_iscarnivore.UseVisualStyleBackColor = true;
            // 
            // lb_wagons
            // 
            this.lb_wagons.FormattingEnabled = true;
            this.lb_wagons.Location = new System.Drawing.Point(259, 161);
            this.lb_wagons.Name = "lb_wagons";
            this.lb_wagons.Size = new System.Drawing.Size(210, 277);
            this.lb_wagons.TabIndex = 4;
            // 
            // lbl_amount
            // 
            this.lbl_amount.AutoSize = true;
            this.lbl_amount.Location = new System.Drawing.Point(9, 107);
            this.lbl_amount.Name = "lbl_amount";
            this.lbl_amount.Size = new System.Drawing.Size(46, 13);
            this.lbl_amount.TabIndex = 6;
            this.lbl_amount.Text = "Amount:";
            // 
            // btn_addAnimal
            // 
            this.btn_addAnimal.Location = new System.Drawing.Point(16, 132);
            this.btn_addAnimal.Name = "btn_addAnimal";
            this.btn_addAnimal.Size = new System.Drawing.Size(75, 23);
            this.btn_addAnimal.TabIndex = 7;
            this.btn_addAnimal.Text = "Add animals";
            this.btn_addAnimal.UseVisualStyleBackColor = true;
            this.btn_addAnimal.Click += new System.EventHandler(this.btn_addAnimal_Click);
            // 
            // num_amount
            // 
            this.num_amount.Location = new System.Drawing.Point(61, 105);
            this.num_amount.Name = "num_amount";
            this.num_amount.Size = new System.Drawing.Size(60, 20);
            this.num_amount.TabIndex = 8;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 450);
            this.Controls.Add(this.num_amount);
            this.Controls.Add(this.btn_addAnimal);
            this.Controls.Add(this.lbl_amount);
            this.Controls.Add(this.lb_wagons);
            this.Controls.Add(this.cb_iscarnivore);
            this.Controls.Add(this.combo_animalSize);
            this.Controls.Add(this.lb_selectedAnimals);
            this.Controls.Add(this.lbl_addAnimals);
            this.Name = "Form";
            this.Text = "Circustrein";
            ((System.ComponentModel.ISupportInitialize)(this.num_amount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_addAnimals;
        private System.Windows.Forms.ListBox lb_selectedAnimals;
        private System.Windows.Forms.ComboBox combo_animalSize;
        private System.Windows.Forms.CheckBox cb_iscarnivore;
        private System.Windows.Forms.ListBox lb_wagons;
        private System.Windows.Forms.Label lbl_amount;
        private System.Windows.Forms.Button btn_addAnimal;
        private System.Windows.Forms.NumericUpDown num_amount;
    }
}

