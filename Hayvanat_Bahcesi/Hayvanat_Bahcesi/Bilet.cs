//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Hayvanat_Bahcesi
{
    using System;
    using System.Collections.Generic;
    
    public partial class Bilet
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Bilet()
        {
            this.Calisans = new HashSet<Calisan>();
        }
    
        public int Bid { get; set; }
        public Nullable<int> Bucret { get; set; }
        public Nullable<int> Btarih { get; set; }
        public Nullable<int> Mid { get; set; }
    
        private Musteri Musteri { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        private ICollection<Calisan> Calisans { get; set; }
    }
}
