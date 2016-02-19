using System.IO;
using System.Xml.Serialization;

namespace POEditor
{
    public class Project
    {
        public int a;

        public string str;

        public Project ()
        {
            a = 1;
            str = "Test";
        }

        // private void DoReadWrite (string filename, Curve from, out Curve to)
        // {
        //     XmlSerializer xs = new XmlSerializer (typeof (Curve));
           
        //     // Запись
        //     Stream writer = new FileStream (filename, FileMode.Create);
        //     xs.Serialize (writer, from);
        //     writer.Close ();
           
        //     // Чтение
        //     Stream reader = new FileStream (filename, FileMode.Open);
        //     to = (Curve) xs.Deserialize (reader);
        //     reader.Close ();
        // }
           
        public static Project Load (string path)
        {
            Stream reader = new FileStream (path, FileMode.Open);
            XmlSerializer x = new XmlSerializer (typeof (Project));

            Project p = (Project) x.Deserialize (reader);
            reader.Close ();

            return p;
        }

        public static void Save (Project project, string path)
        {
            XmlSerializer x = new XmlSerializer (typeof (Project));
            Stream writer = new FileStream (path, FileMode.Create);

            x.Serialize (writer, project);
            writer.Close ();
        }
    }
}