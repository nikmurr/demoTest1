namespace TestDemoApp1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.cardElement1 = new TestDemoApp1.CardElement();
            this.cardElement2 = new TestDemoApp1.CardElement();
            this.cardElement3 = new TestDemoApp1.CardElement();
            this.cardElement4 = new TestDemoApp1.CardElement();
            this.button1 = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(255)))), ((int)(((byte)(249)))));
            this.flowLayoutPanel1.Controls.Add(this.cardElement1);
            this.flowLayoutPanel1.Controls.Add(this.cardElement2);
            this.flowLayoutPanel1.Controls.Add(this.cardElement3);
            this.flowLayoutPanel1.Controls.Add(this.cardElement4);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 110);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1181, 595);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // cardElement1
            // 
            this.cardElement1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cardElement1.AutoSize = true;
            this.cardElement1.Location = new System.Drawing.Point(3, 3);
            this.cardElement1.MinimumSize = new System.Drawing.Size(0, 116);
            this.cardElement1.Name = "cardElement1";
            this.cardElement1.Size = new System.Drawing.Size(1178, 116);
            this.cardElement1.TabIndex = 0;
            // 
            // cardElement2
            // 
            this.cardElement2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cardElement2.AutoSize = true;
            this.cardElement2.Location = new System.Drawing.Point(3, 125);
            this.cardElement2.MinimumSize = new System.Drawing.Size(0, 116);
            this.cardElement2.Name = "cardElement2";
            this.cardElement2.Size = new System.Drawing.Size(590, 133);
            this.cardElement2.TabIndex = 1;
            // 
            // cardElement3
            // 
            this.cardElement3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cardElement3.AutoSize = true;
            this.cardElement3.Location = new System.Drawing.Point(3, 264);
            this.cardElement3.MinimumSize = new System.Drawing.Size(0, 116);
            this.cardElement3.Name = "cardElement3";
            this.cardElement3.Size = new System.Drawing.Size(590, 133);
            this.cardElement3.TabIndex = 2;
            // 
            // cardElement4
            // 
            this.cardElement4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cardElement4.AutoSize = true;
            this.cardElement4.Location = new System.Drawing.Point(3, 403);
            this.cardElement4.MinimumSize = new System.Drawing.Size(0, 116);
            this.cardElement4.Name = "cardElement4";
            this.cardElement4.Size = new System.Drawing.Size(590, 133);
            this.cardElement4.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 72);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1205, 717);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Подсистема для работы с продукцией  «Лопушок»";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private CardElement cardElement1;
        private CardElement cardElement2;
        private CardElement cardElement3;
        private CardElement cardElement4;
        private System.Windows.Forms.Button button1;
    }
}

