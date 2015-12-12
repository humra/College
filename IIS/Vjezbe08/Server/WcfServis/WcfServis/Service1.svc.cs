using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfServis
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        string cs = ConfigurationManager.ConnectionStrings["cs"].ConnectionString;

        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public List<Kolegij> GetKolegijiZaStudenta(int IDStudenta)
        {
            List<Kolegij> kolegiji = new List<Kolegij>();

            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();

                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM Kolegij INNER JOIN " + 
                        "Upis ON Upis.KolegijID = Kolegij.IDKolegij WHERE Upis.StudentID = " + IDStudenta;
                    cmd.CommandType = System.Data.CommandType.Text;

                    using (SqlDataReader r = cmd.ExecuteReader())
                    {
                        if (r.HasRows)
                        {
                            while (r.Read())
                            {
                                kolegiji.Add(new Kolegij
                                {
                                    ECTS = (int)r["ECTS"],
                                    IDKolegij = (int)r["IDKolegij"],
                                    Naziv = r["Naziv"].ToString(),
                                    Nositelj = r["Nositelj"].ToString()
                                });
                            };
                        }
                    }
                }
            }

            return kolegiji;
        }

        public List<Student> GetStudentiZaKolegij(int IDKolegija)
        {
            List<Student> studenti = new List<Student>();

            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();

                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM Student INNER JOIN Upis ON " +
                        "Upis.StudentID = Student.IDStudent WHERE Upis.KolegijID = " + IDKolegija;
                    cmd.CommandType = System.Data.CommandType.Text;

                    using (SqlDataReader r = cmd.ExecuteReader())
                    {
                        if (r.HasRows)
                        {
                            while (r.Read())
                            {
                                studenti.Add(new Student
                                {
                                    GodinaStudija = (int)r["GodinaStudija"],
                                    Ime = r["Ime"].ToString(),
                                    JMBAG = r["JMBAG"].ToString(),
                                    Prezime = r["Prezime"].ToString()
                                });
                            };
                        }
                    }
                }
            }

            return studenti;
        }

        public void CreateStudent(string ime, string prezime, string jmbag, int godinaStudija)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();

                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO Student VALUES (Ime, Prezime, JMBAG, GodinaStudija) " +
                        "VALUES ('" + ime + "', '" + prezime + "', '" + jmbag + "', " + godinaStudija + ")";
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.ExecuteNonQuery();
                }
             }
          }

        public void UpisiStudentaNaKolegij(int IDStudenta, int IDKolegij)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();

                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO Upis (StudentID, KolegijID) VALUES " +
                        " (" + IDStudenta + ", " + IDKolegij + ")";
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
