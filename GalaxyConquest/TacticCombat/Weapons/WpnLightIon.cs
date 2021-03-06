﻿using System.Drawing;
using System.Windows.Forms;

namespace GalaxyConquest.Tactics
{
    public class WpnLightIon : Weapon
    {
        public WpnLightIon()
        {
            attackPower = 15;
            attackRange = 4;
            energyСonsumption = 1;
            cage = 2;
            shotsleft = cage;
        }
        public override string description()
        {
            return "\nЛёгкая ионная пушка\nВыстрелов: " + shotsleft;
        }
        public override void drawAttack(int x, int y, int targetx, int targety, ref System.Drawing.Bitmap bmap, System.Media.SoundPlayer player, ref PictureBox pictureMap, ref System.Drawing.Bitmap bmBackground, ref System.Drawing.Bitmap bmFull)
        {
            System.Threading.Thread.Sleep(150);
            player.SoundLocation = @"Sounds/iongun2.wav";

            Graphics g = Graphics.FromImage(bmap);
            Rectangle rect;  //  --- размер изображения
            Bitmap oldImage;  //  --- переменная, в которую его засунем
            player.Play();

            SolidBrush brush1 = new SolidBrush(Color.CadetBlue);
            SolidBrush brush = new SolidBrush(Color.CornflowerBlue);

            int dx, dy;
            
            dx = (targetx - x) / 10;
            dy = (targety - y) / 10;

            for (int i = 0; i < 10; i++)
            {
                // --- 1) находим размер изображения
                rect = new Rectangle(0, 0, bmap.Width, bmap.Height); 
                // --- 2) клонируем наш битмап
                oldImage = bmap.Clone(rect, bmap.PixelFormat);

                g.FillEllipse(brush, x - 5 + dx * i, y - 5 + dy * i, 10, 10);
                g.FillEllipse(brush1, x - 3 + dx * i, y - 3 + dy * i, 6, 6);

                pictureMap.Image = bmap;
                pictureMap.Refresh();

                // --- 3) отрисовываем тот битмам, который сохранили выше
                g.DrawImage(oldImage, 0, 0);

                //System.Threading.Thread.Sleep(15);
            } 
        }
    }
}
