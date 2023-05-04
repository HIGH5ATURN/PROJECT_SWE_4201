using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace IUTSMS_MAIN_
{
    public partial class Classic_Snake_Game : Form
    {




        private List<Circle> Snake = new List<Circle>();



        private Circle Food =new Circle();


        //maximum width the snake is allowed to travel.

        int maxWidth;



        //maximum height the snake is alowwed to travel.

        int maxHeight;



        //to record the score


        int score;


        //to record the highscore 


        int highscore;




        Random rand=new Random();


        //For the directions:

        bool goLeft, goRight, goUp, goDown;





        
        public Classic_Snake_Game()
        {
            InitializeComponent();



            //To get th3ee attributes of the Settings class we will initialize the Settings class at the start of the form;


            new Settings();



        }

        private void Classic_Snake_Game_Load(object sender, EventArgs e)
        {
            WinAPI.AnimateWindow(this.Handle, 500, WinAPI.BLEND);
        }



        //KeyIsUp means key is not pressed 

        private void KeyIsUp(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Left)  //Checks if left key is enabled
            {

                goLeft = false;


            }




            if (e.KeyCode == Keys.Right)
            {



                goRight = false;



            }


            if (e.KeyCode == Keys.Up)
            {


                goUp = false;




            }


            if (e.KeyCode == Keys.Down)
            {


                goDown = false;
            }




        }




        //KeyIsDown means key is pressed
        private void KeyIsDown(object sender, KeyEventArgs e)   
        {

            //Checks if left key is enabled and direction is not right because the snake 
            // cannot move right while going left


            if (e.KeyCode==Keys.Left && Settings.direction!="right")  
            {

                goLeft= true;


            }




            if(e.KeyCode==Keys.Right && Settings.direction!="left")
            {



                goRight= true;  



            }


            if(e.KeyCode==Keys.Up && Settings.direction!="down")
            {


                goUp= true;




            }


            if(e.KeyCode==Keys.Down && Settings.direction!="up" )
            {


                goDown= true;
            }



        }

        private void StartGame(object sender, EventArgs e)
        {


            RestartGame();  


            //It just restarts the game when tapping on the start button

        }

        private void TakeSnapShot(object sender, EventArgs e)
        {


            Label caption = new Label();


            caption.Text = "I scored: " + score + " and my Highscore is " + highscore + " on the Snake Game from IUTSIS";
            
            
            caption.Font = new Font("Ariel", 12, FontStyle.Bold);
            
            
            caption.ForeColor = Color.Purple;
            
            
            caption.AutoSize = false;
            
            
            caption.Width = picCanvas.Width;
            
            
            caption.Height = 30;
            
            
            caption.TextAlign = ContentAlignment.MiddleCenter;
            
            
            picCanvas.Controls.Add(caption);

            
            
            SaveFileDialog dialog = new SaveFileDialog();
            
            
            dialog.FileName = "Snake Game SnapShot IUTSMS";
            
            
            dialog.DefaultExt = "jpg";
            
            
            dialog.Filter = "JPG Image File | *.jpg";
            
            
            dialog.ValidateNames = true;



            if (dialog.ShowDialog() == DialogResult.OK)
            {
             
                
                int width = Convert.ToInt32(picCanvas.Width);
                
                
                int height = Convert.ToInt32(picCanvas.Height);
                
                
                Bitmap bmp = new Bitmap(width, height);
                
                
                picCanvas.DrawToBitmap(bmp, new Rectangle(0, 0, width, height));
                
                
                bmp.Save(dialog.FileName, ImageFormat.Jpeg);
                
                
                picCanvas.Controls.Remove(caption);
            }

        }

        private void GameTimerEvent(object sender, EventArgs e)
        {


            //setting the direction 



            if(goUp)
            {

                Settings.direction = "up";

            }



            if(goDown)
            {


                Settings.direction = "down";


            }



            if(goLeft)
            {



                Settings.direction= "left";



            }


            if(goRight)
            {



                Settings.direction= "right";



            }


            //end of setting up directions 




            for(int i=Snake.Count-1;i>=0;i--)
            {


                if(i==0)
                {
                    switch(Settings.direction)
                    {

                        case "left":


                            Snake[i].X--;

                            break;

                        case "right":


                            Snake[i].X++;


                            break;

                        case "up":


                            Snake[i].Y--;


                            break;

                        case "down":
                            

                            Snake[i].Y++;


                            break;
                    }


                    if (Snake[i].X<0)
                    {

                        Snake[i].X = maxWidth;

                    }

                    if (Snake[i].X>maxWidth)
                    {

                        Snake[i].X = 0;


                    }

                    if (Snake[i].Y<0)
                    {


                        Snake[i].Y = maxHeight;


                    }


                    if (Snake[i].Y>maxHeight)
                    {


                        Snake[i].Y = 0;


                    }




                    if (Snake[i].X==Food.X && Snake[i].Y==Food.Y)
                    {


                        EatFood();
                      

                    }

                    for(int j=1;j<Snake.Count;j++)
                    {


                        if (Snake[i].X == Snake[j].X && Snake[i].Y == Snake[j].Y)
                        {


                            GameOver();


                        }
                    }




                   
                }



                else
                {

                    Snake[i].X = Snake[i - 1].X;


                    Snake[i].Y = Snake[i - 1].Y;



                }



                picCanvas.Invalidate();

            }

        }

        private void UpdatePictureBoxGraphics(object sender, PaintEventArgs e)
        {




            Graphics canvas = e.Graphics;

            //this basically links the paintevent to the canvas 



            Brush snakecolour;


            for(int i=0;i<Snake.Count;i++)
            {

                if(i==0)  //It means the head
                {


                    snakecolour = Brushes.Black; 


                }



                else
                {

                    snakecolour = Brushes.DarkBlue;


                }


                canvas.FillEllipse(snakecolour, new Rectangle
                    (


                    Snake[i].X * Settings.width,



                    Snake[i].Y * Settings.height,



                    Settings.width,Settings.height



                    ));
                
                    



            }




            canvas.FillEllipse(Brushes.Red, new Rectangle
                   (


                   Food.X * Settings.width,



                   Food.Y * Settings.height,



                   Settings.width, Settings.height



                   ));




        }







        private void RestartGame()
        {


            //the settings.width is the width of the snake and it cannot be larger than the picCanvas width


            maxWidth = picCanvas.Width / Settings.width -1;  
            
            
           

            maxHeight = picCanvas.Height / Settings.height -1;



            // The previous attributes of the snake which was on the snake list will be cleared 


            Snake.Clear();  


            Start_button.Enabled = false;

            snap_button.Enabled = false;


            //If the start button or snap buttons are enabled then the focus will be on these button and we cannot use 

            // use the button up or down etc



            score = 0;

            txtScore.Text = "SCORE: " + score;




            Circle head = new Circle { X= 10, Y = 5 };


            Snake.Add(head);

            //Now in the snake list the head is in index 0;


            for(int i=0;i<10;i++)
            {


                Circle body=new Circle();


                Snake.Add(body);


            }

            //this loop creates the body of the snake and adds each body circle to the next of head and correspondingly;



            Food = new Circle { X = rand.Next(2, maxWidth), Y = rand.Next(2, maxHeight) };



            // The food will be at a random position between 2 and the max width and height at the starting of the game;



            gameTimer.Start();









        }





        private void EatFood()
        {


            txtScore.Text = "";


            score += 1;

            txtScore.Text += "SCORE:" + score;


            Circle body = new Circle
            {
                X = Snake[Snake.Count - 1].X,

                Y = Snake[Snake.Count - 1].Y,
            };


            Snake.Add(body);


            Food = new Circle { X = rand.Next(2, maxWidth), Y = rand.Next(2, maxHeight) };

        }





        private void GameOver()
        {


            gameTimer.Stop();



            Start_button.Enabled = true;



            snap_button.Enabled = true;


            if(score>highscore)
            {


                highscore= score;

                txtHighscore.Text = "HIGHSCORE: " + Environment.NewLine + highscore;

                txtHighscore.ForeColor = Color.Maroon;

                txtHighscore.TextAlign=ContentAlignment.MiddleCenter;

            }

        }






    }
}
