using System.Text;

namespace DoubleKiller
{
    internal static class ByteExtension
    {
        public static string ToHex(this byte[] data, bool toUpper)
        {
            if (data == null || data.Length == 0) return "";

            var format = toUpper ? "X2" : "x2";
            var result = new StringBuilder(data.Length * 2);
            foreach (var item in data)
            {
                result.Append(item.ToString(format));
            }
            return result.ToString();
        }
    }
}
