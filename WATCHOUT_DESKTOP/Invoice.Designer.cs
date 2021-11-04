namespace WATCHOUT_DESKTOP
{
    partial class FormInvoice
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
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.crystalReportViewer2 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.CrystalReportInvoice1 = new WATCHOUT_DESKTOP.CrystalReportInvoice();
            this.CrystalReportInvoice2 = new WATCHOUT_DESKTOP.CrystalReportInvoice();
            this.buttonBackInv = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.DisplayStatusBar = false;
            this.crystalReportViewer1.DisplayToolbar = false;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(999, 613);
            this.crystalReportViewer1.TabIndex = 0;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // crystalReportViewer2
            // 
            this.crystalReportViewer2.ActiveViewIndex = 0;
            this.crystalReportViewer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer2.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer2.DisplayStatusBar = false;
            this.crystalReportViewer2.DisplayToolbar = false;
            this.crystalReportViewer2.Location = new System.Drawing.Point(230, 0);
            this.crystalReportViewer2.Name = "crystalReportViewer2";
            this.crystalReportViewer2.ReportSource = this.CrystalReportInvoice1;
            this.crystalReportViewer2.Size = new System.Drawing.Size(769, 613);
            this.crystalReportViewer2.TabIndex = 1;
            this.crystalReportViewer2.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // buttonBackInv
            // 
            this.buttonBackInv.Location = new System.Drawing.Point(29, 32);
            this.buttonBackInv.Name = "buttonBackInv";
            this.buttonBackInv.Size = new System.Drawing.Size(170, 73);
            this.buttonBackInv.TabIndex = 2;
            this.buttonBackInv.Text = "Back";
            this.buttonBackInv.UseVisualStyleBackColor = true;
            this.buttonBackInv.Click += new System.EventHandler(this.buttonBackInv_Click);
            // 
            // FormInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 613);
            this.Controls.Add(this.buttonBackInv);
            this.Controls.Add(this.crystalReportViewer2);
            this.Controls.Add(this.crystalReportViewer1);
            this.Name = "FormInvoice";
            this.Text = "Invoice";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer2;
        private CrystalReportInvoice CrystalReportInvoice1;
        private CrystalReportInvoice CrystalReportInvoice2;
        private System.Windows.Forms.Button buttonBackInv;
    }
}