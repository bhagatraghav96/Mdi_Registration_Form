namespace MDIWINDOWFORM
{
    partial class Form3
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
            label1 = new Label();
            Englishtxt = new CheckBox();
            Submit = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            Hinditxt = new CheckBox();
            Sanskrittxt = new CheckBox();
            FullNametxt = new TextBox();
            Citytxt = new TextBox();
            Maletxt = new RadioButton();
            Femaletxt = new RadioButton();
            dataGridView1 = new DataGridView();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 95);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // Englishtxt
            // 
            Englishtxt.AutoSize = true;
            Englishtxt.Location = new Point(298, 133);
            Englishtxt.Name = "Englishtxt";
            Englishtxt.Size = new Size(64, 19);
            Englishtxt.TabIndex = 1;
            Englishtxt.Text = "English";
            Englishtxt.UseVisualStyleBackColor = true;
            // 
            // Submit
            // 
            Submit.Location = new Point(368, 168);
            Submit.Name = "Submit";
            Submit.Size = new Size(143, 23);
            Submit.TabIndex = 2;
            Submit.Text = "Submit To Database";
            Submit.UseVisualStyleBackColor = true;
            Submit.Click += Submit_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 133);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 4;
            label2.Text = "Gender";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(233, 133);
            label3.Name = "label3";
            label3.Size = new Size(59, 15);
            label3.TabIndex = 5;
            label3.Text = "Language";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(264, 103);
            label4.Name = "label4";
            label4.Size = new Size(28, 15);
            label4.TabIndex = 6;
            label4.Text = "City";
            // 
            // Hinditxt
            // 
            Hinditxt.AutoSize = true;
            Hinditxt.Location = new Point(368, 133);
            Hinditxt.Name = "Hinditxt";
            Hinditxt.Size = new Size(55, 19);
            Hinditxt.TabIndex = 7;
            Hinditxt.Text = "Hindi";
            Hinditxt.UseVisualStyleBackColor = true;
            // 
            // Sanskrittxt
            // 
            Sanskrittxt.AutoSize = true;
            Sanskrittxt.Location = new Point(438, 133);
            Sanskrittxt.Name = "Sanskrittxt";
            Sanskrittxt.Size = new Size(67, 19);
            Sanskrittxt.TabIndex = 8;
            Sanskrittxt.Text = "Sanskrit";
            Sanskrittxt.UseVisualStyleBackColor = true;
            // 
            // FullNametxt
            // 
            FullNametxt.Location = new Point(57, 95);
            FullNametxt.Name = "FullNametxt";
            FullNametxt.Size = new Size(187, 23);
            FullNametxt.TabIndex = 3;
            // 
            // Citytxt
            // 
            Citytxt.Location = new Point(313, 97);
            Citytxt.Name = "Citytxt";
            Citytxt.Size = new Size(171, 23);
            Citytxt.TabIndex = 9;
            // 
            // Maletxt
            // 
            Maletxt.AutoSize = true;
            Maletxt.Location = new Point(73, 129);
            Maletxt.Name = "Maletxt";
            Maletxt.Size = new Size(51, 19);
            Maletxt.TabIndex = 10;
            Maletxt.TabStop = true;
            Maletxt.Text = "Male";
            Maletxt.UseVisualStyleBackColor = true;
            // 
            // Femaletxt
            // 
            Femaletxt.AutoSize = true;
            Femaletxt.Location = new Point(136, 129);
            Femaletxt.Name = "Femaletxt";
            Femaletxt.Size = new Size(63, 19);
            Femaletxt.TabIndex = 11;
            Femaletxt.TabStop = true;
            Femaletxt.Text = "Female";
            Femaletxt.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridView1.Location = new Point(12, 197);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(571, 241);
            dataGridView1.TabIndex = 12;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 30F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(57, 9);
            label5.Name = "label5";
            label5.Size = new Size(427, 46);
            label5.TabIndex = 13;
            label5.Text = "REGISTRATION FORM";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(594, 450);
            Controls.Add(label5);
            Controls.Add(dataGridView1);
            Controls.Add(Femaletxt);
            Controls.Add(Maletxt);
            Controls.Add(Citytxt);
            Controls.Add(Sanskrittxt);
            Controls.Add(Hinditxt);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(FullNametxt);
            Controls.Add(Submit);
            Controls.Add(Englishtxt);
            Controls.Add(label1);
            Name = "Form3";
            Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private CheckBox Englishtxt;
        private Button Submit;
        private Label label2;
        private Label label3;
        private Label label4;
        private CheckBox Hinditxt;
        private CheckBox Sanskrittxt;
        private TextBox FullNametxt;
        private TextBox Citytxt;
        private RadioButton Maletxt;
        private RadioButton Femaletxt;
        private DataGridView dataGridView1;
        private Label label5;
    }
}