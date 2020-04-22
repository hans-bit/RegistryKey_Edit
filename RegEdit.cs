using System;
using Microsoft.Win32;
using System.Collections.Generic;
using System.Security.Permissions;

namespace registry_edit
{
    public abstract class RegEdit
    {//c#的注册表项删除比较奇葩,没有删除本身的api,只能通过父目录的对象删除子目录的对象.

        public static Dictionary<string, RegistryKey> reg_Item = new Dictionary<string, RegistryKey> {
            {"HKEY_CLASSES_ROOT", Registry.ClassesRoot },
            {"HKEY_CURRENT_CONFIG", Registry.CurrentConfig },
            {"HKEY_CURRENT_USER", Registry.CurrentUser },
            {"HKEY_LOCAL_MACHINE", Registry.LocalMachine },
            {"HKEY_PERFORMANCE_DATA", Registry.PerformanceData },
            {"HKEY_USERS", Registry.Users }
        };


        public static RegistryKey Reg_edit(string path, bool write_or_read)
        {//返回此注册表路径对应的对象,参数二为返回的对象是否可写
            string[] sub_path = path.Split(new string[] { "\\" }, StringSplitOptions.RemoveEmptyEntries);
            RegistryKey tmp;
            try
            {
                tmp = reg_Item[sub_path[0]];
                for (int i = 1; i < sub_path.Length; i++)
                {
                    tmp = tmp.OpenSubKey(sub_path[i], write_or_read);
                }
                return tmp;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }

        }

        public static List<RegistryKey> Context_meun(RegistryKey reg_key, string[] name)
        {//检索指定注册表对象 的 所有下一级目录对象的键名 中 是否含有参数二指定的字符串键名之一,若有则返回含有此键的注册表项的集合列表.
         //参数一是待检索的注册表对象
         //参数二是待检索的特征键集合
            
            string[] sub_key = reg_key.GetSubKeyNames();
            string[] sub_key_value_name;
            List<RegistryKey> context = new List<RegistryKey>();
            RegistryKey tmp;
            foreach (string i in sub_key)
            {
                tmp = reg_key.OpenSubKey(i);
                sub_key_value_name = tmp.GetValueNames();
                foreach(string n in name)
                {
                    if (Array.IndexOf(sub_key_value_name, n) != -1)
                    {
                        context.Add(tmp);
                        break;
                    }
                }

            }
            return context;
        }

        public static bool MyDeleteSubKeyTree(RegistryKey tmp) {//返回真则删除成功,返回假则删除失败
            string[] head = tmp.ToString().Split(new char[] { '\\' }, StringSplitOptions.RemoveEmptyEntries);
            RegistryKey Reg_Base = reg_Item[head[0]];
            string Path = tmp.ToString().Replace(head[0] + '\\', "");
            try
            {
                Reg_Base.DeleteSubKeyTree(Path, false);//如无法删除,也不显示异常
                return true;
            }
            catch (Exception) {
                return false;
            }
        }
    }
}