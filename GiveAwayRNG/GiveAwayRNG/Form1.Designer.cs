namespace GiveAwayRNG
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lstboxBoosters = new System.Windows.Forms.ListBox();
            this.txtNewBooster = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnRandomize = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnRandomize)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.Red;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(580, 507);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(214, 59);
            this.btnSubmit.TabIndex = 0;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lstboxBoosters
            // 
            this.lstboxBoosters.BackColor = System.Drawing.Color.White;
            this.lstboxBoosters.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstboxBoosters.FormattingEnabled = true;
            this.lstboxBoosters.ItemHeight = 26;
            this.lstboxBoosters.Location = new System.Drawing.Point(447, 33);
            this.lstboxBoosters.Name = "lstboxBoosters";
            this.lstboxBoosters.Size = new System.Drawing.Size(473, 420);
            this.lstboxBoosters.TabIndex = 1;
            // 
            // txtNewBooster
            // 
            this.txtNewBooster.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewBooster.Location = new System.Drawing.Point(447, 459);
            this.txtNewBooster.Multiline = true;
            this.txtNewBooster.Name = "txtNewBooster";
            this.txtNewBooster.Size = new System.Drawing.Size(473, 42);
            this.txtNewBooster.TabIndex = 2;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnRandomize
            // 
            this.btnRandomize.BackColor = System.Drawing.Color.Transparent;
            this.btnRandomize.BackgroundImage = global::GiveAwayRNG.Properties.Resources.floor_vent;
            this.btnRandomize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRandomize.Location = new System.Drawing.Point(635, 572);
            this.btnRandomize.Name = "btnRandomize";
            this.btnRandomize.Size = new System.Drawing.Size(102, 84);
            this.btnRandomize.TabIndex = 3;
            this.btnRandomize.TabStop = false;
            this.btnRandomize.Click += new System.EventHandler(this.btnRandomize_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GiveAwayRNG.Properties.Resources.entry_image;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.btnRandomize);
            this.Controls.Add(this.txtNewBooster);
            this.Controls.Add(this.lstboxBoosters);
            this.Controls.Add(this.btnSubmit);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Nitro Booster Entry";
            this.Load += new System.EventHandler(this.frm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnRandomize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.ListBox lstboxBoosters;
        private System.Windows.Forms.TextBox txtNewBooster;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox btnRandomize;
    }
}

