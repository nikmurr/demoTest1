namespace TestDemoApp1
{
    partial class CardElement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CardElement));
            this.iconBox = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label_prod_type = new System.Windows.Forms.Label();
            this.label_div = new System.Windows.Forms.Label();
            this.label_prod_name = new System.Windows.Forms.Label();
            this.label_prod_price = new System.Windows.Forms.Label();
            this.label_prod_art = new System.Windows.Forms.Label();
            this.label_prod_material = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.iconBox)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // iconBox
            // 
            this.iconBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.iconBox.Image = ((System.Drawing.Image)(resources.GetObject("iconBox.Image")));
            this.iconBox.Location = new System.Drawing.Point(14, 14);
            this.iconBox.Name = "iconBox";
            this.iconBox.Size = new System.Drawing.Size(103, 77);
            this.iconBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconBox.TabIndex = 0;
            this.iconBox.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label_prod_art, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label_prod_material, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(133, 14);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(892, 87);
            this.tableLayoutPanel1.TabIndex = 1;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.label_prod_type);
            this.flowLayoutPanel1.Controls.Add(this.label_div);
            this.flowLayoutPanel1.Controls.Add(this.label_prod_name);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(270, 29);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // label_prod_type
            // 
            this.label_prod_type.AutoSize = true;
            this.label_prod_type.Font = new System.Drawing.Font("Gabriola", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_prod_type.Location = new System.Drawing.Point(3, 0);
            this.label_prod_type.Name = "label_prod_type";
            this.label_prod_type.Size = new System.Drawing.Size(86, 29);
            this.label_prod_type.TabIndex = 0;
            this.label_prod_type.Text = "Тип товара";
            // 
            // label_div
            // 
            this.label_div.AutoSize = true;
            this.label_div.Font = new System.Drawing.Font("Gabriola", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_div.Location = new System.Drawing.Point(92, 0);
            this.label_div.Margin = new System.Windows.Forms.Padding(0);
            this.label_div.Name = "label_div";
            this.label_div.Size = new System.Drawing.Size(18, 29);
            this.label_div.TabIndex = 1;
            this.label_div.Text = "|";
            // 
            // label_prod_name
            // 
            this.label_prod_name.AutoSize = true;
            this.label_prod_name.Font = new System.Drawing.Font("Gabriola", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_prod_name.Location = new System.Drawing.Point(113, 0);
            this.label_prod_name.Name = "label_prod_name";
            this.label_prod_name.Size = new System.Drawing.Size(154, 29);
            this.label_prod_name.TabIndex = 2;
            this.label_prod_name.Text = "Наименование товара";
            // 
            // label_prod_price
            // 
            this.label_prod_price.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_prod_price.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_prod_price.Location = new System.Drawing.Point(1043, 14);
            this.label_prod_price.Name = "label_prod_price";
            this.label_prod_price.Size = new System.Drawing.Size(110, 87);
            this.label_prod_price.TabIndex = 3;
            this.label_prod_price.Text = "100₽";
            // 
            // label_prod_art
            // 
            this.label_prod_art.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label_prod_art.AutoSize = true;
            this.label_prod_art.Font = new System.Drawing.Font("Gabriola", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_prod_art.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label_prod_art.Location = new System.Drawing.Point(3, 29);
            this.label_prod_art.Name = "label_prod_art";
            this.label_prod_art.Size = new System.Drawing.Size(59, 29);
            this.label_prod_art.TabIndex = 4;
            this.label_prod_art.Text = "артикул";
            // 
            // label_prod_material
            // 
            this.label_prod_material.AutoSize = true;
            this.label_prod_material.Font = new System.Drawing.Font("Gabriola", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_prod_material.Location = new System.Drawing.Point(3, 58);
            this.label_prod_material.Name = "label_prod_material";
            this.label_prod_material.Size = new System.Drawing.Size(572, 29);
            this.label_prod_material.TabIndex = 5;
            this.label_prod_material.Text = "Материалы товара, Материалы товара, Материалы товара, Материалы товара, Материалы" +
    " товара";
            // 
            // CardElement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.iconBox);
            this.Controls.Add(this.label_prod_price);
            this.MinimumSize = new System.Drawing.Size(0, 116);
            this.Name = "CardElement";
            this.Size = new System.Drawing.Size(1167, 116);
            this.Load += new System.EventHandler(this.CardElement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iconBox)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox iconBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label_prod_type;
        private System.Windows.Forms.Label label_div;
        private System.Windows.Forms.Label label_prod_name;
        private System.Windows.Forms.Label label_prod_art;
        private System.Windows.Forms.Label label_prod_price;
        private System.Windows.Forms.Label label_prod_material;
    }
}
