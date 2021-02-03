using DigitalOutsource.framework.pageojects.betway;
using DigitalOutsource.framework.pageojects.shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalOutsource.framework.pageojects
{
    public class webUI
    {
        public static registration_page betwayHome_page
        {
            get { return new registration_page(seleniumDriver.Webdriver); }
        }

        public static common_page common_page
        {
            get { return new common_page(seleniumDriver.Webdriver); }
        }

        public static headline_page headline_page
        {
            get { return new headline_page(seleniumDriver.Webdriver); }
        }




        

    }
}
