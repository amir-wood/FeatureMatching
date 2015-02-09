﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeatureMatching
{
    public class Utils
    {
        /// <summary>
        /// Write the given object in a debug line.
        /// </summary>
        /// <param name="content"></param>
        public static void DebugLine(object content)
        {
            System.Diagnostics.Debug.WriteLine(content);
        }
    }
}