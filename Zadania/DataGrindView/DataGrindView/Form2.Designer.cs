
namespace DataGrindView
{
    partial class Form2
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
            this.labelCtrlE = new System.Windows.Forms.Label();
            this.textBoxCtrlE = new System.Windows.Forms.TextBox();
            this.buttonCtrlECancel = new System.Windows.Forms.Button();
            this.buttonCtrlESave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelCtrlE
            // 
            this.labelCtrlE.AutoSize = true;
            this.labelCtrlE.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelCtrlE.Location = new System.Drawing.Point(31, 25);
            this.labelCtrlE.Name = "labelCtrlE";
            this.labelCtrlE.Size = new System.Drawing.Size(73, 25);
            this.labelCtrlE.TabIndex = 0;
            this.labelCtrlE.Text = "Value:";
            // 
            // textBoxCtrlE
            // 
            this.textBoxCtrlE.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxCtrlE.Location = new System.Drawing.Point(110, 22);
            this.textBoxCtrlE.Name = "textBoxCtrlE";
            this.textBoxCtrlE.Size = new System.Drawing.Size(104, 31);
            this.textBoxCtrlE.TabIndex = 1;
            // 
            // buttonCtrlECancel
            // 
            this.buttonCtrlECancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCtrlECancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonCtrlECancel.Location = new System.Drawing.Point(12, 89);
            this.buttonCtrlECancel.Name = "buttonCtrlECancel";
            this.buttonCtrlECancel.Size = new System.Drawing.Size(99, 38);
            this.buttonCtrlECancel.TabIndex = 2;
            this.buttonCtrlECancel.Text = "Cancel";
            this.buttonCtrlECancel.UseVisualStyleBackColor = true;
            // 
            // buttonCtrlESave
            // 
            this.buttonCtrlESave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonCtrlESave.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonCtrlESave.Location = new System.Drawing.Point(131, 89);
            this.buttonCtrlESave.Name = "buttonCtrlESave";
            this.buttonCtrlESave.Size = new System.Drawing.Size(99, 38);
            this.buttonCtrlESave.TabIndex = 3;
            this.buttonCtrlESave.Text = "Save";
            this.buttonCtrlESave.UseVisualStyleBackColor = true;
            this.buttonCtrlESave.Click += new System.EventHandler(this.buttonCtrlESave_Click);
            // 
            // Form2
            // 
            this.AcceptButton = this.buttonCtrlESave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCtrlECancel;
            this.ClientSize = new System.Drawing.Size(242, 160);
            this.Controls.Add(this.buttonCtrlESave);
            this.Controls.Add(this.buttonCtrlECancel);
            this.Controls.Add(this.textBoxCtrlE);
            this.Controls.Add(this.labelCtrlE);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCtrlE;
        private System.Windows.Forms.TextBox textBoxCtrlE;
        private System.Windows.Forms.Button buttonCtrlECancel;
        private System.Windows.Forms.Button buttonCtrlESave;
    }
}