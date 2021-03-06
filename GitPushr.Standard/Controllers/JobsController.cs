/*
 * GitPushr.Standard
 *
 * This file was automatically generated by APIMATIC v2.0 ( https://apimatic.io )
 */
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Converters;
using GitPushr.Standard;
using GitPushr.Standard.Utilities;
using GitPushr.Standard.Http.Request;
using GitPushr.Standard.Http.Response;
using GitPushr.Standard.Http.Client;
using GitPushr.Standard.Exceptions;

namespace GitPushr.Standard.Controllers
{
    public partial class JobsController: BaseController
    {
        #region Singleton Pattern

        //private static variables for the singleton pattern
        private static object syncObject = new object();
        private static JobsController instance = null;

        /// <summary>
        /// Singleton pattern implementation
        /// </summary>
        internal static JobsController Instance
        {
            get
            {
                lock (syncObject)
                {
                    if (null == instance)
                    {
                        instance = new JobsController();
                    }
                }
                return instance;
            }
        }

        #endregion Singleton Pattern

        /// <summary>
        /// Returns the state of the job
        /// </summary>
        /// <param name="jobId">Required parameter: The Job Id you want to check status for</param>
        /// <return>Returns the Models.JobStatus response from the API call</return>
        public Models.JobStatus GetJob(string jobId)
        {
            Task<Models.JobStatus> t = GetJobAsync(jobId);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Returns the state of the job
        /// </summary>
        /// <param name="jobId">Required parameter: The Job Id you want to check status for</param>
        /// <return>Returns the Models.JobStatus response from the API call</return>
        public async Task<Models.JobStatus> GetJobAsync(string jobId)
        {
            //the base uri for api requests
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/jobs/{job-id}");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "job-id", jobId }
            });


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "APIMATIC 2.0" },
                { "accept", "application/json" }
            };
            _headers.Add("x-username", Configuration.XUsername);
            _headers.Add("x-password", Configuration.XPassword);

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.Get(_queryUrl,_headers);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request).ConfigureAwait(false);
            HttpContext _context = new HttpContext(_request,_response);
            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return APIHelper.JsonDeserialize<Models.JobStatus>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

    }
} 