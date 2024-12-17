namespace Gamify__Quizzlett_Application.Custom_Controls
{
    partial class Floating_Navigation
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menu_btn = new Button();
            create_btn = new Button();
            SuspendLayout();
            // 
            // menu_btn
            // 
            menu_btn.Location = new Point(210, 4);
            menu_btn.Name = "menu_btn";
            menu_btn.Size = new Size(94, 29);
            menu_btn.TabIndex = 0;
            menu_btn.Text = "Home";
            menu_btn.UseVisualStyleBackColor = true;
            menu_btn.Click += menu_btn_Click;
            // 
            // create_btn
            // 
            create_btn.Location = new Point(310, 3);
            create_btn.Name = "create_btn";
            create_btn.Size = new Size(94, 29);
            create_btn.TabIndex = 1;
            create_btn.Text = "Create";
            create_btn.UseVisualStyleBackColor = true;
          
            // 
            // Floating_Navigation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(create_btn);
            Controls.Add(menu_btn);
            Cursor = Cursors.Hand;
            Name = "Floating_Navigation";
            Size = new Size(649, 36);
            ResumeLayout(false);
        }

        #endregion

        private Button menu_btn;
        private Button create_btn;
    }
}
