﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestModels;

namespace TestController.DAO
{
    public interface AlumnoDAO : GenericoDao<Alumno, int>
    {
       
    }
}

