//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UOWWithReporitoryPattern.ClassDiagram_SFNeptuneServer
{
    using System;
    using System.Collections.Generic;
    
    public partial class file
    {
        public int fid { get; set; }
        public Nullable<int> sid { get; set; }
        public Nullable<int> pid { get; set; }
        public Nullable<System.DateTime> starttime { get; set; }
        public Nullable<System.DateTime> endtime { get; set; }
        public string filename { get; set; }
        public Nullable<int> filesize { get; set; }
        public Nullable<int> resumefrom { get; set; }
        public Nullable<long> speed { get; set; }
        public string Discriminator { get; set; }
    }
}
