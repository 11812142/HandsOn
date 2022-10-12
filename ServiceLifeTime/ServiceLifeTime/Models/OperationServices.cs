namespace ServiceLifeTime.Models;
using System.Security.Cryptography.X509Certificates;

    public class OperationServices : ISingletonService, ITransientService, IScopedService
    {
        Guid id;
        int no;
        public OperationServices()
        {

            id = Guid.NewGuid();
            Random r = new Random();
            no = r.Next(1200);


        }

        public Guid GetOperationID()
        {

            return id;
        }
        public int GenerateRandomNumber()
        {
            return no;
        }


    }

