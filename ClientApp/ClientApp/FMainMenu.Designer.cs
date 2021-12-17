
namespace ClientApp
{
    partial class FMainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FMainMenu));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.backImgButton = new Guna.UI2.WinForms.Guna2ImageButton();
            this.goldRateLabel = new System.Windows.Forms.Label();
            this.datetimePicker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2ComboBox1 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.goldDataGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.searchButton = new Guna.UI2.WinForms.Guna2Button();
            this.resetButton = new Guna.UI2.WinForms.Guna2Button();
            this.serverStatusLabel = new System.Windows.Forms.Label();
            this.serverStatusGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.goldDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serverStatusGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // backImgButton
            // 
            this.backImgButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backImgButton.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.backImgButton.CheckedState.Parent = this.backImgButton;
            this.backImgButton.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.backImgButton.HoverState.Parent = this.backImgButton;
            this.backImgButton.Image = ((System.Drawing.Image)(resources.GetObject("backImgButton.Image")));
            this.backImgButton.ImageOffset = new System.Drawing.Point(0, 0);
            this.backImgButton.ImageRotate = 0F;
            this.backImgButton.ImageSize = new System.Drawing.Size(60, 60);
            this.backImgButton.Location = new System.Drawing.Point(1045, 671);
            this.backImgButton.Name = "backImgButton";
            this.backImgButton.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.backImgButton.PressedState.Parent = this.backImgButton;
            this.backImgButton.ShadowDecoration.Parent = this.backImgButton;
            this.backImgButton.Size = new System.Drawing.Size(74, 70);
            this.backImgButton.TabIndex = 0;
            this.backImgButton.Click += new System.EventHandler(this.backImgButton_Click);
            // 
            // goldRateLabel
            // 
            this.goldRateLabel.AutoSize = true;
            this.goldRateLabel.BackColor = System.Drawing.Color.Khaki;
            this.goldRateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goldRateLabel.ForeColor = System.Drawing.Color.Black;
            this.goldRateLabel.Location = new System.Drawing.Point(392, 9);
            this.goldRateLabel.Name = "goldRateLabel";
            this.goldRateLabel.Size = new System.Drawing.Size(508, 91);
            this.goldRateLabel.TabIndex = 1;
            this.goldRateLabel.Text = "GOLD RATE";
            // 
            // datetimePicker
            // 
            this.datetimePicker.BorderRadius = 10;
            this.datetimePicker.Checked = true;
            this.datetimePicker.CheckedState.Parent = this.datetimePicker;
            this.datetimePicker.CustomFormat = "MM/dd/yyyy | hh:mm";
            this.datetimePicker.FillColor = System.Drawing.Color.Khaki;
            this.datetimePicker.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.datetimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datetimePicker.HoverState.Parent = this.datetimePicker;
            this.datetimePicker.Location = new System.Drawing.Point(12, 130);
            this.datetimePicker.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.datetimePicker.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.datetimePicker.Name = "datetimePicker";
            this.datetimePicker.ShadowDecoration.Parent = this.datetimePicker;
            this.datetimePicker.Size = new System.Drawing.Size(249, 52);
            this.datetimePicker.TabIndex = 2;
            this.datetimePicker.Value = new System.DateTime(2021, 12, 9, 1, 59, 48, 793);
            // 
            // guna2ComboBox1
            // 
            this.guna2ComboBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ComboBox1.BorderColor = System.Drawing.Color.White;
            this.guna2ComboBox1.BorderRadius = 10;
            this.guna2ComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.guna2ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guna2ComboBox1.FillColor = System.Drawing.Color.Khaki;
            this.guna2ComboBox1.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox1.FocusedState.Parent = this.guna2ComboBox1;
            this.guna2ComboBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.guna2ComboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.guna2ComboBox1.HoverState.Parent = this.guna2ComboBox1;
            this.guna2ComboBox1.ItemHeight = 30;
            this.guna2ComboBox1.ItemsAppearance.Parent = this.guna2ComboBox1;
            this.guna2ComboBox1.Location = new System.Drawing.Point(341, 146);
            this.guna2ComboBox1.Name = "guna2ComboBox1";
            this.guna2ComboBox1.ShadowDecoration.Parent = this.guna2ComboBox1;
            this.guna2ComboBox1.Size = new System.Drawing.Size(113, 36);
            this.guna2ComboBox1.TabIndex = 3;
            this.guna2ComboBox1.Tag = "";
            // 
            // goldDataGridView
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.goldDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.goldDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.goldDataGridView.BackgroundColor = System.Drawing.Color.LightGray;
            this.goldDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.goldDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.goldDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.goldDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.goldDataGridView.ColumnHeadersHeight = 4;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.goldDataGridView.DefaultCellStyle = dataGridViewCellStyle9;
            this.goldDataGridView.EnableHeadersVisualStyles = false;
            this.goldDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.goldDataGridView.Location = new System.Drawing.Point(12, 203);
            this.goldDataGridView.Name = "goldDataGridView";
            this.goldDataGridView.RowHeadersVisible = false;
            this.goldDataGridView.RowHeadersWidth = 51;
            this.goldDataGridView.RowTemplate.Height = 24;
            this.goldDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.goldDataGridView.Size = new System.Drawing.Size(863, 538);
            this.goldDataGridView.TabIndex = 4;
            this.goldDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.goldDataGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.goldDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.goldDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.goldDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.goldDataGridView.ThemeStyle.BackColor = System.Drawing.Color.LightGray;
            this.goldDataGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.goldDataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.goldDataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.goldDataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goldDataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.goldDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.goldDataGridView.ThemeStyle.HeaderStyle.Height = 4;
            this.goldDataGridView.ThemeStyle.ReadOnly = false;
            this.goldDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.goldDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.goldDataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goldDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.goldDataGridView.ThemeStyle.RowsStyle.Height = 24;
            this.goldDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.goldDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // searchButton
            // 
            this.searchButton.BorderRadius = 10;
            this.searchButton.CheckedState.Parent = this.searchButton;
            this.searchButton.CustomImages.Parent = this.searchButton;
            this.searchButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.searchButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.searchButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.searchButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.searchButton.DisabledState.Parent = this.searchButton;
            this.searchButton.FillColor = System.Drawing.Color.Khaki;
            this.searchButton.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.searchButton.ForeColor = System.Drawing.Color.Black;
            this.searchButton.HoverState.Parent = this.searchButton;
            this.searchButton.Location = new System.Drawing.Point(527, 137);
            this.searchButton.Name = "searchButton";
            this.searchButton.ShadowDecoration.Parent = this.searchButton;
            this.searchButton.Size = new System.Drawing.Size(156, 45);
            this.searchButton.TabIndex = 5;
            this.searchButton.Text = "Search";
            // 
            // resetButton
            // 
            this.resetButton.BorderRadius = 10;
            this.resetButton.CheckedState.Parent = this.resetButton;
            this.resetButton.CustomImages.Parent = this.resetButton;
            this.resetButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.resetButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.resetButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.resetButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.resetButton.DisabledState.Parent = this.resetButton;
            this.resetButton.FillColor = System.Drawing.Color.Khaki;
            this.resetButton.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetButton.ForeColor = System.Drawing.Color.Black;
            this.resetButton.HoverState.Parent = this.resetButton;
            this.resetButton.Location = new System.Drawing.Point(734, 137);
            this.resetButton.Name = "resetButton";
            this.resetButton.ShadowDecoration.Parent = this.resetButton;
            this.resetButton.Size = new System.Drawing.Size(141, 45);
            this.resetButton.TabIndex = 6;
            this.resetButton.Text = "Reset";
            // 
            // serverStatusLabel
            // 
            this.serverStatusLabel.AutoSize = true;
            this.serverStatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serverStatusLabel.Location = new System.Drawing.Point(944, 147);
            this.serverStatusLabel.Name = "serverStatusLabel";
            this.serverStatusLabel.Size = new System.Drawing.Size(263, 44);
            this.serverStatusLabel.TabIndex = 7;
            this.serverStatusLabel.Text = "Server Status";
            // 
            // serverStatusGridView
            // 
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            this.serverStatusGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.serverStatusGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.serverStatusGridView.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.serverStatusGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.serverStatusGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.serverStatusGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.serverStatusGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.serverStatusGridView.ColumnHeadersHeight = 4;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.serverStatusGridView.DefaultCellStyle = dataGridViewCellStyle12;
            this.serverStatusGridView.EnableHeadersVisualStyles = false;
            this.serverStatusGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.serverStatusGridView.Location = new System.Drawing.Point(918, 203);
            this.serverStatusGridView.Name = "serverStatusGridView";
            this.serverStatusGridView.RowHeadersVisible = false;
            this.serverStatusGridView.RowHeadersWidth = 51;
            this.serverStatusGridView.RowTemplate.Height = 24;
            this.serverStatusGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.serverStatusGridView.Size = new System.Drawing.Size(305, 445);
            this.serverStatusGridView.TabIndex = 8;
            this.serverStatusGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.serverStatusGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.serverStatusGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.serverStatusGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.serverStatusGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.serverStatusGridView.ThemeStyle.BackColor = System.Drawing.Color.Gainsboro;
            this.serverStatusGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.serverStatusGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.serverStatusGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.serverStatusGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serverStatusGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.serverStatusGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.serverStatusGridView.ThemeStyle.HeaderStyle.Height = 4;
            this.serverStatusGridView.ThemeStyle.ReadOnly = false;
            this.serverStatusGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.serverStatusGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.serverStatusGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serverStatusGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.serverStatusGridView.ThemeStyle.RowsStyle.Height = 24;
            this.serverStatusGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.serverStatusGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(367, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Type";
            // 
            // FMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.ClientSize = new System.Drawing.Size(1251, 753);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.serverStatusGridView);
            this.Controls.Add(this.serverStatusLabel);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.goldDataGridView);
            this.Controls.Add(this.guna2ComboBox1);
            this.Controls.Add(this.datetimePicker);
            this.Controls.Add(this.goldRateLabel);
            this.Controls.Add(this.backImgButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1269, 800);
            this.Name = "FMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GOLD RATE";
            ((System.ComponentModel.ISupportInitialize)(this.goldDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serverStatusGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ImageButton backImgButton;
        private System.Windows.Forms.Label goldRateLabel;
        private Guna.UI2.WinForms.Guna2DateTimePicker datetimePicker;
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBox1;
        private Guna.UI2.WinForms.Guna2DataGridView goldDataGridView;
        private Guna.UI2.WinForms.Guna2Button searchButton;
        private Guna.UI2.WinForms.Guna2Button resetButton;
        private System.Windows.Forms.Label serverStatusLabel;
        private Guna.UI2.WinForms.Guna2DataGridView serverStatusGridView;
        private System.Windows.Forms.Label label1;
    }
}