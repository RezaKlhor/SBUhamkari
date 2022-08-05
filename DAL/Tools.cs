namespace DAL
{
    public class Tools<T> where T : class
    {
        public bool checkListExist(List<T> outer, List<T> inner)
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
    }


}
