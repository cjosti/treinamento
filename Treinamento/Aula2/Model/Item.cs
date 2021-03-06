﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Aula2.Model
{
    public class Item
    {
        public decimal Valor { get; set; }
        public DateTime Data { get; set; }

        public override string ToString()
        {
            //var culture = CultureInfo.GetCultureInfo("en-US");

            //return $"{Data.ToString()} - {Valor.ToString("C2", culture)}";
            return $"{Data.ToString("dd-MM-yyyy HH:mm")} - {Valor.ToString("C2")}";
        }

    }
}
