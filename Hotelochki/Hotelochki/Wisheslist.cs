using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Hotelochki
{
    [Serializable]
    internal class Wisheslist
    {
        public List<MyWish> myWishes { get; private set; } = new List<MyWish>();
        public void AddWish(MyWish wish)
        {
            myWishes.Add(wish);
        }
        public void Remove(MyWish wish)
        {
            myWishes.Remove(wish);
        }
        public void Save(string fileName) 
        {
            FileStream file = new FileStream(fileName, FileMode.OpenOrCreate);
            BinaryFormatter formatter = new BinaryFormatter();

            try
            {
                formatter.Serialize(file, this);
            }
            catch (SerializationException ex)
            {
                Console.WriteLine(ex.Message);
                throw ex;
            }
            finally
            {
                file.Close();
            }
        }
        public static Wisheslist Restore(string fileName)
        {
            Wisheslist list;
            FileStream fs = new FileStream(fileName, FileMode.Open);
            try
            {
                BinaryFormatter formatter = new BinaryFormatter();
                list = (Wisheslist)formatter.Deserialize(fs);
            }
            catch (SerializationException ex)
            {
                Console.WriteLine( ex.Message);
                throw ex;
            }
            finally { fs.Close(); }
            return list;
        }
    }
}
