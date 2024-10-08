
namespace ims
{
    partial class HomeScreen
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.catBtn = new System.Windows.Forms.Button();
            this.Salesbtn = new System.Windows.Forms.Button();
            this.purchaseBtn = new System.Windows.Forms.Button();
            this.Stockbtn = new System.Windows.Forms.Button();
            this.userBtn = new System.Windows.Forms.Button();
            this.suppbtn = new System.Windows.Forms.Button();
            this.probtn = new System.Windows.Forms.Button();
            this.propbtn = new System.Windows.Forms.Button();
            this.leftPanel.SuspendLayout();
            this.rightPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftPanel
            // 
            this.leftPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.leftPanel.Size = new System.Drawing.Size(221, 505);
            // 
            // rightPanel
            // 
            this.rightPanel.Controls.Add(this.tableLayoutPanel1);
            this.rightPanel.Location = new System.Drawing.Point(221, 0);
            this.rightPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rightPanel.Size = new System.Drawing.Size(837, 505);
            this.rightPanel.Controls.SetChildIndex(this.tableLayoutPanel1, 0);
            // 
            // panel2
            // 
            this.panel2.Size = new System.Drawing.Size(221, 49);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.propbtn, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.catBtn, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.Salesbtn, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.purchaseBtn, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.Stockbtn, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.userBtn, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.suppbtn, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.probtn, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 49);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(837, 456);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // catBtn
            // 
            this.catBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.catBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.catBtn.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.catBtn.FlatAppearance.BorderSize = 2;
            this.catBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.catBtn.Location = new System.Drawing.Point(3, 93);
            this.catBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.catBtn.Name = "catBtn";
            this.catBtn.Size = new System.Drawing.Size(161, 87);
            this.catBtn.TabIndex = 6;
            this.catBtn.Text = "Categories";
            this.catBtn.UseVisualStyleBackColor = true;
            this.catBtn.Click += new System.EventHandler(this.catBtn_Click);
            // 
            // Salesbtn
            // 
            this.Salesbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Salesbtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Salesbtn.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.Salesbtn.FlatAppearance.BorderSize = 2;
            this.Salesbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Salesbtn.Location = new System.Drawing.Point(671, 2);
            this.Salesbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Salesbtn.Name = "Salesbtn";
            this.Salesbtn.Size = new System.Drawing.Size(163, 87);
            this.Salesbtn.TabIndex = 4;
            this.Salesbtn.Text = "Sales";
            this.Salesbtn.UseVisualStyleBackColor = true;
            this.Salesbtn.Click += new System.EventHandler(this.Salesbtn_Click);
            // 
            // purchaseBtn
            // 
            this.purchaseBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.purchaseBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.purchaseBtn.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.purchaseBtn.FlatAppearance.BorderSize = 2;
            this.purchaseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.purchaseBtn.Location = new System.Drawing.Point(504, 2);
            this.purchaseBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.purchaseBtn.Name = "purchaseBtn";
            this.purchaseBtn.Size = new System.Drawing.Size(161, 87);
            this.purchaseBtn.TabIndex = 3;
            this.purchaseBtn.Text = "Purchase Invoice";
            this.purchaseBtn.UseVisualStyleBackColor = true;
            this.purchaseBtn.Click += new System.EventHandler(this.purchaseBtn_Click);
            // 
            // Stockbtn
            // 
            this.Stockbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Stockbtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Stockbtn.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.Stockbtn.FlatAppearance.BorderSize = 2;
            this.Stockbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Stockbtn.Location = new System.Drawing.Point(337, 2);
            this.Stockbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Stockbtn.Name = "Stockbtn";
            this.Stockbtn.Size = new System.Drawing.Size(161, 87);
            this.Stockbtn.TabIndex = 2;
            this.Stockbtn.Text = "Stocks";
            this.Stockbtn.UseVisualStyleBackColor = true;
            this.Stockbtn.Click += new System.EventHandler(this.Stockbtn_Click);
            // 
            // userBtn
            // 
            this.userBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.userBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userBtn.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.userBtn.FlatAppearance.BorderSize = 2;
            this.userBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userBtn.Location = new System.Drawing.Point(3, 2);
            this.userBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.userBtn.Name = "userBtn";
            this.userBtn.Size = new System.Drawing.Size(161, 87);
            this.userBtn.TabIndex = 0;
            this.userBtn.Text = "User";
            this.userBtn.UseVisualStyleBackColor = true;
            this.userBtn.Click += new System.EventHandler(this.userBtn_Click);
            // 
            // suppbtn
            // 
            this.suppbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.suppbtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.suppbtn.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.suppbtn.FlatAppearance.BorderSize = 2;
            this.suppbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.suppbtn.Location = new System.Drawing.Point(170, 93);
            this.suppbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.suppbtn.Name = "suppbtn";
            this.suppbtn.Size = new System.Drawing.Size(161, 87);
            this.suppbtn.TabIndex = 5;
            this.suppbtn.Text = "Suppliers";
            this.suppbtn.UseVisualStyleBackColor = true;
            this.suppbtn.Click += new System.EventHandler(this.suppbtn_Click);
            // 
            // probtn
            // 
            this.probtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.probtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.probtn.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.probtn.FlatAppearance.BorderSize = 2;
            this.probtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.probtn.Location = new System.Drawing.Point(170, 2);
            this.probtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.probtn.Name = "probtn";
            this.probtn.Size = new System.Drawing.Size(161, 87);
            this.probtn.TabIndex = 7;
            this.probtn.Text = "Product";
            this.probtn.UseVisualStyleBackColor = true;
            this.probtn.Click += new System.EventHandler(this.probtn_Click_1);
            // 
            // propbtn
            // 
            this.propbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.propbtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propbtn.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.propbtn.FlatAppearance.BorderSize = 2;
            this.propbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.propbtn.Location = new System.Drawing.Point(337, 93);
            this.propbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.propbtn.Name = "propbtn";
            this.propbtn.Size = new System.Drawing.Size(161, 87);
            this.propbtn.TabIndex = 8;
            this.propbtn.Text = "Product Pricing";
            this.propbtn.UseVisualStyleBackColor = true;
            this.propbtn.Click += new System.EventHandler(this.propbtn_Click);
            // 
            // HomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 505);
            this.Name = "HomeScreen";
            this.Text = "Home Screen";
            this.Load += new System.EventHandler(this.HomeScreen_Load);
            this.leftPanel.ResumeLayout(false);
            this.rightPanel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button Salesbtn;
        private System.Windows.Forms.Button purchaseBtn;
        private System.Windows.Forms.Button Stockbtn;
        private System.Windows.Forms.Button userBtn;
        private System.Windows.Forms.Button suppbtn;
        private System.Windows.Forms.Button catBtn;
        private System.Windows.Forms.Button probtn;
        private System.Windows.Forms.Button propbtn;
    }
}