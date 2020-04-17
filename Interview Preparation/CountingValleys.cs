using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Solution {

    // Complete the countingValleys function below.
    static int countingValleys(int n, string s) {

        int valleys = 0;
        int tLevel = 0;


        for(int index = 0; index <= s.Length-1; index++){
            char c = s[index];
            if(c == 'U') tLevel++;
            if(c == 'D') tLevel--;
        
            if(tLevel+1 == 0 && s[index+1] =='U')valleys++;
        }

        return valleys;
    }

    static void Main(string[] args) {
        

        int n = 8;

        string s ="UDDDUDUU";

        int result = countingValleys(n, s);

        Console.WriteLine(result);

        Console.WriteLine("Press any key to close");
        Console.ReadKey();
    }
}