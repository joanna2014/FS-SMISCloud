//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace FreeSun.FS_SMISCloud.Server.CloudApi.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class BATCH_JOB_EXECUTION_CONTEXT
    {
        public long JOB_EXECUTION_ID { get; set; }
        public string SHORT_CONTEXT { get; set; }
        public string SERIALIZED_CONTEXT { get; set; }
    
        public virtual BATCH_JOB_EXECUTION BATCH_JOB_EXECUTION { get; set; }
    }
}