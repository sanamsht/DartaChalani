
namespace DartaChalani
{
    partial class ConsultancyDarta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultancyDarta));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCDSearch = new System.Windows.Forms.Button();
            this.tbCDSearch = new System.Windows.Forms.TextBox();
            this.btnCDHome = new System.Windows.Forms.Button();
            this.btnCDAddNew = new System.Windows.Forms.Button();
            this.dgvConsultancyDarta = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultancyDarta)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnCDSearch);
            this.panel1.Controls.Add(this.tbCDSearch);
            this.panel1.Controls.Add(this.btnCDHome);
            this.panel1.Controls.Add(this.btnCDAddNew);
            this.panel1.Location = new System.Drawing.Point(15, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1350, 55);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(540, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "Consultancy दर्ता";
            // 
            // btnCDSearch
            // 
            this.btnCDSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCDSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnCDSearch.Image")));
            this.btnCDSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCDSearch.Location = new System.Drawing.Point(1250, 24);
            this.btnCDSearch.Name = "btnCDSearch";
            this.btnCDSearch.Size = new System.Drawing.Size(80, 22);
            this.btnCDSearch.TabIndex = 4;
            this.btnCDSearch.Text = "Search";
            this.btnCDSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCDSearch.UseVisualStyleBackColor = true;
            // 
            // tbCDSearch
            // 
            this.tbCDSearch.Location = new System.Drawing.Point(940, 25);
            this.tbCDSearch.Name = "tbCDSearch";
            this.tbCDSearch.Size = new System.Drawing.Size(307, 20);
            this.tbCDSearch.TabIndex = 3;
            // 
            // btnCDHome
            // 
            this.btnCDHome.Image = global::DartaChalani.Properties.Resources.home_circle_icon_137496;
            this.btnCDHome.Location = new System.Drawing.Point(4, 5);
            this.btnCDHome.Name = "btnCDHome";
            this.btnCDHome.Size = new System.Drawing.Size(50, 50);
            this.btnCDHome.TabIndex = 2;
            this.btnCDHome.UseVisualStyleBackColor = true;
            this.btnCDHome.Click += new System.EventHandler(this.btnCDHome_Click);
            // 
            // btnCDAddNew
            // 
            this.btnCDAddNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCDAddNew.Image = ((System.Drawing.Image)(resources.GetObject("btnCDAddNew.Image")));
            this.btnCDAddNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCDAddNew.Location = new System.Drawing.Point(80, 5);
            this.btnCDAddNew.Name = "btnCDAddNew";
            this.btnCDAddNew.Size = new System.Drawing.Size(151, 49);
            this.btnCDAddNew.TabIndex = 1;
            this.btnCDAddNew.Text = "Add New Record";
            this.btnCDAddNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCDAddNew.UseVisualStyleBackColor = true;
            this.btnCDAddNew.Click += new System.EventHandler(this.btnCDAddNew_Click);
            // 
            // dgvConsultancyDarta
            // 
            this.dgvConsultancyDarta.AllowUserToOrderColumns = true;
            this.dgvConsultancyDarta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvConsultancyDarta.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvConsultancyDarta.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvConsultancyDarta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultancyDarta.Location = new System.Drawing.Point(15, 93);
            this.dgvConsultancyDarta.Name = "dgvConsultancyDarta";
            this.dgvConsultancyDarta.Size = new System.Drawing.Size(1350, 581);
            this.dgvConsultancyDarta.TabIndex = 3;
            // 
            // ConsultancyDarta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.dgvConsultancyDarta);
            this.Controls.Add(this.panel1);
            this.Name = "ConsultancyDarta";
            this.Size = new System.Drawing.Size(1375, 685);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultancyDarta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCDSearch;
        private System.Windows.Forms.TextBox tbCDSearch;
        private System.Windows.Forms.Button btnCDHome;
        private System.Windows.Forms.Button btnCDAddNew;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvConsultancyDarta;
    }
}
