
namespace WATCHOUT_DESKTOP
{
    partial class FormInv
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInv));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.Invoice1 = new WATCHOUT_DESKTOP.Invoice();
            this.buttonBackInvoicee = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.DisplayStatusBar = false;
            this.crystalReportViewer1.DisplayToolbar = false;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.ReportSource = this.Invoice1;
            this.crystalReportViewer1.Size = new System.Drawing.Size(800, 450);
            this.crystalReportViewer1.TabIndex = 0;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.crystalReportViewer1.Load += new System.EventHandler(this.crystalReportViewer1_Load);
            // 
            // buttonBackInvoicee
            // 
            this.buttonBackInvoicee.AllowAnimations = true;
            this.buttonBackInvoicee.AllowMouseEffects = true;
            this.buttonBackInvoicee.AllowToggling = false;
            this.buttonBackInvoicee.AnimationSpeed = 200;
            this.buttonBackInvoicee.AutoGenerateColors = false;
            this.buttonBackInvoicee.AutoRoundBorders = false;
            this.buttonBackInvoicee.AutoSizeLeftIcon = true;
            this.buttonBackInvoicee.AutoSizeRightIcon = true;
            this.buttonBackInvoicee.BackColor = System.Drawing.Color.Transparent;
            this.buttonBackInvoicee.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.buttonBackInvoicee.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonBackInvoicee.BackgroundImage")));
            this.buttonBackInvoicee.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.buttonBackInvoicee.ButtonText = "Back";
            this.buttonBackInvoicee.ButtonTextMarginLeft = 0;
            this.buttonBackInvoicee.ColorContrastOnClick = 45;
            this.buttonBackInvoicee.ColorContrastOnHover = 45;
            this.buttonBackInvoicee.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.buttonBackInvoicee.CustomizableEdges = borderEdges1;
            this.buttonBackInvoicee.DialogResult = System.Windows.Forms.DialogResult.None;
            this.buttonBackInvoicee.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.buttonBackInvoicee.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.buttonBackInvoicee.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.buttonBackInvoicee.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.buttonBackInvoicee.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonBackInvoicee.ForeColor = System.Drawing.Color.White;
            this.buttonBackInvoicee.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonBackInvoicee.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.buttonBackInvoicee.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.buttonBackInvoicee.IconMarginLeft = 11;
            this.buttonBackInvoicee.IconPadding = 10;
            this.buttonBackInvoicee.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonBackInvoicee.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.buttonBackInvoicee.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.buttonBackInvoicee.IconSize = 25;
            this.buttonBackInvoicee.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.buttonBackInvoicee.IdleBorderRadius = 1;
            this.buttonBackInvoicee.IdleBorderThickness = 1;
            this.buttonBackInvoicee.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.buttonBackInvoicee.IdleIconLeftImage = null;
            this.buttonBackInvoicee.IdleIconRightImage = null;
            this.buttonBackInvoicee.IndicateFocus = false;
            this.buttonBackInvoicee.Location = new System.Drawing.Point(103, 0);
            this.buttonBackInvoicee.Name = "buttonBackInvoicee";
            this.buttonBackInvoicee.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.buttonBackInvoicee.OnDisabledState.BorderRadius = 1;
            this.buttonBackInvoicee.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.buttonBackInvoicee.OnDisabledState.BorderThickness = 1;
            this.buttonBackInvoicee.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.buttonBackInvoicee.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.buttonBackInvoicee.OnDisabledState.IconLeftImage = null;
            this.buttonBackInvoicee.OnDisabledState.IconRightImage = null;
            this.buttonBackInvoicee.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.buttonBackInvoicee.onHoverState.BorderRadius = 1;
            this.buttonBackInvoicee.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.buttonBackInvoicee.onHoverState.BorderThickness = 1;
            this.buttonBackInvoicee.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.buttonBackInvoicee.onHoverState.ForeColor = System.Drawing.Color.White;
            this.buttonBackInvoicee.onHoverState.IconLeftImage = null;
            this.buttonBackInvoicee.onHoverState.IconRightImage = null;
            this.buttonBackInvoicee.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.buttonBackInvoicee.OnIdleState.BorderRadius = 1;
            this.buttonBackInvoicee.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.buttonBackInvoicee.OnIdleState.BorderThickness = 1;
            this.buttonBackInvoicee.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.buttonBackInvoicee.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.buttonBackInvoicee.OnIdleState.IconLeftImage = null;
            this.buttonBackInvoicee.OnIdleState.IconRightImage = null;
            this.buttonBackInvoicee.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.buttonBackInvoicee.OnPressedState.BorderRadius = 1;
            this.buttonBackInvoicee.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.buttonBackInvoicee.OnPressedState.BorderThickness = 1;
            this.buttonBackInvoicee.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.buttonBackInvoicee.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.buttonBackInvoicee.OnPressedState.IconLeftImage = null;
            this.buttonBackInvoicee.OnPressedState.IconRightImage = null;
            this.buttonBackInvoicee.Size = new System.Drawing.Size(144, 32);
            this.buttonBackInvoicee.TabIndex = 1;
            this.buttonBackInvoicee.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonBackInvoicee.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.buttonBackInvoicee.TextMarginLeft = 0;
            this.buttonBackInvoicee.TextPadding = new System.Windows.Forms.Padding(0);
            this.buttonBackInvoicee.UseDefaultRadiusAndThickness = true;
            this.buttonBackInvoicee.Click += new System.EventHandler(this.buttonBackInvoicee_Click);
            // 
            // FormInv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonBackInvoicee);
            this.Controls.Add(this.crystalReportViewer1);
            this.Name = "FormInv";
            this.Text = "FormInv";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private Invoice Invoice1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton buttonBackInvoicee;
    }
}