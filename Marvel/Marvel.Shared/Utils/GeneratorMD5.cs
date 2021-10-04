using System;
using System.Collections.Generic;
using System.Text;
#if __WASM__
using Uno.Foundation;
#endif

namespace Marvel.Utils
{
    public static class GeneratorMD5
    {
        public static string CreateMD5(string input)
        {
            // Use input string to calculate MD5 hash
            using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
            {
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                // Convert the byte array to hexadecimal string
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("X2"));
                }
                return sb.ToString();
            }
        }


        public static string CreateHASH(out string timeSpan)
        {
            timeSpan = DateTime.Now.ToString("yyyyMMddHHmmssffff");
#if __WASM__
            return  WebAssemblyRuntime.InvokeJS($"GenerateHASH('{timeSpan + Contants.PRIVATE_KEY + Contants.PUBLIC_KEY}');");
#else
            return CreateMD5(timeSpan + Contants.PRIVATE_KEY + Contants.PUBLIC_KEY).ToLower();
#endif
        }
    }
}
