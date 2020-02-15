using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake
{
    public partial class Ground : Form
    {
        
        bool On_Off = true;

        int count = 0;
        
        string Direction = "right";

        List<PictureBox> BodyList;

        public void InitializeBodyList()
        {
            BodyList = new List<PictureBox>(30);

            BodyList.Add(Body1);

            BodyList.Add(Body2);

            BodyList.Add(Body3);

            BodyList.Add(Body4);

            BodyList.Add(Body5);

            BodyList.Add(Body6);

            BodyList.Add(Body7);
        }
        public Ground()
        {
            InitializeComponent();
            
            
            timer1.Interval = 100;//  ******TIMER***********
           
        }
        public bool BodyCrash()
        {
            for (int i = 0; i < BodyList.Count; i++)
            {
                if (HeadOfSnake.Location == BodyList[i].Location) ////
                    return true;
            }
            return false;
        }
        private void timer1_Tick(object sender, EventArgs e) //Eat Here
        {

            bool crash = false;

            crash = BodyCrash();

            if (crash)
            {
                Direction = "none";

                Go.Show();

                Go.Location = new Point(54, 196);

                On_Off = false;
                
                PlayAgain.Show();
            }

            // Catch food
            if (HeadOfSnake.Location.X >= Food.Location.X -20  && HeadOfSnake.Location.X <= Food.Location.X +10 &&
                HeadOfSnake.Location.Y >= Food.Location.Y - 20 && HeadOfSnake.Location.Y <= Food.Location.Y + 10)
            {
                AddBodyPart();

               FoodLocation();    
                
            }
            switch (Direction)
            {
                case "up": MoveUp(HeadOfSnake.Top, HeadOfSnake.Right);break;

                case "down": MoveDown(HeadOfSnake.Top, HeadOfSnake.Right);break;

                case "left": MoveLeft(HeadOfSnake.Top, HeadOfSnake.Right);break;

                case "right": MoveRight(HeadOfSnake.Top, HeadOfSnake.Right);break;
            }
        
        }

        private void HeadOfSnake_Click(object sender, EventArgs e)
        {
            
        }
      
        public void MoveUp(int x,int y)
        {
            if (On_Off)
            {
                HeadOfSnake.Location = new Point(HeadOfSnake.Left, HeadOfSnake.Top - 20);

                BodyMove(HeadOfSnake.Left, HeadOfSnake.Top + 20);
            }

            if (HeadOfSnake.Location.Y <= -1)//crash in wall
            {
                Direction = "none";

                Go.Show();

                Go.Location = new Point(54, 196);

                On_Off = false;

                PlayAgain.Show();
            }
        }

        public void MoveDown(int x,int y)
        {
            if (On_Off)
            {
                HeadOfSnake.Location = new Point(HeadOfSnake.Left, HeadOfSnake.Top + 20);

                BodyMove(HeadOfSnake.Left, HeadOfSnake.Top - 20);
            }

            if (HeadOfSnake.Location.Y >= 700)//crash in wall
            {
                Direction = "none";

                Go.Show();

                Go.Location = new Point(54, 196);

                On_Off = false;

                PlayAgain.Show();
            }
        }

        public void MoveLeft(int x, int y)
        {
            if (On_Off)
            {
                HeadOfSnake.Location = new Point(HeadOfSnake.Left - 20, HeadOfSnake.Top);

                BodyMove(HeadOfSnake.Left + 20, HeadOfSnake.Top);
            }
            if (HeadOfSnake.Location.X <= -1)//crash in wall
            {
                Direction = "none";

                Go.Show();

                Go.Location = new Point(54, 196);

                On_Off = false;

                PlayAgain.Show();
            }
        }

        public void MoveRight(int x, int y)
        {
            if (On_Off)
            {
                HeadOfSnake.Location = new Point(HeadOfSnake.Left + 20, HeadOfSnake.Top);

                BodyMove(HeadOfSnake.Left - 20, HeadOfSnake.Top);
            }
            if (HeadOfSnake.Location.X >= 700)
            {
                Direction = "none";

                Go.Show();

                Go.Location = new Point(54, 196);

                On_Off = false;

                PlayAgain.Show();
            }

        }
       

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            //capture up arrow key
            if (keyData == Keys.Up && HeadOfSnake.Location.X != BodyList[count].Location.X)
            {
                
                Direction = "up";

                return true;
            }
           
            //capture down arrow key
            if (keyData == Keys.Down && HeadOfSnake.Location.X != BodyList[count].Location.X)
            {
                Direction = "down";

                return true;

            }
            
            //capture left arrow key
            if (keyData == Keys.Left && HeadOfSnake.Location.Y != BodyList[count].Location.Y) 
            {
                Direction = "left";

                return true;
            }
            
            //capture right arrow key
            if (keyData == Keys.Right && HeadOfSnake.Location.Y != BodyList[count].Location.Y)
            {

                Direction = "right";

                return true;
            }
            if(keyData == Keys.Escape)
            {
                Application.Exit();
            }
        
            return base.ProcessCmdKey(ref msg, keyData);
        }

        public void FoodLocation()
        {
            bool bnf;

            int x, y;

            do
            {

                Random rundNum = new Random();

                do
                {
                    x = rundNum.Next(0, 687);

                } while (x % 20 == 0);
                do
                {
                    y = rundNum.Next(0, 687);

                } while (y % 20 == 0);

                bnf = BodyAndFood(x, y);

            } while (bnf);

            Food.Location = new Point(x, y);
          

        }
        public void BodyMove(int x, int y)
        {
            count++;

            if (count > BodyList.Count -1)

                count = 0;  

            var Tail = BodyList[count];

            Tail.Location = new Point(x, y);            

        }
        public bool BodyAndFood(int x,int y)
        {
            for (int i = 0; i < BodyList.Count ; i++)
            {
                if (BodyList[i].Location.X >= x - 20 && BodyList[i].Location.X <= x + 10 &&
                BodyList[i].Location.Y >= y - 20 && BodyList[i].Location.Y <= y + 10)

                    return true;
            }
            return false;
        }

        private void Food_Click(object sender, EventArgs e)
        {

        }

        private void Ground_Load(object sender, EventArgs e)
        {
            HeadOfSnake.Height = 20;

            HeadOfSnake.Width = 20;

            Body1.Height = 20;

            Body1.Width = 20;

            Body2.Height = 20;

            Body2.Width = 20;

            Body3.Height = 20;

            Body3.Width = 20;

            Body5.Height = 20;

            Body5.Width = 20;

            Body6.Height = 20;

            Body6.Width = 20;

            Body7.Height = 20;

            Body7.Width = 20;

            Body4.Height = 20;

            Body4.Width = 20;

            Body4.Height = 20;

            Body4.Width = 20;


            InitializeBodyList();

            Go.BackColor = Color.Transparent;

            Logo.BackColor = Color.Transparent;

            Title.BackColor = Color.Transparent;
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Start.Hide();

            timer1.Start();
        }

        private void PlayAgin_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
        private void  AddBodyPart()
        {
            PictureBox Snake_body = new PictureBox();

            Snake_body.Width = 20;

            Snake_body.Height = 20;

            Snake_body.BackColor = Color.Lime;

            BodyList.Add(Snake_body);

            this.Controls.Add(Snake_body);

        }
        
    }
}
