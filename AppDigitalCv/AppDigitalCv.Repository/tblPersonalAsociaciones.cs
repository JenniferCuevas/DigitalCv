//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AppDigitalCv.Repository
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblPersonalAsociaciones
    {
        public int idPersonal { get; set; }
        public int idAsociacion { get; set; }
        public Nullable<System.DateTime> dteFecha { get; set; }
        public string strTipoParticipacion { get; set; }
    
        public virtual catAsociaciones catAsociaciones { get; set; }
        public virtual tblPersonal tblPersonal { get; set; }
    }
}
