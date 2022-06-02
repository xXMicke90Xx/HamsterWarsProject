using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamsterWars.Shared.Interfaces
{
    public interface IHamsterImage
    {
        Task<string> UploadProductImage(MultipartFormDataContent content);
    }
}
