﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

namespace FirstTestApp.Models
{
   public class GithubInputModel
    {
        public string UserName { get; set; }
        public string RepositoryName { get; set; }
    }

}
