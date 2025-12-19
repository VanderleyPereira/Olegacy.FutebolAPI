using System;
using System.Threading.Tasks;


namespace Olegacy.FutebolAPI
{
    class MainClass
    {
        public static object RestService { get; private set; }

        static async Task Main(string[] args)
        {
            try
            {
                var cepService = RestService.For<ICepApiService>("https://viacep.com.br/");
                

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro na consulta Otario... {ex.Message}");
            }
        }
    }
}