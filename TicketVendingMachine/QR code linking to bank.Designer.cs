namespace TicketVendingMachine
{
    partial class QR_code_linking_to_bank
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
            this.bFinish = new System.Windows.Forms.Button();
            this.tPrice = new System.Windows.Forms.TextBox();
            this.tSelection = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tCodeBank = new System.Windows.Forms.TextBox();
            this.cbBank = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // bFinish
            // 
            this.bFinish.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bFinish.Location = new System.Drawing.Point(687, 247);
            this.bFinish.Name = "bFinish";
            this.bFinish.Size = new System.Drawing.Size(88, 31);
            this.bFinish.TabIndex = 11;
            this.bFinish.Text = "Finish";
            this.bFinish.UseVisualStyleBackColor = true;
            this.bFinish.Click += new System.EventHandler(this.bFinish_Click);
            // 
            // tPrice
            // 
            this.tPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tPrice.Location = new System.Drawing.Point(243, 83);
            this.tPrice.Name = "tPrice";
            this.tPrice.Size = new System.Drawing.Size(532, 31);
            this.tPrice.TabIndex = 10;
            // 
            // tSelection
            // 
            this.tSelection.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tSelection.Location = new System.Drawing.Point(243, 37);
            this.tSelection.Name = "tSelection";
            this.tSelection.Size = new System.Drawing.Size(532, 31);
            this.tSelection.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(232, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Please input your bank";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Price";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Your selection is";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(5, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(232, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "Please input your code";
            // 
            // tCodeBank
            // 
            this.tCodeBank.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tCodeBank.Location = new System.Drawing.Point(243, 201);
            this.tCodeBank.Name = "tCodeBank";
            this.tCodeBank.Size = new System.Drawing.Size(532, 31);
            this.tCodeBank.TabIndex = 14;
            // 
            // cbBank
            // 
            this.cbBank.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBank.FormattingEnabled = true;
            this.cbBank.Location = new System.Drawing.Point(243, 141);
            this.cbBank.Name = "cbBank";
            this.cbBank.Size = new System.Drawing.Size(532, 33);
            this.cbBank.TabIndex = 15;
            // 
            // QR_code_linking_to_bank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 290);
            this.Controls.Add(this.cbBank);
            this.Controls.Add(this.tCodeBank);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bFinish);
            this.Controls.Add(this.tPrice);
            this.Controls.Add(this.tSelection);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "QR_code_linking_to_bank";
            this.Text = "QR code linking to bank";
            this.Load += new System.EventHandler(this.QR_code_linking_to_bank_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bFinish;
        private System.Windows.Forms.TextBox tPrice;
        private System.Windows.Forms.TextBox tSelection;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tCodeBank;
        private System.Windows.Forms.ComboBox cbBank;
    }
}