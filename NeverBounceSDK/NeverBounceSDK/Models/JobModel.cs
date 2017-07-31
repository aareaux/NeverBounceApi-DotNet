﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeverBounce.Models
{
    public class JobSearchRequestModel
    {
        public string key { get; set; }
        public int job_id { get; set; }
        public string filename { get; set; }
        public int completed { get; set; }
        public int processing { get; set; }
        public int indexing { get; set; }
        public int failed { get; set; }
        public int manual_review { get; set; }
        public int unpurchased { get; set; }
        public int page { get; set; }
        public int items_per_page { get; set; }
    }
    public class JobSearchResponseModel
    {
        public string status { get; set; }
        public int total_results { get; set; }
        public int total_pages { get; set; }
        public JobSearchQuery query { get; set; }
        public List<JobSearchResult> results { get; set; }
        public int execution_time { get; set; }
    }
    public class JobSearchQuery
    {
        public string job_id { get; set; }
        public int page { get; set; }
        public int items_per_page { get; set; }

    }

    public class JobSearchResult
    {
        public int id { get; set; }
        public string status { get; set; }
        public string filename { get; set; }
        public string created { get; set; }
        public object started { get; set; }
        public object finished { get; set; }
        public int total_records { get; set; }
        public int total_billable { get; set; }
        public object total_processed { get; set; }
        public object total_valid { get; set; }
        public int total_invalid { get; set; }
        public object total_catchall { get; set; }
        public object total_disposable { get; set; }
        public object total_unknown { get; set; }
        public object total_duplicates { get; set; }
        public object total_bad_syntax { get; set; }
        public int bounce_estimate { get; set; }
        public int percent_complete { get; set; }
    }
    public class JobCreateRequestModel
    {
        public string key { get; set; }
        public string input_location { get; set; }
        public string filename { get; set; }
        public int auto_start { get; set; }
        public int auto_parse { get; set; }
        public List<Input> input { get; set; }
        public string inputRemote_url { get; set; }

        public Int32 auto_run { get; set; }
        public Nullable<Int32> run_sample { get; set; }

    }
    public class Input
    {
        public string id { get; set; }
        public string email { get; set; }
        public string name { get; set; }
    }
    public class JobCreateResponseModel
    {
        public string status { get; set; }
        public int job_id { get; set; }
        public string message { get; set; }
        public int execution_time { get; set; }
    }
    public class JobParseRequestModel
    {
        public string key { get; set; }
        public int job_id { get; set; }
        public int auto_start { get; set; }


    }
    public class JobParseResponseModel
    {
        public string status { get; set; }
        public string queue_id { get; set; }
        public int execution_time { get; set; }
        public string message { get; set; }
    }
    public class JobStartRequestModel
    {
        public int job_id { get; set; }
        public string run_sample { get; set; }
        public string key { get; set; }
    }
    public class JobStartResponseModel
    {

        public string status { get; set; }
        public string queue_id { get; set; }
        public int execution_time { get; set; }
        public string message { get; set; }

    }
    public class JobStatusRequestModel
    {
        public string key { get; set; }
        public int job_id { get; set; }
    }
    public class JobStatusResponseModel
    {
        public string message { get; set; }
        public string status { get; set; }
        public string id { get; set; }
        public string filename { get; set; }
        public string created { get; set; }
        public object started { get; set; }
        public object finished { get; set; }
        public int total_records { get; set; }
        public int total_billable { get; set; }
        public object total_processed { get; set; }
        public object total_valid { get; set; }
        public int total_invalid { get; set; }
        public object total_catchall { get; set; }
        public object total_disposable { get; set; }
        public object total_unknown { get; set; }
        public object total_duplicates { get; set; }
        public object total_bad_syntax { get; set; }
        public int bounce_estimate { get; set; }
        public int percent_complete { get; set; }
        public string job_status { get; set; }
        public int execution_time { get; set; }
    }
    public class JobResultsRequestModel
    {
        public int job_id { get; set; }
        public string key { get; set; }
        public int page { get; set; }
        public int items_per_page { get; set; }
    }
    public class JobResultsResponseModel
    {
        public string status { get; set; }
        public int total_results { get; set; }
        public int total_pages { get; set; }
        public JobResultsQuery query { get; set; }
        public List<JobResult> results { get; set; }
        public int execution_time { get; set; }
        public string message { get; set; }
    }
    public class JobResult
    {
        public JobResultsData data { get; set; }
        public JobResultsVerification verification { get; set; }
    }
    public class JobResultsQuery
    {
        public int job_id { get; set; }
        public int valids { get; set; }
        public int invalids { get; set; }
        public int disposables { get; set; }
        public int catchalls { get; set; }
        public int unknowns { get; set; }
        public int page { get; set; }
        public int items_per_page { get; set; }
    }
    public class JobResultsData
    {
        public string email { get; set; }
        public string id { get; set; }
        public string name { get; set; }
    }
    public class JobResultsAddressInfo
    {
        public string original_email { get; set; }
        public string normalized_email { get; set; }
        public string addr { get; set; }
        public string alias { get; set; }
        public string host { get; set; }
        public string fqdn { get; set; }
        public string domain { get; set; }
        public string subdomain { get; set; }
        public string tld { get; set; }
    }
    public class JobResultsVerification
    {
        public string status { get; set; }
        public string result { get; set; }
        public List<String> flags { get; set; }
        public string suggested_correction { get; set; }
        public JobResultsAddressInfo address_info { get; set; }
    }
    public class JobDeleteRequestModel
    {
        public string key { get; set; }
        public int job_id { get; set; }
    }
    public class JobDeleteResponseModel
    {
        public string status { get; set; }
        public int execution_time { get; set; }
        public string message { get; set; }
    }

    public class JobDownloadRequestModel
    {
        public string key { get; set; }
        public int job_id { get; set; }
        public bool valids { get; set; }
        public bool invalids { get; set; }
        public bool catchalls { get; set; }
        public bool unknowns { get; set; }
        public bool disposables { get; set; }
        public bool include_duplicates { get; set; }
        public bool email_status { get; set; }
    }

}