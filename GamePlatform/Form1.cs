using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GamePlatform
{
    public partial class Form1 : Form
    {

        #region var
        Boolean right, left;
        Boolean Isjumping;
        Boolean DriftJumpRight;
        Boolean GameOn;

        int g = 25;
        int Force;
        int bomsize = 16;
        int amin = 0;
        int Score = 0;

        String DebugLog = "Started: " + DateTime.Now + "\n";
        PictureBox[] WorldObjects = new PictureBox[10];
        PictureBox[] Bomb = new PictureBox[10];//bom
        PictureBox[] Expolsive = new PictureBox[10];//thuốc nỗ



        #endregion
        #region check || Function 

        public Boolean OutSideWorldFrame(PictureBox tar)
        {
            if (tar.Location.X < 0)
            {
                return true;
            }
            if (tar.Location.X > pn_WorldFame.Width)
            {
                return true;
            }
            if (tar.Location.Y + tar.Height > pn_WorldFame.Height)
            {
                return true;
            }
            foreach (PictureBox ob in WorldObjects)
            {
                if (ob != null)
                {
                    if (tar.Bounds.IntersectsWith(ob.Bounds))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public Boolean InAirNoCollosion(PictureBox tar)
        {
            if (!OutSideWorldFrame(tar))
            {
                foreach (PictureBox obj in WorldObjects)
                {
                    if (tar.Bounds.IntersectsWith(obj.Bounds))
                    {
                        if (tar.Location.Y < pn_WorldFame.Height)
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        public Boolean Collision_Top(PictureBox tar)
        {
            foreach (PictureBox ob in WorldObjects)
            {
                if (ob != null)
                {
                    PictureBox temp = new PictureBox();
                    temp.Bounds = ob.Bounds;
                    temp.SetBounds(temp.Location.X - 3, temp.Location.Y - 1, temp.Width + 6, 1);
                    if (tar.Bounds.IntersectsWith(temp.Bounds))
                        return true;
                }
            }
            return false;
        }

        public Boolean Collision_Bottom(PictureBox tar)
        {
            foreach (PictureBox ob in WorldObjects)
            {
                if (ob != null)
                {
                    PictureBox temp = new PictureBox();
                    temp.Bounds = ob.Bounds;
                    temp.SetBounds(temp.Location.X, temp.Location.Y + temp.Height, temp.Width, 1);
                    if (tar.Bounds.IntersectsWith(temp.Bounds))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public Boolean Collision_Left(PictureBox tar)
        {
            foreach (PictureBox ob in WorldObjects)
            {
                if (ob != null)
                {
                    PictureBox temp = new PictureBox();
                    temp.Bounds = ob.Bounds;
                    temp.SetBounds(temp.Location.X - 1, temp.Location.Y + 1, 1, temp.Height - 1);
                    if (tar.Bounds.IntersectsWith(temp.Bounds))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public Boolean Collision_Right(PictureBox tar)
        {
            foreach (PictureBox ob in WorldObjects)
            {
                if (ob != null)
                {
                    PictureBox temp = new PictureBox();
                    temp.Bounds = ob.Bounds;
                    temp.SetBounds(temp.Location.X + temp.Width, temp.Location.Y + 1, 1, temp.Height - 1);
                    if (tar.Bounds.IntersectsWith(temp.Bounds))
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        #endregion

        #region Keyboard
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

            switch (e.KeyCode)
            {
                case Keys.Right:
                    if (GameOn)
                    {
                        //   player.Image = Character.stand_r;
                        right = true;
                        DriftJumpRight = true;
                    }
                    break;
                case Keys.P:
                    if (GameOn)
                    {
                        GameOn = false;
                        label_Dead.Text = " Press P to continue.";
                        label_Dead.Visible = true;
                    }
                    else
                    {
                        GameOn = true;
                        label_Dead.Text = "You die!!!!";
                        label_Dead.Visible = false;
                    }
                    break;
                case Keys.Left:
                    // player.Image = Character.stand_l;
                    if (GameOn)
                    {
                        left = true;
                        DriftJumpRight = false;
                    }
                    break;
                case Keys.Escape:
                    this.Close();
                    break;
                case Keys.Space:
                    if (label_Dead.Visible && label_Dead.Text.Contains("Pause"))
                    {
                        Reset();
                    }
                    else
                    {
                        if (!Isjumping && InAirNoCollosion(player))
                        {
                            if (DriftJumpRight)
                            {
                                player.Image = Character.jump_r;
                            }
                            else
                            {
                                player.Image = Character.jump_l;
                            }
                            if (Isjumping == false)
                            {
                                Isjumping = true;
                                Force = g;
                            }
                        }
                    }
                    break;
            }

            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
            if (Isjumping == false)
            {
                if (e.KeyCode == Keys.Space)
                {
                    Isjumping = true;
                    Force = g;
                }
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (GameOn)
            {
                switch (e.KeyCode)
                {
                    case Keys.Left:

                        {

                            left = false;
                            DriftJumpRight = false;
                            player.Image = Character.walk_l;
                        }
                        break;
                    case Keys.Right:

                        {
                            right = false;
                            DriftJumpRight = true;
                            player.Image = Character.walk_r;
                        }
                        break;
                }
            }
        }
        #endregion

        #region Timeer
        private void Tm_Gravity_Tick(object sender, EventArgs e)
        {
            //if(right == true)
            //{
            //    player.Left +=  10;
            //}
            //if(left == true)
            //{
            //    player.Left -= 10;
            //}
            //if(Isjumping == true)
            //{
            //    player.Top -= Force;
            //    Force -= 1;
            //}
            //if(player.Top + player.Height > pn_WorldFame.Height)
            //{
            //    player.Top = pn_WorldFame.Height - player.Height;
            //    Isjumping = false;
            //}
            //else
            //{
            //    player.Top += 5;
            //}
            if (GameOn)
            {
                if (right && player.Right <= pn_WorldFame.Width + 3 && !Collision_Left(player))
                {
                    player.Left += 5;
                }
                if (left && player.Location.X >= 3 && !Collision_Right(player))
                {
                    player.Left -= 5;
                }
            }

            if (Force > 0)
            {
                if (Collision_Bottom(player))
                {
                    Force = 0;
                }
                else
                {

                    player.Top -= Force;
                    Force--;
                }
            }
            else
            {
                Isjumping = false;
            }
        }

        private void Tm_Gravity_Tick_1(object sender, EventArgs e)
        {
            if (Isjumping && player.Location.Y + player.Height < pn_WorldFame.Height - 2 && !Collision_Top(player))
            {
                player.Top += 11;
            }
            if (!Isjumping && player.Location.Y + player.Height < pn_WorldFame.Height - 1)
            {
                foreach (PictureBox tar in WorldObjects)
                {
                    //   PictureBox ob = new PictureBox();
                    //   ob.Bounds = tar.Bounds;
                    //   if(!tar.Bounds.IntersectsWith(ob.Bounds))
                    if (!Collision_Top(player))
                    {
                        player.Top++;//pn_WorldFame.Height
                    }
                }

            }
            int x = 0;
            if (GameOn)
            {
                foreach (PictureBox ob in Bomb)
                {
                    if (ob != null)
                    {
                        try
                        {
                            if (!OutSideWorldFrame(ob))
                            {
                                if (ob.Name == "pb" || ob.Name == "Coin")
                                {
                                    ob.Top += 3;

                                }
                                if (ob.Name == "pbR")
                                {
                                    ob.Left += 3;
                                }
                                if (ob.Name == "pbL")
                                {
                                    ob.Left -= 3;
                                }
                            }
                            else
                            {
                                //if (OutSideWorldFrame(ob))
                                //{
                                //    Bomb[x] = null;
                                //    ob.Dispose();
                                //}
                                //if()
                                if (Expolsive[0] != null)
                                {
                                    Expolsive[0].Dispose();
                                    Expolsive[0] = null;
                                }
                                CreateBoom(ob.Location.X, ob.Location.Y);
                            }
                        }
                        catch (Exception) { }

                    }
                    x++;
                    if (x > 10)
                    {
                        x = 0;
                    }

                }
            }
        }
        
        #endregion

        #region Void -- Add
        public void Reset()
        {
            label_Dead.Visible = false;
            int x = 0;
            foreach (PictureBox bomb in Bomb)
            {
                if (bomb != null)
                {
                    bomb.Dispose();
                    Bomb[x] = null;
                }
                x++;
            }
            int x2 = 0;
            foreach (PictureBox exp in Expolsive)
            {
                if (exp != null)
                {
                    exp.Dispose();
                    Expolsive[x2] = null;
                }
                x2++;
            }
            GameOn = true;
            player.Visible = true;
            player.Location = new System.Drawing.Point(167, pn_WorldFame.Size.Height - 10 - player.Height);
            player.Image = Character.stand_r;
            Score = 0;
            bomsize = 16;
        }

        public void Dead()
        {
            player.Visible = false;
            label_Dead.Visible = true;
            GameOn = false;
        }

        public void CreateBoom(int x, int y)
        {
            PictureBox Boom = new PictureBox();
            Boom.Name = "Boom";
            Boom.BackColor = Color.Transparent;
            Boom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            Boom.Size = new System.Drawing.Size(bomsize, bomsize);
            Boom.Image = Enemy.Boom;
            Boom.Location = new System.Drawing.Point(x, y);
            pn_WorldFame.Controls.Add(Boom);
            Expolsive[0] = Boom;
        }
        #endregion

        #region Boom

        private void Tm_Anim_Tick(object sender, EventArgs e)
        {
            amin++;
            lb_HighScore.Text = "Hight Socre: " + Properties.Settings.Default.Highscore;
            lb_Bomb.Text = "Bomb: " + getBoomNum(Bomb);
            lb_Bomb.Text = "Bombs: " + getBoomNum(Bomb);
            if (right == true && amin % 15 == 0)
            {
                player.Image = Character.walk_r;
            }
            if (left == true && amin % 15 == 0)
            {
                player.Image = Character.walk_l;
            }

            foreach (PictureBox ob in Bomb)
            {
                if (ob != null)
                {
                    if (player.Bounds.IntersectsWith(ob.Bounds))
                        if (ob.Name == "Coin")
                        {
                            Score++;
                            ob.Dispose();
                        }
                        else
                        {
                            Dead();
                            ob.Dispose();
                        }
                }
            }
        }
        public String Boomdebug()
        {
            String t = "";
            for (int i = 0; i < 10; i++)
            {
                if (Bomb[i] == null)
                {
                    t += 0;
                }
                else
                {
                    t += 1;
                }
            }
            return t;
        }
        public int getBoomNum(PictureBox[] Arr)
        {
            int x = 0;
            foreach (PictureBox bomb in Arr)
            {
                if (bomb != null)
                    x++;
            }
            return x;
        }

        public int NextBoom(PictureBox[] Arr)
        {
            if (getBoomNum(Arr) < 10)
            {
                for (int i = 0; i < 10; i++)
                {
                    if (Arr[i] == null)
                        return i;
                }
            }
            Bomb[0] = null;
            return 0;
        }
       
       
        private void Tm_RandomBomb_Tick(object sender, EventArgs e)
        {
            Random rdm = new Random();
            if (GameOn || (!GameOn)&& !label_Dead.Visible)
            {
                if (getBoomNum(Bomb) == 10)
                {
                    tm_BombFalseSafe.Enabled = true;
                }
                else
                {
                    tm_BombFalseSafe.Enabled = false;
                    int NextSpot = NextBoom(Bomb);
                    switch (rdm.Next(1, 12))
                    {
                        case 8:
                            NextSpot = NextBoom(Bomb);
                            PictureBox ob = new PictureBox();
                            ob.Name = "pb";
                            ob.BackColor = Color.Transparent;
                            ob.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                            ob.Size = new System.Drawing.Size(16, 16);
                            ob.Image = Enemy.Bomb;
                            if (Score > 50)
                            {
                                ob.Location = new System.Drawing.Point(rdm.Next(player.Location.X + 10, player.Location.X - 10), 0);
                            }
                            else
                            {
                                ob.Location = new System.Drawing.Point(rdm.Next(0, pn_WorldFame.Height), 0);
                            }
                            pn_WorldFame.Controls.Add(ob);
                            Bomb[NextBoom(Bomb)]= ob ;
                            DebugLog += DateTime.Now + " :  Add bomb at " + NextSpot + "\n";
                            break;
                        case 11:
                            //NextSpot = NextBoom(Bomb);
                            //PictureBox coin = new PictureBox();
                            //coin.Name = "Coin";
                            //coin.BackColor = Color.Transparent;
                            //coin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                            //coin.Size = new System.Drawing.Size(20, 29);
                            //coin.Image = Coin.Coinssss;
                            //coin.Location = new System.Drawing.Point(rdm.Next(0, pn_WorldFame.Height), 0);
                            //pn_WorldFame.Controls.Add(coin);
                            //DebugLog += DateTime.Now + ": add coin at " + NextSpot + "\n";
                            break;
                    }

                }
            }
        }

        private void Tm_BombFalseSafe_Tick(object sender, EventArgs e)
        {
            DebugLog += DateTime.Now + "Bomb: -" + Boomdebug();
            for(int i = 0; i < 10; i++)
            {
                if (Expolsive[0] != null)
                {
                    Expolsive[0].Dispose();
                    Expolsive[0] = null;
                }
                if (Bomb[i] != null)
                {
                    Bomb[i].Dispose();
                    Bomb[i] = null;
                }
            }
            DebugLog += DateTime.Now + ": Had to Hard falseSafe.\n";
            DebugLog += DateTime.Now + ": Bomb - " + Boomdebug();
        }

        private void Tm_Sec_Tick(object sender, EventArgs e)
        {
            for(int i = 0; i < 10; i++)
            {
                if(Bomb[i]!=null&& Bomb[i].IsDisposed)
                {
                    Bomb[i] = null;
                }
            }
            lb_Score.Text = "Score: " + Score;
            if(!label_Dead.Visible)
            {
                Score++;
                bomsize++;
                if (tm_RandomBomb.Interval > 1)
                {
                    tm_RandomBomb.Interval--;
                }
                if (Score > Properties.Settings.Default.Highscore)
                {
                    Properties.Settings.Default.Highscore = Score;
                    Properties.Settings.Default.Save();
                }
            }
        }

        private void Tm_Bombremove_Tick(object sender, EventArgs e)
        {
            foreach(Control X in this.Controls)
            {
                if(X is PictureBox)
                {
                    if (X.Name == "Boom")
                    {
                        X.Dispose();
                    }
                }
            }
            foreach(PictureBox bom  in Expolsive)
            {
                if(bom != null)
                {
                    bom.Dispose();
                }
            }
        }
        #endregion
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Reset();
            WorldObjects[0] = pb_Block1;
            WorldObjects[1] = pb_Block2;
            WorldObjects[2] = pb_Block3;
            WorldObjects[3] = pb_Block4;
            WorldObjects[4] = pb_Block5;
            WorldObjects[5] = pb_Block6;
            WorldObjects[6] = pb_Block6;
            WorldObjects[7] = pb_Block7;
            WorldObjects[8] = pb_Block8;
            WorldObjects[9] = pb_Block9;
            
        }

    }
}
