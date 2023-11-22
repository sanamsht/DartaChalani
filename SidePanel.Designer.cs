
namespace DartaChalani
{
    partial class SidePanel
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_sp_tippani = new System.Windows.Forms.Button();
            this.btn_sp_darta = new System.Windows.Forms.Button();
            this.btn_sp_consultancy = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Controls.Add(this.btn_sp_tippani);
            this.flowLayoutPanel1.Controls.Add(this.btn_sp_darta);
            this.flowLayoutPanel1.Controls.Add(this.btn_sp_consultancy);
            this.flowLayoutPanel1.Controls.Add(this.button4);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(233, 291);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // btn_sp_tippani
            // 
            this.btn_sp_tippani.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sp_tippani.Location = new System.Drawing.Point(3, 3);
            this.btn_sp_tippani.Name = "btn_sp_tippani";
            this.btn_sp_tippani.Size = new System.Drawing.Size(220, 66);
            this.btn_sp_tippani.TabIndex = 0;
            this.btn_sp_tippani.Text = "टिप्पणी दर्ता";
            this.btn_sp_tippani.UseVisualStyleBackColor = true;
            this.btn_sp_tippani.Click += new System.EventHandler(this.btn_sp_tippani_Click);
            // 
            // btn_sp_darta
            // 
            this.btn_sp_darta.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sp_darta.Location = new System.Drawing.Point(3, 75);
            this.btn_sp_darta.Name = "btn_sp_darta";
            this.btn_sp_darta.Size = new System.Drawing.Size(220, 66);
            this.btn_sp_darta.TabIndex = 0;
            this.btn_sp_darta.Text = "पत्र दर्ता";
            this.btn_sp_darta.UseVisualStyleBackColor = true;
            this.btn_sp_darta.Click += new System.EventHandler(this.btn_sp_darta_Click);
            // 
            // btn_sp_consultancy
            // 
            this.btn_sp_consultancy.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sp_consultancy.Location = new System.Drawing.Point(3, 147);
            this.btn_sp_consultancy.Name = "btn_sp_consultancy";
            this.btn_sp_consultancy.Size = new System.Drawing.Size(220, 66);
            this.btn_sp_consultancy.TabIndex = 0;
            this.btn_sp_consultancy.Text = "Consultancy दर्ता";
            this.btn_sp_consultancy.UseVisualStyleBackColor = true;
            this.btn_sp_consultancy.Click += new System.EventHandler(this.btn_sp_consultancy_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(3, 219);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(220, 66);
            this.button4.TabIndex = 0;
            this.button4.Text = "चलानी";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // SidePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "SidePanel";
            this.Size = new System.Drawing.Size(271, 297);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btn_sp_tippani;
        private System.Windows.Forms.Button btn_sp_darta;
        private System.Windows.Forms.Button btn_sp_consultancy;
        private System.Windows.Forms.Button button4;
    }
}
