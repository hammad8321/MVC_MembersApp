namespace MemberApp_MVC.Models
{
    public class Member
    {
       public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public string Document { get; set; }

        public string Date { get; set; }

        public int DaysToExpire { get; set; }
    }
    //     /member/overview

}
