using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DesignPatterns
{
    public class AbstractFactoryPattern
    {

        public AbstractFactoryPattern()
        { }

        public void GetProductInfo()
        {
            PackDeliveryFactory stdFactory = new StandardDeliveryFactory();
            Client stdFactoryClient = new Client(stdFactory);


            PackDeliveryFactory delicateFactory = new DelicateDeliveryFactory();
            Client stdFactoryClient = new Client(delicateFactory);
        }
    }

    public class Client
    {
        Client(PackDeliveryFactory packDeliveryProduct)
        {

        }
    }

   abstract class PackDeliveryFactory
    {
       public abstract Packaging CreatePacking();
        public abstract DeliveryDocument CreateDeliveryDocument();

    }

   public abstract class Packaging
    { }
   public abstract class DeliveryDocument
    { }

    class StandardDeliveryFactory : PackDeliveryFactory
    {
       public override CreatePacking()
        { }
        public override CreateDeliveryDocument()
        { }
    }

    class DelicateDeliveryFactory
    { }

}