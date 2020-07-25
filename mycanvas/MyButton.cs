using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCanvas
{
      internal class MyButton
    {
        protected Point _topLeft;
        protected Point _bottomRight;
        private int _width;
        private int _height;
        internal MyButton(Point topLeft, Point bottomRight)
        {
            this._topLeft = topLeft;
            this._bottomRight = bottomRight;
           
        }
        internal int GetWidth()
        {
            return _width;
        }
        internal int GetHeight()
        {
            return _height;
        }
        internal bool SetTopLeft(Point point)
        {
            point.SetX(this._width);
            point.SetY(this._height);
            if (this._height > this._width)
            {
                return true;
            }
            else
                return false;
        }
        internal bool SetBottomRight(Point point)
        {
            point.SetX(this._width);
            point.SetY(this._height);
            if (this._width > this._height)
            {
                return true;
            }
            else
                return false;
        }
        internal Point GetTopLeft(Point point)
        {
            return _topLeft;
        }
        internal Point GetBottomRight(Point point)
        {
            return _bottomRight;
        }

        public override string ToString()
        {
            return $"[{base.ToString()}]= TopLeft: {_topLeft}, BottomRight : {_bottomRight}, Width : {_width} "
                + $"Height : {_height}";
        }
    }
}
