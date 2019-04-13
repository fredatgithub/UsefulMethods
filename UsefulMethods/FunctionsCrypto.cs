using System;
using System.Security.Cryptography;
using System.Text;

namespace UsefulMethods
{
  public static class FunctionsCrypto
  {
    public static string RsaEncryption(string clearData)
    {
      var param = new CspParameters { KeyContainerName = "MyKeyContainer" };
      using (var rsa = new RSACryptoServiceProvider(param))
      {
        string plainText = clearData;
        byte[] plainData = Encoding.Default.GetBytes(plainText);
        byte[] encryptedData = rsa.Encrypt(plainData, false);
        string encryptedString = Convert.ToBase64String(encryptedData);
        return encryptedString;
      }
    }

    public static string RsaDecryption(string encryptedData)
    {
      var param = new CspParameters { KeyContainerName = "MyKeyContainer" };
      using (var rsa = new RSACryptoServiceProvider(param))
      {
        byte[] encryptedBytes = Convert.FromBase64String(encryptedData);
        byte[] decryptedData = rsa.Decrypt(encryptedBytes, false);
        string plainData = Encoding.Default.GetString(decryptedData);
        return plainData;
      }
    }

    public static int GenerateRndNumberUsingCrypto(int min, int max)
    {
      if (max > 255 || min < 0)
      {
        return 0;
      }

      if (max == min)
      {
        return min;
      }

      int result;
      var crypto = new RNGCryptoServiceProvider();
      byte[] randomNumber = new byte[1];
      do
      {
        crypto.GetBytes(randomNumber);
        result = randomNumber[0];
      } while (result < min || result > max);

      return result;
    }

    public static int GenerateGreatRndNumberUsingCrypto(int min, int max)
    {
      if (max > 255 || min < 0)
      {
        return 0;
      }

      if (max == min)
      {
        return min;
      }

      int result;
      var crypto = new RNGCryptoServiceProvider();
      byte[] randomNumber = new byte[1];
      do
      {
        crypto.GetBytes(randomNumber);
        result = randomNumber[0];
      } while (result < min || result > max);

      return result;
    }
  }
}