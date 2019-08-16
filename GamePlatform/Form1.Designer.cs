namespace GamePlatform
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
            this.pn_WorldFame = new System.Windows.Forms.Panel();
            this.lb_Bomb = new System.Windows.Forms.Label();
            this.lb_Score = new System.Windows.Forms.Label();
            this.pb_Block9 = new System.Windows.Forms.PictureBox();
            this.pb_Block8 = new System.Windows.Forms.PictureBox();
            this.pb_Block7 = new System.Windows.Forms.PictureBox();
            this.pb_Block6 = new System.Windows.Forms.PictureBox();
            this.pb_Block5 = new System.Windows.Forms.PictureBox();
            this.pb_Block3 = new System.Windows.Forms.PictureBox();
            this.pb_Block4 = new System.Windows.Forms.PictureBox();
            this.pb_Block1 = new System.Windows.Forms.PictureBox();
            this.pb_Block2 = new System.Windows.Forms.PictureBox();
            this.label_Dead = new System.Windows.Forms.Label();
            this.player = new System.Windows.Forms.PictureBox();
            this.tm_Jump = new System.Windows.Forms.Timer(this.components);
            this.tm_Gravity = new System.Windows.Forms.Timer(this.components);
            this.tm_Anim = new System.Windows.Forms.Timer(this.components);
            this.tm_RandomBomb = new System.Windows.Forms.Timer(this.components);
            this.tm_BombFalseSafe = new System.Windows.Forms.Timer(this.components);
            this.tm_Sec = new System.Windows.Forms.Timer(this.components);
            this.tm_Bombremove = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lb_HighScore = new System.Windows.Forms.Label();
            this.pn_WorldFame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Block9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Block8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Block7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Block6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Block5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Block3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Block4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Block1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Block2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pn_WorldFame
            // 
            this.pn_WorldFame.BackColor = System.Drawing.Color.SkyBlue;
            this.pn_WorldFame.Controls.Add(this.lb_Bomb);
            this.pn_WorldFame.Controls.Add(this.lb_HighScore);
            this.pn_WorldFame.Controls.Add(this.lb_Score);
            this.pn_WorldFame.Controls.Add(this.pb_Block9);
            this.pn_WorldFame.Controls.Add(this.pb_Block8);
            this.pn_WorldFame.Controls.Add(this.pb_Block7);
            this.pn_WorldFame.Controls.Add(this.pb_Block6);
            this.pn_WorldFame.Controls.Add(this.pb_Block5);
            this.pn_WorldFame.Controls.Add(this.pb_Block3);
            this.pn_WorldFame.Controls.Add(this.pb_Block4);
            this.pn_WorldFame.Controls.Add(this.pb_Block1);
            this.pn_WorldFame.Controls.Add(this.pb_Block2);
            this.pn_WorldFame.Controls.Add(this.label_Dead);
            this.pn_WorldFame.Controls.Add(this.player);
            this.pn_WorldFame.Location = new System.Drawing.Point(1, -2);
            this.pn_WorldFame.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pn_WorldFame.Name = "pn_WorldFame";
            this.pn_WorldFame.Size = new System.Drawing.Size(765, 647);
            this.pn_WorldFame.TabIndex = 3;
            // 
            // lb_Bomb
            // 
            this.lb_Bomb.AutoSize = true;
            this.lb_Bomb.Location = new System.Drawing.Point(17, 102);
            this.lb_Bomb.Name = "lb_Bomb";
            this.lb_Bomb.Size = new System.Drawing.Size(52, 17);
            this.lb_Bomb.TabIndex = 3;
            this.lb_Bomb.Text = "Bomb: ";
            // 
            // lb_Score
            // 
            this.lb_Score.AutoSize = true;
            this.lb_Score.Location = new System.Drawing.Point(16, 33);
            this.lb_Score.Name = "lb_Score";
            this.lb_Score.Size = new System.Drawing.Size(53, 17);
            this.lb_Score.TabIndex = 3;
            this.lb_Score.Text = "Score: ";
            // 
            // pb_Block9
            // 
            this.pb_Block9.BackgroundImage = global::GamePlatform.Properties.Resources.Platform;
            this.pb_Block9.Location = new System.Drawing.Point(223, 136);
            this.pb_Block9.Margin = new System.Windows.Forms.Padding(5);
            this.pb_Block9.Name = "pb_Block9";
            this.pb_Block9.Size = new System.Drawing.Size(116, 26);
            this.pb_Block9.TabIndex = 2;
            this.pb_Block9.TabStop = false;
            // 
            // pb_Block8
            // 
            this.pb_Block8.BackgroundImage = global::GamePlatform.Properties.Resources.Platform;
            this.pb_Block8.Location = new System.Drawing.Point(623, 345);
            this.pb_Block8.Margin = new System.Windows.Forms.Padding(5);
            this.pb_Block8.Name = "pb_Block8";
            this.pb_Block8.Size = new System.Drawing.Size(116, 25);
            this.pb_Block8.TabIndex = 2;
            this.pb_Block8.TabStop = false;
            // 
            // pb_Block7
            // 
            this.pb_Block7.BackgroundImage = global::GamePlatform.Properties.Resources.Platform;
            this.pb_Block7.Location = new System.Drawing.Point(5, 430);
            this.pb_Block7.Margin = new System.Windows.Forms.Padding(5);
            this.pb_Block7.Name = "pb_Block7";
            this.pb_Block7.Size = new System.Drawing.Size(116, 22);
            this.pb_Block7.TabIndex = 2;
            this.pb_Block7.TabStop = false;
            // 
            // pb_Block6
            // 
            this.pb_Block6.BackgroundImage = global::GamePlatform.Properties.Resources.Platform;
            this.pb_Block6.Location = new System.Drawing.Point(191, 335);
            this.pb_Block6.Margin = new System.Windows.Forms.Padding(5);
            this.pb_Block6.Name = "pb_Block6";
            this.pb_Block6.Size = new System.Drawing.Size(116, 25);
            this.pb_Block6.TabIndex = 2;
            this.pb_Block6.TabStop = false;
            // 
            // pb_Block5
            // 
            this.pb_Block5.BackgroundImage = global::GamePlatform.Properties.Resources.Platform;
            this.pb_Block5.Location = new System.Drawing.Point(417, 430);
            this.pb_Block5.Margin = new System.Windows.Forms.Padding(5);
            this.pb_Block5.Name = "pb_Block5";
            this.pb_Block5.Size = new System.Drawing.Size(116, 27);
            this.pb_Block5.TabIndex = 2;
            this.pb_Block5.TabStop = false;
            // 
            // pb_Block3
            // 
            this.pb_Block3.BackgroundImage = global::GamePlatform.Properties.Resources.Platform;
            this.pb_Block3.Location = new System.Drawing.Point(51, 567);
            this.pb_Block3.Margin = new System.Windows.Forms.Padding(5);
            this.pb_Block3.Name = "pb_Block3";
            this.pb_Block3.Size = new System.Drawing.Size(116, 25);
            this.pb_Block3.TabIndex = 2;
            this.pb_Block3.TabStop = false;
            // 
            // pb_Block4
            // 
            this.pb_Block4.BackgroundImage = global::GamePlatform.Properties.Resources.Platform;
            this.pb_Block4.Location = new System.Drawing.Point(438, 229);
            this.pb_Block4.Margin = new System.Windows.Forms.Padding(5);
            this.pb_Block4.Name = "pb_Block4";
            this.pb_Block4.Size = new System.Drawing.Size(95, 21);
            this.pb_Block4.TabIndex = 2;
            this.pb_Block4.TabStop = false;
            // 
            // pb_Block1
            // 
            this.pb_Block1.BackgroundImage = global::GamePlatform.Properties.Resources.Platform;
            this.pb_Block1.Location = new System.Drawing.Point(585, 522);
            this.pb_Block1.Margin = new System.Windows.Forms.Padding(5);
            this.pb_Block1.Name = "pb_Block1";
            this.pb_Block1.Size = new System.Drawing.Size(116, 23);
            this.pb_Block1.TabIndex = 2;
            this.pb_Block1.TabStop = false;
            // 
            // pb_Block2
            // 
            this.pb_Block2.BackgroundImage = global::GamePlatform.Properties.Resources.Platform;
            this.pb_Block2.Location = new System.Drawing.Point(273, 550);
            this.pb_Block2.Margin = new System.Windows.Forms.Padding(5);
            this.pb_Block2.Name = "pb_Block2";
            this.pb_Block2.Size = new System.Drawing.Size(116, 25);
            this.pb_Block2.TabIndex = 2;
            this.pb_Block2.TabStop = false;
            // 
            // label_Dead
            // 
            this.label_Dead.AutoSize = true;
            this.label_Dead.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Dead.Location = new System.Drawing.Point(319, 218);
            this.label_Dead.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.label_Dead.Name = "label_Dead";
            this.label_Dead.Size = new System.Drawing.Size(99, 20);
            this.label_Dead.TabIndex = 1;
            this.label_Dead.Text = "You die!!!";
            // 
            // player
            // 
            this.player.Image = ((System.Drawing.Image)(resources.GetObject("player.Image")));
            this.player.Location = new System.Drawing.Point(34, 218);
            this.player.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(28, 48);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.player.TabIndex = 0;
            this.player.TabStop = false;
            // 
            // tm_Jump
            // 
            this.tm_Jump.Enabled = true;
            this.tm_Jump.Interval = 30;
            this.tm_Jump.Tick += new System.EventHandler(this.Tm_Gravity_Tick);
            // 
            // tm_Gravity
            // 
            this.tm_Gravity.Enabled = true;
            this.tm_Gravity.Interval = 30;
            this.tm_Gravity.Tick += new System.EventHandler(this.Tm_Gravity_Tick_1);
            // 
            // tm_Anim
            // 
            this.tm_Anim.Enabled = true;
            this.tm_Anim.Interval = 30;
            this.tm_Anim.Tick += new System.EventHandler(this.Tm_Anim_Tick);
            // 
            // tm_RandomBomb
            // 
            this.tm_RandomBomb.Enabled = true;
            this.tm_RandomBomb.Interval = 800;
            this.tm_RandomBomb.Tick += new System.EventHandler(this.Tm_RandomBomb_Tick);
            // 
            // tm_BombFalseSafe
            // 
            this.tm_BombFalseSafe.Enabled = true;
            this.tm_BombFalseSafe.Interval = 3000;
            this.tm_BombFalseSafe.Tick += new System.EventHandler(this.Tm_BombFalseSafe_Tick);
            // 
            // tm_Sec
            // 
            this.tm_Sec.Enabled = true;
            this.tm_Sec.Interval = 1000;
            this.tm_Sec.Tick += new System.EventHandler(this.Tm_Sec_Tick);
            // 
            // tm_Bombremove
            // 
            this.tm_Bombremove.Enabled = true;
            this.tm_Bombremove.Tick += new System.EventHandler(this.Tm_Bombremove_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::GamePlatform.Properties.Resources.floor;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureBox1.Location = new System.Drawing.Point(0, 648);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(766, 34);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "platform game";
            // 
            // lb_HighScore
            // 
            this.lb_HighScore.AutoSize = true;
            this.lb_HighScore.Location = new System.Drawing.Point(16, 69);
            this.lb_HighScore.Name = "lb_HighScore";
            this.lb_HighScore.Size = new System.Drawing.Size(53, 17);
            this.lb_HighScore.TabIndex = 3;
            this.lb_HighScore.Text = "Score: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 682);
            this.Controls.Add(this.pn_WorldFame);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.pn_WorldFame.ResumeLayout(false);
            this.pn_WorldFame.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Block9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Block8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Block7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Block6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Block5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Block3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Block4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Block1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Block2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pn_WorldFame;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.Label label_Dead;
        private System.Windows.Forms.Timer tm_Jump;
        private System.Windows.Forms.Timer tm_Gravity;
        private System.Windows.Forms.PictureBox pb_Block2;
        private System.Windows.Forms.PictureBox pb_Block9;
        private System.Windows.Forms.PictureBox pb_Block8;
        private System.Windows.Forms.PictureBox pb_Block7;
        private System.Windows.Forms.PictureBox pb_Block6;
        private System.Windows.Forms.PictureBox pb_Block5;
        private System.Windows.Forms.PictureBox pb_Block3;
        private System.Windows.Forms.PictureBox pb_Block4;
        private System.Windows.Forms.PictureBox pb_Block1;
        private System.Windows.Forms.Timer tm_Anim;
        private System.Windows.Forms.Label lb_Bomb;
        private System.Windows.Forms.Label lb_Score;
        private System.Windows.Forms.Timer tm_RandomBomb;
        private System.Windows.Forms.Timer tm_BombFalseSafe;
        private System.Windows.Forms.Timer tm_Sec;
        private System.Windows.Forms.Timer tm_Bombremove;
        private System.Windows.Forms.Label lb_HighScore;
    }
}

