using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalOutsource.framework.utility
{
    public class Parameters
    {
        
            private static Dictionary<String, object> parameter = new Dictionary<string, object>();
            public static T GetData<T>(String key)
            {
                var value = (dynamic)null;
                try
                {
                    value = Convert.ChangeType(parameter[key], typeof(T));
                }
                catch (Exception e)
                {
                    value = default(T);
                }
            return value;
            }
            public static void SetData(String key, object ob)
            {
                if(parameter.ContainsKey(key))
            {
                parameter[key] = ob; 
            }
            else
            {
                Console.WriteLine(string.Format("Key: {0} value: {1}", key, ob));
                parameter.Add(key, ob);
            }
               
            
            }
        }
  }
