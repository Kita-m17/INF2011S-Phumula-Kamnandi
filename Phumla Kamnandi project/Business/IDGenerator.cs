﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phumla_Kamnandi_project.Business
{
    public class IDGenerator
    {
        private static Random random = new Random();
        private static IDGenerator generator = new IDGenerator();
        private static string chars = "ABCDEFGHIJKLIMNOPQRSTUVWXYZabcdefghijklmnopqrstvwxyz0123456789";

        private IDGenerator() { }

        public static string makeID(int length = 8)
        {
            char[] id = new char[length];
            for (int i = 0; i < id.Length; i++)
            {
                id[i] = chars[random.Next(chars.Length)];
            }
            return new string(id);
        }

        public static string GenerateWithPrefix(string prefix, int length = 8)
        {
            return $"{prefix.ToUpper()}_{makeID(length)}";
        }

    }
}
