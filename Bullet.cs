using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zombie_gampeplay_work;
using System.Drawing;
using System.Windows.Forms;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Zombie_gampeplay_work
{
    public class Bullet
    {
public  Vector directionVector = new Vector(0, 0);
public  Vector bulletPosition = new Vector(0, 0);

        private Form form; //for contructor

        private int BulletTimerspeed = 50; //only for interval(not the real bullet speed)
        private PictureBox bullet = new PictureBox();
        public System.Windows.Forms.Timer bulletTimer = new System.Windows.Forms.Timer();
        public Bullet(Form form)
        {
            this.form = form; //contructor to load on the form
           
        }

        public void MakeBullet(Vector BULLETPOSITION, Vector DIRECTIONVECTOR)
        {
            directionVector = DIRECTIONVECTOR;
            bulletPosition = BULLETPOSITION;
            bullet.BackColor = Color.Black;
            bullet.Size = new Size(10, 5);
            bullet.Tag = "bullet";
            bullet.BringToFront();
            form.Controls.Add(bullet);
            bulletTimer.Enabled = true;

            
            
            bulletTimer.Interval = BulletTimerspeed;
            bulletTimer.Tick += BulletTimerEvent;


        }
        public void Pause()
        {
            
            bulletTimer.Enabled = true;
            bullet.Dispose();
        }

        public void Resume()
        {
            bulletTimer.Enabled = false;
            
        }
        private void BulletTimerEvent(object sender, EventArgs e)
        {
            bulletPosition.X += directionVector.X ;
            bulletPosition.Y += directionVector.Y ;

            if (bullet.Parent == null)
            {

                bulletTimer.Stop();
                bulletTimer.Dispose();
                bullet.Dispose();
               
                return;
            }


                if (bulletPosition.X < 0 || bulletPosition.X > bullet.Parent.ClientSize.Width ||
       bulletPosition.Y < 0 || bulletPosition.Y > bullet.Parent.ClientSize.Height)
                {
                    bulletTimer.Stop();
                    bulletTimer.Dispose();
                    bullet.Dispose();
                   

                }

                else
                {
                    bullet.Left = (int)bulletPosition.X;
                    bullet.Top = (int)bulletPosition.Y;  //cast for picturebox value and postional speed

                }
        }

    }





    }


