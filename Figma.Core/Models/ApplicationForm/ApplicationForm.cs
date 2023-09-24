using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figma.Core.Models
{
    public class ApplicationForm
    {
        public int Id { get; set; }
        public byte[] Cover { get; set; }
        public int PersonalInfoId { get; set; }
        public virtual PersonalInfo PersonalInfo { get; set; } = default!;
        public int ProfileId { get; set; }
        public virtual Profile Profile { get; set; } = default!;
    }
}
