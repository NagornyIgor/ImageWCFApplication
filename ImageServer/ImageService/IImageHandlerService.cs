using System.Collections.Generic;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace ImageService
{
    [ServiceContract]
    public interface IImageHandlerService
    {
        //[FaultContract(typeof(FaultException<ImageServiceFault>), Action = "http://localhost:8080/ImageServiceFault", Name = "ImageServiceFault")]
        [FaultContract(typeof(FaultException))]
        [OperationContract]
        void SaveImage(FileModel image);

        [OperationContract]
        IEnumerable<string> GetImageNames();

        [OperationContract]
        byte[] GetImage(string imageName);
    }


    [DataContract]
    public class FileModel
    {
        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public byte[] Content { get; set; }
    }

    [DataContract]
    public class ImageServiceFault
    {
        public ImageServiceFault(string message)
        {
            Message = message;
        }

        [DataMember]
        public string Message { get; set; }
    }
}
