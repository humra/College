using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfServis
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        string GetData(int value);

        [OperationContract]
        List<Kolegij> GetKolegijiZaStudenta(int IDStudenta);

        [OperationContract]
        List<Student> GetStudentiZaKolegij(int IDKolegija);

        [OperationContract]
        void CreateStudent(string ime, string prezime, string jmbag, int godinaStudija);

        [OperationContract]
        void UpisiStudentaNaKolegij(int IDStudenta, int IDKolegij);

        // TODO: Add your service operations here
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class Student
    {
        [DataMember]
        public int IDStudent
        {
            get;
            set;
        }

        [DataMember]
        public string Ime
        {
            get;
            set;
        }

        [DataMember]
        public string Prezime
        {
            get;
            set;
        }

        [DataMember]
        public string JMBAG
        {
            get;
            set;
        }

        [DataMember]
        public int GodinaStudija
        {
            get;
            set;
        }
    }

    [DataContract]
    public class Kolegij
    {
        [DataMember]
        public int IDKolegij
        {
            get;
            set;
        }

        [DataMember]
        public string Naziv
        {
            get;
            set;
        }

        [DataMember]
        public string Nositelj
        {
            get;
            set;
        }

        [DataMember]
        public int ECTS
        {
            get;
            set;
        }
    }

    [DataContract]
    public class Upis
    {
        [DataMember]
        public int IDUpis
        {
            get;
            set;
        }

        [DataMember]
        public int StudentID
        {
            get;
            set;
        }

        [DataMember]
        public int KolegijID
        {
            get;
            set;
        }
    }
}
