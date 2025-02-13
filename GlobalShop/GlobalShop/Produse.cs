//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GlobalShop
{
    using System;
    using System.Collections.Generic;
    
    public partial class Produse
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Produse()
        {
            this.CumparareItems = new HashSet<CumparareItem>();
        }
        public Produse(string Nume, decimal PretProdus, int Stoc, string Caracteristici, byte[] imagine, int CategorieId, int BrandId,int vanzatorId)
        {
            this.NumeProdus = Nume;
            this.Pret = PretProdus;
            this.Stoc = Stoc;
            this.Caracteristici = Caracteristici;
            this.Imagine = imagine;
            this.CategorieId = CategorieId;
            this.BrandId = BrandId;
            this.VanzatorId = vanzatorId;

        }

        public int ProdusId { get; set; }
        public Nullable<int> VanzatorId { get; set; }
        public Nullable<int> BrandId { get; set; }
        public Nullable<int> CategorieId { get; set; }
        public string NumeProdus { get; set; }
        public decimal Pret { get; set; }
        public int Stoc { get; set; }
        public string Caracteristici { get; set; }
        public byte[] Imagine { get; set; }
    
        public virtual Branduri Branduri { get; set; }
        public virtual CategoriiProduse CategoriiProduse { get; set; }
       
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CumparareItem> CumparareItems { get; set; }
        public virtual Vanzatori Vanzatori { get; set; }
    }
}
