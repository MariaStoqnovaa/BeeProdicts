namespace BeeProdicts.Models
{
    public class Finish
    {
        public Finish()
        {
            
        }
        public Finish(int FinishID, string FinishName)
        {
            this.FinishID = FinishID;
            this.FinishName = FinishName;
        }
        public int FinishID { get; set; }
        public string FinishName { get; set; }
    }
}
