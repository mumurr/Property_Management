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
    
    public partial class w_user_paymoney
    {
        public int id { get; set; }
        public Nullable<int> house_id { get; set; }
        public Nullable<int> number { get; set; }
        public Nullable<decimal> price { get; set; }
        public Nullable<decimal> should_pay { get; set; }
        public Nullable<decimal> realy_pay { get; set; }
        public Nullable<decimal> no_pay { get; set; }
        public Nullable<System.DateTime> start_pay_time { get; set; }
        public Nullable<int> by_id { get; set; }
        public string title { get; set; }
    
        public virtual w_admin w_admin { get; set; }
        public virtual w_house w_house { get; set; }
    }
}
