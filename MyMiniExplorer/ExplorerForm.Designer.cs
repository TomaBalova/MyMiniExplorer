namespace MyMiniExplorer
{
    partial class ExplorerForm
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
            this.comboBoxDisk = new System.Windows.Forms.ComboBox();
            this.listBoxCatalogs = new System.Windows.Forms.ListBox();
            this.listBoxFiles = new System.Windows.Forms.ListBox();
            this.DriveSpaceLabel = new System.Windows.Forms.Label();
            this.CatalogPropLable = new System.Windows.Forms.Label();
            this.FilePropLable = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxDisk
            // 
            this.comboBoxDisk.FormattingEnabled = true;
            this.comboBoxDisk.Location = new System.Drawing.Point(13, 13);
            this.comboBoxDisk.Name = "comboBoxDisk";
            this.comboBoxDisk.Size = new System.Drawing.Size(172, 21);
            this.comboBoxDisk.TabIndex = 0;
            this.comboBoxDisk.SelectedIndexChanged += new System.EventHandler(this.comboBoxDisk_SelectedIndexChanged);
            // 
            // listBoxCatalogs
            // 
            this.listBoxCatalogs.FormattingEnabled = true;
            this.listBoxCatalogs.Location = new System.Drawing.Point(210, 13);
            this.listBoxCatalogs.Name = "listBoxCatalogs";
            this.listBoxCatalogs.Size = new System.Drawing.Size(230, 225);
            this.listBoxCatalogs.TabIndex = 1;
            this.listBoxCatalogs.SelectedIndexChanged += new System.EventHandler(this.listBoxCatalogs_SelectedIndexChanged);
            this.listBoxCatalogs.DoubleClick += new System.EventHandler(this.listBoxCatalogs_DoubleClick);
            // 
            // listBoxFiles
            // 
            this.listBoxFiles.FormattingEnabled = true;
            this.listBoxFiles.Location = new System.Drawing.Point(499, 13);
            this.listBoxFiles.Name = "listBoxFiles";
            this.listBoxFiles.Size = new System.Drawing.Size(230, 225);
            this.listBoxFiles.TabIndex = 2;
            this.listBoxFiles.SelectedIndexChanged += new System.EventHandler(this.listBoxFiles_SelectedIndexChanged);
            this.listBoxFiles.DoubleClick += new System.EventHandler(this.listBoxFiles_DoubleClick);
            // 
            // DriveSpaceLabel
            // 
            this.DriveSpaceLabel.Location = new System.Drawing.Point(10, 261);
            this.DriveSpaceLabel.Name = "DriveSpaceLabel";
            this.DriveSpaceLabel.Size = new System.Drawing.Size(175, 166);
            this.DriveSpaceLabel.TabIndex = 3;
            // 
            // CatalogPropLable
            // 
            this.CatalogPropLable.Location = new System.Drawing.Point(207, 261);
            this.CatalogPropLable.Name = "CatalogPropLable";
            this.CatalogPropLable.Size = new System.Drawing.Size(233, 166);
            this.CatalogPropLable.TabIndex = 4;
            // 
            // FilePropLable
            // 
            this.FilePropLable.Location = new System.Drawing.Point(496, 261);
            this.FilePropLable.Name = "FilePropLable";
            this.FilePropLable.Size = new System.Drawing.Size(233, 166);
            this.FilePropLable.TabIndex = 5;
            // 
            // ExplorerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.FilePropLable);
            this.Controls.Add(this.CatalogPropLable);
            this.Controls.Add(this.DriveSpaceLabel);
            this.Controls.Add(this.listBoxFiles);
            this.Controls.Add(this.listBoxCatalogs);
            this.Controls.Add(this.comboBoxDisk);
            this.Name = "ExplorerForm";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ExplorerForm_FormClosed);
            this.Load += new System.EventHandler(this.ExplorerForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxDisk;
        private System.Windows.Forms.ListBox listBoxCatalogs;
        private System.Windows.Forms.ListBox listBoxFiles;
        private System.Windows.Forms.Label DriveSpaceLabel;
        private System.Windows.Forms.Label CatalogPropLable;
        private System.Windows.Forms.Label FilePropLable;
    }
}

