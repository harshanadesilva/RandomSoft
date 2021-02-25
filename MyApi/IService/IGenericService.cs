﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyApi.IService
{
    public interface IGenericService<T>
    {
        List<T> GetAll();

        T GetById(int id);

        List<T> Insert(T item);

        List<T> Delete(int id);
    }
}