//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Property_Management.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class w_installation
    {
        public int id { get; set; }
        public int sp_id { get; set; }
        public string name { get; set; }
        public string phone { get; set; }
        public string main_name { get; set; }
        public string contents { get; set; }
        public string title { get; set; }
    
        public virtual w_system_params w_system_params { get; set; }
    }
}