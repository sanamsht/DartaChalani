
namespace DartaChalani
{
    partial class ChangePassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePassword));
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnChangePw = new System.Windows.Forms.Button();
            this.txtConfirmPw = new System.Windows.Forms.TextBox();
            this.txtNewPw = new System.Windows.Forms.TextBox();
            this.txtOldPw = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(311, 157);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(61, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnChangePw
            // 
            this.btnChangePw.Location = new System.Drawing.Point(176, 158);
            this.btnChangePw.Name = "btnChangePw";
            this.btnChangePw.Size = new System.Drawing.Size(115, 23);
            this.btnChangePw.TabIndex = 3;
            this.btnChangePw.Text = "Change Password";
            this.btnChangePw.UseVisualStyleBackColor = true;
            // 
            // txtConfirmPw
            // 
            this.txtConfirmPw.Location = new System.Drawing.Point(176, 103);
            this.txtConfirmPw.Name = "txtConfirmPw";
            this.txtConfirmPw.Size = new System.Drawing.Size(196, 20);
            this.txtConfirmPw.TabIndex = 2;
            // 
            // txtNewPw
            // 
            this.txtNewPw.Location = new System.Drawing.Point(176, 60);
            this.txtNewPw.Name = "txtNewPw";
            this.txtNewPw.Size = new System.Drawing.Size(196, 20);
            this.txtNewPw.TabIndex = 1;
            // 
            // txtOldPw
            // 
            this.txtOldPw.Location = new System.Drawing.Point(176, 16);
            this.txtOldPw.Name = "txtOldPw";
            this.txtOldPw.Size = new System.Drawing.Size(196, 20);
            this.txtOldPw.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Confirm Password :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "New Password :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Old Password :";
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 190);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnChangePw);
            this.Controls.Add(this.txtConfirmPw);
            this.Controls.Add(this.txtNewPw);
            this.Controls.Add(this.txtOldPw);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(413, 229);
            this.MinimizeBox = false;
            this.Name = "ChangePassword";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Change Password";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnChangePw;
        private System.Windows.Forms.TextBox txtConfirmPw;
        private System.Windows.Forms.TextBox txtNewPw;
        private System.Windows.Forms.TextBox txtOldPw;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}