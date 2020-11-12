namespace GiveAwayRNG
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.lblName = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.picBlack = new System.Windows.Forms.PictureBox();
            this.picRed = new System.Windows.Forms.PictureBox();
            this.picPurple = new System.Windows.Forms.PictureBox();
            this.picWhite = new System.Windows.Forms.PictureBox();
            this.picCyan = new System.Windows.Forms.PictureBox();
            this.picLime = new System.Windows.Forms.PictureBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.timer5 = new System.Windows.Forms.Timer(this.components);
            this.timer6 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picBlack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPurple)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWhite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCyan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLime)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.Yellow;
            this.lblName.Location = new System.Drawing.Point(0, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(1264, 681);
            this.lblName.TabIndex = 0;
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblName.Visible = false;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Transparent;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Image = global::GiveAwayRNG.Properties.Resources.emergency_button;
            this.btnStart.Location = new System.Drawing.Point(442, 76);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(450, 436);
            this.btnStart.TabIndex = 1;
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // picBlack
            // 
            this.picBlack.BackColor = System.Drawing.Color.Transparent;
            this.picBlack.BackgroundImage = global::GiveAwayRNG.Properties.Resources.black;
            this.picBlack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBlack.Location = new System.Drawing.Point(1008, 377);
            this.picBlack.Name = "picBlack";
            this.picBlack.Size = new System.Drawing.Size(88, 113);
            this.picBlack.TabIndex = 7;
            this.picBlack.TabStop = false;
            // 
            // picRed
            // 
            this.picRed.BackColor = System.Drawing.Color.Transparent;
            this.picRed.BackgroundImage = global::GiveAwayRNG.Properties.Resources.red;
            this.picRed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picRed.Location = new System.Drawing.Point(68, 389);
            this.picRed.Name = "picRed";
            this.picRed.Size = new System.Drawing.Size(93, 123);
            this.picRed.TabIndex = 6;
            this.picRed.TabStop = false;
            // 
            // picPurple
            // 
            this.picPurple.BackColor = System.Drawing.Color.Transparent;
            this.picPurple.BackgroundImage = global::GiveAwayRNG.Properties.Resources.purple;
            this.picPurple.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picPurple.Location = new System.Drawing.Point(665, 544);
            this.picPurple.Name = "picPurple";
            this.picPurple.Size = new System.Drawing.Size(105, 111);
            this.picPurple.TabIndex = 5;
            this.picPurple.TabStop = false;
            // 
            // picWhite
            // 
            this.picWhite.BackColor = System.Drawing.Color.Transparent;
            this.picWhite.BackgroundImage = global::GiveAwayRNG.Properties.Resources.white;
            this.picWhite.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWhite.Location = new System.Drawing.Point(-2, 556);
            this.picWhite.Name = "picWhite";
            this.picWhite.Size = new System.Drawing.Size(123, 125);
            this.picWhite.TabIndex = 4;
            this.picWhite.TabStop = false;
            this.picWhite.Click += new System.EventHandler(this.picWhite_Click);
            // 
            // picCyan
            // 
            this.picCyan.BackColor = System.Drawing.Color.Transparent;
            this.picCyan.BackgroundImage = global::GiveAwayRNG.Properties.Resources.cyan;
            this.picCyan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picCyan.Location = new System.Drawing.Point(1055, 159);
            this.picCyan.Name = "picCyan";
            this.picCyan.Size = new System.Drawing.Size(81, 94);
            this.picCyan.TabIndex = 3;
            this.picCyan.TabStop = false;
            // 
            // picLime
            // 
            this.picLime.BackColor = System.Drawing.Color.Transparent;
            this.picLime.BackgroundImage = global::GiveAwayRNG.Properties.Resources.lime;
            this.picLime.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picLime.Location = new System.Drawing.Point(32, 37);
            this.picLime.Name = "picLime";
            this.picLime.Size = new System.Drawing.Size(96, 112);
            this.picLime.TabIndex = 2;
            this.picLime.TabStop = false;
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // timer4
            // 
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // timer5
            // 
            this.timer5.Tick += new System.EventHandler(this.timer5_Tick);
            // 
            // timer6
            // 
            this.timer6.Tick += new System.EventHandler(this.timer6_Tick);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::GiveAwayRNG.Properties.Resources.space;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.picBlack);
            this.Controls.Add(this.picRed);
            this.Controls.Add(this.picPurple);
            this.Controls.Add(this.picWhite);
            this.Controls.Add(this.picCyan);
            this.Controls.Add(this.picLime);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Select Winner";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBlack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPurple)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWhite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCyan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLime)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.PictureBox picLime;
        private System.Windows.Forms.PictureBox picCyan;
        private System.Windows.Forms.PictureBox picWhite;
        private System.Windows.Forms.PictureBox picPurple;
        private System.Windows.Forms.PictureBox picRed;
        private System.Windows.Forms.PictureBox picBlack;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.Timer timer5;
        private System.Windows.Forms.Timer timer6;
    }
}