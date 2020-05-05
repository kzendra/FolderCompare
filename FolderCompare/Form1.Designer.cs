namespace FolderCompare
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnSelectBase = new System.Windows.Forms.Button();
            this.lblBaseFolder = new System.Windows.Forms.Label();
            this.gridBase = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCompareFolder = new System.Windows.Forms.Label();
            this.btnSelectCompare = new System.Windows.Forms.Button();
            this.gridCompare = new System.Windows.Forms.DataGridView();
            this.btnCompareFolders = new System.Windows.Forms.Button();
            this.lblComparingFile = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridBase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCompare)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(20, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Base folder:";
            // 
            // btnSelectBase
            // 
            this.btnSelectBase.Location = new System.Drawing.Point(18, 41);
            this.btnSelectBase.Name = "btnSelectBase";
            this.btnSelectBase.Size = new System.Drawing.Size(96, 39);
            this.btnSelectBase.TabIndex = 1;
            this.btnSelectBase.Text = "Select";
            this.btnSelectBase.UseVisualStyleBackColor = true;
            this.btnSelectBase.Click += new System.EventHandler(this.BtnSelectBase_Click);
            // 
            // lblBaseFolder
            // 
            this.lblBaseFolder.AutoSize = true;
            this.lblBaseFolder.Location = new System.Drawing.Point(123, 12);
            this.lblBaseFolder.Name = "lblBaseFolder";
            this.lblBaseFolder.Size = new System.Drawing.Size(0, 18);
            this.lblBaseFolder.TabIndex = 2;
            // 
            // gridBase
            // 
            this.gridBase.AllowUserToAddRows = false;
            this.gridBase.AllowUserToDeleteRows = false;
            this.gridBase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridBase.Location = new System.Drawing.Point(20, 88);
            this.gridBase.Name = "gridBase";
            this.gridBase.ReadOnly = true;
            this.gridBase.Size = new System.Drawing.Size(677, 556);
            this.gridBase.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(708, 12);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Compare folder:";
            // 
            // lblCompareFolder
            // 
            this.lblCompareFolder.AutoSize = true;
            this.lblCompareFolder.Location = new System.Drawing.Point(838, 21);
            this.lblCompareFolder.Name = "lblCompareFolder";
            this.lblCompareFolder.Size = new System.Drawing.Size(0, 18);
            this.lblCompareFolder.TabIndex = 5;
            // 
            // btnSelectCompare
            // 
            this.btnSelectCompare.Location = new System.Drawing.Point(711, 41);
            this.btnSelectCompare.Name = "btnSelectCompare";
            this.btnSelectCompare.Size = new System.Drawing.Size(96, 39);
            this.btnSelectCompare.TabIndex = 6;
            this.btnSelectCompare.Text = "Select";
            this.btnSelectCompare.UseVisualStyleBackColor = true;
            this.btnSelectCompare.Click += new System.EventHandler(this.BtnSelectCompare_Click);
            // 
            // gridCompare
            // 
            this.gridCompare.AllowUserToAddRows = false;
            this.gridCompare.AllowUserToDeleteRows = false;
            this.gridCompare.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCompare.Location = new System.Drawing.Point(711, 86);
            this.gridCompare.Name = "gridCompare";
            this.gridCompare.ReadOnly = true;
            this.gridCompare.Size = new System.Drawing.Size(677, 558);
            this.gridCompare.TabIndex = 7;
            // 
            // btnCompareFolders
            // 
            this.btnCompareFolders.Location = new System.Drawing.Point(18, 650);
            this.btnCompareFolders.Name = "btnCompareFolders";
            this.btnCompareFolders.Size = new System.Drawing.Size(188, 39);
            this.btnCompareFolders.TabIndex = 8;
            this.btnCompareFolders.Text = "Compare folders";
            this.btnCompareFolders.UseVisualStyleBackColor = true;
            this.btnCompareFolders.Click += new System.EventHandler(this.BtnCompareFolders_Click);
            // 
            // lblComparingFile
            // 
            this.lblComparingFile.AutoSize = true;
            this.lblComparingFile.Location = new System.Drawing.Point(228, 659);
            this.lblComparingFile.Name = "lblComparingFile";
            this.lblComparingFile.Size = new System.Drawing.Size(0, 18);
            this.lblComparingFile.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1401, 694);
            this.Controls.Add(this.lblComparingFile);
            this.Controls.Add(this.btnCompareFolders);
            this.Controls.Add(this.gridCompare);
            this.Controls.Add(this.btnSelectCompare);
            this.Controls.Add(this.lblCompareFolder);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gridBase);
            this.Controls.Add(this.lblBaseFolder);
            this.Controls.Add(this.btnSelectBase);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.Text = "Compare folders";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridBase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCompare)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSelectBase;
        private System.Windows.Forms.Label lblBaseFolder;
        private System.Windows.Forms.DataGridView gridBase;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCompareFolder;
        private System.Windows.Forms.Button btnSelectCompare;
        private System.Windows.Forms.DataGridView gridCompare;
        private System.Windows.Forms.Button btnCompareFolders;
        private System.Windows.Forms.Label lblComparingFile;
    }
}

