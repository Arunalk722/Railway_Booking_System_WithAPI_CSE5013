using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace SLRD_ClientApp
{
    internal class SystemFuntion
    {
        public static string ApiURL = "https://localhost:7121/";
       // public static string Token = "SMd/TxSOGdDzRk6rT4G8WvQXvc4NQnbaQJTtk7MXZrrsxybAbpEm7MHK4r8VyAjwuVixBTjIPtwt2SKn1WtfywByqyW0uVMA0hGH/FbFT6zSB75KmZBjA0WcCnf3jP9PDO69It9Fr8DMZzRF9EgN70uGYRktrGNUxLjyUQc4wmSUF4CYQw0yikCQfO/c+sY5GA6EvRT+fTlT+7Hw0PSilxf/BDd242Mq0v7HZwI+WlnB2g7FQp/wLsvaiXcPbIrvNjJrCSbFOVJ+xMBm8+YRX/aMCDJYMIsjhlHCYAdo7PuNkKn8Ap7ethHCZFFTLR6P";
        public static string Token =null;
        //

        public static int UserId { get; set; } = 1;
        public static string UserName { get; set; }
        public static string Email { get; set; }
        public static string UserRole { get; set; }
        public static int UserRoleID { get; set; }

    }

    public class APICalling
    {
        public async static Task<string> PostMethodCalling(string requestUrl, object content)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    client.BaseAddress = new Uri(SystemFuntion.ApiURL);
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    var response = await client.PostAsJsonAsync(requestUrl, content);
                  //  response.EnsureSuccessStatusCode();

                    return await response.Content.ReadAsStringAsync();
                }
            }
            catch (Exception ex)
            {
                // Handle the exception appropriately (e.g., logging)
                return null;
            }
        }

        public async static Task<string> GetMethodCalling(string requestUrl)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    client.BaseAddress = new Uri(SystemFuntion.ApiURL);
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    var response = await client.GetAsync(requestUrl);
                    response.EnsureSuccessStatusCode();

                    return await response.Content.ReadAsStringAsync();
                }
            }
            catch (Exception ex)
            {
                // Handle the exception appropriately (e.g., logging)
                return null;
            }
        }

        public async static Task<string> DeleteMethodCalling(string requestUrl)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    client.BaseAddress = new Uri(SystemFuntion.ApiURL);
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    var response = await client.DeleteAsync(requestUrl);
                    response.EnsureSuccessStatusCode();
                    return await response.Content.ReadAsStringAsync();
                }
            }
            catch (Exception ex)
            {
                // Handle the exception appropriately (e.g., logging)
                return null;
            }
        }

        public async static Task<string> PutMethodCalling(string requestURl, object content)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    client.BaseAddress = new Uri(SystemFuntion.ApiURL);
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    var response = await client.PutAsJsonAsync(requestURl, content);
                    response.EnsureSuccessStatusCode();
                    return await response.Content.ReadAsStringAsync();
                }
            }
            catch (Exception ex)
            {
                // Handle the exception appropriately (e.g., logging)
                return null;
            }
        }



    }

   public class TokenCreat
    {
        public static bool CreateTokenKey(WebTokenRequestModel request)
        {
            try
            {
                var jsonString = JsonSerializer.Serialize(request);
                string encryptedText = "";

                byte[] key = Encoding.UTF8.GetBytes("424693eb479b9953");
                byte[] iv = Encoding.UTF8.GetBytes("0049dA87db8945aq");
                using (Aes aes = Aes.Create())
                {
                    aes.Key = key;
                    aes.IV = iv;
                    byte[] encrypted = null;
                    using (MemoryStream ms = new MemoryStream())
                    {
                        using (CryptoStream cs = new CryptoStream(ms, aes.CreateEncryptor(), CryptoStreamMode.Write))
                        {
                            byte[] bytesToEncrypt = Encoding.UTF8.GetBytes(jsonString);
                            cs.Write(bytesToEncrypt, 0, bytesToEncrypt.Length);
                        }
                        encrypted = ms.ToArray();
                    }
                    encryptedText = Convert.ToBase64String(encrypted);
                    SystemFuntion.Token = encryptedText;
                    return true;
                }
            }
            catch(Exception ex)
            {
                return false;
            }
        }
    }

    public class WebTokenRequestModel
    {
        public string userIP { get; set; }
        public string tokenKey { get; set; }
        public string tokenHash { get; set; }
        public string userName { get; set; }
        public string userGUID { get; set; }
        public DateTime requestTime { get; set; }
    }
}
