using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;

namespace EngineTests.Project
{
    [TestClass]
    public class Loading
    {
        [TestMethod]
        public void SaveProject()
        {
            MemoryStream memStream = new MemoryStream();

            Engine.Project project = new Engine.Project();
            project.Save(memStream);

            String s = memStream.ToString();
        }

        [TestMethod]
        public void LoadProject()
        {
            Engine.Project p = new Engine.Project();
            p.Load(GenerateStreamFromString(projectExample1));

        }

        public static String projectExample1 = "";

        // http://stackoverflow.com/questions/1879395/how-to-generate-a-stream-from-a-string
        public Stream GenerateStreamFromString(string s)
        {
            MemoryStream stream = new MemoryStream();
            StreamWriter writer = new StreamWriter(stream);
            writer.Write(s);
            writer.Flush();
            stream.Position = 0;
            return stream;
        }
    }
}
