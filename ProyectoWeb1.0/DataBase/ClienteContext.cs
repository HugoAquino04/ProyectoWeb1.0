using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProyectoWeb1._0.DataBase
{
    public class ClienteContext:DbContext
    {
        public ClienteContext():base("name=Cliente")
        {
            
        }
    }
}