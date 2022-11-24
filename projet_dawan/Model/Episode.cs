﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet_dawan.Model
{
    public class Episode
    {
		private int id;
		private Saison saison_id;
		private string nom;
		private string resume;
		private DateTime date_prem_diff;

		public DateTime DatePremDiff
		{
			get { return date_prem_diff; }
			set { date_prem_diff = value; }
		}


		public string Resume
		{
			get { return resume; }
			set { resume = value; }
		}


		public string Nom
		{
			get { return nom; }
			set { nom = value; }
		}


		public Saison SaisonId
		{
			get { return saison_id; }
			set { saison_id = value; }
		}


		public int Id
		{
			get { return id; }
			set { id = value; }
		}

		public Episode() { }

	}
}
