﻿using Balta.ContentContext.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Balta.ContentContext
{
    public class Course : Content
    {
       
        public Course(string title, string url)
            : base(title, url)
        {

            Modules = new List<Module>();

        }

        public string Tag { get; set; }
        public IList<Module> Modules { get; set; }
        public int DurationInMinute { get; set; }
        public EcontentLevel Level { get; set; }




    }

}

