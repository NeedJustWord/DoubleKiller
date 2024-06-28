using System.IO;
using System.Security.Cryptography;

namespace DoubleKiller
{
    internal class HashHelper
    {
        public static string Md5(Stream stream, bool toUpper)
        {
            return ComputeHash(new MD5CryptoServiceProvider(), stream, toUpper);
        }

        public static string Sha1(Stream stream, bool toUpper)
        {
            return ComputeHash(new SHA1CryptoServiceProvider(), stream, toUpper);
        }

        public static string Sha256(Stream stream, bool toUpper)
        {
            return ComputeHash(new SHA256CryptoServiceProvider(), stream, toUpper);
        }

        public static string Sha384(Stream stream, bool toUpper)
        {
            return ComputeHash(new SHA384CryptoServiceProvider(), stream, toUpper);
        }

        public static string Sha512(Stream stream, bool toUpper)
        {
            return ComputeHash(new SHA512CryptoServiceProvider(), stream, toUpper);
        }

        private static string ComputeHash(HashAlgorithm hashAlgorithm, Stream stream, bool toUpper)
        {
            return hashAlgorithm.ComputeHash(stream).ToHex(toUpper);
        }
    }
}
