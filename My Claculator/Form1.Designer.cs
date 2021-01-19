
namespace My_Claculator
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
            this.xTxt = new System.Windows.Forms.TextBox();
            this.yTxt = new System.Windows.Forms.TextBox();
            this.inputxLbl = new System.Windows.Forms.Label();
            this.inputyLbl = new System.Windows.Forms.Label();
            this.resultLbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.addBtn = new System.Windows.Forms.Button();
            this.subBtn = new System.Windows.Forms.Button();
            this.mulBtn = new System.Windows.Forms.Button();
            this.divBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // xTxt
            // 
            this.xTxt.Location = new System.Drawing.Point(225, 114);
            this.xTxt.Name = "xTxt";
            this.xTxt.Size = new System.Drawing.Size(100, 20);
            this.xTxt.TabIndex = 0;
            // 
            // yTxt
            // 
            this.yTxt.Location = new System.Drawing.Point(416, 112);
            this.yTxt.Name = "yTxt";
            this.yTxt.Size = new System.Drawing.Size(100, 20);
            this.yTxt.TabIndex = 1;
            // 
            // inputxLbl
            // 
            this.inputxLbl.AutoSize = true;
            this.inputxLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputxLbl.ForeColor = System.Drawing.Color.Purple;
            this.inputxLbl.Location = new System.Drawing.Point(164, 114);
            this.inputxLbl.Name = "inputxLbl";
            this.inputxLbl.Size = new System.Drawing.Size(18, 18);
            this.inputxLbl.TabIndex = 2;
            this.inputxLbl.Text = "X";
            // 
            // inputyLbl
            // 
            this.inputyLbl.AutoSize = true;
            this.inputyLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputyLbl.ForeColor = System.Drawing.Color.Purple;
            this.inputyLbl.Location = new System.Drawing.Point(364, 114);
            this.inputyLbl.Name = "inputyLbl";
            this.inputyLbl.Size = new System.Drawing.Size(17, 18);
            this.inputyLbl.TabIndex = 3;
            this.inputyLbl.Text = "Y";
            // 
            // resultLbl
            // 
            this.resultLbl.AutoSize = true;
            this.resultLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultLbl.ForeColor = System.Drawing.Color.Purple;
            this.resultLbl.Location = new System.Drawing.Point(581, 111);
            this.resultLbl.Name = "resultLbl";
            this.resultLbl.Size = new System.Drawing.Size(16, 18);
            this.resultLbl.TabIndex = 4;
            this.resultLbl.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(246, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(270, 47);
            this.label4.TabIndex = 5;
            this.label4.Text = "MY CALCULATOR";
            // 
            // addBtn
            // 
            this.addBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.addBtn.Location = new System.Drawing.Point(156, 193);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(85, 35);
            this.addBtn.TabIndex = 6;
            this.addBtn.Text = "+";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // subBtn
            // 
            this.subBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.subBtn.Location = new System.Drawing.Point(278, 193);
            this.subBtn.Name = "subBtn";
            this.subBtn.Size = new System.Drawing.Size(85, 35);
            this.subBtn.TabIndex = 7;
            this.subBtn.Text = "-";
            this.subBtn.UseVisualStyleBackColor = true;
            this.subBtn.Click += new System.EventHandler(this.subBtn_Click);
            // 
            // mulBtn
            // 
            this.mulBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mulBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.mulBtn.Location = new System.Drawing.Point(399, 193);
            this.mulBtn.Name = "mulBtn";
            this.mulBtn.Size = new System.Drawing.Size(85, 35);
            this.mulBtn.TabIndex = 8;
            this.mulBtn.Text = "*";
            this.mulBtn.UseVisualStyleBackColor = true;
            this.mulBtn.Click += new System.EventHandler(this.mulBtn_Click);
            // 
            // divBtn
            // 
            this.divBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.divBtn.Location = new System.Drawing.Point(512, 193);
            this.divBtn.Name = "divBtn";
            this.divBtn.Size = new System.Drawing.Size(85, 35);
            this.divBtn.TabIndex = 9;
            this.divBtn.Text = "/";
            this.divBtn.UseVisualStyleBackColor = true;
            this.divBtn.Click += new System.EventHandler(this.divBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.divBtn);
            this.Controls.Add(this.mulBtn);
            this.Controls.Add(this.subBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.resultLbl);
            this.Controls.Add(this.inputyLbl);
            this.Controls.Add(this.inputxLbl);
            this.Controls.Add(this.yTxt);
            this.Controls.Add(this.xTxt);
            this.Name = "Form1";
            this.Text = "claculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox xTxt;
        private System.Windows.Forms.TextBox yTxt;
        private System.Windows.Forms.Label inputxLbl;
        private System.Windows.Forms.Label inputyLbl;
        private System.Windows.Forms.Label resultLbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button subBtn;
        private System.Windows.Forms.Button mulBtn;
        private System.Windows.Forms.Button divBtn;
    }
}

