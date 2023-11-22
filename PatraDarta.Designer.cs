
namespace DartaChalani
{
    partial class PatraDarta
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatraDarta));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPDSearch = new System.Windows.Forms.Button();
            this.tbPDSearch = new System.Windows.Forms.TextBox();
            this.btnPDHome = new System.Windows.Forms.Button();
            this.btnPDAddNew = new System.Windows.Forms.Button();
            this.dgvMainDarta = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMainDarta)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnPDSearch);
            this.panel1.Controls.Add(this.tbPDSearch);
            this.panel1.Controls.Add(this.btnPDHome);
            this.panel1.Controls.Add(this.btnPDAddNew);
            this.panel1.Location = new System.Drawing.Point(15, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1350, 55);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(540, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "दर्ता";
            // 
            // btnPDSearch
            // 
            this.btnPDSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPDSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnPDSearch.Image")));
            this.btnPDSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPDSearch.Location = new System.Drawing.Point(1250, 24);
            this.btnPDSearch.Name = "btnPDSearch";
            this.btnPDSearch.Size = new System.Drawing.Size(80, 22);
            this.btnPDSearch.TabIndex = 4;
            this.btnPDSearch.Text = "Search";
            this.btnPDSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPDSearch.UseVisualStyleBackColor = true;
            // 
            // tbPDSearch
            // 
            this.tbPDSearch.Location = new System.Drawing.Point(940, 25);
            this.tbPDSearch.Name = "tbPDSearch";
            this.tbPDSearch.Size = new System.Drawing.Size(307, 20);
            this.tbPDSearch.TabIndex = 3;
            // 
            // btnPDHome
            // 
            this.btnPDHome.Image = global::DartaChalani.Properties.Resources.home_circle_icon_137496;
            this.btnPDHome.Location = new System.Drawing.Point(4, 5);
            this.btnPDHome.Name = "btnPDHome";
            this.btnPDHome.Size = new System.Drawing.Size(50, 50);
            this.btnPDHome.TabIndex = 2;
            this.btnPDHome.UseVisualStyleBackColor = true;
            this.btnPDHome.Click += new System.EventHandler(this.btnPDHome_Click);
            // 
            // btnPDAddNew
            // 
            this.btnPDAddNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPDAddNew.Image = ((System.Drawing.Image)(resources.GetObject("btnPDAddNew.Image")));
            this.btnPDAddNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPDAddNew.Location = new System.Drawing.Point(80, 5);
            this.btnPDAddNew.Name = "btnPDAddNew";
            this.btnPDAddNew.Size = new System.Drawing.Size(151, 49);
            this.btnPDAddNew.TabIndex = 1;
            this.btnPDAddNew.Text = "Add New Record";
            this.btnPDAddNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPDAddNew.UseVisualStyleBackColor = true;
            this.btnPDAddNew.Click += new System.EventHandler(this.btnPDAddNew_Click);
            // 
            // dgvMainDarta
            // 
            this.dgvMainDarta.AllowUserToOrderColumns = true;
            this.dgvMainDarta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvMainDarta.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvMainDarta.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvMainDarta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMainDarta.Location = new System.Drawing.Point(15, 93);
            this.dgvMainDarta.Name = "dgvMainDarta";
            this.dgvMainDarta.Size = new System.Drawing.Size(1350, 581);
            this.dgvMainDarta.TabIndex = 3;
            // 
            // PatraDarta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.dgvMainDarta);
            this.Controls.Add(this.panel1);
            this.Name = "PatraDarta";
            this.Size = new System.Drawing.Size(1375, 685);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMainDarta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnPDSearch;
        private System.Windows.Forms.TextBox tbPDSearch;
        private System.Windows.Forms.Button btnPDHome;
        private System.Windows.Forms.Button btnPDAddNew;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvMainDarta;
    }
}
