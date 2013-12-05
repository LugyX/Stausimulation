namespace Designer
{
    partial class FieldType
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
            this.btnCreate = new System.Windows.Forms.Button();
            this.cBoxNorden = new System.Windows.Forms.CheckBox();
            this.cBoxOsten = new System.Windows.Forms.CheckBox();
            this.cBoxSüden = new System.Windows.Forms.CheckBox();
            this.cBoxWesten = new System.Windows.Forms.CheckBox();
            this.txtNorden = new System.Windows.Forms.TextBox();
            this.txtOsten = new System.Windows.Forms.TextBox();
            this.txtSüden = new System.Windows.Forms.TextBox();
            this.txtWesten = new System.Windows.Forms.TextBox();
            this.combField = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnCreate
            // 
            this.btnCreate.Enabled = false;
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.Location = new System.Drawing.Point(13, 148);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 0;
            this.btnCreate.Text = "Erstellen";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // cBoxNorden
            // 
            this.cBoxNorden.AutoSize = true;
            this.cBoxNorden.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBoxNorden.Location = new System.Drawing.Point(13, 13);
            this.cBoxNorden.Name = "cBoxNorden";
            this.cBoxNorden.Size = new System.Drawing.Size(72, 20);
            this.cBoxNorden.TabIndex = 1;
            this.cBoxNorden.Text = "Norden";
            this.cBoxNorden.UseVisualStyleBackColor = true;
            this.cBoxNorden.CheckedChanged += new System.EventHandler(this.cBoxNorden_CheckedChanged);
            // 
            // cBoxOsten
            // 
            this.cBoxOsten.AutoSize = true;
            this.cBoxOsten.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBoxOsten.Location = new System.Drawing.Point(13, 39);
            this.cBoxOsten.Name = "cBoxOsten";
            this.cBoxOsten.Size = new System.Drawing.Size(62, 20);
            this.cBoxOsten.TabIndex = 2;
            this.cBoxOsten.Text = "Osten";
            this.cBoxOsten.UseVisualStyleBackColor = true;
            this.cBoxOsten.CheckedChanged += new System.EventHandler(this.cBoxOsten_CheckedChanged);
            // 
            // cBoxSüden
            // 
            this.cBoxSüden.AutoSize = true;
            this.cBoxSüden.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBoxSüden.Location = new System.Drawing.Point(13, 65);
            this.cBoxSüden.Name = "cBoxSüden";
            this.cBoxSüden.Size = new System.Drawing.Size(66, 20);
            this.cBoxSüden.TabIndex = 3;
            this.cBoxSüden.Text = "Süden";
            this.cBoxSüden.UseVisualStyleBackColor = true;
            this.cBoxSüden.CheckedChanged += new System.EventHandler(this.cBoxSüden_CheckedChanged);
            // 
            // cBoxWesten
            // 
            this.cBoxWesten.AutoSize = true;
            this.cBoxWesten.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBoxWesten.Location = new System.Drawing.Point(13, 91);
            this.cBoxWesten.Name = "cBoxWesten";
            this.cBoxWesten.Size = new System.Drawing.Size(73, 20);
            this.cBoxWesten.TabIndex = 4;
            this.cBoxWesten.Text = "Westen";
            this.cBoxWesten.UseVisualStyleBackColor = true;
            this.cBoxWesten.CheckedChanged += new System.EventHandler(this.cBoxWesten_CheckedChanged);
            // 
            // txtNorden
            // 
            this.txtNorden.Enabled = false;
            this.txtNorden.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNorden.Location = new System.Drawing.Point(92, 11);
            this.txtNorden.Name = "txtNorden";
            this.txtNorden.Size = new System.Drawing.Size(86, 22);
            this.txtNorden.TabIndex = 5;
            // 
            // txtOsten
            // 
            this.txtOsten.Enabled = false;
            this.txtOsten.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOsten.Location = new System.Drawing.Point(92, 37);
            this.txtOsten.Name = "txtOsten";
            this.txtOsten.Size = new System.Drawing.Size(86, 22);
            this.txtOsten.TabIndex = 6;
            // 
            // txtSüden
            // 
            this.txtSüden.Enabled = false;
            this.txtSüden.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSüden.Location = new System.Drawing.Point(92, 63);
            this.txtSüden.Name = "txtSüden";
            this.txtSüden.Size = new System.Drawing.Size(86, 22);
            this.txtSüden.TabIndex = 7;
            // 
            // txtWesten
            // 
            this.txtWesten.Enabled = false;
            this.txtWesten.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWesten.Location = new System.Drawing.Point(92, 89);
            this.txtWesten.Name = "txtWesten";
            this.txtWesten.Size = new System.Drawing.Size(86, 22);
            this.txtWesten.TabIndex = 8;
            // 
            // combField
            // 
            this.combField.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combField.FormattingEnabled = true;
            this.combField.Items.AddRange(new object[] {
            "Spawnfeld",
            "Unterscheidungsfeld",
            "Despawnfeld"});
            this.combField.Location = new System.Drawing.Point(13, 118);
            this.combField.Name = "combField";
            this.combField.Size = new System.Drawing.Size(165, 24);
            this.combField.TabIndex = 9;
            this.combField.Text = "Unterscheidungsfeld";
            // 
            // FieldType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(192, 180);
            this.Controls.Add(this.combField);
            this.Controls.Add(this.txtWesten);
            this.Controls.Add(this.txtSüden);
            this.Controls.Add(this.txtOsten);
            this.Controls.Add(this.txtNorden);
            this.Controls.Add(this.cBoxWesten);
            this.Controls.Add(this.cBoxSüden);
            this.Controls.Add(this.cBoxOsten);
            this.Controls.Add(this.cBoxNorden);
            this.Controls.Add(this.btnCreate);
            this.Name = "FieldType";
            this.Text = "FieldType";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.CheckBox cBoxNorden;
        private System.Windows.Forms.CheckBox cBoxOsten;
        private System.Windows.Forms.CheckBox cBoxSüden;
        private System.Windows.Forms.CheckBox cBoxWesten;
        private System.Windows.Forms.TextBox txtNorden;
        private System.Windows.Forms.TextBox txtOsten;
        private System.Windows.Forms.TextBox txtSüden;
        private System.Windows.Forms.TextBox txtWesten;
        private System.Windows.Forms.ComboBox combField;
    }
}