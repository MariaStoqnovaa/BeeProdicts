namespace BeeProdicts.Models
{
    public class Size
    {
        public Size()
        {
            
        }
        public Size(int SizeID, string SizeName)
        {
            this.SizeID = SizeID;
            this.SizeName = SizeName;
        }
        public int SizeID { get; set; }
        public string SizeName { get; set; }

       
    }
}
