using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace TestProject
{
    class Program
    {
        static void Main(string[] args)
        {
            SerializeAccounts();
            DeserializeAccounts();
        }
        static public void SerializeAccounts()
        {
            var accounts = new List<TestAccount>()
                { new TestAccount() { Password = "1" }, new TestAccount() { Password = "2" } };
            using (var stream = new FileStream("acc.json", FileMode.OpenOrCreate))
            using (var writer = new StreamWriter(stream))
            {
                var data = JsonConvert.SerializeObject(accounts);
                writer.Write(data);
                Console.WriteLine(accounts[0].CreationDate);
            }
        }
        static public void DeserializeAccounts()
        {
            using (var stream = new FileStream("acc.json", FileMode.OpenOrCreate))
            using (var reader = new StreamReader(stream))
            {
                var data = JsonConvert.DeserializeObject<List<TestAccount>>(reader.ReadToEnd());
                Console.WriteLine(data[0].CreationDate);
            }
        }
    }
    [DataContract]
    class TestAccount
    {
        [DataMember]
        private string password; 

        public string Password 
        {
            get 
            {
                return password;
            }
            set
            {
                password = value;
                CreationDate = DateTime.Now;
            }
        }
        [DataMember]
        public DateTime CreationDate { get; set; }
    }

}
