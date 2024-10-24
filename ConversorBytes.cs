namespace Conversor;
public static class ConversorBytes
{
    public static string Converter<T>(T bytes) where T : struct
    {
        string[] unit = new string[] { "B", "KB", "MB", "GB", "TB", "PB" };

        int count = 0;

        if (Double.TryParse(bytes.ToString(), out double bytesDouble))
        {
            while (bytesDouble >= 1024)
            {
                bytesDouble /= 1024;
                count = count == unit.Count() - 1 ? count : count + 1;
            }

            return string.Format("{0} {1}", Math.Round(bytesDouble, 2), unit[count]);
        }
        return "Não é possível converter esse valor.";
    }
}
