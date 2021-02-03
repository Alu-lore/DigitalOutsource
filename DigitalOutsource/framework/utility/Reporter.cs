using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalOutsource.framework.utility
{
    public class Reporter
    {
        private static Dictionary<String, object> Report = new Dictionary<string, object>();

        public static T GetStepPassed<T>(String key)
        {
            var value = (dynamic)null;
            try
            {
                value = Convert.ChangeType(Report[key], typeof(T));
            }
            catch (Exception e)
            {

                value = default(T);
            }
            return value;
        }
        public static void SetStepPassed(String key, object ob)
        {
            Report.Add(key, ob);
        }

        public static void Clear()
        {
            Report.Clear();
        }
    }
}
