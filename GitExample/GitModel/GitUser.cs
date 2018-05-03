﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System.Runtime.Serialization;
namespace WebAPIClient

//namespace GitExample.GitModel
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    [DataContract(Name = "repo")]
    public class GitUser
    {


        [DataMember(Name = "id")]
        public string id { get; set; }

        [DataMember(Name = "login")]
        public Uri login { get; set; }

        [DataMember(Name = "html_url")]
        public Uri html_url { get; set; }

    }

}

