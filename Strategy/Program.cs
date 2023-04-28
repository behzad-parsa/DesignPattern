using Strategy.Exercise;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Model 1

            //ImageStorage imageStorage = new ImageStorage(new JpegCompressor() , new BlackAndWhiteFilter() );
            //imageStorage.Store("MYPhoto");

            //Model 2
            var imageStorage = new ImageStorage();
            imageStorage.Store("MyPhoto", new JpegCompressor(), new BlackAndWhiteFilter());
            imageStorage.Store("MyPhoto", new PngCompressor(), new BlackAndWhiteFilter());


            //Exercise
            Console.WriteLine("\n ------- Exercise --------- \n");
            var chatClient = new ChatClient(new DESAlgorithm());
            chatClient.Send("Heyyyy!!");

            Console.ReadLine();

        }
    }
}
