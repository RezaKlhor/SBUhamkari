namespace Models.Models
{

    public class Skill : BaseEntity
    {
        public Skill()
        {
        }

        public Skill(string skillTitle, SkillLevel skillLevel, Person person)
        {
            SkillTitle = skillTitle;
            SkillLevel = skillLevel;
            Person = person;
        }

        public string SkillTitle { get; set; }
        public SkillLevel SkillLevel { get; set; }

        //public DefaultSkills?  DefaultMappedSkill{ get; set; }
        public Person Person { get; set; }



    }
    public enum SkillLevel
    {
        Novice, AdvancedBeginner, Competent, Proficient, Expert
    }
}
