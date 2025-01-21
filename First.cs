using System.Globalization;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public static void Main(string[] args)
    {
        List<List<string>> mai = GroupAnagrams(new string[] {"eat", "tea", "tan", "ate", "nat", "bat"});
        for (int i = 0; i < mai.Count; i++) {
            for (int j = 0; j < mai[i].Count; j++) {
                System.Console.WriteLine(mai[i][j]);
            }
            Console.WriteLine();
            Console.WriteLine();
        }
        Console.ReadKey();
    }
    public static List<List<string>> GroupAnagrams(string[] strs) 
    {
        List<List<string>> mainList = new List<List<string>>();   
        for (int i = 0; i < strs.Length; i++) {
            if (strs[i] != "") {
                List <string> chimo = [strs[i]];
                for (int j = 0; j < strs.Length; j++) {
                    if (i != j && IsAnagram(strs[i], strs[j])) {
                        chimo.Add(strs[j]);
                        strs[j] = "";
                    }
                }
                mainList.Add(chimo);
            }
        }
        return mainList;
    }

    public static bool IsAnagram(string s, string t)
    {
        Char[] sArray = s.ToCharArray();
        Char[] tArray = t.ToCharArray();
        Array.Sort(sArray);
        Array.Sort(tArray);
        if (sArray.Length != tArray.Length)
        {
            return false;
        }

        return new string(sArray) == new string(tArray);
    }
}
