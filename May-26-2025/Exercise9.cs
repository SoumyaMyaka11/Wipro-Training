using System;

namespace ConsoleApp7
{
    

    #region Strategy Abstraction

    public abstract class CompressionStrategy
    {
        public abstract void Compress(string inputPath, string outputPath);
    }

    #endregion

    #region Concrete Strategies

    public class ZipCompression : CompressionStrategy
    {
        public override void Compress(string inputPath, string outputPath)
        {
            Console.WriteLine($" Compressing '{inputPath}' into ZIP -> '{outputPath}.zip'");
            
        }
    }

    public class RarCompression : CompressionStrategy
    {
        public override void Compress(string inputPath, string outputPath)
        {
            Console.WriteLine($"Compressing '{inputPath}' into RAR -> '{outputPath}.rar'");
            
        }
    }

    #endregion

    #region Context

    public class Compressor
    {
        private CompressionStrategy _strategy;

        public Compressor(CompressionStrategy strategy)
        {
            _strategy = strategy;
        }

        public void SetStrategy(CompressionStrategy strategy)
        {
            _strategy = strategy;
        }

        public void CompressFile(string inputPath, string outputPath)
        {
            _strategy.Compress(inputPath, outputPath);
        }
    }

    #endregion

    #region Program

    public class Program
    {
        public static void Main()
        {
            string input = "report.txt";

            Compressor compressor = new Compressor(new ZipCompression());
            compressor.CompressFile(input, "archive1");

            compressor.SetStrategy(new RarCompression());
            compressor.CompressFile(input, "archive2");
        }
    }

    #endregion
}
