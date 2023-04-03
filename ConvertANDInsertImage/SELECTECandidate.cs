using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertANDInsertImage
{
    [Table("SELECTECandidate")]
    public class SELECTECandidate
    {
        public int Roll { get; set; }
        public int ApplicantionId { get; set; }
        public int Name { get; set; }
    }
}
