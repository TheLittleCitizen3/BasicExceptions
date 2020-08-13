using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;
using Logic;

namespace BasicExceptionHandle
{
    class RunLogic
    {
        private int _studentNumber;
        private Logic.Logic logic = new Logic.Logic();

        public RunLogic( int studentNumber)
        {
            _studentNumber = studentNumber;
        }

        public void RunLogic1(int[] numbers)
        {
            if (numbers.Length == 0)
            {
                throw new ScubaException("Cannot sum empty array",_studentNumber);
            }
            try
            {
                logic.Logic1(numbers);
            }
            catch (IndexOutOfRangeException e)
            {

                Console.WriteLine("The index is out of range" + e.Message);
                throw;
                
            }
            catch (Exception e)
            {
                Console.WriteLine("Cant complete the operation of sim array. error info: " + e.Message);
                throw;

            }


        }

        public void RunLogic2(string inputFileName, string outputFileName)
        {
            try
            {

            }
            catch (System.IO.IOException e)
            {

                Console.WriteLine("Could not read or Write to file. Error info: " + e.Message);
                throw;

            }
            catch (Exception e)
            {
                Console.WriteLine("there was error reading or writing to file. error info: " + e.Message);
                throw;
            }
        }

        public void RunLogic3(string data)
        {
            if (data == null)
            {
                throw new ScubaException("cant parse empty data to int", _studentNumber);
            }
            try
            {
                logic.Logic3(data);
            }
            catch (ArgumentException e )
            {
                Console.WriteLine("not a valid number data. more info: " + e.Message);
                throw;
            }
            catch (FormatException e)
            {
                Console.WriteLine("not a valid number data. more info: " + e.Message);
                throw;
            }
            catch (OverflowException e)
            {
                Console.WriteLine("the number is not in range of int 32. more info: "+ e.Message);
                throw;
            }
            catch (Exception e)
            {
                Console.WriteLine("cant parse the data to int. more info: " + e.Message);
                throw;
            }

        }
        
        public void RunLogic4(string data1, int data2, long data3)
        {
            try
            {
                logic.Logic4(data1, data2, data3);
            }
            catch (NotImplementedException e)
            {
                Console.WriteLine("the function is not implemented yet. more info: " + e.Message);
                throw;
            }
        }

        public void RunLogic5(string dllName)
        {
            try
            {
                logic.Logic5(dllName);
            }
            catch (e is ArgumentNullException)
            {
                Console.WriteLine("the File is Null. more info:" + e.Message);
                throw;
            }
            catch (e is System.IO.FileNotFoundException)
            {
                Console.WriteLine("File not found!. more info: " + e.Message);
                throw;
            }
            catch (Exception e)
            {
                Console.WriteLine("could not load file. more info: " + e.Message);
                throw;
            }
         
        }


    }
}
