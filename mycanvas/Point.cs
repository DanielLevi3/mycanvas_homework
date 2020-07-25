using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCanvas
{
     internal class Point
    {
        private int _x;
        private int _y;
        internal Point(int x,int y)
        {
            SetX(x);
            SetY(y);
        }
        internal int GetX()
        {
            return _x;
        }
        internal void SetX(int new_x)
        {
            if(new_x>0 && new_x<800)
            {
                this._x = new_x;
            }
            else
            {
                Console.WriteLine("Please enter a valid number between 0-800");
            }
        }
        internal int GetY()
        {
            return _y;
        }
        internal void SetY(int new_y)
        {
            if (new_y > 0 && new_y<600)
            {
                this._y = new_y;
            }
            else
            {
                Console.WriteLine("Please enter a valid number between 0-600");
            }
        }
        public override string ToString()
        {
            return $"[{base.ToString()}] X : {GetX()} Y: {GetY()}";
        }
    }
}
