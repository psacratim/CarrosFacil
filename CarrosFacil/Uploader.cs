﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarrosFacil
{
    class Uploader
    {
        private static readonly string urlServidor = "http://localhost/INFO_50/carrosfacil/";
        private static readonly string urlUploadImage = urlServidor + "admin/upload_image.php";

        public static async Task<string> EnviarImagem(string caminhoImagem)
        {
            try
            {
                HttpClient client = new HttpClient();
                using (var form = new MultipartFormDataContent())
                {
                    var stream = new FileStream(caminhoImagem, FileMode.Open, FileAccess.Read);
                    var content = new StreamContent(stream);
                    form.Add(content, "imagem", Path.GetFileName(caminhoImagem));

                    var response = await client.PostAsync(urlUploadImage, form);
                    string resposta = await response.Content.ReadAsStringAsync();

                    return resposta.Replace("\"", "");
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
            if (caminho != "")
            {
                return urlServidor + caminho;
            }

            return "";
        }
    }
}
