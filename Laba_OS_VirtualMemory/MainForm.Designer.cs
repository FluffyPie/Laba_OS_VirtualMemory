namespace Laba_OS_VirtualMemory
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.LruTextbox = new System.Windows.Forms.TextBox();
            this.FifoTextbox = new System.Windows.Forms.TextBox();
            this.YourDateTextbox = new System.Windows.Forms.TextBox();
            this.MainFormElipse = new Guna.UI.WinForms.GunaElipse(this.components);
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.ExitButton = new Guna.UI.WinForms.GunaButton();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.FrameCount = new System.Windows.Forms.NumericUpDown();
            this.FramesLabel = new System.Windows.Forms.Label();
            this.YourLabel = new System.Windows.Forms.Label();
            this.FileLabel = new System.Windows.Forms.Label();
            this.ChooseFileButton = new Guna.UI.WinForms.GunaButton();
            this.FifoLabel = new System.Windows.Forms.Label();
            this.LRULabel = new System.Windows.Forms.Label();
            this.TopPaneDragControl = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FrameCount)).BeginInit();
            this.SuspendLayout();
            // 
            // LruTextbox
            // 
            this.LruTextbox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.LruTextbox.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LruTextbox.Location = new System.Drawing.Point(310, 276);
            this.LruTextbox.Multiline = true;
            this.LruTextbox.Name = "LruTextbox";
            this.LruTextbox.ReadOnly = true;
            this.LruTextbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.LruTextbox.Size = new System.Drawing.Size(277, 351);
            this.LruTextbox.TabIndex = 13;
            // 
            // FifoTextbox
            // 
            this.FifoTextbox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FifoTextbox.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FifoTextbox.Location = new System.Drawing.Point(12, 276);
            this.FifoTextbox.Multiline = true;
            this.FifoTextbox.Name = "FifoTextbox";
            this.FifoTextbox.ReadOnly = true;
            this.FifoTextbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.FifoTextbox.Size = new System.Drawing.Size(277, 351);
            this.FifoTextbox.TabIndex = 12;
            // 
            // YourDateTextbox
            // 
            this.YourDateTextbox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.YourDateTextbox.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.YourDateTextbox.Location = new System.Drawing.Point(12, 124);
            this.YourDateTextbox.Multiline = true;
            this.YourDateTextbox.Name = "YourDateTextbox";
            this.YourDateTextbox.ReadOnly = true;
            this.YourDateTextbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.YourDateTextbox.Size = new System.Drawing.Size(575, 119);
            this.YourDateTextbox.TabIndex = 11;
            // 
            // MainFormElipse
            // 
            this.MainFormElipse.Radius = 10;
            this.MainFormElipse.TargetControl = this;
            // 
            // OpenFileDialog
            // 
            this.OpenFileDialog.FileName = "OpenFileDialog";
            // 
            // ExitButton
            // 
            this.ExitButton.AnimationHoverSpeed = 0.07F;
            this.ExitButton.AnimationSpeed = 0.03F;
            this.ExitButton.BaseColor = System.Drawing.Color.Transparent;
            this.ExitButton.BorderColor = System.Drawing.Color.Black;
            this.ExitButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ExitButton.FocusedColor = System.Drawing.Color.Empty;
            this.ExitButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ExitButton.ForeColor = System.Drawing.Color.White;
            this.ExitButton.Image = ((System.Drawing.Image)(resources.GetObject("ExitButton.Image")));
            this.ExitButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ExitButton.ImageSize = new System.Drawing.Size(20, 20);
            this.ExitButton.Location = new System.Drawing.Point(569, 3);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.ExitButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.ExitButton.OnHoverForeColor = System.Drawing.Color.White;
            this.ExitButton.OnHoverImage = null;
            this.ExitButton.OnPressedColor = System.Drawing.Color.Black;
            this.ExitButton.Size = new System.Drawing.Size(27, 25);
            this.ExitButton.TabIndex = 0;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.TopPanel.Controls.Add(this.ExitButton);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(599, 32);
            this.TopPanel.TabIndex = 16;
            // 
            // FrameCount
            // 
            this.FrameCount.Location = new System.Drawing.Point(15, 65);
            this.FrameCount.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.FrameCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.FrameCount.Name = "FrameCount";
            this.FrameCount.Size = new System.Drawing.Size(165, 20);
            this.FrameCount.TabIndex = 17;
            this.FrameCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // FramesLabel
            // 
            this.FramesLabel.AutoSize = true;
            this.FramesLabel.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FramesLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.FramesLabel.Location = new System.Drawing.Point(12, 44);
            this.FramesLabel.Name = "FramesLabel";
            this.FramesLabel.Size = new System.Drawing.Size(168, 18);
            this.FramesLabel.TabIndex = 18;
            this.FramesLabel.Text = "Number of Frames";
            // 
            // YourLabel
            // 
            this.YourLabel.AutoSize = true;
            this.YourLabel.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.YourLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.YourLabel.Location = new System.Drawing.Point(12, 103);
            this.YourLabel.Name = "YourLabel";
            this.YourLabel.Size = new System.Drawing.Size(98, 18);
            this.YourLabel.TabIndex = 19;
            this.YourLabel.Text = "Your data";
            // 
            // FileLabel
            // 
            this.FileLabel.AutoSize = true;
            this.FileLabel.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FileLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.FileLabel.Location = new System.Drawing.Point(419, 44);
            this.FileLabel.Name = "FileLabel";
            this.FileLabel.Size = new System.Drawing.Size(168, 18);
            this.FileLabel.TabIndex = 20;
            this.FileLabel.Text = "Choose Test File";
            // 
            // ChooseFileButton
            // 
            this.ChooseFileButton.AnimationHoverSpeed = 0.07F;
            this.ChooseFileButton.AnimationSpeed = 0.03F;
            this.ChooseFileButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.ChooseFileButton.BorderColor = System.Drawing.Color.Black;
            this.ChooseFileButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ChooseFileButton.FocusedColor = System.Drawing.Color.Empty;
            this.ChooseFileButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ChooseFileButton.ForeColor = System.Drawing.Color.White;
            this.ChooseFileButton.Image = null;
            this.ChooseFileButton.ImageSize = new System.Drawing.Size(20, 20);
            this.ChooseFileButton.Location = new System.Drawing.Point(422, 65);
            this.ChooseFileButton.Name = "ChooseFileButton";
            this.ChooseFileButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.ChooseFileButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.ChooseFileButton.OnHoverForeColor = System.Drawing.Color.White;
            this.ChooseFileButton.OnHoverImage = null;
            this.ChooseFileButton.OnPressedColor = System.Drawing.Color.Black;
            this.ChooseFileButton.Size = new System.Drawing.Size(165, 44);
            this.ChooseFileButton.TabIndex = 21;
            this.ChooseFileButton.Text = "Open file";
            this.ChooseFileButton.Click += new System.EventHandler(this.ChooseFileButton_Click);
            // 
            // FifoLabel
            // 
            this.FifoLabel.AutoSize = true;
            this.FifoLabel.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FifoLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.FifoLabel.Location = new System.Drawing.Point(9, 255);
            this.FifoLabel.Name = "FifoLabel";
            this.FifoLabel.Size = new System.Drawing.Size(148, 18);
            this.FifoLabel.TabIndex = 22;
            this.FifoLabel.Text = "FIFO algorithm";
            // 
            // LRULabel
            // 
            this.LRULabel.AutoSize = true;
            this.LRULabel.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LRULabel.ForeColor = System.Drawing.SystemColors.Control;
            this.LRULabel.Location = new System.Drawing.Point(439, 255);
            this.LRULabel.Name = "LRULabel";
            this.LRULabel.Size = new System.Drawing.Size(138, 18);
            this.LRULabel.TabIndex = 23;
            this.LRULabel.Text = "LRU algorithm";
            // 
            // TopPaneDragControl
            // 
            this.TopPaneDragControl.TargetControl = this.TopPanel;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(68)))), ((int)(((byte)(75)))));
            this.ClientSize = new System.Drawing.Size(599, 649);
            this.Controls.Add(this.LRULabel);
            this.Controls.Add(this.FifoLabel);
            this.Controls.Add(this.ChooseFileButton);
            this.Controls.Add(this.FileLabel);
            this.Controls.Add(this.YourLabel);
            this.Controls.Add(this.FramesLabel);
            this.Controls.Add(this.FrameCount);
            this.Controls.Add(this.TopPanel);
            this.Controls.Add(this.LruTextbox);
            this.Controls.Add(this.FifoTextbox);
            this.Controls.Add(this.YourDateTextbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.TopPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FrameCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox LruTextbox;
        private System.Windows.Forms.TextBox FifoTextbox;
        private System.Windows.Forms.TextBox YourDateTextbox;
        private Guna.UI.WinForms.GunaElipse MainFormElipse;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog;
        private System.Windows.Forms.Panel TopPanel;
        private Guna.UI.WinForms.GunaButton ExitButton;
        private Guna.UI.WinForms.GunaButton ChooseFileButton;
        private System.Windows.Forms.Label FileLabel;
        private System.Windows.Forms.Label YourLabel;
        private System.Windows.Forms.Label FramesLabel;
        private System.Windows.Forms.NumericUpDown FrameCount;
        private System.Windows.Forms.Label FifoLabel;
        private System.Windows.Forms.Label LRULabel;
        private Guna.UI.WinForms.GunaDragControl TopPaneDragControl;
    }
}

