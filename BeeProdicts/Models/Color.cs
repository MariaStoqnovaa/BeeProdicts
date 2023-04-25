namespace BeeProdicts.Models
{
    public class Color
    {
        public Color()
        {
            
        }
        public Color(int ColorID, string ColorName)
        {
            this.ColorID = ColorID;
            this.ColorName = ColorName;
        }
        public int ColorID { get; set; }
        public string ColorName { get; set; }
    }
}
