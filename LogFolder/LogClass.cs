using System;
using System.Text;
using System.IO;

namespace LogGenerate
{
    public class LogClass
    {
        private StringBuilder sb = new StringBuilder();
        private string timeStamp()
        {
            string datetime = DateTime.Now.ToString("[ "+"yyyy"+"-"+"MM"+"-"+"dd"+"T"+"hh"+":"+"mm"+":"+"ss"+"."+"fffZ"+" ]");
            return datetime;
        }
        public string info (string kata)
        {
            sb.Append(timeStamp()+" [INFO] : "+ kata+"\n");
            return null;
        }
        public string error( string kata)
        {
            sb.Append(timeStamp()+" [ERROR] : "+kata+"\n");
            return null;
        }
        public string notice(string kata)
        {
            sb.Append(timeStamp()+" [NOTICE] : "+kata+"\n");
            return null;
        }
        public string warning(string kata)
        {
            sb.Append(timeStamp()+" [WARNING] : "+kata+"\n");
            return null;
        }
        public string debug(string kata)
        {
            sb.Append(timeStamp()+" [DEBUG] : "+kata+"\n");
            return null;
        }
        public string alert(string kata)
        {
            sb.Append(timeStamp()+" [ALERT] : "+kata+"\n");
            return null;
        }
        public string critical(string kata)
        {
            sb.Append(timeStamp()+" [CRITICAL] : "+kata+"\n");
            return null;
        }
        public string emergency(string kata)
        {
            sb.Append(timeStamp()+" [EMERGENCY] : "+kata+"\n");
            return null;
        }
        public void pathGenerator(string logpath)
        {
            File.AppendAllText(logpath+"Log", sb.ToString());
        }

        public void output()
        {

        }    
    }
}
