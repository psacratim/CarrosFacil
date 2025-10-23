using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CarrosFacil
{
    class Uploader
    {
        private static readonly HttpClient client = new HttpClient();
        private static readonly string urlServidor = "http://localhost/INFO_50/carrosfacil/";
        private static readonly string urlFotoFuncionario = urlServidor + "admin/upload_employee_photo.php";
        private static readonly string urlIconeCaracteristica = urlServidor + "admin/upload_car_feature_icon.php";

        public static async Task<string> EnviarImagem(string caminhoImagem)
        {
            try
            {
                using (var form = new MultipartFormDataContent())
                {
                    var stream = new FileStream(caminhoImagem, FileMode.Open, FileAccess.Read);
                    var content = new StreamContent(stream);
                    form.Add(content, "imagem", Path.GetFileName(caminhoImagem));

                    var response = await client.PostAsync(urlFotoFuncionario, form);
                    string resposta = await response.Content.ReadAsStringAsync();

                    return resposta;
                }
            }
            catch (Exception)
            {
                return "unknown_error";
            }
        }

        public static string CarregarImagemDoServidor(string imagem)
        {
            string caminho = imagem.Replace("../", "");
            return urlServidor+caminho;
        }
    }
}
