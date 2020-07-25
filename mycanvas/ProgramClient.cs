using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyCanvas;
using System.Threading.Tasks;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            MyCanvas.MyCanvas.CreateNewButton(100, 150, 200, 250);
            MyCanvas.MyCanvas.CreateNewButton(170, 180, 400, 500);
            MyCanvas.MyCanvas.CreateNewButton(190, 300, 450, 600);
            MyCanvas.MyCanvas.MoveButton(1,100, 150);


        }
    }
}
