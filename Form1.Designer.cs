
namespace PlayingBird
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
            this.flayingtop = new System.Windows.Forms.PictureBox();
            this.flayingbird = new System.Windows.Forms.PictureBox();
            this.ground = new System.Windows.Forms.PictureBox();
            this.flayingbottom = new System.Windows.Forms.PictureBox();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.flayingtop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flayingbird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flayingbottom)).BeginInit();
            this.SuspendLayout();
            // 
            // flayingtop
            // 
            this.flayingtop.Image = global::PlayingBird.Properties.Resources.pipedown;
            this.flayingtop.Location = new System.Drawing.Point(406, -2);
            this.flayingtop.Name = "flayingtop";
            this.flayingtop.Size = new System.Drawing.Size(88, 189);
            this.flayingtop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.flayingtop.TabIndex = 0;
            this.flayingtop.TabStop = false;
            // 
            // flayingbird
            // 
            this.flayingbird.Image = global::PlayingBird.Properties.Resources.bird;
            this.flayingbird.Location = new System.Drawing.Point(12, 228);
            this.flayingbird.Name = "flayingbird";
            this.flayingbird.Size = new System.Drawing.Size(91, 67);
            this.flayingbird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.flayingbird.TabIndex = 1;
            this.flayingbird.TabStop = false;
            this.flayingbird.Click += new System.EventHandler(this.flayingbird_Click);
            // 
            // ground
            // 
            this.ground.Image = global::PlayingBird.Properties.Resources.ground;
            this.ground.Location = new System.Drawing.Point(0, 539);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(520, 79);
            this.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground.TabIndex = 2;
            this.ground.TabStop = false;
            // 
            // flayingbottom
            // 
            this.flayingbottom.Image = global::PlayingBird.Properties.Resources.pipe;
            this.flayingbottom.Location = new System.Drawing.Point(328, 369);
            this.flayingbottom.Name = "flayingbottom";
            this.flayingbottom.Size = new System.Drawing.Size(88, 190);
            this.flayingbottom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.flayingbottom.TabIndex = 3;
            this.flayingbottom.TabStop = false;
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 30;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimerEvent);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 572);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 35);
            this.label2.TabIndex = 5;
            this.label2.Text = "Score:0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(519, 621);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.flayingbottom);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.flayingbird);
            this.Controls.Add(this.flayingtop);
            this.Name = "Form1";
            this.Text = "Playing your bird";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gamekeyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gameskeyisup);
            ((System.ComponentModel.ISupportInitialize)(this.flayingtop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flayingbird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flayingbottom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox flayingtop;
        private System.Windows.Forms.PictureBox flayingbird;
        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.PictureBox flayingbottom;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label label2;
    }
}

