namespace BatExpert
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            Save = new Button();
            DeleteAll = new Button();
            Open = new Button();
            Run = new Button();
            panel1 = new Panel();
            Minimize = new Button();
            Close = new Button();
            label1 = new Label();
            Undo = new Button();
            Redo = new Button();
            HideRun = new Button();
            ((System.ComponentModel.ISupportInitialize)webView21).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // webView21
            // 
            webView21.AllowExternalDrop = true;
            webView21.CreationProperties = null;
            webView21.DefaultBackgroundColor = Color.White;
            webView21.Location = new Point(-2, 76);
            webView21.Name = "webView21";
            webView21.Size = new Size(799, 401);
            webView21.TabIndex = 0;
            webView21.ZoomFactor = 1D;
            // 
            // Save
            // 
            Save.FlatAppearance.BorderSize = 0;
            Save.FlatStyle = FlatStyle.Flat;
            Save.Image = Properties.Resources.save__1_;
            Save.Location = new Point(6, 42);
            Save.Name = "Save";
            Save.Size = new Size(28, 28);
            Save.TabIndex = 1;
            Save.UseVisualStyleBackColor = true;
            Save.Click += Save_Click;
            // 
            // DeleteAll
            // 
            DeleteAll.FlatAppearance.BorderSize = 0;
            DeleteAll.FlatStyle = FlatStyle.Flat;
            DeleteAll.Image = Properties.Resources.x__2_;
            DeleteAll.Location = new Point(769, 42);
            DeleteAll.Name = "DeleteAll";
            DeleteAll.Size = new Size(28, 28);
            DeleteAll.TabIndex = 2;
            DeleteAll.UseVisualStyleBackColor = true;
            DeleteAll.Click += DeleteAll_Click;
            // 
            // Open
            // 
            Open.FlatAppearance.BorderSize = 0;
            Open.FlatStyle = FlatStyle.Flat;
            Open.Image = Properties.Resources.paperclip__1_;
            Open.Location = new Point(40, 42);
            Open.Name = "Open";
            Open.Size = new Size(28, 28);
            Open.TabIndex = 3;
            Open.UseVisualStyleBackColor = true;
            Open.Click += Open_Click;
            // 
            // Run
            // 
            Run.FlatAppearance.BorderSize = 0;
            Run.FlatStyle = FlatStyle.Flat;
            Run.Image = Properties.Resources.play__4_;
            Run.Location = new Point(74, 42);
            Run.Name = "Run";
            Run.Size = new Size(28, 28);
            Run.TabIndex = 4;
            Run.UseVisualStyleBackColor = true;
            Run.Click += Run_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(Minimize);
            panel1.Controls.Add(Close);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-2, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(799, 35);
            panel1.TabIndex = 5;
            panel1.MouseDown += panel1_MouseDown;
            panel1.MouseMove += panel1_MouseDown;
            // 
            // Minimize
            // 
            Minimize.FlatAppearance.BorderSize = 0;
            Minimize.FlatStyle = FlatStyle.Flat;
            Minimize.Image = Properties.Resources.minus;
            Minimize.Location = new Point(737, 4);
            Minimize.Name = "Minimize";
            Minimize.Size = new Size(28, 28);
            Minimize.TabIndex = 7;
            Minimize.UseVisualStyleBackColor = true;
            Minimize.Click += Minimize_Click;
            // 
            // Close
            // 
            Close.FlatAppearance.BorderSize = 0;
            Close.FlatStyle = FlatStyle.Flat;
            Close.Image = Properties.Resources.x__1_;
            Close.Location = new Point(771, 2);
            Close.Name = "Close";
            Close.Size = new Size(28, 28);
            Close.TabIndex = 6;
            Close.UseVisualStyleBackColor = true;
            Close.Click += Close_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.White;
            label1.Location = new Point(3, 2);
            label1.Name = "label1";
            label1.Size = new Size(101, 30);
            label1.TabIndex = 6;
            label1.Text = "BatExpert";
            // 
            // Undo
            // 
            Undo.FlatAppearance.BorderSize = 0;
            Undo.FlatStyle = FlatStyle.Flat;
            Undo.Image = Properties.Resources.undo;
            Undo.Location = new Point(108, 46);
            Undo.Name = "Undo";
            Undo.Size = new Size(24, 24);
            Undo.TabIndex = 6;
            Undo.UseVisualStyleBackColor = true;
            Undo.Click += Undo_Click;
            // 
            // Redo
            // 
            Redo.FlatAppearance.BorderSize = 0;
            Redo.FlatStyle = FlatStyle.Flat;
            Redo.Image = Properties.Resources.redo;
            Redo.Location = new Point(138, 46);
            Redo.Name = "Redo";
            Redo.Size = new Size(24, 24);
            Redo.TabIndex = 7;
            Redo.UseVisualStyleBackColor = true;
            Redo.Click += Redo_Click;
            // 
            // HideRun
            // 
            HideRun.FlatAppearance.BorderSize = 0;
            HideRun.FlatStyle = FlatStyle.Flat;
            HideRun.Image = Properties.Resources.eye_closed__1_;
            HideRun.Location = new Point(735, 42);
            HideRun.Name = "HideRun";
            HideRun.Size = new Size(28, 28);
            HideRun.TabIndex = 8;
            HideRun.UseVisualStyleBackColor = true;
            HideRun.Click += HideRun_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(25, 25, 25);
            ClientSize = new Size(800, 475);
            Controls.Add(HideRun);
            Controls.Add(Redo);
            Controls.Add(Undo);
            Controls.Add(panel1);
            Controls.Add(Run);
            Controls.Add(Open);
            Controls.Add(DeleteAll);
            Controls.Add(Save);
            Controls.Add(webView21);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)webView21).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
        private Button Save;
        private Button DeleteAll;
        private Button Open;
        private Button Run;
        private Panel panel1;
        private Label label1;
        private Button Close;
        private Button Undo;
        private Button Redo;
        private Button Minimize;
        private Button HideRun;
    }


}
