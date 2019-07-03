using System;
using System.ServiceModel;
using ImageService;

namespace ImageServer
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var host = new ServiceHost(typeof(ImageHandlerService)))
            {
                host.Open();

                Console.WriteLine("Image handler service is ready.");
                Console.WriteLine("Press <Enter> to stop the service.");
                Console.ReadLine();

                host.Close();
            }
        }
    }
}
