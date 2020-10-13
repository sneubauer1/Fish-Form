namespace Prog_Assign_07_Fish_Example
{
    partial class FormFish
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFish));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.listBoxFish = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelWaterType = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonAddFish = new System.Windows.Forms.Button();
            this.buttonModifyFish = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(751, 128);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(270, 359);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // listBoxFish
            // 
            this.listBoxFish.FormattingEnabled = true;
            this.listBoxFish.ItemHeight = 25;
            this.listBoxFish.Location = new System.Drawing.Point(77, 128);
            this.listBoxFish.Name = "listBoxFish";
            this.listBoxFish.Size = new System.Drawing.Size(425, 229);
            this.listBoxFish.TabIndex = 1;
            this.listBoxFish.SelectedIndexChanged += new System.EventHandler(this.listBoxFish_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(77, 431);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Type of water:";
            // 
            // labelWaterType
            // 
            this.labelWaterType.AutoSize = true;
            this.labelWaterType.Location = new System.Drawing.Point(250, 430);
            this.labelWaterType.Name = "labelWaterType";
            this.labelWaterType.Size = new System.Drawing.Size(167, 25);
            this.labelWaterType.TabIndex = 3;
            this.labelWaterType.Text = "Set me to empty";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(464, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Select a fish to see what kind of water it lives in";
            // 
            // buttonAddFish
            // 
            this.buttonAddFish.Location = new System.Drawing.Point(340, 545);
            this.buttonAddFish.Name = "buttonAddFish";
            this.buttonAddFish.Size = new System.Drawing.Size(162, 62);
            this.buttonAddFish.TabIndex = 5;
            this.buttonAddFish.Text = "Add Fish";
            this.buttonAddFish.UseVisualStyleBackColor = true;
            this.buttonAddFish.Click += new System.EventHandler(this.buttonAddFish_Click);
            // 
            // buttonModifyFish
            // 
            this.buttonModifyFish.Location = new System.Drawing.Point(142, 545);
            this.buttonModifyFish.Name = "buttonModifyFish";
            this.buttonModifyFish.Size = new System.Drawing.Size(162, 62);
            this.buttonModifyFish.TabIndex = 6;
            this.buttonModifyFish.Text = "Modify Fish";
            this.buttonModifyFish.UseVisualStyleBackColor = true;
            this.buttonModifyFish.Click += new System.EventHandler(this.buttonModifyFish_Click);
            // 
            // FormFish
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1408, 960);
            this.Controls.Add(this.buttonModifyFish);
            this.Controls.Add(this.buttonAddFish);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelWaterType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxFish);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormFish";
            this.Text = "Something Fishy Going On";
            this.Load += new System.EventHandler(this.FormFish_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox listBoxFish;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelWaterType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonAddFish;
        private System.Windows.Forms.Button buttonModifyFish;
    }
}

