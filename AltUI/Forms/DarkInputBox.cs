using AltUI.Config;
using AltUI.Icons;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace AltUI.Forms
{
    public partial class DarkInputBox : DarkDialog
    {
        #region Field Region

        private string _message;
        private Controls.DarkLabel lblText;
        private Controls.DarkTextBox inputTextBox;
        private int _maximumWidth = 350;

        #endregion

        #region Property Region

        [Description("Determines the maximum width of the message box when it autosizes around the displayed message.")]
        [DefaultValue(350)]
        public int MaximumWidth
        {
            get { return _maximumWidth; }
            set
            {
                _maximumWidth = value;
                CalculateSize();
            }
        }

        #endregion

        #region Constructor Region

        public DarkInputBox()
        {
            InitializeComponent();
        }
        public DarkInputBox(string message, string title, DarkDialogButton buttons)
    : this()
        {
            Text = title;
            _message = message;
            DialogButtons = buttons;
        }

        #endregion

        #region Static Method Region


        public static string ShowDialog(string message, string caption, bool passwordBox = false, DarkDialogButton buttons = DarkDialogButton.OkCancel)
        {
            using (var dlg = new DarkInputBox(message, caption, buttons))
            {
                dlg.inputTextBox.Location = new Point(13, dlg.Height - dlg.inputTextBox.Height - 65);
                dlg.inputTextBox.Width = dlg.Width - 30;
                if(passwordBox)
                    dlg.inputTextBox.PasswordChar = '•';
                dlg.lblText.Location = new Point(10, 10);
                dlg.ShowDialog();
                return dlg.inputTextBox.Text;
            }
        }

        #endregion

        #region Method Region

        private void CalculateSize()
        {
            var width = 260; var height = 124;

            // Reset form back to original size
            Size = new Size(width, height);

            lblText.Text = string.Empty;
            lblText.AutoSize = true;
            lblText.Text = _message;

            // Set the minimum dialog size to whichever is bigger - the original size or the buttons.
            var minWidth = Math.Max(width, TotalButtonSize + 15);

            // Calculate the total size of the message
            var totalWidth = lblText.Right + 25;

            // Make sure we're not making the dialog bigger than the maximum size
            if (totalWidth < _maximumWidth)
            {
                // Width is smaller than the maximum width.
                // This means we can have a single-line message box.
                // Move the label to accomodate this.
                width = totalWidth;
            }
            else
            {
                // Width is larger than the maximum width.
                // Change the label size and wrap it.
                width = _maximumWidth;
                lblText.AutoUpdateHeight = true;
                lblText.Width = width - lblText.Left - 25;
                height = lblText.Height;
            }

            // Force the width to the minimum width
            if (width < minWidth)
                width = minWidth;

            // Set the new size of the dialog
            Size = new Size(width, height);
        }

        #endregion

        #region Event Handler Region

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            CalculateSize();
        }


        protected override void OnHandleCreated(EventArgs e)
        {
            ThemeProvider.SetupWindow(Handle, 2);
            if (ThemeProvider.TransparencyMode & ThemeProvider.WindowsVersion >= 22000)
            {
                TransparencyKey = BackColor;
                AllowTransparency = true;
            }
        }

        #endregion

        private void InitializeComponent()
        {
            lblText = new Controls.DarkLabel();
            inputTextBox = new Controls.DarkTextBox();
            SuspendLayout();
            // 
            // DarkInputBox
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            ClientSize = new Size(244, 86);
            Controls.Add(inputTextBox);
            Controls.Add(lblText);
            Name = "DarkInputBox";
            StartPosition = FormStartPosition.CenterScreen;
            ShowIcon = false;
            ShowInTaskbar = false;
            MinimizeBox = false;
            MaximizeBox = false;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Controls.SetChildIndex(lblText, 0);
            Controls.SetChildIndex(inputTextBox, 0);
            ResumeLayout(false);
            PerformLayout();

        }
    }
}
