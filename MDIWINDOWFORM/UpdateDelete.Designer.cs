namespace MDIWINDOWFORM
{
    partial class UpdateDelete
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
            Update = new Button();
            FullNametxt = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            Hinditxt = new CheckBox();
            Sanskrittxt = new CheckBox();
            Citytxt = new TextBox();
            Maletxt = new RadioButton();
            Femaletxt = new RadioButton();
            label5 = new Label();
            Delete = new Button();
            Back = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(115, 97);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 14;
            label1.Text = "Name";
            // 
            // Englishtxt
            // 
            Englishtxt.AutoSize = true;
            Englishtxt.Location = new Point(189, 174);
            Englishtxt.Name = "Englishtxt";
            Englishtxt.Size = new Size(64, 19);
            Englishtxt.TabIndex = 15;
            Englishtxt.Text = "English";
            Englishtxt.UseVisualStyleBackColor = true;
            // 
            // Update
            // 
            Update.Location = new Point(83, 297);
            Update.Name = "Update";
            Update.Size = new Size(99, 23);
            Update.TabIndex = 16;
            Update.Text = "Update Data";
            Update.UseVisualStyleBackColor = true;
            Update.Click += Update_Click;
            // 
            // FullNametxt
            // 
            FullNametxt.Location = new Point(160, 97);
            FullNametxt.Name = "FullNametxt";
            FullNametxt.Size = new Size(187, 23);
            FullNametxt.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(115, 135);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 18;
            label2.Text = "Gender";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(115, 174);
            label3.Name = "label3";
            label3.Size = new Size(59, 15);
            label3.TabIndex = 19;
            label3.Text = "Language";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(115, 231);
            label4.Name = "label4";
            label4.Size = new Size(28, 15);
            label4.TabIndex = 20;
            label4.Text = "City";
            // 
            // Hinditxt
            // 
            Hinditxt.AutoSize = true;
            Hinditxt.Location = new Point(259, 174);
            Hinditxt.Name = "Hinditxt";
            Hinditxt.Size = new Size(55, 19);
            Hinditxt.TabIndex = 21;
            Hinditxt.Text = "Hindi";
            Hinditxt.UseVisualStyleBackColor = true;
            // 
            // Sanskrittxt
            // 
            Sanskrittxt.AutoSize = true;
            Sanskrittxt.Location = new Point(328, 174);
            Sanskrittxt.Name = "Sanskrittxt";
            Sanskrittxt.Size = new Size(67, 19);
            Sanskrittxt.TabIndex = 22;
            Sanskrittxt.Text = "Sanskrit";
            Sanskrittxt.UseVisualStyleBackColor = true;
            // 
            // Citytxt
            // 
            Citytxt.Location = new Point(160, 228);
            Citytxt.Name = "Citytxt";
            Citytxt.Size = new Size(171, 23);
            Citytxt.TabIndex = 23;
            // 
            // Maletxt
            // 
            Maletxt.AutoSize = true;
            Maletxt.Location = new Point(176, 131);
            Maletxt.Name = "Maletxt";
            Maletxt.Size = new Size(51, 19);
            Maletxt.TabIndex = 24;
            Maletxt.TabStop = true;
            Maletxt.Text = "Male";
            Maletxt.UseVisualStyleBackColor = true;
            // 
            // Femaletxt
            // 
            Femaletxt.AutoSize = true;
            Femaletxt.Location = new Point(239, 131);
            Femaletxt.Name = "Femaletxt";
            Femaletxt.Size = new Size(63, 19);
            Femaletxt.TabIndex = 25;
            Femaletxt.TabStop = true;
            Femaletxt.Text = "Female";
            Femaletxt.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 30F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(83, 9);
            label5.Name = "label5";
            label5.Size = new Size(557, 46);
            label5.TabIndex = 27;
            label5.Text = "UPDATION & DELETION FORM";
            // 
            // Delete
            // 
            Delete.Location = new Point(207, 297);
            Delete.Name = "Delete";
            Delete.Size = new Size(75, 23);
            Delete.TabIndex = 28;
            Delete.Text = "Delete Data";
            Delete.UseVisualStyleBackColor = true;
            Delete.Click += Delete_Click;
            // 
            // Back
            // 
            Back.Location = new Point(320, 297);
            Back.Name = "Back";
            Back.Size = new Size(131, 23);
            Back.TabIndex = 29;
            Back.Text = "Back To  Main Form";
            Back.UseVisualStyleBackColor = true;
            Back.Click += Back_Click;
            // 
            // UpdateDelete
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Back);
            Controls.Add(Delete);
            Controls.Add(label5);
            Controls.Add(Femaletxt);
            Controls.Add(Maletxt);
            Controls.Add(Citytxt);
            Controls.Add(Sanskrittxt);
            Controls.Add(Hinditxt);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(FullNametxt);
            Controls.Add(Update);
            Controls.Add(Englishtxt);
            Controls.Add(label1);
            Name = "UpdateDelete";
            Text = "UpdateDelete";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private CheckBox Englishtxt;
        private Button Update;
        private TextBox FullNametxt;
        private Label label2;
        private Label label3;
        private Label label4;
        private CheckBox Hinditxt;
        private CheckBox Sanskrittxt;
        private TextBox Citytxt;
        private RadioButton Maletxt;
        private RadioButton Femaletxt;
        private Label label5;
        private Button Delete;
        private Button Back;
    }
}