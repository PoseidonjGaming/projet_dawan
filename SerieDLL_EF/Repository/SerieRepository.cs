﻿using projet_dawan.Models;
using SerieDLL_EF.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerieDLL_EF.Repository
{
    public class SerieRepository
    {
        public static List<Serie> GetAll()
        {
            using (BddprojetContext context = new BddprojetContext())
            {
                return context.Series.ToList();
            }
        }

        public static Serie GetById()
        {
            using (BddprojetContext context = new BddprojetContext())
            {
                return context.Series.ToList()[0];
            }
        }
    }
}
