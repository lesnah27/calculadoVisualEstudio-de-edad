﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace TareaIIIA
{
    public class ConectorBD
    {
        public static SqlConnection ObtnerCOnexion()
        {
            SqlConnection Conn = new SqlConnection("Data Source=.;Initial Catalog=TareaIII;Integrated Security=True");
            Conn.Open();

            return Conn;
        }

        }

    }



