using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace XamarinYSlim
{
    class RestClient
    {   
        public async Task<string> Get(string palabra) {
            try{
                HttpClient client = new HttpClient();
                var response = await client.GetAsync("http://bgeundam.000webhostapp.com/testSlim/index.php/cifrar/"+palabra);
                if (response.StatusCode == System.Net.HttpStatusCode.OK) {
                    var codificado = await response.Content.ReadAsStringAsync();
                    return codificado;
                }
            }
            catch {

            }
            return "Fallo";
        }
    }
}
