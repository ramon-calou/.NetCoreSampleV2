using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotnetCore.Sample.DataContract.Abstractions;

namespace DotnetCore.Sample.DataContract.V1.Login
{
    public class LoginResponse : BaseResponse
    {
        /// <summary>
        /// 
        /// </summary>
        public string Token { get; set; }
    }
}