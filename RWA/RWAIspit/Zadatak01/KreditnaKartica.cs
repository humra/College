//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Zadatak01
{
    using System;
    using System.Collections.Generic;
    
    public partial class KreditnaKartica
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KreditnaKartica()
        {
            this.Racuns = new HashSet<Racun>();
        }
    
        public int IDKreditnaKartica { get; set; }
        public string Tip { get; set; }
        public string Broj { get; set; }
        public byte IstekMjesec { get; set; }
        public short IstekGodina { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Racun> Racuns { get; set; }
    }
}