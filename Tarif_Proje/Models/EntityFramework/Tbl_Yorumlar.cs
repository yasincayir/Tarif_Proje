//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Tarif_Proje.Models.EntityFramework
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tbl_Yorumlar
    {
        public short ID { get; set; }
        public string ADSOYAD { get; set; }
        public string MAİL { get; set; }
        public Nullable<System.DateTime> TARİH { get; set; }
        public Nullable<bool> ONAY { get; set; }
        public string ICERIK { get; set; }
        public Nullable<short> YemekID { get; set; }
    
        public virtual Tbl_Yemekler Tbl_Yemekler { get; set; }
    }
}