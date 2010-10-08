using System;
using System.IO;

namespace hobd{

public class Logger
{

    static StreamWriter fs = new StreamWriter(new FileStream("log.txt", FileMode.Append));
    
    public static void trace(String s)
    {
        log("TRACE", s);
    }
    
    static void log(string level, string s)
    {
        s = "["+level+"] "+DateTime.Now.ToShortTimeString() + ":    " + s;
        System.Console.WriteLine(s);
        fs.Write(s+"\n");
        fs.Flush();    
    }

}


}