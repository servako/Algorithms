using System;
using System.Collections.Generic;
using System.Text;

namespace powerset
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

         public static List<string> BitMaskImplementation(string input)
        {
            int n = input.Length;
            // Power set contains 2^N subsets.
            int powerSetCount = 1 << n;
            var ans = new List<string>();

            for (int setMask = 0; setMask < powerSetCount; setMask++)
            {
                var s = new StringBuilder();
                for (int i = 0; i < n; i++)
                {
                    // Checking whether i'th element of input collection should go to the current subset.
                    if ((setMask & (1 << i)) > 0)
                    {
                        s.Append(input[i]);
                    }
                }
                ans.Add(s.ToString());
            }

            return ans;
        }

        public static void RecursionImplementation()
        {        
            //Setting Up the Array   
            int[] arr = {1,3,2};  
            
            //Calling the Mediator Function vis passing the array  
            FindSubsets(arr);  
            
            Console.WriteLine("----End----");  
         
        }  
      
        static void FindSubsets(int[] arr){  
            int[] sub = new int[arr.Length];  
            Find(arr,sub,0);  
        }  
      
        static void Find(int[] arr,int[] sub,int p){  
            //if the position variable p has iterated all elements   
            if(p==arr.Length){  
                //mechanism to print non zero elements  
                string s = "";  
                for(int i=0;i<arr.Length;i++){  
                    if(sub[i]!=0){  
                        s += sub[i].ToString();  
                    }  
                }  
                Console.WriteLine(s);  
            }  
            else{  
                //For not selecting the element  
                sub[p] = 0;  
                Find(arr,sub,p+1);  
                
                //For selecting the element  
                sub[p] = arr[p];  
                Find(arr,sub,p+1);                  
            }  
        }
    }
}
