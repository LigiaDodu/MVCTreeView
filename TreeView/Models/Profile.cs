namespace TreeView.Models
{
    public class Profile
    {
        public int Id { get; set; }
        public string Name { get; set; }


        public Profile(int id, string name)
        {
            Id = id;
            Name = name;

        }

       

    }
}