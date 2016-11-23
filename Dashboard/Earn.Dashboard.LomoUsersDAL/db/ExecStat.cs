//
// Copyright (c) Microsoft Corporation. All rights reserved. 
// Licensed under the MIT license. See LICENSE.txt file in the project root for full license information.
//

// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>

namespace Earn.Dashboard.LomoUsersDAL.db
{
    using System;
    using System.Collections.Generic;
    
    public partial class ExecStat
    {
        public byte[] sql_handle { get; set; }
        public int statement_start_offset { get; set; }
        public int statement_end_offset { get; set; }
        public Nullable<long> plan_generation_num { get; set; }
        public byte[] plan_handle { get; set; }
        public Nullable<System.DateTime> creation_time { get; set; }
        public Nullable<System.DateTime> last_execution_time { get; set; }
        public long execution_count { get; set; }
        public long total_worker_time { get; set; }
        public long last_worker_time { get; set; }
        public long min_worker_time { get; set; }
        public long max_worker_time { get; set; }
        public long total_physical_reads { get; set; }
        public long last_physical_reads { get; set; }
        public long min_physical_reads { get; set; }
        public long max_physical_reads { get; set; }
        public long total_logical_writes { get; set; }
        public long last_logical_writes { get; set; }
        public long min_logical_writes { get; set; }
        public long max_logical_writes { get; set; }
        public long total_logical_reads { get; set; }
        public long last_logical_reads { get; set; }
        public long min_logical_reads { get; set; }
        public long max_logical_reads { get; set; }
        public long total_clr_time { get; set; }
        public long last_clr_time { get; set; }
        public long min_clr_time { get; set; }
        public long max_clr_time { get; set; }
        public long total_elapsed_time { get; set; }
        public long last_elapsed_time { get; set; }
        public long min_elapsed_time { get; set; }
        public long max_elapsed_time { get; set; }
        public byte[] query_hash { get; set; }
        public byte[] query_plan_hash { get; set; }
        public Nullable<long> total_rows { get; set; }
        public Nullable<long> last_rows { get; set; }
        public Nullable<long> min_rows { get; set; }
        public Nullable<long> max_rows { get; set; }
        public byte[] statement_sql_handle { get; set; }
        public Nullable<long> statement_context_id { get; set; }
        public string text { get; set; }
        public string Statement { get; set; }
        public Nullable<long> ProcedureStart { get; set; }
        public string ShortText { get; set; }
    }
}