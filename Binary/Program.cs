using System.IO;
namespace Binary
{
    internal class Program
    {
        const string SettingsFileName = "Settings.cfg";
        static void Main(string[] args)
        {
            WriteValues();

            ReadValues();

           NewFile();
        }
        static void NewFile()
        {
            string FilePath = "/Users/tyr1k_qq/Downloads/BinaryFile.bin";

            if (File.Exists(FilePath))
            {
                string StringValue;

                using (BinaryReader bin = new BinaryReader(File.Open(FilePath, FileMode.Open)))
                {
                    StringValue = bin.ReadString();
                }

                Console.WriteLine("Из файла считано");
                Console.WriteLine(StringValue);
            }
        }

        static void WriteValues()
        {
            using (BinaryWriter writer = new BinaryWriter(File.Open(SettingsFileName , FileMode.Create)))
            {
                writer.Write(20.666f);
                writer.Write(@"Text...");
                writer.Write(55);
                writer.Write(false);
            }
        }
        static void ReadValues()
        {
            float FloatValue;
            string StringValue;
            int IntValue;
            bool BoleanValue;
            if (File.Exists(SettingsFileName))
            {


                using (BinaryReader reader = new BinaryReader(File.Open(SettingsFileName, FileMode.Open)))
                {
                    FloatValue = reader.ReadSingle();
                    StringValue = reader.ReadString();
                    IntValue = reader.ReadInt32();
                    BoleanValue = reader.ReadBoolean();
                }

                Console.WriteLine("Из файла считано:");

                Console.WriteLine();

                Console.WriteLine("Дробь:" + FloatValue);
                Console.WriteLine("Строка:" + StringValue);
                Console.WriteLine("Целое:" + IntValue);
                Console.WriteLine("Булевое значение:" + BoleanValue);

            }
        }
    }
}