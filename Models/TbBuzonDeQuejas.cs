﻿using System;
using System.Collections.Generic;

namespace SGCFIEE.Models
{
    public partial class TbBuzonDeQuejas
    {
        public int IdTbBuzonDeQuejas { get; set; }
        public int? RProblema { get; set; }
        public int? RAlumno { get; set; }
        public int? RPeriodo { get; set; }
        public string Propuesta { get; set; }
        public string Sugerencia { get; set; }

        public virtual Alumnos RAlumnoNavigation { get; set; }
        public virtual TipoPeriodo RPeriodoNavigation { get; set; }
        public virtual CtProblemas RProblemaNavigation { get; set; }
    }
}
