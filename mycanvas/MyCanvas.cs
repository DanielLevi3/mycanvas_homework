using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCanvas
{
    public class MyCanvas
    {
        public const int _MaxWidth= 800;
        public const int _MaxHeight = 600;
        private static int _buttonIndex = 0;
        static MyButton[] buttons = new MyButton[_MaxButtons];
        private static int _MaxButtons = 3;
        public static bool CreateNewButton(int x1,int y1,int x2,int y2)
        {
            if(_buttonIndex==_MaxButtons)
            {
                return false;
            }
            buttons[_buttonIndex] = new MyButton(new Point(x1, y1), new Point(x2, y2));
            _buttonIndex++;
            return true;
        }
        public static bool MoveButton(int buttonNumber,int x , int y)
        {
            buttons[buttonNumber] = new MyButton(new Point(x, y), new Point(x, y));
            if (buttonNumber < 0 && buttonNumber > 3)
            {
                return false;
            }
                return true;
        }
        public static bool DeleteLastButton()
        {
                if (buttons.Length== 0)
                {
                    return false;
                }
                if (buttons.Length <= 3)
                {
                _buttonIndex--;
                }
            return true;
        }
        public static void ClearAllButtons()
        {
            if(buttons.Length>0 && buttons.Length<3)
            {
                _buttonIndex = 0;
                Console.WriteLine("All buttons deleted");
            }    
        }
        public static int GetCurrentNumberOfButtons()
        {
            return _buttonIndex;
        }
        public static int GetMaxNumberOfButtons()
        {
            return _MaxButtons;
        }
        public static int GetMaxWidthOfAButton()
        {
            if(buttons.Length==0)
            {
                return 0;
            } 
            int biggestWidth = 0;
            for (int i = 0; buttons.Length>i;i++)
            {
                if (buttons[i].GetWidth() > biggestWidth)
                {
                    biggestWidth = buttons[i].GetWidth();
                }
            }
            return biggestWidth;
        }
        public static int GetMaxHeightOfAButton()
        {
            if (buttons.Length == 0)
            {
                return 0;
            }
            int biggestHeight = 0;
            for (int i = 0; buttons.Length > i; i++)
            {
                if (buttons[i].GetHeight() > biggestHeight)
                {
                    biggestHeight = buttons[i].GetHeight();
                }
            }
            return biggestHeight;
        }
        public static bool IsPointInsideAButton()
        {
            return false;
        }
        public static bool CheckIfAnyButtonIsOverlapping()
        {
            return false;
        }
        public static int Print()
        {
            int area = 0;
            for(int i = 0;buttons.Length>i; i++)
            {
                area = buttons[i].GetWidth()*buttons[i].GetHeight();
            }
            return area;
        }
        public override string ToString()
        {
            return $"[{base.ToString()}] ";
        }
    }
}
