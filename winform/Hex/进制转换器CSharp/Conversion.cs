using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 进制转换器CSharp
{
    class Conversion
    {
        public long nToDecimal(string binStr, int rule)
        {
            long result = 0;
            try
            { 
                 result=Convert.ToInt64(binStr, rule);         
            } catch (Exception)
            {
                return -1;    
            }
            return result;
        }

        public string nToBin(string binStr, int rule)
        {
            
            string result = "";
            long myValue = 0;
            try
            {
                myValue = Convert.ToInt64(binStr, rule);
                result = Convert.ToString(myValue, 2);
            }
            catch (Exception)
            {
                return "";
            }
            return result;
        }
        public string nToOct(string binStr, int rule)
        {

            string result = "";
            long myValue = 0;
            try
            {
                myValue = Convert.ToInt64(binStr, rule);
                result = Convert.ToString(myValue, 8);
            }
            catch (Exception)
            {
                return "";
            }
            return result;
        }
        public string nToHex(string binStr, int rule)
        {

            string result = "";
            long myValue = 0;
            try
            {
                myValue = Convert.ToInt64(binStr, rule);
                result = Convert.ToString(myValue, 16);
            }
            catch (Exception)
            {
                return "";
            }
            return result.ToUpper();
        }        
    }
}
