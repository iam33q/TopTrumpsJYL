
namespace WEEK7.Models
{
	public class CardAttribute
    {
        public string   name    { get; set; }
        public string   value   { get; set; }
        public int      rank    { get; set; }


        //Constructors:
        CardAttribute()
        {
            name = "default;";
            value = "0";
            rank = 0;
        }

        CardAttribute(string value, int rank)
        {
            name = "default;";
            this.value = value;
            this.rank = rank;
        }

        public CardAttribute(string name, string value)
        {
            this.name = name;
            this.value = value;
        }

        CardAttribute(string name, string value, int rank)
        {
            this.name = name;
            this.value = value;
            this.rank = rank;
        }
    }


}
