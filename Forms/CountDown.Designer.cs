namespace Gamify__Quizzlett_Application.Forms
{
    partial class CountDown
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
            components = new System.ComponentModel.Container();
            time_lbl = new Label();
            timer = new System.Windows.Forms.Timer(components);
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // time_lbl
            // 
            time_lbl.Anchor = AnchorStyles.None;
            time_lbl.Font = new Font("Architects Daughter", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            time_lbl.ForeColor = SystemColors.ButtonHighlight;
            time_lbl.Location = new Point(355, 178);
            time_lbl.Name = "time_lbl";
            time_lbl.Size = new Size(803, 466);
            time_lbl.TabIndex = 0;
            time_lbl.Text = "1";
            time_lbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // timer
            // 
            timer.Tick += timer_Tick;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.Font = new Font("Architects Daughter", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(382, 169);
            label1.Name = "label1";
            label1.Size = new Size(803, 466);
            label1.TabIndex = 1;
            label1.Text = "1";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.Font = new Font("Architects Daughter", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(381, 169);
            label2.Name = "label2";
            label2.Size = new Size(803, 466);
            label2.TabIndex = 2;
            label2.Text = "1";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Architects Daughter", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(684, 145);
            label3.Name = "label3";
            label3.Size = new Size(202, 33);
            label3.TabIndex = 3;
            label3.Text = "Get Ready...... in";
            // 
            // CountDown
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(12, 10, 9);
            ClientSize = new Size(1564, 804);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(time_lbl);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CountDown";
            Text = "CountDown";
            Load += CountDown_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label time_lbl;
        private System.Windows.Forms.Timer timer;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}