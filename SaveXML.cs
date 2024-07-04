using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace Calendar
{
     public class SaveXML<type>
     {
          BinaryFormatter formatter;

          public SaveXML()
          {
               formatter = new BinaryFormatter();
          }

          public void SaveData(Dictionary<int, List<Event>> obj, string filename)
          {
               try
               {
                    FileStream writerFileStream = new FileStream(filename, FileMode.Create, FileAccess.Write);
                    formatter.Serialize(writerFileStream, obj);
                    writerFileStream.Close();
               }
               catch (Exception e)
               {
                    MessageBox.Show(e.GetBaseException().ToString());
               }
          }

          public Dictionary<int, List<Event>> GetData(Dictionary<int, List<Event>> o, string filename)
          {
               try
               {
                    FileStream readerFileStream = new FileStream(filename, FileMode.Open, FileAccess.Read);
                    var dict = (Dictionary<int, List<Event>>)formatter.Deserialize(readerFileStream);
                    readerFileStream.Close();
                    return dict;
               }
               catch (Exception e)
               {
                    MessageBox.Show(e.GetBaseException().ToString());
               }

               return new Dictionary<int, List<Event>>();
          }
     }
}
