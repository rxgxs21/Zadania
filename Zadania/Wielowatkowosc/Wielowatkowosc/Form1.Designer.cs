
namespace Wielowatkowosc
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
            this.labelPerLength = new System.Windows.Forms.Label();
            this.numericUpDownPerLength = new System.Windows.Forms.NumericUpDown();
            this.buttonGen = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.labelProgressBar = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPerLength)).BeginInit();
            this.SuspendLayout();
            // 
            // labelPerLength
            // 
            this.labelPerLength.AutoSize = true;
            this.labelPerLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPerLength.Location = new System.Drawing.Point(28, 17);
            this.labelPerLength.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPerLength.Name = "labelPerLength";
            this.labelPerLength.Size = new System.Drawing.Size(129, 16);
            this.labelPerLength.TabIndex = 0;
            this.labelPerLength.Text = "Długość permutacji:";
            // 
            // numericUpDownPerLength
            // 
            this.numericUpDownPerLength.Location = new System.Drawing.Point(208, 17);
            this.numericUpDownPerLength.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numericUpDownPerLength.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.numericUpDownPerLength.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDownPerLength.Name = "numericUpDownPerLength";
            this.numericUpDownPerLength.Size = new System.Drawing.Size(44, 22);
            this.numericUpDownPerLength.TabIndex = 1;
            this.numericUpDownPerLength.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // buttonGen
            // 
            this.buttonGen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonGen.Location = new System.Drawing.Point(276, 8);
            this.buttonGen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonGen.Name = "buttonGen";
            this.buttonGen.Size = new System.Drawing.Size(132, 38);
            this.buttonGen.TabIndex = 2;
            this.buttonGen.Text = "Genereuj";
            this.buttonGen.UseVisualStyleBackColor = true;
            this.buttonGen.Click += new System.EventHandler(this.buttonGen_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(40, 500);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(988, 33);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 3;
            // 
            // labelProgressBar
            // 
            this.labelProgressBar.AutoSize = true;
            this.labelProgressBar.Location = new System.Drawing.Point(36, 480);
            this.labelProgressBar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelProgressBar.Name = "labelProgressBar";
            this.labelProgressBar.Size = new System.Drawing.Size(100, 16);
            this.labelProgressBar.TabIndex = 4;
            this.labelProgressBar.Text = "Permutacja: 0/0";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(45, 65);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(981, 379);
            this.textBox1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelProgressBar);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.buttonGen);
            this.Controls.Add(this.numericUpDownPerLength);
            this.Controls.Add(this.labelPerLength);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Test";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPerLength)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPerLength;
        private System.Windows.Forms.NumericUpDown numericUpDownPerLength;
        private System.Windows.Forms.Button buttonGen;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label labelProgressBar;
        private System.Windows.Forms.TextBox textBox1;
    }
}

