namespace Chapter01
{
    public class Question01
    {
        public bool IsUniqueAscii(string input)
        {
            if (input.Length > 256) return false;

            var isSet = new bool[256];
            foreach(var c in input)
            {
                var index = (int) c;
                if (isSet[index]) return false;
                isSet[index] = true;
            }
            return true;
        }
    }
}
