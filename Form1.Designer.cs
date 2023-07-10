namespace WinFormsApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.startIDtxt = new System.Windows.Forms.TextBox();
            this.endIDtxt = new System.Windows.Forms.TextBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.toTxt = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.locationIdTxt = new System.Windows.Forms.TextBox();
            this.productIdTxt = new System.Windows.Forms.TextBox();
            this.locationIdLbl = new System.Windows.Forms.Label();
            this.productIdLbl = new System.Windows.Forms.Label();
            this.updateBtn = new System.Windows.Forms.Button();
            this.quantityTxt = new System.Windows.Forms.TextBox();
            this.binTxt = new System.Windows.Forms.TextBox();
            this.quantityLbl = new System.Windows.Forms.Label();
            this.binLbl = new System.Windows.Forms.Label();
            this.shelfTxt = new System.Windows.Forms.TextBox();
            this.shelfLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(9, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Start product ID";
            //this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(232, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "End product ID";
            // 
            // startIDtxt
            // 
            this.startIDtxt.Location = new System.Drawing.Point(9, 48);
            this.startIDtxt.Name = "startIDtxt";
            this.startIDtxt.Size = new System.Drawing.Size(169, 31);
            this.startIDtxt.TabIndex = 2;
            //this.startIDtxt.TextChanged += new System.EventHandler(this.startIDtxt_TextChanged);
            // 
            // endIDtxt
            // 
            this.endIDtxt.Location = new System.Drawing.Point(232, 48);
            this.endIDtxt.Name = "endIDtxt";
            this.endIDtxt.Size = new System.Drawing.Size(169, 31);
            this.endIDtxt.TabIndex = 3;
            // 
            // searchBtn
            // 
            this.searchBtn.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.searchBtn.Location = new System.Drawing.Point(426, 43);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(127, 35);
            this.searchBtn.TabIndex = 4;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // toTxt
            // 
            this.toTxt.AutoSize = true;
            this.toTxt.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.toTxt.Location = new System.Drawing.Point(192, 49);
            this.toTxt.Name = "toTxt";
            this.toTxt.Size = new System.Drawing.Size(28, 24);
            this.toTxt.TabIndex = 5;
            this.toTxt.Text = "to";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 121);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(574, 515);
            this.dataGridView1.TabIndex = 6;
            //this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(597, 196);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 33;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(574, 436);
            this.dataGridView2.TabIndex = 7;
           // this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // locationIdTxt
            // 
            this.locationIdTxt.Location = new System.Drawing.Point(811, 49);
            this.locationIdTxt.Name = "locationIdTxt";
            this.locationIdTxt.ReadOnly = true;
            this.locationIdTxt.Size = new System.Drawing.Size(169, 31);
            this.locationIdTxt.TabIndex = 12;
            this.locationIdTxt.Visible = false;
            // 
            // productIdTxt
            // 
            this.productIdTxt.Location = new System.Drawing.Point(620, 48);
            this.productIdTxt.Name = "productIdTxt";
            this.productIdTxt.ReadOnly = true;
            this.productIdTxt.Size = new System.Drawing.Size(169, 31);
            this.productIdTxt.TabIndex = 11;
            this.productIdTxt.Visible = false;
            // 
            // locationIdLbl
            // 
            this.locationIdLbl.AutoSize = true;
            this.locationIdLbl.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.locationIdLbl.Location = new System.Drawing.Point(811, 21);
            this.locationIdLbl.Name = "locationIdLbl";
            this.locationIdLbl.Size = new System.Drawing.Size(116, 24);
            this.locationIdLbl.TabIndex = 10;
            this.locationIdLbl.Text = "Location ID";
            this.locationIdLbl.Visible = false;
            // 
            // productIdLbl
            // 
            this.productIdLbl.AutoSize = true;
            this.productIdLbl.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.productIdLbl.Location = new System.Drawing.Point(620, 21);
            this.productIdLbl.Name = "productIdLbl";
            this.productIdLbl.Size = new System.Drawing.Size(108, 24);
            this.productIdLbl.TabIndex = 9;
            this.productIdLbl.Text = "Product ID";
            this.productIdLbl.Visible = false;
            // 
            // updateBtn
            // 
            this.updateBtn.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.updateBtn.Location = new System.Drawing.Point(1015, 109);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(147, 45);
            this.updateBtn.TabIndex = 19;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Visible = false;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // quantityTxt
            // 
            this.quantityTxt.Location = new System.Drawing.Point(811, 124);
            this.quantityTxt.Name = "quantityTxt";
            this.quantityTxt.Size = new System.Drawing.Size(169, 31);
            this.quantityTxt.TabIndex = 18;
            this.quantityTxt.Visible = false;
            // 
            // binTxt
            // 
            this.binTxt.Location = new System.Drawing.Point(620, 124);
            this.binTxt.Name = "binTxt";
            this.binTxt.Size = new System.Drawing.Size(169, 31);
            this.binTxt.TabIndex = 17;
            this.binTxt.Visible = false;
            // 
            // quantityLbl
            // 
            this.quantityLbl.AutoSize = true;
            this.quantityLbl.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.quantityLbl.Location = new System.Drawing.Point(811, 97);
            this.quantityLbl.Name = "quantityLbl";
            this.quantityLbl.Size = new System.Drawing.Size(89, 24);
            this.quantityLbl.TabIndex = 16;
            this.quantityLbl.Text = "Quantity";
            this.quantityLbl.Visible = false;
            // 
            // binLbl
            // 
            this.binLbl.AutoSize = true;
            this.binLbl.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.binLbl.Location = new System.Drawing.Point(620, 97);
            this.binLbl.Name = "binLbl";
            this.binLbl.Size = new System.Drawing.Size(41, 24);
            this.binLbl.TabIndex = 15;
            this.binLbl.Text = "Bin";
            this.binLbl.Visible = false;
            // 
            // shelfTxt
            // 
            this.shelfTxt.Location = new System.Drawing.Point(1002, 48);
            this.shelfTxt.Name = "shelfTxt";
            this.shelfTxt.Size = new System.Drawing.Size(169, 31);
            this.shelfTxt.TabIndex = 21;
            this.shelfTxt.Visible = false;
            //this.shelfTxt.TextChanged += new System.EventHandler(this.shelfTxt_TextChanged);
            // 
            // shelfLbl
            // 
            this.shelfLbl.AutoSize = true;
            this.shelfLbl.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.shelfLbl.Location = new System.Drawing.Point(1002, 21);
            this.shelfLbl.Name = "shelfLbl";
            this.shelfLbl.Size = new System.Drawing.Size(56, 24);
            this.shelfLbl.TabIndex = 20;
            this.shelfLbl.Text = "Shelf";
            this.shelfLbl.Visible = false;
            //this.shelfLbl.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 644);
            this.Controls.Add(this.shelfTxt);
            this.Controls.Add(this.shelfLbl);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.quantityTxt);
            this.Controls.Add(this.binTxt);
            this.Controls.Add(this.quantityLbl);
            this.Controls.Add(this.binLbl);
            this.Controls.Add(this.locationIdTxt);
            this.Controls.Add(this.productIdTxt);
            this.Controls.Add(this.locationIdLbl);
            this.Controls.Add(this.productIdLbl);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toTxt);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.endIDtxt);
            this.Controls.Add(this.startIDtxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            //this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox startIDtxt;
        private TextBox endIDtxt;
        private Button searchBtn;
        private Label toTxt;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private TextBox locationIdTxt;
        private TextBox productIdTxt;
        private Label locationIdLbl;
        private Label productIdLbl;
        private Button updateBtn;
        private TextBox quantityTxt;
        private TextBox binTxt;
        private Label quantityLbl;
        private Label binLbl;
        private TextBox shelfTxt;
        private Label shelfLbl;
    }
}