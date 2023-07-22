namespace Assignment3_json.model
{
    internal class FileHelper
    {
        public static string Read(string filePath)
        {
            if (File.Exists(filePath))
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    return reader.ReadToEnd();
                }
            }
            return string.Empty;
        }

        // WRITE FILE
        public static void Write(string filePath, string text, bool append = true)
        {
            using (StreamWriter writer = new StreamWriter(filePath, append: append))
            {
                writer.Write(text);
            }
        }
    }
}


