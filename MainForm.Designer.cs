
namespace Task0
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
            this.label1 = new System.Windows.Forms.Label();
            this.setTimeField = new System.Windows.Forms.TextBox();
            this.doBtn = new System.Windows.Forms.Button();
            this.units = new System.Windows.Forms.ComboBox();
            this.deltaTimeField = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.radioBtnForward = new System.Windows.Forms.RadioButton();
            this.radioBtnBack = new System.Windows.Forms.RadioButton();
            this.setTimeBtn = new System.Windows.Forms.Button();
            this.errorMessage1 = new System.Windows.Forms.Label();
            this.Watch = new System.Windows.Forms.PictureBox();
            this.errorMessage2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Watch)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(17, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Set time:";
            // 
            // setTimeField
            // 
            this.setTimeField.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.setTimeField.Location = new System.Drawing.Point(21, 51);
            this.setTimeField.Name = "setTimeField";
            this.setTimeField.Size = new System.Drawing.Size(155, 41);
            this.setTimeField.TabIndex = 1;
            this.setTimeField.Text = "00:00:00";
            // 
            // doBtn
            // 
            this.doBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.doBtn.Location = new System.Drawing.Point(21, 386);
            this.doBtn.Name = "doBtn";
            this.doBtn.Size = new System.Drawing.Size(97, 37);
            this.doBtn.TabIndex = 4;
            this.doBtn.Text = "Do";
            this.doBtn.UseVisualStyleBackColor = true;
            this.doBtn.Click += new System.EventHandler(this.DoBtn_Click);
            // 
            // units
            // 
            this.units.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.units.FormattingEnabled = true;
            this.units.Items.AddRange(new object[] {
            "seconds",
            "minutes",
            "hours"});
            this.units.Location = new System.Drawing.Point(116, 267);
            this.units.Name = "units";
            this.units.Size = new System.Drawing.Size(148, 37);
            this.units.TabIndex = 5;
            this.units.Text = "seconds";
            // 
            // deltaTimeField
            // 
            this.deltaTimeField.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deltaTimeField.Location = new System.Drawing.Point(22, 263);
            this.deltaTimeField.Name = "deltaTimeField";
            this.deltaTimeField.Size = new System.Drawing.Size(84, 41);
            this.deltaTimeField.TabIndex = 6;
            this.deltaTimeField.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(17, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(256, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Input value and choose unit:";
            // 
            // radioBtnForward
            // 
            this.radioBtnForward.AutoSize = true;
            this.radioBtnForward.Checked = true;
            this.radioBtnForward.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioBtnForward.Location = new System.Drawing.Point(22, 322);
            this.radioBtnForward.Name = "radioBtnForward";
            this.radioBtnForward.Size = new System.Drawing.Size(93, 28);
            this.radioBtnForward.TabIndex = 8;
            this.radioBtnForward.TabStop = true;
            this.radioBtnForward.Text = "forward";
            this.radioBtnForward.UseVisualStyleBackColor = true;
            // 
            // radioBtnBack
            // 
            this.radioBtnBack.AutoSize = true;
            this.radioBtnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioBtnBack.Location = new System.Drawing.Point(22, 351);
            this.radioBtnBack.Name = "radioBtnBack";
            this.radioBtnBack.Size = new System.Drawing.Size(71, 28);
            this.radioBtnBack.TabIndex = 9;
            this.radioBtnBack.TabStop = true;
            this.radioBtnBack.Text = "back";
            this.radioBtnBack.UseVisualStyleBackColor = true;
            // 
            // setTimeBtn
            // 
            this.setTimeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.setTimeBtn.Location = new System.Drawing.Point(21, 106);
            this.setTimeBtn.Name = "setTimeBtn";
            this.setTimeBtn.Size = new System.Drawing.Size(98, 37);
            this.setTimeBtn.TabIndex = 11;
            this.setTimeBtn.Text = "Set";
            this.setTimeBtn.UseVisualStyleBackColor = true;
            this.setTimeBtn.Click += new System.EventHandler(this.SetTimeBtn_Click);
            // 
            // errorMessage1
            // 
            this.errorMessage1.AutoSize = true;
            this.errorMessage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.errorMessage1.ForeColor = System.Drawing.Color.Red;
            this.errorMessage1.Location = new System.Drawing.Point(22, 152);
            this.errorMessage1.Name = "errorMessage1";
            this.errorMessage1.Size = new System.Drawing.Size(0, 20);
            this.errorMessage1.TabIndex = 12;
            // 
            // Watch
            // 
            this.Watch.BackgroundImage = global::Task0.Properties.Resources.watch;
            this.Watch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Watch.Location = new System.Drawing.Point(370, 50);
            this.Watch.Name = "Watch";
            this.Watch.Size = new System.Drawing.Size(380, 350);
            this.Watch.TabIndex = 13;
            this.Watch.TabStop = false;
            this.Watch.Paint += new System.Windows.Forms.PaintEventHandler(this.PaintArrows);
            // 
            // errorMessage2
            // 
            this.errorMessage2.AutoSize = true;
            this.errorMessage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.errorMessage2.ForeColor = System.Drawing.Color.Red;
            this.errorMessage2.Location = new System.Drawing.Point(22, 437);
            this.errorMessage2.Name = "errorMessage2";
            this.errorMessage2.Size = new System.Drawing.Size(0, 20);
            this.errorMessage2.TabIndex = 14;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 489);
            this.Controls.Add(this.errorMessage2);
            this.Controls.Add(this.Watch);
            this.Controls.Add(this.errorMessage1);
            this.Controls.Add(this.setTimeBtn);
            this.Controls.Add(this.radioBtnBack);
            this.Controls.Add(this.radioBtnForward);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.deltaTimeField);
            this.Controls.Add(this.units);
            this.Controls.Add(this.doBtn);
            this.Controls.Add(this.setTimeField);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Watch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox setTimeField;
        private System.Windows.Forms.Button doBtn;
        private System.Windows.Forms.ComboBox units;
        private System.Windows.Forms.TextBox deltaTimeField;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioBtnForward;
        private System.Windows.Forms.RadioButton radioBtnBack;
        private System.Windows.Forms.Button setTimeBtn;
        private System.Windows.Forms.Label errorMessage1;
        private System.Windows.Forms.PictureBox Watch;
        private System.Windows.Forms.Label errorMessage2;
    }
}

