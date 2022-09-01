using System;
using System.Threading;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Configuration;
using System.Collections.Generic;

namespace ColeCipherServer
{
    class ColeCipherServer
    {
        static TcpListener listener;
        const int LIMIT = 10; //5 concurrent clients

        public static void Main()
        {
            listener = new TcpListener(2055);
            listener.Start();
            #region UpdateDictionary
            StreamReader Reader = new StreamReader(@"Words.txt");
            string RealWord = "";
            string CipherWord = "";
            string TEXT = Reader.ReadToEnd();
            string[] words = TEXT.Split('~');
            bool flag = true;
            string Key = "";
            foreach(string word in words)
            {
                if (flag)
                {
                    flag = false;
                    Key = word;
                }
                else
                {
                    flag = true;
                    DictionaryCode.Add(Key, word);
                    DictionaryDecode.Add(word, Key);
                }
            }
            Console.WriteLine("ready!");
            /*while (true)
            {
                while (true)
                {
                    string Letter = Reader.Read().ToString();
                    if (Letter == "%")
                        goto breaking;
                    else if (Letter == "$")
                        goto notbreaking;
                    if (Letter != "~")
                        RealWord += Letter;
                    else if(Letter == " ")
                        break;
                    else
                    {
                        break;
                    }
                }
                while (true)
                {
                    string Letter = Reader.Read().ToString();
                    if (Letter != "~")
                        CipherWord += Letter;
                    else
                        break;
                }
                DictionaryCode.Add(RealWord, CipherWord);
                DictionaryDecode.Add(CipherWord, RealWord);
                goto notbreaking;
                breaking:
                Console.WriteLine("Ready!");
                    break;
                notbreaking:
                    ;
                    */
            
            Reader.Close();
            #endregion
            for (int i = 0; i < LIMIT; i++)
            {
                Thread t = new Thread(new ThreadStart(Service));
                t.Start();
            }
        }
        public static Dictionary<string, string> DictionaryCode = new Dictionary<string, string>();
        public static Dictionary<string, string> DictionaryDecode = new Dictionary<string, string>();
        public static string[] Alphabet = new string[] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z","a","b","c","d","e","f","g","h","i","j","k","l","m","n","o","p","q","r","s","t","u","v","w","x","y","z" };
      
        public static void Service()
        {
            while (true)
            {
                Socket soc = listener.AcceptSocket();

               
                    Stream s = new NetworkStream(soc);
                    StreamReader sr = new StreamReader(s);
                    StreamWriter sw = new StreamWriter(s);
                    sw.AutoFlush = true;
                    while (true)
                    {
                        string command = sr.ReadLine();
                        switch (command)
                        {
                            case "code":
                                string Message = sr.ReadLine();
                                Console.WriteLine("Got message: " + Message);
                                string CipherMessage = "";
                                string[] words = Message.Split(' ');
                               
                                    foreach(string word in words)
                                    {
                                        if (DictionaryCode.ContainsKey(word))
                                        {
                                            CipherMessage += DictionaryCode[word] + " ";
                                        }
                                        else
                                        {
                                            Random rand = new Random();
                                            int b = rand.Next(1, 11);
                                    rand:
                                    string st = "";
                                    
                                            for(int a = 0; a < b; a++)
                                            {
                                                st += Alphabet[rand.Next(0, Alphabet.Length)];
                                            }
                                            foreach(string k in DictionaryDecode.Keys)
                                    {
                                        if(k == st)
                                        {
                                            goto rand;
                                        }
                                    }
                                            DictionaryCode.Add(word, st);
                                            DictionaryDecode.Add(st, word);
                                            CipherMessage += st + " ";                                                                                                                    
                                        }
                                    }
                                sw.WriteLine(CipherMessage);
                                Console.WriteLine("Sent message: " + CipherMessage);
                                break;
                            case "decode":
                                string DMessage = sr.ReadLine();
                            Console.WriteLine("Got message: " + DMessage);
                            string DCipherMessage = "";
                                string[] Dwords = DMessage.Split(' ');
                            try
                            {
                                foreach (string Dword in Dwords)
                                {
                                    DCipherMessage += DictionaryDecode[Dword] + " ";
                                }
                                sw.WriteLine(DCipherMessage);
                                Console.WriteLine("Sent message: " + DCipherMessage);
                            }
                            catch
                            {
                                sw.WriteLine("Błąd! Słowo które wpisałeś nie znajduje się w dzienniku!");
                            }
                                break;
                            case "exit":
                                File.WriteAllText("Words.txt","banan~debil~");
                            string text = "";
                                foreach(string key in DictionaryCode.Keys)
                                {
                                text += key + "~" + DictionaryCode[key] + "~";
                                }
                                File.WriteAllText("Words.txt", text);
                            sw.WriteLine("ready");
                            Console.WriteLine("Saved!");
                                break;
                        }
                    }
                    s.Close();
               
            }
        }      
    }
}
