namespace SimpleForum.Models.ViewModels
{
    public class DetailForumViewModel
    {
        public Forum Forum { get; set; }
        public List<Contribution>? Contribution { get; set; }
        public Contribution NewContribution { get; set; }        
    }
}
