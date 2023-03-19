namespace TicketVendingMachine
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rbCre = new System.Windows.Forms.RadioButton();
            this.rbQR = new System.Windows.Forms.RadioButton();
            this.rbDW = new System.Windows.Forms.RadioButton();
            this.cbDestination = new System.Windows.Forms.ComboBox();
            this.bStart = new System.Windows.Forms.Button();
            this.bFinish = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(361, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to Ticket Vending machine";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Select mode payment";
            // 
            // rbCre
            // 
            this.rbCre.AutoSize = true;
            this.rbCre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCre.Location = new System.Drawing.Point(226, 67);
            this.rbCre.Name = "rbCre";
            this.rbCre.Size = new System.Drawing.Size(104, 24);
            this.rbCre.TabIndex = 2;
            this.rbCre.TabStop = true;
            this.rbCre.Text = "Credit card";
            this.rbCre.UseVisualStyleBackColor = true;
            this.rbCre.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rbQR
            // 
            this.rbQR.AutoSize = true;
            this.rbQR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbQR.Location = new System.Drawing.Point(336, 67);
            this.rbQR.Name = "rbQR";
            this.rbQR.Size = new System.Drawing.Size(195, 24);
            this.rbQR.TabIndex = 3;
            this.rbQR.TabStop = true;
            this.rbQR.Text = "QR code linking to bank";
            this.rbQR.UseVisualStyleBackColor = true;
            this.rbQR.CheckedChanged += new System.EventHandler(this.rbQR_CheckedChanged);
            // 
            // rbDW
            // 
            this.rbDW.AutoSize = true;
            this.rbDW.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDW.Location = new System.Drawing.Point(537, 67);
            this.rbDW.Name = "rbDW";
            this.rbDW.Size = new System.Drawing.Size(119, 24);
            this.rbDW.TabIndex = 4;
            this.rbDW.TabStop = true;
            this.rbDW.Text = "Digital Wallet";
            this.rbDW.UseVisualStyleBackColor = true;
            this.rbDW.CheckedChanged += new System.EventHandler(this.rbDW_CheckedChanged);
            // 
            // cbDestination
            // 
            this.cbDestination.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDestination.FormattingEnabled = true;
            this.cbDestination.Location = new System.Drawing.Point(17, 147);
            this.cbDestination.Name = "cbDestination";
            this.cbDestination.Size = new System.Drawing.Size(630, 28);
            this.cbDestination.TabIndex = 5;
            this.cbDestination.Text = "Select a destination";
            this.cbDestination.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // bStart
            // 
            this.bStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bStart.Location = new System.Drawing.Point(17, 102);
            this.bStart.Name = "bStart";
            this.bStart.Size = new System.Drawing.Size(79, 25);
            this.bStart.TabIndex = 6;
            this.bStart.Text = "Start";
            this.bStart.UseVisualStyleBackColor = true;
            this.bStart.Click += new System.EventHandler(this.bStart_Click);
            // 
            // bFinish
            // 
            this.bFinish.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bFinish.Location = new System.Drawing.Point(563, 195);
            this.bFinish.Name = "bFinish";
            this.bFinish.Size = new System.Drawing.Size(84, 32);
            this.bFinish.TabIndex = 7;
            this.bFinish.Text = "Finish";
            this.bFinish.UseVisualStyleBackColor = true;
            this.bFinish.Click += new System.EventHandler(this.bFinish_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(397, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Date";
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(447, 102);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(200, 20);
            this.date.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 250);
            this.Controls.Add(this.date);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bFinish);
            this.Controls.Add(this.bStart);
            this.Controls.Add(this.cbDestination);
            this.Controls.Add(this.rbDW);
            this.Controls.Add(this.rbQR);
            this.Controls.Add(this.rbCre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Ticket Vending Machine";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbCre;
        private System.Windows.Forms.RadioButton rbQR;
        private System.Windows.Forms.RadioButton rbDW;
        private System.Windows.Forms.ComboBox cbDestination;
        private System.Windows.Forms.Button bStart;
        private System.Windows.Forms.Button bFinish;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker date;
    }
}

