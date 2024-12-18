namespace Gamify__Quizzlett_Application.Forms
{
    partial class Modify_Quiz_form
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
            return_btn = new Button();
            Add_btn = new Button();
            card_panel = new Panel();
            statusStrip1 = new StatusStrip();
            toolStrip_status = new ToolStripStatusLabel();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // return_btn
            // 
            return_btn.BackgroundImage = Properties.Resources.log_in__5_;
            return_btn.BackgroundImageLayout = ImageLayout.Center;
            return_btn.FlatStyle = FlatStyle.Popup;
            return_btn.Location = new Point(10, 9);
            return_btn.Margin = new Padding(3, 2, 3, 2);
            return_btn.Name = "return_btn";
            return_btn.Size = new Size(34, 30);
            return_btn.TabIndex = 1;
            return_btn.UseVisualStyleBackColor = true;
            return_btn.Click += return_btn_Click;
            // 
            // Add_btn
            // 
            Add_btn.FlatStyle = FlatStyle.Flat;
            Add_btn.Font = new Font("Architects Daughter", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Add_btn.ForeColor = SystemColors.ButtonHighlight;
            Add_btn.Location = new Point(51, 476);
            Add_btn.Margin = new Padding(3, 2, 3, 2);
            Add_btn.Name = "Add_btn";
            Add_btn.Size = new Size(108, 41);
            Add_btn.TabIndex = 3;
            Add_btn.Text = "Add";
            Add_btn.UseVisualStyleBackColor = true;
            Add_btn.Click += Add_btn_Click;
            // 
            // card_panel
            // 
            card_panel.Location = new Point(165, 20);
            card_panel.Margin = new Padding(3, 2, 3, 2);
            card_panel.Name = "card_panel";
            card_panel.Size = new Size(1054, 497);
            card_panel.TabIndex = 4;
            // 
            // statusStrip1
            // 
            statusStrip1.BackColor = Color.FromArgb(30, 41, 59);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStrip_status });
            statusStrip1.Location = new Point(0, 556);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1329, 22);
            statusStrip1.TabIndex = 5;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStrip_status
            // 
            toolStrip_status.BackColor = Color.FromArgb(226, 232, 240);
            toolStrip_status.Name = "toolStrip_status";
            toolStrip_status.Size = new Size(224, 17);
            toolStrip_status.Text = "Hover on diffrent elements to view status";
            // 
            // Modify_Quiz_form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(9, 9, 11);
            ClientSize = new Size(1329, 578);
            Controls.Add(statusStrip1);
            Controls.Add(card_panel);
            Controls.Add(Add_btn);
            Controls.Add(return_btn);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Modify_Quiz_form";
            Text = "Modify Quiz";
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button return_btn;
        private Button Add_btn;
        private Panel card_panel;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStrip_status;
    }
}