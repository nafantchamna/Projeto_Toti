using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Site_Sistema_Aluno.Models
{
    public class contexto: DbContext
    {
        DbSet<toti> toti { get; set; }
    }
}