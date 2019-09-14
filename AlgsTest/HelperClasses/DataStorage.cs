using System.IO;
using AlgsTest.HelperInterfaces;

namespace AlgsTest.HelperClasses
{
    public class DataStorage : IDataStorage
    {
        public void Save(string note)
        {
            using (StreamWriter writer = new StreamWriter("db.txt"))
            {
                writer.WriteLine(note);   
            }
        }
    }
}
