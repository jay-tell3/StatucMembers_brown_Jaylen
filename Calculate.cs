using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatucMembers_brown_Jaylen
{   //makes the Calculate class
    static internal class Calculate
    {
        //the result of the answer
        public static float result = 0.0f;
        //inislizes the result 
        static Calculate()
        {
            result = 0.0f;        
        }
        //methods\/
        //Adds two ints and retruns the answer
        public static int Add(int x, int y)
        { 
           return x + y;
        }
        //subtracts two ints and retruns the answer
        public static int Sub(int x, int y)
        {
            return x - y;
        }
        //multiplis two ints and retruns the answer
        public static int Mult(int x, int y)
        {
            return x * y;
        }
        //divides two ints and retruns the answer
        public static int Div(int x, int y)
        {
            return x / y;
        }
        //Adds two floats and retruns the answer
        public static float Add(float x, float y)
        {
            return x + y;
        }
        //subtracts two floats and retruns the answer
        public static float Sub(float x, float y)
        {
            return x - y;
        }
        //multiplis two floats and retruns the answer
        public static float Mult(float x, float y)
        {
            return x * y;
        }
        //divids two floats and retruns the answer
        public static float Div(float x, float y)
        {
            return x / y;
        }

    }
}
