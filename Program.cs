using System;
using System.Collections.Generic;

namespace Basic13
{
    class Program
    {
        public static void PrintNumbers()
        {
            for (int i=1; i<256; i++){
                Console.Write(i + ", ");
            }
        }
        public static void PrintOdds()
        {
            for (int i=1; i<256; i+=2){
                Console.Write(i + ", ");
            }
        }
        public static void PrintSum()
        {
            int sum = 0;
            for (int i=0; i<256; i++){
                sum += i;
                Console.WriteLine("New number: " + i + " Sum: " + sum);
            }
        }
        public static void LoopArray(int[] numbers)
        {
            foreach (int i in numbers){
                Console.Write(i + ", ");
            }
        }
        public static int FindMax(int[] numbers)
        {
            int maxnum = 0;
            for (int i=0; i<numbers.Length; i++){
                if (numbers[i] > maxnum){
                    maxnum = numbers[i];
                }
            }
            return maxnum;
        }
        public static void GetAverage(int[] numbers)
        {
            int total = 0;
            for (int i=0; i<numbers.Length; i++){
                total += numbers[i];
            }
            int average = total/numbers.Length;
            Console.WriteLine(average);
        }
        public static int[] OddArray()
        {
            int[] odds = new int[128];
            for (int i=1; i<256; i+=2){
                int j = (i-1)/2;
                odds[j] = i;
            }
            return odds;
        }
        public static int GreaterThanY(int[] numbers, int y)
        {
            int total = 0;
            for (int i=0; i<numbers.Length; i++){
                if (numbers[i]>y){
                    total += 1;
                }
            }
            return total;
        }
        public static void SquareArrayValues(int[] numbers)
        {
            for (int i=0; i<numbers.Length; i++){
                numbers[i] *= numbers[i];
            }
        }
        public static void EliminateNegatives(int[] numbers)
        {
            for (int i=0; i<numbers.Length; i++){
                if (numbers[i] < 0){
                    numbers[i] = 0;
                }
            }
        }
        public static void MinMaxAverage(int[] numbers)
        {
            int max = numbers[0];
            int min = numbers[0];
            int total = 0;
            for (int i=0; i<numbers.Length; i++){
                if (numbers[i] < min){
                    min = numbers[i];
                }
                else if (numbers[i] > max){
                    max = numbers[i];
                }
                total += numbers[i];
            }
            double avg = total/numbers.Length;
            Console.WriteLine("Max: " + max);
            Console.WriteLine("Min: " + min);
            Console.WriteLine("Average: " + avg);
        }
        public static void ShiftValues(int[] numbers)
        {
            for (int i=0; i<numbers.Length; i++){
                if (i == numbers.Length-1){
                    numbers[i] = 0;
                }
                else {
                    numbers[i] = numbers[i+1];
                }
            }
        }
        public static object[] NumToString(int[] numbers)
        {
            object[] newArr = new object[numbers.Length];
            for (int i=0; i<numbers.Length; i++){
                object o = numbers[i];
                if (numbers[i] < 0){
                    newArr[i] = "Dojo";
                }
                else {
                    newArr[i] = o;
                }
            }
            return newArr;
        }
        
        static void Main(string[] args)
        {
            int[] array1 = {2,-6,4,8,3};
            NumToString(array1);
        }
    }
}
