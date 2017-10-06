namespace WindowsFormsApplication3
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.register4 = new System.Windows.Forms.TextBox();
            this.register3 = new System.Windows.Forms.TextBox();
            this.register2 = new System.Windows.Forms.TextBox();
            this.register1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonRotateCCW = new System.Windows.Forms.Button();
            this.buttonRotateCW = new System.Windows.Forms.Button();
            this.buttonPop = new System.Windows.Forms.Button();
            this.buttonPush = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.buttonPlus = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.register4);
            this.groupBox1.Controls.Add(this.register3);
            this.groupBox1.Controls.Add(this.register2);
            this.groupBox1.Controls.Add(this.register1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(496, 139);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registers";
            // 
            // register4
            // 
            this.register4.Enabled = false;
            this.register4.Location = new System.Drawing.Point(7, 109);
            this.register4.Name = "register4";
            this.register4.Size = new System.Drawing.Size(483, 22);
            this.register4.TabIndex = 3;
            // 
            // register3
            // 
            this.register3.Enabled = false;
            this.register3.Location = new System.Drawing.Point(7, 80);
            this.register3.Name = "register3";
            this.register3.Size = new System.Drawing.Size(483, 22);
            this.register3.TabIndex = 2;
            // 
            // register2
            // 
            this.register2.Enabled = false;
            this.register2.Location = new System.Drawing.Point(7, 51);
            this.register2.Name = "register2";
            this.register2.Size = new System.Drawing.Size(483, 22);
            this.register2.TabIndex = 1;
            // 
            // register1
            // 
            this.register1.Location = new System.Drawing.Point(7, 22);
            this.register1.Name = "register1";
            this.register1.Size = new System.Drawing.Size(483, 22);
            this.register1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonRotateCCW);
            this.groupBox2.Controls.Add(this.buttonRotateCW);
            this.groupBox2.Controls.Add(this.buttonPop);
            this.groupBox2.Controls.Add(this.buttonPush);
            this.groupBox2.Location = new System.Drawing.Point(13, 158);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(495, 53);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Stack Operations";
            // 
            // buttonRotateCCW
            // 
            this.buttonRotateCCW.Location = new System.Drawing.Point(253, 22);
            this.buttonRotateCCW.Name = "buttonRotateCCW";
            this.buttonRotateCCW.Size = new System.Drawing.Size(58, 23);
            this.buttonRotateCCW.TabIndex = 3;
            this.buttonRotateCCW.Text = "RCCW";
            this.buttonRotateCCW.UseVisualStyleBackColor = true;
            // 
            // buttonRotateCW
            // 
            this.buttonRotateCW.Location = new System.Drawing.Point(171, 22);
            this.buttonRotateCW.Name = "buttonRotateCW";
            this.buttonRotateCW.Size = new System.Drawing.Size(63, 23);
            this.buttonRotateCW.TabIndex = 2;
            this.buttonRotateCW.Text = "RCW";
            this.buttonRotateCW.UseVisualStyleBackColor = true;
            // 
            // buttonPop
            // 
            this.buttonPop.Location = new System.Drawing.Point(89, 22);
            this.buttonPop.Name = "buttonPop";
            this.buttonPop.Size = new System.Drawing.Size(62, 23);
            this.buttonPop.TabIndex = 1;
            this.buttonPop.Text = "Pop";
            this.buttonPop.UseVisualStyleBackColor = true;
            this.buttonPop.Click += new System.EventHandler(this.buttonPop_Click);
            // 
            // buttonPush
            // 
            this.buttonPush.Location = new System.Drawing.Point(7, 22);
            this.buttonPush.Name = "buttonPush";
            this.buttonPush.Size = new System.Drawing.Size(59, 23);
            this.buttonPush.TabIndex = 0;
            this.buttonPush.Text = "Push";
            this.buttonPush.UseVisualStyleBackColor = true;
            this.buttonPush.Click += new System.EventHandler(this.buttonPush_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(13, 218);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(334, 355);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.buttonPlus);
            this.groupBox4.Location = new System.Drawing.Point(354, 218);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(154, 355);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            // 
            // buttonPlus
            // 
            this.buttonPlus.Location = new System.Drawing.Point(7, 22);
            this.buttonPlus.Name = "buttonPlus";
            this.buttonPlus.Size = new System.Drawing.Size(62, 23);
            this.buttonPlus.TabIndex = 0;
            this.buttonPlus.Text = "+";
            this.buttonPlus.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 585);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox register4;
        private System.Windows.Forms.TextBox register3;
        private System.Windows.Forms.TextBox register2;
        private System.Windows.Forms.TextBox register1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonRotateCCW;
        private System.Windows.Forms.Button buttonRotateCW;
        private System.Windows.Forms.Button buttonPop;
        private System.Windows.Forms.Button buttonPush;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button buttonPlus;
    }
}

