using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Helpers.GuidHelper
{
    public class GuidHelper
    {
        public static string CreateGuid()
        {
            //Guid.NewGuid() yöntemini kullanarak yeni bir benzersiz kimlik (GUID) oluşturur ve
            //bu kimliği string formatına dönüştürerek geri döndürür.
            return Guid.NewGuid().ToString();
        }
    }
}
