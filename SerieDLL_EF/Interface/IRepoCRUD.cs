﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerieDLL_EF.Interface
{
    /*
     * Contient les méthodes CRUD classiques qui sont implémentées dans les répository
     * T correspond à une classe model
     */
    public interface IRepoCRUD<T> where T : class
    {
        //Récupère tous les objets de type T
        List<T> GetAll();

        //Récupère l'objet de type T dont l'id est égal à l'id passé en paramètre
        T GetById(int id);

        //Ajoute l'objet de type T dans la bdd
        void Add(T item);

        //Modifie l'objet de type T dans la bdd
        void Update(T item);

        //Supprime l'objet de type T dans la bdd
        void Delete(T item);

    }
}