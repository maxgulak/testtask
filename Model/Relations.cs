//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DbFirstTest.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Relations
    {
        public int Id { get; set; }
        public int ChildId { get; set; }
        public int ParentId { get; set; }
        public byte QuantityOfComponents { get; set; }
    
        public virtual Component Component { get; set; }
    }
}