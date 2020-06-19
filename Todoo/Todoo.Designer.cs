namespace Todoo
{
    partial class Todoo
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
            this.dtPicker = new System.Windows.Forms.DateTimePicker();
            this.btnAddNewTodoo = new System.Windows.Forms.Button();
            this.rtbTodoo = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // dtPicker
            // 
            this.dtPicker.CustomFormat = "dd/mm/yyyy hh/mm/ss";
            this.dtPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtPicker.Location = new System.Drawing.Point(12, 17);
            this.dtPicker.MinDate = new System.DateTime(1921, 1, 1, 0, 0, 0, 0);
            this.dtPicker.Name = "dtPicker";
            this.dtPicker.Size = new System.Drawing.Size(344, 26);
            this.dtPicker.TabIndex = 0;
            // 
            // btnAddNewTodoo
            // 
            this.btnAddNewTodoo.Location = new System.Drawing.Point(12, 401);
            this.btnAddNewTodoo.Name = "btnAddNewTodoo";
            this.btnAddNewTodoo.Size = new System.Drawing.Size(164, 37);
            this.btnAddNewTodoo.TabIndex = 1;
            this.btnAddNewTodoo.Text = "Hinzufügen";
            this.btnAddNewTodoo.UseVisualStyleBackColor = true;
            this.btnAddNewTodoo.Click += new System.EventHandler(this.btnAddNewTodoo_Click);
            // 
            // rtbTodoo
            // 
            this.rtbTodoo.Location = new System.Drawing.Point(12, 58);
            this.rtbTodoo.Name = "rtbTodoo";
            this.rtbTodoo.Size = new System.Drawing.Size(344, 329);
            this.rtbTodoo.TabIndex = 3;
            this.rtbTodoo.Text = "";
            // 
            // Todoo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 450);
            this.Controls.Add(this.rtbTodoo);
            this.Controls.Add(this.btnAddNewTodoo);
            this.Controls.Add(this.dtPicker);
            this.Name = "Todoo";
            this.Text = "Todoo";
            this.Load += new System.EventHandler(this.Todoo_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtPicker;
        private System.Windows.Forms.Button btnAddNewTodoo;
        private System.Windows.Forms.RichTextBox rtbTodoo;
    }
}

