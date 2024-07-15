using System.Net;
using System.Security.Cryptography;
using System.Text.Json;
using System.Text;

namespace SOC_Project.FunctionFiles
{
    public class WebTokenValidate
    {
        public static bool TokenValidateing(string token)
        {
            try
            {
                byte[] decryptedData;
                using (Aes aes = Aes.Create())
                {
                    byte[] key = Encoding.UTF8.GetBytes("424693eb479b9953");
                    byte[] iv = Encoding.UTF8.GetBytes("0049dA87db8945aq");
                    aes.Key = key;
                    aes.IV = iv;
                    ICryptoTransform decryptor = aes.CreateDecryptor(aes.Key, aes.IV);
                    var encryptedBytes = Convert.FromBase64String(token);
                    using (MemoryStream msDecrypt = new MemoryStream(encryptedBytes))
                    {
                        using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                        {
                            using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                            {
                                string decryptedMessage = srDecrypt.ReadToEnd();
                                decryptedData = Encoding.UTF8.GetBytes(decryptedMessage);
                            }
                        }
                    }
                }
                try
                {
                    string decryptCode = Encoding.UTF8.GetString(decryptedData);
                    JsonDocument json = JsonDocument.Parse(decryptedData);
                    DateTime requestTime = DateTime.Parse(json.RootElement.GetProperty("requestTime").GetString());
                    if (requestTime < DateTime.Now)
                    {
                        return false;
                    }
                    else if (requestTime >= DateTime.Now)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch (Exception e)
                {
                    /* EncryptingExceptionLog.webTokenDecryptError(e, "JSON_Convert");
                     stateCode = 8;*/
                    return false;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
                return true;
            }

            //for testing all incoming traffic is allow
            return true;
        }
    }
}