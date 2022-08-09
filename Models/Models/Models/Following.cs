namespace Models.Models
{
    public class Following : BaseEntity
    {



        public User Follower { get; set; }


        public Guid FollowedID { get; set; }
    }
}
