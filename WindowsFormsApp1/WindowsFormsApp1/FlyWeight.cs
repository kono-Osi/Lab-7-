using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Param
    {
        public int h;
        public Bitmap pic;
    }
    public class ParamOneCar : Param
    {
        public ParamOneCar()
        {
            h = 40;
            pic = new Bitmap(@"C:\Users\Sidor\OneDrive\Рабочий стол\картинки\828ad903db4e4b08.jpeg");
        }

    }
    public class ParamTwoCar : Param
    {
        public ParamTwoCar()
        {
            h = 60;
            pic = new Bitmap(@"C:\Users\Sidor\OneDrive\Рабочий стол\картинки\vtxnf.jpg");
        }
    }
    public class Car
    {
        public int x, y;     
        public Param p;      
        public string Direction { get; set; } 

        public Car()
        {
            x = 0;
            y = 0;
            Direction = "right";
        }

        public Car(int x, int y, Param p, string direction)
        {
            this.p = p;
            this.x = x;
            this.y = y;
            Direction = direction;
        }

   
        public void Move()
        {
            if (Direction == "right")
            {
                x += 5; 
            }
            else if (Direction == "left")
            {
                x -= 5;
            }
        }

 
        public override string ToString()
        {
            return $"Car at position: x = {x}, y = {y}, height = {p?.h}, direction = {Direction}";
        }
    }
}