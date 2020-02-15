namespace Snake
{
    partial class Ground
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ground));
            this.Logo = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Start = new System.Windows.Forms.Button();
            this.Go = new System.Windows.Forms.Label();
            this.PlayAgain = new System.Windows.Forms.Button();
            this.Body1 = new System.Windows.Forms.PictureBox();
            this.Body2 = new System.Windows.Forms.PictureBox();
            this.Food = new System.Windows.Forms.PictureBox();
            this.HeadOfSnake = new System.Windows.Forms.PictureBox();
            this.Body3 = new System.Windows.Forms.PictureBox();
            this.Body4 = new System.Windows.Forms.PictureBox();
            this.Body5 = new System.Windows.Forms.PictureBox();
            this.Body7 = new System.Windows.Forms.PictureBox();
            this.Body6 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Body1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Body2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Food)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeadOfSnake)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Body3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Body4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Body5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Body7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Body6)).BeginInit();
            this.SuspendLayout();
            // 
            // Logo
            // 
            resources.ApplyResources(this.Logo, "Logo");
            this.Logo.Name = "Logo";
            // 
            // Title
            // 
            resources.ApplyResources(this.Title, "Title");
            this.Title.ForeColor = System.Drawing.Color.LimeGreen;
            this.Title.Name = "Title";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Start
            // 
            this.Start.BackColor = System.Drawing.Color.Lime;
            resources.ApplyResources(this.Start, "Start");
            this.Start.Name = "Start";
            this.Start.UseVisualStyleBackColor = false;
            this.Start.Click += new System.EventHandler(this.button1_Click);
            // 
            // Go
            // 
            resources.ApplyResources(this.Go, "Go");
            this.Go.Name = "Go";
            // 
            // PlayAgain
            // 
            this.PlayAgain.BackColor = System.Drawing.Color.Lime;
            resources.ApplyResources(this.PlayAgain, "PlayAgain");
            this.PlayAgain.Name = "PlayAgain";
            this.PlayAgain.UseVisualStyleBackColor = false;
            this.PlayAgain.Click += new System.EventHandler(this.PlayAgin_Click);
            // 
            // Body1
            // 
            this.Body1.BackColor = System.Drawing.Color.Lime;
            resources.ApplyResources(this.Body1, "Body1");
            this.Body1.Name = "Body1";
            this.Body1.TabStop = false;
            // 
            // Body2
            // 
            this.Body2.BackColor = System.Drawing.Color.Lime;
            resources.ApplyResources(this.Body2, "Body2");
            this.Body2.Name = "Body2";
            this.Body2.TabStop = false;
            // 
            // Food
            // 
            this.Food.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            resources.ApplyResources(this.Food, "Food");
            this.Food.Name = "Food";
            this.Food.TabStop = false;
            this.Food.Click += new System.EventHandler(this.Food_Click);
            // 
            // HeadOfSnake
            // 
            this.HeadOfSnake.BackColor = System.Drawing.Color.Red;
            resources.ApplyResources(this.HeadOfSnake, "HeadOfSnake");
            this.HeadOfSnake.Name = "HeadOfSnake";
            this.HeadOfSnake.TabStop = false;
            this.HeadOfSnake.Click += new System.EventHandler(this.HeadOfSnake_Click);
            // 
            // Body3
            // 
            this.Body3.BackColor = System.Drawing.Color.Lime;
            resources.ApplyResources(this.Body3, "Body3");
            this.Body3.Name = "Body3";
            this.Body3.TabStop = false;
            // 
            // Body4
            // 
            this.Body4.BackColor = System.Drawing.Color.Lime;
            resources.ApplyResources(this.Body4, "Body4");
            this.Body4.Name = "Body4";
            this.Body4.TabStop = false;
            // 
            // Body5
            // 
            this.Body5.BackColor = System.Drawing.Color.Lime;
            resources.ApplyResources(this.Body5, "Body5");
            this.Body5.Name = "Body5";
            this.Body5.TabStop = false;
            // 
            // Body7
            // 
            this.Body7.BackColor = System.Drawing.Color.Lime;
            resources.ApplyResources(this.Body7, "Body7");
            this.Body7.Name = "Body7";
            this.Body7.TabStop = false;
            // 
            // Body6
            // 
            this.Body6.BackColor = System.Drawing.Color.Lime;
            resources.ApplyResources(this.Body6, "Body6");
            this.Body6.Name = "Body6";
            this.Body6.TabStop = false;
            // 
            // Ground
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.BackgroundImage = global::Snake.Properties.Resources.animal_crossing_grass_remake_spring__hd__by_thenewhylton_d79w7f1;
            this.CausesValidation = false;
            this.Controls.Add(this.PlayAgain);
            this.Controls.Add(this.Go);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.Body6);
            this.Controls.Add(this.Body7);
            this.Controls.Add(this.Body5);
            this.Controls.Add(this.Body4);
            this.Controls.Add(this.Body3);
            this.Controls.Add(this.Body1);
            this.Controls.Add(this.Body2);
            this.Controls.Add(this.Food);
            this.Controls.Add(this.HeadOfSnake);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.Title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Ground";
            this.Load += new System.EventHandler(this.Ground_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Body1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Body2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Food)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeadOfSnake)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Body3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Body4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Body5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Body7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Body6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Go;
        private System.Windows.Forms.Label Logo;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox HeadOfSnake;
        private System.Windows.Forms.PictureBox Body2;
        private System.Windows.Forms.PictureBox Body1;
        private System.Windows.Forms.PictureBox Body3;
        private System.Windows.Forms.PictureBox Food;
        private System.Windows.Forms.PictureBox Body4;
        private System.Windows.Forms.PictureBox Body5;
        private System.Windows.Forms.PictureBox Body6;
        private System.Windows.Forms.PictureBox Body7;
        
        private System.Windows.Forms.Button Start;
      
        private System.Windows.Forms.Button PlayAgain;
    }
}

