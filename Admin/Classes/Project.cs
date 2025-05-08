namespace FatiIkhlassYoun.Admin.Classes
{
    internal class Project
    {
        public int ProjectID { get; internal set; }
        public string Title { get; internal set; }
        public DateTime StartDate { get; internal set; }
        public DateTime EndDate { get; internal set; }
        public string Description { get; internal set; }
        public int ManagerID { get; internal set; }
    }
}