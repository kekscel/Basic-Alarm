
namespace AlarmApp
{
    partial class AlarmForm
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.buttonstart = new System.Windows.Forms.Button();
            this.buttonstop = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker1.Location = new System.Drawing.Point(105, 35);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(125, 22);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // buttonstart
            // 
            this.buttonstart.Location = new System.Drawing.Point(63, 109);
            this.buttonstart.Name = "buttonstart";
            this.buttonstart.Size = new System.Drawing.Size(100, 50);
            this.buttonstart.TabIndex = 1;
            this.buttonstart.Text = "Start";
            this.buttonstart.UseVisualStyleBackColor = true;
            this.buttonstart.Click += new System.EventHandler(this.buttonstart_Click);
            // 
            // buttonstop
            // 
            this.buttonstop.Location = new System.Drawing.Point(169, 109);
            this.buttonstop.Name = "buttonstop";
            this.buttonstop.Size = new System.Drawing.Size(100, 50);
            this.buttonstop.TabIndex = 2;
            this.buttonstop.Text = "Stop";
            this.buttonstop.UseVisualStyleBackColor = true;
            this.buttonstop.Click += new System.EventHandler(this.buttonstop_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(128, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Alarm";
            // 
            // AlarmForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 203);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonstop);
            this.Controls.Add(this.buttonstart);
            this.Controls.Add(this.dateTimePicker1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AlarmForm";
            this.Text = "Alarm";
            this.Load += new System.EventHandler(this.AlarmForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button buttonstart;
        private System.Windows.Forms.Button buttonstop;
        private System.Windows.Forms.Label label1;
    }
}

