//
//
// (c) 2015 Samaritan Pawn IDE - Source Code
//
//

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Samaritan.Scripting
{
    class Parser
    {
        public List<Defines> Defines = new List<Scripting.Defines>();
        public List<Functions> Functions = new List<Scripting.Functions>();
        public List<Events> Events = new List<Scripting.Events>();
        public List<Variables> Variables = new List<Scripting.Variables>();
        public void Parse(string sourceCode)
        {
            StreamReader stream = new StreamReader(new MemoryStream(Encoding.ASCII.GetBytes(sourceCode.ToString())));

            while (!stream.EndOfStream)
            {
                string line = stream.ReadLine();
                if (line.Length > 0)
                {
                    Defines.Add(new Scripting.Defines()
                    {
                        Name = "MAX_PLAYER_NAME",
                        Value = "24"
                    });
                }
                else if (line.StartsWith("forward"))
                {

                }
                else if (line.StartsWith("#include"))
                {

                }
                else
                {

                }
            }
        }
    }
}
