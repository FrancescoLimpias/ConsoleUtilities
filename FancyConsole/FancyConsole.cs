using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FancyConsole
{
    public class FancyConsole
    { 

        //True if there is an active FancyConsole instance
        private static bool Instanced { get; set; } = false;

        //Fancy Console PROPERTIES
        //window title
        private string WindowTitle {
            get
            {
                return Console.Title;
            } 
            set
            {
                Console.Title = value;
            }
        }
        //FancyConsole size
        private int width, height;
        
        public FancyConsole(string windowTitle, int width, int height)
        {
            //Check whether there already is an instanced FancyConsole
            if (Instanced)
            {
                throw new Exception("Only one FancyConsole instance allowed at a time");
            }

            //Toggle instanced
            Instanced = true;

            //Set properties
            WindowTitle = windowTitle;
            this.width = width;
            this.height = height;

        }
        ~FancyConsole()
        {
            //Toggle back instanced
            Instanced = false;
        }

    }
}
