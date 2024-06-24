namespace NatGlassCutOptimiser
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
            panel1 = new Panel();
            optimise = new Button();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Location = new Point(6, 44);
            panel1.Name = "panel1";
            panel1.Size = new Size(979, 604);
            panel1.TabIndex = 0;
            // 
            // optimise
            // 
            optimise.Location = new Point(6, 12);
            optimise.Name = "optimise";
            optimise.Size = new Size(75, 23);
            optimise.TabIndex = 1;
            optimise.Text = "Start Cut";
            optimise.UseVisualStyleBackColor = true;
            optimise.Click += optimise_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(997, 660);
            Controls.Add(optimise);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button optimise;
    }
}
