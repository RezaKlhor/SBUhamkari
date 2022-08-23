using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Models;
                

namespace DTO.ProjectDtos
{
    public record ProjectFilterDto
    {
        public List<Guid> WorkFieldsId { get; set; }
        public ProjectStateFilter ProjectState { get; set; }
        public string ManagerRole { get; set; }
        public NeedState? NeedState { get; set; }
       
    }
   public enum NeedState { NEED,DONTNEED,DONTCARE}
    public enum ProjectStateFilter { Ongoing, Ended,DONTCARE}
}
