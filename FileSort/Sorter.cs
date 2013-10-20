using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections.Generic;

namespace FileSort {
    class Sorter {
        public string toFolder { get; set; }
        public string nameRef { get; set; }

        public List<Sorter> ReadFile(string fileName) {
            List<Sorter> sortList = new List<Sorter>();
            StreamReader stream = null;
            try {
                using (stream = new StreamReader(fileName)) {
                    string line;
                    while ((line = stream.ReadLine()) != null) {
                        string[] splitLine = line.Split(',');
                        Sorter sortLine = new Sorter();
                        sortLine.toFolder = splitLine[0];
                        sortLine.nameRef = splitLine[1];
                        sortList.Add(sortLine);
                    }
                }
                return sortList;

            } catch (FileNotFoundException) {
                throw new Exception("The Reference file could not be found");
            } catch (Exception) {
                throw new Exception("An error has occured please check the Reference file and try again");
            } finally {
                stream.Close();
                stream.Dispose();
            }
        }

        public void SortFiles(List<Sorter> referenceList, string folderName, string outFolder) {
            try {
                string[] files = Directory.GetFiles(folderName);
                foreach (string file in files) {
                    string[] split = file.Split('\\');
                    string[] fileName = split.Last().Split('.');
                    try {
                        Sorter reference = referenceList.First(i => i.nameRef == fileName[0]);
                        try {

                            Directory.GetDirectories(outFolder + "\\" + reference.toFolder);
                        } catch (DirectoryNotFoundException) {
                            Directory.CreateDirectory(outFolder + "\\" + reference.toFolder);
                        }

                        File.Copy(file, outFolder + "\\" + reference.toFolder + "\\" + split.Last().ToString());

                    } catch (Exception) {

                    }

                }
            } catch (Exception ex) {
                throw new Exception(ex.Message);
            }
        }
    }
}
