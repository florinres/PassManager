using System;
using System.Data.SqlClient;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace HourOne
{
    internal class Logare
    {
        Random random = new Random();
        string numeLogare;
        string parolaLogare;
        string super_name = "admin";
        string super_pass = "admin";
        public Logare(string name, string parola)
        {
            //daca exista fisierul cu credentialele atunci le citim de acolo
            //aici constructorul trebuie sa citeasca fisierul cu credentialele deja setate din exterior
            //ar trebuii sa fac o metoda care citeste acele credentiale
            this.numeLogare = name;
            this.parolaLogare = parola;
            stricaNume();
            stricaParola();
            //dupa scriem in datele intr un fisier nou din care utilizatorul le va folosi pentru data urmatoare
        }
        public Logare()
        {

        }
        private void stricaNume()
        {
            byte[] bytes = Encoding.ASCII.GetBytes(this.numeLogare);
            for (byte a = 0; a < numeLogare.Length; a++)
            {
                bytes[a] = (byte)(bytes[a] + random.Next(0, 5));
            }
            numeLogare = System.Text.Encoding.ASCII.GetString(bytes);
            stricaParola();
        }
        private void stricaParola()
        {
            byte[] bytes = Encoding.ASCII.GetBytes(this.parolaLogare);
            for (byte a = 0; a < parolaLogare.Length; a++)
            {
                bytes[a] = (byte)(bytes[a] + random.Next(0, 5));
            }
            parolaLogare = System.Text.Encoding.ASCII.GetString(bytes);
        }

        public bool login(string user, string pass)
        {
        }
        public string ret_nume()
        {
            return this.numeLogare;
        }
        public string ret_pass()
        {
            return this.parolaLogare;
        }
        public string ret_super_name()
        {
            return this.super_name;
        }

        public string ret_super_pass()
        {
            return super_pass;
        }
    }
}
