using System.IO;
using System.Collections.Generic;

namespace FindAFileInDirectory_Recursion
{
    public class Solution
    {
        public void solve(string dirname, string fileName)
        {
			DateTime stratTime = DateTime.Now;
            Console.WriteLine(searchFile(dirname, fileName));
			DateTime endTime = DateTime.Now;
			TimeSpan timeTaken = endTime - stratTime;
			Console.WriteLine(timeTaken.TotalSeconds + " seconds");
        }

        public bool? searchFile(string givenDirectory, string targetFile)
        {
            try
            {
				Console.WriteLine(givenDirectory);
                List<string> allFilesInDir = Directory.GetFiles(givenDirectory).ToList().Select(a => Path.GetFileName(a)).ToList();
                if (allFilesInDir.Contains(targetFile))
                {
                    return true;
                }
                else
                {
                    List<string> allSubDirInDir = Directory.GetDirectories(givenDirectory).ToList();
                    foreach (string item in allSubDirInDir)
                    {
                        bool? ans = searchFile(item, targetFile);
						if(ans.HasValue && ans.Value){
							return true;
						}
                    }
                }

                return false;
            }
            catch(Exception ex)
            {
                return null;
            }
        }
    }
}
