
namespace ims
{
    partial class categories
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.activeDD = new System.Windows.Forms.ComboBox();
            this.activeLabel = new System.Windows.Forms.Label();
            this.catnameLabel = new System.Windows.Forms.Label();
            this.catTxt = new System.Windows.Forms.TextBox();
            this.catErrorLabel = new System.Windows.Forms.Label();
            this.activeErrorLabel = new System.Windows.Forms.Label();
            this.catGridView = new System.Windows.Forms.DataGridView();
            this.catIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leftPanel.SuspendLayout();
            this.rightPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.catGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(0, 49);
            this.panel3.Size = new System.Drawing.Size(758, 60);
            // 
            // backBtn
            // 
            this.backBtn.FlatAppearance.BorderSize = 0;
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.activeDD);
            this.leftPanel.Controls.Add(this.activeLabel);
            this.leftPanel.Controls.Add(this.catnameLabel);
            this.leftPanel.Controls.Add(this.catTxt);
            this.leftPanel.Controls.Add(this.catErrorLabel);
            this.leftPanel.Controls.Add(this.activeErrorLabel);
            this.leftPanel.Size = new System.Drawing.Size(253, 586);
            this.leftPanel.Controls.SetChildIndex(this.panel2, 0);
            this.leftPanel.Controls.SetChildIndex(this.panel4, 0);
            this.leftPanel.Controls.SetChildIndex(this.activeErrorLabel, 0);
            this.leftPanel.Controls.SetChildIndex(this.catErrorLabel, 0);
            this.leftPanel.Controls.SetChildIndex(this.catTxt, 0);
            this.leftPanel.Controls.SetChildIndex(this.catnameLabel, 0);
            this.leftPanel.Controls.SetChildIndex(this.activeLabel, 0);
            this.leftPanel.Controls.SetChildIndex(this.activeDD, 0);
            // 
            // rightPanel
            // 
            this.rightPanel.Controls.Add(this.catGridView);
            this.rightPanel.Size = new System.Drawing.Size(758, 586);
            this.rightPanel.Controls.SetChildIndex(this.panel3, 0);
            this.rightPanel.Controls.SetChildIndex(this.catGridView, 0);
            // 
            // activeDD
            // 
            this.activeDD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.activeDD.FormattingEnabled = true;
            this.activeDD.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.activeDD.Location = new System.Drawing.Point(16, 240);
            this.activeDD.Name = "activeDD";
            this.activeDD.Size = new System.Drawing.Size(216, 28);
            this.activeDD.TabIndex = 22;
            // 
            // activeLabel
            // 
            this.activeLabel.AutoSize = true;
            this.activeLabel.Location = new System.Drawing.Point(12, 212);
            this.activeLabel.Name = "activeLabel";
            this.activeLabel.Size = new System.Drawing.Size(64, 20);
            this.activeLabel.TabIndex = 21;
            this.activeLabel.Text = "Is Active";
            // 
            // catnameLabel
            // 
            this.catnameLabel.AutoSize = true;
            this.catnameLabel.Location = new System.Drawing.Point(12, 147);
            this.catnameLabel.Name = "catnameLabel";
            this.catnameLabel.Size = new System.Drawing.Size(113, 20);
            this.catnameLabel.TabIndex = 18;
            this.catnameLabel.Text = "Category Name";
            // 
            // catTxt
            // 
            this.catTxt.Location = new System.Drawing.Point(16, 183);
            this.catTxt.Multiline = true;
            this.catTxt.Name = "catTxt";
            this.catTxt.Size = new System.Drawing.Size(216, 26);
            this.catTxt.TabIndex = 17;
            // 
            // catErrorLabel
            // 
            this.catErrorLabel.AutoSize = true;
            this.catErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catErrorLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.catErrorLabel.Location = new System.Drawing.Point(131, 147);
            this.catErrorLabel.Name = "catErrorLabel";
            this.catErrorLabel.Size = new System.Drawing.Size(20, 25);
            this.catErrorLabel.TabIndex = 19;
            this.catErrorLabel.Text = "*";
            // 
            // activeErrorLabel
            // 
            this.activeErrorLabel.AutoSize = true;
            this.activeErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activeErrorLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.activeErrorLabel.Location = new System.Drawing.Point(82, 212);
            this.activeErrorLabel.Name = "activeErrorLabel";
            this.activeErrorLabel.Size = new System.Drawing.Size(20, 25);
            this.activeErrorLabel.TabIndex = 20;
            this.activeErrorLabel.Text = "*";
            // 
            // catGridView
            // 
            this.catGridView.AllowUserToAddRows = false;
            this.catGridView.AllowUserToDeleteRows = false;
            this.catGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.catGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.catGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.catGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.catGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.catIDGV,
            this.NameGV,
            this.statusGV});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.catGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.catGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.catGridView.Location = new System.Drawing.Point(0, 109);
            this.catGridView.Name = "catGridView";
            this.catGridView.ReadOnly = true;
            this.catGridView.RowHeadersVisible = false;
            this.catGridView.RowHeadersWidth = 51;
            this.catGridView.RowTemplate.Height = 24;
            this.catGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.catGridView.ShowRowErrors = false;
            this.catGridView.Size = new System.Drawing.Size(758, 477);
            this.catGridView.TabIndex = 3;
            this.catGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.catGridView_CellClick);
            // 
            // catIDGV
            // 
            this.catIDGV.HeaderText = "catID";
            this.catIDGV.MinimumWidth = 6;
            this.catIDGV.Name = "catIDGV";
            this.catIDGV.ReadOnly = true;
            this.catIDGV.Visible = false;
            // 
            // NameGV
            // 
            this.NameGV.HeaderText = "Name";
            this.NameGV.MinimumWidth = 6;
            this.NameGV.Name = "NameGV";
            this.NameGV.ReadOnly = true;
            // 
            // statusGV
            // 
            this.statusGV.HeaderText = "Status";
            this.statusGV.MinimumWidth = 6;
            this.statusGV.Name = "statusGV";
            this.statusGV.ReadOnly = true;
            // 
            // categories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 586);
            this.Name = "categories";
            this.Text = "categories";
            this.Load += new System.EventHandler(this.categories_Load);
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            this.rightPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.catGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox activeDD;
        private System.Windows.Forms.Label activeLabel;
        private System.Windows.Forms.Label catnameLabel;
        private System.Windows.Forms.TextBox catTxt;
        private System.Windows.Forms.Label catErrorLabel;
        private System.Windows.Forms.Label activeErrorLabel;
        private System.Windows.Forms.DataGridView catGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn catIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusGV;
    }
}