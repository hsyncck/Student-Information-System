//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BilgiDeposu.Models.Entitiy
{
    using System;
    using System.Collections.Generic;
    
    public partial class TBLOGRENCI
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TBLOGRENCI()
        {
            this.TBLCEZALAR = new HashSet<TBLCEZALAR>();
            this.TBLHAREKET = new HashSet<TBLHAREKET>();
            this.TBLNOTLAR = new HashSet<TBLNOTLAR>();
        }
    
        public int ID { get; set; }
        public string AD { get; set; }
        public string SOYAD { get; set; }
        public string MAIL { get; set; }
        public string KULLANICIADI { get; set; }
        public string SIFRE { get; set; }
        public string FOTOGRAF { get; set; }
        public string TELEFON { get; set; }
        public Nullable<byte> OKUL { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLCEZALAR> TBLCEZALAR { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLHAREKET> TBLHAREKET { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLNOTLAR> TBLNOTLAR { get; set; }
        public virtual TBLBOLUM TBLBOLUM { get; set; }
    }
}