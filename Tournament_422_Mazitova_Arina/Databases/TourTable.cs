//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Tournament_422_Mazitova_Arina.Databases
{
    using System;
    using System.Collections.Generic;
    
    public partial class TourTable
    {
        public int ID { get; set; }
        public Nullable<int> Match_Count { get; set; }
        public Nullable<int> Points { get; set; }
        public Nullable<int> ID_Player { get; set; }
        public string Status { get; set; }
    
        public virtual Player Player { get; set; }
    }
}
