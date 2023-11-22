
namespace DartaChalani
{
    partial class MainPanel
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Tippani = new System.Windows.Forms.Button();
            this.btnMainDarta = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btn_Tippani, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnMainDarta, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.button5, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.button6, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(49, 44);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(15, 15, 10, 10);
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(754, 468);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // btn_Tippani
            // 
            this.btn_Tippani.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Tippani.Location = new System.Drawing.Point(18, 18);
            this.btn_Tippani.Name = "btn_Tippani";
            this.btn_Tippani.Padding = new System.Windows.Forms.Padding(1);
            this.btn_Tippani.Size = new System.Drawing.Size(336, 184);
            this.btn_Tippani.TabIndex = 0;
            this.btn_Tippani.Text = "टिप्पणी दर्ता";
            this.btn_Tippani.UseVisualStyleBackColor = true;
            this.btn_Tippani.Click += new System.EventHandler(this.btn_Tippani_Click);
            // 
            // btnMainDarta
            // 
            this.btnMainDarta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMainDarta.Font = new System.Drawing.Font("Microsoft Sans Serif", 56F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMainDarta.Location = new System.Drawing.Point(394, 18);
            this.btnMainDarta.Name = "btnMainDarta";
            this.btnMainDarta.Padding = new System.Windows.Forms.Padding(15, 15, 10, 10);
            this.btnMainDarta.Size = new System.Drawing.Size(347, 184);
            this.btnMainDarta.TabIndex = 0;
            this.btnMainDarta.Text = "दर्ता";
            this.btnMainDarta.UseVisualStyleBackColor = true;
            this.btnMainDarta.Click += new System.EventHandler(this.btnMainDarta_Click);
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 38F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(18, 271);
            this.button5.Name = "button5";
            this.button5.Padding = new System.Windows.Forms.Padding(1);
            this.button5.Size = new System.Drawing.Size(336, 184);
            this.button5.TabIndex = 0;
            this.button5.Text = "Consultancy दर्ता";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 56F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(405, 271);
            this.button6.Name = "button6";
            this.button6.Padding = new System.Windows.Forms.Padding(15, 15, 10, 10);
            this.button6.Size = new System.Drawing.Size(336, 184);
            this.button6.TabIndex = 0;
            this.button6.Text = "चलानी";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // MainPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MainPanel";
            this.Size = new System.Drawing.Size(852, 556);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btn_Tippani;
        private System.Windows.Forms.Button btnMainDarta;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}
