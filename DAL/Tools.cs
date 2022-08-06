namespace DAL
{
    public class Tools<T> where T : class
    {
        public static bool CheckListExist(List<T> outer, List<T> inner)
        {
            foreach (var item in inner)
            {
                if (!outer.Contains(item))
                {
                    return false;
                }
            }
            return true;
        }
        public static List<T> FindCommon(List<List<T>> lists)
        {
            var common = new List<T>();
            common.AddRange(lists.ElementAt(0));
            lists.RemoveAt(0);
            foreach (var list in lists)
            {
                foreach (var item in common)
                {
                    if (!list.Contains(item))
                    {
                        common.Remove(item as T);
                    }
                }
                if (common.Count == 0)
                {
                    common = null;
                    break;
                }
            }
            return common;


        }
        
    }


}
