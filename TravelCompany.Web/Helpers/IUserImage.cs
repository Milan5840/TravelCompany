using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TravelCompany.Web.Helpers
{
    public interface IUserImage
    {
        Task<string> UploadImageAsync(IFormFile imageFile, string folder);
    }
}
