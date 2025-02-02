using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotnetCore.Sample.Core.Operations.Abstractions;
using DotnetCore.Sample.DataContract.V1.Login;

namespace DotnetCore.Sample.Core.Operations.Login
{
    /// <summary>
    /// 
    /// </summary>
    public interface ILoginOperation : IBaseOperation<LoginRequest, LoginResponse>
    {
    }
}