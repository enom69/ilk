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
    
    public partial class HayvanatBahcesi
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HayvanatBahcesi()
        {
            this.Calisans = new HashSet<Calisan>();
            this.Hayvans = new HashSet<Hayvan>();
            this.Musteris = new HashSet<Musteri>();
        }
    
        public int HBid { get; set; }
        public string HBad { get; set; }
        public Nullable<int> HBtelefon { get; set; }
        public string HBadres { get; set; }
        public Nullable<int> HBacilis { get; set; }
        public Nullable<int> HBkapanis { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        private ICollection<Calisan> Calisans { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        private ICollection<Hayvan> Hayvans { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        private ICollection<Musteri> Musteris { get; set; }
    }
}
