﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerieDLL_EF.Interface
{
    /*
     * Contient les méthodes particulière qui sont implémentées seulement dans certaines repository
     * (eg: GetByTxt implémenté dans toutes les répositories sauf dans SaisonRepository)
     */
    public interface IRepSpecials<T> where T:class
    {
        //Récupère la liste des objets de type T dont les champs,
        //spécifiés dans les implémentation contiennent la chaîne txt
        List<T> GetByTxt(string txt);
    }
}
