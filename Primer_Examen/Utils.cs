using System;
using System.IO;
using System.Xml.Serialization;

namespace Primer_Examen
{
    public static class Utils {
       public static void GrabarXml(string arch, Escuela escuela){
        FileStream fs = File.Open(arch,FileMode.Create);
        XmlSerializer xml = new XmlSerializer(typeof(Escuela));
        xml.Serialize(fs,escuela);
        fs.Close();
        }
        public static void LeerXml(string arch, ref Escuela escuela){
        FileStream fs = File.Open(arch,FileMode.Open);
        XmlSerializer xml = new XmlSerializer(typeof(Escuela));
        escuela=(Escuela)xml.Deserialize(fs);
        fs.Close();

        }
    }
}