//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _21._106_10_Restoran.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Products
    {
        public int IdProducts { get; set; }
        public int IdIngredients { get; set; }
        public int Quantity { get; set; }
        public int IdProvide { get; set; }
    
        public virtual Ingredients Ingredients { get; set; }
        public virtual Provider Provider { get; set; }
    }
}
