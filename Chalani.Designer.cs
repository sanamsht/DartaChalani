
namespace DartaChalani
{
    partial class Chalani
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Chalani));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnChaSearch = new System.Windows.Forms.Button();
            this.tbChaSearch = new System.Windows.Forms.TextBox();
            this.btnChaHome = new System.Windows.Forms.Button();
            this.btnChaAddNew = new System.Windows.Forms.Button();
            this.dgvChalani = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChalani)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnChaSearch);
            this.panel1.Controls.Add(this.tbChaSearch);
            this.panel1.Controls.Add(this.btnChaHome);
            this.panel1.Controls.Add(this.btnChaAddNew);
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
            this.label1.Size = new System.Drawing.Size(76, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "चलानी";
            // 
            // btnChaSearch
            // 
            this.btnChaSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChaSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnChaSearch.Image")));
            this.btnChaSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChaSearch.Location = new System.Drawing.Point(1250, 24);
            this.btnChaSearch.Name = "btnChaSearch";
            this.btnChaSearch.Size = new System.Drawing.Size(80, 22);
            this.btnChaSearch.TabIndex = 4;
            this.btnChaSearch.Text = "Search";
            this.btnChaSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnChaSearch.UseVisualStyleBackColor = true;
            // 
            // tbChaSearch
            // 
            this.tbChaSearch.Location = new System.Drawing.Point(940, 25);
            this.tbChaSearch.Name = "tbChaSearch";
            this.tbChaSearch.Size = new System.Drawing.Size(307, 20);
            this.tbChaSearch.TabIndex = 3;
            // 
            // btnChaHome
            // 
            this.btnChaHome.Image = global::DartaChalani.Properties.Resources.home_circle_icon_137496;
            this.btnChaHome.Location = new System.Drawing.Point(4, 5);
            this.btnChaHome.Name = "btnChaHome";
            this.btnChaHome.Size = new System.Drawing.Size(50, 50);
            this.btnChaHome.TabIndex = 2;
            this.btnChaHome.UseVisualStyleBackColor = true;
            this.btnChaHome.Click += new System.EventHandler(this.btnChaHome_Click);
            // 
            // btnChaAddNew
            // 
            this.btnChaAddNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChaAddNew.Image = ((System.Drawing.Image)(resources.GetObject("btnChaAddNew.Image")));
            this.btnChaAddNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChaAddNew.Location = new System.Drawing.Point(80, 5);
            this.btnChaAddNew.Name = "btnChaAddNew";
            this.btnChaAddNew.Size = new System.Drawing.Size(151, 49);
            this.btnChaAddNew.TabIndex = 1;
            this.btnChaAddNew.Text = "Add New Record";
            this.btnChaAddNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnChaAddNew.UseVisualStyleBackColor = true;
            this.btnChaAddNew.Click += new System.EventHandler(this.btnChaAddNew_Click);
            // 
            // dgvChalani
            // 
            this.dgvChalani.AllowUserToAddRows = false;
            this.dgvChalani.AllowUserToDeleteRows = false;
            this.dgvChalani.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvChalani.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvChalani.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChalani.Location = new System.Drawing.Point(15, 93);
            this.dgvChalani.Name = "dgvChalani";
            this.dgvChalani.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Kalimati", 8.25F);
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvChalani.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvChalani.Size = new System.Drawing.Size(1350, 581);
            this.dgvChalani.TabIndex = 3;
            this.dgvChalani.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvViewBtnClick);
            // 
            // Chalani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.dgvChalani);
            this.Controls.Add(this.panel1);
            this.Name = "Chalani";
            this.Size = new System.Drawing.Size(1375, 685);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChalani)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnChaSearch;
        private System.Windows.Forms.TextBox tbChaSearch;
        private System.Windows.Forms.Button btnChaHome;
        private System.Windows.Forms.Button btnChaAddNew;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView dgvChalani;
    }
}
