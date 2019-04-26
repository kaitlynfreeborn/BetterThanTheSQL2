using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Shapes;

namespace Tower_Defense
{
    class animation
    { 
        public balloonPath()
        {
            NameScope.SetNameScope(this, new NameScope());

            // creating a balloon
            Oval aOval = new Oval();
            aOval.Width = 25;
            aOval.Height = 25;
            aOval.Fill = Brushes.Red;


        }
    }
}
