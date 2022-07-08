using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    
    public class Skill: BaseEntity
    {
        public Skill()
        {
        }

        public Skill(string skillTitle, SkillLevel skillLevel, Person user)
        {
            SkillTitle = skillTitle;
            SkillLevel = skillLevel;
            User = user;
        }

        public string SkillTitle { get; set; }
        public SkillLevel SkillLevel { get; set; }
       
        //public DefaultSkills?  DefaultMappedSkill{ get; set; }
        public Person User { get; set; }



    }
    public enum SkillLevel
    {
        Novice,AdvancedBeginner,Competent,Proficient,Expert
    }
}
