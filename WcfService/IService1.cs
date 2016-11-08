using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {   [OperationContract]
        IEnumerable<Product> GetProducts();
        [OperationContract]
         void Remove(int id);
        [OperationContract]
         void InsertProduct(Product pr);
        [OperationContract]
        void Update(Product pr);

    }
    [DataContract]
    public class Product
    {
        [DataMember]
        [Key]
        public int Id { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Description { get; set; }
        [DataMember]
        public int Price { get; set; }
    }
}
