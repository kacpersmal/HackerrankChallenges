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

    // Complete the sockMerchant function below.
    static int sockMerchant(int n, int[] ar) {
        
        int pairs = 0;
        
        int[] counter = new int[101];
        for(int i = 0; i <= n-1; i++){
            int current = ar[i];

            counter[current]++;
        }

      

        for(int i = 0; i <=counter.Length-1; i++){
            int current = counter[i];
            if(current != 0){
                int countPairs = (int)current/2;
                Console.WriteLine(countPairs);
                pairs = pairs + countPairs;
            }
        }

        return pairs;
    }

    static void Main(string[] args) {

        int n = 7;

        int[] ar = Array.ConvertAll("1 2 1 2 1 3 2".Split(' '), arTemp => Convert.ToInt32(arTemp));
        int result = sockMerchant(n, ar);

        Console.WriteLine(result);

        Console.WriteLine("Press any key to close");
        Console.ReadKey();
    }
}