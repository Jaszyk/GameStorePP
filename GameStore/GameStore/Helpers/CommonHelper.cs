﻿using GameStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameStore.Helpers
{
    public static class ExtensionMethods
    {
        public static string ToDisplayableDate(this DateTime date)
        {
            string month;
            switch (date.Month)
            {
                case 1: month = "stycznia"; break;
                case 2: month = "lutego"; break;
                case 3: month = "marca"; break;
                case 4: month = "kwietnia"; break;
                case 5: month = "maja"; break;
                case 6: month = "czerwca"; break;
                case 7: month = "lipca"; break;
                case 8: month = "sierpnia"; break;
                case 9: month = "września"; break;
                case 10: month = "października"; break;
                case 11: month = "listopada"; break;
                case 12: month = "grudnia"; break;
                default: month = "error"; break;
            }
            return string.Format("{0} {1} {2}", date.Day, month, date.Year);
        }

        public static List<PegiInfo> ToPegiInfo(this IEnumerable<Pegi> collection)
        {
            var result = new List<PegiInfo>(collection.Count());
            foreach (var pg in collection)
            { result.Add(PegiInfo.FromPegi(pg)); }
            return result;
        }

        public static bool IsAnyPropertySet(this Requirements reqs)
        {
            return !(string.IsNullOrWhiteSpace(reqs.OS)
                && string.IsNullOrWhiteSpace(reqs.CPU)
                && string.IsNullOrWhiteSpace(reqs.GPU)
                && string.IsNullOrWhiteSpace(reqs.HDD)
                && string.IsNullOrWhiteSpace(reqs.RAM)
                && string.IsNullOrWhiteSpace(reqs.DirectX));
        }
    }
}