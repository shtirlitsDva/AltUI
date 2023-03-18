using System;
using AltUI.Controls;

namespace  AltUI.ColorPicker
{
  partial class ColorPickerDialog
  { /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
            this.okButton = new AltUI.Controls.DarkButton();
            this.cancelButton = new AltUI.Controls.DarkButton();
            this.previewPanel = new System.Windows.Forms.Panel();
            this.loadPaletteButton = new AltUI.Controls.DarkButton();
            this.savePaletteButton = new AltUI.Controls.DarkButton();
            this.toolTip = new AltUI.Controls.DarkToolTip();
            this.screenColorPicker = new AltUI.ColorPicker.ScreenColorPicker();
            this.colorWheel = new AltUI.ColorPicker.ColorWheel();
            this.colorEditor = new AltUI.ColorPicker.ColorEditor();
            this.colorGrid = new AltUI.ColorPicker.ColorGrid();
            this.colorEditorManager = new AltUI.ColorPicker.ColorEditorManager();
            this.SuspendLayout();
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.BorderColour = System.Drawing.Color.Empty;
            this.okButton.CustomColour = false;
            this.okButton.FlatBottom = false;
            this.okButton.FlatTop = false;
            this.okButton.Location = new System.Drawing.Point(501, 12);
            this.okButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.okButton.Name = "okButton";
            this.okButton.Padding = new System.Windows.Forms.Padding(6);
            this.okButton.Size = new System.Drawing.Size(88, 27);
            this.okButton.TabIndex = 1;
            this.okButton.Text = "OK";
            this.okButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.BorderColour = System.Drawing.Color.Empty;
            this.cancelButton.CustomColour = false;
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.FlatBottom = false;
            this.cancelButton.FlatTop = false;
            this.cancelButton.Location = new System.Drawing.Point(501, 45);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Padding = new System.Windows.Forms.Padding(6);
            this.cancelButton.Size = new System.Drawing.Size(88, 27);
            this.cancelButton.TabIndex = 2;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // previewPanel
            // 
            this.previewPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.previewPanel.Location = new System.Drawing.Point(501, 218);
            this.previewPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.previewPanel.Name = "previewPanel";
            this.previewPanel.Size = new System.Drawing.Size(88, 54);
            this.previewPanel.TabIndex = 3;
            this.previewPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.PreviewPanel_Paint);
            // 
            // loadPaletteButton
            // 
            this.loadPaletteButton.BorderColour = System.Drawing.Color.Empty;
            this.loadPaletteButton.CustomColour = false;
            this.loadPaletteButton.FlatBottom = false;
            this.loadPaletteButton.FlatTop = false;
            this.loadPaletteButton.Location = new System.Drawing.Point(13, 167);
            this.loadPaletteButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.loadPaletteButton.Name = "loadPaletteButton";
            this.loadPaletteButton.Padding = new System.Windows.Forms.Padding(6);
            this.loadPaletteButton.Size = new System.Drawing.Size(27, 27);
            this.loadPaletteButton.TabIndex = 5;
            this.toolTip.SetToolTip(this.loadPaletteButton, "Load Palette");
            this.loadPaletteButton.Click += new System.EventHandler(this.LoadPaletteButton_Click);
            // 
            // savePaletteButton
            // 
            this.savePaletteButton.BorderColour = System.Drawing.Color.Empty;
            this.savePaletteButton.CustomColour = false;
            this.savePaletteButton.FlatBottom = false;
            this.savePaletteButton.FlatTop = false;
            this.savePaletteButton.Location = new System.Drawing.Point(39, 167);
            this.savePaletteButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.savePaletteButton.Name = "savePaletteButton";
            this.savePaletteButton.Padding = new System.Windows.Forms.Padding(6);
            this.savePaletteButton.Size = new System.Drawing.Size(27, 27);
            this.savePaletteButton.TabIndex = 6;
            this.toolTip.SetToolTip(this.savePaletteButton, "Save Palette");
            this.savePaletteButton.Click += new System.EventHandler(this.SavePaletteButton_Click);
            // 
            // toolTip
            // 
            this.toolTip.OwnerDraw = true;
            // 
            // screenColorPicker
            // 
            this.screenColorPicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.screenColorPicker.Color = System.Drawing.Color.Black;
            this.screenColorPicker.Location = new System.Drawing.Point(501, 94);
            this.screenColorPicker.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.screenColorPicker.Name = "screenColorPicker";
            this.screenColorPicker.Size = new System.Drawing.Size(85, 98);
            this.toolTip.SetToolTip(this.screenColorPicker, "Click and drag to select screen color");
            this.screenColorPicker.Zoom = 6;
            // 
            // colorWheel
            // 
            this.colorWheel.Alpha = 1D;
            this.colorWheel.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.colorWheel.Location = new System.Drawing.Point(13, 12);
            this.colorWheel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.colorWheel.Name = "colorWheel";
            this.colorWheel.Size = new System.Drawing.Size(192, 152);
            this.colorWheel.TabIndex = 4;
            // 
            // colorEditor
            // 
            this.colorEditor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.colorEditor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.colorEditor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.colorEditor.Location = new System.Drawing.Point(214, 12);
            this.colorEditor.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.colorEditor.Name = "colorEditor";
            this.colorEditor.Size = new System.Drawing.Size(278, 260);
            this.colorEditor.TabIndex = 0;
            // 
            // colorGrid
            // 
            this.colorGrid.AutoAddColors = false;
            this.colorGrid.CellBorderStyle = AltUI.ColorPicker.ColorCellBorderStyle.None;
            this.colorGrid.EditMode = AltUI.ColorPicker.ColorEditingMode.Both;
            this.colorGrid.Location = new System.Drawing.Point(13, 200);
            this.colorGrid.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.colorGrid.Name = "colorGrid";
            this.colorGrid.Padding = new System.Windows.Forms.Padding(0);
            this.colorGrid.Palette = AltUI.ColorPicker.ColorPalette.Paint;
            this.colorGrid.SelectedCellStyle = AltUI.ColorPicker.ColorGridSelectedCellStyle.Standard;
            this.colorGrid.ShowCustomColors = false;
            this.colorGrid.Size = new System.Drawing.Size(192, 72);
            this.colorGrid.Spacing = new System.Drawing.Size(0, 0);
            this.colorGrid.TabIndex = 7;
            this.colorGrid.EditingColor += new System.EventHandler<AltUI.ColorPicker.EditColorCancelEventArgs>(this.ColorGrid_EditingColor);
            // 
            // colorEditorManager
            // 
            this.colorEditorManager.Color = System.Drawing.Color.Empty;
            this.colorEditorManager.ColorEditor = this.colorEditor;
            this.colorEditorManager.ColorGrid = this.colorGrid;
            this.colorEditorManager.ColorWheel = this.colorWheel;
            this.colorEditorManager.ScreenColorPicker = this.screenColorPicker;
            this.colorEditorManager.ColorChanged += new System.EventHandler(this.ColorEditorManager_ColorChanged);
            // 
            // ColorPickerDialog
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(602, 284);
            this.Controls.Add(this.savePaletteButton);
            this.Controls.Add(this.loadPaletteButton);
            this.Controls.Add(this.previewPanel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.screenColorPicker);
            this.Controls.Add(this.colorWheel);
            this.Controls.Add(this.colorEditor);
            this.Controls.Add(this.colorGrid);
            this.CornerStyle = AltUI.Forms.DarkForm.CornerPreference.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ColorPickerDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Color Picker";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private ColorGrid colorGrid;
    private ColorEditor colorEditor;
    private ColorWheel colorWheel;
    private ColorEditorManager colorEditorManager;
    private ScreenColorPicker screenColorPicker;
    private DarkButton okButton;
    private DarkButton cancelButton;
    private System.Windows.Forms.Panel previewPanel;
    private DarkButton loadPaletteButton;
    private DarkButton savePaletteButton;
    private DarkToolTip toolTip;
  }
}
