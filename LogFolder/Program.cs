using System;
using LogGenerate;

namespace Log
{
    class Program
    {
        static void Main(string[] args)
        {
            LogClass log = new LogClass();
            log.info("This is an information about something.");
            log.error("We can't divide any numbers by zero.");
            log.notice("Someone loves your status.");
            log.warning("Insufficient funds.");
            log.debug("This is debug message.");
            log.alert("Achtung! Achtung!");
            log.critical("Medic!! We've got critical damages.");
            log.emergency("System hung. Contact system administrator immediately!");

            log.pathGenerator("D:/Users/bsi50129/.vscode/Task OOP/LogFolder/");
            log.output();
        }


    }
}
