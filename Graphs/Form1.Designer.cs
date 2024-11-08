namespace Graphs
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
            btn_AddDataPoint = new Button();
            lbl_Instructions = new Label();
            txt_DataPoint = new TextBox();
            SuspendLayout();
            // 
            // btn_AddDataPoint
            // 
            btn_AddDataPoint.Location = new Point(208, 184);
            btn_AddDataPoint.Name = "btn_AddDataPoint";
            btn_AddDataPoint.Size = new Size(94, 29);
            btn_AddDataPoint.TabIndex = 0;
            btn_AddDataPoint.Text = "Add Data";
            btn_AddDataPoint.UseVisualStyleBackColor = true;
            btn_AddDataPoint.Click += btn_AddDataPoint_Click;
            // 
            // lbl_Instructions
            // 
            lbl_Instructions.AutoSize = true;
            lbl_Instructions.Location = new Point(123, 31);
            lbl_Instructions.Name = "lbl_Instructions";
            lbl_Instructions.Size = new Size(253, 20);
            lbl_Instructions.TabIndex = 1;
            lbl_Instructions.Text = "\"Enter a number to add to the chart\".";
            // 
            // txt_DataPoint
            // 
            txt_DataPoint.Location = new Point(192, 250);
            txt_DataPoint.Name = "txt_DataPoint";
            txt_DataPoint.Size = new Size(125, 27);
            txt_DataPoint.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(493, 450);
            Controls.Add(txt_DataPoint);
            Controls.Add(lbl_Instructions);
            Controls.Add(btn_AddDataPoint);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_AddDataPoint;
        private Label lbl_Instructions;
        private TextBox txt_DataPoint;
    }
}
