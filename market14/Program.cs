﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace market14
{
    static class Program
    {
        /// <summary>
        /// Uygulamanın ana girdi noktası.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Category_form());
        }
    }
}
