//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AdventureWorks.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class ErrorLog
    {
        public int ErrorLogID { get; set; }
        public System.DateTime ErrorTime { get; set; }
        public string UserName { get; set; }
        public int ErrorNumber { get; set; }
        public Nullable<int> ErrorSeverity { get; set; }
        public Nullable<int> ErrorState { get; set; }
        public string ErrorProcedure { get; set; }
        public Nullable<int> ErrorLine { get; set; }
        public string ErrorMessage { get; set; }
    }
}
