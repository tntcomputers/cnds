﻿using System;
using System.Runtime.Serialization;

namespace Lpp.CNDS.DTO.Requests
{
    /// <summary>
    /// DTO For Resubmitting a Route
    /// </summary>
    [DataContract]
    public class ResubmitRouteDTO
    {
        /// <summary>
        /// Gets or Sets the ResponseID for the RequestDataMart
        /// </summary>
        [DataMember]
        public Guid ResponseID { get; set; }
        /// <summary>
        /// Gets or Sets the RequestDatamartID 
        /// </summary>
        [DataMember]
        public Guid RequestDatamartID { get; set; }
        /// <summary>
        /// Gets or Sets the Message for the Resubmit
        /// </summary>
        [DataMember]
        public string Message { get; set; }
    }
}