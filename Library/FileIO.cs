using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class FileIO : IFileInterface
    {
        public List<string> ReturnMediaFile(string path)
        {
            //initialize the list we'll be returning
            //var lines = File.ReadLines(@"Media.txt");

            List<string> mediaFile = new List<string>();

            try
            {
                //check to see whether the file exists
                if (!File.Exists(path))
                {
                    //throw appropriate exepction
                    //implement
                    throw new FileNotFoundException("file not found!", path);
                }

                //initialize the empty string we'll be using for each line
                string line;

                //open a StreamReader to the file specifcied in the path variable 
                //implement
                using (StreamReader reader = new StreamReader(path))
                {
                    //while reading a new from file, addd each line to mediaFile
                    //as long as each new line is not null
                    //implement
                    line = reader.ReadLine();

                    while (line !=null)
                    {
                        mediaFile.Add(line);
                        line = reader.ReadLine();
                    }


                }





                //remember to close your file
                //file.Close();
            }
            catch (FileNotFoundException)
            {
                //write out appropriate message
                //implement
                Console.WriteLine("File not found");
            }
            catch (Exception e)
            {
                //write out the message of e
                //implement
                Console.WriteLine(e);
            }

            return mediaFile;
        }

        //not yet implemented
        public void UpdateMediaFile(List<string> newMedia)
        {
            throw new NotImplementedException();
        }
    }
}
